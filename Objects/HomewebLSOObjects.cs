using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeweb_3._0_Tests.Objects
{
    internal class HomewebLSOObjects
    {
        private IWebDriver driver;
        [FindsBy(How = How.CssSelector, Using = ".list-group-item:nth-child(1) .form-check-label")]
        public IWebElement LSOselect { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@data-role='display'][text()='Cochrane, Algoma']")]
        public IWebElement LSOregion { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@data-role='display'][text()='Family Member did not know'])[2]")]
        public IWebElement LSOrole { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@data-role='display'][text()='Autre'])[2]")]
        public IWebElement LSOroleFR { get; set; }
        [FindsBy(How = How.XPath, Using = "id(\"orgTree\")/UL[1]/LI[1]/DIV[1]/SPAN[3]")]
        public IWebElement Chevron { get; set; }

        [FindsBy(How = How.XPath, Using = "//BUTTON[@id='register']")]
        public IWebElement LSORegcomplete { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Law Society of Ontario']")]
        public IWebElement LSO1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='LawPRO']")]
        public IWebElement LSO2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='The Distress Centres']")]
        public IWebElement LSO3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='PracticePro - Practice Tools']")]
        public IWebElement LSO4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Canadian Centre on Substance Abuse']")]
        public IWebElement LSO5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='360 degrés de santé mentale']")]
        public IWebElement LSO6 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='La santé mentale des femmes']")]
        public IWebElement LSO7 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='La santé mentale des hommes']")]
        public IWebElement LSO8 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Les vacances : se relaxer, se revigorer, se retrou')]")]
        public IWebElement LSO9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='col-md-6 column-text']//span[@class='resource-duration'][normalize-space()='2 Minute Read']")]
        public IWebElement LSODashboard { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='tile-resource-card col-12 col-md-6 col-lg-4 mb-4 polaroid polaroid-resource-duration']//span[@class='resource-duration'][normalize-space()='2 minutes de lecture']")]
        public IWebElement LSODashboardFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='When Habits Become Addictions']")]
        public IWebElement LSOHabitsarticle { get; set; }


    }
}
