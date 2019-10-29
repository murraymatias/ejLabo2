using System;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsUnitarios
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestMethod1()
        {
            // Arrenge
            Centralita c = new Centralita("Test");

            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "SanRafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            // Act

            c += l1;
            c += l2;
            c += l3;
            c += l4;

            // Assert
            try
            {
                c += l4;
                Assert.Fail();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
