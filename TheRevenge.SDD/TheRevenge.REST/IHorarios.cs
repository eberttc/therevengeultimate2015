using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TheRevenge.Data.Dominio;
using System.ServiceModel.Web;

namespace TheRevenge.REST
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IHorarios" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IHorarios
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Horarios", ResponseFormat = WebMessageFormat.Json)]
        Horario CrearHorario(Horario tipoACrear);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Horarios/{IdHorario}", ResponseFormat = WebMessageFormat.Json)]
        Horario ObtenerHorario(string IdHorario);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Horarios", ResponseFormat = WebMessageFormat.Json)]
        Horario ModificarHorario(Horario tipoAModificar);
        [OperationContract]
        //[WebInvoke(Method = "DELETE", UriTemplate = "Horarioes/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        [WebInvoke(Method = "DELETE", UriTemplate = "Horarios/{IdHorario}")]
        void EliminarHorario(string IdHorario);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Horarios", ResponseFormat = WebMessageFormat.Json)]
        List<Horario> ListarHorarios();
    }
}
