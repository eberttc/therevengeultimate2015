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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICMPs" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICMPs
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "CMPs", ResponseFormat = WebMessageFormat.Json)]
        Cmp CrearCmp(Cmp cmpACrear);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "CMPs/{IdCmp}", ResponseFormat = WebMessageFormat.Json)]
        Cmp ObtenerCmp(string IdCmp);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "CMPs", ResponseFormat = WebMessageFormat.Json)]
        Cmp ModificarCmp(Cmp cmpAModificar);
        [OperationContract]
        //[WebInvoke(Method = "DELETE", UriTemplate = "Cmpes/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        [WebInvoke(Method = "DELETE", UriTemplate = "CMPs/{IdCmp}")]
        void EliminarCmp(string IdCmp);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "CMPs", ResponseFormat = WebMessageFormat.Json)]
        List<Cmp> ListarCmps();
    }
}
