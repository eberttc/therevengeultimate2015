using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheRevenge.Data.Dominio;
using NHibernate;
using NHibernate.Criterion;


namespace TheRevenge.Data.Persistencia
{
    public class CitaDAO : BaseDAO<Cita, int>
    {
        public ICollection<Cita> BuscarMedicosConCitas(Cita _Cita)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                ICollection<Cita> cita = sesion
                    .CreateCriteria(typeof(Cita))
                    .Add(Restrictions.Eq("IdEspecialidad", _Cita.IdEspecialidad))
                    .Add(Restrictions.Eq("IdHorario", _Cita.IdHorario))
                    .Add(Restrictions.Eq("IdEstado", _Cita.IdEstado))
                    .Add(Restrictions.Eq("IdMedico", _Cita.IdMedico))
                    .List<Cita>();
                return cita;
            }
        }
        public ICollection<Cita> BuscarPacienteConCita(Cita _Cita)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                ICollection<Cita> cita = sesion
                    .CreateCriteria(typeof(Cita))
                    .Add(Restrictions.Eq("IdEspecialidad", _Cita.IdEspecialidad))
                    .Add(Restrictions.Eq("IdHorario", _Cita.IdHorario))
                    .Add(Restrictions.Eq("IdEstado", _Cita.IdEstado))
                    .Add(Restrictions.Eq("IdPaciente", _Cita.IdPaciente))
                    .List<Cita>();
                return cita;
            }
        }
    }
}
