using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TheRevenge.Data.Dominio
{
    [DataContract]
    public class Especialidad
    {
        [DataMember]
        public int Id_Especialidad { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}
