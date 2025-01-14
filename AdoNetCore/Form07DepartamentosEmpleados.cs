using AdoNetCore.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetCore
{
    public partial class Form07DepartamentosEmpleados : Form
    {
        RepositoryDepartamentosEmpleados repo;
        public Form07DepartamentosEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentosEmpleados();
            this.LoadDepartamentos();
        }

        private async void LoadDepartamentos()
        {
            List<string> departamentos =
                await this.repo.GetDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (string nombre in departamentos)
            {
                this.lstDepartamentos.Items.Add(nombre);
            }
        }

        private async void LoadEmpleados()
        {
            string departamentoSeleccionado =
                this.lstDepartamentos.SelectedItem.ToString();
            List<string> empleados =
                await this.repo.GetEmpleadosDepartamentoAsync(departamentoSeleccionado);
            this.lstEmpleados.Items.Clear();
            foreach (string nombre in empleados)
            {
                this.lstEmpleados.Items.Add(nombre);
            }
        }



        private async void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            string apellido =
                this.lstEmpleados.SelectedItem.ToString();
            await this.repo.DeleteEmpleadoAsync(apellido);
            this.LoadEmpleados();

        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadEmpleados();
        }
    }
}
