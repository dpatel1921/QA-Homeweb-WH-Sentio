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
    public class AlumniRegression
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
            public string AlumniUsername { get; set; }
            public string AlumniPassword { get; set; }
            public string Url { get; set; }




        }

        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void AlumniAddiction(string AlumniUsername, string AlumniPassword, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new AlumniRegressionObjects();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(AlumniUsername);

            homePage.Next.Click();

            homePage.Password.SendKeys(AlumniPassword);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            ClickAndNavigate(RegObj.AlumniAddiction);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.AlumniAddiction1);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.AlumniAddiction1);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniAddiction3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction8);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction9);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction10);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction10);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction11);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction11);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);  
            ScrollToElement(RegObj.AlumniAddiction12);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction12);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction13);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.    AlumniAddiction13);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction14);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction14);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction15);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction15);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction16);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction16);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction17);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction17);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction18);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction18);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction19);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction19);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction20);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction20);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction21);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction21);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction22);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction22);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction23);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction23);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction24);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction24);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction25);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction25);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction26);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction26);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction27);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction27);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction28);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction28);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction29);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction29);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction30);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction30);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction31);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction31);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction32);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction32);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniAddictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniAddiction33);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniAddiction33);
            Thread.Sleep(1000);



            ScrollToElement(homePage.Profile);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.Profile);

            homePage.Logout.Click();

            // Quit the driver
            driver.Quit();
        }

        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void AlumniLifeSkills(string AlumniUsername, string AlumniPassword, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new AlumniRegressionObjects();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(AlumniUsername);

            homePage.Next.Click();

            homePage.Password.SendKeys(AlumniPassword);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            ClickAndNavigate(RegObj.AlumniLS1);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.AlumniLS2);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.AlumniLS2);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniLS3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS8);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS9);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS10);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS10);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS11);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS11);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS12);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS12);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS13);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS13);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS14);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS14);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS15);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS15);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS16);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS16);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS17);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS17);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS18);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS18);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS19);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS19);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS20);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS20);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS21);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS21);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS22);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniLS22);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniLS2tag);
            Thread.Sleep(1000);
            ScrollToElement(homePage.Profile);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.Profile);

            homePage.Logout.Click();

            // Quit the driver
            driver.Quit();
        }

        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void AlumniRelationships(string AlumniUsername, string AlumniPassword, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new AlumniRegressionObjects();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(AlumniUsername);

            homePage.Next.Click();

            homePage.Password.SendKeys(AlumniPassword);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            ClickAndNavigate(RegObj.AlumniRS1);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.AlumniRS2);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.AlumniRS2);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRS2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRS2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRStag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniRS3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRS3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRS4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRS4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRS5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRS5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRS6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRS6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRS7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRS7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRS8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRS8);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRS9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRS9);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRS10);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRS10);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRS11);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRS11);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRS12);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRS12);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRS13);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRS13);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRS14);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRS14);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRS15);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRS15);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRS16);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRS16);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRStag);
            Thread.Sleep(1000);
            ScrollToElement(homePage.Profile);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.Profile);

            homePage.Logout.Click();

            // Quit the driver
            driver.Quit();
        }

        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void AlumniRecovery(string AlumniUsername, string AlumniPassword, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new AlumniRegressionObjects();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(AlumniUsername);

            homePage.Next.Click();

            homePage.Password.SendKeys(AlumniPassword);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            ClickAndNavigate(RegObj.AlumniRecovery);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.AlumniRecovery1);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.AlumniRecovery1);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniRecovery3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery8);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery9);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery10);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery10);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery11);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery11);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery12);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery12);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery13);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery13);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery14);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery14);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery15);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery15);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery16);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery16);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery17);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery17);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery18);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery18);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery19);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery19);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery20);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery20);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery21);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery21);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery22);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery22);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery23);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery23);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery24);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery24);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery25);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery25);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery26);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery26);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery27);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery27);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery28);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery28);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery29);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery29);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery30);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery30);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery31);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery31);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery32);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery32);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery33);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery33);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery34);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery34);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniRecoverytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniRecovery35);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniRecovery35);
            Thread.Sleep(1000);


            ScrollToElement(homePage.Profile);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.Profile);

            homePage.Logout.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void AlumniWellnessTogether(string AlumniUsername, string AlumniPassword, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new AlumniRegressionObjects();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(AlumniUsername);

            homePage.Next.Click();

            homePage.Password.SendKeys(AlumniPassword);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            ClickAndNavigate(RegObj.AlumniRecovery);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Alumniwellness1);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Alumniwellness1);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Alumniwellness2);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Alumniwellness2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Alumniwellnesstag);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Alumniwellnesstag);
            Thread.Sleep(1000);

          

            ScrollToElement(homePage.Profile);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.Profile);

            homePage.Logout.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void AlumniHealingwithHomewood(string AlumniUsername, string AlumniPassword, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new AlumniRegressionObjects();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(AlumniUsername);

            homePage.Next.Click();

            homePage.Password.SendKeys(AlumniPassword);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            ClickAndNavigate(RegObj.AlumniHealing);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.AlumniHealing1);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.AlumniHealing1);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealing2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniHealing2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniHealing3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniHealing3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealing4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniHealing4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealing5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniHealing5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealing6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniHealing6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealing7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniHealing7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealing8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniHealing8);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealing9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniHealing9);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealing10);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniHealing10);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealing11);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniHealing11);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealing12);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniHealing12);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealing13);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniHealing13);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealing14);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniHealing14);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealing15);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniHealing15);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealing16);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniHealing16);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniHealingtag);
            Thread.Sleep(1000);
           

            ScrollToElement(homePage.Profile);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.Profile);

            homePage.Logout.Click();

            // Quit the driver
            driver.Quit();
        }

        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void AlumniGettingStarted(string AlumniUsername, string AlumniPassword, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new AlumniRegressionObjects();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(AlumniUsername);

            homePage.Next.Click();

            homePage.Password.SendKeys(AlumniPassword);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            ClickAndNavigate(RegObj.AlumniGettingStarted);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.AlumniGettingStarted1);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.AlumniGettingStarted1);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStarted2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniGettingStarted2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniGettingStarted3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniGettingStarted3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStarted4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniGettingStarted4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStarted5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniGettingStarted5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStarted6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniGettingStarted6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStarted7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniGettingStarted7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStarted8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniGettingStarted8);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStarted9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniGettingStarted9);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStarted10);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniGettingStarted10);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStarted11);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniGettingStarted11);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStarted12);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniGettingStarted12);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStarted13);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniGettingStarted13);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStarted14);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniGettingStarted14);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStarted15);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniGettingStarted15);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStarted16);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniGettingStarted16);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStarted17);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniGettingStarted17);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStarted18);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniGettingStarted18);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniGettingStartedtag);
            Thread.Sleep(1000);


            ScrollToElement(homePage.Profile);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.Profile);

            homePage.Logout.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void AlumniWebinars(string AlumniUsername, string AlumniPassword, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new AlumniRegressionObjects();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(AlumniUsername);

            homePage.Next.Click();

            homePage.Password.SendKeys(AlumniPassword);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            ClickAndNavigate(RegObj.AlumniWebinars);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.AlumniWebinars1);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.AlumniWebinars1);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.AlumniWebinarstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniWebinarstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniWebinars2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniWebinars2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniWebinarstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniWebinarstag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniWebinars3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniWebinars3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniWebinarstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniWebinarstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniWebinars4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniWebinars4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniWebinarstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniWebinarstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniWebinars5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniWebinars5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniWebinarstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniWebinarstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniWebinars6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniWebinars6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniWebinarstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniWebinarstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniWebinars7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniWebinars7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniWebinarstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniWebinarstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniWebinars8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniWebinars8);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniWebinarstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniWebinarstag);
            Thread.Sleep(1000);
            

            ScrollToElement(homePage.Profile);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.Profile);

            homePage.Logout.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void AlumniCrisis(string AlumniUsername, string AlumniPassword, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new AlumniRegressionObjects();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(AlumniUsername);

            homePage.Next.Click();

            homePage.Password.SendKeys(AlumniPassword);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            ClickAndNavigate(RegObj.AlumniCrisis);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.AlumniCrisis1);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.AlumniCrisis1);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.AlumniCrisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCrisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCrisis2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCrisis2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniCrisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCrisistag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniCrisis3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCrisis3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCrisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCrisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCrisis4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCrisis4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCrisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCrisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCrisis5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCrisis5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCrisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCrisistag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCrisis6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCrisis6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCrisistag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCrisistag);
            Thread.Sleep(1000);
           

            ScrollToElement(homePage.Profile);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.Profile);

            homePage.Logout.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void AlumniCovid(string AlumniUsername, string AlumniPassword, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new AlumniRegressionObjects();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(AlumniUsername);

            homePage.Next.Click();

            homePage.Password.SendKeys(AlumniPassword);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            ClickAndNavigate(RegObj.AlumniCrisis);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.AlumniCovid);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.AlumniCovid);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.AlumniCovid1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCovid1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniCovid2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCovid2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovid3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCovid3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovid4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCovid4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovid5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCovid5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovid6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCovid6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovid7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCovid7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovid8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCovid8);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovid9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCovid9);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovid10);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCovid10);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovid11);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCovid11);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovid12);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCovid12);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovid13);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCovid13);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovid14);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCovid14);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovid15);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCovid15);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovid16);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCovid16);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovid17);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniCovid17);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniCovidtag);
            Thread.Sleep(1000);


            ScrollToElement(homePage.Profile);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.Profile);

            homePage.Logout.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void AlumniMentalHealth(string AlumniUsername, string AlumniPassword, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new AlumniRegressionObjects();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(AlumniUsername);

            homePage.Next.Click();

            homePage.Password.SendKeys(AlumniPassword);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            ClickAndNavigate(RegObj.AlumniMentalHealth);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.AlumniMentalHealth1);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.AlumniMentalHealth1);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth2);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealth3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth8);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth8);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth9);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth9);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth10);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth10);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth11);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth11);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth12);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth12);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth13);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth13);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth14);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth14);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth15);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth15);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth16);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth16);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth17);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth17);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth18);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth18);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth19);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth19);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth20);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth20);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth21);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth21);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth22);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth22);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth23);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth23);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth24);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth24);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth25);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth25);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth26);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth26);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth27);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth27);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth28);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth28);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth29);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth29);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth30);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth30);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth31);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth31);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth32);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth32);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth33);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth33);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth34);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth34);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth35);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth35);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth36);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth36);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth37);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth37);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth38);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth38);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth39);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth39);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth40);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth40);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth41);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth41);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth42);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth42);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth43);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth43);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth44);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth44);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth45);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth45);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth46);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth46);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth47);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth47);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth48);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth48);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth49);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth49);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth50);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth50);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth51);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth51);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth52);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth52);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.AlumniMentalHealth53);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.AlumniMentalHealth53);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.AlumniMentalHealthtag);
            Thread.Sleep(1000);

            ScrollToElement(homePage.Profile);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.Profile);

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
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.AlumniUsername)
                                                        && !string.IsNullOrEmpty(data.AlumniPassword)
                                                        && data.Url == "https://homeweb.ca/alumni");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.AlumniUsername, loginData.AlumniPassword, loginData.Url);
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
