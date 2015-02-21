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
        public void Post_Duplicado()
        {
            try
            {
                //--------post
                //Prueba de creación de extintor vía HTTP POST
                string postdata = "{\"Nombre\":\"Yolvi\",\"Ape_Paterno\":\"Escobar\",\"Ape_Materno\":\"Vega\",\"Sexo\":\"M\",\"Tipo_Documento\":1,\"Nro_Documento\":\"23\",\"Cmp\":1,\"Especialidad\":2,\"Direccion\":\"Jr. Hoyle P.\",\"Telefono\":\"3270317\",\"Correo\":\"EBERT@HOMTAIL.COM\",\"Password\":\"yolvi\"}";//JSON
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
                Assert.AreEqual("3270317", MedicoCreado.Telefono);
                Assert.AreEqual("yolvi13@gmail.com", MedicoCreado.Correo);
                Assert.AreEqual("yolvi", MedicoCreado.Password); 
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Observacion Observacion = js.Deserialize<Observacion>(error);
                Assert.AreEqual("Medico ya existe... VERIFICAR.", Observacion.MensajeError);
            }
        }

        public void Post_CMPNoRegistrado()
        {
            try
            {
                //--------post
                //Prueba de creación de extintor vía HTTP POST
                string postdata = "{\"Nombre\":\"Yolvi\",\"Ape_Paterno\":\"Escobar\",\"Ape_Materno\":\"Vega\",\"Sexo\":\"M\",\"Tipo_Documento\":1,\"Nro_Documento\":\"46904157\",\"Cmp\":12,\"Especialidad\":2,\"Direccion\":\"Jr. Hoyle P.\",\"Telefono\":\"3270317\",\"Correo\":\"yolvi13@gmail.com\",\"Password\":\"yolvi\"}";//JSON
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
                Assert.AreEqual("3270317", MedicoCreado.Telefono);
                Assert.AreEqual("yolvi13@gmail.com", MedicoCreado.Correo);
                Assert.AreEqual("yolvi", MedicoCreado.Password);
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Observacion Observacion = js.Deserialize<Observacion>(error);
                Assert.AreEqual("Medico no registrado en CMP.", Observacion.MensajeError);
            }
        }
        [TestMethod]
        public void GetListXEsp()
        {
            try
            {
                string postdata = "{\"Especialidad\":2}";//JSON
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest req = (HttpWebRequest)WebRequest
                    .Create("http://localhost:1921/Medicos.svc/Medicos");
                req.Method = "POST";
                req.ContentLength = data.Length;
                req.ContentType = "application/json";
                var reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string tramaJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                List<Medico> MedicoLista = js.Deserialize<List<Medico>>(tramaJson);
                Assert.IsTrue(MedicoLista.Count > 0);
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Observacion Observacion = js.Deserialize<Observacion>(error);
                Assert.AreEqual("La lista no devolvió datos.", Observacion.MensajeError);
            }
        }
        [TestMethod]
        public void GetList()
        {
            try
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
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Observacion Observacion = js.Deserialize<Observacion>(error);
                Assert.AreEqual("La lista no devolvió datos.", Observacion.MensajeError);
            }
        }
        [TestMethod]
        public void get()
        {
            try
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
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Observacion Observacion = js.Deserialize<Observacion>(error);
                Assert.AreEqual("El Medico a obtener no se encuentra registrado.", Observacion.MensajeError);
            }
            
        }
        [TestMethod]
        public void Delete()
        {
            try
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
            catch (WebException e )
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Observacion Observacion = js.Deserialize<Observacion>(error);
                Assert.AreEqual("El Medico a eliminar no se encuentra registrado.", Observacion.MensajeError);
            }
        }
        [TestMethod]
        public void PutMedicoCMPNoReg()
        {
            try
            {
                string postdata = "{\"IdMedico\":2,\"Nombre\":\"Yolvi\",\"Ape_Paterno\":\"Escobar\",\"Ape_Materno\":\"Vega\",\"Sexo\":\"M\",\"Tipo_Documento\":1,\"Nro_Documento\":\"46904157\",\"Cmp\":12,\"Especialidad\":2,\"Direccion\":\"Jr. Hoyle P.\",\"Telefono\":\"3270317\",\"Correo\":\"yolvi13@gmail.com\",\"Password\":\"yolvi\"}";//JSON
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
                Assert.AreEqual("3270317", MedicoModif.Telefono);
                Assert.AreEqual("yolvi13@gmail.com", MedicoModif.Correo);
                Assert.AreEqual("yolvi", MedicoModif.Password); 
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Observacion Observacion = js.Deserialize<Observacion>(error);
                Assert.AreEqual("Medico no registrado en CMP.", Observacion.MensajeError);
            } 
        }
        [TestMethod]
        public void PutMedicoNoExiste()
        {
            try
            {
                string postdata = "{\"IdMedico\":2,\"Nombre\":\"Yolvi\",\"Ape_Paterno\":\"Escobar\",\"Ape_Materno\":\"Vega\",\"Sexo\":\"M\",\"Tipo_Documento\":1,\"Nro_Documento\":\"46904157\",\"Cmp\":12,\"Especialidad\":2,\"Direccion\":\"Jr. Hoyle P.\",\"Telefono\":\"3270317\",\"Correo\":\"yolvi13@gmail.com\",\"Password\":\"yolvi\"}";//JSON
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
                Assert.AreEqual("3270317", MedicoModif.Telefono);
                Assert.AreEqual("yolvi13@gmail.com", MedicoModif.Correo);
                Assert.AreEqual("yolvi", MedicoModif.Password);
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Observacion Observacion = js.Deserialize<Observacion>(error);
                Assert.AreEqual("Medico No existe... VERIFICAR.", Observacion.MensajeError);
            }
        }

    }
}
