using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TheRevenge.Data.Dominio
{
    [DataContract]
    public class Observacion
    {
        [DataMember]
        public int CodigoError { get; set; }
        [DataMember]
        public string MensajeError { get; set; }
    }
}
