using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TheRevenge.Data.Dominio;
using TheRevenge.Data.Persistencia;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.ServiceModel.Web;
namespace TheRevenge.REST
{

    public class AtencionCitas : IAtencionCitas
    {
        private CitaDAO dao = new CitaDAO();
        private Cita CrearAtencion(Cita atencionACrear)
        {
            return dao.Crear(atencionACrear);
        }

        public Cita ObtenerCitaAtencion(string IdCita)
        {        
            Cita CitaAtencion = null;
            CitaAtencion = dao.Obtener(Convert.ToInt16(IdCita));
            if (CitaAtencion == null)
           // {
              //  if(CitaAtencion.Observacion == null)
                {
                    return CitaAtencion;
                }
               // else
                {
                    throw new WebFaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 1,
                        MensajeError = "Nr° de Cita no existe"
                    }, HttpStatusCode.InternalServerError);
                }
            }
            //else
            //{               
            //    throw new WebFaultException<Observacion>(
            //    new Observacion()
            //    {
            //       CodigoError = 2,
            //       MensajeError = "Nr° Cita ya atendido"
            //    };HttpStatusCode.InternalServerError);
            //}
         
       // }
    }
}
