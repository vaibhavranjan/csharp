using System;
using System.Collections;
using CSharpPrograms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
       
    [TestClass]
    public class ArrayListTest
    {
        
        [TestMethod]
        public void Array_List_Test()
        {
            ArraySort();
        } 
        
        public void ArraySort()
        {
            ArrayList alist = new ArrayList();
            Console.WriteLine("Adding some number");
            Console.WriteLine();
            alist.Add(786);
            alist.Add(568);
            alist.Add(768);
            alist.Add(456);
            alist.Add(987);
            alist.Add(1107);
            Console.WriteLine($"ArrayList Capacity { alist.Capacity}" );
            Console.WriteLine();
            Console.WriteLine($"ArrayList Count { alist.Count}");
            Console.WriteLine();
            Console.Write("Stored content  ");
            foreach(int i in alist)
                Console.Write(i + " ");
            alist.Sort();
            Console.WriteLine();
            Console.Write("Sorted Content  ");
            foreach (int i in alist)
                Console.Write(i+"  ");
            alist.RemoveAt(5);
            Console.WriteLine();
            Console.WriteLine($"ArrayList Count { alist.Count}");
            Console.WriteLine();
            Console.Write("Sorted Content after removing ");
            foreach (int i in alist)
                Console.Write(i + "  ");
        }
    }
}
