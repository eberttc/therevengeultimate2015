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
    public class EstadoCitasService : IEstadoCitasService
    {
        private EstadoCitaDAO estadoCitaDAO = null;
        private EstadoCitaDAO EstadoCitaDAO
        {
            get
            {
                if (estadoCitaDAO == null)
                    estadoCitaDAO = new EstadoCitaDAO();
                return estadoCitaDAO;
            }
        }
        public List<EstadoCita> ListarEstadoCita()
        {
            return EstadoCitaDAO.ListarTodos().ToList();
        }
    }
}
