using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheRevenge.SOAPTest
{
    /// <summary>
    /// Descripción resumida de TestPaciente
    /// </summary>
    [TestClass]
    public class TestPaciente
    {
        [TestMethod]
        public void ConsultaPaciente()
        {
            ServicePaciente.PacientesServiceClient proxy = new ServicePaciente.PacientesServiceClient();
            try
            {
                ServicePaciente.Paciente Paciente = proxy.consultarPaciente(1);
                Assert.AreEqual(Paciente.Id_Paciente, 1);
            }
            catch (Exception e)
            {
                Assert.AreEqual("SOAP_NotFoundFail", e.Message);
            }
        }

        [TestMethod]
        public void RegistrarPaciente_CodYaIngresado()
        {
            ServicePaciente.Paciente _Paciente = new ServicePaciente.Paciente()
            {
                Nombres = "Yolvi",
                Ape_Paterno = "Escobar",
                Ape_Materno = "Vega",
                Sexo = "M",
                Id_Tipo_Doc = 1,
                Nro_Documento = "46904157",
                Correo = "yolvi13@gmail.com",
                Direccion = "-",
                Telefono = "997511821",
                Fec_Nac = DateTime.Now,
                Password = "p@ssw0rd"
            };

            try
            {
                ServicePaciente.PacientesServiceClient proxy = new ServicePaciente.PacientesServiceClient();
                ServicePaciente.Paciente Paciente = proxy.crearPaciente(_Paciente);
                Assert.AreEqual(Paciente.Nombres, _Paciente.Nombres);
                Assert.AreEqual(Paciente.Ape_Paterno, _Paciente.Ape_Paterno);
                Assert.AreEqual(Paciente.Ape_Materno, _Paciente.Ape_Materno);
                Assert.AreEqual(Paciente.Sexo, _Paciente.Sexo);
                Assert.AreEqual(Paciente.Id_Tipo_Doc, _Paciente.Id_Tipo_Doc);
                Assert.AreEqual(Paciente.Nro_Documento, _Paciente.Nro_Documento);
                Assert.AreEqual(Paciente.Correo, _Paciente.Correo);
                Assert.AreEqual(Paciente.Direccion, _Paciente.Direccion);
                Assert.AreEqual(Paciente.Telefono, _Paciente.Telefono);
                Assert.AreEqual(Paciente.Fec_Nac, _Paciente.Fec_Nac);
                Assert.AreEqual(Paciente.Password, _Paciente.Password);

            }
            catch (Exception e)
            {

                Assert.AreEqual("SOAP_InsertFail", e.Message);
            }
            
        }
        [TestMethod]
        public void RegistrarPaciente_DatosYaIngresados()
        {
            ServicePaciente.Paciente _Paciente = new ServicePaciente.Paciente()
            {
                Nombres = "Yolvi",
                Ape_Paterno = "Escobar",
                Ape_Materno = "Vega",
                Sexo = "M",
                Id_Tipo_Doc = 1,
                Nro_Documento = "46904157",
                Correo = "yolvi13@gmail.com",
                Direccion = "-",
                Telefono = "997511821",
                Fec_Nac = DateTime.Now,
                Password = "p@ssw0rd"
            };

            try
            {
                ServicePaciente.PacientesServiceClient proxy = new ServicePaciente.PacientesServiceClient();
                ServicePaciente.Paciente Paciente = proxy.crearPaciente(_Paciente);
                Assert.AreEqual(Paciente.Nombres, _Paciente.Nombres);
                Assert.AreEqual(Paciente.Ape_Paterno, _Paciente.Ape_Paterno);
                Assert.AreEqual(Paciente.Ape_Materno, _Paciente.Ape_Materno);
                Assert.AreEqual(Paciente.Sexo, _Paciente.Sexo);
                Assert.AreEqual(Paciente.Id_Tipo_Doc, _Paciente.Id_Tipo_Doc);
                Assert.AreEqual(Paciente.Nro_Documento, _Paciente.Nro_Documento);
                Assert.AreEqual(Paciente.Correo, _Paciente.Correo);
                Assert.AreEqual(Paciente.Direccion, _Paciente.Direccion);
                Assert.AreEqual(Paciente.Telefono, _Paciente.Telefono);
                Assert.AreEqual(Paciente.Fec_Nac, _Paciente.Fec_Nac);
                Assert.AreEqual(Paciente.Password, _Paciente.Password);

            }
            catch (Exception e)
            {

                Assert.AreEqual("SOAP_2_InsertFail", e.Message);
            }

        }
        [TestMethod]
        public void ActualizarPaciente_NoExiste()
        {
            ServicePaciente.Paciente _Paciente = new ServicePaciente.Paciente()
            {
                Nombres = "Yolvi",
                Ape_Paterno = "Escobar",
                Ape_Materno = "Vega",
                Sexo = "M",
                Id_Tipo_Doc = 1,
                Nro_Documento = "46904157",
                Correo = "yolvi13@gmail.com",
                Direccion = "-",
                Telefono = "997511821",
                Fec_Nac = DateTime.Now,
                Password = "p@ssw0rd"
            };

            try
            {
                ServicePaciente.PacientesServiceClient proxy = new ServicePaciente.PacientesServiceClient();
                ServicePaciente.Paciente Paciente = proxy.actualizarPaciente(_Paciente);
                Assert.AreEqual(Paciente.Nombres, _Paciente.Nombres);
                Assert.AreEqual(Paciente.Ape_Paterno, _Paciente.Ape_Paterno);
                Assert.AreEqual(Paciente.Ape_Materno, _Paciente.Ape_Materno);
                Assert.AreEqual(Paciente.Sexo, _Paciente.Sexo);
                Assert.AreEqual(Paciente.Id_Tipo_Doc, _Paciente.Id_Tipo_Doc);
                Assert.AreEqual(Paciente.Nro_Documento, _Paciente.Nro_Documento);
                Assert.AreEqual(Paciente.Correo, _Paciente.Correo);
                Assert.AreEqual(Paciente.Direccion, _Paciente.Direccion);
                Assert.AreEqual(Paciente.Telefono, _Paciente.Telefono);
                Assert.AreEqual(Paciente.Fec_Nac, _Paciente.Fec_Nac);
                Assert.AreEqual(Paciente.Password, _Paciente.Password);

            }
            catch (Exception e)
            {

                Assert.AreEqual("SOAP_UpdateFail", e.Message);
            }

        }
        [TestMethod]
        public void ActualizarPaciente_DatosYaExisten()
        {
            ServicePaciente.Paciente _Paciente = new ServicePaciente.Paciente()
            {
                Nombres = "Yolvi",
                Ape_Paterno = "Escobar",
                Ape_Materno = "Vega",
                Sexo = "M",
                Id_Tipo_Doc = 1,
                Nro_Documento = "46904157",
                Correo = "yolvi13@gmail.com",
                Direccion = "-",
                Telefono = "997511821",
                Fec_Nac = DateTime.Now,
                Password = "p@ssw0rd"
            };

            try
            {
                ServicePaciente.PacientesServiceClient proxy = new ServicePaciente.PacientesServiceClient();
                ServicePaciente.Paciente Paciente = proxy.actualizarPaciente(_Paciente);
                Assert.AreEqual(Paciente.Nombres, _Paciente.Nombres);
                Assert.AreEqual(Paciente.Ape_Paterno, _Paciente.Ape_Paterno);
                Assert.AreEqual(Paciente.Ape_Materno, _Paciente.Ape_Materno);
                Assert.AreEqual(Paciente.Sexo, _Paciente.Sexo);
                Assert.AreEqual(Paciente.Id_Tipo_Doc, _Paciente.Id_Tipo_Doc);
                Assert.AreEqual(Paciente.Nro_Documento, _Paciente.Nro_Documento);
                Assert.AreEqual(Paciente.Correo, _Paciente.Correo);
                Assert.AreEqual(Paciente.Direccion, _Paciente.Direccion);
                Assert.AreEqual(Paciente.Telefono, _Paciente.Telefono);
                Assert.AreEqual(Paciente.Fec_Nac, _Paciente.Fec_Nac);
                Assert.AreEqual(Paciente.Password, _Paciente.Password);

            }
            catch (Exception e)
            {

                Assert.AreEqual("SOAP_2_UpdateFail", e.Message);
            }

        }

        [TestMethod]
        public void ListarPaciente()
        {
            int cantLista;
            int f;
            try
            {
                ServicePaciente.PacientesServiceClient proxy = new ServicePaciente.PacientesServiceClient();
                ServicePaciente.Paciente[] Pacienteproducto = proxy.listarPaciente();
                cantLista = Pacienteproducto.Length;
                if (cantLista == 8)
                {
                    for (f = 1; f <= Pacienteproducto.Length; f++)
                    {
                        Assert.AreEqual(Pacienteproducto[0].Id_Paciente, 1);
                    }
                }
                else
                    Assert.Fail();
            }
            catch (Exception e)
            {

                Assert.AreEqual("SOAP_EmptyListFail", e.Message);
            }
            
        }

        [TestMethod]
        public void EliminarPaciente()
        {
            try
            {
                ServicePaciente.PacientesServiceClient proxy = new ServicePaciente.PacientesServiceClient();
                proxy.eliminarPaciente(5);
                Assert.AreEqual(null, proxy.consultarPaciente(5));
            }
            catch (Exception e)
            {

                Assert.AreEqual("SOAP_DeleteFail", e.Message);
            }
            



        }
    }
}
