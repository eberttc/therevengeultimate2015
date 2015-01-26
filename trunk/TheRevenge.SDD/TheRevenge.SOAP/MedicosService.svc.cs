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
    
    public class MedicosService : IMedicosService
    {
        private MedicoDAO medicoDAO = null;
        private MedicoDAO MedicoDAO
        {
            get
            {
                if (medicoDAO == null)
                    medicoDAO = new MedicoDAO();
                return medicoDAO;
            }
        }

        private Tipo_DocumentoDAO tipo_DocumentoDAO = null;
        private Tipo_DocumentoDAO Tipo_DocumentoDAO
        {
            get
            {
                if (tipo_DocumentoDAO == null)
                    tipo_DocumentoDAO = new Tipo_DocumentoDAO();
                return tipo_DocumentoDAO;
            }
        }

        private CmpDAO cmpDAO = null;
        private CmpDAO CmpDAO
        {
            get
            {
                if (cmpDAO == null)
                    cmpDAO = new CmpDAO();
                return cmpDAO;
            }
        }

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

        public Medico crearMedico(string nombre, string ape_paterno, string ape_materno, string sexo, int tipo_Documento, string nro_documento, int cmp, int especialidad, string direccion, string correo, string password)
        {
            Tipo_Documento tipoDocExistente = Tipo_DocumentoDAO.Obtener(tipo_Documento);
            Cmp cmpExistente = CmpDAO.Obtener(cmp);
            Especialidad especialidadExistente = EspecialidadDAO.Obtener(especialidad);
            Medico medicoCrear = new Medico()
            {
                Nombre = nombre,
                Ape_Paterno = ape_paterno,
                Ape_Materno = ape_materno,
                Sexo = sexo,
                Tipo_Documento = tipoDocExistente,
                Nro_Documento = nro_documento,
                Cmp = cmpExistente,
                Especialidad = especialidadExistente,
                Direccion = direccion,
                Correo = correo,
                Password = password
            };
            return MedicoDAO.Crear(medicoCrear);
        }

        public Medico consultarMedico(int idmedico)
        {
            return MedicoDAO.Obtener(idmedico);
        }

        public Medico actualizarMedico(int idmedico, string nombre, string ape_paterno, string ape_materno, string sexo, int tipo_Documento, string nro_documento, int cmp, int especialidad, string direccion, string password)
        {
            Tipo_Documento tipoDocExistente = Tipo_DocumentoDAO.Obtener(tipo_Documento);
            Cmp cmpExistente = CmpDAO.Obtener(cmp);
            Especialidad especialidadExistente = EspecialidadDAO.Obtener(especialidad);
            Medico medicoModificar = new Medico()
            {
                IdMedico = idmedico,
                Nombre = nombre,
                Ape_Paterno = ape_paterno,
                Ape_Materno = ape_materno,
                Sexo = sexo,
                Tipo_Documento = tipoDocExistente,
                Nro_Documento = nro_documento,
                Cmp = cmpExistente,
                Especialidad = especialidadExistente,
                Direccion = direccion,
                Password = password
            };
            return MedicoDAO.Modificar(medicoModificar);
        }

        public void eliminarMedico(int idmedico)
        {
            Medico medicoExistente = MedicoDAO.Obtener(idmedico);
            MedicoDAO.Eliminar(medicoExistente);
        }

        public List<Medico> ListarMedico()
        {
            return MedicoDAO.ListarTodos().ToList();
        }
    }
}
