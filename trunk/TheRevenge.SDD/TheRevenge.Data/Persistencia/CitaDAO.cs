using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheRevenge.Data.Dominio;
using NHibernate;
using NHibernate.Criterion;
using System.Data.SqlClient;


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
                    .Add(Restrictions.Eq("FecReserva", _Cita.FecReserva))
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
                    .Add(Restrictions.Eq("FecReserva", _Cita.FecReserva))
                    .List<Cita>();
                return cita;
            }
        }

        public ICollection<CitaDescrita> BuscarCitaDescritaPorPaciente(String IdPaciente)
        {
            string sql = @"select ID_CITA,FEC_RESERVA,FEC_ATENCION,DIAGNOSTICO,OBSERVACION,DESCRIPCION,
NOM_APE_PAC=C.NOMBRES+' '+C.APE_PATERNO+' '+C.APE_PATERNO,VAL_ESTADO,NOM_APE_MED=E.NOMBRES+' '+E.APE_PATERNO+' '+E.APE_PATERNO,
VAL_HOR from CITA A (nolock) inner join ESPECIALIDAD B (nolock) on A.ID_ESPECIALIDAD=B.ID_ESPECIALIDAD
inner join PACIENTE C (nolock) on A.ID_PACIENTE=C.ID_PACIENTE inner join ESTADO_CITA D (nolock) on A.ID_ESTADO=D.ID_ESTADO
inner join MEDICO E (nolock) on A.ID_MEDICO=E.ID_MEDICO inner join HORARIO F (nolock) on A.ID_HORARIO=F.ID_HORARIO
WHERE ID_PACIENTE=@P_ID_PACIENTE";
            ICollection<CitaDescrita> lista = new List<CitaDescrita>();
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@P_ID_PACIENTE", IdPaciente));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        CitaDescrita citadescrita;
                        while (resultado.Read())
                        {
                            citadescrita = new CitaDescrita();
                            citadescrita.IdCita = (Int16)resultado["ID_CITA"];
                            citadescrita.FecReserva = (String)resultado["FEC_RESERVA"];
                            citadescrita.FecAtencion = (String)resultado["FEC_ATENCION"];
                            citadescrita.Diagnostico = (String)resultado["DIAGNOSTICO"];
                            citadescrita.Observacion = (String)resultado["OBSERVACION"];
                            citadescrita.Descripcion = (String)resultado["DESCRIPCION"];
                            citadescrita.Nom_Ape_Pac = (String)resultado["NOM_APE_PAC"];
                            citadescrita.Val_Estado = (String)resultado["VAL_ESTADO"];
                            citadescrita.Nom_Ape_Med = (String)resultado["NOM_APE_MED"];
                            citadescrita.Val_Hor = (String)resultado["VAL_HOR"];
                            lista.Add(citadescrita);
                        }
                    }
                }
                con.Close();
                return lista;
            }
        }

        public ICollection<CitaDescrita> BuscarCitaDescritaPorIdCita(String IdCita)
        {
            string sql = @"select ID_CITA,FEC_RESERVA,FEC_ATENCION,DIAGNOSTICO,OBSERVACION,DESCRIPCION,
NOM_APE_PAC=C.NOMBRES+' '+C.APE_PATERNO+' '+C.APE_PATERNO,VAL_ESTADO,NOM_APE_MED=E.NOMBRES+' '+E.APE_PATERNO+' '+E.APE_PATERNO,
VAL_HOR from CITA A (nolock) inner join ESPECIALIDAD B (nolock) on A.ID_ESPECIALIDAD=B.ID_ESPECIALIDAD
inner join PACIENTE C (nolock) on A.ID_PACIENTE=C.ID_PACIENTE inner join ESTADO_CITA D (nolock) on A.ID_ESTADO=D.ID_ESTADO
inner join MEDICO E (nolock) on A.ID_MEDICO=E.ID_MEDICO inner join HORARIO F (nolock) on A.ID_HORARIO=F.ID_HORARIO
WHERE ID_CITA=@ID_CITA";
            ICollection<CitaDescrita> lista = new List<CitaDescrita>();
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@ID_CITA", IdCita));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        CitaDescrita citadescrita;
                        while (resultado.Read())
                        {
                            citadescrita = new CitaDescrita();
                            citadescrita.IdCita = (Int16)resultado["ID_CITA"];
                            citadescrita.FecReserva = (String)resultado["FEC_RESERVA"];
                            citadescrita.FecAtencion = (String)resultado["FEC_ATENCION"];
                            citadescrita.Diagnostico = (String)resultado["DIAGNOSTICO"];
                            citadescrita.Observacion = (String)resultado["OBSERVACION"];
                            citadescrita.Descripcion = (String)resultado["DESCRIPCION"];
                            citadescrita.Nom_Ape_Pac = (String)resultado["NOM_APE_PAC"];
                            citadescrita.Val_Estado = (String)resultado["VAL_ESTADO"];
                            citadescrita.Nom_Ape_Med = (String)resultado["NOM_APE_MED"];
                            citadescrita.Val_Hor = (String)resultado["VAL_HOR"];
                            lista.Add(citadescrita);
                        }
                    }
                }
                con.Close();
                return lista;
            }
        }



        //public ICollection<Cita> ReservaNoExiste(int Id)
        //{
        //    using (ISession sesion = NHibernateHelper.ObtenerSesion())
        //    {
        //        ICollection<Cita> cita = sesion
        //            .CreateCriteria(typeof(Cita))
        //            .Add(Restrictions.Eq("IdCita", Id.IdCita))                   
        //            .List<Cita>();
        //        return cita;
        //    }
        //}

        
    }
}
