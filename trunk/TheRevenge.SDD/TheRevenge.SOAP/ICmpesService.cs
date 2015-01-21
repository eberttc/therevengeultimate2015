using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TheRevenge.Data.Dominio;

namespace TheRevenge.SOAP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICmpesService" in both code and config file together.
    [ServiceContract]
    public interface ICmpesService
    {
        [OperationContract]
        Cmp crearCmp(String strtxDescripcion, String strtxDoc_Identidad);
        [OperationContract]
        Cmp consultarCmp(int intIdCMP);
        [OperationContract]
        Cmp actualizarCmp(int intIdCMP, String strtxDescripcion, String strtxDoc_Identidad);
        [OperationContract]
        void eliminarCmp(int intIdCMP);
        [OperationContract]
        ICollection<Cmp> listarCmp();
    }
}
