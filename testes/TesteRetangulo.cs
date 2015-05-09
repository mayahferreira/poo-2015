using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using poo_paint;

namespace testes
{
    [TestClass]
    public class TesteRetangulo
    {
        [TestMethod]
        public void TestaImprime()
        {
            Retangulo r = new Retangulo(12, 34, 50, 40);
            Assert.AreEqual("retangulo[x:12,y:34,l:50,a:40]", r.Imprime());
        }

        [TestMethod]
        public void TestaContador()
        {
            Retangulo.ZeraContador();
            Assert.AreEqual(0, Retangulo.LeContador());

            new Retangulo(20, 20, 10, 10);
            new Retangulo(20, 20, 10, 10);
            Assert.AreEqual(2, Retangulo.LeContador());

            new Retangulo(20, 20, 10, 10);
            Assert.AreEqual(3, Retangulo.LeContador());
        }
    }
}
