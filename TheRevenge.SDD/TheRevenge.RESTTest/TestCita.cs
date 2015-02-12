using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using TheRevenge.Data.Dominio;

namespace TheRevenge.RESTTest
{
    [TestClass]
    public class TestCita
    {
        [TestMethod]
        public void Post()
        {
            //--------post
            //Prueba de creación de extintor vía HTTP POST
            string postdata = "{\"FecAtencion\":\"21/02/2015\",\"Diagnostico\":\"Sano\",\"Observacion\":\"\",\"IdEspecialidad\":1,\"IdPaciente\":1,\"IdEstado\":2,\"IdMedico\":3,\"IdHorario\":4}";//JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:1921/Citas.svc/Citas");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string citaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Cita citaCreado = js.Deserialize<Cita>(citaJson);
            Assert.AreEqual("21/02/2015", citaCreado.FecAtencion);
            Assert.AreEqual("Sano", citaCreado.Diagnostico);
            Assert.AreEqual("", citaCreado.Observacion);
            Assert.AreEqual(1, citaCreado.IdEspecialidad);
            Assert.AreEqual(1, citaCreado.IdPaciente);
            Assert.AreEqual(2, citaCreado.IdEstado);
            Assert.AreEqual(3, citaCreado.IdMedico);
            Assert.AreEqual(4, citaCreado.IdHorario);
        }
        [TestMethod]
        public void GetList()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest
               .Create("http://localhost:1921/Citas.svc/Citas");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Cita> citaLista = js.Deserialize<List<Cita>>(tramaJson);
            Assert.IsTrue(citaLista.Count > 0);
        }
        [TestMethod]
        public void get()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:1921/Citas.svc/Citas/1");
            req.Method = "GET";
            req.ContentType = "application/json";
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string CitaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Cita CitaCreado = js.Deserialize<Cita>(CitaJson);
            Assert.AreEqual(1, CitaCreado.IdCita);
        }
        [TestMethod]
        public void Delete()
        {
            HttpWebRequest request1 = (HttpWebRequest)WebRequest
               .Create("http://localhost:1921/Citas.svc/Citas/2");
            request1.Method = "DELETE";
            HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();
            StreamReader reader1 = new StreamReader(response1.GetResponseStream());
            string tramaJson1 = reader1.ReadToEnd();
            JavaScriptSerializer js1 = new JavaScriptSerializer();
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:1921/Citas.svc/Citas/2");
            req.Method = "GET";
            req.ContentType = "application/json";
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string CitaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Cita CitaCreado = js.Deserialize<Cita>(CitaJson);
            Assert.AreEqual(null, CitaCreado);
        }
        [TestMethod]
        public void Put()
        {
            string postdata = "{\"IdCita\":1,\"FecAtencion\":\"21/02/2015\",\"Diagnostico\":\"Sano\",\"Observacion\":\"\",\"IdEspecialidad\":1,\"IdPaciente\":1,\"IdEstado\":2,\"IdMedico\":3,\"IdHorario\":4}";//JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest request = (HttpWebRequest)WebRequest
               .Create("http://localhost:1921/Citas.svc/Citas");
            request.Method = "PUT";
            request.ContentLength = data.Length;
            request.ContentType = "application/json";
            var reqStream = request.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Cita citaModif = js.Deserialize<Cita>(tramaJson);
            Assert.AreEqual(1, citaModif.IdCita);
            Assert.AreEqual("21/02/2015", citaModif.FecAtencion);
            Assert.AreEqual("Sano", citaModif.Diagnostico);
            Assert.AreEqual("", citaModif.Observacion);
            Assert.AreEqual(1, citaModif.IdEspecialidad);
            Assert.AreEqual(1, citaModif.IdPaciente);
            Assert.AreEqual(2, citaModif.IdEstado);
            Assert.AreEqual(3, citaModif.IdMedico);
            Assert.AreEqual(4, citaModif.IdHorario);
        }
    }
}
