using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TheRevenge.Data.Dominio;

namespace TheRevenge.SOAP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ITiposDocService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ITiposDocService
    {
        [OperationContract]
        ICollection<Tipo_Documento> listarTipo_Documento();
    }
}
