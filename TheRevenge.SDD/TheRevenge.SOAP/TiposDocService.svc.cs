using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TheRevenge.Data.Persistencia;
using TheRevenge.Data.Dominio;
using Iesi.Collections.Generic;

namespace TheRevenge.SOAP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "TiposDocService" en el código, en svc y en el archivo de configuración a la vez.
    public class TiposDocService : ITiposDocService
    {
        private Tipo_DocumentoDAO tipo_DocumentoDAO = null;
        private Tipo_DocumentoDAO Tipo_DocumentoDAO
        {
            get
            {
                if (tipo_DocumentoDAO == null)
                    tipo_DocumentoDAO = new Tipo_DocumentoDAO();
                return tipo_DocumentoDAO;
            }
        }
        public ICollection<Tipo_Documento> listarTipo_Documento()
        {
            ICollection<Tipo_Documento> listarTipo_Documento = Tipo_DocumentoDAO.ListarTodos();
            if (listarTipo_Documento.Count() == 0)
                throw new FaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 6,
                        MensajeError = "La lista no devolvió datos."
                    }, new FaultReason("SOAP_TD_EmptyListFail"));
            return listarTipo_Documento;
        }
    }
}
