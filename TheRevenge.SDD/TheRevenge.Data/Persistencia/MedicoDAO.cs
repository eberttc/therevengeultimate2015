using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheRevenge.Data.Dominio;
using NHibernate;
using NHibernate.Criterion;

namespace TheRevenge.Data.Persistencia
{
    public class MedicoDAO : BaseDAO<Medico, int>
    {
        public ICollection<Medico> BuscarMedicosDuplicados(Medico _Medico)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                ICollection<Medico> persona = sesion
                    .CreateCriteria(typeof(Medico))
                    .Add(Restrictions.Eq("Nro_Documento", _Medico.Nro_Documento))
                    .Add(Restrictions.Eq("Cmp", _Medico.Cmp))
                    .Add(Restrictions.Eq("Correo", _Medico.Correo))
                    .List<Medico>();
                return persona;
            }
        }
        public ICollection<Medico> BuscarMedicosPorEspecialidad(String Especialidad)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                ICollection<Medico> persona = sesion
                    .CreateCriteria(typeof(Medico))
                    .Add(Restrictions.Eq("Especialidad", Convert.ToInt32(Especialidad)))
                    .List<Medico>();
                return persona;
            }
        }
    }
}
