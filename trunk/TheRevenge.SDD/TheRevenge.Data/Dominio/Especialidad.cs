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
        // Clase que manejara el movimiento de informacion de Especialidades que posee la clinica
        [DataMember(IsRequired = false)]
        public int Id_Especialidad { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}
