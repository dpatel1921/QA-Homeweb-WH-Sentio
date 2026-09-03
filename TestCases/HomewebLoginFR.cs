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
    public class HomewebLoginFR
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
        public void LoginCheckFR(string login, string password, string url)
        {

      
            driver.Navigate().GoToUrl(url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => homePage.LanChange.Displayed);
            homePage.LanChange.Click();
            wait.Until(d => homePage.LoginFR.Displayed);
            homePage.LoginFR.Click();
            homePage.UserName.SendKeys(login);       
            homePage.Next.Click();          
            homePage.Password.SendKeys(password);          
            homePage.Submit.Submit();     
            wait.Until(d => homePage.ProfileFR.Displayed);
            homePage.ProfileFR.Click();      
            homePage.LogoutFR.Click();
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData1))]
        public void ForgotPasswordFR(string login, string ForgotUsername, string url)
        {

      
            driver.Navigate().GoToUrl(url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => homePage.LanChange.Displayed);
            homePage.LanChange.Click();
            wait.Until(d => homePage.LoginFR.Displayed);
            homePage.LoginFR.Click();      
            homePage.UserName.SendKeys(login);        
            homePage.Next.Click();       
            homePage.ForgotPassword.Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            homePage.Enteremail.SendKeys(ForgotUsername);
            homePage.Buttonsubmit.Click();
            TakeScreenshot("C:/TestData/Homeweb/ForgotPassword_");       
            Thread.Sleep(1000);          
            driver.Quit();

        }
        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void RegistrationFR(string regName, string regCode, string url, string regFirstName,
    string regLastName, string regPassword, string regMonth, string regDay,
    string regYear, string regGender, string regPronoun, string regTitle, string regStart)
        {
       
            driver.Navigate().GoToUrl(url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            wait.Until(d => homePage.LanChange.Displayed);
            homePage.LanChange.Click();
            wait.Until(d => homePage.RegisterFR.Displayed);
            homePage.RegisterFR.Click();          
            wait.Until(d => homePage.Orgsearch.Displayed);
            homePage.Orgsearch.SendKeys(regName);
            homePage.Searchbutton.Click();          
            wait.Until(d => homePage.Selectitem.Displayed);
            homePage.Selectitem.Click();      
            homePage.Companycode.SendKeys(regCode);
            homePage.Nextstep.Click();                 
            homePage.Firstname.SendKeys(regFirstName);        
            homePage.LastName.SendKeys(regLastName);      
            homePage.Email.Click();
            string uniqueEmail = GenerateUniqueEmail();
            homePage.Email.SendKeys(uniqueEmail);       
            homePage.Password1.SendKeys(regPassword);
            var dobMonth = driver.FindElement(By.CssSelector("select#dobMonth")); 
            new SelectElement(dobMonth).SelectByText("janvier");
            var dobDay = driver.FindElement(By.CssSelector("select#dobDay"));     
            new SelectElement(dobDay).SelectByText(regDay);
            var dobYear = driver.FindElement(By.CssSelector("select#dobYear"));        
            new SelectElement(dobYear).SelectByText(regYear);
            var gender = driver.FindElement(By.CssSelector("select#gender"));        
            new SelectElement(gender).SelectByText("Femme");
            var pronoun = driver.FindElement(By.CssSelector("select#pronoun"));         
            new SelectElement(pronoun).SelectByText("Elle");
            Thread.Sleep(2000);
            ScrollToElement(homePage.NextButton);
            Thread.Sleep(2000);       
            homePage.CheckPolicy.Click();    
            homePage.Marketing.Click();      
            homePage.NextButton.Click();
            wait.Until(d => homePage.Employee.Displayed);
            homePage.Employee.Click();         
            homePage.NextButton1.Click();
            homePage.JobTitle.SendKeys(regTitle);
            var startYear = driver.FindElement(By.CssSelector("select#startYear"));         
            new SelectElement(startYear).SelectByText(regStart);
            wait.Until(d => homePage.RegComplete.Displayed);
            homePage.RegComplete.Click();
            TakeScreenshot("C:/TestData/Homeweb/Registration_");
        }

        public static IEnumerable<TestCaseData> LoginJsonData()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
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
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
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
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
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
