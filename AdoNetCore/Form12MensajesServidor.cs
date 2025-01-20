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
using System.Diagnostics.Metrics;

#region
//alter procedure SP_ALL_DEPARTAMENTOS
//as
//	select DEPT_NO, DNOMBRE, LOC from DEPARTAMENTOS
//go

//alter procedure INSERT_DEPARTAMENTO(@numero as int, @nombre as nvarchar(50), @localidad as nvarchar(50))
//as
//	if(@localidad = 'TERUEL')
//	begin
//		print 'TERUEL NO EXISTE'
//	end
//	else
//	begin
//		insert into DEPARTAMENTOS values(@numero, @nombre, @localidad)
//	end
//go
#endregion

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

            // RECUPERAMOS EL EVENTO DE MENSAJES DE LA CONEXION
            this.cn.InfoMessage += Cn_InfoMessage;


            //this.LoadDepartamentos();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblMensaje.Text = e.Message;
        }

        //public async Task LoadDepartamentos()
        //{
        //    this.lblMensaje.Text = "";
        //    string sql = "SP_ALL_DEPARTAMENTOS";
        //    this.com.CommandType = CommandType.StoredProcedure;
        //    this.com.CommandText = sql;
        //    await this.cn.OpenAsync();
        //    this.reader = await this.com.ExecuteReaderAsync();
        //    this.lstDepartamentos.Items.Clear();
        //    while (await this.reader.ReadAsync())
        //    {
        //        string dept_no = this.reader["DEPT_NO"].ToString();
        //        string dnombre = this.reader["DNOMBRE"].ToString();
        //        string loc = this.reader["LOC"].ToString();
        //        this.lstDepartamentos.Items.Add(dept_no + " - " + dnombre + " " + loc);
        //    }

        //    await this.reader.CloseAsync();
        //    await this.cn.CloseAsync();
        //}

        public void InsertDepartamento
            (int dept_no, string dnombre, string loc)
        {
            string sql = "INSERT_DEPARTAMENTO";
            this.com.Parameters.AddWithValue("@numero", dept_no);
            this.com.Parameters.AddWithValue("@nombre", dnombre);
            this.com.Parameters.AddWithValue("@localidad", loc);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            this.cn.Open();
            int afectados =  this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            MessageBox.Show("Afectados: " + afectados);
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            this.lblMensaje.Text = "";
            int dept_no = int.Parse(this.txtNumero.Text);
            string dnombre = this.txtNombre.Text;
            string loc = this.txtLocalidad.Text;
            this.InsertDepartamento(dept_no, dnombre, loc);
            //await this.LoadDepartamentos();
        }
    }
}
