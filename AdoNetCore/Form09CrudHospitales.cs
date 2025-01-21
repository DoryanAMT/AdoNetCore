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
    public partial class Form09CrudHospitales : Form
    {
        RepositoryHospitales repo;
        public Form09CrudHospitales()
        {
            this.repo = new RepositoryHospitales();
            InitializeComponent();
            this.LoadHospitales();
        }

        private async void LoadHospitales()
        {
            List<Hospital> hospiales =
                await this.repo.GetHospitalesAsync();
            this.lstHospitales.Items.Clear();
            foreach (Hospital hospital in hospiales)
            {
                this.lstHospitales.Items.Add(hospital.IdHospital
                    + " - " + hospital.Nombre + " - " + hospital.Direccion
                    + " - " + hospital.Telefono + " - " + hospital.NumCama);
            }
        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtIdHospital.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int numCamas = int.Parse(this.txtNumCamas.Text);
            await this.repo.InsertHospitalesAsync(id, nombre, direccion, telefono, numCamas);
            this.LoadHospitales();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtIdHospital.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int numCamas = int.Parse(this.txtNumCamas.Text);
            await this.repo.UpdateHospitalAsync(id, nombre, direccion, telefono, numCamas);
            this.LoadHospitales();

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtIdHospital.Text);
            await this.repo.DeleteHospitalAsync(id);
            this.LoadHospitales();
        }
    }
}
