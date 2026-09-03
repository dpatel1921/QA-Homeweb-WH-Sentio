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
   
    public class HomewebSmoke
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
          //  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
        }

        public class TestCaseJsonData
        {
            public string HWLogin { get; set; }
            public string HWPassword { get; set; }
            public string Url { get; set; }
            public string Search { get; set; }

        }
        [Test,TestCaseSource(nameof(LoginJsonData))]
        public void LandingPage(string HWLogin, string HWPassword, string Url, string Search)
        {
            try
            {
                driver.Navigate().GoToUrl(Url);
                driver.Manage().Cookies.DeleteAllCookies();

                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                // Sign-up interactions
                Assert.IsNotNull(homePage.Signup, "Signup button is not found.");
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Signup);
                Assert.IsNotNull(homePage.Signup1, "Signup1 button is not found.");
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Signup1);

                // Click on Homewood in footer
                Thread.Sleep(2000);          

                ScrollToElement(homePage.Homewood);
                Thread.Sleep(2000);
                ClickAndSwitchNewTab(homePage.Homewood);                             
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Termsofservice);
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Privacypolicy);
            
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Accessibility);

                // Click on Articles
                Thread.Sleep(2000);
                ScrollToElement(homePage.Article1);
                Thread.Sleep(2000);

                ClickAndNavigateBack(homePage.Article1);
                ClickAndNavigateBack(homePage.Article2);
                ClickAndNavigateBack(homePage.Articleextra);

                // Change Language and click French Sign-up options
                Thread.Sleep(2000);        

                ScrollToElement(homePage.LanChange);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.LanChange);
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.SignupFR);          
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Signup1FR);

                // Click on additional articles
                Thread.Sleep(2000);
                ScrollToElement(homePage.Article4);
                Thread.Sleep(2000);

                ClickAndNavigateBack(homePage.Article4);
                ClickAndNavigateBack(homePage.Article5);
                ClickAndNavigateBack(homePage.Article6);       

                ScrollToElement(homePage.HomewoodFR);
                Thread.Sleep(2000);
                ClickAndSwitchNewTab(homePage.HomewoodFR);
                        
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.TermsofserviceFR);              
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.PrivacypolicyFR);                            
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.AccessibilityFR);


                // Quit the driver
                driver.Quit();
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);

            }

        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void HomewebDashboard(string login, string password, string url, string Search)
        {
            try
            { // Navigate to the provided URL
                driver.Navigate().GoToUrl(url);
                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);
                var alumniSignup = new HomewebAlumniObjects();
                PageFactory.InitElements(driver, alumniSignup);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                // Login process
                Assert.IsNotNull(homePage.Login, "Login button is not found.");
                Thread.Sleep(1000);
                homePage.Login.Click();

                Assert.IsNotNull(homePage.UserName, "Username field is not found.");
                homePage.UserName.SendKeys(login);

                Assert.IsNotNull(homePage.Next, "Next button is not found.");
                homePage.Next.Click();

                Assert.IsNotNull(homePage.Password, "Password field is not found.");
                Thread.Sleep(1000);
                homePage.Password.SendKeys(password);

                Assert.IsNotNull(homePage.Submit, "Submit button is not found.");
                homePage.Submit.Submit();

                // Dashboard interactions
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.Checkin);
                ClickAndNavigate(homePage.Gettingby);

                // Watch tutorial and handle new tab
                Thread.Sleep(1000);              
                homePage.Watchtutorial.Click();
                SwitchToNewTab();
                driver.Close();
                driver.SwitchTo().Window(driver.WindowHandles.First());

                Thread.Sleep(1000);
                ClickAndNavigate(homePage.Continue);
                Thread.Sleep(2000);                  
                homePage.Moodselect.Click();
                Assert.IsNotNull(homePage.Moodselectcontinue, "Mood selection continue button is not found.");
                homePage.Moodselectcontinue.Click();

                Thread.Sleep(1000);
                ClickAndNavigate(homePage.BacktoDashboard);
                Thread.Sleep(1000);
                ClickAndNavigateBack(homePage.Launchpathfinder);          
                ClickAndNavigateBack(homePage.Browse);            
                // Scroll and interact with features
                Thread.Sleep(1000);
                ScrollToElement(homePage.Recommends);
                Thread.Sleep(1000);
                ClickAndNavigateBack(homePage.Recommends);
                Thread.Sleep(1000);
                            
                ScrollToElement(homePage.Monthreading);
                Thread.Sleep(1000);

                ClickAndNavigateBack(homePage.Monthreading);
                Thread.Sleep(1000);

                ScrollToElement(homePage.Resources);
                Thread.Sleep(1000);

                ClickAndNavigateBack(homePage.Resources);

                // Language Change
                Thread.Sleep(2000);             
                ScrollToElement(homePage.LanChange);
                Thread.Sleep(1000);
                wait.Until(d => homePage.LanChange.Displayed);
                homePage.LanChange.Click();
                wait.Until(d => homePage.LanchangeEN.Displayed);
                homePage.LanchangeEN.Click();            
                wait.Until(d => homePage.Search.Displayed);
                homePage.Search.Click();                           
                wait.Until(d => alumniSignup.Searchbox.Displayed);
                alumniSignup.Searchbox.SendKeys(Search);
                wait.Until(d => alumniSignup.ClickSearch.Displayed);
                alumniSignup.ClickSearch.Click();

                // Scroll and click on search result
                Thread.Sleep(1000);
                ScrollToElement(alumniSignup.ArticleSearch);
                Thread.Sleep(1000);
                wait.Until(d => alumniSignup.ArticleSearch.Displayed);
                alumniSignup.ArticleSearch.Click();

                // Profile and Logout            
                wait.Until(d => homePage.Profile.Displayed);
                homePage.Profile.Click();       
                homePage.Logout.Click();

                // Quit the driver
                driver.Quit();
            }
            catch { 
            
            
            }

        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void HomewebExternallinks(string login, string password, string url, string Search)
        {
            try
            {
                driver.Navigate().GoToUrl(url);
                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                // Login process
                Assert.IsNotNull(homePage.Login, "Login button is not found.");
                Thread.Sleep(1000);
                homePage.Login.Click();

                Assert.IsNotNull(homePage.UserName, "Username field is not found.");
                homePage.UserName.SendKeys(login);

                Assert.IsNotNull(homePage.Next, "Next button is not found.");
                homePage.Next.Click();

                Assert.IsNotNull(homePage.Password, "Password field is not found.");
                homePage.Password.SendKeys(password);

                Assert.IsNotNull(homePage.Submit, "Submit button is not found.");
                homePage.Submit.Submit();

                // Browse and navigate to Tools
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.Browse);
                ClickAndNavigate(homePage.Tools);

                // Childcare Locator
                Thread.Sleep(2000);
                ScrollToElement(homePage.Childcarelocator);
                Thread.Sleep(2000);

                ClickAndNavigate(homePage.Childcarelocator);
                Thread.Sleep(1000);

                ScrollToElement(homePage.Childcarelocatorstart);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.Childcarelocatorstart);
                TakeScreenshot("C:/TestData/Homeweb/ChildcareLocator_");


                Assert.IsNotNull(homePage.Childcarelocatoraccept, "Childcare Locator Accept button is not found.");

                homePage.Childcarelocatoraccept.Click();
                Thread.Sleep(1000);
                driver.Navigate().Back();


                driver.Navigate().Back();
                ClickAndNavigate(homePage.Backtotools);

                // Health and Wellness
                Thread.Sleep(1000);
                ScrollToElement(homePage.HealthandWellness);
                Thread.Sleep(1000);
                ClickAndNavigate(homePage.HealthandWellness);
                Thread.Sleep(1000);
                ScrollToElement(homePage.HealthandWellnesslibrary);
                Thread.Sleep(1000);
                ClickAndSwitchNewTab(homePage.HealthandWellnesslibrary);
                TakeScreenshot("C:/TestData/Homeweb/Healthandwellness_");

                ClickAndNavigate(homePage.Backtotools);

                // Health Risk Assessment
                Thread.Sleep(1000);
                Assert.IsNotNull(homePage.Healthriskassessment, "Health Risk Assessment button is not found.");
                ScrollToElement(homePage.Healthriskassessment);
                Thread.Sleep(1000);
                ClickAndNavigate(homePage.Healthriskassessment);
                Thread.Sleep(1000);

                Assert.IsNotNull(homePage.Healthriskassessmentaccept, "Health Risk Assessment Accept button is not found.");
                ScrollToElement(homePage.Healthriskassessmentaccept);
                Thread.Sleep(1000);

                ((IJavaScriptExecutor)driver).ExecuteScript("window.open(arguments[0].href, '_blank');", homePage.Healthriskassessmentaccept);
                driver.SwitchTo().Window(driver.WindowHandles[0]);

                TakeScreenshot("C:/TestData/PBC/Healthrisk_");
                Thread.Sleep(2000);

            



            Assert.IsNotNull(homePage.Backtotools, "Back to Tools button is not found.");

            ClickAndNavigate(homePage.Backtotools);

            // Sentio
            Thread.Sleep(1000);
            ScrollToElement(homePage.Sentio);
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.Sentio);
            Thread.Sleep(1000);
            ScrollToElement(homePage.SentioStart);
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.SentioStart);
            TakeScreenshot("C:/TestData/Homeweb/Sentio_");
            Thread.Sleep(1000);

            Assert.IsNotNull(homePage.Childcarelocatoraccept, "Childcare Locator Accept button is not found.");

            homePage.Childcarelocatoraccept.Click();
            Thread.Sleep(1000);


            driver.Navigate().Back();
            Thread.Sleep(2000);
            ScrollToElement(homePage.Backtotools);
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.Backtotools);

            // Profile and Logout
            ClickAndNavigate(homePage.Profile);
            Assert.IsNotNull(homePage.Logout, "Logout button is not found.");
            homePage.Logout.Click();
            }  
           
          
             catch (Exception ex)
                {

                Console.WriteLine("An error occurred: " + ex.Message);

            }
            // Quit the driver
            driver.Quit();

        
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void HomewebResources(string login, string password, string url, string Search)
        {
            try
            {
                // Navigate to the provided URL
                driver.Navigate().GoToUrl(url);
                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                // Login process
                Assert.IsNotNull(homePage.Login, "Login button is not found.");
                Thread.Sleep(1000);
                homePage.Login.Click();

                Assert.IsNotNull(homePage.UserName, "Username field is not found.");
                homePage.UserName.SendKeys(login);

                Assert.IsNotNull(homePage.Next, "Next button is not found.");
                homePage.Next.Click();

                Assert.IsNotNull(homePage.Password, "Password field is not found.");
                homePage.Password.SendKeys(password);

                Assert.IsNotNull(homePage.Submit, "Submit button is not found.");
                homePage.Submit.Submit();

                // Browse webinars
                ClickAndNavigate(homePage.Browse);
                ClickAndNavigate(homePage.Webinars);

                // Access Covid-19 Webinar and YouTube video
                Thread.Sleep(2000);
                ScrollToElement(homePage.Covid19);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.Covid19);
                driver.SwitchTo().Frame(0);
                Thread.Sleep(2000);
                ScrollToElement(homePage.Youtube);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.Youtube);
                driver.SwitchTo().DefaultContent();

                // Return to resources
                Thread.Sleep(2000);
                ScrollToElement(homePage.BacktoResources);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.BacktoResources);

                // Access Wellness sessions
                ClickAndNavigate(homePage.Wellnesssessions);
                Thread.Sleep(2000);
                ScrollToElement(homePage.Beyondstigma);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.Beyondstigma);
                Thread.Sleep(2000);
                ScrollToElement(homePage.BacktoResources);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.BacktoResources);

                // Build Resilience & Adapting to Change
                ClickAndNavigate(homePage.Buildyourresi);
                Thread.Sleep(2000);
                ScrollToElement(homePage.Adpatingtochange);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.Adpatingtochange);
                Thread.Sleep(2000);
                ScrollToElement(homePage.BacktoResources);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.BacktoResources);

                // Mental Health Podcast
                ClickAndNavigate(homePage.MentalHealth);
                Thread.Sleep(2000);
                ScrollToElement(homePage.Childmentalpodcast);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.Childmentalpodcast);
                Thread.Sleep(2000);
                ScrollToElement(homePage.Podcastplay);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.Podcastplay);
                Thread.Sleep(2000);
                ScrollToElement(homePage.BacktoResources);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.BacktoResources);

                // Profile and Logout
                ClickAndNavigate(homePage.Profile);
                Assert.IsNotNull(homePage.Logout, "Logout button is not found.");

                homePage.Logout.Click();

                // Quit the driver
                driver.Quit();
            }
             
         catch (Exception ex)
                {

                    Console.WriteLine("An error occurred: " + ex.Message);

                }
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
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\source\\repos\\QA-Homeweb-Automation-3.0\\TestData\\HomewebLoginData.json");
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

