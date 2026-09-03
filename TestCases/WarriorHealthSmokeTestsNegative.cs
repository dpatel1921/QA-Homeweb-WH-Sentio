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
    public class WarriorHealthSmokeTestsNegative
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
            public string WrongLogin { get; set; }
            public string WrongPassword { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
            public string Url { get; set; }
            public string Invalid { get; set; }
            public string Valid { get; set; }
            public string Search1 { get; set; }
            public string Search2 { get; set; }
            public string OrgName { get; set; }
            public string RepName { get; set; }
            public string RepTitle { get; set; }
            public string RepEmail { get; set; }
            public string RepPhone { get; set; }
            public string City { get; set; }
            public string Province { get; set; }
        }
        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void LoginNegative(string WrongLogin, string WrongPassword, string Url)
        {
            NavigateWithCredentials(WrongLogin, WrongPassword);

            driver.Close();

        }


        [Test, TestCaseSource(nameof(LoginJsonData3))]
        public void SmokeEnrollorgNegative1(string Login, string Password, string Url, string OrgName, string RepName,
     string RepTitle, string RepPhone)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var homePage = new WarriorHealthObjects();
            PageFactory.InitElements(driver, homePage);

            string url = $"https://{Login}:{Password}@staging.warriorhealth.ca/en";
            driver.Navigate().GoToUrl(url);

            Assert.That(driver.Url.Contains("warriorhealth.ca"), "Login did not redirect to WarriorHealth.");

            ScrollAndClick(wait, homePage.ForOrgs);
            ScrollAndClick(wait, homePage.Enroll1);

            wait.Until(ExpectedConditions.ElementToBeClickable(homePage.OrgEnroll1)).SendKeys(OrgName);
            homePage.OrgEnroll2.SendKeys(RepName);
            homePage.OrgEnroll3.SendKeys(RepTitle);
            string uniqueEmail = GenerateUniqueEmail();
            homePage.OrgEnroll4.SendKeys(uniqueEmail);
            ScrollAndClick(homePage.OrgEnroll11);
            ScrollAndClick(wait, homePage.OrgEnroll7);

            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");

          

            driver.Close();
        }

        [Test, TestCaseSource(nameof(LoginJsonData3))]
        public void SmokeEnrollorgNegative2(string Login, string Password, string Url, string OrgName, string RepName,
            string RepPhone, string RepTitle)
        {
            NavigateWithCredentials(Login, Password);
            var homePage = new WarriorHealthObjects();
            PageFactory.InitElements(driver, homePage);

            ScrollAndClick(homePage.ForOrgs);
            ScrollAndClick(homePage.Enroll1);

            homePage.OrgEnroll1.SendKeys(OrgName);
            homePage.OrgEnroll2.SendKeys(RepName);
            homePage.OrgEnroll3.SendKeys(RepPhone);
            homePage.OrgEnroll4.SendKeys(GenerateUniqueEmail());
            ScrollAndClick(homePage.OrgEnroll11);
            ScrollAndClick(homePage.OrgEnroll7);
            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");
            Assert.That(driver.PageSource.Contains("error") || driver.PageSource.Contains("required"));
            driver.Close();

        }
        [Test, TestCaseSource(nameof(LoginJsonData5))]
        public void SmokeEnrollorgNegative3(string Login, string Password, string Url)
        {
            NavigateWithCredentials(Login, Password);
            var homePage = new WarriorHealthObjects();
            PageFactory.InitElements(driver, homePage);

            ScrollAndClick(homePage.ForOrgs);
            ScrollAndClick(homePage.Enroll1);
            ScrollAndClick(homePage.OrgEnroll11);
            ScrollAndClick(homePage.OrgEnroll7);

            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");
            Assert.That(driver.PageSource.Contains("error") || driver.PageSource.Contains("required"));
            driver.Close();

        }
        [Test, TestCaseSource(nameof(LoginJsonData4))]
        public void SmokeEmailUpdatesNegative(string Login, string Password, string Url, string OrgName, string RepName,
            string RepTitle, string RepEmail, string RepPhone)
        {
            NavigateWithCredentials(Login, Password);
            var homePage = new WarriorHealthObjects();
            PageFactory.InitElements(driver, homePage);

            ScrollAndClick(homePage.Footer7);
            homePage.OrgEmailupdate.SendKeys(RepName);
            homePage.OrgEnroll4.SendKeys(GenerateUniqueEmail());
            ScrollAndClick(homePage.EmailSign1);

            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");
            Assert.That(driver.PageSource.Contains("error") || driver.PageSource.Contains("required"));
            driver.Close();
        }
        [Test, TestCaseSource(nameof(LoginJsonData4))]
        public void SmokeEmailUpdatesNegative1(string Login, string Password, string Url, string OrgName, string RepName,
           string RepTitle, string RepEmail, string RepPhone)
        {
            NavigateWithCredentials(Login, Password);
            var homePage = new WarriorHealthObjects();
            PageFactory.InitElements(driver, homePage);

            ScrollAndClick(homePage.Footer7);
            homePage.OrgEmailupdate.SendKeys(RepName);
            homePage.OrgEnroll3.SendKeys(RepTitle);
            ScrollAndClick(homePage.EmailSign1);

            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");
            Assert.That(driver.PageSource.Contains("error") || driver.PageSource.Contains("required"));
            driver.Close();

        }
        [Test, TestCaseSource(nameof(LoginJsonData4))]
        public void SmokeEmailUpdatesNegative2(string Login, string Password, string Url, string OrgName, string RepName,
          string RepTitle, string RepEmail, string RepPhone)
        {
            NavigateWithCredentials(Login, Password);
            var homePage = new WarriorHealthObjects();
            PageFactory.InitElements(driver, homePage);

            ScrollAndClick(homePage.Footer7);
            ScrollAndClick(homePage.EmailSign1);

            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");
            Assert.That(driver.PageSource.Contains("error") || driver.PageSource.Contains("required"));
            driver.Close();

        }


        public static IEnumerable<TestCaseData> LoginJsonData2()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\WarriorHealthBeta\\TestData\\TestData.Json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.WrongLogin)
                                                        && !string.IsNullOrEmpty(data.WrongPassword)
                                                        && data.Url == "https://staging.warriorhealth.ca/en");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.WrongLogin, loginData.WrongPassword, loginData.Url);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData3()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\WarriorHealthBeta\\TestData\\TestData.Json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.Login)
                                                        && !string.IsNullOrEmpty(data.Password)
                                                        && data.Url == "https://staging.warriorhealth.ca/en");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Login, loginData.Password, loginData.Url, loginData.OrgName,
                    loginData.RepName, loginData.RepPhone,loginData.RepTitle);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData4()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\WarriorHealthBeta\\TestData\\TestData.Json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.Login)
                                                        && !string.IsNullOrEmpty(data.Password)
                                                        && data.Url == "https://staging.warriorhealth.ca/en");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Login, loginData.Password, loginData.Url, loginData.OrgName,
                    loginData.RepName, loginData.RepTitle, loginData.RepEmail, loginData.RepPhone);
            
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData5()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\WarriorHealthBeta\\TestData\\TestData.Json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.Login)
                                                        && !string.IsNullOrEmpty(data.Password)
                                                        && data.Url == "https://staging.warriorhealth.ca/en");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Login, loginData.Password, loginData.Url);
            }
        }
        private void ScrollAndClick(WebDriverWait wait, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'});", element);
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            try
            {
                element.Click();
            }
            catch (ElementClickInterceptedException)
            {
                js.ExecuteScript("arguments[0].click();", element);
            }
        }

        private void TakeScreenshot(string filePath)
        {
            ITakesScreenshot ssd = driver as ITakesScreenshot;
            Screenshot ss = ssd.GetScreenshot();
            ss.SaveAsFile(filePath + time.ToString("yy_dd_h_mm_ss") + ".png");
        }
        private void NavigateWithCredentials(string username, string password)
        {
            string url = $"https://{username}:{password}@staging.warriorhealth.ca/en";
            driver.Navigate().GoToUrl(url);
            Assert.That(driver.Url.Contains("warriorhealth.ca"), "Navigation failed.");
        }
        [OneTimeTearDown]
        public void TearDown()
        {
          
            extent.Flush();
        }
        private void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        private void ClickAndSwitchNewTab(IWebElement element)
        {
            ClickAndNavigate(element);
            SwitchToNewTab();
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }
        private void ScrollAndClick(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'});", element);
           

            try
            {
                element.Click();
            }
            catch (ElementClickInterceptedException)
            {
                js.ExecuteScript("arguments[0].click();", element);
            }
        }
        private void SwitchToNewTab()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(d => driver.WindowHandles.Count > 1);
            var newTab = driver.WindowHandles.Last();
            driver.SwitchTo().Window(newTab);
        }
        private void ClickAndNavigate(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => element.Displayed);
            element.Click();
        }
        private static string GenerateUniqueEmail()
        {
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            return $"testuser_{timestamp}@demo.com";
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
