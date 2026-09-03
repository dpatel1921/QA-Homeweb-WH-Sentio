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
    public class HomewebRegressionManagerFR
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
            public string HWLogin2 { get; set; }
            public string HWPassword2 { get; set; }
            public string Url { get; set; }




        }

        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void ManagerToolsFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            ClickAndNavigate(RegObj.Managertools);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Managertoolsecourses);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Managertoolsecourses);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Managertoolstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Managertoolstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Managertoolsres);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Managertoolsres);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Managertoolstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Managertoolstag);
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
        public void ManagerToolsEcoursesFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            ClickAndNavigate(RegObj.Managertools);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Managertoolsecourses1);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Managertoolsecourses1);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Managertoolsecoursesmanagers);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Managertoolsecoursesmanagers);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Managertoolsecoursestag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Managertoolsecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Managertoolsecoursesfund);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Managertoolsecoursesfund);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Managertoolsecoursestag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Managertoolsecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Managertoolsecourseslead);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Managertoolsecourseslead);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Managertoolsecoursestag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Managertoolsecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Managertoolsecoursesmanaging);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Managertoolsecoursesmanaging);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Managertoolsecoursestag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Managertoolsecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Managertoolsecoursessupport);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Managertoolsecoursessupport);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Managertoolsecoursestag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Managertoolsecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Managertoolsecoursesvalue);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Managertoolsecoursesvalue);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Managertoolsecoursestag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Managertoolsecoursestag);
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
        public void ManagerMentalHealthFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();



            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Managermentalhealth);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Managermentalhealth);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Managermentalhealthfertility);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Managermentalhealthfertility);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Managermentalhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Managermentalhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Managermentalhealthguide);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Managermentalhealthguide);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Managermentalhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Managermentalhealthtag);
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
        public void ManagerCrisisFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Managercrisis);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Managercrisis);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Managercrisismanagement);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Managercrisismanagement);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Managercrisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Managercrisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Managercrisisflooding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Managercrisisflooding);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Managercrisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Managercrisistag);
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
        public void ManagerFamilyFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Managerfamily);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Managerfamily);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Managerfamilyfert);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Managerfamilyfert);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Managerfamilytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Managerfamilytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Managerfamilyworking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Managerfamilyworking);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Managerfamilytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Managerfamilytag);
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
        public void ManagerFamilycaregivingFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Managerfamily);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Managerfamily);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Managerfamilycaregiving);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Managerfamilycaregiving);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Managerfamilyworking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Managerfamilyworking);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Managerfamilycaregivingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Managerfamilycaregivingtag);
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
        public void ManagerLifestyleFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerLifestyle);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerLifestyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerLifestylefacing);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerLifestylefacing);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.ManagerLifestyletag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyletag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleleading);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleleading);
            Thread.Sleep(1000);


            ScrollToElement(RegObj.ManagerLifestyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleuncovering);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleuncovering);
            Thread.Sleep(1000);


            ScrollToElement(RegObj.ManagerLifestyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyletag);
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
        public void ManagerLifestyleAddictionFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerLifestyle);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerLifestyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerLifestyleaddiction);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerLifestyleaddiction);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.ManagerLifestyleaddictionuncover);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleaddictionuncover);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleaddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleaddictiontag);
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
        public void ManagerLifestyleDEIFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerLifestyle);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerLifestyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerLifestyleDEI);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerLifestyleDEI);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.ManagerLifestyleDEI1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleDEI1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleDEItag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleDEItag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleDEI2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleDEI2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleDEItag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleDEItag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleDEI3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleDEI3);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleDEItag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleDEItag);
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
        public void ManagerLifestyleFitnessFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerLifestyle);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerLifestyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerLifestyleFitness);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerLifestyleFitness);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.ManagerLifestyleFitnesepain);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleFitnesepain);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleFitnesstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleFitnesstag);
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
        public void ManagerLifestyleNewsletterFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerLifestyle);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerLifestyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.ManagerLifestyleNews2SLG);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNews2SLG);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNews2SLG1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNews2SLG1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter3);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter4);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter5);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter6);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter7);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter8);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter9);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter10);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter10);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter11);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter11);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter12);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter12);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter13);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter13);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter14);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter14);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter15);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter15);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter16);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter16);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter17);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter17);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter18);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter18);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter19);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter19);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter20);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter20);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter21);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter21);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter22);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter22);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter23);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter23);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter24);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter24);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter25);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter25);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter26);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter26);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter27);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter27);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter28);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter28);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter29);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter29);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter30);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter30);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter31);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter31);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerLifestyleNewsletter32);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleNewsletter32);
            Thread.Sleep(1000);

          

            ScrollToElement(RegObj.ManagerLifestyleNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleNewstag);
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
        public void ManagerLifestyleMentalHealthFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerLifestyle);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerLifestyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerLifestyleMentalHealth);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerLifestyleMentalHealth);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.ManagerLifestyleMenhea);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerLifestyleMenhea);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerLifestyleMenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerLifestyleMenheatag);
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
        public void ManagerWorkplaceFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerWorkplace);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerWorkplace);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerWorkplacecann);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerWorkplacecann);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplaceteams);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplaceteams);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplaceconnecting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplaceconnecting);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacecrisis);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacecrisis);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplaceemployer);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplaceemployer);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacefacilitating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacefacilitating);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacefacing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacefacing);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacefund);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacefund);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplaceguiding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplaceguiding);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacehowto);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacehowto);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplaceleading);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplaceleading);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemanaging);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemanaging);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplaceopt);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplaceopt);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplaceopt1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplaceopt1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplaceopt2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplaceopt2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacepromoting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacepromoting);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplaceres);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplaceres);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacesup);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacesup);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacesup1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacesup1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacesup2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacesup2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacesup3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacesup3);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacesup4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacesup4);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacesup5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacesup5);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacetips);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacetips);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacetrans);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacetrans);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplaceunder);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplaceunder);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacevalue);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacevalue);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacewhen);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacewhen);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacework);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacework);
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
        public void ManagerWorkplaceCareerDevFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerWorkplace);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerWorkplace);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerWorkplacecareer);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerWorkplacecareer);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.ManagerWorkplacecareertrans);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacecareertrans);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacecareertag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacecareertag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacecareersupport);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacecareersupport);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacecareertag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacecareertag);
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
        public void ManagerWorkplaceCommFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerWorkplace);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerWorkplace);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerWorkplacecareercomm);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerWorkplacecareercomm);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.ManagerWorkplacecommfund);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacecommfund);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacecommtag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacecommtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacecommsens);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacecommsens);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacecommtag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacecommtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacecommsupport);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacecommsupport);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacecommtag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacecommtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacecommtrans);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacecommtrans);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacecommtag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacecommtag);
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
        public void ManagerWorkplaceManagementFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerWorkplace);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerWorkplace);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmt);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.ManagerWorkplacemgmtcann);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmtcann);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmt1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt3);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt4);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt5);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt6);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt7);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt8);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt9);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt10);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt10);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt11);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt11);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt12);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt12);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt13);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt13);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt14);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt14);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt15);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt15);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt16);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt16);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt17);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt17);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt18);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt18);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt19);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt19);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt20);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt20);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt21);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt21);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt22);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt22);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt23);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt23);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgm24);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgm24);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt25);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt25);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt26);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt26);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt27);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt27);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt28);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt28);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt29);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt29);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt30);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt30);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt31);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt31);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacemgmttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacemgmt32);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacemgmt31);
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
        public void ManagerWorkplaceMentalFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerWorkplace);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerWorkplace);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerWorkplacementhea);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerWorkplacementhea);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.ManagerWorkplacementhea1);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacementhea1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacementheatag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacementheatag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacementhea2);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacementhea2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacementheatag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacementheatag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacementhea3);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacementhea3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacementheatag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacementheatag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacementhea4);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacementhea4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacementheatag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacementheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacementhea5);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacementhea5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacementheatag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacementheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacementhea6);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacementhea6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacementheatag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacementheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacementhea7);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacementhea7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacementheatag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacementheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacementhea8);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacementhea8);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacementheatag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacementheatag);
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
        public void ManagerWorkplaceTransitionFR(string HWLogin2, string HWPassword2, string Url)
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

            homePage.UserName.SendKeys(HWLogin2);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword2);

            homePage.Submit.Submit();


            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerWorkplace);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerWorkplace);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ManagerWorkplacetransition);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ManagerWorkplacetransition);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.ManagerWorkplacetransition1);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetransition1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacetransitiontag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacetransitiontag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ManagerWorkplacetransition2);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ManagerWorkplacetransition2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ManagerWorkplacetransitiontag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ManagerWorkplacetransitiontag);
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
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.HWLogin2)
                                                        && !string.IsNullOrEmpty(data.HWPassword2)
                                                        && data.Url == "https://homeweb.ca");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.HWLogin2, loginData.HWPassword2, loginData.Url);
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
