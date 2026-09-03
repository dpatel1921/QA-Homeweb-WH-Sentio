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
    public class HomewebRegressionToolsFR
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
        public void ToolsFR(string HWLogin1, string HWPassword1, string Url)
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

            ClickAndNavigate(RegObj.Tools);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Toolsbacktoschool);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Toolsbacktoschool);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.ToolsTag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ToolsTag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Toolsecounselling);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Toolsecounselling);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ToolsTag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ToolsTag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Toolsecourses);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Toolsecourses);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ToolsTag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ToolsTag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Toolsmemberorientation);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Toolsmemberorientation);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ToolsTag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ToolsTag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ToolsIntrotoCBT);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ToolsIntrotoCBT);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ToolsTag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ToolsTag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ToolsLS);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ToolsLS);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ToolsTag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ToolsTag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ToolsVideo);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.ToolsVideo);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ToolsTag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ToolsTag);
            Thread.Sleep(1000);

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
        public void ToolsCounsellingFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Tools);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Counselling);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ECounselling);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ECounselling);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Counsellingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Counsellingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.IntroCBT);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.IntroCBT);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Counsellingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Counsellingtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.IntroCBTpod);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.IntroCBTpod);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Counsellingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Counsellingtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.videocounselling);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.videocounselling);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Counsellingtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Counsellingtag);
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
        public void ToolsEcoursesFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Tools);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ecourses);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.ecourses1);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.ecourses1);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.embracingworkplace);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.embracingworkplace);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.foundationsofeffective);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.foundationsofeffective);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.leadership1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.leadership1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.leadership2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.leadership2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.leadership3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.leadership3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.leadership4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.leadership4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.leadership5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.leadership5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.preparingforretirement);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.preparingforretirement);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.resilience);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.resilience);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.resolvingconflict);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.resolvingconflict);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.respectinworkplace);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.respectinworkplace);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.responsibleoptimism);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.responsibleoptimism);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.stopsmokingtools);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.stopsmokingtools);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.takingcontrolofanger);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.takingcontrolofanger);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.takingcontrolofjobloss);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.takingcontrolofjobloss);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.takingcontrolofstress);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.takingcontrolofstress);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.takingcontrolofcareer);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.takingcontrolofcareer);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.takingcontrolofmood);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.takingcontrolofmood);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.ecoursestag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.ecoursestag);
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
        public void ToolsiCBTFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Tools);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.iCBT);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Sentio);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Sentio);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.iCBTtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.iCBTtag);
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
        public void ToolsOrientationFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.Tools);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Orientation);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.employeeorientation);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.employeeorientation);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Orientationtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Orientationtag);
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
