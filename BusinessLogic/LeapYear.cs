using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    public class LeapYear
    {
        public static void FindLeapYear(int year)
        {

            if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
            {
                Console.WriteLine("Entered Year is Leap Year");
            }
            else if (year % 4 == 0 && year % 100 != 0 && year % 400 != 0)
            {
                Console.WriteLine("Entered Year is Leap Year");
            }
            else
            {
                Console.WriteLine("Entered Year is Not Leap Year");
            }

        }        
    }
}
