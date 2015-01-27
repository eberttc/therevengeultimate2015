using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Criterion;
using TheRevenge.Data.Dominio;


namespace TheRevenge.Data.Persistencia
{
    public class PacienteDAO : BaseDAO<Paciente, int>
    {
        public ICollection<Paciente> ListarPacienteFiltros (Paciente _Paciente)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                ICollection<Paciente> persona = sesion
                    .CreateCriteria(typeof(Paciente))
                    .Add(Restrictions.Like("Nombres", _Paciente.Nombres + "%"))
                    .Add(Restrictions.Like("Ape_Paterno", _Paciente.Ape_Paterno + "%"))
                    .Add(Restrictions.Like("Ape_Materno", _Paciente.Ape_Materno + "%"))
                    .Add(Restrictions.Like("Nro_Documento", _Paciente.Nro_Documento + "%"))
                    .Add(Restrictions.Like("Correo", _Paciente.Correo + "%"))
                    .List<Paciente>();
                return persona;
            }
        }
    }
}
