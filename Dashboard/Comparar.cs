using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Comparar : Form
    {
        //Conexion
        SqlConnection Conexion = new SqlConnection("Server=(local); DataBase=Dashboard; integrated Security= true");
        SqlCommand cmd;
        SqlConnection dr;
        SqlDataReader leerFilas;
        public Comparar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        //Metodos
        public DataTable cargarDatos()
        {
            SqlDataAdapter bd = new SqlDataAdapter("SP_listaEmpresas", Conexion);
            bd.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            bd.Fill(dt);
            return dt;
        }

        private void comboBoxEmp1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatos();
            

        }
    }
}
