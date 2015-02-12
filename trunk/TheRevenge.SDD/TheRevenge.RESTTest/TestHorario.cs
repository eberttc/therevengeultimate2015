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
    public class TestHorario
    {
        [TestMethod]
        public void Post()
        {
            //--------post
            //Prueba de creación de extintor vía HTTP POST
            string postdata = "{\"ValHor\":\"08:00 am - 08:30 am\"}";//JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:1921/Horarios.svc/Horarios");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string horariosJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Horario horariosCreado = js.Deserialize<Horario>(horariosJson);
            Assert.AreEqual("08:00 am - 08:30 am", horariosCreado.ValHor);
        }
        [TestMethod]
        public void GetList()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest
               .Create("http://localhost:1921/Horarios.svc/Horarios");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Horario> horariosLista = js.Deserialize<List<Horario>>(tramaJson);
            Assert.IsTrue(horariosLista.Count > 0);
        }
        [TestMethod]
        public void get()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:1921/Horarios.svc/Horarios/1");
            req.Method = "GET";
            req.ContentType = "application/json";
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string HorarioJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Horario HorarioCreado = js.Deserialize<Horario>(HorarioJson);
            Assert.AreEqual(1, HorarioCreado.IdHorario);
        }
        [TestMethod]
        public void Delete()
        {
            HttpWebRequest request1 = (HttpWebRequest)WebRequest
               .Create("http://localhost:1921/Horarios.svc/Horarios/2");
            request1.Method = "DELETE";
            HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();
            StreamReader reader1 = new StreamReader(response1.GetResponseStream());
            string tramaJson1 = reader1.ReadToEnd();
            JavaScriptSerializer js1 = new JavaScriptSerializer();

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:1921/Horarios.svc/Horarios/2");
            req.Method = "GET";
            req.ContentType = "application/json";
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string HorarioJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Horario HorarioCreado = js.Deserialize<Horario>(HorarioJson);
            Assert.AreEqual(null, HorarioCreado);
        }
        [TestMethod]
        public void Put()
        {
            string postdata = "{\"IdHorario\":1,\"ValHor\":\"08:00 am - 08:30 am\"}";//JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest request = (HttpWebRequest)WebRequest
               .Create("http://localhost:1921/Horarios.svc/Horarios");
            request.Method = "PUT";
            request.ContentLength = data.Length;
            request.ContentType = "application/json";
            var reqStream = request.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Horario horariosModif = js.Deserialize<Horario>(tramaJson);
            Assert.AreEqual(1, horariosModif.IdHorario);
            Assert.AreEqual("08:00 am - 08:30 am", horariosModif.ValHor);
        }
    }
}
