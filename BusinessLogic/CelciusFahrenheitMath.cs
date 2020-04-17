using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    public class CelciusFahrenheitMath
    {

        public static double _Fahrenheit;
        public static double _Celcius;
        public double CelciusToFahrenheitMath(double celcius)
        {
            _Fahrenheit = (celcius * 9 / 5) + 32;
            return _Fahrenheit;

        }

        public double FahrenheitToCelciusMath(double Fahrenheit)
        {
            _Celcius = (Fahrenheit - 32)*5 / 9;
            return _Celcius;
        }
    }
}
