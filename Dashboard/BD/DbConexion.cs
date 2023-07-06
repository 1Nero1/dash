using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.BD
{
    public abstract class DbConexion
    {
        private readonly string conecionString;

        public DbConexion()
        {
            conecionString = "Server=(local); DataBase=Dashboard; integrated Security= true";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(conecionString);
        }
    }
}
