﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TheRevenge.Data.Dominio
{
    [DataContract]
    public class Medico
    {
        [DataMember (IsRequired = false)]
        public int IdMedico { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Ape_Paterno { get; set; }
        [DataMember]
        public string Ape_Materno { get; set; }
        [DataMember]
        public string Sexo { get; set; }
        [DataMember]
        public int Tipo_Documento { get; set; }
        [DataMember]
        public string Nro_Documento { get; set; }
        [DataMember]
        public int Cmp { get; set; }
        [DataMember]
        public int Especialidad { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string Telefono { get; set; }
        [DataMember]
        public string Correo { get; set; }
        [DataMember]
        public string Password { get; set; }
    }
}
