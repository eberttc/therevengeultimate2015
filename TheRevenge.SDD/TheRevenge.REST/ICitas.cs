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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICitas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICitas
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Citas", ResponseFormat = WebMessageFormat.Json)]
        Cita CrearCita(Cita citaACrear);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Citas/{IdCita}", ResponseFormat = WebMessageFormat.Json)]
        Cita ObtenerCita(string IdCita);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Citas", ResponseFormat = WebMessageFormat.Json)]
        Cita ModificarCita(Cita citaAModificar);
        [OperationContract]
        //[WebInvoke(Method = "DELETE", UriTemplate = "Citaes/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        [WebInvoke(Method = "DELETE", UriTemplate = "Citas/{IdCita}")]
        void EliminarCita(string IdCita);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Citas", ResponseFormat = WebMessageFormat.Json)]
        List<Cita> ListarCitas();
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Citas/{IdPaciente}", ResponseFormat = WebMessageFormat.Json)]
        List<CitaDescrita> ObtenerCitaDescrita(string IdPaciente);
    }
}
