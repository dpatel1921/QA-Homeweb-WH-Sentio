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
    public class HomewebRegressionStudentLifeFR
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
        public void StudentLifeFR(string HWLogin1, string HWPassword1, string Url)
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
            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.StudentLife);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Adaptingtochange);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Adaptingtochange);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Breakthose);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Breakthose);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Dealingwithread);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Dealingwithread);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Dealingwithvideo);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Dealingwithvideo);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.EatingHealthier);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.EatingHealthier);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.GetControl);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.GetControl);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.HowcanIcope);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.HowcanIcope);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Howtoavoid);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Howtoavoid);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Howtoimprove);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Howtoimprove);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Howtoincrease);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Howtoincrease);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Howtomaintain);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Howtomaintain);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Humourtherapy);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Humourtherapy);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Lifesmart);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Lifesmart);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.MaintainingGood);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.MaintainingGood);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Movingbeyond);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Movingbeyond);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Raisingself);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Raisingself);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Spottingsigns);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Spottingsigns);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Stopsmoking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Stopsmoking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Survivingsept);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Survivingsept);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Takingchargeofstress);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Takingchargeofstress);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Dansgersofsocial);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Dansgersofsocial);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Whenhabits);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Whenhabits);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Studentlifetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Studentlifetag);
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
        public void StudentLifeAddictionFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.StudentLife);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Addiction);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Stopsmokingaddiction);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Stopsmokingaddiction);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Addictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Addictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.UnderstandingEating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.UnderstandingEating);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Addictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Addictiontag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.UnderstandingEatingvideo);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.UnderstandingEatingvideo);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Addictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Addictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.UnderstandingEatingread);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.UnderstandingEatingread);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Addictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Addictiontag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Stopsmoking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Stopsmoking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Addictiontag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Addictiontag);
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
        public void StudentLifeFinancesFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.StudentLife);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Srudentlifefinance);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Getcontrolofmoney);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Getcontrolofmoney);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Financetag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Financetag);
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
        public void StudentLifeMentalhealthFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.StudentLife);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Mentalhealth);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.AmIExperiencing);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.AmIExperiencing);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Backtoschool);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Backtoschool);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Covid19);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Covid19);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Dealingwithseasonal);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Dealingwithseasonal);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Howtoavoidoverreacting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Howtoavoidoverreacting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Howtoincreaseyour);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Howtoincreaseyour);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentalhealthtag);

            Thread.Sleep(1000);
            ScrollToElement(RegObj.Maintaininggood);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Maintaininggood);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Raisingyourself);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Raisingyourself);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Spottingsignsof);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Spottingsignsof);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Thedangersof);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Thedangersof);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Understandingeating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Understandingeating);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalhealthtag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentalhealthtag);
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
