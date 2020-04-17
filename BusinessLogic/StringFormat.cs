using System;

namespace CSharpPrograms
{
    class StringFormat
    {
        public static void StringFormats()
        {
            double itemPrice = 17.23;
            string itemName = "Samsung";
            string output = String.Format("{0,10}{1,10}", itemName, itemPrice);
            //String Format
            Console.WriteLine(String.Format("{0,10}{1,10}", "ProductName", "Price"));
            Console.WriteLine(output);
        }
    }
}
