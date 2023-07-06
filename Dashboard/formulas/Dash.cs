using Dashboard.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.formulas
{
    public class Dash : DbConexion
    {
        public struct tiempo
        {
            public string date { set; get; }
            public decimal total { set; get; }
        }

        //propiedades
        private DateTime inicioFecha;
        private DateTime recienteFecha;
        private int numeroDias;

        //Aqui se guardaran los datos de la DB
        public int numProductos { get; private set; }
        //para la grafica
        public List<KeyValuePair<String, int>> toProductos { get; private set; }
        public List<KeyValuePair<String, int>> Precio { get; private set; }

        public decimal totalIngresos { set; get; }

        //constructor
        public Dash()
        {

        }

        //Metodos privados
        private void getNumberProductos()
        {
            toProductos = new List<KeyValuePair<String, int>>();
            using(var conexion= GetConnection())
            {
                conexion.Open();
                using(var command=new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = @"SELECT TOP 5 P.prod_nombre, SUM(V.cant_compra) as ventas
                                            FROM VENTA V
                                            INNER JOIN Producto P ON V.prod_nombre = P.prod_nombre
                                            WHERE V.date_venta BETWEEN @fechaInicio AND @fechaReciente
                                            GROUP BY P.prod_nombre
                                            ORDER BY ventas desc";
                    command.Parameters.Add("@fechaInicio", System.Data.SqlDbType.DateTime).Value = inicioFecha;
                    command.Parameters.Add("@fechaReciente", System.Data.SqlDbType.DateTime).Value = recienteFecha;
                    //Si produce error cambiar a DATETIME
                    var leer = command.ExecuteReader();
                    while (leer.Read())
                    {
                        toProductos.Add(new KeyValuePair<String, int>(leer[0].ToString(), (int)leer[1]));
                    }
                    leer.Close();
                }
            }
        }

        //Metodos public
        public bool crearFecha(DateTime inicioFecha, DateTime recienteFecha)
        {
            recienteFecha = new DateTime(recienteFecha.Year, recienteFecha.Month,
                recienteFecha.Day, recienteFecha.Hour, recienteFecha.Minute,
                59); // Realiza la actualizacion cuando se cumpla el minuto

            if (inicioFecha != this.inicioFecha || recienteFecha != this.recienteFecha)
            {
                this.inicioFecha = inicioFecha;
                this.recienteFecha = recienteFecha;
                this.numeroDias = (inicioFecha - recienteFecha).Days;

                getNumberProductos();

                return true;
            }
            else 
            {
                Console.WriteLine("Sin refrescar pagina");
                return false; 
            }
        }
    }
}
