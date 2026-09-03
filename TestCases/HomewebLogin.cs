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
    public class HomewebLogin
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
           


        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void LoginCheck(string login, string password, string url)
        {

            // Navigate to the provided URL
            driver.Navigate().GoToUrl(url);
            

            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Login process
            Assert.IsNotNull(homePage.Login, "Login button is not found.");
          //  Thread.Sleep(1000);
            homePage.Login.Click();

            Assert.IsNotNull(homePage.UserName, "Username field is not found.");
           // Thread.Sleep(1000);
            homePage.UserName.SendKeys(login);

            Assert.IsNotNull(homePage.Next, "Next button is not found.");
            //Thread.Sleep(1000);
            homePage.Next.Click();

            Assert.IsNotNull(homePage.Password, "Password field is not found.");
           // Thread.Sleep(1000);
            homePage.Password.SendKeys(password);

            Assert.IsNotNull(homePage.Submit, "Submit button is not found.");
            homePage.Submit.Submit();

            Assert.IsNotNull(homePage.Profile, "Profile button is not found.");
            //Thread.Sleep(1000);
            homePage.Profile.Click();

            // Log out
            Assert.IsNotNull(homePage.Logout, "Logout button is not found.");
            homePage.Logout.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData1))]
        public void ForgotPassword(string login,string ForgotUsername, string url)
        {

            // Navigate to the provided URL
            driver.Navigate().GoToUrl(url);
          

            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Login process
            Assert.IsNotNull(homePage.Login, "Login button is not found.");
          
            homePage.Login.Click();

            Assert.IsNotNull(homePage.UserName, "Username field is not found.");
          
            homePage.UserName.SendKeys(login);

            Assert.IsNotNull(homePage.Next, "Next button is not found.");
          
            homePage.Next.Click();

            // Forgot Password
            Assert.IsNotNull(homePage.ForgotPassword, "Forgot Password link is not found.");
          
            homePage.ForgotPassword.Click();

            // Switch to new window
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            Assert.IsNotNull(homePage.Enteremail, "Email input field for password reset is not found.");
            homePage.Enteremail.SendKeys(ForgotUsername);

            Assert.IsNotNull(homePage.Buttonsubmit, "Submit button for password reset is not found.");
            homePage.Buttonsubmit.Click();
            TakeScreenshot("C:/TestData/Homeweb/ForgotPassword_");

            // Wait for process completion
            Thread.Sleep(1000);

            // Quit the driver
            driver.Quit();


        }
        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void Registration(string regName, string regCode, string url, string regFirstName,
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

            Assert.IsNotNull(homePage.Companycode, "Company code field is not found.");
            homePage.Companycode.SendKeys(regCode);

            Assert.IsNotNull(homePage.Nextstep, "Next step button is not found.");
            homePage.Nextstep.Click();

            // Enter Personal Information
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
            Assert.IsNotNull(homePage.Employee, "Employee selection is not found.");
            wait.Until(d => homePage.Employee.Displayed);
            homePage.Employee.Click();

            Assert.IsNotNull(homePage.NextButton1, "Next button (Job Info) is not found.");
            homePage.NextButton1.Click();

            Assert.IsNotNull(homePage.JobTitle, "Job Title field is not found.");
            homePage.JobTitle.SendKeys(regTitle);

            var startYear = driver.FindElement(By.CssSelector("select#startYear"));
            Assert.IsNotNull(startYear, "Start Year dropdown is not found.");
            new SelectElement(startYear).SelectByText(regStart);

            // Complete Registration
            Assert.IsNotNull(homePage.RegComplete, "Complete Registration button is not found.");
            wait.Until(d => homePage.RegComplete.Displayed);
            homePage.RegComplete.Click();
        
        }

        public static IEnumerable<TestCaseData> LoginJsonData()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\source\\repos\\QA-Homeweb-Automation-3.0\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.Login)
                                                        && !string.IsNullOrEmpty(data.Password)
                                                        && data.Url == "https://homeweb.ca");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Login, loginData.Password, loginData.Url);
            }
        }
        private void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        private void TakeScreenshot(string filePath)
        {
            ITakesScreenshot ssd = driver as ITakesScreenshot;
            Screenshot ss = ssd.GetScreenshot();
            ss.SaveAsFile(filePath + time.ToString("yy_dd_h_mm_ss") + ".png");
        }
        public static IEnumerable<TestCaseData> LoginJsonData1()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\source\\repos\\QA-Homeweb-Automation-3.0\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.Login)
                                                        && !string.IsNullOrEmpty(data.ForgotUsername)
                                                        && data.Url == "https://homeweb.ca");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Login, loginData.ForgotUsername, loginData.Url);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData2()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\source\\repos\\QA-Homeweb-Automation-3.0\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.Regname)
                                                        && !string.IsNullOrEmpty(data.Regcode)
                                                        && data.Url == "https://homeweb.ca");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Regname, loginData.Regcode, loginData.Url, loginData.RegFirstName,
                    loginData.RegLastName, loginData.RegPassword, loginData.RegMonth, loginData.RegDay,
                    loginData.RegYear, loginData.RegGender, loginData.RegPronoun, loginData.RegTitle, loginData.RegStart);
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
