using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Runtime.Serialization;
using System.Collections;


namespace TheRevenge.Data.Dominio
{
    [DataContract]
    public class Tipo_Documento
    {
        [DataMember (IsRequired=false)]
        public int ID_Tipo_Doc { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}
