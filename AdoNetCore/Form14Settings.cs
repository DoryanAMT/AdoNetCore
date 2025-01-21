using Microsoft.Extensions.Configuration;
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
    public partial class Form14Settings : Form
    {
        public Form14Settings()
        {
            InitializeComponent();
        }

        private void btnLeerSettings_Click(object sender, EventArgs e)
        {
            //  NECESITAMOS UN CONSTRUCTOR DE CONFIGURACIONES
            ConfigurationBuilder builder = new ConfigurationBuilder();
            //  EN ESTE ENTORNO NO ES NATIVO, POR LO QUE DEBEMOS
            //  INDICAR DE FORMA EXPLICITA EL NOMBRE DEL FICHERO
            //  SU UBICACION
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);
            //  EL OBJETO PARA RECUPERAR LAS KEYS
            IConfigurationRoot configuration = builder.Build();
            //  EXISTE CLAVES QUE YA VIENEN POR DEFECTO: ConnectionString
            string connectionString = configuration.GetConnectionString("SqlTajamar");
            this.lblCadenaConexion.Text = connectionString;
            //  SI NO ES UNA ZONA CONOZIDA COMO Imagenes/colores
            //  LOS DATOS SE RECUPERAN EN CASCADA CON CADA key/subkey
            string imagen1 =
                configuration.GetSection("Imagenes:imagen1").Value;
            string imagen2 =
                configuration.GetSection("Imagenes:imagen2").Value;
            string colorFondo =
                configuration.GetSection("Colores:fondo").Value;
            string colorLetra =
                configuration.GetSection("Colores:letra").Value;

            this.pictureBox1.Load(imagen1);
            this.pictureBox2.Load(imagen2);
            this.btnLeerSettings.BackColor =
                Color.FromName(colorFondo);
            this.btnLeerSettings.ForeColor =
                Color.FromName(colorLetra);
        }

    }
}
