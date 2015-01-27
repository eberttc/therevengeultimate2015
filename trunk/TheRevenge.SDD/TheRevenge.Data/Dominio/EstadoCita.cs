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
        [DataMember]
        public int Id_Estado { get; set; }
        [DataMember]
        public string Val_Estado { get; set; }
    }
}
