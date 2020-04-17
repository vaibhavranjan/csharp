using System;
using BusinessLogic;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    public class PageObject1 : IPageObject
    {
        public string pageNameOb1 = "Page Name 1";
        public string PageName()
        {
            return pageNameOb1;
        }
    }
}
