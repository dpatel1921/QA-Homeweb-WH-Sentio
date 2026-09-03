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
    public class HomewebRegressionPlanAdminFR
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
            public string HWLogin { get; set; }
            public string HWPassword { get; set; }
            public string Url { get; set; }




        }

        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void PlanAdminHRResourcesFR(string HWLogin, string HWPassword, string Url)
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

            homePage.UserName.SendKeys(HWLogin);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword);

            homePage.Submit.Submit();



            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminHRres);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.PlanAdminHRres1);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminHRres1);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRres2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRres2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRres3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRres3);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRres4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRres4);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRres5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRres5);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRres6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRres6);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRres7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRres7);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRres8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRres8);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRres9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRres9);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRres10);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRres10);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRres11);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRres11);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRres12);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRres12);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRres13);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRres13);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRres14);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRres14);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRres15);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRres15);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRres16);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRres16);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRres17);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRres17);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRres18);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRres18);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRrestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRrestag);
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
        public void PlanAdminHRResourcesEmpHandFR(string HWLogin, string HWPassword, string Url)
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

            homePage.UserName.SendKeys(HWLogin);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword);

            homePage.Submit.Submit();



            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminHRres);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.PlanAdminHRresemphand);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminHRresemphand);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.PlanAdminHRresemphand1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresemphand1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresemphandtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresemphandtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRresemphand2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresemphand2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresemphandtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresemphandtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRresemphand3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresemphand3);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresemphandtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresemphandtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRresemphand4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresemphand4);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresemphandtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresemphandtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRresemphand5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresemphand5);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresemphandtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresemphandtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRresemphand6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresemphand6);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresemphandtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresemphandtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRresemphand7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresemphand7);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresemphandtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresemphandtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRresemphand8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresemphand8);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresemphandtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresemphandtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRresemphand9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresemphand9);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresemphandtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresemphandtag);
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
        public void PlanAdminHRResourcesJDFR(string HWLogin, string HWPassword, string Url)
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

            homePage.UserName.SendKeys(HWLogin);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminHRres);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.PlanAdminHRresJD);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminHRresJD);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.PlanAdminHRresJD1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresJD1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresJDtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresJDtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRresJD2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresJD2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresJDtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresJDtag);
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
        public void PlanAdminHRResourcesPMFR(string HWLogin, string HWPassword, string Url)
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

            homePage.UserName.SendKeys(HWLogin);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword);

            homePage.Submit.Submit();



            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminHRres);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.PlanAdminHRresPM);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminHRresPM);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.PlanAdminHRresPM1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresPM1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresPMtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresPMtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRresPM2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresPM2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresPMtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresPMtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRresPM3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresPM3);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresPMtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresPMtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRresPM4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresPM4);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresPMtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresPMtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRresPM5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresPM5);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresPMtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresPMtag);
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
        public void PlanAdminHRResourcesPPFR(string HWLogin, string HWPassword, string Url)
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

            homePage.UserName.SendKeys(HWLogin);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword);

            homePage.Submit.Submit();



            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminHRres);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.PlanAdminHRresPP);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminHRresPP);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.PlanAdminHRresPP1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresPP1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresPPtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresPPtag);
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
        public void PlanAdminHRResourcesrecFR(string HWLogin, string HWPassword, string Url)
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

            homePage.UserName.SendKeys(HWLogin);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminHRres);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.PlanAdminHRresrec);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminHRresrec);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.PlanAdminHRresrec1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresrec1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresrectag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresrectag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminHRresrec2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminHRresrec2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.PlanAdminHRresrectag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.PlanAdminHRresrectag);
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
        public void PlanAdminLifestyleFR(string HWLogin, string HWPassword, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new HomewebRegressionObjects();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(HWLogin);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.PlanAdminLS);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminLS);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.PlanAdminLS1);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminLS1);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.PlanAdminLStag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminLStag);
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
        public void PlanAdminLifestyleMenheaFR(string HWLogin, string HWPassword, string Url)
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

            homePage.UserName.SendKeys(HWLogin);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword);

            homePage.Submit.Submit();



            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.PlanAdminLS);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminLS);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.PlanAdminLSmenhea);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminLSmenhea);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.PlanAdminLSmenhea1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminLSmenhea1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminLSmenheatag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminLSmenheatag);
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
        public void PlanAdminWorkPlaceMenheaFR(string HWLogin, string HWPassword, string Url)
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

            homePage.UserName.SendKeys(HWLogin);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword);

            homePage.Submit.Submit();



            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.PlanAdminWP);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminWP);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.PlanAdminWPmenhea);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminWPmenhea);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.PlanAdminWPmenhea1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminWPmenhea1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminWPmenheatag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminWPmenheatag);
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
        public void PlanAdminWorkPlaceTransitionFR(string HWLogin, string HWPassword, string Url)
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

            homePage.UserName.SendKeys(HWLogin);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.PlanAdminWP);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminWP);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.PlanAdminWPtransition);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.PlanAdminWPtransition);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.PlanAdminWPtransition1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminWPtransition1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.PlanAdminWPtransitiontag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.PlanAdminWPtransitiontag);
            Thread.Sleep(1000);

            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.Logout.Click();

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
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.HWLogin)
                                                        && !string.IsNullOrEmpty(data.HWPassword)
                                                        && data.Url == "https://homeweb.ca");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.HWLogin, loginData.HWPassword, loginData.Url);
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
