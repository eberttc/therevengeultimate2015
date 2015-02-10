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
    /// Descripción resumida de TestCMP
    /// </summary>
    [TestClass]
    public class TestCMP
    {
        [TestMethod]
        public void Post()
        {
            //--------post
            //Prueba de creación de extintor vía HTTP POST
            string postdata = "{\"TxDescripcion\":\"Olenka Escobar\",\"TxDoc_Identidad\":\"00000000\"}";//JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:1921/CMPs.svc/CMPs");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string cmpJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Cmp cmpCreado = js.Deserialize<Cmp>(cmpJson);
            Assert.AreEqual("Olenka Escobar", cmpCreado.TxDescripcion);
            Assert.AreEqual("00000000", cmpCreado.TxDoc_Identidad);
        }
        [TestMethod]
        public void GetList()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest
               .Create("http://localhost:1921/CMPs.svc/CMPs");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Cmp> cmpLista = js.Deserialize<List<Cmp>>(tramaJson);
            Assert.IsTrue(cmpLista.Count > 0);
        }
        [TestMethod]
        public void get()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:1921/CMPs.svc/CMPs/1");
            req.Method = "GET";
            req.ContentType = "application/json";
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string CmpJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Cmp CmpCreado = js.Deserialize<Cmp>(CmpJson);
            Assert.AreEqual(1, CmpCreado.IdCmp);
        }
        [TestMethod]
        public void Delete()
        {
            HttpWebRequest request1 = (HttpWebRequest)WebRequest
               .Create("http://localhost:1921/CMPs.svc/CMPs/2");
            request1.Method = "DELETE";
            HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();
            StreamReader reader1 = new StreamReader(response1.GetResponseStream());
            string tramaJson1 = reader1.ReadToEnd();
            JavaScriptSerializer js1 = new JavaScriptSerializer();


            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:1921/CMPs.svc/CMPs/2");
            req.Method = "GET";
            req.ContentType = "application/json";
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string CmpJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Cmp CmpCreado = js.Deserialize<Cmp>(CmpJson);
            Assert.AreEqual(null, CmpCreado);
        }
        [TestMethod]
        public void Put()
        {
            string postdata = "{\"IdCmp\":2,\"TxDescripcion\":\"Alyssa Escobar Vega\",\"TxDoc_Identidad\":\"22222222\"}";//JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest request = (HttpWebRequest)WebRequest
               .Create("http://localhost:1921/CMPs.svc/CMPs");
            request.Method = "PUT";
            request.ContentLength = data.Length;
            request.ContentType = "application/json";
            var reqStream = request.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Cmp cmpModif = js.Deserialize<Cmp>(tramaJson);
            Assert.AreEqual(5, cmpModif.IdCmp);
            Assert.AreEqual("Alyssa Escobar Vega", cmpModif.TxDescripcion);
            Assert.AreEqual("22222222", cmpModif.TxDoc_Identidad);
        }
    }
}
