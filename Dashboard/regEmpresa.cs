using Dashboard.formulas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dashboard

{
    public partial class regEmpresa : Form
    {
        SqlConnection Conexion = new SqlConnection("Server=(local); DataBase=Dashboard; integrated Security= true");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable tb = new DataTable();
        SqlDataReader leer;


        public regEmpresa()
        {
            InitializeComponent();
            mostrarTablaEmp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingresarEmp();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mostrarTablaEmp()
        {
            Conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Empresa", Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.Close();

            dataGridView1.DataSource = dt;
        }

        private void ingresarEmp()
        {
            Conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_detallesProductos", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emp_nombre", empNombre.Text);
            cmd.Parameters.AddWithValue("@emp_ciudad", textCiudad.Text);
            cmd.Parameters.AddWithValue("@emp_estado", textEstado.Text);
            cmd.Parameters.AddWithValue("@emp_zona", textZona.Text);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
    }
}
