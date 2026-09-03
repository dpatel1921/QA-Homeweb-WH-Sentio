/*using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System.Text.Json;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using AutoItX3Lib;
using System.Collections.Generic;
using NUnit.Framework.Internal;
using AventStack.ExtentReports;
using System.Security.Policy;
using System.Diagnostics;
using SeleniumExtras.WaitHelpers;
using System.Data;
using WarriorHealthBeta.Objects;


namespace WarriorHealthBeta.TestCases
{
    [TestFixture]
    public class HomePage
    {
        private IWebDriver driver;
        AutoItX3 au3 = new AutoItX3();
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
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
         
            var options = new ChromeOptions();
            options.AddArgument("start-maximized");
            driver = new ChromeDriver(options);

            driver.Manage().Window.Maximize();
        }
        public class TestCaseJsonData
        {
            public string Login { get; set; }
            public string Password { get; set; }
            public string Url { get; set; }
         
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void LoginValidation(string Login, string Password, string Url)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var homePage = new HomePageObjects();
            PageFactory.InitElements(driver, homePage);
            //driver.Navigate().GoToUrl(Url);
            /* au3.Send("Login");
             au3.Send("{Tab}");
             au3.Send("Password");
             Thread.Sleep(3000);
             au3.Send("{Enter}");
            string username = Login;
            string password = Password;

            string url = $"https://{username}:{password}@beta.warriorhealth.ca/en";
            driver.Navigate().GoToUrl(url);
            TakeScreenshot("C:\\TestData\\WarriorHealth\\Login_");
            driver.Close();
           
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void Home(string Login, string Password, string Url)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var homePage = new HomePageObjects();
            PageFactory.InitElements(driver, homePage);
            string username = Login;
            string password = Password;

            string url = $"https://{username}:{password}@beta.warriorhealth.ca/en";
            driver.Navigate().GoToUrl(url);

            Thread.Sleep(1000);
            homePage.Home.Click();
            Thread.Sleep(1000);
            homePage.ForIndividuals.Click();
            Thread.Sleep(1000);
            ScrollToElement(homePage.ForFamilies);
            homePage.ForFamilies.Click();
            Thread.Sleep(1000);
            ScrollToElement(homePage.ForOrgs);
            homePage.ForOrgs.Click();
            Thread.Sleep(1000);
            driver.Navigate().Back();
            Thread.Sleep(1000);

            homePage.PeerSupport.Click();
            Thread.Sleep(1000);
            driver.Navigate().Back();
            Thread.Sleep(1000);
            homePage.CrisisSupport.Click();
            driver.Navigate().Back();
            Thread.Sleep(1000);
            homePage.Poweredby1.Click();
            Thread.Sleep(1000);
            homePage.Home.Click();
            Thread.Sleep(1000);
            homePage.Poweredby2.Click();
            Thread.Sleep(1000);
            homePage.Home.Click(); 
            Thread.Sleep(1000);
            homePage.Poweredby3.Click();
            Thread.Sleep(1000);
            homePage.Home.Click();
            Thread.Sleep(1000);
            homePage.Poweredby4.Click();
            Thread.Sleep(1000);
            homePage.Home.Click();
            Thread.Sleep(1000);
            homePage.Poweredby5.Click();
            Thread.Sleep(1000);
            homePage.Home.Click();
            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");
            driver.Close();

        }
        public static IEnumerable<TestCaseData> LoginJsonData()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\WarriorHealthBeta\\TestData\\TestData.Json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.Login)
                                                        && !string.IsNullOrEmpty(data.Password)
                                                        && data.Url == "https://beta.warriorhealth.ca/en");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Login, loginData.Password, loginData.Url);
            }
        }
        private void TakeScreenshot(string filePath)
        {
            ITakesScreenshot ssd = driver as ITakesScreenshot;
            Screenshot ss = ssd.GetScreenshot();
            ss.SaveAsFile(filePath + time.ToString("yy_dd_h_mm_ss") + ".png");
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            // Flush the extent reports
            extent.Flush();
        }
        private void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        [TearDown]
        public void Endtest()
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
            driver.Quit();
            driver.Dispose();
        }

    }
}*/
