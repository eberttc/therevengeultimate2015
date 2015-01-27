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

            return paciente;
        }

        public Paciente actualizarPaciente(Paciente _paciente)
        {
            Paciente pacienteAModificar = new Paciente()
            {
                Id_Paciente=1,
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

            PacienteDAO.Eliminar(PacienteExistente);
        }

        public ICollection<Paciente> listarPaciente()
        {
            ICollection<Paciente> listaPaciente = PacienteDAO.ListarTodos();
            return listaPaciente;
        }
    }
}
