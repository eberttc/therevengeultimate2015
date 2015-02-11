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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Especialidades" en el código, en svc y en el archivo de configuración a la vez.
    public class Especialidades : IEspecialidades
    {
        private EspecialidadDAO dao = new EspecialidadDAO();

        public Especialidad CrearEspecialidad(Especialidad especialidadACrear)
        {
            return dao.Crear(especialidadACrear);
        }

        public Especialidad ObtenerEspecialidad(string Id_Especialidad)
        {
            return dao.Obtener(Convert.ToInt16(Id_Especialidad));
        }

        public Especialidad ModificarEspecialidad(Especialidad especialidadAModificar)
        {
            return dao.Modificar(especialidadAModificar);
        }

        public void EliminarEspecialidad(string Id_Especialidad)
        {
            Especialidad especialidadAEliminar = dao.Obtener(Convert.ToInt16(Id_Especialidad));
            dao.Eliminar(especialidadAEliminar);
        }

        public List<Especialidad> ListarEspecialidades()
        {
            return dao.ListarTodos().ToList();
        }
    }
}
