using System;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Centralita c = new Centralita();

            Assert.IsNotNull(c.Llamadas);
        }
    }
}
