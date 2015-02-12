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
    public class Paciente
    {
        [DataMember]
        public int IdPaciente { get; set; }
        [DataMember]
        public String Nombres { get; set; }
        [DataMember]
        public String Ape_Paterno { get; set; }
        [DataMember]
        public String Ape_Materno { get; set; }
        [DataMember]
        public String Sexo { get; set; }
        [DataMember]
        public int Id_Tipo_Doc { get; set; }
        [DataMember]
        public String Nro_Documento { get; set; }
        [DataMember]
        public String Correo { get; set; }
        [DataMember]
        public String Direccion { get; set; }
        [DataMember]
        public String Telefono { get; set; }
        [DataMember]
        public DateTime Fec_Nac { get; set; }
        [DataMember]
        public String Password { get; set; }
    }
}
