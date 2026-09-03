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
using System.Security.Policy;

namespace Homeweb_3._0_Tests.TestCases
{
    [TestFixture]
    public class HomewebPBC
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
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
        }

        // Class to hold test case data from JSON file
        public class TestCaseJsonData
        {
            public string Login { get; set; }
            public string Password { get; set; }
            public string Url { get; set; }
            public string ForgotUsername { get; set; }
            public string Regname { get; set; }
            public string Regcode { get; set; }
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
            public string PBCUsername { get; set; }
            public string PBCPassword { get; set; }
            public string Search { get; set; }


        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void PBCRegistration(string regName,string url, string regFirstName,
            string regLastName, string regPassword, string regMonth, string regDay,
            string regYear, string regGender, string regPronoun, string regTitle, string regStart)
        {
            // Navigate to the registration URL
            driver.Navigate().GoToUrl(url);
           

            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Click on Register
            Assert.IsNotNull(homePage.Register, "Register button is not found.");
            wait.Until(d => homePage.Register.Displayed);
            homePage.Register.Click();

            // Fill registration form
            Assert.IsNotNull(homePage.Orgsearch, "Organization search field is not found.");
            wait.Until(d => homePage.Orgsearch.Displayed);
            homePage.Orgsearch.SendKeys(regName);

            Assert.IsNotNull(homePage.Searchbutton, "Search button is not found.");
            homePage.Searchbutton.Click();

            Assert.IsNotNull(homePage.Selectitem, "Select item option is not found.");
            wait.Until(d => homePage.Selectitem.Displayed);
            homePage.Selectitem.Click();

            Assert.IsNotNull(homePage.Firstname, "First name field is not found.");
            homePage.Firstname.SendKeys(regFirstName);

            Assert.IsNotNull(homePage.LastName, "Last name field is not found.");
            homePage.LastName.SendKeys(regLastName);

            Assert.IsNotNull(homePage.Email, "Email field is not found.");
            homePage.Email.Click();
            string uniqueEmail = GenerateUniqueEmail();
            homePage.Email.SendKeys(uniqueEmail);

            Assert.IsNotNull(homePage.Password1, "Password field is not found.");
            homePage.Password1.SendKeys(regPassword);

            // Select Date of Birth
            var dobMonth = driver.FindElement(By.CssSelector("select#dobMonth"));
            Assert.IsNotNull(dobMonth, "Date of Birth - Month dropdown is not found.");
            new SelectElement(dobMonth).SelectByText(regMonth);

            var dobDay = driver.FindElement(By.CssSelector("select#dobDay"));
            Assert.IsNotNull(dobDay, "Date of Birth - Day dropdown is not found.");
            new SelectElement(dobDay).SelectByText(regDay);

            var dobYear = driver.FindElement(By.CssSelector("select#dobYear"));
            Assert.IsNotNull(dobYear, "Date of Birth - Year dropdown is not found.");
            new SelectElement(dobYear).SelectByText(regYear);

            // Select Gender & Pronoun
            var gender = driver.FindElement(By.CssSelector("select#gender"));
            Assert.IsNotNull(gender, "Gender dropdown is not found.");
            new SelectElement(gender).SelectByText(regGender);

            var pronoun = driver.FindElement(By.CssSelector("select#pronoun"));
            Assert.IsNotNull(pronoun, "Pronoun dropdown is not found.");
            new SelectElement(pronoun).SelectByText(regPronoun);

            // Accept Policies
            Thread.Sleep(2000);
            ScrollToElement(homePage.NextButton);
            Thread.Sleep(2000);

            Assert.IsNotNull(homePage.CheckPolicy, "Check Policy checkbox is not found.");
            homePage.CheckPolicy.Click();

            Assert.IsNotNull(homePage.Marketing, "Marketing checkbox is not found.");
            homePage.Marketing.Click();

            Assert.IsNotNull(homePage.NextButton, "Next button is not found.");
            homePage.NextButton.Click();

            // Job Information
            Assert.IsNotNull(homePage.Employee, "Employee option is not found.");
            wait.Until(d => homePage.Employee.Displayed);
            homePage.Employee.Click();

            Assert.IsNotNull(homePage.NextButton1, "Next button (Job Info) is not found.");
            homePage.NextButton1.Click();

            Assert.IsNotNull(homePage.PBCadditionaldetails, "PBC Additional Details section is not found.");
            wait.Until(d => homePage.PBCadditionaldetails.Displayed);
            homePage.PBCadditionaldetails.Click();

            Assert.IsNotNull(homePage.PBCNextbutton, "PBC Next button is not found.");
            wait.Until(d => homePage.PBCNextbutton.Displayed);
            homePage.PBCNextbutton.Click();

            Assert.IsNotNull(homePage.JobTitle, "Job Title field is not found.");
            homePage.JobTitle.SendKeys(regTitle);

            var startYear = driver.FindElement(By.CssSelector("select#startYear"));
            Assert.IsNotNull(startYear, "Start Year dropdown is not found.");
            new SelectElement(startYear).SelectByText(regStart);

            Assert.IsNotNull(homePage.RegComplete, "Complete Registration button is not found.");
            wait.Until(d => homePage.RegComplete.Displayed);
            homePage.RegComplete.Click();
         

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData1))]
        public void PBCLandingPage(string Url)
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
                ClickAndNavigateBack(homePage.Signup);
                ClickAndNavigateBack(homePage.Signup1);

                // Click on Homewood in footer
                Thread.Sleep(2000);
                ScrollToElement(homePage.Homewood);
                Thread.Sleep(2000);
                ClickAndSwitchNewTab(homePage.Homewood);

                // Click on Terms of Service & Privacy Policy

                ClickAndNavigateBack(homePage.Termsofservice);

                ClickAndNavigateBack(homePage.Privacypolicy);

                ClickAndNavigateBack(homePage.Accessibility);

                // Click on Articles
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Article1);
                ClickAndNavigateBack(homePage.Article2);
                ClickAndNavigateBack(homePage.Article3);

                // Change Language and click French Sign-up options.

                ScrollToElement(homePage.LanChange);

                ClickAndNavigate(homePage.LanChange);

                ScrollToElement(homePage.SignupFR);
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.SignupFR);
                ClickAndNavigateBack(homePage.Signup1FR);

                // Click on additional articles
                Thread.Sleep(2000);

                ScrollToElement(homePage.Article4);
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Article4);
                ClickAndNavigateBack(homePage.Article5);
                ClickAndNavigateBack(homePage.Article6);

                // Click on French Homewood
                Thread.Sleep(2000);
                ScrollToElement(homePage.HomewoodFR);
                Thread.Sleep(2000);
                ClickAndSwitchNewTab(homePage.HomewoodFR);

                // Click on French Terms of Service & Privacy Policy

                ClickAndNavigateBack(homePage.TermsofserviceFR);

                ClickAndNavigateBack(homePage.PrivacypolicyFR);

                ClickAndNavigateBack(homePage.AccessibilityFR);

                // Quit the driver
                driver.Quit();
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);

            }
        }

        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void PBCDashboard(string PBCUsername, string PBCPassword, string Url, string Search)
        {
            try {  // Navigate to the provided URL
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            var alumniSignup = new HomewebAlumniObjects();
            PageFactory.InitElements(driver, homePage);
            PageFactory.InitElements(driver, alumniSignup);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            
            Thread.Sleep(1000);
            homePage.Login.Click();
            homePage.UserName.SendKeys(PBCUsername);
            Thread.Sleep(1000);
            homePage.Next.Click();
                Thread.Sleep(1000);
                homePage.Password.SendKeys(PBCPassword);
            Thread.Sleep(1000);
            homePage.Submit.Submit();

            // Dashboard interactions
            Thread.Sleep(2000);
            wait.Until(d => homePage.Checkin.Displayed);
            homePage.Checkin.Click();
            Thread.Sleep(2000);
            homePage.Gettingby.Click();
            Thread.Sleep(2000);
            homePage.Continue.Click();
            Thread.Sleep(2000);

            homePage.Moodselect.Click();
            Thread.Sleep(2000);
            homePage.Moodselectcontinue.Click();
            Thread.Sleep(2000);
            homePage.BacktoDashboard.Click();
            Thread.Sleep(2000);
            ClickAndNavigateBack(homePage.Browse);
            // Language Change
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.LanChange);
            ClickAndNavigate(homePage.LanchangeEN);
            wait.Until(d => homePage.Search.Displayed);
            homePage.Search.Click();
            wait.Until(d => alumniSignup.Searchbox.Displayed);
            alumniSignup.Searchbox.SendKeys(Search);
            wait.Until(d => alumniSignup.ClickSearch.Displayed);
            alumniSignup.ClickSearch.Click();

            // Scroll and click on search result
            Thread.Sleep(2000);
            ScrollToElement(alumniSignup.ArticleSearch);
            Thread.Sleep(2000);
            wait.Until(d => alumniSignup.ArticleSearch.Displayed);
            alumniSignup.ArticleSearch.Click();

            // Profile and Logout
            wait.Until(d => homePage.Profile.Displayed);
            homePage.Profile.Click();
            homePage.Logout.Click();

            // Quit the driver
            driver.Quit();

        }
            catch{
        }

            

        }
        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void PBCExternallinks(string PBCUsername, string PBCPassword, string Url, string Search)
        {
            try
            {
                driver.Navigate().GoToUrl(Url);


                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                // Login process
                Assert.IsNotNull(homePage.Login, "Login button is not found.");
                Thread.Sleep(1000);
                homePage.Login.Click();

                Assert.IsNotNull(homePage.UserName, "Username field is not found.");
                homePage.UserName.SendKeys(PBCUsername);

                Assert.IsNotNull(homePage.Next, "Next button is not found.");
                homePage.Next.Click();

                Assert.IsNotNull(homePage.Password, "Password field is not found.");
                Thread.Sleep(1000);
                homePage.Password.SendKeys(PBCPassword);

                Assert.IsNotNull(homePage.Submit, "Submit button is not found.");
                homePage.Submit.Submit();

                // Browse and navigate to Tools
                Assert.IsNotNull(homePage.Browse, "Browse button is not found.");
                ClickAndNavigate(homePage.Browse);
                Thread.Sleep(2000);

                Assert.IsNotNull(homePage.Tools, "Tools button is not found.");
                ClickAndNavigate(homePage.Tools);

                // Childcare Locator
                Thread.Sleep(2000);
                Assert.IsNotNull(homePage.Childcarelocator, "Childcare Locator button is not found.");
                ScrollToElement(homePage.Childcarelocator);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.Childcarelocator);
                Thread.Sleep(1000);

                Assert.IsNotNull(homePage.Childcarelocatorstart, "Childcare Locator Start button is not found.");
                ScrollToElement(homePage.Childcarelocatorstart);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.Childcarelocatorstart);
                TakeScreenshot("C:/Test Data/PBC/ChildcareLocator_");

                try
                {
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
                Assert.IsNotNull(homePage.Backtotools, "Back to Tools button is not found.");
                ClickAndNavigate(homePage.Backtotools);

                // Health and Wellness
                Thread.Sleep(1000);
                Assert.IsNotNull(homePage.HealthandWellness, "Health and Wellness button is not found.");
                ScrollToElement(homePage.HealthandWellness);
                Thread.Sleep(1000);
                ClickAndNavigate(homePage.HealthandWellness);
                Thread.Sleep(1000);

                Assert.IsNotNull(homePage.HealthandWellnesslibrary, "Health and Wellness Library button is not found.");
                ScrollToElement(homePage.HealthandWellnesslibrary);
                Thread.Sleep(1000);
                ClickAndSwitchNewTab(homePage.HealthandWellnesslibrary);
                TakeScreenshot("C:/Test Data/PBC/Healthandwellness_");

                Assert.IsNotNull(homePage.Backtotools, "Back to Tools button is not found.");
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

                    TakeScreenshot("C:/Test Data/PBC/Healthrisk_");
                    Thread.Sleep(2000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                Assert.IsNotNull(homePage.Backtotools, "Back to Tools button is not found.");

                ClickAndNavigate(homePage.Backtotools);

                // Sentio
                Thread.Sleep(2000);
                Assert.IsNotNull(homePage.PBCdepression, "PBC Depression button is not found.");
                ScrollToElement(homePage.PBCdepression);
                Thread.Sleep(1000);
                ClickAndNavigate(homePage.PBCdepression);
                Thread.Sleep(1000);

                Assert.IsNotNull(homePage.PBCStart, "PBC Start button is not found.");
                ScrollToElement(homePage.PBCStart);
                Thread.Sleep(1000);
                ClickAndNavigate(homePage.PBCStart);
                Thread.Sleep(1000);
                driver.Navigate().Back();
                Thread.Sleep(2000);

                Assert.IsNotNull(homePage.Backtotools, "Back to Tools button is not found.");
                ScrollToElement(homePage.Backtotools);
                Thread.Sleep(1000);
                ClickAndNavigate(homePage.Backtotools);

                // Profile and Logout
                Assert.IsNotNull(homePage.Profile, "Profile button is not found.");
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
        private void TakeScreenshot(string filePath)
        {
            ITakesScreenshot ssd = driver as ITakesScreenshot;
            Screenshot ss = ssd.GetScreenshot();
            ss.SaveAsFile(filePath + time.ToString("yy_dd_h_mm_ss") + ".png");
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
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.Regname)
                                                        && !string.IsNullOrEmpty(data.RegFirstName)
                                                        && data.Url == "https://homeweb.ca/pbc");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Regname,  loginData.Url, loginData.RegFirstName,
                    loginData.RegLastName, loginData.RegPassword, loginData.RegMonth, loginData.RegDay,
                    loginData.RegYear, loginData.RegGender, loginData.RegPronoun, loginData.RegTitle, loginData.RegStart);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData1()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\source\\repos\\QA-Homeweb-Automation-3.0\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.Regname)
                                                        && !string.IsNullOrEmpty(data.RegFirstName)
                                                        && data.Url == "https://homeweb.ca/pbc");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Url);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData2()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\source\\repos\\QA-Homeweb-Automation-3.0\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.PBCUsername)
                                                        && !string.IsNullOrEmpty(data.PBCPassword)
                                                        && data.Url == "https://homeweb.ca/pbc");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.PBCUsername, loginData.PBCPassword,loginData.Url, loginData.Search);
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
        private static string GenerateUniqueEmail()
        {
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            return $"testuser_{timestamp}@demo.com";
        }

    }
}
