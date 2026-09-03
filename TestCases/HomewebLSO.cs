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
    public class HomewebLSO
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
         //   driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
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
            public string LSOUsername { get; set; }
            public string LSOPassword { get; set; }
            public string Search { get; set; }



        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void LSORegistration(string Url, string RegFirstName, string RegLastName, string RegPassword,
    string RegMonth, string RegDay, string RegYear, string RegGender, string RegPronoun)
        {
            // Navigate to the registration URL
            driver.Navigate().GoToUrl(Url);


            var homePage = new HomewebLoginObjects();
            var lsoSignup = new HomewebLSOObjects();
            PageFactory.InitElements(driver, homePage);
            PageFactory.InitElements(driver, lsoSignup);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            Actions action = new Actions(driver);

            // Click on Register
            Assert.IsNotNull(homePage.Register, "Register button is not found.");
            wait.Until(d => homePage.Register.Displayed);
            homePage.Register.Click();

            // Fill registration form
            Assert.IsNotNull(homePage.Firstname, "First name field is not found.");
            homePage.Firstname.SendKeys(RegFirstName);

            Assert.IsNotNull(homePage.LastName, "Last name field is not found.");
            homePage.LastName.SendKeys(RegLastName);

            Assert.IsNotNull(homePage.Email, "Email field is not found.");
            homePage.Email.Click();
            string uniqueEmail = GenerateUniqueEmail();
            homePage.Email.SendKeys(uniqueEmail);

            Assert.IsNotNull(homePage.Password, "Password field is not found.");
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

            // Select Gender & Pronoun
            var gender = driver.FindElement(By.CssSelector("select#gender"));
            Assert.IsNotNull(gender, "Gender dropdown is not found.");
            new SelectElement(gender).SelectByText(RegGender);

            var pronoun = driver.FindElement(By.CssSelector("select#pronoun"));
            Assert.IsNotNull(pronoun, "Pronoun dropdown is not found.");
            new SelectElement(pronoun).SelectByText(RegPronoun);

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

            // LSO Selection
            Assert.IsNotNull(lsoSignup.LSOselect, "LSO selection button is not found.");
            wait.Until(d => lsoSignup.LSOselect.Displayed);
            lsoSignup.LSOselect.Click();

            Assert.IsNotNull(lsoSignup.Chevron, "Chevron dropdown is not found.");
            wait.Until(d => lsoSignup.Chevron.Displayed);
            lsoSignup.Chevron.Click();

            // Selecting Region & Role using Actions
            Thread.Sleep(2000);
            Assert.IsNotNull(lsoSignup.LSOregion, "LSO Region selection is not found.");
            IWebElement regionElement = wait.Until(d => lsoSignup.LSOregion);
            action.MoveToElement(regionElement).Click().Perform();

            Thread.Sleep(2000);
            Assert.IsNotNull(lsoSignup.LSOrole, "LSO Role selection is not found.");
            IWebElement roleElement = wait.Until(d => lsoSignup.LSOrole);
            action.MoveToElement(roleElement).Click().Perform();

            // Complete Registration
            Assert.IsNotNull(lsoSignup.LSORegcomplete, "Complete Registration button is not found.");
            wait.Until(d => lsoSignup.LSORegcomplete.Displayed);
            lsoSignup.LSORegcomplete.Click();
         

            // Quit the driver
            driver.Quit();
        }

        [Test, TestCaseSource(nameof(LoginJsonData1))]
        public void LSOLandingPage(string Url)
        {
            try
            {
                // Navigate to the provided URL
                driver.Navigate().GoToUrl(Url);


                driver.Manage().Cookies.DeleteAllCookies();

                var homePage = new HomewebLoginObjects();
                var lsoPage = new HomewebLSOObjects();
                PageFactory.InitElements(driver, homePage);
                PageFactory.InitElements(driver, lsoPage);

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
                Thread.Sleep(2000);
                ScrollToElement(homePage.Termsofservice);
                ClickAndNavigateBack(homePage.Termsofservice);
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Privacypolicy);
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Accessibility);

                // Click on LSO links
                Thread.Sleep(2000);
                Assert.IsNotNull(lsoPage.LSO1, "LSO1 link is not found.");
                ScrollToElement(lsoPage.LSO1);
                Thread.Sleep(2000);
                ClickAndSwitchNewTab(lsoPage.LSO1);
                ClickAndSwitchNewTab(lsoPage.LSO2);
                ClickAndSwitchNewTab(lsoPage.LSO3);
                ClickAndSwitchNewTab(lsoPage.LSO4);
                ClickAndSwitchNewTab(lsoPage.LSO5);

                // Change Language and click French Sign-up options
                Thread.Sleep(2000);
                Assert.IsNotNull(homePage.LanChange, "Language Change button is not found.");
                ScrollToElement(homePage.LanChange);
                Thread.Sleep(2000);
                ClickAndNavigate(homePage.LanChange);
                ClickAndNavigateBack(homePage.SignupFR);
                ClickAndNavigateBack(homePage.Signup1FR);

                // Click on additional LSO links
                Thread.Sleep(2000);
                ScrollToElement(lsoPage.LSO6);
                Thread.Sleep(2000);
                ClickAndSwitchNewTab1(lsoPage.LSO6);
                ClickAndSwitchNewTab1(lsoPage.LSO7);
                ClickAndSwitchNewTab1(lsoPage.LSO8);
                ClickAndSwitchNewTab1(lsoPage.LSO9);

                // Click on French Homewood
                Thread.Sleep(2000);
                Assert.IsNotNull(homePage.HomewoodFR, "French Homewood link is not found.");
                ScrollToElement(homePage.HomewoodFR);
                Thread.Sleep(2000);
                ClickAndSwitchNewTab(homePage.HomewoodFR);

                // Click on French Terms of Service & Privacy Policy
                ClickAndNavigateBack(homePage.TermsofserviceFR);
                ClickAndNavigateBack(homePage.PrivacypolicyFR);
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.AccessibilityFR);

                // Quit the driver
                driver.Quit();
            }
            catch
            {

            }

        }
        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void LSODashboard(string LSOUsername, string LSOPassword, string url, string Search)
        {
            try
            {


                // Navigate to the provided URL
                driver.Navigate().GoToUrl(url);


                var homePage = new HomewebLoginObjects();
                var lsoPage = new HomewebLSOObjects();
                PageFactory.InitElements(driver, homePage);
                PageFactory.InitElements(driver, lsoPage);
                var alumniSignup = new HomewebAlumniObjects();
                PageFactory.InitElements(driver, alumniSignup);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                // Login process
                Assert.IsNotNull(homePage.Login, "Login button is not found.");
                Thread.Sleep(1000);
                homePage.Login.Click();

                Assert.IsNotNull(homePage.UserName, "Username field is not found.");
                homePage.UserName.SendKeys(LSOUsername);

                Assert.IsNotNull(homePage.Next, "Next button is not found.");
                homePage.Next.Click();

                Assert.IsNotNull(homePage.Password, "Password field is not found.");
                Thread.Sleep(1000);
                homePage.Password.SendKeys(LSOPassword);

                Assert.IsNotNull(homePage.Submit, "Submit button is not found.");
                homePage.Submit.Submit();

                // Dashboard interactions
                Assert.IsNotNull(homePage.Checkin, "Check-in button is not found.");

                Thread.Sleep(2000);
                homePage.Checkin.Click();

                Assert.IsNotNull(homePage.Gettingby, "Getting by option is not found.");
                homePage.Gettingby.Click();
                homePage.Watchtutorial.Click();
                SwitchToNewTab();
                Thread.Sleep(2000);
                driver.Close();
                driver.SwitchTo().Window(driver.WindowHandles.First());

                Assert.IsNotNull(homePage.Continue, "Continue button is not found.");
                homePage.Continue.Click();

                Thread.Sleep(2000);
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

                Thread.Sleep(2000);
                ScrollToElement(homePage.Recommends);

                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Recommends);

                // Scroll and click on LSO Dashboard elements

                Thread.Sleep(2000);
                ScrollToElement(lsoPage.LSODashboard);

                Thread.Sleep(2000);
                ClickAndNavigateBack(lsoPage.LSODashboard);

                Thread.Sleep(2000);
                ScrollToElement(lsoPage.LSOHabitsarticle);

                Thread.Sleep(2000);
                ClickAndNavigateBack(lsoPage.LSOHabitsarticle);
                Thread.Sleep(1000);
                // Language Change
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
                Thread.Sleep(1000);
                ScrollToElement(alumniSignup.ArticleSearch);
                Thread.Sleep(1000);
                wait.Until(d => alumniSignup.ArticleSearch.Displayed);
                alumniSignup.ArticleSearch.Click();

                // Profile and Logout

                Thread.Sleep(1000);

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
        public void LSOExternallinks(string LSOUsername, string LSOPassword, string url, string Search)
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
                homePage.UserName.SendKeys(LSOUsername);

                Assert.IsNotNull(homePage.Next, "Next button is not found.");
                homePage.Next.Click();

                Assert.IsNotNull(homePage.Password, "Password field is not found.");
                Thread.Sleep(1000);
                homePage.Password.SendKeys(LSOPassword);

                Assert.IsNotNull(homePage.Submit, "Submit button is not found.");
                homePage.Submit.Submit();

                // Browse and navigate to Tools
                ClickAndNavigate(homePage.Browse);
                ClickAndNavigate(homePage.Tools);

                // Childcare Locator
                Thread.Sleep(2000);
                ScrollToElement(homePage.Childcarelocator);
                Thread.Sleep(1000);

                ClickAndNavigate(homePage.Childcarelocator);
                Thread.Sleep(1000);

                ScrollToElement(homePage.Childcarelocatorstart);
                Thread.Sleep(1000);
                ClickAndNavigate(homePage.Childcarelocatorstart);
                Thread.Sleep(1000);
                TakeScreenshot("C:/Test Data/LSO/ChildcareLocator_");

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
                TakeScreenshot("C:/Test Data/LSO/Healthandwellness_");

                ClickAndNavigate(homePage.Backtotools);

                // Health RiskAssessment
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
                TakeScreenshot("C:/Test Data/LSO/Sentio_");
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
                Thread.Sleep(2000);
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

      
        private void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        private void ClickAndNavigate(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => element.Displayed);
            element.Click();
        }

        private void ClickAndNavigateBack(IWebElement element)
        {
            ClickAndNavigate(element);
            driver.Navigate().Back();
        }

        private void ClickAndSwitchNewTab(IWebElement element)
        {
            ClickAndNavigate(element);
            SwitchToNewTab();
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }
        private void ClickAndSwitchNewTab1(IWebElement element)
        {
            ClickAndNavigate(element);
            SwitchToNewTab();
            //driver.Close();
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

        private static string GenerateUniqueEmail()
        {
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            return $"testuser_{timestamp}@demo.com";
        }
        public static IEnumerable<TestCaseData> LoginJsonData()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\source\\repos\\QA-Homeweb-Automation-3.0\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.RegFirstName)
                                                                    && !string.IsNullOrEmpty(data.RegLastName)
                                                                    && data.Url == "https://homeweb.ca/map")
                                                     .Skip(0);

            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Url, loginData.RegFirstName,
                    loginData.RegLastName, loginData.RegPassword, loginData.RegMonth, loginData.RegDay,
                    loginData.RegYear, loginData.RegGender, loginData.RegPronoun);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData1()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\source\\repos\\QA-Homeweb-Automation-3.0\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.RegFirstName)
                                                                    && !string.IsNullOrEmpty(data.RegLastName)
                                                                    && data.Url == "https://homeweb.ca/map")
                                                     .Skip(0);

            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Url);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData2()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\source\\repos\\QA-Homeweb-Automation-3.0\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.LSOUsername)
                                                                    && !string.IsNullOrEmpty(data.LSOPassword)
                                                                    && data.Url == "https://homeweb.ca/map")
                                                     .Skip(0);

            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.LSOUsername, loginData.LSOPassword,loginData.Url, loginData.Search);
            }
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            extent.Flush();
        }

        [TearDown]
        public void Aftertest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = TestContext.CurrentContext.Result.Message;

            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                test.Fail("Test Failed");
                test.Log(Status.Fail, "Test failed with logtrace" + stackTrace);
            }
            else if (status == NUnit.Framework.Interfaces.TestStatus.Passed)
            {
                test.Pass("Test Pass");
            }

            try
            {
                driver.Quit();
            }
            finally
            {
                driver.Dispose();
            }
        }
    }
}
