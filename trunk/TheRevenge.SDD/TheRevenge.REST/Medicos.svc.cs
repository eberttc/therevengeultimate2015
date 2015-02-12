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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Medicos" en el código, en svc y en el archivo de configuración a la vez.
    public class Medicos : IMedicos
    {
        private MedicoDAO dao = new MedicoDAO();

        public Medico CrearMedico(Medico medicoACrear)
        {
            ICollection<Medico> _lista = dao.BuscarMedicosDuplicados(medicoACrear).ToList();
            if (_lista.Count() == 0)
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:1921/CMPs.svc/CMPs/"+ Convert.ToString(medicoACrear.Cmp));
                req.Method = "GET";
                req.ContentType = "application/json";
                var res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string CmpJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Cmp _Cmp = js.Deserialize<Cmp>(CmpJson);
                if (_Cmp == null)
                {
                    throw new WebFaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 1,
                        MensajeError = "Medico no registrado en CMP."
                    }, HttpStatusCode.InternalServerError);
                }
                else
                {
                    return dao.Crear(medicoACrear); 
                }
            }
            else
            {
                throw new WebFaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 2,
                        MensajeError = "Medico ya existe... VERIFICAR."
                    }, HttpStatusCode.InternalServerError);
            }
            
        }

        public Medico ObtenerMedico(string IdMedico)
        {
            Medico Medico = null;
            Medico = dao.Obtener(Convert.ToInt16(IdMedico));
            if (Medico == null)
                throw new WebFaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 3,
                        MensajeError = "El Medico a obtener no se encuentra registrado."
                    }, HttpStatusCode.InternalServerError);
            return Medico;
        }

        public Medico ModificarMedico(Medico medicoAModificar)
        {
            ICollection<Medico> _lista = dao.BuscarMedicosDuplicados(medicoAModificar).ToList();
            if (_lista.Count() > 0)
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:1921/CMPs.svc/CMPs/" + Convert.ToString(medicoAModificar.Cmp));
                req.Method = "GET";
                req.ContentType = "application/json";
                var res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string CmpJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Cmp _Cmp = js.Deserialize<Cmp>(CmpJson);
                if (_Cmp == null)
                {
                    throw new WebFaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 4,
                        MensajeError = "Medico no registrado en CMP."
                    }, HttpStatusCode.InternalServerError);
                }
                else
                {
                    return dao.Modificar(medicoAModificar);
                }
            }
            else
            {
                throw new WebFaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 5,
                        MensajeError = "Medico No existe... VERIFICAR."
                    }, HttpStatusCode.InternalServerError);
            }

        }

        public void EliminarMedico(string IdMedico)
        {
            Medico MedicoExistente = dao.Obtener(Convert.ToInt16(IdMedico));
            if (MedicoExistente == null)
                throw new WebFaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 6,
                        MensajeError = "El Medico a eliminar no se encuentra registrado."
                    }, HttpStatusCode.InternalServerError);
            dao.Eliminar(MedicoExistente);
        }

        public List<Medico> ListarMedicos()
        {
            List<Medico> listaMedico = dao.ListarTodos().ToList();
            if (listaMedico.Count() == 0)
                throw new WebFaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 7,
                        MensajeError = "La lista no devolvió datos."
                    }, HttpStatusCode.InternalServerError);
            return listaMedico;
        }


        public List<Medico> BuscarMedicosPorEsp(string Especialidad)
        {
            List<Medico> listaMedico = dao.BuscarMedicosPorEspecialidad(Especialidad).ToList();
            if (listaMedico.Count() == 0)
                throw new WebFaultException<Observacion>(
                    new Observacion()
                    {
                        CodigoError = 8,
                        MensajeError = "La lista no devolvió datos."
                    }, HttpStatusCode.InternalServerError);
            return listaMedico;
        }
    }
}
