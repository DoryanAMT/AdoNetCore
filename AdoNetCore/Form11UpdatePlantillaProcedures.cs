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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

# region STORED PROCEDURES
//ALTER procedure[dbo].[SP_UPDATEPLANTILLA_HOSPITAL]
//(@nombre nvarchar(50), @incremento int)
//as
//	declare @hospitalcod int
//	select @hospitalcod = HOSPITAL_COD from HOSPITAL
//	where NOMBRE = @nombre
//	update PLANTILLA set SALARIO = SALARIO + @incremento
//	where HOSPITAL_COD=@hospitalcod
//go
#endregion

namespace AdoNetCore
{
    public partial class Form11UpdatePlantillaProcedures : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form11UpdatePlantillaProcedures()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadHospitales();
        }

        public async void LoadHospitales()
        {
            string sql = "SP_ALL_HOSPITAL";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.cmbHospital.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.cmbHospital.Items.Add(nombre);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }
        private async void cmbHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SP_PLANTILLA_HOSPITAL_NB";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText= sql;
            this.com.Parameters.AddWithValue("@nombre", this.cmbHospital.SelectedItem.ToString());
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstPlantilla.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.lstPlantilla.Items.Add(apellido + " - " + salario);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        private async void btnModificarSalario_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbHospital.SelectedItem.ToString();
            int incremento = int.Parse(this.txtIncremento.Text);
            
            string sql = "SP_UPDATEPLANTILLA_HOSPITAL";
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            //int afectados = await this.com.ExecuteNonQueryAsync();
            int afectados = 0;
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstPlantilla.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                afectados++;
                string apellido = this.reader["APELLIDO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.lstPlantilla.Items.Add(apellido + " - " + salario);
            }
                        
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            MessageBox.Show("Registros afectados: " + afectados);
        }

        }
    }
