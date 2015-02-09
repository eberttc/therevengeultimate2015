using System;
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
    public interface ICitaServices
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Citas", ResponseFormat = WebMessageFormat.Json)]
        Cita CrearCita(Cita CitaACrear);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Citas/{IdCita}", ResponseFormat = WebMessageFormat.Json)]
        Cita ObtenerCita(string IdCita);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Citas", ResponseFormat = WebMessageFormat.Json)]
        Cita ModificarCita(Cita CitaAModificar);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Citas/{IdCita}")]
        void EliminarCita(string IdCita);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Citas", ResponseFormat = WebMessageFormat.Json)]
        List<Cita> ListarCitas();
    }
}
