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
            InitializeComponent();
            this.repo = new RepositoryHospitales();
        }

        private async void LoadHospitales()
        {
            List<Hospital> hospiales = 
                await this.repo.GetHospitalesAsync();

        }
    }
}
