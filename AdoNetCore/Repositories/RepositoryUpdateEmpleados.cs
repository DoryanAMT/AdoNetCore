using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCore.Models;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositoryUpdateEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryUpdateEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<String>> GetOficiosAsync()
        {
            string sql = "select distinct OFICIO from EMP";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> oficios = new List<string>();

            while (await this.reader.ReadAsync())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficios.Add(oficio);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return oficios;
        }

        public async Task<List<string>> GetEmpleadosOficiosAsync
            (string oficio)
        {
            string sql = "select * from EMP where OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@oficio",oficio);
            this.com.CommandType= System.Data.CommandType.Text;
            this.com.CommandText= sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> empleados = new List<string>();

            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                empleados.Add(apellido);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleados;
        }

        public async Task <int> UpdateSalarioEmpleadoOficio
            (string oldOficio, string newOficio, int incremento)
        {
            string sql = "update EMP set SALARIO=SALARIO+@incremento, " +
                "oficio=@newoficio" +
                "where OFICIO=@oldoficio";
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.Parameters.AddWithValue("@oldoficio", oldOficio);
            this.com.Parameters.AddWithValue("@newoficio", newOficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int afectados = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return afectados;
        }

        public async Task <List<string>> GetCalculosOficio
            (string oficio)
        {
            string sql
                = "select sum(SALARIO) as SUMSALARIO, avg(SALARIO) as MEDSALARIO, min(SALARIO) as MINSALARIO from EMP where OFICIO = @oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType= System.Data.CommandType.Text;
            this.com.CommandText= sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> resultados = new List<string>();
            if (await this.reader.ReadAsync())
            {
                resultados.Add(this.reader["SUMSALARIO"].ToString());
                resultados.Add(this.reader["MEDSALARIO"].ToString());
                resultados.Add(this.reader["MINSALARIO"].ToString());
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return resultados;
        }
        
        public async Task<DatosEmpleadosOficio> GetDatosEmpleadosOficiosAsync
            (string oficio)
        {
            string sql = "select sum(SALARIO) as SUMASALARIAL, " +
                "avg(SALARIO) as MEDIASALARIAL, " +
                "min(SALARIO) as MAXIMOSALARIO " +
                "from EMP where OFICIO = @oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            DatosEmpleadosOficio datos = new DatosEmpleadosOficio();
            await this.reader.ReadAsync();
            datos.SumaSalarial =
                int.Parse(this.reader["SUMASALARIAL"].ToString());
            datos.MediaSalarial =
                int.Parse(this.reader["MEDIASALARIAL"].ToString());
            datos.MaximoSalario =
                int.Parse(this.reader["MAXIMOSALARIO"].ToString());
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return datos;
        }
    }
}
