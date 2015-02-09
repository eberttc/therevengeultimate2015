using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TheRevenge.Data.Dominio
{
    [DataContract]
    public class Cita
    {
        [DataMember]
        public int IdCita { get; set; }
        [DataMember]
        public DateTime FechaReserva { get; set; }
        [DataMember]
        public int IdPaciente { get; set; }
        [DataMember]
        public int IdMedico { get; set; }
        [DataMember]
        public int IdHorario { get; set; }
        [DataMember]
        public int IdEstado { get; set; }
        [DataMember]
        public DateTime FechaAtencion { get; set; }
        [DataMember]
        public string Diagnostico { get; set; }
        [DataMember]
        public string Observacion { get; set; }
    }
}
