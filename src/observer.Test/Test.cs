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
            // Arrange
            var observavel = new WordsCounter();
            var observador = new Subscriber(1, "TestSubscriber");
            observavel.AddObserver(observador);

            // Act
            observavel.Application("This is a test sentence.");

            // Assert
            Assert.AreEqual(1, observavel.UpperWords);
        }
    }
}

