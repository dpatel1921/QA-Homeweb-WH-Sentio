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
using System.Linq.Expressions;

namespace Homeweb_3._0_Tests.TestCases
{
    [TestFixture]

    public class HomewebSmokeFR
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

        public class TestCaseJsonData
        {
            public string HWLogin { get; set; }
            public string HWPassword { get; set; }
            public string Url { get; set; }
            public string Search { get; set; }

        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void LandingPageFR(string HWLogin, string HWPassword, string Url, string Search)
        {
            try
            {
                driver.Navigate().GoToUrl(Url);
                driver.Manage().Cookies.DeleteAllCookies();
                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;        
                Assert.IsNotNull(homePage.Signup, "Signup button is not found.");
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Signup);
                Assert.IsNotNull(homePage.Signup1, "Signup1 button is not found.");
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Signup1);           
                Thread.Sleep(2000);
                Assert.IsNotNull(homePage.Homewood, "Homewood link is not found.");
                ScrollToElement(homePage.Homewood);
                Thread.Sleep(2000);
                ClickAndSwitchNewTab(homePage.Homewood);              
                Assert.IsNotNull(homePage.Termsofservice, "Terms of Service link is not found.");
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Termsofservice);
                Assert.IsNotNull(homePage.Privacypolicy, "Privacy Policy link is not found.");
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Privacypolicy);
                Assert.IsNotNull(homePage.Accessibility, "Accessibility link is not found.");
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Accessibility);
                Thread.Sleep(2000);
                ScrollToElement(homePage.Article1);
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Article1);
                ClickAndNavigateBack(homePage.Article2);
                ClickAndNavigateBack(homePage.Articleextra);             
                Thread.Sleep(2000);
                Assert.IsNotNull(homePage.LanChange, "Language Change button is not found.");
                ScrollToElement(homePage.LanChange);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.LanChange);
                Assert.IsNotNull(homePage.SignupFR, "French Signup button is not found.");
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.SignupFR);
                Assert.IsNotNull(homePage.Signup1FR, "French Signup1 button is not found.");
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Signup1FR);
                Thread.Sleep(2000);
                ScrollToElement(homePage.Article4);
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Article4);
                ClickAndNavigateBack(homePage.Article5);
                ClickAndNavigateBack(homePage.Article6);             
                Assert.IsNotNull(homePage.HomewoodFR, "French Homewood link is not found.");
                ScrollToElement(homePage.HomewoodFR);
                Thread.Sleep(2000);
                ClickAndSwitchNewTab(homePage.HomewoodFR);           
                Assert.IsNotNull(homePage.TermsofserviceFR, "French Terms of Service link is not found.");
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.TermsofserviceFR);
                Assert.IsNotNull(homePage.PrivacypolicyFR, "French Privacy Policy link is not found.");
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.PrivacypolicyFR);
                Assert.IsNotNull(homePage.AccessibilityFR, "French Accessibility link is not found.");
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.AccessibilityFR);
                driver.Quit();
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);

            }

        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void HomewebDashboardFR(string login, string password, string url, string Search)
        {
           
            driver.Navigate().GoToUrl(url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            wait.Until(d => homePage.LanChange.Displayed);
            homePage.LanChange.Click();             
            wait.Until(d => homePage.LoginFR.Displayed);
            homePage.LoginFR.Click();       
            homePage.UserName.SendKeys(login);      
            homePage.Next.Click();         
            homePage.Password.SendKeys(password);
            homePage.Submit.Submit();      
            Thread.Sleep(2000);
            ClickAndNavigate(homePage.CheckinFR);
            ClickAndNavigate(homePage.Gettingby);       
            Thread.Sleep(1000);    
            homePage.WatchtutorialFR.Click();
            SwitchToNewTab();
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.ContinueFR);
            Thread.Sleep(2000);                    
            homePage.Moodselect.Click();
            homePage.ContinueFR.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.BacktoDashboardFR);
            Thread.Sleep(1000);
            ClickAndNavigateBack(homePage.LaunchpathfinderFR);
            ClickAndNavigateBack(homePage.BrowseFR);
            Thread.Sleep(1000);
            ScrollToElement(homePage.RecommendsFR);
            Thread.Sleep(1000);
            ClickAndNavigateBack(homePage.RecommendsFR);
            Thread.Sleep(1000);
            ScrollToElement(homePage.SelfdirectedFR);
            Thread.Sleep(1000);
            ClickAndNavigateBack(homePage.SelfdirectedFR);
            Thread.Sleep(1000);
            ScrollToElement(homePage.AdditionalresourcesFR);
            Thread.Sleep(1000);
            ClickAndNavigateBack(homePage.AdditionalresourcesFR);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ArticleFR);
            Thread.Sleep(1000);
            ClickAndNavigateBack(homePage.ArticleFR);
            Thread.Sleep(1000);
            ScrollToElement(homePage.Monthreading);
            Thread.Sleep(1000);
            ClickAndNavigateBack(homePage.Monthreading);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ResourcesFR);
            Thread.Sleep(1000);
            ClickAndNavigateBack(homePage.ResourcesFR);       
            ClickAndNavigateBack(homePage.WellnessFR);       
            Thread.Sleep(2000);        
                    
            ClickAndNavigateBack(homePage.SearchFR);
            wait.Until(d => homePage.ProfileFR.Displayed);
            homePage.ProfileFR.Click();          
            homePage.LogoutFR.Click();
            driver.Quit();


        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void HomewebExternallinksFR(string login, string password, string url, string Search)
        {
            try
            {
                driver.Navigate().GoToUrl(url);
                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                wait.Until(d => homePage.LanChange.Displayed);
                homePage.LanChange.Click();
                wait.Until(d => homePage.LoginFR.Displayed);
                homePage.LoginFR.Click();               
                homePage.UserName.SendKeys(login);         
                homePage.Next.Click();           
                homePage.Password.SendKeys(password);           
                homePage.Submit.Submit();        
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.BrowseFR);
                ClickAndNavigate(homePage.ToolsFR);         
                Thread.Sleep(2000);
                ScrollToElement(homePage.ChildcarelocatorFR);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.ChildcarelocatorFR);
                Thread.Sleep(1000);
                ScrollToElement(homePage.ChildcarelocatorstartFR);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.ChildcarelocatorstartFR);         
                Thread.Sleep(1000);
                driver.Navigate().Back();
             
                ClickAndNavigate(homePage.ToolsFR);         
                Thread.Sleep(1000);
                ScrollToElement(homePage.HealthandWellnessFR);
                Thread.Sleep(1000);
                ClickAndNavigate(homePage.HealthandWellnessFR);
                Thread.Sleep(1000);
                ScrollToElement(homePage.HealthandWellnesslibraryFR);
                Thread.Sleep(1000);
                ClickAndSwitchNewTab(homePage.HealthandWellnesslibraryFR);        
                ClickAndNavigate(homePage.Backtotools);           
                 ((IJavaScriptExecutor)driver).ExecuteScript("window.open(arguments[0].href, '_blank');", homePage.Healthriskassessmentaccept);
                driver.SwitchTo().Window(driver.WindowHandles[0]);         
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.ToolsFR);    
                Thread.Sleep(1000);
                ScrollToElement(homePage.SentioFR);
                Thread.Sleep(1000);
                ClickAndNavigate(homePage.SentioFR);
                Thread.Sleep(1000);
                ScrollToElement(homePage.SentioStartFR);
                Thread.Sleep(1000);
                ClickAndNavigate(homePage.SentioStartFR);
                Thread.Sleep(1000);
                driver.Navigate().Back();
                Thread.Sleep(2000);
                ScrollToElement(homePage.ToolsFR);
                Thread.Sleep(1000);
                ClickAndNavigate(homePage.ToolsFR);    
                ClickAndNavigate(homePage.ProfileFR);
                Assert.IsNotNull(homePage.LogoutFR, "Logout button is not found.");
                homePage.LogoutFR.Click();
            }


            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);

            }
          
            driver.Quit();


        }
       
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void HomewebSearchFR(string HWLogin, string HWPassword, string url, string Search)
        {
        
            driver.Navigate().GoToUrl(url);
            var homePage = new HomewebLoginObjects();
            var alumniSignup = new HomewebAlumniObjects();
            PageFactory.InitElements(driver, homePage);
            PageFactory.InitElements(driver, alumniSignup);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            wait.Until(d => homePage.LanChange.Displayed);
            homePage.LanChange.Click();         
            wait.Until(d => homePage.LoginFR.Displayed);
            homePage.LoginFR.Click();
            homePage.UserName.SendKeys(HWLogin);
            homePage.Next.Click();
            homePage.Password.SendKeys(HWPassword);
            homePage.Submit.Submit();
            wait.Until(d => homePage.SearchFR.Displayed);
            homePage.SearchFR.Click();
            wait.Until(d => alumniSignup.Searchbox.Displayed);
            alumniSignup.Searchbox.SendKeys(Search);
            wait.Until(d => alumniSignup.ClickSearch.Displayed);
            alumniSignup.ClickSearch.Click();
            Thread.Sleep(1000);
            wait.Until(d => homePage.ProfileFR.Displayed);
            homePage.ProfileFR.Click();
            homePage.LogoutFR.Click();
        
            driver.Quit();
        }
        private void TakeScreenshot(string filePath)
        {
            ITakesScreenshot ssd = driver as ITakesScreenshot;
            Screenshot ss = ssd.GetScreenshot();
            ss.SaveAsFile(filePath + time.ToString("yy_dd_h_mm_ss") + ".png");
        }
        private void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        private void ClickAndSwitchActiveElement(IWebElement element)
        {
            ClickAndNavigate(element);
            driver.SwitchTo().ActiveElement();
        }
        private void ClickAndNavigate(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Thread.Sleep(2000);
            element.Click();
        }
        private void ClickAndSwitchNewTab(IWebElement element)
        {
            ClickAndNavigate(element);
            SwitchToNewTab();
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }
        private void SwitchToNewTab()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(d => driver.WindowHandles.Count > 1);
            var newTab = driver.WindowHandles.Last();
            driver.SwitchTo().Window(newTab);
        }

        private void ClickAndNavigateBack(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Thread.Sleep(2000);
            element.Click();
            driver.Navigate().Back();
        }
        public static IEnumerable<TestCaseData> LoginJsonData()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.HWLogin)
                                                        && !string.IsNullOrEmpty(data.HWPassword)
                                                        && data.Url == "https://homeweb.ca");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.HWLogin, loginData.HWPassword, loginData.Url, loginData.Search);
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

