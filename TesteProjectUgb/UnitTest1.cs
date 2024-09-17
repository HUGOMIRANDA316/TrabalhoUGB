using System;
using System.IO;
using System.Security.Authentication.ExtendedProtection;
using TrabalhoUGB.Menu;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteProjectUgb
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerificandoPalindromo()
        {
            // ação & teste
            Assert.IsTrue(Palindromo.EhPalindromo("121"));
            Assert.IsFalse(Palindromo.EhPalindromo("267"));
        }
        [TestMethod]
        public void VerificandoValorEntre0e100()
        {
            //ação e teste
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);

            bool EntradaValida = numeroAleatorio > 0 && numeroAleatorio < 101;
            Assert.IsTrue(EntradaValida);
        }
        [TestMethod]
        public void VerificandoValorInvalido()
        {
            //desenvolver
        }
    }  
}
