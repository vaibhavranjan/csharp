using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    public class PageObject2 : IPageObject
    {

        string pageNameob2 = "Page Name 2";
        public string PageName()
        {
            return pageNameob2;
        }
    }
}
