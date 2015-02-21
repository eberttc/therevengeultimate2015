using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TheRevenge.Data.Dominio
{
    [DataContract]
    public class CitaDescrita
    {
        [DataMember(IsRequired = false)]
        public int IdCita { get; set; }
        [DataMember]
        public String FecReserva { get; set; }
        [DataMember]
        public String FecAtencion { get; set; }
        [DataMember]
        public String Diagnostico { get; set; }
        [DataMember]
        public String Observacion { get; set; }
        [DataMember]
        public String Descripcion { get; set; }
        [DataMember]
        public String Nom_Ape_Pac { get; set; }
        [DataMember]
        public String Val_Estado { get; set; }
        [DataMember]
        public String Nom_Ape_Med { get; set; }
        [DataMember]
        public String Val_Hor { get; set; }
        
    }
}
