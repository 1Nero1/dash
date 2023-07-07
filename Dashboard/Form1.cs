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
using Dashboard.BD;

namespace Dashboard
{
    public partial class Form1 : Form
    {   
        //Conecion
        SqlConnection Conexion = new SqlConnection("Server=(local); DataBase=Dashboard; integrated Security= true");
        SqlCommand cmd;
        SqlConnection dr;


        public Form1()
        {
            InitializeComponent();
        }

        //Metodo para la gafica 
        private void graficaCategorias()
        {
            cmd = new SqlCommand("SP_ProductosMasVendidos", Conexion);
            cmd.Parameters.AddWithValue("@fechaInicio", date_ini.Text.ToString());
            Console.WriteLine(date_ini);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //var fechaInicial = date_ini.Value;
            //Console.WriteLine(fechaInicial.ToString());
        }

        private void lab_dateIni_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            getTop5Productos();
        }

        private void date_act_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid_prod_vendidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Metodos privados
        private void getTop5Productos()
        {
            SqlDataAdapter bd = new SqlDataAdapter("SP_ProductosMasVendidos", Conexion);
            bd.SelectCommand.CommandType = CommandType.StoredProcedure;
            bd.SelectCommand.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = date_ini.Text;
            bd.SelectCommand.Parameters.Add("@fechaReciente", SqlDbType.DateTime).Value = date_reciente.Text;
            DataTable dt = new DataTable();
            bd.Fill(dt);
            this.dataGrid_prod_vendidos.DataSource = dt;
        }
    }
}
