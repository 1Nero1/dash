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
using System.Collections;

namespace Dashboard
{
    public partial class Form1 : Form
    {   
        //Conexion
        SqlConnection Conexion = new SqlConnection("Server=(local); DataBase=Dashboard; integrated Security= true");
        SqlCommand cmd;
        SqlDataReader dr;

        //Valores
        ArrayList empresas = new ArrayList();
        ArrayList ventas = new ArrayList();
        ArrayList productos = new ArrayList();
        ArrayList fecha = new ArrayList();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graficaTopProductos();
            graficaTopEmpresas();
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

        private void btn_Comparar_Click(object sender, EventArgs e)
        {
            Form formComparar = new Comparar();
            formComparar.Show();
        }

        private void getDetallesVentas()
        {
            SqlDataAdapter bd = new SqlDataAdapter("SP_detallesVentas", Conexion);
            bd.SelectCommand.CommandType = CommandType.StoredProcedure;
            bd.SelectCommand.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = date_ini.Text;
            bd.SelectCommand.Parameters.Add("@fechaReciente", SqlDbType.DateTime).Value = date_reciente.Text;
            DataTable dt = new DataTable();
            bd.Fill(dt);
            this.dataGrid_prod_vendidos.DataSource = dt;
        }

        private void btn_dia_Click(object sender, EventArgs e)
        {
            getDetallesVentas();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void graficaTopEmpresas()
        {
            cmd = new SqlCommand("SP_VentasXEmpresa", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                empresas.Add(dr.GetString(0));
                ventas.Add(dr.GetInt32(1));
            }
            charComparativa.Series[0].Points.DataBindXY(empresas, ventas);
            dr.Close();
            Conexion.Close();
        }

        private void graficaTopProductos()
        {
            cmd = new SqlCommand("SP_productosMasVendidosHastaHoy", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                productos.Add(dr.GetString(0));
                fecha.Add(dr.GetInt32(1));
            }
            chartTopVentas.Series[0].Points.DataBindXY(productos, fecha);
            dr.Close();
            Conexion.Close();
        }

        private void chartTopVentas_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Form registrar = new registrar();
            //registrar.Show();
        }
    }
}
