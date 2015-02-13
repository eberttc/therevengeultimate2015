using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TheRevenge.Data.Dominio;
using TheRevenge.Data.Persistencia;
using System.Net;
using System.ServiceModel.Web;

namespace TheRevenge.REST
{
    public class ReservaCitas : IReservaCitas
    {
        private ReservaCitaDAO dao = new ReservaCitaDAO();

        public ReservaCita CrearReservaCita(ReservaCita reservaACrear)
        {
            try
            {
                ICollection<ReservaCita> _listaHorarioReserva = dao.BuscarHorarioReservado(reservaACrear).ToList();
                if (_listaHorarioReserva.Count() == 0)
                {
                    return dao.Crear(reservaACrear);
                }
                else 
                {
                    throw new WebFaultException<Observacion>(
                        new Observacion()
                        {
                            CodigoError = 1,
                            MensajeError = "El doctor no cuenta con este horario disponible"
                        }, HttpStatusCode.InternalServerError);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
