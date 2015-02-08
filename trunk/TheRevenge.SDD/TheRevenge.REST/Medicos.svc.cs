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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Medicos" en el código, en svc y en el archivo de configuración a la vez.
    public class Medicos : IMedicos
    {
        private MedicoDAO dao = new MedicoDAO();

        public Medico CrearMedico(Medico medicoACrear)
        {
            return dao.Crear(medicoACrear);
        }

        public Medico ObtenerMedico(string IdMedico)
        {
            return dao.Obtener(Convert.ToInt16(IdMedico));
        }

        public Medico ModificarMedico(Medico medicoAModificar)
        {
            return dao.Modificar(medicoAModificar);
        }

        public void EliminarMedico(string IdMedico)
        {
            Medico medicoAEliminar = dao.Obtener(Convert.ToInt16(IdMedico));
            dao.Eliminar(medicoAEliminar);
        }

        public List<Medico> ListarMedicos()
        {
            return dao.ListarTodos().ToList();
        }
    }
}
