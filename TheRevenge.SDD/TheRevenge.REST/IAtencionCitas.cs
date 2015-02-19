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
    public interface IAtencionCitas
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Atenciones", ResponseFormat = WebMessageFormat.Json)]
        AtencionCita CrearAtencion(AtencionCita AtencionACrear);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Atenciones/{IdCita}", ResponseFormat = WebMessageFormat.Json)]
        AtencionCita ObtenerCitaAtencion(string IdCita);
    }
}
