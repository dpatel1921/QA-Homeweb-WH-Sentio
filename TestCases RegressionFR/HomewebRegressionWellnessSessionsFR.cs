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
    public class HomewebRegressionWellnessSessionsFR
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
        public void Webinars(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Wellnesssessions);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Wellnesssessionbeyondstigma);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Wellnesssessionbeyondstigma);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Wellresilience);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Wellresilience);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Wellbuilding);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Wellbuilding);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Wellimproving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Wellimproving);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Wellmanaging);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Wellmanaging);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Wellstress);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Wellstress);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Wellartof);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Wellartof);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Wellfundamentals);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Wellfundamentals);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Welljourney);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Welljourney);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Wellscience);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Wellscience);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Wellnesssessionstag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Wellnesssessionstag);
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
