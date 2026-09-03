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
    public class HomewebPBCFR
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
            public string PBCUsername { get; set; }
            public string PBCPassword { get; set; }
            public string Search { get; set; }


        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void PBCRegistrationFR(string regName, string url, string regFirstName,
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
            ScrollToElement(homePage.RegisterFR);
            wait.Until(d => homePage.RegisterFR.Displayed);
            homePage.RegisterFR.Click();      
            wait.Until(d => homePage.Orgsearch.Displayed);
            homePage.Orgsearch.SendKeys(regName);        
            homePage.Searchbutton.Click();        
            wait.Until(d => homePage.Selectitem.Displayed);
            homePage.Selectitem.Click();           
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
            wait.Until(d => homePage.PBCadditionaldetails.Displayed);
            homePage.PBCadditionaldetails.Click();          
            wait.Until(d => homePage.PBCNextbutton.Displayed);
            homePage.PBCNextbutton.Click();        
            homePage.JobTitle.SendKeys(regTitle);
            var startYear = driver.FindElement(By.CssSelector("select#startYear"));         
            new SelectElement(startYear).SelectByText(regStart);      
            wait.Until(d => homePage.RegComplete.Displayed);
            homePage.RegComplete.Click();                   
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData1))]
        public void PBCLandingPageFR(string Url)
        {
            try
            {
                driver.Navigate().GoToUrl(Url);
                driver.Manage().Cookies.DeleteAllCookies();
                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                ClickAndNavigateBack(homePage.Signup);
                ClickAndNavigateBack(homePage.Signup1);            
                Thread.Sleep(2000);
                ScrollToElement(homePage.Homewood);
                Thread.Sleep(2000);
                ClickAndSwitchNewTab(homePage.Homewood);    
                ClickAndNavigateBack(homePage.Termsofservice);
                ClickAndNavigateBack(homePage.Privacypolicy);
                ClickAndNavigateBack(homePage.Accessibility);     
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Article1);
                ClickAndNavigateBack(homePage.Article2);
                ClickAndNavigateBack(homePage.Article3);      
                ScrollToElement(homePage.LanChange);
                ClickAndNavigate(homePage.LanChange);
                ScrollToElement(homePage.SignupFR);
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.SignupFR);
                ClickAndNavigateBack(homePage.Signup1FR);
                Thread.Sleep(2000);
                ScrollToElement(homePage.Article4);
                Thread.Sleep(2000);
                ClickAndNavigateBack(homePage.Article4);
                ClickAndNavigateBack(homePage.Article5);
                ClickAndNavigateBack(homePage.Article6);      
                Thread.Sleep(2000);
                ScrollToElement(homePage.HomewoodFR);
                Thread.Sleep(2000);
                ClickAndSwitchNewTab(homePage.HomewoodFR);       
                ClickAndNavigateBack(homePage.TermsofserviceFR);
                ClickAndNavigateBack(homePage.PrivacypolicyFR);
                ClickAndNavigateBack(homePage.AccessibilityFR);
                driver.Quit();
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);

            }
        }

        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void PBCDashboardFR(string PBCUsername, string PBCPassword, string Url, string Search)
        {
          
            driver.Navigate().GoToUrl(Url);
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
            homePage.UserName.SendKeys(PBCUsername);
            homePage.Next.Click();
            homePage.Password.SendKeys(PBCPassword);
            homePage.Submit.Submit();         
            Thread.Sleep(2000);
            wait.Until(d => homePage.CheckinFR.Displayed);
            homePage.CheckinFR.Click();
            homePage.Gettingby.Click();
            homePage.ContinueFR.Click();
            Thread.Sleep(2000);
            homePage.Moodselect.Click();
            Thread.Sleep(2000);
            homePage.ContinueFR.Click();
            Thread.Sleep(2000);
            homePage.BacktoDashboardFR.Click();
            Thread.Sleep(2000);
            ClickAndNavigateBack(homePage.BrowseFR);        
            Thread.Sleep(2000);
            ScrollToElement(alumniSignup.PBCFeature2FR);
            Thread.Sleep(2000);
            ClickAndNavigateBack(alumniSignup.PBCFeature2FR);
            Thread.Sleep(2000);
            ScrollToElement(alumniSignup.PBCFeature1FR);
            Thread.Sleep(2000);
            ClickAndNavigateBack(alumniSignup.PBCFeature1FR);
            Thread.Sleep(2000);
            ScrollToElement(homePage.WellnessFR);
            Thread.Sleep(2000);
            ClickAndNavigateBack(homePage.WellnessFR);          
            Thread.Sleep(2000);                 
            ClickAndNavigateBack(homePage.SearchFR);           
            wait.Until(d => homePage.ProfileFR.Displayed);
            homePage.ProfileFR.Click();
            homePage.LogoutFR.Click();       
            driver.Quit();

        }
        
        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void PBCSearchFR(string PBCUsername, string PBCPassword, string Url, string Search)
        {
         
            driver.Navigate().GoToUrl(Url);
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
            homePage.UserName.SendKeys(PBCUsername);          
            homePage.Next.Click();         
            homePage.Password.SendKeys(PBCPassword);       
            homePage.Submit.Submit();   
            wait.Until(d => homePage.SearchFR.Displayed);
            homePage.SearchFR.Click();        
            wait.Until(d => alumniSignup.Searchbox.Displayed);
            alumniSignup.Searchbox.SendKeys(Search);         
            wait.Until(d => alumniSignup.ClickSearch.Displayed);
            alumniSignup.ClickSearch.Click();              
            wait.Until(d => homePage.ProfileFR.Displayed);
            homePage.ProfileFR.Click(); 
            homePage.LogoutFR.Click();
            driver.Quit();

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
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.Regname)
                                                        && !string.IsNullOrEmpty(data.RegFirstName)
                                                        && data.Url == "https://homeweb.ca/pbc");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Regname, loginData.Url, loginData.RegFirstName,
                    loginData.RegLastName, loginData.RegPassword, loginData.RegMonth, loginData.RegDay,
                    loginData.RegYear, loginData.RegGender, loginData.RegPronoun, loginData.RegTitle, loginData.RegStart);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData1()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
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
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.PBCUsername)
                                                        && !string.IsNullOrEmpty(data.PBCPassword)
                                                        && data.Url == "https://homeweb.ca/pbc");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.PBCUsername, loginData.PBCPassword, loginData.Url, loginData.Search);
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
