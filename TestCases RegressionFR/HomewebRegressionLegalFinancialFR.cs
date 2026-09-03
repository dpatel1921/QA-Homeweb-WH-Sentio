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
    public class HomewebRegressionLegalFinancialFR
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
        public void LegalFinancialFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.LegFin);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.LegFinFam);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.LegFinFam);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinmatters);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinmatters);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LegFinconsultation);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinconsultation);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinfitness);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinfitness);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinconsider);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinconsider);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinretirement);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinretirement);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinget);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinget);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinorder);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinorder);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinhow);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinhow);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinisit);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinisit);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinovercoming);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinovercoming);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinpre);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinpre);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinretirementpre);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinretirementpre);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinquestions);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinquestions);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFincontent);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFincontent);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinspending);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinspending);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintaking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFintaking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinallowance);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinallowance);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinreal);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinreal);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinworking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinworking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFintag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFintag);
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
        public void LegalFinancialManagementFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.LegFin);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.LegFinMan);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.LegFinMancons);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinMancons);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LegFinMantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFinMantag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LegFinManFitness);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinManFitness);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinMantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFinMantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinManStress);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinManStress);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinMantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFinMantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinManRetirement);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinManRetirement);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinMantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFinMantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinManGetting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinManGetting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinMantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFinMantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinManisit);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinManisit);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinMantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFinMantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinManspending);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinManspending);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinMantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFinMantag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinMantaking);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LegFinMantaking);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LegFinMantag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LegFinMantag);
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
        public void LegalFinancialLegalFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.LegFin);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.LFL);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.LFLFamily);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LFLFamily);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LFLTag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LFLTag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LFLintro);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LFLintro);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFLTag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LFLTag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFLQuestions);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LFLQuestions);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFLTag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LFLTag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFLLaw);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LFLLaw);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFLTag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LFLTag);
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
        public void LegalFinancialMentalHealthFR(string HWLogin1, string HWPassword1, string Url)
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
            ClickAndNavigate(RegObj.LegFin);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.LFMental);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.LFMentaPhysical);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LFMentaPhysical);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LFMentaltag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.LFMentalconsulatation);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LFMentalconsulatation);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFMentalfitness);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LFMentalfitness);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFMentalstress);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LFMentalstress);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFMentalgetcontrol);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LFMentalgetcontrol);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFMentalhow);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LFMentalhow);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFMentalovercoming);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LFMentalovercoming);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFMentalovercoming1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LFMentalovercoming1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFMentalretire);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LFMentalretire);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFMentalspending);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.LFMentalspending);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.LFMentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.LFMentaltag);
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
