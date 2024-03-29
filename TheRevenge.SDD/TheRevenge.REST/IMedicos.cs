﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using TheRevenge.Data.Dominio;

namespace TheRevenge.REST
{
    [ServiceContract]
    public interface IMedicos
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Medicos", ResponseFormat = WebMessageFormat.Json)]
        Medico CrearMedico(Medico MedicoACrear);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Medicos/{IdMedico}", ResponseFormat = WebMessageFormat.Json)]
        Medico ObtenerMedico(string IdMedico);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Medicos", ResponseFormat = WebMessageFormat.Json)]
        Medico ModificarMedico(Medico MedicoAModificar);
        [OperationContract]
        //[WebInvoke(Method = "DELETE", UriTemplate = "Medicoes/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        [WebInvoke(Method = "DELETE", UriTemplate = "Medicos/{IdMedico}")]
        void EliminarMedico(string IdMedico);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Medicos", ResponseFormat = WebMessageFormat.Json)]
        List<Medico> ListarMedicos();
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Medicos?Especialidades={Especialidad}", ResponseFormat = WebMessageFormat.Json)]
        List<Medico> BuscarMedicosPorEsp(string Especialidad);
    }
}
