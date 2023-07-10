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

        //Globales
        String item;
        String item2;
        String prod;
        public Comparar()
        {
            InitializeComponent();
            cbEmpresa1();
            cbEmpresa2();
            cbProducto();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        //Metodos
        public void cbEmpresa1()
        {
            Conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT id_empresa, emp_nombre FROM Empresa", Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.Close();

            DataRow Fila = dt.NewRow();
            Fila["emp_nombre"] = "Selecciona la Empresa";
            dt.Rows.InsertAt(Fila, 0);

            comboBoxEmp1.ValueMember = "id_empresa";
            comboBoxEmp1.DisplayMember = "emp_nombre";
            comboBoxEmp1.DataSource = dt;
        }

        public void cbEmpresa2()
        {
            Conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT id_empresa, emp_nombre FROM Empresa", Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.Close();

            DataRow Fila = dt.NewRow();
            Fila["emp_nombre"] = "Selecciona la Empresa";
            dt.Rows.InsertAt(Fila, 0);

            comboBoxEmp2.ValueMember = "id_empresa";
            comboBoxEmp2.DisplayMember = "emp_nombre";
            comboBoxEmp2.DataSource = dt;
        }

        //Tablas
        public void cargarTd1()
        {
            SqlDataAdapter bd = new SqlDataAdapter("SP_detallesVentasEmpresa", Conexion);
            SqlDataReader dr;
            bd.SelectCommand.CommandType = CommandType.StoredProcedure;
            bd.SelectCommand.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = date_ini.Text;
            bd.SelectCommand.Parameters.Add("@fechaReciente", SqlDbType.DateTime).Value = date_reciente.Text;
            bd.SelectCommand.Parameters.Add("@empresa", SqlDbType.VarChar).Value = item;
            DataTable dt = new DataTable();
            bd.Fill(dt);
            this.dataGridView_emp1.DataSource = dt;
        }

        public void cargarTd2()
        {
            SqlDataAdapter bd = new SqlDataAdapter("SP_detallesVentasEmpresa", Conexion);
            SqlDataReader dr;
            bd.SelectCommand.CommandType = CommandType.StoredProcedure;
            bd.SelectCommand.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = date_ini.Text;
            bd.SelectCommand.Parameters.Add("@fechaReciente", SqlDbType.DateTime).Value = date_reciente.Text;
            bd.SelectCommand.Parameters.Add("@empresa", SqlDbType.VarChar).Value = item2;
            DataTable dt = new DataTable();
            bd.Fill(dt);
            this.dataGridView_emp2.DataSource = dt;
        }

        public void cargarProdEmp1()
        {
            SqlDataAdapter bd = new SqlDataAdapter("SP_detallesProductos", Conexion);
            SqlDataReader dr;
            bd.SelectCommand.CommandType = CommandType.StoredProcedure;
            bd.SelectCommand.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = date_ini.Text;
            bd.SelectCommand.Parameters.Add("@fechaReciente", SqlDbType.DateTime).Value = date_reciente.Text;
            bd.SelectCommand.Parameters.Add("@empresa", SqlDbType.VarChar).Value = item;
            bd.SelectCommand.Parameters.Add("@producto", SqlDbType.VarChar).Value = prod;
            DataTable dt = new DataTable();
            bd.Fill(dt);
            this.dataGridView_emp1.DataSource = dt;
        }

        public void cargarProdEmp2()
        {
            SqlDataAdapter bd = new SqlDataAdapter("SP_detallesProductos", Conexion);
            bd.SelectCommand.CommandType = CommandType.StoredProcedure;
            bd.SelectCommand.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = date_ini.Text;
            bd.SelectCommand.Parameters.Add("@fechaReciente", SqlDbType.DateTime).Value = date_reciente.Text;
            bd.SelectCommand.Parameters.Add("@empresa", SqlDbType.VarChar).Value = item2;
            bd.SelectCommand.Parameters.Add("@producto", SqlDbType.VarChar).Value = prod;
            DataTable dt = new DataTable();
            bd.Fill(dt);
            this.dataGridView_emp2.DataSource = dt;
        }

        private void comboBoxEmp1_SelectedIndexChanged(object sender, EventArgs e)
        {
            item = comboBoxEmp1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (item != "Selecciona un producto" || item2 != "Selecciona un producto")
            {
                MessageBox.Show("Puede demorar unos segundos");
                cargarTd1();
                cargarTd2();
            }
            else
            {
                MessageBox.Show("No ha seleccionado una Empresa");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxEmp2_SelectedIndexChanged(object sender, EventArgs e)
        {
            item2 = comboBoxEmp2.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void cbProducto()
        {
            Conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT id_producto, prod_nombre FROM Producto", Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conexion.Close();

            DataRow Fila = dt.NewRow();
            Fila["prod_nombre"] = "Selecciona un producto";
            dt.Rows.InsertAt(Fila, 0);

            cb_prod.ValueMember = "id_producto";
            cb_prod.DisplayMember = "prod_nombre";
            cb_prod.DataSource = dt;
        }

        private void cb_prod_SelectedIndexChanged(object sender, EventArgs e)
        {
            prod = cb_prod.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarProdEmp1();
            cargarProdEmp2();
        }
    }
}
