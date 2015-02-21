using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheRevenge.SOAPTest
{
    [TestClass]
    public class TestCmp
    {
        [TestMethod]
        public void ConsultaCmp()
        {
            ServiceCmp.CmpesServiceClient proxy = new ServiceCmp.CmpesServiceClient();

            try
            {
                ServiceCmp.Cmp Cmp = proxy.consultarCmp(1);
                Assert.AreEqual(Cmp.IdCmp, 1);
            }
            catch (Exception e)
            {
                Assert.AreEqual(null, e.InnerException);

            }
        }

        [TestMethod]
        public void RegistrarCmp()
        {
            ServiceCmp.CmpesServiceClient proxy = new ServiceCmp.CmpesServiceClient();
            ServiceCmp.Cmp Cmp = proxy.crearCmp("Olenka Escobar","07057975");
            Assert.AreEqual(Cmp.TxDescripcion, "Olenka Escobar");
            Assert.AreEqual(Cmp.TxDoc_Identidad, "07057975");

        }


        [TestMethod]
        public void ListarDetalleCmp()
        {
            ServiceCmp.CmpesServiceClient proxy = new ServiceCmp.CmpesServiceClient();
            ServiceCmp.Cmp[] Cmpproducto = proxy.listarCmp();
            
            int f;
            for (f = 1; f <= Cmpproducto.Length; f++)
            {
                Assert.AreEqual(Cmpproducto[0].IdCmp, 1);
            }

        }

        [TestMethod]
        public void EliminarCmp()
        {
            ServiceCmp.CmpesServiceClient proxy = new ServiceCmp.CmpesServiceClient();
            proxy.eliminarCmp(5);
            Assert.AreEqual(null, proxy.consultarCmp(5));

            

        }
    }
}
