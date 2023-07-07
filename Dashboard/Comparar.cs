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
        public void cargarDatos()
        {
            Conexion.Open();
            cmd = new SqlCommand("SELECT id_empresa, emp_nombre FROM Empresa",Conexion);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Selecciona una empresa";
            dt.Rows.InsertAt(fila, 0);

            //se guarda el resultado en en combobox
            comboBoxEmp1.ValueMember = "id_empresa";
            comboBoxEmp1.DisplayMember = "emp_nombre";
            comboBoxEmp1.DataSource = dataAdapter;
        }

        private void comboBoxEmp1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
