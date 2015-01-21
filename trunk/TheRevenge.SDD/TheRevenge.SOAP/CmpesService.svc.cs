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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CmpesService" in code, svc and config file together.
    public class CmpesService : ICmpesService
    {

        #region ICmpesService Members

        private CmpDAO cmpDAO = null;
        private CmpDAO CmpDAO
        {
            get
            {
                if (cmpDAO == null)
                    cmpDAO = new CmpDAO();
                return cmpDAO;
            }
        }

        public Cmp crearCmp(string strtxDescripcion, string strtxDoc_Identidad)
        {
            Cmp nuevoCmp = null;
            Cmp CmpACrear = new Cmp()
            {
                TxDescripcion = strtxDescripcion,
                TxDoc_Identidad = strtxDoc_Identidad
            };

            nuevoCmp = CmpDAO.Crear(CmpACrear);

            return nuevoCmp;
        }

        public Cmp consultarCmp(int intIdCMP)
        {
            Cmp cmp = null;
            cmp = CmpDAO.Obtener(intIdCMP);

            return cmp;
        }

        public Cmp actualizarCmp(int intIdCMP, string strtxDescripcion, string strtxDoc_Identidad)
        {
            
            Cmp asesorAModificar = new Cmp()
            {
                IdCmp = intIdCMP,
                TxDescripcion = strtxDescripcion,
                TxDoc_Identidad= strtxDoc_Identidad
            };

            return CmpDAO.Modificar(asesorAModificar);
        }

        public void eliminarCmp(int intIdCMP)
        {
            Cmp CmpExistente = CmpDAO.Obtener(intIdCMP);

            CmpDAO.Eliminar(CmpExistente);
        }

        public ICollection<Cmp> listarCmp()
        {
                ICollection<Cmp> listaCmp = CmpDAO.ListarTodos();
                return listaCmp;   
        }

        #endregion
    }
}
