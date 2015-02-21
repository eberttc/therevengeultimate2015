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
        [DataMember ( IsRequired = false )]
        public int IdCita { get; set; }      
        [DataMember]
        public String FecReserva { get; set; }
        [DataMember (IsRequired = false)]
        public String FecAtencion { get; set; }
        [DataMember (IsRequired = false)]
        public String Diagnostico { get; set; }
        [DataMember(IsRequired = false)]
        public String Observacion { get; set; }
        [DataMember]
        public int IdEspecialidad { get; set; }
        [DataMember]
        public int IdPaciente { get; set; }
        [DataMember]
        public int IdEstado { get; set; }
        [DataMember]
        public int IdMedico { get; set; }
        [DataMember]
        public int IdHorario { get; set; }
    }
}
