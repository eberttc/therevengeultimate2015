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
    public class HorariosService : IHorariosService
    {
        private HorarioDAO horarioDAO = null;
        private HorarioDAO HorarioDAO
        {
            get 
            {
                if (horarioDAO == null)
                    horarioDAO = new HorarioDAO();
                return horarioDAO;
            }
        }
        public List<Horario> ListarHorario()
        {
            return HorarioDAO.ListarTodos().ToList();
        }
    }
}
