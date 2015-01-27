using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using TheRevenge.Data.Dominio;


namespace TheRevenge.SOAPTest
{
    [TestClass]
    public class TestHorario
    {
        [TestMethod]
        public void TestListarHorarios()
        {
            ServiceHorario.HorariosServiceClient proxy = new ServiceHorario.HorariosServiceClient();
            //List<Horario> resultado = proxy.ListarHorario();
            ServiceHorario.Horario[] resultado = proxy.ListarHorario();
            int h;
            for (h = 1; h <= resultado.Length; h++)
            {
                Assert.AreEqual(resultado[0].Id_Horario,1);
            }
                
        }
    }
}
