using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheRevenge.SOAPTest
{
    [TestClass]
    public class TestEstadoCita
    {
        [TestMethod]
        public void TestListarEstadoCitas()
        {
            ServiceEstadoCita.EstadoCitasServiceClient proxy = new ServiceEstadoCita.EstadoCitasServiceClient();
            ServiceEstadoCita.EstadoCita[] resultado = proxy.ListarEstadoCita();
            int e;
            for (e = 1; e <= resultado.Length; e++)
            {
                Assert.AreEqual(resultado[0].Id_Estado,1);
            }
        }
    }
}
