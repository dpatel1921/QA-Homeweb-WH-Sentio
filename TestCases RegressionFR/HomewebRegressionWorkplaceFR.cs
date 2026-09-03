using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System.Text.Json;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AventStack.ExtentReports.Reporter;
using Homeweb_3._0_Tests.Objects;

namespace Homeweb_3._0_Tests.TestCases_Regression
{
    [TestFixture]
    public class HomewebRegressionWorkPlaceFR
    {
        private IWebDriver driver;
        private ExtentReports extent;
        private ExtentTest test;
        private DateTime time = DateTime.Now;

        [OneTimeSetUp]
        public void SetUp()
        {
            // Initialize ExtentReports instance
            extent = ExtentManager.GetReporter();
        }

        [SetUp]
        public void Initialize()
        {
            // Create a new instance of ChromeDriver
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
        }

        // Class to hold test case data from JSON file
        public class TestCaseJsonData
        {
            public string HWLogin1 { get; set; }
            public string HWPassword1 { get; set; }
            public string Url { get; set; }




        }

        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void WorkPlaceFR(string HWLogin1, string HWPassword1, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new HomewebRegressionObjectsFR();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(HWLogin1);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword1);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            ClickAndNavigate(RegObj.WorkPlace);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.WorkPlace10);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.WorkPlace10);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlace101);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlace101);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.WorkPlace2SL);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlace2SL);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceAres);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceAres);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceavoid);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceavoid);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacebuild);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacebuild);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceburnout);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceburnout);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacecareer);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacecareer);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacecoping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacecoping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacecreating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacecreating);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacecreating1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacecreating1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacecreating2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacecreating2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacedealing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacedealing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacedealing1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacedealing1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacedisability);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacedisability);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacedoes);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacedoes);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceeffect);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceeffect);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceemb);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceemb);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceemb1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceemb1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceeng);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceeng);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacefacing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacefacing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacegetting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacegetting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacegoing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacegoing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacegoing1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacegoing1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.LogoutFR.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void WorkPlace1FR(string HWLogin1, string HWPassword1, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new HomewebRegressionObjectsFR();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(HWLogin1);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword1);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click(); ;
            ClickAndNavigate(RegObj.WorkPlace);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.WorkPlacegrief);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.WorkPlacegrief);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacehealth);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacehealth);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.WorkPlacehelping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacehelping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacehelping1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacehelping1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacehow);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacehow);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacehow1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacehow1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacehow2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacehow2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacehow3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacehow3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceimm);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceimm);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceimprove);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceimprove);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceman);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceman);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceman1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceman1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceman2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceman2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemetime);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemetime);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemental);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemental);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemod);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemod);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemod1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemod1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemov);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemov);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceprep);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceprep);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceprep1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceprep1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceprep2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceprep2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceptsd);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceptsd);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceres);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceres);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceresp);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceresp);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.LogoutFR.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void WorkPlace2FR(string HWLogin1, string HWPassword1, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new HomewebRegressionObjectsFR();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(HWLogin1);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword1);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            ClickAndNavigate(RegObj.WorkPlace);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.WorkPlaceshift);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.WorkPlaceshift);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacesteps);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacesteps);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.WorkPlacestages);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacestages);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacesupport);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacesupport);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacesupport1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacesupport1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetaking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetaking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetaking1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetaking1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetaking2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetaking2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetaking3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetaking3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetaking4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetaking4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceten);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceten);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceten2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceten2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceimportance);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceimportance);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceinvisible);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceinvisible);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacethe);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacethe);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacethriving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacethriving);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetips);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetips);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceunder);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceunder);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacevis);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacevis);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacewebinar);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacewebinar);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacewhat);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacewhat);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacewhat1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacewhat1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceworking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceworking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceworking1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceworking1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceworking2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceworking2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceyou);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceyou);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceyou1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceyou1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceyou2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceyou2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceyou3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceyou3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetag);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.LogoutFR.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void WorkPlaceCareerDevelopmentFR(string HWLogin1, string HWPassword1, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new HomewebRegressionObjectsFR();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(HWLogin1);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword1);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlace);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.WorkPlace);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.WorkPlaceCD);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.WorkPlaceCD);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.WorkPlaceCD1);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCD1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCD2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCD2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCD3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCD3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCD4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCD4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCD5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCD5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCD6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCD6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCD7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCD7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCD8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCD8);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCD9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCD9);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCDtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCD10);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCD10);
            Thread.Sleep(1000);

            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.LogoutFR.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void WorkPlaceChangeTransitionFR(string HWLogin1, string HWPassword1, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new HomewebRegressionObjectsFR();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(HWLogin1);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword1);

            homePage.Submit.Submit();
            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlace);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.WorkPlace);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.WorkPlaceCT);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.WorkPlaceCT);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.WorkPlaceCT1);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCT1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCT2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCT2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCT3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCT3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCT4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCT4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCT5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCT5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCT6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCT6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCT7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCT7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCT8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCT8);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCT9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCT9);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCT10);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCT10);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCTtag);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.LogoutFR.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void WorkPlaceCommunicationFR(string HWLogin1, string HWPassword1, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new HomewebRegressionObjectsFR();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(HWLogin1);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword1);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlace);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.WorkPlace);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.WorkPlaceComm);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.WorkPlaceComm);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.WorkPlaceComm1);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceComm1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceComm2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceComm2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceComm3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceComm3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceComm4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceComm4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceComm5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceComm5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceComm6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceComm6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceComm7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceComm7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceComm8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceComm8);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceComm9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceComm9);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceComm10);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceComm10);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceCommtag);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.LogoutFR.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void WorkPlaceFitnessFR(string HWLogin1, string HWPassword1, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new HomewebRegressionObjectsFR();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(HWLogin1);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword1);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlace);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.WorkPlace);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.WorkPlaceFitness);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.WorkPlaceFitness);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.WorkPlaceFitness1);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceFitness1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceFitnesstag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceFitnesstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceFitness2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceFitness2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceFitnesstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceFitnesstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceFitness3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceFitness3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceFitnesstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceFitnesstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceFitness4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceFitness4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceFitnesstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceFitnesstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceFitness5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceFitness5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceFitnesstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceFitnesstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceFitness6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlaceFitness6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlaceFitnesstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlaceFitnesstag);
            Thread.Sleep(1000);

            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.LogoutFR.Click();

            // Quit the driver
            driver.Quit();
        }

        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void WorkPlaceManagementFR(string HWLogin1, string HWPassword1, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new HomewebRegressionObjectsFR();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(HWLogin1);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword1);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            ClickAndNavigate(RegObj.WorkPlace);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.WorkPlacemgmt);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.WorkPlacemgmt);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.WorkPlacemgmt2SL);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemgmt2SL);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtbuilding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtbuilding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtcreate);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtcreate);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtcreate1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtcreate1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtdoes);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtdoes);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtembracing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtembracing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtembracing1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtembracing1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtembracing2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtembracing2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtencourage);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtencourage);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmthealth);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmthealth);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmthelp);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmthelp);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmthelp1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmthelp1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmthow);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmthow);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtimm);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtimm);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtimm1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtimm1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtwokrplace);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtwokrplace);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtmod);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtmod);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtmod1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtmod1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtrespect);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtrespect);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtstages);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtstages);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmttalking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmttalking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtthe);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtthe);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtthrive);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtthrive);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtthrive1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtthrive1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmttips);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmttips);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemgmtunder);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemgmtunder);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.workplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.LogoutFR.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void WorkPlaceMentalHealthFR(string HWLogin1, string HWPassword1, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new HomewebRegressionObjectsFR();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(HWLogin1);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword1);

            homePage.Submit.Submit();
            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            ClickAndNavigate(RegObj.WorkPlace);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.WorkPlacementalhealth);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.WorkPlacementalhealth);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.WorkPlacemenhealth);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealth);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth8);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth9);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth10);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth10);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth11);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth11);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth12);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth12);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth13);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth13);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth14);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth14);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth15);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth15);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth16);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth16);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth17);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth17);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth18);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth18);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth19);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth19);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth20);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth20);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth21);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth21);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth23);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth23);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth24);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth24);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth25);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth25);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacementalhealth26);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth26);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.WorkPlacementalhealth27);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth27);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.WorkPlacementalhealth28);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth28);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.WorkPlacementalhealth29);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth29);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.WorkPlacementalhealth30);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth30);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.WorkPlacementalhealth31);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth31);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.WorkPlacementalhealth32);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth32);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.WorkPlacementalhealth33);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth33);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.WorkPlacementalhealth34);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth34);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.WorkPlacementalhealth35);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth35);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.WorkPlacementalhealth36);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacementalhealth36);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacemenhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.LogoutFR.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void WorkPlaceTransitionFR(string HWLogin1, string HWPassword1, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new HomewebRegressionObjectsFR();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(HWLogin1);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword1);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            ClickAndNavigate(RegObj.WorkPlace);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.WorkPlacetransition);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.WorkPlacetransition);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.WorkPlacetransition1);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetransition1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransition2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetransition2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransition3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetransition3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransition4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetransition4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransition5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetransition5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransition6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetransition6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransition7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetransition7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransition8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetransition8);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransition9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetransition9);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransition10);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetransition10);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransition11);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetransition11);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransition12);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetransition12);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransition13);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WorkPlacetransition13);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.WorkPlacetransitiontag);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.LogoutFR.Click();

            // Quit the driver
            driver.Quit();
        }



        private void ClickAndNavigate(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            element.Click();
        }
        private void ClickAndNavigateBack(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => element.Displayed);
            element.Click();
            driver.Navigate().Back();
        }
        private void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        private void SwitchToNewTab()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(d => driver.WindowHandles.Count > 1);
            var newTab = driver.WindowHandles.Last();
            driver.SwitchTo().Window(newTab);
        }
        public static IEnumerable<TestCaseData> LoginJsonData()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.HWLogin1)
                                                        && !string.IsNullOrEmpty(data.HWPassword1)
                                                        && data.Url == "https://homeweb.ca");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.HWLogin1, loginData.HWPassword1, loginData.Url);
            }
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            // Flush the extent reports
            extent.Flush();
        }

        [TearDown]
        public void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = TestContext.CurrentContext.Result.Message;

            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                test.Fail("Test Failed");
                test.Log(Status.Fail, $"Test failed with logtrace: {stackTrace}");
            }
            else if (status == NUnit.Framework.Interfaces.TestStatus.Passed)
            {
                test.Pass("Test Passed");
            }

            // Quit and dispose the driver
            driver.Quit();
            driver.Dispose();
        }
    }
}
