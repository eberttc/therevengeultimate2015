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
    public interface IHorariosService
    {
        [OperationContract]
        List<Horario>ListarHorario();
    }
}
