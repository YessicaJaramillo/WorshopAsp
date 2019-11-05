using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Supermercado
{
    public class conexion
    {
        private static SqlConnection conex;

        private conexion()
        {

        }
        public static SqlConnection obtenerConexion()
        {
            if(conex == null)
            {
                conex = new SqlConnection(Properties.Settings.Default.cadena);
                conex.Open();
            }
            return conex;
        }


    }
}