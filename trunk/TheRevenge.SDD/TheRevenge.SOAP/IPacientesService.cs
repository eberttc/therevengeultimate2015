using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TheRevenge.Data.Dominio;

namespace TheRevenge.SOAP
{
    [ServiceContract]
    public interface IPacientesService
    {
        [OperationContract]
        [FaultContract(typeof(Observacion))]
        Paciente crearPaciente(Paciente _paciente);
        [OperationContract]
        Paciente consultarPaciente(int intIdPaciente);
        [OperationContract]
        [FaultContract(typeof(Observacion))]
        Paciente actualizarPaciente(Paciente _paciente);
        [OperationContract]
        void eliminarPaciente(int intIdPaciente);
        [OperationContract]        
        ICollection<Paciente> listarPaciente();
    }
}
