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
    public partial class Form05UpdateSalas : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form05UpdateSalas()
        {
            InitializeComponent();
            CargarSalas();


        }

        private async void CargarSalas()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            string sql = "select distinct NOMBRE from SALA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstSalas.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.lstSalas.Items.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private async void btnModificarSala_Click(object sender, EventArgs e)
        {
            
            string sql =
                "update SALA set NOMBRE =@nuevonombre where NOMBRE=@antiguonombre";
            string nuevoNombre = this.txtNuevaSala.Text;
            string antiguoNombre = this.lstSalas.SelectedItem.ToString();
            SqlParameter paramOld =
                new SqlParameter("@antiguonombre", antiguoNombre);
            this.com.Parameters.Add(paramOld);
            SqlParameter paramNew=
                new SqlParameter("@nuevonombre", nuevoNombre);
            this.com.Parameters.Add(paramNew);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int afectados =
                await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            this.CargarSalas();
            MessageBox.Show("Salas modificadas "+ afectados);

        }

        private void lstSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtNuevaSala.Text = this.lstSalas.SelectedItem.ToString();
        }
    }
}
