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
        //private MedicoDAO medicoDAO = null;
        //private MedicoDAO MedicoDAO
        //{
        //    get
        //    {
        //        if (medicoDAO == null)
        //            medicoDAO = new MedicoDAO();
        //        return medicoDAO;
        //    }
        //}

        ///*private Tipo_DocumentoDAO tipo_DocumentoDAO = null;
        //private Tipo_DocumentoDAO Tipo_DocumentoDAO
        //{
        //    get
        //    {
        //        if (tipo_DocumentoDAO == null)
        //            tipo_DocumentoDAO = new Tipo_DocumentoDAO();
        //        return tipo_DocumentoDAO;
        //    }
        //}

        //private CmpDAO cmpDAO = null;
        //private CmpDAO CmpDAO
        //{
        //    get
        //    {
        //        if (cmpDAO == null)
        //            cmpDAO = new CmpDAO();
        //        return cmpDAO;
        //    }
        //}

        //private EspecialidadDAO especialidadDAO = null;
        //private EspecialidadDAO EspecialidadDAO
        //{
        //    get
        //    {
        //        if (especialidadDAO == null)
        //            especialidadDAO = new EspecialidadDAO();
        //        return especialidadDAO;
        //    }
        //}*/

        //public Medico crearMedico(Medico _medico)
        //{
        //    Medico medicoABuscar = new Medico()
        //    {
        //        Nro_Documento = _medico.Nro_Documento,
        //        Correo = _medico.Correo
        //    };
        //    ICollection<Medico> listaMedico = MedicoDAO.ListarMedicoFiltros(medicoABuscar);
        //    if (listaMedico.Count > 0)
        //    {
        //        throw new FaultException<Observacion>(
        //            new Observacion()
        //            {
        //                CodigoError = 1,
        //                MensajeError = "El medico a ingresar ya se encuentra registrado. Usar otro usuario."
        //            }, new FaultReason("SOAP_InsertFail"));
        //    }


        //    /*Tipo_Documento tipoDocExistente = Tipo_DocumentoDAO.Obtener(tipo_Documento);
        //    Cmp cmpExistente = CmpDAO.Obtener(cmp);
        //    Especialidad especialidadExistente = EspecialidadDAO.Obtener(especialidad);*/
        //    Medico medicoCrear = new Medico()
        //    {
        //        Nombre = _medico.Nombre,
        //        Ape_Paterno = _medico.Ape_Paterno,
        //        Ape_Materno = _medico.Ape_Materno,
        //        Sexo = _medico.Sexo,
        //        Tipo_Documento = 1, //tipoDocExistente,
        //        Nro_Documento = _medico.Nro_Documento,
        //        Cmp = 1, //cmpExistente,
        //        Especialidad = 1, //especialidadExistente,
        //        Direccion = _medico.Direccion,
        //        Correo = _medico.Correo,
        //        Password = _medico.Password
        //    };
        //    return MedicoDAO.Crear(medicoCrear);
        //}

        //public Medico consultarMedico(int idmedico)
        //{
        //    Medico medico = null;
        //    medico = MedicoDAO.Obtener(idmedico);
        //    if (medico == null)
        //        throw new FaultException<Observacion>(
        //            new Observacion()
        //            {
        //                CodigoError = 3,
        //                MensajeError = "El medico a obtener no se encuentra registrado."
        //            }, new FaultReason("SOAP_NotFoundFail"));
        //    return medico;

        //    //return MedicoDAO.Obtener(idmedico);
        //}

        //public Medico actualizarMedico(Medico _medico)
        ////int idmedico, string nombre, string ape_paterno, string ape_materno, string sexo, int tipo_Documento, string nro_documento, int cmp, int especialidad, string direccion, string password
        //{

        //    Medico medicoABuscar = new Medico()
        //    {
        //        Nro_Documento = _medico.Nro_Documento,
        //        Correo = _medico.Correo
        //    };
        //    ICollection<Medico> listaMedico = MedicoDAO.ListarMedicoFiltros(medicoABuscar);
        //    if (listaMedico.Count() == 0)
        //        throw new FaultException<Observacion>(
        //            new Observacion()
        //            {
        //                CodigoError = 4,
        //                MensajeError = "El medico ingresado no se encuentra registrado."
        //            }, new FaultReason("SOAP_UpdateFail"));

        //    Medico medicoAComparar = new Medico()
        //    {
        //        Nombre = _medico.Nombre,
        //        Ape_Paterno = _medico.Ape_Paterno,
        //        Ape_Materno = _medico.Ape_Materno
        //    };
        //    listaMedico = MedicoDAO.ListarMedicoFiltros(medicoAComparar);
        //    if (listaMedico.Count() > 0)
        //        throw new FaultException<Observacion>(
        //            new Observacion()
        //            {
        //                CodigoError = 5,
        //                MensajeError = "Los datos del medico ingresado ya se encuentran registrados."
        //            }, new FaultReason("SOAP_2_UpdateFail"));



        //    /*Tipo_Documento tipoDocExistente = Tipo_DocumentoDAO.Obtener(tipo_Documento);
        //    Cmp cmpExistente = CmpDAO.Obtener(cmp);
        //    Especialidad especialidadExistente = EspecialidadDAO.Obtener(especialidad);*/

        //    Medico medicoAModificar = new Medico()
        //    {
        //        IdMedico = _medico.IdMedico,
        //        Nombre = _medico.Nombre,
        //        Ape_Paterno = _medico.Ape_Paterno,
        //        Ape_Materno = _medico.Ape_Materno,
        //        Sexo = _medico.Sexo,
        //        Tipo_Documento = _medico.Tipo_Documento,
        //        Nro_Documento = _medico.Nro_Documento,
        //        Cmp = _medico.Cmp,
        //        Especialidad = _medico.Especialidad,
        //        Direccion = _medico.Direccion,
        //        Password = _medico.Password
        //    };
        //    return MedicoDAO.Modificar(medicoAModificar);
        //}

        //public void eliminarMedico(int idmedico)
        //{
        //    Medico MedicoExistente = MedicoDAO.Obtener(idmedico);
        //    if (MedicoExistente == null)
        //        throw new FaultException<Observacion>(
        //            new Observacion()
        //            {
        //                CodigoError = 6,
        //                MensajeError = "El medico a eliminar no se encuentra registrado."
        //            }, new FaultReason("SOAP_DeleteFail"));
        //    MedicoDAO.Eliminar(MedicoExistente);

        //    //Medico medicoExistente = MedicoDAO.Obtener(idmedico);
        //    //MedicoDAO.Eliminar(medicoExistente);
        //}

        //public ICollection<Medico> ListarMedico()
        //{
        //    ICollection<Medico> listaMedico = MedicoDAO.ListarTodos();
        //    if (listaMedico.Count() == 0)
        //        throw new FaultException<Observacion>(
        //            new Observacion()
        //            {
        //                CodigoError = 7,
        //                MensajeError = "La lista no devolvió datos."
        //            }, new FaultReason("SOAP_EmptyListFail"));
        //    return listaMedico;
            
        //    //return MedicoDAO.ListarTodos().ToList();
        //}
    }
}
