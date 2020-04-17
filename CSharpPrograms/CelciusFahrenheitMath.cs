using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    public class CelciusFahrenheitMath
    {

        public static double _Fahrenheit;
        public static double _Celcius;
        public static void CelciusToFahrenheitMath(double celcius)
        {
            _Fahrenheit = (celcius * 9 / 5) + 32;

        }

        public static void FahrenheitToCelciusMath(double Fahrenheit)
        {
            _Celcius = (Fahrenheit - 32)*5 / 9;
        }
    }
}
