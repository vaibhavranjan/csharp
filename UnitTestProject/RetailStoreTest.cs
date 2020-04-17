using System;
using CSharpPrograms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
       
    [TestClass]
    public class RetailStoreTest
    {
        RetailStore rs = new RetailStore(1, DateTime.Now,"Vaibhav Ranjan", 
        441122, 1, 70, 100);
        [TestMethod]
        public void Calculate_Total_Cost()
        {
            double totalCost = rs.TotalCost();
            Assert.AreEqual(totalCost, 7000);
        }        
    }
}
