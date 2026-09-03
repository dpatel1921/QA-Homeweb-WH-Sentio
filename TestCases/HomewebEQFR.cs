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
    public class HomewebEQFR
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
        public void EQRegistrationFR(string EQPolicy, string Url, string RegFirstName, string RegLastName, string RegPassword,
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
            wait.Until(d => homePage.LanChange.Displayed);
            homePage.LanChange.Click();
            wait.Until(d => homePage.RegisterFR.Displayed);
            homePage.RegisterFR.Click();          
            wait.Until(d => eqSignup.EQPolicyID.Displayed);
            eqSignup.EQPolicyID.Click();
            eqSignup.EQPolicyID.SendKeys(EQPolicy);
            eqSignup.SearchButton.Click();         
            wait.Until(d => eqSignup.OrgSelect.Displayed);
            eqSignup.OrgSelect.Click();         
            homePage.Firstname.SendKeys(RegFirstName);
            homePage.LastName.SendKeys(RegLastName);
            homePage.Email.Click();
            string uniqueEmail = GenerateUniqueEmail();
            homePage.Email.SendKeys(uniqueEmail);
            homePage.Password.Click();
            homePage.Password.SendKeys(RegPassword);
            var dobMonth = driver.FindElement(By.CssSelector("select#dobMonth"));           
            new SelectElement(dobMonth).SelectByText("janvier");
            var dobDay = driver.FindElement(By.CssSelector("select#dobDay"));        
            new SelectElement(dobDay).SelectByText(RegDay);
            var dobYear = driver.FindElement(By.CssSelector("select#dobYear"));       
            new SelectElement(dobYear).SelectByText(RegYear);
            Thread.Sleep(2000);
            ScrollToElement(homePage.NextButton);
            var gender = driver.FindElement(By.CssSelector("select#gender"));        
            new SelectElement(gender).SelectByText("Femme");
            var pronoun = driver.FindElement(By.CssSelector("select#pronoun"));         
            new SelectElement(pronoun).SelectByText("Elle");    
            wait.Until(d => homePage.CheckPolicy.Displayed);
            homePage.CheckPolicy.Click();
            homePage.Marketing.Click();
            wait.Until(d => homePage.NextButton.Displayed);
            homePage.NextButton.Click();       
            wait.Until(d => homePage.Employee.Displayed);
            homePage.Employee.Click();         
            homePage.NextButton1.Click();         
            wait.Until(d => eqSignup.SelectPartOrg.Displayed);
            eqSignup.SelectPartOrg.Click();          
            homePage.JobTitle.SendKeys(RegTitle);
            var startYear = driver.FindElement(By.CssSelector("select#startYear"));       
            new SelectElement(startYear).SelectByText(RegStart);
            wait.Until(d => homePage.RegComplete.Displayed);            
            homePage.RegComplete.Click();       
            driver.Quit();
        }

        [Test, TestCaseSource(nameof(LoginJsonData1))]
        public void EQLandingPageFR(string Url)
        {
            try
            { 
                driver.Navigate().GoToUrl(Url);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Manage().Cookies.DeleteAllCookies();
                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;             
                Thread.Sleep(2000);
                homePage.Signup.Click();
                driver.Navigate().Back();             
                Thread.Sleep(2000);
                homePage.Signup1.Click();
                driver.Navigate().Back();          
                ScrollToElement(homePage.Homewood);
                Thread.Sleep(2000);
                homePage.Homewood.Click();
                SwitchToNewTab();
                Thread.Sleep(2000);
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
                ClickAndNavigateBack(homePage.Article1);
                ClickAndNavigateBack(homePage.Article2);
                ClickAndNavigateBack(homePage.Article3);
                Thread.Sleep(2000);      
                ScrollToElement(homePage.LanChange);
                Thread.Sleep(2000);
                homePage.LanChange.Click();         
                wait.Until(d => homePage.SignupFR.Displayed);
                homePage.SignupFR.Click();
                driver.Navigate().Back();
                Thread.Sleep(1000);        
                wait.Until(d => homePage.Signup1FR.Displayed);
                Thread.Sleep(1000);
                homePage.Signup1FR.Click();
                driver.Navigate().Back();       
                Thread.Sleep(1000);         
                ScrollToElement(homePage.HomewoodFR);
                Thread.Sleep(1000);
                homePage.HomewoodFR.Click();
                SwitchToNewTab();
                Thread.Sleep(2000);
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
                ClickAndNavigateBack(homePage.Article4);
                ClickAndNavigateBack(homePage.Article5);
                ClickAndNavigateBack(homePage.Article6);
                driver.Quit();
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);

            }
        }

        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void EQDashboardFR(string EQUsername, string EQPassword, string url, string Search)
        {
            driver.Navigate().GoToUrl(url);
            var homePage = new HomewebLoginObjects();
            var eqSignup = new HomewebEQObjects();
            PageFactory.InitElements(driver, homePage);
            PageFactory.InitElements(driver, eqSignup);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            wait.Until(d => homePage.LanChange.Displayed);
            homePage.LanChange.Click();
            wait.Until(d => homePage.LoginFR.Displayed);
            homePage.LoginFR.Click();
            homePage.UserName.SendKeys(EQUsername);
            homePage.Next.Click();        
            homePage.Password.SendKeys(EQPassword);          
            homePage.Submit.Submit();
            Thread.Sleep(2000);
            homePage.CheckinFR.Click();          
            homePage.Gettingby.Click();        
            homePage.WatchtutorialFR.Click();
            SwitchToNewTab();
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());    
            homePage.ContinueFR.Click();
            Thread.Sleep(1000);    
            homePage.Moodselect.Click();      
            homePage.ContinueFR.Click();
            Thread.Sleep(1000);       
            homePage.BacktoDashboardFR.Click();                 
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
            ScrollToElement(eqSignup.EQSentioFR);
            Thread.Sleep(1000);
            ClickAndNavigateBack(eqSignup.EQSentioFR);
            Thread.Sleep(1000);
            ScrollToElement(eqSignup.EQMonthArticle);
            Thread.Sleep(1000);
            ClickAndNavigateBack(eqSignup.EQMonthArticle);                   
            Thread.Sleep(1000);
            ScrollToElement(homePage.WellnessFR);
            Thread.Sleep(1000);
            ClickAndNavigateBack(homePage.WellnessFR);     
            Thread.Sleep(1000);        
            ClickAndNavigateBack(homePage.SearchFR);
            wait.Until(d => homePage.ProfileFR.Displayed);
            homePage.ProfileFR.Click();          
            homePage.LogoutFR.Click();
            driver.Quit();
        }

       
        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void EQSearchFR(string EQUsername, string EQPassword, string url, string Search)
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
            homePage.UserName.SendKeys(EQUsername);        
            homePage.Next.Click();         
            homePage.Password.SendKeys(EQPassword);
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
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
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
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
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
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.EQUsername)
                                                        && !string.IsNullOrEmpty(data.EQPassword)
                                                         && data.Url == "https://homeweb.ca/equitable");

            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.EQUsername, loginData.EQPassword, loginData.Url, loginData.Search);
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
