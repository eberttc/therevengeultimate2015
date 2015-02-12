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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Citas" en el código, en svc y en el archivo de configuración a la vez.
    public class Citas : ICitas
    {
        private CitaDAO dao = new CitaDAO();

        public Cita CrearCita(Cita citaACrear)
        {
            return dao.Crear(citaACrear);
        }

        public Cita ObtenerCita(string IdCita)
        {
            return dao.Obtener(Convert.ToInt16(IdCita));
        }

        public Cita ModificarCita(Cita citaAModificar)
        {
            return dao.Modificar(citaAModificar);
        }

        public void EliminarCita(string IdCita)
        {
            Cita citaAEliminar = dao.Obtener(Convert.ToInt16(IdCita));
            dao.Eliminar(citaAEliminar);
        }

        public List<Cita> ListarCitas()
        {
            return dao.ListarTodos().ToList();
        }
    }
}
