using System;
using BusinessLogic;
using CSharpPrograms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{   
    [TestClass]
    public class InterfacePageNameTests
    {
        [TestMethod]
        public void Interface_PageName_Tests1()
        {
            IPageObject ipo = new PageObject1();
            Assert.AreEqual(ipo.PageName(), "Page Name 1");
        }

        [TestMethod]
        public void Interface_PageName_Tests2()
        {
            IPageObject ipo2 = new PageObject2();
            Assert.AreEqual(ipo2.PageName(), "Page Name 2");
        }
    }
}
