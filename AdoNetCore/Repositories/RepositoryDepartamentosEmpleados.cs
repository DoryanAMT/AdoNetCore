using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AdoNetCore.Repositories
{
    internal class RepositoryDepartamentosEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryDepartamentosEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = "select DNOMBRE from DEPT";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<string> departamentos = new List<string>();

            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                departamentos.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        public async Task<List<string>> GetEmpleadosDepartamentoAsync
            (string nombreDepartamento)
        {
            string sql = "select APELLIDO from EMP " +
                "inner join DEPT " +
                "on EMP.DEPT_NO = DEPT.DEPT_NO " +
                "WHERE DNOMBRE = @nombredepartamento";
            SqlParameter pamNombreDepartamento =
                new SqlParameter("@nombredepartamento", nombreDepartamento);
            this.com.Parameters.Add(pamNombreDepartamento);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<String> empleados = new List<String>();
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

        public async Task DeleteEmpleadoAsync
            (string apellido)
        {
            string sql = "delete from EMP where APELLIDO=@apellido";
            SqlParameter pamApellido =
                new SqlParameter("@apellido",apellido);
            this.com.Parameters.Add(pamApellido);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

        }
    }
}
