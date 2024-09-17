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
            // NÃO ACEITA NENHUM NÚMERO NEGATIVO E NEM NÚMERO MAIOR QUE 100.
            {
                // Ação e teste para valores inválidos (fora de 1 a 100)
                Random random = new Random();

                // Gerar um valor inválido menor que 0
                int valorInvalidoMenor = random.Next(int.MinValue, 0);

                // Gerar um valor inválido maior que 100
                int valorInvalidoMaior = random.Next(101, int.MaxValue);

                bool EntradaValidaMenor = valorInvalidoMenor > 0 && valorInvalidoMenor < 101;
                bool EntradaValidaMaior = valorInvalidoMaior > 0 && valorInvalidoMaior < 101;

                Assert.IsFalse(EntradaValidaMenor);  // Esperamos que seja falso
                Assert.IsFalse(EntradaValidaMaior);  // Esperamos que seja falso
            }
        }
    }
}