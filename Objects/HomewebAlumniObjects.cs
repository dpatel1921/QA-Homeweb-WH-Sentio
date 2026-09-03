using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeweb_3._0_Tests.Objects
{
    internal class HomewebAlumniObjects
    {
       private IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//a[@title=\"S'inscrire\"]")]
        public IWebElement SignupFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@title='Se connecter']")]
        public IWebElement SignupFR1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-secondary w-100']")]
        public IWebElement AlumniFeatured { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='tile-resource-card col-12 mb-4 polaroid-list']//p[@class='summary'][contains(text(),'Appelez au 1-855-805-4858 pour parler avec un cons')]")]
        public IWebElement AlumniFeaturedFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='tile-resource-card col-12 col-md-6 col-lg-4 mb-4 polaroid polaroid-resource-duration']//span[@class='resource-duration'][normalize-space()='2 Minute Read']")]
        public IWebElement AlumniFeatured1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='tile-resource-card col-12 col-sm-6 col-lg-12 mb-4 polaroid polaroid-resource-duration']//span[@class='resource-duration'][normalize-space()='2 minutes de lecture']")]
        public IWebElement AlumniFeatured1FR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-secondary btn-icon-end']")]
        public IWebElement AlumniFeatured2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='2 minutes de video']")]
        public IWebElement AlumniFeatured2FR { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='col-md-6 column-text']//span[@class='resource-duration'][normalize-space()='Self-Directed Service']")]
        public IWebElement PBCFeature1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='col-12 col-lg-8']//div[2]//a[1]//div[2]//span[2]")]
        public IWebElement PBCFeature1FR { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='tile-resource-card col-12 col-md-6 col-lg-4 mb-4 polaroid polaroid-resource-duration']//span[@class='resource-duration'][normalize-space()='2 Minute Video']")]
        public IWebElement PBCFeature2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='col-12 col-lg-8']//div[1]//a[1]//div[2]//span[2]")]
        public IWebElement PBCFeature2FR { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='searchHomeweb']")]
        public IWebElement Searchbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@id='search']//i[@role='presentation']")]
        public IWebElement ClickSearch { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Childcare Resource Locator by LifestageCare']")]
        public IWebElement ArticleSearch { get; set; }
    }
}
