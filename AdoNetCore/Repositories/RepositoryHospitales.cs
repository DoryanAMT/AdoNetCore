using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using AdoNetCore.Models;

namespace AdoNetCore.Repositories
{
    public class RepositoryHospitales
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryHospitales()
        {
            string connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task <List<Hospital>> GetHospitalesAsync()
        {
            string sql = "select * from HOSPITAL";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Hospital> hospitales = new List<Hospital>();
            while (await this.reader.ReadAsync())
            {
                int id = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                string nombre = this.reader["NOMBRE"].ToString();
                string direccion = this.reader["DIRECCION"].ToString();
                string telefono = this.reader["TELEFONO"].ToString();
                int numCamas = int.Parse(this.reader["NUM_CAMA"].ToString());
                Hospital hospital = new Hospital();
                hospital.IdHospital = id;
                hospital.Nombre = nombre;
                hospital.Direccion = direccion;
                hospital.Telefono = telefono;
                hospital.NumCama = numCamas;
                hospitales.Add(hospital);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return hospitales;
        }

        public async Task InsertHospitalesAsync
            (int id, string nombre, string direccion, string telefono, int numCamas)
        {
            string sql = "insert into HOSPITAL values(@id, @nombre, @direccion, @telefono, @numcamas)";
            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@direccion", direccion);
            this.com.Parameters.AddWithValue("@telefono", telefono);
            this.com.Parameters.AddWithValue("@numcamas", numCamas);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task DeleteDepartamentoAsync
            (int id)
        {
            string sql = "delete from HOSPITAL where HOSPITAL_COD=@id";
            this.com.Parameters.AddWithValue("@id", id);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

    }
}
