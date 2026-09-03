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
    public class HomewebAlumniFR
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
            public string Search { get; set; }

        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void AlumniRegistrationFR(string RegFirstName, string RegLastName, string Url, string RegYear,
            string RegPassword, string RegCode, string RegProvince, string RegCity, string RegFacility,
            string RegStartYear, string RegTreatmentName)
        {

            driver.Navigate().GoToUrl(Url);
        
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);
            homePage.LanChange.Click();
            ScrollToElement(homePage.RegisterFR);
            homePage.RegisterFR.Click();          
            homePage.FirstnameFR.SendKeys(RegFirstName);
            homePage.LastNameFR.SendKeys(RegLastName);
            var yearDropdown = driver.FindElement(By.Id("dobYear"));          
            new SelectElement(yearDropdown).SelectByText(RegYear);        
            homePage.EmailFR.SendKeys(GenerateUniqueEmail());          
            homePage.Password1FR.SendKeys(RegPassword);
            Thread.Sleep(1000);
            ScrollToElement(homePage.AlumniregFR);
            Thread.Sleep(1000);
            homePage.AlumniregFR.SendKeys(RegCode);
            var provinceDropdown = driver.FindElement(By.Id("province"));         
            new SelectElement(provinceDropdown).SelectByText(RegProvince);
            homePage.AlumnicityFR.SendKeys(RegCity);
            ScrollToElement(homePage.NextButtonFR);
            homePage.NextButtonFR.Click();           
            var facilityDropdown = driver.FindElement(By.Id("treatmentFacility"));          
            new SelectElement(facilityDropdown).SelectByText(RegFacility);
            var startYearDropdown = driver.FindElement(By.Id("startYear"));         
            new SelectElement(startYearDropdown).SelectByText(RegStartYear);
            var treatmentProgramDropdown = driver.FindElement(By.Id("treatmentProgram"));        
            new SelectElement(treatmentProgramDropdown).SelectByText(RegTreatmentName);          
            Thread.Sleep(1000);
            ScrollToElement(homePage.AddtreatmentFR);
            Thread.Sleep(1000);
            homePage.AddtreatmentFR.Click();
            ScrollToElement(homePage.alumicompleteregFR);
            homePage.alumicompleteregFR.Click();
            TakeScreenshot("C:/TestData/Alumni/Registration_");

        }
        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void AlumniDashboardFR(string AlumniUsername, string AlumniPassword, string url, string Search)
        {
            driver.Navigate().GoToUrl(url);


            var homePage = new HomewebLoginObjects();
            var alumnisignup = new HomewebAlumniObjects();
            PageFactory.InitElements(driver, homePage);
            PageFactory.InitElements(driver, alumnisignup);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            wait.Until(d => homePage.LanChange.Displayed);
            homePage.LanChange.Click();
            wait.Until(d => homePage.LoginFR.Displayed);
            homePage.LoginFR.Click();         
            homePage.UserName.SendKeys(AlumniUsername);
            homePage.Next.Click();      
            homePage.Password.SendKeys(AlumniPassword);         
            homePage.Submit.Submit();         
            wait.Until(d => homePage.CheckinFR.Displayed);
            homePage.CheckinFR.Click();        
            homePage.Gettingby.Click();         
            homePage.ContinueFR.Click();
            Thread.Sleep(2000);         
            homePage.Moodselect.Click();
            Thread.Sleep(2000);         
            homePage.ContinueFR.Click();
            Thread.Sleep(1000);       
            homePage.BacktoDashboardFR.Click();
            Thread.Sleep(1000);          
            homePage.BrowseFR.Click();
            Thread.Sleep(1000);        
            homePage.BacktoDashboardFR.Click();
            Thread.Sleep(1000);        
            ScrollToElement(alumnisignup.AlumniFeaturedFR);
            Thread.Sleep(1000);
            wait.Until(d => alumnisignup.AlumniFeaturedFR.Displayed);
            alumnisignup.AlumniFeaturedFR.Click();         
            homePage.BacktoDashboardFR.Click();
            Thread.Sleep(1000);      
            ScrollToElement(alumnisignup.AlumniFeatured1FR);
            Thread.Sleep(1000);
            wait.Until(d => alumnisignup.AlumniFeatured1FR.Displayed);
            alumnisignup.AlumniFeatured1FR.Click();       
            homePage.BacktoDashboardFR.Click();
            Thread.Sleep(1000);          
            ScrollToElement(alumnisignup.AlumniFeatured2FR);
            Thread.Sleep(1000);
            wait.Until(d => alumnisignup.AlumniFeatured2FR.Displayed);
            alumnisignup.AlumniFeatured2FR.Click();          
            homePage.BacktoDashboardFR.Click();        
            wait.Until(d => homePage.WellnessFR.Displayed);
            homePage.WellnessFR.Click();        
            homePage.BacktoDashboardFR.Click();
         
            wait.Until(d => homePage.SearchFR.Displayed);
            homePage.SearchFR.Click();
            homePage.BacktoDashboardFR.Click();
            wait.Until(d => homePage.ProfileFR.Displayed);
            homePage.ProfileFR.Click();        
            homePage.LogoutFR.Click();
            driver.Quit();
        }



        private static string GenerateUniqueEmail()
        {
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            return $"testuser_{timestamp}@demo.com";
        }
        public static IEnumerable<TestCaseData> LoginJsonData()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
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
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
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
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.AlumniUsername)
                                                        && !string.IsNullOrEmpty(data.AlumniPassword)
                                                        && data.Url == "https://homeweb.ca/alumni");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.AlumniUsername, loginData.AlumniPassword, loginData.Url, loginData.Search);
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
