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
    /// Descripción resumida de TestEspecialidad
    /// </summary>
    [TestClass]
    public class TestEspecialidad
    {
        [TestMethod]
        public void GetList()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest
               .Create("http://localhost:1921/Especialidades.svc/Especialidades");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Especialidad> cmpLista = js.Deserialize<List<Especialidad>>(tramaJson);
            Assert.IsTrue(cmpLista.Count > 0);
        }
    }
}
