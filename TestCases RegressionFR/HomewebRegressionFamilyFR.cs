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
    public class HomewebRegressionFamilyFR
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
        public void FamilyFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Family);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Familyresource);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Familyresource);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familystress);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familystress);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Familybabies);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familybabies);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familybackto);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familybackto);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familybecoming);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familybecoming);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familybuilding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familybuilding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycelebrating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycelebrating);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycelebrating1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycelebrating1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycelebrating2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycelebrating2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familychildcare);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familychildcare);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familychildcare1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familychildcare1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familychildren1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familychildren1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familychildren2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familychildren2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familychildren2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familychildren2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familychoosing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familychoosing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycombining);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycombining);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycovid19);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycovid19);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycreate);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycreate);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyeffective);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyeffective);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyeldercare);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyeldercare);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyemployees);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyemployees);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyfamilylaw);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyfamilylaw);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyfinancial1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyfinancial1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyfinancial2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyfinancial2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyfoundations);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyfoundations);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyfoundations1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyfoundations1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyfromkids);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyfromkids);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
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
        public void FamilycontinueFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Family);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Familygrand);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Familygrand);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyhealthy);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyhealthy);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Familyhelping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyhelping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyhousing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyhousing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyhowto);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyhowto);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyhowto1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyhowto1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyhowto2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyhowto2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyhowto3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyhowto3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyimproving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyimproving);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyinfertility);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyinfertility);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyisittime);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyisittime);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familylongdistance);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familylongdistance);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familynewparent);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familynewparent);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familypostpartem);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familypostpartem);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familypostpreparinglife);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familypostpreparinglife);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familypreparing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familypreparing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyrelationship);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyrelationship);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyresolving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyresolving);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familysecure);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familysecure);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyselfcare);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyselfcare);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyseparation);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyseparation);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familysetting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familysetting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familysingle);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familysingle);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familysomeone);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familysomeone);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyspirited);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyspirited);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familystaying);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familystaying);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);

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
        public void FamilycontinuesFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Family);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Familytaking);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Familytaking);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytalking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familytalking);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Familytalking1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familytalking1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytech);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familytech);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytech1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familytech1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytantrums);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familytantrums);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familygreatallowance);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familygreatallowance);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyimpact);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyimpact);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familypositive);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familypositive);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyparent);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyparent);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyteenagers);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyteenagers);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyunderstanding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyunderstanding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyunderstanding1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyunderstanding1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyvaping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyvaping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familywhenthe);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familywhenthe);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyyour);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyyour);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyyouth);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyyouth);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyyouth1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyyouth1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyyouth2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyyouth2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familyyouth3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familyyouth3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familytag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familytag);
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
        public void FamilyCaregivingFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Family);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Familycaregiving);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Familycaregivingparents);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycaregivingparents);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Familycaregivingelder);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycaregivingelder);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivingemployees);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycaregivingemployees);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivingfinancial);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycaregivingfinancial);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivinghousing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycaregivinghousing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivinglong);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycaregivinglong);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivingrespite);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycaregivingrespite);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivingselfcare);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycaregivingselfcare);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivingunder);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycaregivingunder);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivingunder1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycaregivingunder1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivingunder2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycaregivingunder2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycaregivingtag);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.Logout.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void FamilyCommunicationFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Family);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Familycomm);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Familycommtrans);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycommtrans);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycommtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Familycommbuilding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycommbuilding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommcombining);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycommcombining);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommimproving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycommimproving);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommrelationship);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycommrelationship);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommtalking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycommtalking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommtalking1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycommtalking1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommtech);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycommtech);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommtodays);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycommtodays);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommconsent);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycommconsent);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommconsent1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Familycommconsent1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Familycommtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Familycommtag);
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
        public void FamilyFinancesFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Family);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.FamilyFin);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.FamilyFinben);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyFinben);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyFintag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.FamilyFinmental);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyFinmental);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFinconsultation);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyFinconsultation);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFinfitness);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyFinfitness);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFinissues);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyFinissues);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFinselfcare);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyFinselfcare);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFinstress);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyFinstress);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFinkidsto);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyFinkidsto);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFintimefor);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyFintimefor);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFinovercoming);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyFinovercoming);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFinplanning);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyFinplanning);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFinpreparing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyFinpreparing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFintaking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyFintaking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFinthe);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyFinthe);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFinthe1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyFinthe1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFinthe2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyFinthe2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyFintag);
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
        public void FamilyParentingFR(string HWLogin1, string HWPassword1, string Url)
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

            // Browse and navigate to Tools
            ClickAndNavigate(homePage.Browse);
            ClickAndNavigate(RegObj.Family);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.FamilyParenting);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.FamilyParstress);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParstress);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.FamilyParadhd);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParadhd);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParbabies);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParbabies);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParbackto);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParbackto);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParbackto1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParbackto1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParbecoming);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParbecoming);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParcelebratingdads);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParcelebratingdads);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParcelebratingmoms);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParcelebratingmoms);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParchildcare1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParchildcare1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParchildcare2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParchildcare2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParchildren);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParchildren);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParchildren1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParchildren1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParchoosing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParchoosing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParcombining);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParcombining);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParcreate);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParcreate);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyPareffective);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyPareffective);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParfoundations1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParfoundations1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParfoundations2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParfoundations2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyPargrand);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyPargrand);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParMaid);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParMaid);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParhelping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParhelping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParhowto);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParhowto);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParhowto1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParhowto1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParhowto2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParhowto2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParimproving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParimproving);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParnewparent);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParnewparent);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParpreparing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParpreparing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParsecure);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParsecure);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParseparation);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParseparation);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParsingle);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParsingle);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParspirited);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParspirited);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParspotting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParspotting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyPartalking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyPartalking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyPartalking1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyPartalking1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyPartamper);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyPartamper);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyPartheimpact);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyPartheimpact);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParthepower);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParthepower);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyPartheworking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyPartheworking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParteenagers);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParteenagers);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParvaping);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParvaping);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParconsent);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParconsent);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParyour);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParyour);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParyour1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.FamilyParyour1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.FamilyParstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.FamilyParstag);

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
