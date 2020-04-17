using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    public class WhileNestedLoop
    {
        public static int inner = 0;
        
        public static void NestedLoop()
        {
           while(inner <= 2)
           {
                int outer = 10;
                while(outer >=6)
                    {
                    Console.WriteLine($"Outer:{inner}   Inner:{outer}");
                    outer--;
                    }
                inner++;
            }
            
        }
        
    }
}
