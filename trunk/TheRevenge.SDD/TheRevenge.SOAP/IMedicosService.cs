using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TheRevenge.Data.Dominio;

namespace TheRevenge.SOAP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMedicosService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMedicosService
    {
        [OperationContract]
        Medico crearMedico(string nombre, string ape_paterno, string ape_materno, string sexo, int tipo_Documento, string nro_documento, int cmp, int especialidad, string direccion, string correo, string password);
        [OperationContract]
        Medico consultarMedico(int idmedico);
        [OperationContract]
        Medico actualizarMedico(int idmedico, string nombre, string ape_paterno, string ape_materno, string sexo, int tipo_Documento, string nro_documento, int cmp, int especialidad, string direccion, string password);
        [OperationContract]
        void eliminarMedico(int idmedico);
        [OperationContract]
        List<Medico> ListarMedico();

    }
}
