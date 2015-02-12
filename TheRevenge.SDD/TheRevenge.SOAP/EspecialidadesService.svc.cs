using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TheRevenge.Data.Dominio;
using TheRevenge.Data.Persistencia;

namespace TheRevenge.SOAP
{
    
    public class EspecialidadesService : IEspecialidadesService
    {
        private EspecialidadDAO especialidadDAO = null;
        private EspecialidadDAO EspecialidadDAO
        {
            get
            {
                if (especialidadDAO == null)
                    especialidadDAO = new EspecialidadDAO();
                return especialidadDAO;
            }
        }

        public Especialidad crearEspecialidad(string descripcion)
        {
            Especialidad especialidadCrear = new Especialidad()
            {
                Descripcion = descripcion
            };
            return EspecialidadDAO.Crear(especialidadCrear);
        }

        public Especialidad consultarEspecialidad(int idespecialidad)
        {
            return EspecialidadDAO.Obtener(idespecialidad);
        }

        public Especialidad actualizarEspecialidad(int idespecialidad, string descripcion)
        {
            Especialidad especialidadCrear = new Especialidad()
            {
                IdEspecialidad = idespecialidad,
                Descripcion = descripcion
            };
            return EspecialidadDAO.Modificar(especialidadCrear);
        }

        public void eliminarEspecialidad(int idespecialidad)
        {
            Especialidad especialidadExistente = EspecialidadDAO.Obtener(idespecialidad);
            EspecialidadDAO.Eliminar(especialidadExistente);
        }

        public List<Especialidad> ListarEspecialidad()
        {
            return EspecialidadDAO.ListarTodos().ToList();
        }
    }
}
