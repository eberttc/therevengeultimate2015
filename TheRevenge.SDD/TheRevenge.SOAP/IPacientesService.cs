using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TheRevenge.Data.Dominio;

namespace TheRevenge.SOAP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPacientesService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPacientesService
    {
        [OperationContract]
        Paciente crearPaciente(Paciente _paciente);
        [OperationContract]
        Paciente consultarPaciente(int intIdPaciente);
        [OperationContract]
        Paciente actualizarPaciente(Paciente _paciente);
        [OperationContract]
        void eliminarPaciente(int intIdPaciente);
        [OperationContract]
        ICollection<Paciente> listarPaciente();
    }
}
