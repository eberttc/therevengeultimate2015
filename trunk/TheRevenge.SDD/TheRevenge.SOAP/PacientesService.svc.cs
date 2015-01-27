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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PacientesService" en el código, en svc y en el archivo de configuración a la vez.
    public class PacientesService : IPacientesService
    {
        private PacienteDAO pacienteDAO = null;
        private PacienteDAO PacienteDAO
        {
            get
            {
                if (pacienteDAO == null)
                    pacienteDAO = new PacienteDAO();
                return pacienteDAO;
            }
        }
        public Paciente crearPaciente(Paciente _paciente)
        {
            ICollection<Paciente> listaPaciente = PacienteDAO.ListarPacienteFiltros(_paciente);
            if (listaPaciente.Count > 0)
            {
                throw new FaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 1,
                        MensajeError = "El paciente a ingresar ya se encuentra registrado. Usar otro usuario."
                    }, new FaultReason("SOAP_InsertFail"));
            }
            Paciente PacienteACrear = new Paciente()
            {
                Nombres=_paciente.Nombres,
                Ape_Paterno = _paciente.Ape_Paterno,
                Ape_Materno = _paciente.Ape_Materno,
                Sexo = _paciente.Sexo,
                Id_Tipo_Doc = _paciente.Id_Tipo_Doc,
                Nro_Documento = _paciente.Nro_Documento,
                Correo = _paciente.Correo,
                Direccion = _paciente.Direccion,
                Telefono = _paciente.Telefono,
                Fec_Nac = _paciente.Fec_Nac,
                Password = _paciente.Password
            };

            return PacienteDAO.Crear(PacienteACrear);
        }

        public Paciente consultarPaciente(int intIdPaciente)
        {
            Paciente paciente = null;
            paciente = PacienteDAO.Obtener(intIdPaciente);
            if (paciente == null)
                throw new FaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 2,
                        MensajeError = "El paciente a obtener no se encuentra registrado."
                    }, new FaultReason("SOAP_NotFoundFail"));
            return paciente;
        }

        public Paciente actualizarPaciente(Paciente _paciente)
        {
            ICollection<Paciente> listaPaciente = PacienteDAO.ListarPacienteFiltros(_paciente);
            if (listaPaciente.Count() == 0)
                throw new FaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 3,
                        MensajeError = "El paciente ingresado no se encuentra registrado."
                    }, new FaultReason("SOAP_UpdateFail"));

            Paciente pacienteAModificar = new Paciente()
            {
                Id_Paciente=_paciente.Id_Paciente,
                Nombres = _paciente.Nombres,
                Ape_Paterno = _paciente.Ape_Paterno,
                Ape_Materno = _paciente.Ape_Materno,
                Sexo = _paciente.Sexo,
                Id_Tipo_Doc = _paciente.Id_Tipo_Doc,
                Nro_Documento = _paciente.Nro_Documento,
                Correo = _paciente.Correo,
                Direccion = _paciente.Direccion,
                Telefono = _paciente.Telefono,
                Fec_Nac = _paciente.Fec_Nac,
                Password = _paciente.Password
            };
            return PacienteDAO.Modificar(pacienteAModificar);
        }

        public void eliminarPaciente(int intIdPaciente)
        {
            Paciente PacienteExistente = PacienteDAO.Obtener(intIdPaciente);
            if (PacienteExistente == null)
                throw new FaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 4,
                        MensajeError = "El paciente a eliminar no se encuentra registrado."
                    }, new FaultReason("SOAP_DeleteFail"));
            PacienteDAO.Eliminar(PacienteExistente);
        }

        public ICollection<Paciente> listarPaciente()
        {
            ICollection<Paciente> listaPaciente = PacienteDAO.ListarTodos();
            if (listaPaciente.Count() == 0)
                throw new FaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 5,
                        MensajeError = "La lista no devolvió datos."
                    }, new FaultReason("SOAP_EmptyListFail"));
            return listaPaciente;
        }
    }
}
