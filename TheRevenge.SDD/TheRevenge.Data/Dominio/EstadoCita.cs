using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TheRevenge.Data.Dominio
{
    [DataContract]
    public class EstadoCita
    {
        [DataMember ( IsRequired = false )]
        public int IdEstado { get; set; }
        [DataMember]
        public string ValEstado { get; set; }
    }
}
