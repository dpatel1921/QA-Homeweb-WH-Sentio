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
    public class HomewebRegressionCrisisFR
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
        public void CrisisFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Crisis);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Crisischildhood);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Crisischildhood);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscopingtraumatic);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscopingtraumatic);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Crisiscopingloss);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscopingloss);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscopingcoworker);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscopingcoworker);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisisukraine);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisisukraine);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisisemployeefatigue);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisisemployeefatigue);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisisexperiencingviolence);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisisexperiencingviolence);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisisexperiencingdisruptive);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisisexperiencingdisruptive);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisisgrief);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisisgrief);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismaid);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismaid);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisislossofchild);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisislossofchild);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisishelpingchildren);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisishelpingchildren);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisishowtodeal);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisishowtodeal);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisisnovascotia);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisisnovascotia);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisispractical);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisispractical);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisisabuse1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisisabuse1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisisabuse2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisisabuse2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisissuicide);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisissuicide);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisissupporting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisissupporting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistakingcontrol);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisistakingcontrol);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisisptsd);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisisptsd);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiswhattodo);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiswhattodo);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiswhattodo1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiswhattodo1);
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
        public void CrisisCovid19FR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Crisis);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Crisiscovid);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Crisiscovid10);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Crisiscovid10);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidbeing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovidbeing);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Crisiscovidcelebrating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovidcelebrating);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19masks);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19masks);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19assessment);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19assessment);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19symtoms);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19symtoms);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19mental);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19mental);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19languishing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19languishing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19sick);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19sick);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19fatigue);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19fatigue);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19sanitizer1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19sanitizer1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19sanitizer2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19sanitizer2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19healthy);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19healthy);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19healthy1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19healthy1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19healthy2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19healthy2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Crisiscovid19holidaystress);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19holidaystress);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19intimate);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19intimate);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19intimate1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19intimate1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19intimate2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19intimate2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19living);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19living);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19living1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19living1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19living2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19living2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19maintaining);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19maintaining);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
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
        public void CrisisCovid19ContinueFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Crisis);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Crisiscovid);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19mentalduring);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovid19mentalduring);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19overcoming);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19overcoming);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Crisiscovid19overcoming1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19overcoming1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19preparing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19preparing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19preparing1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19preparing1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19preparing2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19preparing2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19preparing3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19preparing3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19resilience);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19resilience);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19stayingactive);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19stayingactive);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19stayingconnected);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19stayingconnected);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19supporting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19supporting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19surviving1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19surviving1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19surviving2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19surviving2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19surviving3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19surviving3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19taking1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19taking1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Crisiscovid19taking2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19taking2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19taking3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19taking3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19webinar1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19webinar1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19webinar2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19webinar2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19webinar3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19webinar3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19webinar4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19webinar4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19webinar5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19webinar5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19webinar6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19webinar6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19webinar7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19webinar7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19whensomeone);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19whensomeone);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19whennext);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19whennext);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19youandyour);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19youandyour);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19youandyour1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19youandyour1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovid19youandyour2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisiscovid19youandyour2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisiscovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisiscovidtag);
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
        public void CrisisMentalHealthFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Crisis);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Crisismental);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaldepression);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaldepression);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalcoping1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalcoping1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Crisismentalcoping2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalcoping2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalcoping3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalcoping3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalemployee);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalemployee);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalexperience1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalexperience1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalexperience2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalexperience2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalintimate1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalintimate1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalintimate2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalintimate2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalhealth);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalhealth);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalnova);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalnova);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalabuse);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalabuse);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalsomeone);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalsomeone);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalspotting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalspotting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalsuicide);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalsuicide);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Crisismentalsupporting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalsupporting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalsupporting1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalsupporting1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltaking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentaltaking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalmanyfaces);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalmanyfaces);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.CrisismentalUnderstanding1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.CrisismentalUnderstanding1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.CrisismentalUnderstanding2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.CrisismentalUnderstanding2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalwebinar1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalwebinar1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalwebinar2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalwebinar2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentalwebinar3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisismentalwebinar3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisismentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisismentaltag);
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
        public void CrisisParentingFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Crisis);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Crisisparenting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisisparentinggrieving);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisisparentinggrieving);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Crisisparentingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisisparentingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisisparentinghelping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisisparentinghelping);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Crisisparentingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisisparentingtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Crisisparentingunderstanding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisisparentingunderstanding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisisparentingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisisparentingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisisparentingconsent);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisisparentingconsent);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisisparentingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisisparentingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisisparentingconsent1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Crisisparentingconsent1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Crisisparentingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Crisisparentingtag);
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
