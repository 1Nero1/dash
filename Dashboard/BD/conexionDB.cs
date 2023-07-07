using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.BD
{
    internal class conexionDB
    {
        string cadena ="Server=(local); DataBase=Dashboard; integrated Security= true";
        public SqlConnection conexion = new SqlConnection();

        public conexionDB()
        {
            conexion.ConnectionString = cadena;
        }
        public void abrirConexion()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion exitosa");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Se produjo un error en la conexion"+ex.Message);
            }
        }
        public void cerrarConexion()
        {
            conexion.Close();
        }
    }
}
