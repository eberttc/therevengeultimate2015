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
        [DataMember]
        public int Id_Horario { get; set; }
        [DataMember]
        public string Val_Hor { get; set; }
    }
}
