using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheRevenge.SOAPTest
{
    /// <summary>
    /// Descripción resumida de TestTipoDocumento
    /// </summary>
    [TestClass]
    public class TestTipoDocumento
    {
       
        [TestMethod]
        public void listarTipo_Documento()
        {
            int cantLista;
            int f;
            ServiceTipoDoc.TiposDocServiceClient proxy = new ServiceTipoDoc.TiposDocServiceClient();
            ServiceTipoDoc.Tipo_Documento[] TipoDoc = proxy.listarTipo_Documento();
            cantLista = TipoDoc.Length;
            if (cantLista == 8)
            {
                for (f = 1; f <= TipoDoc.Length; f++)
                {
                    Assert.AreEqual(TipoDoc[0].ID_Tipo_Doc, 1);
                }
            }
            else
                Assert.Fail();
        }
    }
}
