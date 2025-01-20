using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCore.Models;
using AdoNetCore.Repositories;
using Microsoft.Data.SqlClient;

#region
//create procedure SP_EMPLEADOS_DEPT_OUT
//(@nombre nvarchar(50)
//, @suma int out
//, @media int out
//, @personas int out)
//as
//	declare @id int
//	select @id = DEPT_NO from DEPARTAMENTOS
//	where DNOMBRE = @nombre
//	select * from EMP where DEPT_NO = @id
//	select @suma = sum(SALARIO), @media = AVG(SALARIO), @personas = count(EMP_NO) from EMP
//	where DEPT_NO = @id
//go
#endregion

namespace AdoNetCore
{
    public partial class Form13ParametrosSalida : Form
    {
        RepositoryParametrosOut repo;
        public Form13ParametrosSalida()
        {
            InitializeComponent();
            this.repo = new RepositoryParametrosOut();
            this.LoadDepartamentos();
        }

        public async void LoadDepartamentos()
        {
            List<string> departamentos =
                await this.repo.LoadDepartamentosAsync();
            this.cmbDepartamentos.Items.Clear();
            foreach (string departamento in departamentos)
            {
                this.cmbDepartamentos.Items.Add(departamento);
            }
        }

        public async void LoadEmpleadosDepartamento
            (string nombre)
        {
            EmpleadoDepartamentoOut datos = 
                await this.repo.LoadEmpleadosDepartamento(nombre);
            while (datos.nombre )
            {

            }
            
        }

        

        private async void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string sql = "SP_EMPLEADOS_DEPT_OUT";
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();
            //  PARA LOS PARAMROS DE ENTRADA PODEMOS UTILIZAR
            //  AddWithValue SIN PROBLEMAS
            //  PARA LOS PARAMETROS DE ENTRADA ES IMPRESCINDIBLE
            //  UTILIZAR OBJETOS Parameter
            this.com.Parameters.AddWithValue("@nombre", nombre);
            SqlParameter pamSuma = new SqlParameter();
            pamSuma.ParameterName = "@suma";
            pamSuma.Value = 0;
            //  INDICAMOS LA DIRECCION DEL PARAMETRO
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);
            SqlParameter pamMedia = new SqlParameter();
            pamMedia.ParameterName = "@media";
            pamMedia.Value = 0;
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);
            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.ParameterName = "@personas";
            pamPersonas.Value = 0;
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstEmpleados.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEmpleados.Items.Add(apellido);
            }
            await this.reader.CloseAsync();
            this.txtSumaSalarial.Text = pamSuma.Value.ToString();
            this.txtMediaSalarial.Text = pamMedia.Value.ToString();
            this.txtPersonas.Text = pamPersonas.Value.ToString();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
