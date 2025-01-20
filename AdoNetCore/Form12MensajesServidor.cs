using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetCore
{
    public partial class Form12MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form12MensajesServidor()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadDepartamentos();
        }

        public async Task LoadDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstDepartamentos.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string dept_no = this.reader["DEPT_NO"].ToString();
                string dnombre = this.reader["DNOMBRE"].ToString();
                string loc = this.reader["LOC"].ToString();
                this.lstDepartamentos.Items.Add(dept_no + " - " + dnombre + " " + loc);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        public async Task InsertDepartamento
            (string dept_no, string dnombre, string loc)
        {
            string sql = "INSERT_DEPARTAMENTO";
            this.com.Parameters.AddWithValue("@numero", dept_no);
            this.com.Parameters.AddWithValue("@nombre", dnombre);
            this.com.Parameters.AddWithValue("@localidad", loc);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.reader.CloseAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            string dept_no = this.txtNumero.Text;
            string dnombre = this.txtNombre.Text;
            string loc = this.txtLocalidad.Text;
            await InsertDepartamento(dept_no, dnombre, loc);
            await this.LoadDepartamentos();
        }
    }
}
