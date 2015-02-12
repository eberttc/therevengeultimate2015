using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheRevenge.Data.Dominio;

namespace TheRevenge.SOAPTest
{
    /// <summary>
    /// Descripción resumida de TestMedico
    /// </summary>
    [TestClass]
    public class TestMedico
    {
        //[TestMethod]
        //public void ConsultaMedico()
        //{
        //    ServiceMedico.MedicosServiceClient proxy = new ServiceMedico.MedicosServiceClient();
        //    try
        //    {
        //        ServiceMedico.Medico _Medico = proxy.consultarMedico(1);
        //        Assert.AreEqual(_Medico.IdMedico, 1);
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.AreEqual("SOAP_NotFoundFail", e.Message);
        //    }
        //}

        //[TestMethod]
        //public void RegistrarMedico_CodYaIngresado()
        //{
        //    ServiceMedico.Medico _Medico = new ServicePaciente.Medico()
        //    {
        //        Nombres = "Juan",
        //        Ape_Paterno = "Perez",
        //        Ape_Materno = "Cordova",
        //        Sexo = "M",
        //        Id_Tipo_Doc = 1,
        //        Nro_Documento = "26453262",
        //        Correo = "jperezc@gmail.com",
        //        Direccion = "Los Alisos 123",
        //        Telefono = "951357864",
        //        Fec_Nac = DateTime.Now,
        //        Password = "p@ssw0rd"
        //    };

        //    try
        //    {
        //        ServiceMedico.MedicosServiceClient proxy = new ServiceMedico.MedicosServiceClient();
        //        ServicePaciente.Medico Medico = proxy.crearMedico(_Medico);
        //        Assert.AreEqual(Medico.Nombre, _Medico.Nombre);
        //        Assert.AreEqual(Medico.Ape_Paterno, _Medico.Ape_Paterno);
        //        Assert.AreEqual(Medico.Ape_Materno, _Medico.Ape_Materno);
        //        Assert.AreEqual(Medico.Sexo, _Medico.Sexo);
        //        Assert.AreEqual(Medico.Tipo_Documento, _Medico.Tipo_Documento);
        //        Assert.AreEqual(Medico.Nro_Documento, _Medico.Nro_Documento);
        //        Assert.AreEqual(Medico.Correo, _Medico.Correo);
        //        Assert.AreEqual(Medico.Direccion, _Medico.Direccion);
        //        Assert.AreEqual(Medico.Telefono, _Medico.Telefono);
        //        Assert.AreEqual(Medico.Fec_Nac, _Medico.Fec_Nac);
        //        Assert.AreEqual(Medico.Password, _Medico.Password);

        //    }
        //    catch (Exception e)
        //    {

        //        Assert.AreEqual("SOAP_InsertFail", e.Message);
        //    }

        //}
        

        //[TestMethod]
        //public void ActualizarMedico_NoExiste()
        //{
        //    ServicePaciente.Medico _Medico = new ServiceMedico.Medico()
        //    {
        //         Nombres = "Juan",
        //        Ape_Paterno = "Perez",
        //        Ape_Materno = "Cordova",
        //        Sexo = "M",
        //        Id_Tipo_Doc = 1,
        //        Nro_Documento = "26453262",
        //        Correo = "jperezc@gmail.com",
        //        Direccion = "Los Alisos 123",
        //        Telefono = "951357864",
        //        Fec_Nac = DateTime.Now,
        //        Password = "p@ssw0rd"
        //    };

        //    try
        //    {
        //        ServiceMedico.MedicosServiceClient proxy = new ServiceMedico.MedicosServiceClient();
        //        ServiceMedico.Medico Medico = proxy.actualizarMedico(_Medico);
        //        Assert.AreEqual(Medico.Nombre, _Medico.Nombres);
        //        Assert.AreEqual(Medico.Ape_Paterno, _Medico.Ape_Paterno);
        //        Assert.AreEqual(Medico.Ape_Materno, _Medico.Ape_Materno);
        //        Assert.AreEqual(Medico.Sexo, _Medico.Sexo);
        //        Assert.AreEqual(Medico.Tipo_Documento, _Medico.Tipo_Documento);
        //        Assert.AreEqual(Medico.Nro_Documento, _Medico.Nro_Documento);
        //        Assert.AreEqual(Medico.Correo, _Medico.Correo);
        //        Assert.AreEqual(Medico.Direccion, _Medico.Direccion);
        //        Assert.AreEqual(Medico.Telefono, _Medico.Telefono);
        //        Assert.AreEqual(Medico.Fec_Nac, _Medico.Fec_Nac);
        //        Assert.AreEqual(Medico.Password, _Medico.Password);

        //    }
        //    catch (Exception e)
        //    {

        //        Assert.AreEqual("SOAP_UpdateFail", e.Message);
        //    }

        //}

        //[TestMethod]
        //public void ListarMedico()
        //{
        //    int cantLista;
        //    int f;
        //    try
        //    {
        //        ServiceMedico.MedicosServiceClient proxy = new ServiceMedico.MedicosServiceClient();
        //        ServiceMedico.Medico[] Medicoproducto = proxy.listarMedico();
        //        cantLista = Medicoproducto.Length;
        //        if (cantLista == 8)
        //        {
        //            for (f = 1; f <= Medicoproducto.Length; f++)
        //            {
        //                Assert.AreEqual(Medicoproducto[0].IdMedico, 1);
        //            }
        //        }
        //        else
        //            Assert.Fail();
        //    }
        //    catch (Exception e)
        //    {

        //        Assert.AreEqual("SOAP_EmptyListFail", e.Message);
        //    }

        //}

        //[TestMethod]
        //public void EliminarPaciente()
        //{
        //    try
        //    {
        //        ServiceMedico.MedicosServiceClient proxy = new ServiceMedico.MedicosServiceClient();
        //        proxy.eliminarMedico(5);
        //        Assert.AreEqual(null, proxy.consultarMedico(5));
        //    }
        //    catch (Exception e)
        //    {

        //        Assert.AreEqual("SOAP_DeleteFail", e.Message);
        //    }




        //}

        
    }
}
