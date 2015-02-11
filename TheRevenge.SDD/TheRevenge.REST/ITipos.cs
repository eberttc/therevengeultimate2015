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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ITipos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ITipos
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Tipos", ResponseFormat = WebMessageFormat.Json)]
        Tipo_Documento CrearTipo(Tipo_Documento tipoACrear);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Tipos/{ID_Tipo_Doc}", ResponseFormat = WebMessageFormat.Json)]
        Tipo_Documento ObtenerTipo(string ID_Tipo_Doc);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Tipos", ResponseFormat = WebMessageFormat.Json)]
        Tipo_Documento ModificarTipo(Tipo_Documento tipoAModificar);
        [OperationContract]
        //[WebInvoke(Method = "DELETE", UriTemplate = "Tipoes/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        [WebInvoke(Method = "DELETE", UriTemplate = "Tipos/{ID_Tipo_Doc}")]
        void EliminarTipo(string ID_Tipo_Doc);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Tipos", ResponseFormat = WebMessageFormat.Json)]
        List<Tipo_Documento> ListarTipos();
    }
}
