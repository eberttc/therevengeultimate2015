using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TheRevenge.Data.Dominio;
using TheRevenge.Data.Persistencia;

namespace TheRevenge.REST
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Tipos" en el código, en svc y en el archivo de configuración a la vez.
    public class Tipos : ITipos
    {

        private Tipo_DocumentoDAO dao = new Tipo_DocumentoDAO();

        public Tipo_Documento CrearTipo(Tipo_Documento tipoACrear)
        {
            return dao.Crear(tipoACrear);
        }

        public Tipo_Documento ObtenerTipo(string ID_Tipo_Doc)
        {
            return dao.Obtener(Convert.ToInt16(ID_Tipo_Doc));
        }

        public Tipo_Documento ModificarTipo(Tipo_Documento tipoAModificar)
        {
            return dao.Modificar(tipoAModificar);
        }

        public void EliminarTipo(string ID_Tipo_Doc)
        {
            Tipo_Documento tipoAEliminar = dao.Obtener(Convert.ToInt16(ID_Tipo_Doc));
            dao.Eliminar(tipoAEliminar);
        }

        public List<Tipo_Documento> ListarTipos()
        {
            return dao.ListarTodos().ToList();
        }
    }
}
