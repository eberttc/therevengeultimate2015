using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheRevenge.Data.Dominio;

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
                Assert.AreEqual(null, e.InnerException);

            }
        }

        [TestMethod]
        public void RegistrarPaciente()
        {
            Paciente _Paciente = new Paciente()
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
            ServicePaciente.PacientesServiceClient proxy = new ServicePaciente.PacientesServiceClient();
            //ServicePaciente.Paciente Paciente = proxy.crearPaciente(_Paciente);
            //Assert.AreEqual(Paciente.TxDescripcion, "Olenka Escobar");
            //Assert.AreEqual(Paciente.TxDoc_Identidad, "07057975");

        }


        [TestMethod]
        public void ListarDetallePaciente()
        {
            //ServicePaciente.PacienteesServiceClient proxy = new ServicePaciente.PacienteesServiceClient();
            ServicePaciente.Paciente[] Pacienteproducto = proxy.listarPaciente();

            int f;
            for (f = 1; f <= Pacienteproducto.Length; f++)
            {
                //Assert.AreEqual(Pacienteproducto[0].IdPaciente, 1);
            }

        }

        [TestMethod]
        public void EliminarPaciente()
        {
            //ServicePaciente.PacienteesServiceClient proxy = new ServicePaciente.PacienteesServiceClient();
            proxy.eliminarPaciente(5);
            Assert.AreEqual(null, proxy.consultarPaciente(5));



        }
    }
}
