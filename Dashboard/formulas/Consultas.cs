using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Dashboard.formulas
{
    public  class Consultas
    {
        internal object mostrarTablaEmp;
        SqlConnection Conexion = new SqlConnection("Server=(local); DataBase=Dashboard; integrated Security= true");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable tb = new DataTable();
        SqlDataReader leer;

        public DataTable tbEmpresa()
        {
            Conexion.Open();
            cmd.CommandText = "SELECT * FORM Empresa";
            leer = cmd.ExecuteReader();
            tb.Load(leer);
            Conexion.Close();
            return tb;
        }

    }
}
