using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TheRevenge.Data.Dominio;

namespace TheRevenge.SOAP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IEspecialidadesService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IEspecialidadesService
    {
        [OperationContract]
        Especialidad crearEspecialidad(string descripcion);
        [OperationContract]
        Especialidad consultarEspecialidad(int idespecialidad);
        [OperationContract]
        Especialidad actualizarEspecialidad(int idespecialidad, string descripcion);
        [OperationContract]
        void eliminarEspecialidad(int idespecialidad);
        [OperationContract]
        List<Especialidad> ListarEspecialidad();

    }
}
