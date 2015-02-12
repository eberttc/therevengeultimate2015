using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TheRevenge.Data.Dominio
{
    [DataContract]
    public class ReservaCita
    {
        [DataMember(IsRequired = false)]
        public int IdReserva { get; set; }
        [DataMember]
        public DateTime FechaReservaCita { get; set; }
        [DataMember]
        public int Especialidad { get; set; }
        [DataMember]
        public int Medico { get; set; }
        [DataMember]
        public int Paciente { get; set; }
        [DataMember]
        public int Horario { get; set; }
        [DataMember]
        public int Estado { get; set; }
    }
}
