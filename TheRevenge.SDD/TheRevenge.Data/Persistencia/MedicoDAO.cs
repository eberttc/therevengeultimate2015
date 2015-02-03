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
        public ICollection<Medico> ListarMedicoFiltros(Medico _Medico)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                ICollection<Medico> persona = sesion
                    .CreateCriteria(typeof(Medico))
                    .Add(Restrictions.Like("Nombres", _Medico.Nombre + "%"))
                    .Add(Restrictions.Like("Ape_Paterno", _Medico.Ape_Paterno + "%"))
                    .Add(Restrictions.Like("Ape_Materno", _Medico.Ape_Materno + "%"))
                    .Add(Restrictions.Like("Nro_Documento", _Medico.Nro_Documento + "%"))
                    .Add(Restrictions.Like("Correo", _Medico.Correo + "%"))
                    .List<Medico>();
                return persona;
            }
        }

        
    }
}
