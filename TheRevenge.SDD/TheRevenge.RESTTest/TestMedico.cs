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
    /// <summary>
    /// Descripción resumida de TestMedico
    /// </summary>
    [TestClass]
    public class TestMedico
    {
        [TestMethod]
        public void Post()
        {
            //--------post
            //Prueba de creación de extintor vía HTTP POST
            string postdata = "{\"Nombre\":\"Yolvi\",\"Ape_Paterno\":\"Escobar\",\"Ape_Materno\":\"Vega\",\"Sexo\":\"M\",\"Tipo_Documento\":1,\"Nro_Documento\":\"46904157\",\"Cmp\":12,\"Especialidad\":2,\"Direccion\":\"Jr. Hoyle P.\",\"Correo\":\"yolvi13@gmail.com\",\"Password\":\"yolvi\"}";//JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:1921/Medicos.svc/Medicos");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string MedicoJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Medico MedicoCreado = js.Deserialize<Medico>(MedicoJson);
            Assert.AreEqual("Yolvi", MedicoCreado.Nombre);
            Assert.AreEqual("Escobar", MedicoCreado.Ape_Paterno); 
            Assert.AreEqual("Vega", MedicoCreado.Ape_Materno); 
            Assert.AreEqual("M", MedicoCreado.Sexo);
            Assert.AreEqual(1, MedicoCreado.Tipo_Documento);
            Assert.AreEqual("46904157", MedicoCreado.Nro_Documento);
            Assert.AreEqual(1, MedicoCreado.Cmp);
            Assert.AreEqual(12, MedicoCreado.Especialidad);
            Assert.AreEqual("Jr. Hoyle P.", MedicoCreado.Direccion);
            Assert.AreEqual("yolvi13@gmail.com", MedicoCreado.Correo);
            Assert.AreEqual("yolvi", MedicoCreado.Password); 
        }
        [TestMethod]
        public void GetList()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest
               .Create("http://localhost:1921/Medicos.svc/Medicos");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Medico> MedicoLista = js.Deserialize<List<Medico>>(tramaJson);
            Assert.IsTrue(MedicoLista.Count > 0);
        }
        [TestMethod]
        public void get()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:1921/Medicos.svc/Medicos/1");
            req.Method = "GET";
            req.ContentType = "application/json";
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string MedicoJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Medico MedicoCreado = js.Deserialize<Medico>(MedicoJson);
            Assert.AreEqual(1, MedicoCreado.IdMedico);
        }
        [TestMethod]
        public void Delete()
        {
            HttpWebRequest request1 = (HttpWebRequest)WebRequest
               .Create("http://localhost:1921/Medicos.svc/Medicos/2");
            request1.Method = "DELETE";
            HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();
            StreamReader reader1 = new StreamReader(response1.GetResponseStream());
            string tramaJson1 = reader1.ReadToEnd();
            JavaScriptSerializer js1 = new JavaScriptSerializer();


            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:1921/Medicos.svc/Medicos/2");
            req.Method = "GET";
            req.ContentType = "application/json";
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string MedicoJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Medico MedicoCreado = js.Deserialize<Medico>(MedicoJson);
            Assert.AreEqual(null, MedicoCreado);
        }
        [TestMethod]
        public void Put()
        {
            string postdata = "{\"IdMedico\":2,\"Nombre\":\"Yolvi\",\"Ape_Paterno\":\"Escobar\",\"Ape_Materno\":\"Vega\",\"Sexo\":\"M\",\"Tipo_Documento\":1,\"Nro_Documento\":\"46904157\",\"Cmp\":12,\"Especialidad\":2,\"Direccion\":\"Jr. Hoyle P.\",\"Correo\":\"yolvi13@gmail.com\",\"Password\":\"yolvi\"}";//JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest request = (HttpWebRequest)WebRequest
               .Create("http://localhost:1921/Medicos.svc/Medicos");
            request.Method = "PUT";
            request.ContentLength = data.Length;
            request.ContentType = "application/json";
            var reqStream = request.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Medico MedicoModif = js.Deserialize<Medico>(tramaJson);
            Assert.AreEqual(5, MedicoModif.IdMedico);
            Assert.AreEqual("Yolvi", MedicoModif.Nombre);
            Assert.AreEqual("Escobar", MedicoModif.Ape_Paterno);
            Assert.AreEqual("Vega", MedicoModif.Ape_Materno);
            Assert.AreEqual("M", MedicoModif.Sexo);
            Assert.AreEqual(1, MedicoModif.Tipo_Documento);
            Assert.AreEqual("46904157", MedicoModif.Nro_Documento);
            Assert.AreEqual(1, MedicoModif.Cmp);
            Assert.AreEqual(12, MedicoModif.Especialidad);
            Assert.AreEqual("Jr. Hoyle P.", MedicoModif.Direccion);
            Assert.AreEqual("yolvi13@gmail.com", MedicoModif.Correo);
            Assert.AreEqual("yolvi", MedicoModif.Password); 
        }

    }
}
