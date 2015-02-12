using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TheRevenge.Data.Dominio;
using TheRevenge.Data.Persistencia;
using System.Net;
using System.ServiceModel.Web;

namespace TheRevenge.REST
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Citas" en el código, en svc y en el archivo de configuración a la vez.
    public class Citas : ICitas
    {
        private CitaDAO dao = new CitaDAO();

        public Cita CrearCita(Cita citaACrear)
        {
            ICollection<Cita> _listaMedCita = dao.BuscarMedicosConCitas(citaACrear).ToList();
            if (_listaMedCita.Count() == 0)
            {
                ICollection<Cita> _listaPacCita = dao.BuscarPacienteConCita(citaACrear).ToList();
                if (_listaPacCita.Count() == 0)
                {
                    return dao.Crear(citaACrear);
                }
                else
                {
                    throw new WebFaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 1,
                        MensajeError = "Ya se cuenta con una reserva de cita en el horario seleccionado"
                    }, HttpStatusCode.InternalServerError);
                }
            }
            else
            {
                throw new WebFaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 2,
                        MensajeError = "El doctor no cuenta con este horario disponible"
                    }, HttpStatusCode.InternalServerError);
            }
        }

        public Cita ObtenerCita(string IdCita)
        {
            return dao.Obtener(Convert.ToInt16(IdCita));
        }

        public Cita ModificarCita(Cita citaAModificar)
        {
            ICollection<Cita> _listaMedCita = dao.BuscarMedicosConCitas(citaAModificar).ToList();
            if (_listaMedCita.Count() == 0)
            {
                ICollection<Cita> _listaPacCita = dao.BuscarPacienteConCita(citaAModificar).ToList();
                if (_listaPacCita.Count() == 0)
                {
                    return dao.Crear(citaAModificar);
                }
                else
                {
                    throw new WebFaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 1,
                        MensajeError = "Ya se cuenta con una reserva de cita en el horario seleccionado"
                    }, HttpStatusCode.InternalServerError);
                }
            }
            else
            {
                throw new WebFaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 2,
                        MensajeError = "El doctor no cuenta con este horario disponible"
                    }, HttpStatusCode.InternalServerError);
            }
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
