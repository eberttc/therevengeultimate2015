using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TheRevenge.Data.Persistencia;
using TheRevenge.Data.Dominio;

namespace TheRevenge.REST
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CMPs" en el código, en svc y en el archivo de configuración a la vez.
    public class CMPs : ICMPs
    {
        private CmpDAO dao = new CmpDAO();


        #region ICmpService Members

        public Cmp CrearCmp(Cmp cmpACrear)
        {
            return dao.Crear(cmpACrear);
        }

        public Cmp ObtenerCmp(string IdCmp)
        {
            return dao.Obtener(Convert.ToInt16(IdCmp));
        }

        public Cmp ModificarCmp(Cmp cmpAModificar)
        {
            return dao.Modificar(cmpAModificar);
        }

        public void EliminarCmp(string IdCmp)
        {
            Cmp cmpAEliminar = dao.Obtener(Convert.ToInt16(IdCmp));
            dao.Eliminar(cmpAEliminar);
        }

        public List<Cmp> ListarCmps()
        {
            return dao.ListarTodos().ToList();
        }

        #endregion
    }
}
