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
    public class HomewebRegressionWebinarsFR
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
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.webinars);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Covid19support);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Covid19support);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.webinartag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.webinartag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Covid19whatis);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Covid19whatis);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.webinartag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.webinartag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Mentalhealthcovid);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalhealthcovid);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.webinartag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.webinartag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.practicingmindfulness);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.practicingmindfulness);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.webinartag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.webinartag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Webinardealingwith);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Webinardealingwith);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.webinartag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.webinartag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Webinarthesecondwave);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Webinarthesecondwave);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.webinartag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.webinartag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Webinarcovid19mental);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Webinarcovid19mental);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.webinartag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.webinartag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Webinarcovid19loneliness);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Webinarcovid19loneliness);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.webinartag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.webinartag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Webinarcovid19transition);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Webinarcovid19transition);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.webinartag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.webinartag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Webinardevelopeing);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Webinardevelopeing);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.webinartag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.webinartag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Webinarinclusion);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Webinarinclusion);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.webinartag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.webinartag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.WebinarCBT);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.WebinarCBT);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.webinartag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.webinartag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Webinarreducinganxiety);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Webinarreducinganxiety);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.webinartag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.webinartag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Webinarsocialmedia);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Webinarsocialmedia);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.webinartag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.webinartag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Webinarwomensmental);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Webinarwomensmental);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.webinartag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.webinartag);
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
