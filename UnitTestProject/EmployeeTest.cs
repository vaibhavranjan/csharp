using System;
using CSharpPrograms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
       
    [TestClass]
    public class EmployeeTest
    {
        public static string firstName = "Vaibhav";
        public static string lastName = "Ranjan";
        EmployeeDetails ed = new EmployeeDetails(firstName, lastName);
        [TestMethod]
        public void Full_Name_Test()
        {
            string expectedOutput = "Vaibhav Ranjan";
            string FullName = ed.EmpFullName();
            Assert.AreEqual(expectedOutput, FullName);
        }
        [TestMethod]
        public void Full_Name_Sorted_Test()
        {
            string expectedOutput = "Ranjan, Vaibhav";
            string FullNameSorted = ed.EmpFullNameSort();
            Assert.AreEqual(expectedOutput, FullNameSorted);
        }
    }
}
