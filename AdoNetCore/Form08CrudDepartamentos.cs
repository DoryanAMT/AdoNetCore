using AdoNetCore.Models;
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

    public partial class Form08CrudDepartamentos : Form
    {
        RepositoryDepartamentos repo;
        public Form08CrudDepartamentos()
        {
            this.repo = new RepositoryDepartamentos();
            InitializeComponent();
            this.LoadDepartamentos();
        }

        private async void LoadDepartamentos()
        {
            List<Departamento> departamentos =
                await this.repo.GetDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (Departamento dept in departamentos)
            {
                this.lstDepartamentos.Items.Add(dept.idDepartamento
                + " - " + dept.Nombre + " - " + dept.Localidad);
            }

        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localiad = this.txtLocalidad.Text;
            await this.repo.UpdateDepartamentoAsync(id, nombre, localiad);
            this.LoadDepartamentos();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            await this.repo.deleteDepartamentoAsync(id);
            this.LoadDepartamentos();
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            await this.repo.InsertDepartamentoAsync(id, nombre, localidad);
            this.LoadDepartamentos();

        }
    }
}
