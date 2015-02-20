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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Horarios" en el código, en svc y en el archivo de configuración a la vez.
    public class Horarios : IHorarios
    {

        private HorarioDAO dao = new HorarioDAO();
        public Horario CrearHorario(Horario horarioACrear)
        {
            return dao.Crear(horarioACrear);
        }

        public Horario ObtenerHorario(string IdHorario)
        {
            return dao.Obtener(Convert.ToInt16(IdHorario));
        }

        public Horario ModificarHorario(Horario horarioAModificar)
        {
            return dao.Modificar(horarioAModificar);
        }

        public void EliminarHorario(string IdHorario)
        {
            Horario horarioAEliminar = dao.Obtener(Convert.ToInt16(IdHorario));
            dao.Eliminar(horarioAEliminar);
        }

        public List<Horario> ListarHorarios()
        {
            return dao.ListarTodos().ToList();
        }
    }
}
