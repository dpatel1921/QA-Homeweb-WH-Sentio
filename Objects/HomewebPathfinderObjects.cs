using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeweb_3._0_Tests.Objects
{
    internal class HomewebPathfinderObjects
    {
        private IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//span[@class='item-link btn-icon-end']")]
        public IWebElement AccessHomeweb { get; set; }
    }
}
