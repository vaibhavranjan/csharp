using System;

namespace CSharpPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            StringFormat.StringFormats();
            VerbatimStringAndEscapeSequence.VerbatimStringNEscapeSequence();
            Console.WriteLine("Please enter year");
            int enteredYear = Console.Read();
            LeapYear.FindLeapYear(enteredYear);
            Console.Read();
        }
    }
}
