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
    public class HomewebRegressionLifestyleFR
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
        public void LifestyleContinuesFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.LifetylDealing);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.LifetylDealing);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDealing1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDealing1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifetylDealing2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDealing2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyldisability);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyldisability);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyleating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyleating);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyleating1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyleating1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyleco);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyleco);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylensuring);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylensuring);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylfinding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylfinding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylfood);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylfood);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylfoundations);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylfoundations);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylgetaway);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylgetaway);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylgetting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylgetting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylgetting1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylgetting1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylgoing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylgoing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylgrandparent);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylgrandparent);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylgrief);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylgrief);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylhappy);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylhappy);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylharmful);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylharmful);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylhealth);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylhealth);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylhealth1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylhealth1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylhealth2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylhealth2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylhealth3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylhealth3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylhealth4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylhealth4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylhealth5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylhealth5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylholiday);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylholiday);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylhow);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylhow);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylhowavoid);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylhowavoid);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylhowcombat);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylhowcombat);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylhowdeal);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylhowdeal);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylhowpreschooler);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylhowpreschooler);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylhowdefuse);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylhowdefuse);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylhowsleep);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylhowsleep);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylhowself);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylhowself);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmaintain);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmaintain);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylreduce);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylreduce);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylLGB);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylLGB);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchance);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchance);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylseparation);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylseparation);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylhumour);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylhumour);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
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
        public void LifestyleContinues1(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.LifetylIdentity);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.LifetylIdentity);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylImmigrant);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylImmigrant);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifetylImmigrant1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylImmigrant1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylimproving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylimproving);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylinterconnections);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylinterconnections);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylCBT);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylCBT);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmoney);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmoney);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyljump);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyljump);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyljune);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyljune);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylkeep);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylkeep);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylkeeping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylkeeping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyllearning);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyllearning);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyllearning1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyllearning1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyllegal);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyllegal);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylLGBTQ);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylLGBTQ);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylLinking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylLinking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylLiving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylLiving);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylLiving1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylLiving1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylLiving2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylLiving2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylLooking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylLooking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmaintaining);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmaintaining);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmaintaining1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmaintaining1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmanaging);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmanaging);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmetimeg);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmetimeg);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmeditation);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmeditation);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmens);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmens);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmentalillness);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmentalillness);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmindfulness);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmindfulness);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmoving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmoving);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylnavigating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylnavigating);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylnewparent);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylnewparent);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylnutritional);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylnutritional);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylovercoming);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylovercoming);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylovercoming1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylovercoming1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylpositive);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylpositive);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylpre);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylpre);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylpreparing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylpreparing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylpreparing1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylpreparing1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylptsd);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylptsd);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
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
        public void LifestyleContinues2FR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Lifetylrace);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Lifetylrace);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylraising);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylraising);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetylreenergizing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylreenergizing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylreducing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylreducing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylreducingmental);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylreducingmental);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylrelationshipdis);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylrelationshipdis);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylrelationshipsol);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylrelationshipsol);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylresilience);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylresilience);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylresiliencecond);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylresiliencecond);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylresolving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylresolving);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylresponsible);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylresponsible);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylrestoring);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylrestoring);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylselfcare);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylselfcare);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyldivorce);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyldivorce);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylsetting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylsetting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylshift);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylshift);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylsingle);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylsingle);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylsleep);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylsleep);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylsmoking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylsmoking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylsocial);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylsocial);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylsomeone);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylsomeone);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylsomeone1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylsomeone1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylsomeone2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylsomeone2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylstop);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylstop);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylsmoking1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylsmoking1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylstudent);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylstudent);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylsummerskin);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylsummerskin);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylsupporting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylsupporting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylsupporting1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylsupporting1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylsupporting2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylsupporting2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylnewparent);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylnewparent);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylnutritional);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylnutritional);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylovercoming);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylovercoming);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylovercoming1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylovercoming1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylpositive);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylpositive);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylpre);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylpre);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylpreparing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylpreparing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylpreparing1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylpreparing1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylptsd);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylptsd);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
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
        public void LifestyleContinues3FR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Lifetyltakingstress1);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Lifetyltakingstress1);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyltakingstress2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltakingstress2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetyltakingcontrol);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltakingcontrol);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyltakingcontrol1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltakingcontrol1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyltakingcontrol2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltakingcontrol2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyltakingcontrol3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltakingcontrol3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyltakingcontrol4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltakingcontrol4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyltakingcontrol5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltakingcontrol5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyltalking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltalking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyltalking1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltalking1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyltalking2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltalking2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyltech);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltech);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylbenefits);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylbenefits);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylbiology);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylbiology);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcosmeticsurgery);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcosmeticsurgery);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyldangers);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyldangers);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylhealing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylhealing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylimpactalcohol);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylimpactalcohol);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylimpactsleep);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylimpactsleep);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylimpacttech);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylimpacttech);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylimportance);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylimportance);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylimportancesleep);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylimportancesleep);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylinvisible);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylinvisible);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylthelink);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylthelink);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylthemany);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylthemany);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyltheptsd);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltheptsd);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylthepower);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylthepower);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylthesobering);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylthesobering);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyltheweight);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltheweight);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyltheworking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltheworking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyltips);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltips);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyltodays);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltodays);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyltoomuch);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltoomuch);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyltoomuch1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyltoomuch1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyluncovering);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyluncovering);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylunderstanding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylunderstanding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylunderstanding1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylunderstanding1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylunderstanding2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylunderstanding2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylvacation);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylvacation);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylvaping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylvaping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylvisualization);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylvisualization);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylwellness);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylwellness);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylwhat);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylwhat);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylpractiseit);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylpractiseit);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylwhenhabits);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylwhenhabits);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylwhensomeone);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylwhensomeone);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylwhygood);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylwhygood);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylwinter);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylwinter);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylwintertime);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylwintertime);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylwomen);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylwomen);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylworking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylworking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylworking1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylworking1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylyouhave);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylyouhave);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylyouth);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylyouth);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylyouth1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylyouth1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylyouth2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylyouth2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylyouth3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylyouth3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylyouth4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylyouth4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
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
        public void LifestyleFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Lifetyletis);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Lifetyletis);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyle10steps);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyle10steps);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetyle360);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyle360);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylestress);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylestress);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyleacne);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyleacne);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladapting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladapting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdiction);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdiction);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylarthritis);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylarthritis);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylAutumn);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylAutumn);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylAvoiding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylAvoiding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylbeyond);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylbeyond);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylbike);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylbike);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylbody);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylbody);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylbreak);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylbreak);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylbreathe);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylbreathe);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylbuilding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylbuilding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylbuilding1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylbuilding1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylbuilding2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylbuilding2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcareer);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcareer);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcelebdad);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcelebdad);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcelebmom);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcelebmom);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcare);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcare);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcleanup);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcleanup);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylconnecting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylconnecting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcontraption);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcontraption);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcontrolling);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcontrolling);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcoping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcoping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcoping1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcoping1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcoping2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcoping2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcoping3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcoping3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcosmetic);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcosmetic);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyletag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyletag);
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
        public void LifestyleAddictionFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Lifetyladd);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Lifetyladdrecovery);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdrecovery);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetyladdsubs);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdsubs);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdbreak);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdbreak);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdcontrolling);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdcontrolling);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladddating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladddating);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdharmless);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdharmless);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdhow);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdhow);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdpositive);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdpositive);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdsupporting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdsupporting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdsupporting1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdsupporting1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdsupporting2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdsupporting2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtaking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdtaking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtech);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdtech);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladddangers);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladddangers);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdalcohol);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdalcohol);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdsobering);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdsobering);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdunderstanding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdunderstanding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdunderstanding1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdunderstanding1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdunderstanding2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdunderstanding2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdvaping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetyladdvaping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetyladdtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetyladdtag);
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
        public void LifestyleCareerDevelopmentFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Lifetylcareerdev);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Lifetylcareerdevburn);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcareerdevburn);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetylcareerdevtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylcareerdevtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetylcareerdevcareer);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcareerdevcareer);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcareerdevtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylcareerdevtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcareerdevcreating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcareerdevcreating);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcareerdevtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylcareerdevtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcareerdeveffectively);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcareerdeveffectively);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcareerdevtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylcareerdevtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcareerdevhealth);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcareerdevhealth);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcareerdevtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylcareerdevtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcareerdevhow);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcareerdevhow);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcareerdevtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylcareerdevtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcareerdevhowjob);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcareerdevhowjob);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcareerdevtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylcareerdevtag);
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
        public void LifestyleChildcareFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Lifetylchild);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Lifetylchild);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Lifetylchildstress);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildstress);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetylchildcareadhd);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcareadhd);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcareare);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcareare);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarebabies);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarebabies);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarebaby);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarebaby);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcareback);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcareback);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarebecoming);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarebecoming);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarebedwetting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarebedwetting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarebedwetting1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarebedwetting1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarebedwetting2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarebedwetting2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarebreast);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarebreast);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarecaring);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarecaring);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarecaring1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarecaring1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaredads);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcaredads);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaremoms);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcaremoms);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcare1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcare1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcare2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcare2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarechildhood);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarechildhood);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarechoosing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarechoosing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarecombining);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarecombining);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarecreate);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarecreate);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaredry);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcaredry);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcareeating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcareeating);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcareeffective);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcareeffective);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarefoundations);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarefoundations);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarefoundations1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarefoundations1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaregrand);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcaregrand);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarehalloween);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarehalloween);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarehow);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarehow);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarehow1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarehow1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarehow2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarehow2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarehow3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarehow3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcareisyour);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcareisyour);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarekicks);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarekicks);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaremanaging);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcaremanaging);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarenewparent);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarenewparent);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcareonline);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcareonline);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcareplanning);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcareplanning);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcareschool);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcareschool);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaresecure);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcaresecure);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcareseparation);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcareseparation);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaresingle);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcaresingle);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarespirited);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarespirited);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretalking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcaretalking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretech);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcaretech);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcareimpact);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcareimpact);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarepower);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarepower);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcareworking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcareworking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcareunderstanding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcareunderstanding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarevaccination);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarevaccination);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarewhatconsent);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarewhatconsent);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcarewhatdo);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcarewhatdo);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcareworkingout);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcareworkingout);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcareyouth);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcareyouth);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcareyouth1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylchildcareyouth1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylchildcaretag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylchildcaretag);
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
        public void LifestyleCommunicationFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Lifetylcommunication);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylcommunication);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Lifetylcommbuild);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcommbuild);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetylcommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylcommtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetylcommdefuse);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcommdefuse);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylcommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcommlgbtq);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcommlgbtq);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylcommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcommrelation);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcommrelation);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylcommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcommsolution);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcommsolution);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylcommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcommrestoring);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcommrestoring);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylcommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcommtech);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcommtech);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylcommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcommtoo);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylcommtoo);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylcommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylcommtag);
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
        public void LifestyleDiseaseManagementFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.LifetylDisMan);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.LifetylDisMan);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.LifetylDisman10easy);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDisman10easy);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifetylDisman10must);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDisman10must);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDisman10things);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDisman10things);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDisman10tips);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDisman10tips);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDisman5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDisman5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDisman5winter);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDisman5winter);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanactive);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanactive);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanafib);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanafib);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanairtravel);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanairtravel);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanallergy);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanallergy);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanprevention);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanprevention);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismananaemia);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismananaemia);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanrisk);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanrisk);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanarthritis);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanarthritis);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanashtma);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanashtma);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanashtma1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanashtma1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanbe);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanbe);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismancancer);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismancancer);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismancancertips);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismancancertips);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanchildhood);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanchildhood);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismancholestoral);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismancholestoral);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanchronic);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanchronic);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismancolorectal);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismancolorectal);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismancompl);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismancompl);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismancoping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismancoping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismancrp);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismancrp);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismancutting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismancutting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismandiabetes);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismandiabetes);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismandiabetes1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismandiabetes1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismandiabetes2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismandiabetes2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismandiabetes3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismandiabetes3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismandiarrhea);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismandiarrhea);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismandoyou);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismandoyou);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismandoit);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismandoit);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismandont);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismandont);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismandrug);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismandrug);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismaneczema);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismaneczema);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismaneczema1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismaneczema1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanerectile);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanerectile);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismaneye);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismaneye);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismaneyesym);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismaneyesym);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismaneyesight);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismaneyesight);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanflu);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanflu);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismangenital);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismangenital);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanhealthy);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanhealthy);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanheart);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanheart);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanheartfacts);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanheartfacts);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanhearthealth);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanhearthealth);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanhelp);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanhelp);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanhigh);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanhigh);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanhome);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanhome);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanhowMS);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanhowMS);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanhowtoprevent);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanhowtoprevent);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanhowtotalk);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanhowtotalk);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanHPV);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanHPV);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
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
        public void LifestyleDiseaseManagement1FR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.LifetylDisMan);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.LifetylDisMan);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.LifetylDismanHPV1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanHPV1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifetylDismanHPV2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanHPV2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanHPV3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanHPV3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanimpaired);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanimpaired);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanimpetigo);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanimpetigo);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanintegrative);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanintegrative);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismaninterconnections);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismaninterconnections);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismankeeping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismankeeping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismankeeping1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismankeeping1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanlearn);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanlearn);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanlearn1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanlearn1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanliving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanliving);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanliving1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanliving1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmake);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmake);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmanaging);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmanaging);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmoretime);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmoretime);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsdepression);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsdepression);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsemp);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsemp);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsexe);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsexe);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmshealthy);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmshealthy);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsmemory);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsmemory);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsnutrition);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsnutrition);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmspreg);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmspreg);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsquality);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsquality);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmssex);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmssex);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsspa);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsspa);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmstravel);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmstravel);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmssupport);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmssupport);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsmedication);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsmedication);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsmedication1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsmedication1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsback);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsback);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsbowel);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsbowel);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmscog);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmscog);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmscontrol);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmscontrol);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmscoping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmscoping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsdealing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsdealing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsdealing1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsdealing1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsdoctor);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsdoctor);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsexercise);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsexercise);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsfacts);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsfacts);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmshave);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmshave);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmshelp);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmshelp);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsinternet);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsinternet);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsmanaging);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsmanaging);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsmanaging1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsmanaging1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsmanaging2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsmanaging2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsrehab);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsrehab);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsstem);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsstem);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmstips);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmstips);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsunderstand);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsunderstand);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsvitamin);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsvitamin);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsways);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsways);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsyour);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsyour);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsmultiple);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsmultiple);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanmsnicotine);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanmsnicotine);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
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
        public void LifestyleDiseaseManagement2FR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.LifetylDisMan);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.LifetylDisMan);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.LifetylDismannutrition);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismannutrition);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifetylDismanocd);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanocd);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanohno);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanohno);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanosteoporosis);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanosteoporosis);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanosteoporosis1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanosteoporosis1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanovercoming);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanovercoming);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanpeptic);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanpeptic);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanpicking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanpicking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanplant);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanplant);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanprostate);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanprostate);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanprotecting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanprotecting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanpsoriasis);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanpsoriasis);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanpsoriasis1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanpsoriasis1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanpsoriasis2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanpsoriasis2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanpsoriasis3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanpsoriasis3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanpsoriasis4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanpsoriasis4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanquitting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanquitting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanrare);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanrare);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanrecently);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanrecently);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanreduce);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanreduce);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanreducing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanreducing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanseason);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanseason);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismansexuality);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismansexuality);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantrans);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismantrans);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanshot);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanshot);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismansmoking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismansmoking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanstaying);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanstaying);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanstaying1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanstaying1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismansticking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismansticking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanstopsmk);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanstopsmk);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanstroke);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanstroke);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanstroke1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanstroke1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanstroke2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanstroke2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantalking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismantalking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantalking1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismantalking1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanthe);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanthe);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanthegreat);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanthegreat);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanthepersonal);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanthepersonal);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanthroid);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanthroid);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanthroid1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanthroid1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantop10);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismantop10);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantravel);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismantravel);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantreating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismantreating);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanwest);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanwest);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanwhat);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanwhat);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanwhat1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanwhat1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanwhen);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanwhen);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanworkout);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanworkout);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanyeast);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanyeast);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanyoucan);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanyoucan);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanyouand);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanyouand);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanyouyour);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanyouyour);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanyourbad);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanyourbad);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanyourvessels);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanyourvessels);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanyourcholesterol);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanyourcholesterol);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanyourheart);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanyourheart);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanyourtreatment);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanyourtreatment);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanyourtreatment1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanyourtreatment1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismanyourtreatment2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDismanyourtreatment2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDismantag);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.LogoutFR.Click();

            // Quit the driver
            driver.Quit();
        }
        public void LifestyleDEIFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.LifetylDEI);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.LifetylDEI);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.LifetylDEI2LGBT);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEI2LGBT);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifetylDEILGBworkplace);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEILGBworkplace);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIageism);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIageism);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIallies);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIallies);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIanti);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIanti);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIbeing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIbeing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIbiological);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIbiological);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIbuilding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIbuilding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIcoming);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIcoming);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIcoming1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIcoming1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIcreating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIcreating);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIcritical);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIcritical);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIengaging);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIengaging);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIForms);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIForms);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIgender);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIgender);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIimmigrant);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIimmigrant);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIimmigrant1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIimmigrant1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIimpacts);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIimpacts);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIimpl);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIimpl);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIinc);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIinc);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIindi);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIindi);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIindi1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIindi1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIinter);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIinter);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEImicro);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEImicro);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEInavi);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEInavi);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIrace);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIrace);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIreligion);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIreligion);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIresi);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIresi);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIsex);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIsex);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIsocial);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIsocial);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIsupporting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIsupporting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEISys);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEISys);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIunder);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIunder);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIwebinar);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIwebinar);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIwhite);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIwhite);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIworkplace);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIworkplace);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEIworkplace1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylDEIworkplace1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylDEITag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylDEITag);
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
        public void LifestyleEmployeeNewslettersFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.LifetylEmpNews);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.LifetylEmpNews);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.LifetylEmpNews10steps);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNews10steps);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifetylEmpNews360);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNews360);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsaddiction);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsaddiction);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsavoiding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsavoiding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsbacktoschool);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsbacktoschool);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsburnout);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsburnout);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewschildern);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewschildern);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewscompassion);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewscompassion);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewscoping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewscoping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewscreating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewscreating);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewscreating1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewscreating1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewscreating2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewscreating2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsdealing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsdealing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsencouraging);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsencouraging);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsfinancial);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsfinancial);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewshealing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewshealing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewshealing1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewshealing1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewshealthy);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewshealthy);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsholiday);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsholiday);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewshow);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewshow);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewshow1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewshow1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewshow2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewshow2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewshow3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewshow3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewshow4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewshow4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsindi);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsindi);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsinter);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsinter);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsinter1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsinter1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewscbt);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewscbt);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewskickstart);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewskickstart);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewskickstart1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewskickstart1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewskickstart2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewskickstart2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewslearning);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewslearning);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewslgbt);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewslgbt);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsmetime);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsmetime);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsmens);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsmens);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsmental1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsmental1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsmental2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsmental2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsmindful);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsmindful);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsnavi);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsnavi);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsnavi1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsnavi1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewspositive);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewspositive);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewspreparing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewspreparing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewspreparing1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewspreparing1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewspreparing2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewspreparing2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewspreventing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewspreventing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsptsd);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsptsd);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsreducing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsreducing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewssetting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewssetting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewssexual);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewssexual);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewssexual1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewssexual1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewssix);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewssix);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsstigma);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsstigma);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsstudent);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsstudent);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewssuicide);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewssuicide);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewssupporting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewssupporting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewssupporting1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewssupporting1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsteaching);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsteaching);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
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
        public void LifestyleEmployeeNewsletters1FR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.LifetylEmpNews);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.LifetylEmpNews);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.LifetylEmpNewsteaching1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsteaching1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifetylEmpNewsteaching2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsteaching2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsimpact);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsimpact);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsimpact1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsimpact1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsimpact2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsimpact2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsimpact3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsimpact3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsimpact4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsimpact4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsimpact5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsimpact5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsimportance);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsimportance);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsintersection);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsintersection);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsintersection1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsintersection1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsinvisible);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsinvisible);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsmanyfaces);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsmanyfaces);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsmanyptsd);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsmanyptsd);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewspsychology);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewspsychology);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewspsychology1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewspsychology1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsobering);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsobering);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstrauma);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewstrauma);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstrauma1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewstrauma1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsuncovering);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsuncovering);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsunderstanding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsunderstanding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsunderstanding1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsunderstanding1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewsvacation);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewsvacation);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewswhen);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewswhen);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewswhen1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewswhen1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewswomen);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewswomen);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewswomen1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewswomen1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNeewwomen2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNeewwomen2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewswomen3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewswomen3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewswomen4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewswomen4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewswomen5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewswomen5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewswomen6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewswomen6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewswomen7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylEmpNewswomen7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylEmpNewstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylEmpNewstag);
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
        public void LifestyleFitnessFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.LifetylFitness);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.LifetylFitness);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.LifetylFitarth);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitarth);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifetylFitens);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitens);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitgetting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitgetting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFithead);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFithead);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFithealthy);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFithealthy);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFithowto);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFithowto);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitidentify);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitidentify);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitimproving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitimproving);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitlearning);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitlearning);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitlinking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitlinking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitlooking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitlooking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitnut);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitnut);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitpain);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitpain);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitresilience);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitresilience);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitselfcare);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitselfcare);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitseniors);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitseniors);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitsleep);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitsleep);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitsmoke);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitsmoke);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitsocial);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitsocial);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitsocial1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitsocial1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitsports);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitsports);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitstop);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitstop);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitstroke);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitstroke);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittravel);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFittravel);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitunderstanding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitunderstanding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifetylFittag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifetylFitundefstanding1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifetylFitundefstanding1);
            Thread.Sleep(1000);
           
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.LogoutFR.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void LifestyleHealthandwellnessFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Lifetylheawell);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Lifetylheawell);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Lifetylheawellchild);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellchild);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetylheawellcreating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellcreating);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelleating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawelleating);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelleye);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawelleye);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellfaq);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellfaq);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellhand);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellhand);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellsani);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellsani);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellheadaches);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellheadaches);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellholidays);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellholidays);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellcbt);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellcbt);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelllearn);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawelllearn);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelllearn1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawelllearn1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellliving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellliving);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellmaking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellmaking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellmental);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellmental);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellms);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellms);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellorgan);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellorgan);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellpain);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellpain);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellquit);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellquit);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellquit1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellquit1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltrans);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawelltrans);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellsleep);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellsleep);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellsmoking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellsmoking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellsocial);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellsocial);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellsports);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellsports);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellsun);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellsun);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellsun1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellsun1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellrole);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellrole);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellwinter);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellwinter);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltoo);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawelltoo);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltoo1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawelltoo1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltoo2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawelltoo2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellunderstanding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellunderstanding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellunderstanding1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellunderstanding1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellunderstanding2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellunderstanding2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellunderstanding3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellunderstanding3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylheawelltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylheawellweight);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylheawellweight);
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
        public void LifestyleMentalHealthFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Lifetylmentalhealth);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Lifetylmentalhealth);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Lifetylmenhea);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenhea);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetylmenhea360);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenhea360);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheastress);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheastress);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaadapting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaadapting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaami);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaami);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheabeyond);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheabeyond);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheabody);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheabody);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheabreak);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheabreak);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheabreathe);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheabreathe);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheabuilding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheabuilding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheabuilding1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheabuilding1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheachild);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheachild);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheachild1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheachild1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaconnecting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaconnecting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheacoping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheacoping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheacoping1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheacoping1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheadealing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheadealing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheadealing1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheadealing1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheadealing2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheadealing2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaedeveloping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaedeveloping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaefin);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaefin);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaefinding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaefinding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaegetting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaegetting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaegoing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaegoing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheahealthy);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheahealthy);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaholiday);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaholiday);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheahow);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheahow);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheahow1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheahow1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheahow2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheahow2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheahow3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheahow3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheahow4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheahow4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheahumour);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheahumour);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaidentify);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaidentify);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaimp);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaimp);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaindi);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaindi);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheajune);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheajune);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheakeeping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheakeeping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheakickstart);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheakickstart);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheakickstart1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheakickstart1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheakickstart2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheakickstart2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenhealearning);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenhealearning);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenhealearning1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenhealearning1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenhealegal);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenhealegal);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenhealgbtq);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenhealgbtq);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenhealooking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenhealooking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamaintaining);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamaintaining);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamaintaining1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamaintaining1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamanaging);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamanaging);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheametime);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheametime);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamenmental);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamenmental);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamenillness);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamenillness);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamenmindfulness);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamenmindfulness);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamenmoving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamenmoving);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamennavigate);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamennavigate);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamenpho);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamenpho);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamenover);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamenover);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamenpositive);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamenpositive);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
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
        public void LifestyleMentalHealth1FR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Lifetylmentalhealth);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Lifetylmentalhealth);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Lifetylmenheamenpreparing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamenpreparing);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Lifetylmenheamenptsd);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamenptsd);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamenracial);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamenracial);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamenraising);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamenraising);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamenreenergizing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamenreenergizing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamenreducing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamenreducing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamenreducing1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamenreducing1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamenresilience);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamenresilience);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamenresposible);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamenresposible);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamensepa);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamensepa);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamensexual);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamensexual);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamensexual1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamensexual1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheamenshift);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheamenshift);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheasleep);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheasleep);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheasomeone);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheasomeone);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheasomeone1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheasomeone1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheasomeone2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheasomeone2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaspotting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaspotting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheastop);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheastop);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheastress1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheastress1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheastudent);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheastudent);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheasupporting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheasupporting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheasupporting1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheasupporting1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheasupporting2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheasupporting2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheasurviving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheasurviving);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheasurviving1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheasurviving1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheasurviving2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheasurviving2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheataking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheataking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheataking1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheataking1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheataking2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheataking2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheataking3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheataking3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatalking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheatalking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheathe);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheathe);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheathe1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheathe1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheathe2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheathe2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheathe3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheathe3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheathe4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheathe4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheathe5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheathe5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheathe6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheathe6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheathe7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheathe7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheathe8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheathe8);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheathe9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheathe9);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatoo);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheatoo);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheauncovering);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheauncovering);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaunder1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaunder1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaunder2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaunder2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaunder3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaunder3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaunder4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaunder4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaunder5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaunder5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheavacation);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheavacation);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheavis);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheavis);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheawellness);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheawellness);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheawhat);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheawhat);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheawhat1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheawhat1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheawhen);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheawhen);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheawomen);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheawomen);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheawomen1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheawomen1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheaworking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheaworking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheayou);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheayou);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheawomen1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifetylmenheawomen1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifetylmenheatag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Lifetylmenheatag);
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
        public void LifestyleNutritionGeneralFitnessFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.LifestyleNutritionGeneralFitness);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.LifestyleNutritionGeneralFitness);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.LifestyleNut);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNut);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifestyleNut12);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNut12);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNut4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNut4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNut5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNut5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNut5ways);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNut5ways);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNut6skin);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNut6skin);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutactive);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutactive);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutaging);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutaging);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutair);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutair);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutallergies);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutallergies);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutallergies1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutallergies1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutallergies2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutallergies2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutallergies3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutallergies3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutandro);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutandro);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutanemia);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutanemia);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutarth);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutarth);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutavoid);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutavoid);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutbed);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutbed);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutbreast);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutbreast);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutcaring);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutcaring);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutceleb);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutceleb);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutchild);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutchild);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutchoosing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutchoosing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutcommon);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutcommon);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutconstipation);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutconstipation);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutcooking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutcooking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutcoping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutcoping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutcrack);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutcrack);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutdand);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutdand);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutdealing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutdealing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutdental);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutdental);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutdetox);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutdetox);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutdiarr);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutdiarr);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutdont);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutdont);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutdreams);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutdreams);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutdrug);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutdrug);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuteat);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuteat);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuteating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuteating);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuteating1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuteating1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuteating2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuteating2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuteczema);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuteczema);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutensure);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutensure);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuterectile);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuterectile);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuterectile1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuterectile1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutexfol);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutexfol);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuteye);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuteye);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutfad);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutfad);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutfaq);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutfaq);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutfert);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutfert);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutfert1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutfert1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutfin);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutfin);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutfish);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutfish);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutfood);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutfood);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutfood1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutfood1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutfood2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutfood2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutfoot);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutfoot);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutget);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutget);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutgetting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutgetting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutgetting1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutgetting1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuthand);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuthand);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
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
        public void LifestyleNutritionGeneralFitness1FR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.LifestyleNutritionGeneralFitness);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.LifestyleNutritionGeneralFitness);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.LifestyleNuthand1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuthand1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifestyleNuthappy);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuthappy);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuthealthy);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuthealthy);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuthealthy1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuthealthy1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuthealthy2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuthealthy2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutholidays);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutholidays);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutheart);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutheart);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuthow);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuthow);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuthow1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuthow1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuthow2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuthow2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuthow3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuthow3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuthow4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuthow4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutincr);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutincr);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutindoor);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutindoor);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutinfer);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutinfer);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutinfer1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutinfer1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutinfer2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutinfer2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutinteg);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutinteg);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutitches);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutitches);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutjump);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutjump);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutkeep);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutkeep);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutkeep1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutkeep1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutkeep2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutkeep2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutkeep3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutkeep3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutlearn);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutlearn);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutlearn1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutlearn1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutlearn2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutlearn2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutlink);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutlink);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutliving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutliving);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutmilk);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutmilk);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutmy);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutmy);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutmy1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutmy1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutnico);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutnico);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutnotso);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutnotso);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutnut);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutnut);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutnut1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutnut1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutnut2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutnut2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutnut3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutnut3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutohno);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutohno);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutoral);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutoral);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutplant);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutplant);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutpmp);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutpmp);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutpreparing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutpreparing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutpreparing1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutpreparing1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutprobiotic);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutprobiotic);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutprobiotic1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutprobiotic1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutquit);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutquit);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutquit1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutquit1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutreduce);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutreduce);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutrun);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutrun);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutscalp);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutscalp);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutskin);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutskin);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutsleep);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutsleep);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutsleep1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutsleep1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutsmoke);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutsmoke);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutsocial);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutsocial);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutsocial1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutsocial1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutsocial2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutsocial2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutstaying);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutstaying);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutstaying1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutstaying1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
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
        public void LifestyleNutritionGeneralFitness2FR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Lifetyle);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.LifestyleNutritionGeneralFitness);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.LifestyleNutritionGeneralFitness);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.LifestyleNutstopsmoking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutstopsmoking);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LifestyleNutstress);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutstress);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutsummer);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutsummer);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutsummer1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutsummer1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutsun);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutsun);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttelling);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuttelling);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutthe1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutthe1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutthe2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutthe2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutthe3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutthe3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutthe4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutthe4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutthe5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutthe5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutthe6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutthe6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutthe7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutthe7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutthe8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutthe8);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutthy);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutthy);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttime);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuttime);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttips);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuttips);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttravel);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNuttravel);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutttrying);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutttrying);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutunderstand);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutunderstand);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutunderstand1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutunderstand1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutwater);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutwater);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutwhat);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutwhat);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutwhat1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutwhat1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutwhat2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutwhat2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutwhat3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutwhat3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutwhy);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutwhy);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutwhy1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutwhy1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutwinter);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutwinter);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutworkout);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutworkout);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutwork1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutwork1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutwork2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutwork2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutyoga);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutyoga);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutyou);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutyou);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutyou1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutyou1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutyour);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutyour);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutyour1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutyour1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutyour2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutyour2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutyour3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutyour3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutyour4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutyour4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutyour4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNutyour4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNutyour5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LifestyleNutyour5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LifestyleNuttag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LifestyleNuttag);
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
