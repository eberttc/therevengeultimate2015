using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheRevenge.Data.Dominio;
using NHibernate;
using NHibernate.Criterion;

namespace TheRevenge.Data.Persistencia
{
    public class ReservaCitaDAO : BaseDAO<ReservaCita,int>
    {
        public ICollection<ReservaCita>BuscarHorarioReservado(ReservaCita _ReservaCita)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                ICollection<ReservaCita> reserva = sesion
                    .CreateCriteria(typeof(ReservaCita))
                    .Add(Restrictions.Eq("Horario", _ReservaCita.Horario))
                    .List<ReservaCita>();
                return reserva;
            }
        }
    }
}
