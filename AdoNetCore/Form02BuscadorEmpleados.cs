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
    public partial class Form02BuscadorEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        string connectionString;
        public Form02BuscadorEmpleados()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        private void btnBuscadorEmpleados_Click(object sender, EventArgs e)
        {
            string salario = this.txtSalario.Text;
            string sql =
                "select * from EMP where salario >= " + salario;
            //CONEXION
            this.com.Connection = this.cn;
            //  TIPO DE CONSULTA
            this.com.CommandType = CommandType.Text;
            //  LA CONSULTA
            this.com.CommandText = sql;
            //  ABRIMOS LA CONEXION
            //  ENTRAR Y SALIR
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            //  DIBUJAMOS LOS DATOS
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string ape = this.reader["APELLIDO"].ToString();
                string sal = this.reader["SALARIO"].ToString();
                this.lstEmpleados.Items.Add(ape + " - " + sal);
            }

            //  LIBERAMOS TODOS LOS RECURSOS UTILIZADOS
            //  SALIR
            this.reader.Close();
            this.cn.Close();
        }

        private void btnBuscadorOficio_Click(object sender, EventArgs e)
        {
            string oficio = this.txtOficio.Text;
            string sql =
                "select * from EMP where oficio ='" + oficio+"'";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string ape = this.reader["APELLIDO"].ToString();
                string ofi = this.reader["OFICIO"].ToString();
                this.lstEmpleados.Items.Add(ape + " - " + ofi);
            }

            this.reader.Close();
            this.cn.Close();
        }
    }
}
