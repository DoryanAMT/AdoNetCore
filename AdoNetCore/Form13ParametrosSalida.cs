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
//	select @id = DEPT_NO from DEPT
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
                await this.repo.GetDepartamentosAsync();
            this.cmbDepartamentos.Items.Clear();
            foreach (string departamento in departamentos)
            {
                this.cmbDepartamentos.Items.Add(departamento);
            }
        }

        private async void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();
            EmpleadoDepartamentoOut model =
                await this.repo.GetEmpleadosDepartamentoAsync(nombre);
            this.lstEmpleados.Items.Clear();
            foreach (string ape in model.Apellidos)
            {
                this.lstEmpleados.Items.Add(ape);
            }
            this.txtSumaSalarial.Text = model.SumaSalarial.ToString();
            this.txtMediaSalarial.Text = model.MediaSalarial.ToString();
            this.txtPersonas.Text = model.Personas.ToString();
        }
    }
}
