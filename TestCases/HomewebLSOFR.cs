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
    public class HomewebLSOFR
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
            public string LSOUsername { get; set; }
            public string LSOPassword { get; set; }
            public string Search { get; set; }



        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void LSORegistrationFR(string Url, string RegFirstName, string RegLastName, string RegPassword,
    string RegMonth, string RegDay, string RegYear, string RegGender, string RegPronoun)
        {
    
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            var lsoSignup = new HomewebLSOObjects();
            PageFactory.InitElements(driver, homePage);
            PageFactory.InitElements(driver, lsoSignup);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            Actions action = new Actions(driver);
            wait.Until(d => homePage.LanChange.Displayed);
            homePage.LanChange.Click();          
            wait.Until(d => homePage.RegisterFR.Displayed);
            homePage.RegisterFR.Click();         
            homePage.Firstname.SendKeys(RegFirstName);
            homePage.LastName.SendKeys(RegLastName);         
            homePage.Email.Click();
            string uniqueEmail = GenerateUniqueEmail();
            homePage.Email.SendKeys(uniqueEmail);           
            homePage.Password.SendKeys(RegPassword);        
            var dobMonth = driver.FindElement(By.CssSelector("select#dobMonth"));          
            new SelectElement(dobMonth).SelectByText("janvier");
            var dobDay = driver.FindElement(By.CssSelector("select#dobDay"));          
            new SelectElement(dobDay).SelectByText(RegDay);
            var dobYear = driver.FindElement(By.CssSelector("select#dobYear"));         
            new SelectElement(dobYear).SelectByText(RegYear);
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
            wait.Until(d => lsoSignup.LSOselect.Displayed);
            lsoSignup.LSOselect.Click();
            wait.Until(d => lsoSignup.Chevron.Displayed);
            lsoSignup.Chevron.Click();        
            Thread.Sleep(2000);    
            IWebElement regionElement = wait.Until(d => lsoSignup.LSOregion);
            action.MoveToElement(regionElement).Click().Perform();
            Thread.Sleep(2000);
            ScrollToElement(lsoSignup.LSOroleFR);
            Thread.Sleep(1000);
            IWebElement roleElement = wait.Until(d => lsoSignup.LSOroleFR);
            action.MoveToElement(roleElement).Click().Perform();           
            wait.Until(d => lsoSignup.LSORegcomplete.Displayed);
            lsoSignup.LSORegcomplete.Click();         
            driver.Quit();
        }

        [Test, TestCaseSource(nameof(LoginJsonData1))]
        public void LSOLandingPageFR(string Url)
        {

           
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Cookies.DeleteAllCookies();
            var homePage = new HomewebLoginObjects();
            var lsoPage = new HomewebLSOObjects();
            PageFactory.InitElements(driver, homePage);
            PageFactory.InitElements(driver, lsoPage);
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
            Thread.Sleep(2000);
            ClickAndNavigateBack(homePage.Accessibility);
            Thread.Sleep(2000);          
            ScrollToElement(lsoPage.LSO1);
            Thread.Sleep(2000);
            ClickAndSwitchNewTab(lsoPage.LSO1);
            ClickAndSwitchNewTab(lsoPage.LSO2);
            ClickAndSwitchNewTab(lsoPage.LSO3);
            ClickAndSwitchNewTab(lsoPage.LSO4);
            ClickAndSwitchNewTab(lsoPage.LSO5);      
            Thread.Sleep(2000);           
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(2000);
            ClickAndNavigate(homePage.LanChange);
            ClickAndNavigateBack(homePage.SignupFR);
            ClickAndNavigateBack(homePage.Signup1FR);         
            Thread.Sleep(2000);
            ScrollToElement(lsoPage.LSO6);
            Thread.Sleep(2000);
            ClickAndSwitchNewTab1(lsoPage.LSO6);
            ClickAndSwitchNewTab1(lsoPage.LSO7);
            ClickAndSwitchNewTab1(lsoPage.LSO8);
            ClickAndSwitchNewTab1(lsoPage.LSO9);         
            Thread.Sleep(2000);       
            ScrollToElement(homePage.HomewoodFR);
            Thread.Sleep(2000);
            ClickAndSwitchNewTab(homePage.HomewoodFR);         
            ClickAndNavigateBack(homePage.TermsofserviceFR);
            ClickAndNavigateBack(homePage.PrivacypolicyFR);
            Thread.Sleep(2000);
            ClickAndNavigateBack(homePage.AccessibilityFR);
            driver.Quit();

        }
        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void LSODashboardFR(string LSOUsername, string LSOPassword, string url, string Search)
        {
           
            driver.Navigate().GoToUrl(url);
            var homePage = new HomewebLoginObjects();
            var lsoPage = new HomewebLSOObjects();
            PageFactory.InitElements(driver, homePage);
            PageFactory.InitElements(driver, lsoPage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            wait.Until(d => homePage.LanChange.Displayed);
            homePage.LanChange.Click();     
            wait.Until(d => homePage.LoginFR.Displayed);
            homePage.LoginFR.Click();           
            homePage.UserName.SendKeys(LSOUsername);       
            homePage.Next.Click();          
            homePage.Password.SendKeys(LSOPassword);           
            homePage.Submit.Submit();
            Thread.Sleep(2000);
            homePage.CheckinFR.Click();
            homePage.Gettingby.Click();         
            homePage.WatchtutorialFR.Click();
            SwitchToNewTab();
            Thread.Sleep(2000);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());        
            homePage.ContinueFR.Click();
            Thread.Sleep(2000);         
            homePage.Moodselect.Click();           
            homePage.ContinueFR.Click();
            Thread.Sleep(1000);        
            homePage.BacktoDashboardFR.Click();         
            ClickAndNavigateBack(homePage.LaunchpathfinderFR);
            ClickAndNavigateBack(homePage.BrowseFR);
            Thread.Sleep(2000);
            ScrollToElement(homePage.RecommendsFR);
            Thread.Sleep(2000);
            ClickAndNavigateBack(homePage.RecommendsFR);
            Thread.Sleep(2000);
            ScrollToElement(homePage.SelfdirectedFR);
            Thread.Sleep(2000);
            ClickAndNavigateBack(homePage.SelfdirectedFR);
            Thread.Sleep(2000);
            ScrollToElement(homePage.AdditionalresourcesFR);
            Thread.Sleep(2000);
            ClickAndNavigateBack(homePage.AdditionalresourcesFR);      
            Thread.Sleep(2000);
            ScrollToElement(lsoPage.LSODashboardFR);
            Thread.Sleep(2000);
            ClickAndNavigateBack(lsoPage.LSODashboardFR);
            Thread.Sleep(2000);
            ScrollToElement(homePage.WellnessFR);
            Thread.Sleep(2000);
            ClickAndNavigateBack(homePage.WellnessFR);         
            ClickAndNavigateBack(homePage.SearchFR);                      
            Thread.Sleep(1000);            
            homePage.ProfileFR.Click();
            homePage.LogoutFR.Click();
            driver.Quit();
        }
       

        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void LSOSearchFR(string LSOUsername, string LSOPassword, string url, string Search)
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
            homePage.UserName.SendKeys(LSOUsername);          
            homePage.Next.Click();          
            homePage.Password.SendKeys(LSOPassword);          
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
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
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
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
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
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.LSOUsername)
                                                                    && !string.IsNullOrEmpty(data.LSOPassword)
                                                                    && data.Url == "https://homeweb.ca/map")
                                                     .Skip(0);

            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.LSOUsername, loginData.LSOPassword, loginData.Url, loginData.Search);
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
