using System;
using CSharpPrograms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
       
    [TestClass]
    public class CelciusFahrenheitTests
    {

        CelciusFahrenheitMath cf = new CelciusFahrenheitMath();
        [TestMethod]
        public void Celcius_To_Fahrenheit_Test()
        {
            double expectedFahrenheit = 50;
            double actualFahrenheit = cf.CelciusToFahrenheitMath(10);
            Assert.AreEqual(expectedFahrenheit, actualFahrenheit);

        }
        [TestMethod]
        public void Fahrenheit_To_Celcius_Test()
        {

            double expectedCelcius = 10;
            double actualCelcius = cf.FahrenheitToCelciusMath(50);
            Assert.AreEqual(expectedCelcius, actualCelcius);
        }
    }
}
