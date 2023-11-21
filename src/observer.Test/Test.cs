using Microsoft.VisualStudio.TestPlatform.TestHost;
using Observador;
using Observavel;
using System;

namespace UnitTest.Aplication
{
    [TestClass]
    public class Test
    {
        Program p;

        public Test()
        {
            p = new Program();
        }

        [TestMethod]
        public void TestContagemPalavrasUpperCase()
        {
            var observavel = new WordsCounter();
            var observador = new Subscriber(1, "Test_Subscribe");
            observavel.AddObserver(observador);

            observavel.Application("Testando Quantidade de Palavras com Upper Case");

            Assert.AreEqual(5, observavel.UpperWords);
        }

        [TestMethod]
        public void TestContagemPalavrasPares()
        {
            var observavel = new WordsCounter();
            var observador = new Subscriber(1, "TestSubscriber");
            observavel.AddObserver(observador);

            observavel.Application("Testando Contagem de Palavras Pares");

            Assert.AreEqual(4, observavel.EvenWords);
        }

        [TestMethod]
        public void TestNumeroDePalavrasNaFrase()
        {
            var observavel = new WordsCounter();
            var observador = new Subscriber(1, "TestSubscriber");
            observavel.AddObserver(observador);

            observavel.Application("Testando o numero de palavras em cada frase");

            Assert.AreEqual(8, observavel.Words);
        }
    }
}

