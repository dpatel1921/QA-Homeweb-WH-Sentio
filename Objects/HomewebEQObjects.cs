using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeweb_3._0_Tests.Objects
{
    internal class HomewebEQObjects
    {
        private IWebDriver driver;
        [FindsBy(How = How.CssSelector, Using = "input#equitablePolicyId")]
        public IWebElement EQPolicyID { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button#btnOrgSearch")]
        public IWebElement SearchButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".list-group-item > a")]
        public IWebElement OrgSelect { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button#register")]
        public IWebElement SelectPartOrg { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='tile-resource-card col-12 col-md-6 col-lg-4 mb-4 polaroid polaroid-resource-duration']//span[@class='resource-duration'][normalize-space()='Self-Directed Service']")]
        public IWebElement EQSentio { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='col-12 col-lg-8']//div[2]//a[1]//div[2]//span[2]")]
        public IWebElement EQSentioFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-secondary btn-icon-end']")]
        public IWebElement EQMonthArticle { get; set; }
       
    }
}
