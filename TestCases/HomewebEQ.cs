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
namespace Homeweb_3._0_Tests.TestCases
{
    [TestFixture]
    public class HomewebEQ
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
            driver.Manage().Cookies.DeleteAllCookies();
        }

        // Class to hold test case data from JSON file
        public class TestCaseJsonData
        {
            public string EQUsername { get; set; }
            public string EQPassword { get; set; }
            public string EQUsername1 { get; set; }
            public string EQPassword1 { get; set; }
            public string Url { get; set; }
            public string EQPolicy { get; set; }
            public string RegFirstName { get; set; }
            public string RegLastName { get; set; }
            public string RegPassword { get; set; }
            public string RegMonth { get; set; }
            public string RegDay { get; set; }
            public string RegYear { get; set; }
            public string RegGender { get; set; }
            public string RegPronoun { get; set; }
            public string RegTitle { get; set; }
            public string RegStart { get; set; }
            public string Search { get; set; }

        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void EQRegistration(string EQPolicy, string Url, string RegFirstName, string RegLastName, string RegPassword,
    string RegMonth, string RegDay, string RegYear, string RegGender, string RegPronoun, string RegTitle, string RegStart)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(Url);
        

            var homePage = new HomewebLoginObjects();
            var eqSignup = new HomewebEQObjects();
            PageFactory.InitElements(driver, homePage);
            PageFactory.InitElements(driver, eqSignup);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Start registration
            Assert.IsNotNull(homePage.Register, "Register button is not found.");
            wait.Until(d => homePage.Register.Displayed);
            homePage.Register.Click();

            Assert.IsNotNull(eqSignup.EQPolicyID, "EQ Policy ID field is not found.");
            wait.Until(d => eqSignup.EQPolicyID.Displayed);
            eqSignup.EQPolicyID.Click();
            eqSignup.EQPolicyID.SendKeys(EQPolicy);

            Assert.IsNotNull(eqSignup.SearchButton, "Search button is not found.");
            eqSignup.SearchButton.Click();

            Assert.IsNotNull(eqSignup.OrgSelect, "Organization selection is not found.");
            wait.Until(d => eqSignup.OrgSelect.Displayed);
            eqSignup.OrgSelect.Click();

            // Enter Personal Information
            Assert.IsNotNull(homePage.Firstname, "First name field is not found.");
            homePage.Firstname.SendKeys(RegFirstName);

            Assert.IsNotNull(homePage.LastName, "Last name field is not found.");
            homePage.LastName.SendKeys(RegLastName);

            Assert.IsNotNull(homePage.Email, "Email field is not found.");
            homePage.Email.Click();
            string uniqueEmail = GenerateUniqueEmail();
            homePage.Email.SendKeys(uniqueEmail);

            Assert.IsNotNull(homePage.Password, "Password field is not found.");
            homePage.Password.Click();
            homePage.Password.SendKeys(RegPassword);

            // Select Date of Birth
            var dobMonth = driver.FindElement(By.CssSelector("select#dobMonth"));
            Assert.IsNotNull(dobMonth, "Date of Birth - Month dropdown is not found.");
            new SelectElement(dobMonth).SelectByText(RegMonth);

            var dobDay = driver.FindElement(By.CssSelector("select#dobDay"));
            Assert.IsNotNull(dobDay, "Date of Birth - Day dropdown is not found.");
            new SelectElement(dobDay).SelectByText(RegDay);

            var dobYear = driver.FindElement(By.CssSelector("select#dobYear"));
            Assert.IsNotNull(dobYear, "Date of Birth - Year dropdown is not found.");
            new SelectElement(dobYear).SelectByText(RegYear);

            Thread.Sleep(2000);
            ScrollToElement(homePage.NextButton);

            // Select Gender & Pronoun
            var gender = driver.FindElement(By.CssSelector("select#gender"));
            Assert.IsNotNull(gender, "Gender dropdown is not found.");
            new SelectElement(gender).SelectByText(RegGender);

            var pronoun = driver.FindElement(By.CssSelector("select#pronoun"));
            Assert.IsNotNull(pronoun, "Pronoun dropdown is not found.");
            new SelectElement(pronoun).SelectByText(RegPronoun);

            // Accept Policies
            Assert.IsNotNull(homePage.CheckPolicy, "Check Policy checkbox is not found.");
            wait.Until(d => homePage.CheckPolicy.Displayed);
            homePage.CheckPolicy.Click();

            Assert.IsNotNull(homePage.Marketing, "Marketing checkbox is not found.");
            homePage.Marketing.Click();

            Assert.IsNotNull(homePage.NextButton, "Next button is not found.");
            wait.Until(d => homePage.NextButton.Displayed);
            homePage.NextButton.Click();

            // Job Information
            Assert.IsNotNull(homePage.Employee, "Employee selection is not found.");
            wait.Until(d => homePage.Employee.Displayed);
            homePage.Employee.Click();

            Assert.IsNotNull(homePage.NextButton1, "Next button (Job Info) is not found.");
            homePage.NextButton1.Click();

            Assert.IsNotNull(eqSignup.SelectPartOrg, "Select Participating Organization option is not found.");
            wait.Until(d => eqSignup.SelectPartOrg.Displayed);
            eqSignup.SelectPartOrg.Click();

            Assert.IsNotNull(homePage.JobTitle, "Job Title field is not found.");
            homePage.JobTitle.SendKeys(RegTitle);

            var startYear = driver.FindElement(By.CssSelector("select#startYear"));
            Assert.IsNotNull(startYear, "Start Year dropdown is not found.");
            new SelectElement(startYear).SelectByText(RegStart);

            Assert.IsNotNull(homePage.RegComplete, "Complete Registration button is not found.");
            wait.Until(d => homePage.RegComplete.Displayed);
            homePage.RegComplete.Click();
          

            // Quit the driver
            driver.Quit();
        }

        [Test, TestCaseSource(nameof(LoginJsonData1))]
        public void EQLandingPage(string Url)
        {
            try
            {  // Navigate to the provided URL
                driver.Navigate().GoToUrl(Url);


             
                driver.Manage().Cookies.DeleteAllCookies();

                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                // Sign-up interactions
                Assert.IsNotNull(homePage.Signup, "Signup button is not found.");
                Thread.Sleep(2000);
                homePage.Signup.Click();
                driver.Navigate().Back();

                Assert.IsNotNull(homePage.Signup1, "Signup1 button is not found.");
                Thread.Sleep(2000);
                homePage.Signup1.Click();
                driver.Navigate().Back();

                ScrollToElement(homePage.Homewood);
                Thread.Sleep(2000);
                homePage.Homewood.Click();
                SwitchToNewTab();
                Thread.Sleep(1000);
                driver.Close();
                driver.SwitchTo().Window(driver.WindowHandles[0]);

                Thread.Sleep(2000);
                homePage.Termsofservice.Click();
                driver.Navigate().Back();
            
                Thread.Sleep(2000);
                homePage.Privacypolicy.Click();
                driver.Navigate().Back();
                            
                Thread.Sleep(2000);
                homePage.Accessibility.Click();
                driver.Navigate().Back();
                Thread.Sleep(1000);
                // Click on Articles
                ClickAndNavigateBack(homePage.Article1);
                ClickAndNavigateBack(homePage.Article2);
                ClickAndNavigateBack(homePage.Article3);

                // Change Language and click French Sign-up options
                Thread.Sleep(2000);
                ScrollToElement(homePage.LanChange);
                Thread.Sleep(1000);
                homePage.LanChange.Click();        
                wait.Until(d => homePage.SignupFR.Displayed);
                homePage.SignupFR.Click();
                driver.Navigate().Back();
                Thread.Sleep(1000);         
                wait.Until(d => homePage.Signup1FR.Displayed);
                Thread.Sleep(1000);
                homePage.Signup1FR.Click();
                driver.Navigate().Back();

                // Click on French Homewood
                Thread.Sleep(1000);      
                ScrollToElement(homePage.HomewoodFR);
                Thread.Sleep(1000);
                homePage.HomewoodFR.Click();
                SwitchToNewTab();
                Thread.Sleep(1000);
                driver.Close();
                driver.SwitchTo().Window(driver.WindowHandles[0]);        
                Thread.Sleep(2000);
                homePage.TermsofserviceFR.Click();
                driver.Navigate().Back();         
                Thread.Sleep(2000);
                homePage.PrivacypolicyFR.Click();
                driver.Navigate().Back();            
                Thread.Sleep(2000);
                homePage.AccessibilityFR.Click();
                driver.Navigate().Back();

                // Click on additional articles
                ClickAndNavigateBack(homePage.Article4);
                ClickAndNavigateBack(homePage.Article5);
                ClickAndNavigateBack(homePage.Article6);

                // Quit the driver
                driver.Quit();
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);

            }
        }

        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void EQDashboard(string EQUsername, string EQPassword, string url, string Search)
        {
            try
            {
                driver.Navigate().GoToUrl(url);
                var homePage = new HomewebLoginObjects();
                var eqSignup = new HomewebEQObjects();
                PageFactory.InitElements(driver, homePage);
                PageFactory.InitElements(driver, eqSignup);
                var alumniSignup = new HomewebAlumniObjects();
                PageFactory.InitElements(driver, alumniSignup);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                // Login process
                Assert.IsNotNull(homePage.Login, "Login button is not found.");
                wait.Until(d => homePage.Login.Displayed);
                Thread.Sleep(1000);
                homePage.Login.Click();
                Assert.IsNotNull(homePage.UserName, "Username field is not found.");
                homePage.UserName.SendKeys(EQUsername);
                Thread.Sleep(1000);
                homePage.Next.Click();
                Assert.IsNotNull(homePage.Next, "Next button is not found.");
                homePage.Password.SendKeys(EQPassword);

                Assert.IsNotNull(homePage.Submit, "Submit button is not found.");
                Thread.Sleep(1000);
                homePage.Submit.Submit();

                // Dashboard interactions
                Thread.Sleep(2000);

                homePage.Checkin.Click();
                Assert.IsNotNull(homePage.Gettingby, "Getting By button is not found.");
                homePage.Gettingby.Click();

                // Watch tutorial and handle new tab
                Assert.IsNotNull(homePage.Watchtutorial, "Watch Tutorial button is not found.");
                homePage.Watchtutorial.Click();
                SwitchToNewTab();
                driver.Close();
                driver.SwitchTo().Window(driver.WindowHandles.First());
                Assert.IsNotNull(homePage.Continue, "Continue button is not found.");
                homePage.Continue.Click();

                Thread.Sleep(1000);
                Assert.IsNotNull(homePage.Moodselect, "Mood selection is not found.");

                homePage.Moodselect.Click();
                Assert.IsNotNull(homePage.Moodselectcontinue, "Mood selection continue button is not found.");

                homePage.Moodselectcontinue.Click();

                Thread.Sleep(1000);
                Assert.IsNotNull(homePage.BacktoDashboard, "Back to Dashboard button is not found.");

                homePage.BacktoDashboard.Click();

                // Browse different dashboard sections
                ClickAndNavigateBack(homePage.Launchpathfinder);
                ClickAndNavigateBack(homePage.Browse);
                Thread.Sleep(1000);
                ScrollToElement(homePage.Recommends);
                Thread.Sleep(1000);
                ClickAndNavigateBack(homePage.Recommends);
                Thread.Sleep(1000);

                // Language Change
                Thread.Sleep(1000);

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

                wait.Until(d => homePage.Profile.Displayed);
                homePage.Profile.Click();

                homePage.Logout.Click();

                // Quit the driver
                driver.Quit();
            }
            catch
            {

            }
        }

        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void EQExternallinks(string EQUsername, string EQPassword, string url, string Search)
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

                wait.Until(d => homePage.Login.Displayed);
                homePage.Login.Click();
                Assert.IsNotNull(homePage.UserName, "Username field is not found.");

                homePage.UserName.SendKeys(EQUsername);
                Assert.IsNotNull(homePage.Next, "Next button is not found.");

                homePage.Next.Click();
                Assert.IsNotNull(homePage.Password, "Password field is not found.");

                homePage.Password.SendKeys(EQPassword);
                Assert.IsNotNull(homePage.Submit, "Submit button is not found.");

                homePage.Submit.Submit();

                // Browse and navigate to Tools
                ClickAndNavigate(homePage.Browse);
                ClickAndNavigate(homePage.Tools);

                // Childcare Locator
                Thread.Sleep(1000);
                ScrollToElement(homePage.Childcarelocator);
                Thread.Sleep(1000);

                ClickAndNavigate(homePage.Childcarelocator);
                Thread.Sleep(1000);

                ScrollToElement(homePage.Childcarelocatorstart);
                Thread.Sleep(1000);
                ClickAndNavigate(homePage.Childcarelocatorstart);
           
                try
                {
                    ClickAndNavigate(homePage.Childcarelocatorstart);
                    Assert.IsNotNull(homePage.Childcarelocatoraccept, "Childcare Locator Accept button is not found.");

                    homePage.Childcarelocatoraccept.Click();
                    Thread.Sleep(1000);
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {

                    Console.WriteLine("An error occurred: " + ex.Message);

                }
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
            

                ClickAndNavigate(homePage.Backtotools);

                // Health Risk Assessment
                try
                {
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

                  
                    Thread.Sleep(2000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
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
             
                Thread.Sleep(1000);
                try
                {
                    Assert.IsNotNull(homePage.Childcarelocatoraccept, "Childcare Locator Accept button is not found.");

                    homePage.Childcarelocatoraccept.Click();
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {

                    Console.WriteLine("An error occurred: " + ex.Message);

                }
                driver.Navigate().Back();
                Thread.Sleep(1000);
                ScrollToElement(homePage.Backtotools);
                Thread.Sleep(1000);
                ClickAndNavigate(homePage.Backtotools);

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
        private void ClickAndSwitchActiveElement(IWebElement element)
        {
            ClickAndNavigate(element);
            driver.SwitchTo().ActiveElement();
        }
        private void ClickAndNavigate(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => element.Displayed);
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
        private void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        private static string GenerateUniqueEmail()
        {
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            return $"testuser_{timestamp}@demo.com";
        }
        public static IEnumerable<TestCaseData> LoginJsonData()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\source\\repos\\QA-Homeweb-Automation-3.0\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.EQPolicy)
                                                        && !string.IsNullOrEmpty(data.EQPolicy)
                                                         && data.Url == "https://homeweb.ca/equitable");

            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.EQPolicy, loginData.Url, loginData.RegFirstName,
                    loginData.RegLastName, loginData.RegPassword, loginData.RegMonth, loginData.RegDay,
                    loginData.RegYear, loginData.RegGender, loginData.RegPronoun, loginData.RegTitle, loginData.RegStart);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData1()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\source\\repos\\QA-Homeweb-Automation-3.0\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.EQPolicy)
                                                        && !string.IsNullOrEmpty(data.EQPolicy)
                                                         && data.Url == "https://homeweb.ca/equitable");

            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Url);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData2()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\source\\repos\\QA-Homeweb-Automation-3.0\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.EQUsername)
                                                        && !string.IsNullOrEmpty(data.EQPassword)
                                                         && data.Url == "https://homeweb.ca/equitable");

            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.EQUsername, loginData.EQPassword,loginData.Url, loginData.Search);
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
                test.Log(Status.Fail, "Test failed with logtrace: " + stackTrace);
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
