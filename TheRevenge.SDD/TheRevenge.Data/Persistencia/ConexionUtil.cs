using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheRevenge.Data.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            //return @"Data Source=ELIZABETH-PC\SQLEXPRESS; Initial Catalog=EYEsuite;Integrated Security=SSPI";
            return "Data Source=EYESuite.mssql.somee.com; Initial Catalog=EYESuite;user id=therevenge_SQLLogin_1;pwd=2jz7h6vo98";
        }

    }
}