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
            //return "Data Source=E53-018; Initial Catalog=EYEsuite;user id=devsoft_SQLLogin_1;pwd=p@samosSIOSI";
            return "Data Source=E53-018; Initial Catalog=EYEsuite;Integrated Security=SSPI";
        }

    }
}