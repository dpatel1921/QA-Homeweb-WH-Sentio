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
    public class HomewebAlumni
    {
        private ExtentReports extent;
        private ExtentTest test;
        private IWebDriver driver;
        private DateTime time = DateTime.Now;
        private WebDriverWait wait;
        private IJavaScriptExecutor jsExecutor;

        [OneTimeSetUp]
        public void SetUp()
        {
            // Initialize ExtentReports instance
            extent = ExtentManager.GetReporter();
        }

        // SetUp method to initialize the ChromeDriver
        [SetUp]
        public void Initialize()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            // Initialize ChromeDriver and set implicit wait
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            jsExecutor = (IJavaScriptExecutor)driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
        }

        // Class to hold test case data from JSON file
        public class TestCaseJsonData
        {
            public string AlumniUsername { get; set; }
            public string AlumniPassword { get; set; }
            public string Url { get; set; }
            public string RegFirstName { get; set; }
            public string RegLastName { get; set; }
            public string RegYear { get; set; }
            public string RegPassword { get; set; }
            public string RegCode { get; set; }
            public string RegProvince { get; set; }
            public string RegCity { get; set; }
            public string RegFacility { get; set; }
            public string RegStartYear { get; set; }
            public string RegTreatmentName { get; set; }
            public string Search { get; set;}

            }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void AlumniRegistration(string RegFirstName, string RegLastName, string Url, string RegYear,
            string RegPassword, string RegCode, string RegProvince, string RegCity, string RegFacility,
            string RegStartYear, string RegTreatmentName)
        {


            driver.Navigate().GoToUrl(Url);
           

            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);

            ScrollToElement(homePage.Register);
            homePage.Register.Click();

            // Wait for the page transition or element visibility
            var alumniSignup = new HomewebAlumniObjects();
            PageFactory.InitElements(driver, alumniSignup);

            homePage.Firstname.SendKeys(RegFirstName);

            homePage.LastName.SendKeys(RegLastName);

            var yearDropdown = driver.FindElement(By.Id("dobYear"));
            new SelectElement(yearDropdown).SelectByText(RegYear);

            homePage.Email.SendKeys(GenerateUniqueEmail());

            homePage.Password.SendKeys(RegPassword);

            Thread.Sleep(1000);
            ScrollToElement(homePage.Alumnireg);
            Thread.Sleep(1000);
            homePage.Alumnireg.SendKeys(RegCode);

            var provinceDropdown = driver.FindElement(By.Id("province"));
            new SelectElement(provinceDropdown).SelectByText(RegProvince);

            homePage.Alumnicity.SendKeys(RegCity);

            ScrollToElement(homePage.NextButton);
            homePage.NextButton.Click();

            // Second form fields
            var facilityDropdown = driver.FindElement(By.Id("treatmentFacility"));
            new SelectElement(facilityDropdown).SelectByText(RegFacility);

            var startYearDropdown = driver.FindElement(By.Id("startYear"));
            new SelectElement(startYearDropdown).SelectByText(RegStartYear);

            var treatmentProgramDropdown = driver.FindElement(By.Id("treatmentProgram"));
            new SelectElement(treatmentProgramDropdown).SelectByText(RegTreatmentName);

            Thread.Sleep(1000);
            ScrollToElement(homePage.Addtreatment);
            Thread.Sleep(1000);
            homePage.Addtreatment.Click();

            ScrollToElement(homePage.alumicompletereg);
            homePage.alumicompletereg.Click();
          

        }
        [Test, TestCaseSource(nameof(LoginJsonData1))]
        public void AlumniLandingPage(string Url)
        {
            

            driver.Navigate().GoToUrl(Url);
            driver.Manage().Cookies.DeleteAllCookies();


            var homePage = new HomewebLoginObjects();
            var alumniPage = new HomewebAlumniObjects();
            PageFactory.InitElements(driver, homePage);
            PageFactory.InitElements(driver, alumniPage);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            ScrollToElement(homePage.Signup);
            wait.Until(d => homePage.Signup.Displayed);
            homePage.Signup.Click();
            driver.Navigate().Back();
        

            wait.Until(d => homePage.Signup1.Displayed);
            homePage.Signup1.Click();
            driver.Navigate().Back();

            Thread.Sleep(2000);
            ScrollToElement(homePage.Homewood);
            // wait.Until(d => homePage.Homewood.Displayed);
            Thread.Sleep(1000);
            homePage.Homewood.Click();
            SwitchToNewTab();
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
        
            Thread.Sleep(2000);
            ScrollToElement(homePage.LanChange);

            Thread.Sleep(2000);
            wait.Until(d => homePage.LanChange.Displayed);
            homePage.LanChange.Click();

            // Scroll and click on French Signups
            Thread.Sleep(2000);
            ScrollToElement(alumniPage.SignupFR);
            Thread.Sleep(1000);
            wait.Until(d => alumniPage.SignupFR.Displayed);
            alumniPage.SignupFR.Click();
            driver.Navigate().Back();
            Thread.Sleep(1000);
            ScrollToElement(alumniPage.SignupFR1);
            Thread.Sleep(1000);
            wait.Until(d => alumniPage.SignupFR1.Displayed);
            alumniPage.SignupFR1.Click();
            driver.Navigate().Back();
                   
            Thread.Sleep(2000);
            ScrollToElement(homePage.HomewoodFR);
            Thread.Sleep(2000);
            wait.Until(d => homePage.HomewoodFR.Displayed);
            homePage.HomewoodFR.Click();
            SwitchToNewTab();
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
       




        }
        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void AlumniDashboard(string AlumniUsername, string AlumniPassword, string url, string Search)
        {
            try
            {
                driver.Navigate().GoToUrl(url);


                var homePage = new HomewebLoginObjects();
                var alumnisignup = new HomewebAlumniObjects();
                PageFactory.InitElements(driver, homePage);
                PageFactory.InitElements(driver, alumnisignup);
                var alumniSignup = new HomewebAlumniObjects();
                PageFactory.InitElements(driver, alumniSignup);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                wait.Until(d => homePage.Login.Displayed);
                homePage.Login.Click();
                Thread.Sleep(1000);
                homePage.UserName.SendKeys(AlumniUsername);
                Thread.Sleep(2000);
                homePage.Next.Click();
                Thread.Sleep(2000);

                homePage.Password.SendKeys(AlumniPassword);
                Thread.Sleep(2000);
                homePage.Submit.Submit();
                Thread.Sleep(2000);
                wait.Until(d => homePage.Checkin.Displayed);
                homePage.Checkin.Click();

                homePage.Gettingby.Click();


                homePage.Continue.Click();
                Thread.Sleep(2000);


                homePage.Moodselect.Click();
                Thread.Sleep(2000);

                homePage.Moodselectcontinue.Click();
                Thread.Sleep(1000);

                homePage.BacktoDashboard.Click();
                Thread.Sleep(1000);

                homePage.Browse.Click();
                Thread.Sleep(1000);

                homePage.BacktoDashboard.Click();

                // Scroll and interact with featured alumni sections
                Thread.Sleep(1000);


                ScrollToElement(alumnisignup.AlumniFeatured1);
                Thread.Sleep(1000);
                wait.Until(d => alumnisignup.AlumniFeatured1.Displayed);
                alumnisignup.AlumniFeatured1.Click();

                homePage.BacktoDashboard.Click();
                Thread.Sleep(1000);

                ScrollToElement(alumnisignup.AlumniFeatured2);
                Thread.Sleep(1000);
                wait.Until(d => alumnisignup.AlumniFeatured2.Displayed);
                alumnisignup.AlumniFeatured2.Click();

                homePage.BacktoDashboard.Click();

                // Language Change
                wait.Until(d => homePage.LanChange.Displayed);
                homePage.LanChange.Click();

                wait.Until(d => homePage.LanchangeEN.Displayed);
                homePage.LanchangeEN.Click();

                homePage.BacktoDashboard.Click();

                // Search Functionality
                Thread.Sleep(1000);
                homePage.Search.Click();

                Thread.Sleep(1000);
                alumniSignup.Searchbox.SendKeys(Search);

                Thread.Sleep(1000);
                alumniSignup.ClickSearch.Click();

                ScrollToElement(alumniSignup.ArticleSearch);
                Thread.Sleep(1000);
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
                                                        && data.Url == "https://homeweb.ca/alumni");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.RegFirstName, loginData.RegLastName, loginData.Url, loginData.RegYear,
                    loginData.RegPassword, loginData.RegCode, loginData.RegProvince, loginData.RegCity,
                    loginData.RegFacility, loginData.RegStartYear, loginData.RegTreatmentName);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData1()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\source\\repos\\QA-Homeweb-Automation-3.0\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.RegFirstName)
                                                        && !string.IsNullOrEmpty(data.RegLastName)
                                                        && data.Url == "https://homeweb.ca/alumni");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Url);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData2()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\source\\repos\\QA-Homeweb-Automation-3.0\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.AlumniUsername)
                                                        && !string.IsNullOrEmpty(data.AlumniPassword)
                                                        && data.Url == "https://homeweb.ca/alumni");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.AlumniUsername, loginData.AlumniPassword,loginData.Url, loginData.Search);
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
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            wait.Until(d => element.Displayed);
        }

        private void SwitchToNewTab()
        {
            var newTab = driver.WindowHandles.Last();
            driver.SwitchTo().Window(newTab);
        }


        // TearDown method to flush the ExtentReports instance
        [OneTimeTearDown]
        public void TearDown()
        {
            // Flush the extent reports
            extent.Flush();
        }

        [TearDown]
        public void AfterTest()
        {
            try
            {
                // Retrieve test result
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

                // Check if driver is initialized before quitting/disposing
                if (driver != null)
                {
                    driver.Quit();
                    driver.Dispose();
                }
                else
                {
                    Console.WriteLine("Driver was null during TearDown. Skipping driver cleanup.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during TearDown: {ex.Message}");
            }
        }
    }
}
