using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRevenge.Data.Dominio
{
    public class AtencionCita
    {
        public int IdCita { get; set; }
        public DateTime FechaAtencion { get; set; }
        public string Diagnostico { get; set; }
        public string Observaciones { get; set; }
    }
}
