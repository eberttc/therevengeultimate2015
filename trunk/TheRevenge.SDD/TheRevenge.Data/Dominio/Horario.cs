using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TheRevenge.Data.Dominio
{
    [DataContract]
    public class Horario
    {
        [DataMember ( IsRequired = false)]
        public int IdHorario { get; set; }
        [DataMember]
        public string ValHor { get; set; }
    }
}
