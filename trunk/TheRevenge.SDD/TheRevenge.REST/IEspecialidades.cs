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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IEspecialidades" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IEspecialidades
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Especialidades", ResponseFormat = WebMessageFormat.Json)]
        Especialidad CrearEspecialidad(Especialidad especialidadACrear);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Especialidades/{Id_Especialidad}", ResponseFormat = WebMessageFormat.Json)]
        Especialidad ObtenerEspecialidad(string Id_Especialidad);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Especialidades", ResponseFormat = WebMessageFormat.Json)]
        Especialidad ModificarEspecialidad(Especialidad especialidadAModificar);
        [OperationContract]
        //[WebInvoke(Method = "DELETE", UriTemplate = "Especialidades/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        [WebInvoke(Method = "DELETE", UriTemplate = "Especialidades/{Id_Especialidad}")]
        void EliminarEspecialidad(string Id_Especialidad);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Especialidades", ResponseFormat = WebMessageFormat.Json)]
        List<Especialidad> ListarEspecialidades();
    }
}
