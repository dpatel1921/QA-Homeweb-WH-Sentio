using AventStack.ExtentReports;
using Homeweb_3._0_Tests.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Homeweb_3._0_Tests.TestCases
{
    [TestFixture]
    public class PathfinderAssessment
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
          //  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
        }

        public class TestCaseJsonData
        {
            public string PFLogin { get; set; }
            public string PFPassword { get; set; }
            public string Url { get; set; }
            public string PFLogin1 { get; set; }
            public string PFLogin2 { get; set; }

        }
        [Test, TestCaseSource(nameof(LoginJsonData)), Order(1)]
        public void Booking(string PFLogin, string PFPassword, string Url)
        {
            try
            {
                // Navigate to the provided URL
                driver.Navigate().GoToUrl(Url);
                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                // Login process
                Assert.IsNotNull(homePage.Login, "Login button is not found.");
                Wait(1000);
                homePage.Login.Click();

                Assert.IsNotNull(homePage.UserName, "Username field is not found.");
                Wait(1000);
                homePage.UserName.SendKeys(PFLogin);

                Assert.IsNotNull(homePage.Next, "Next button is not found.");
                homePage.Next.Click();

                Assert.IsNotNull(homePage.Password, "Password field is not found.");
                Wait(1000);
                homePage.Password.SendKeys(PFPassword);

                Assert.IsNotNull(homePage.Submit, "Submit button is not found.");
                homePage.Submit.Submit();

                Wait(2000);

                TryClick(homePage.Pathfinder);
                Wait(1000);
                TryClick(homePage.Problemissue);
                Wait(1000);
                TryClick(homePage.Problemissue1);
                Wait(1000);
                TryClick(homePage.PFAssessment); 
                Wait(1000);
                TryClick(homePage.PFAssessment1);
                Wait(1000);
                TryClick(homePage.PFAssessment2);
                Wait(1000);
                TryClick(homePage.PFAssessment3);
                Wait(1000);
                TryClick(homePage.PFAssessment4);
                Wait(1000);


                TryClick(homePage.PFAssessmentbutton);
                TryClick(homePage.Star);
                Wait(2000);
                ScrollToElement(homePage.Next);
                Wait(1000);
                TryClick(homePage.Next);
                Wait(3000);
                TryClick(homePage.EmailNext);
                Wait(2000);
                TryClick(homePage.Meetnow);
                Wait(2000);
                TryClick(homePage.SelectDate);
                Wait(2000);
                TryClick(homePage.SelectTime);
                Wait(2000);
                var Model = driver.FindElement(By.XPath("//SELECT[@id='appointmentModality']"));
                new SelectElement(Model).SelectByText("Phone");
                TryClick(homePage.SelectMode);
                Wait(2000);
                TryClick(homePage.SelectYes);
                Wait(2000);
                TryClick(homePage.SelectText);
                Wait(2000);
                TryClick(homePage.SelectCheck);
                Wait(2000);
                TryClick(homePage.SelectNext);
                Wait(2000);
                TryClick(homePage.SelectDashboard);
                Wait(2000);
                homePage.Profile.Click();
                Wait(2000);
                homePage.Logout.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed with exception: {ex.Message}");
            }
        }
       
        [Test, TestCaseSource(nameof(LoginJsonData)), Order(2)]
        public void Cancel(string PFLogin, string PFPassword, string Url)
        {
            try
            {
                // Navigate to the provided URL
                driver.Navigate().GoToUrl(Url);
                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                // Login process
                Assert.IsNotNull(homePage.Login, "Login button is not found.");
                Wait(1000);
                homePage.Login.Click();

                Assert.IsNotNull(homePage.UserName, "Username field is not found.");
                homePage.UserName.SendKeys(PFLogin);

                Assert.IsNotNull(homePage.Next, "Next button is not found.");
                homePage.Next.Click();

                Assert.IsNotNull(homePage.Password, "Password field is not found.");
                Wait(1000);
                homePage.Password.SendKeys(PFPassword);

                Assert.IsNotNull(homePage.Submit, "Submit button is not found.");
                homePage.Submit.Submit();
                Wait(2000);
                TryClick(homePage.Cancel);
                Wait(2000);
                TryClick(homePage.CancelYes);
                Wait(2000);
                TryClick(homePage.SelectDashboard);
                Wait(2000);
                homePage.Profile.Click();
                Wait(2000);
                homePage.Logout.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed with exception: {ex.Message}");
            }
        }


        [Test, TestCaseSource(nameof(LoginJsonData)), Order(3)]
        public void EndServices(string PFLogin, string PFPassword, string Url)
        {
            try
            {
                // Navigate to the provided URL
                driver.Navigate().GoToUrl(Url);
                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                // Login process
                Assert.IsNotNull(homePage.Login, "Login button is not found.");
                Wait(1000);
                homePage.Login.Click();

                Assert.IsNotNull(homePage.UserName, "Username field is not found.");
                homePage.UserName.SendKeys(PFLogin);

                Assert.IsNotNull(homePage.Next, "Next button is not found.");
                homePage.Next.Click();

                Assert.IsNotNull(homePage.Password, "Password field is not found.");
                Wait(1000);
                homePage.Password.SendKeys(PFPassword);

                Assert.IsNotNull(homePage.Submit, "Submit button is not found.");
                homePage.Submit.Submit();
                ScrollToElement(homePage.EndServices);
                Wait(1000);
                TryClick(homePage.EndServices);
                Wait(2000);
                ScrollToElement(homePage.YesDone);
                Wait(1000);
                TryClick(homePage.YesDone);
                Wait(2000);
                TryClick(homePage.YesEnd);
                Wait(2000);                               
                TryClick(homePage.Reason);
                Wait(2000);
                TryClick(homePage.SelectDashboard);
                Wait(2000);
                homePage.Profile.Click();
                Wait(2000);
                homePage.Logout.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed with exception: {ex.Message}");
            }
        }
        [Test, TestCaseSource(nameof(LoginJsonData1)), Order(4)]
        public void Booking1(string PFLogin1, string PFPassword, string Url)
        {
            try
            {
                // Navigate to the provided URL
                driver.Navigate().GoToUrl(Url);
                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                // Login process
                Assert.IsNotNull(homePage.Login, "Login button is not found.");
                Wait(1000);
                homePage.Login.Click();

                Assert.IsNotNull(homePage.UserName, "Username field is not found.");
                homePage.UserName.SendKeys(PFLogin1);

                Assert.IsNotNull(homePage.Next, "Next button is not found.");
                Wait(1000);
                homePage.Next.Click();

                Assert.IsNotNull(homePage.Password, "Password field is not found.");
                Wait(1000);
                homePage.Password.SendKeys(PFPassword);

                Assert.IsNotNull(homePage.Submit, "Submit button is not found.");
                homePage.Submit.Submit();

                Wait(2000);

                TryClick(homePage.Pathfinder);
                Wait(1000);
                TryClick(homePage.Problemissue);
                Wait(1000);
                TryClick(homePage.Problemissue1);
                Wait(1000);
                TryClick(homePage.PFAssessment);
                Wait(1000);
                TryClick(homePage.PFAssessment1);
                Wait(1000);
                TryClick(homePage.PFAssessment2);
                Wait(1000);
                TryClick(homePage.PFAssessment3);
                Wait(1000);
                TryClick(homePage.PFAssessment4);
                Wait(1000);


                TryClick(homePage.PFAssessmentbutton);
                TryClick(homePage.Star);
                Wait(2000);
                ScrollToElement(homePage.Next);
                Wait(1000);
                TryClick(homePage.Next);
                Wait(3000);
                TryClick(homePage.EmailNext);
                Wait(2000);
                TryClick(homePage.Meetnow);
                Wait(2000);
                TryClick(homePage.SelectDate);
                Wait(2000);
                TryClick(homePage.SelectTime);
                Wait(2000);
                var Model = driver.FindElement(By.XPath("//SELECT[@id='appointmentModality']"));
                new SelectElement(Model).SelectByText("Phone");
                TryClick(homePage.SelectMode);
                Wait(2000);
                TryClick(homePage.SelectYes);
                Wait(2000);
                TryClick(homePage.SelectText);
                Wait(2000);
                TryClick(homePage.SelectCheck);
                Wait(2000);
                TryClick(homePage.SelectNext);
                Wait(2000);
                TryClick(homePage.SelectDashboard);
                Wait(2000);
                homePage.Profile.Click();
                Wait(2000);
                homePage.Logout.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed with exception: {ex.Message}");
            }
        }

        [Test, TestCaseSource(nameof(LoginJsonData1)), Order(5)]
        public void Cancel1(string PFLogin1, string PFPassword, string Url)
        {
            try
            {
                // Navigate to the provided URL
                driver.Navigate().GoToUrl(Url);
                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                // Login process
                Assert.IsNotNull(homePage.Login, "Login button is not found.");
                Wait(1000);
                homePage.Login.Click();

                Assert.IsNotNull(homePage.UserName, "Username field is not found.");
                homePage.UserName.SendKeys(PFLogin1);

                Assert.IsNotNull(homePage.Next, "Next button is not found.");
                homePage.Next.Click();

                Assert.IsNotNull(homePage.Password, "Password field is not found.");
                Wait(1000);
                homePage.Password.SendKeys(PFPassword);

                Assert.IsNotNull(homePage.Submit, "Submit button is not found.");
                homePage.Submit.Submit();
                Wait(2000);
                TryClick(homePage.Cancel);
                Wait(2000);
                TryClick(homePage.CancelYes);
                Wait(2000);
                TryClick(homePage.SelectDashboard);
                Wait(2000);
                homePage.Profile.Click();
                Wait(2000);
                homePage.Logout.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed with exception: {ex.Message}");
            }
        }


        [Test, TestCaseSource(nameof(LoginJsonData1)), Order(6)]
        public void EndServices1(string PFLogin1, string PFPassword, string Url)
        {
            try
            {
                // Navigate to the provided URL
                driver.Navigate().GoToUrl(Url);
                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                // Login process
                Assert.IsNotNull(homePage.Login, "Login button is not found.");
                Wait(1000);
                homePage.Login.Click();

                Assert.IsNotNull(homePage.UserName, "Username field is not found.");
                homePage.UserName.SendKeys(PFLogin1);

                Assert.IsNotNull(homePage.Next, "Next button is not found.");
                homePage.Next.Click();

                Assert.IsNotNull(homePage.Password, "Password field is not found.");
                Wait(1000);
                homePage.Password.SendKeys(PFPassword);

                Assert.IsNotNull(homePage.Submit, "Submit button is not found.");
                homePage.Submit.Submit();
                ScrollToElement(homePage.EndServices);
                Wait(1000);
                TryClick(homePage.EndServices);
                Wait(2000);
                ScrollToElement(homePage.YesDone);
                Wait(1000);
                TryClick(homePage.YesDone);
                Wait(2000);
                TryClick(homePage.YesEnd);
                Wait(2000);
                TryClick(homePage.Reason);
                Wait(2000);
                TryClick(homePage.SelectDashboard);
                Wait(2000);
                homePage.Profile.Click();
                Wait(2000);
                homePage.Logout.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed with exception: {ex.Message}");
            }
        }
        [Test, TestCaseSource(nameof(LoginJsonData2)), Order(7)]
        public void Booking2(string PFLogin2, string PFPassword, string Url)
        {
            try
            {
                // Navigate to the provided URL
                driver.Navigate().GoToUrl(Url);
                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                // Login process
                Assert.IsNotNull(homePage.Login, "Login button is not found.");
                Wait(1000);
                homePage.Login.Click();

                Assert.IsNotNull(homePage.UserName, "Username field is not found.");
                Wait(1000);
                homePage.UserName.SendKeys(PFLogin2);

                Assert.IsNotNull(homePage.Next, "Next button is not found.");
                homePage.Next.Click();

                Assert.IsNotNull(homePage.Password, "Password field is not found.");
                Wait(1000);
                homePage.Password.SendKeys(PFPassword);

                Assert.IsNotNull(homePage.Submit, "Submit button is not found.");
                homePage.Submit.Submit();

                Wait(2000);

                TryClick(homePage.Pathfinder);
                Wait(1000);
                TryClick(homePage.Problemissue);
                Wait(1000);
                TryClick(homePage.Problemissue1);
                Wait(1000);
                TryClick(homePage.PFAssessment);
                Wait(1000);
                TryClick(homePage.PFAssessment1);
                Wait(1000);
                TryClick(homePage.PFAssessment2);
                Wait(1000);
                TryClick(homePage.PFAssessment3);
                Wait(1000);
                TryClick(homePage.PFAssessment4);
                Wait(1000);


                TryClick(homePage.PFAssessmentbutton);
                TryClick(homePage.Star);
                Wait(2000);
                ScrollToElement(homePage.Next);
                Wait(1000);
                TryClick(homePage.Next);
                Wait(3000);
                TryClick(homePage.EmailNext);
                Wait(2000);
                TryClick(homePage.Meetnow);
                Wait(2000);
                TryClick(homePage.SelectDate);
                Wait(2000);
                TryClick(homePage.SelectTime);
                Wait(2000);
                var Model = driver.FindElement(By.XPath("//SELECT[@id='appointmentModality']"));
                new SelectElement(Model).SelectByText("Phone");
                TryClick(homePage.SelectMode);
                Wait(2000);
                TryClick(homePage.SelectYes);
                Wait(2000);
                TryClick(homePage.SelectText);
                Wait(2000);
                TryClick(homePage.SelectCheck);
                Wait(2000);
                TryClick(homePage.SelectNext);
                Wait(2000);
                TryClick(homePage.SelectDashboard);
                Wait(2000);
                homePage.Profile.Click();
                Wait(2000);
                homePage.Logout.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed with exception: {ex.Message}");
            }
        }

        [Test, TestCaseSource(nameof(LoginJsonData2)), Order(8)]
        public void Cancel2(string PFLogin2, string PFPassword, string Url)
        {
            try
            {
                // Navigate to the provided URL
                driver.Navigate().GoToUrl(Url);
                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                // Login process
                Assert.IsNotNull(homePage.Login, "Login button is not found.");
                Wait(1000);
                homePage.Login.Click();

                Assert.IsNotNull(homePage.UserName, "Username field is not found.");
                homePage.UserName.SendKeys(PFLogin2);

                Assert.IsNotNull(homePage.Next, "Next button is not found.");
                homePage.Next.Click();

                Assert.IsNotNull(homePage.Password, "Password field is not found.");
                Wait(1000);
                homePage.Password.SendKeys(PFPassword);

                Assert.IsNotNull(homePage.Submit, "Submit button is not found.");
                homePage.Submit.Submit();
                Wait(2000);
                TryClick(homePage.Cancel);
                Wait(2000);
                TryClick(homePage.CancelYes);
                Wait(2000);
                TryClick(homePage.SelectDashboard);
                Wait(2000);
                homePage.Profile.Click();
                Wait(2000);
                homePage.Logout.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed with exception: {ex.Message}");
            }
        }


        [Test, TestCaseSource(nameof(LoginJsonData2)), Order(9)]
        public void EndServices2(string PFLogin2, string PFPassword, string Url)
        {
            try
            {
                // Navigate to the provided URL
                driver.Navigate().GoToUrl(Url);
                var homePage = new HomewebLoginObjects();
                PageFactory.InitElements(driver, homePage);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                // Login process
                Assert.IsNotNull(homePage.Login, "Login button is not found.");
                Wait(1000);
                homePage.Login.Click();

                Assert.IsNotNull(homePage.UserName, "Username field is not found.");
                homePage.UserName.SendKeys(PFLogin2);

                Assert.IsNotNull(homePage.Next, "Next button is not found.");
                homePage.Next.Click();

                Assert.IsNotNull(homePage.Password, "Password field is not found.");
                Wait(1000);
                homePage.Password.SendKeys(PFPassword);

                Assert.IsNotNull(homePage.Submit, "Submit button is not found.");
                homePage.Submit.Submit();
                ScrollToElement(homePage.EndServices);
                Wait(1000);
                TryClick(homePage.EndServices);
                Wait(2000);
                ScrollToElement(homePage.YesDone);
                Wait(1000);
                TryClick(homePage.YesDone);
                Wait(2000);
                TryClick(homePage.YesEnd);
                Wait(2000);
                TryClick(homePage.Reason);
                Wait(2000);
                TryClick(homePage.SelectDashboard);
                Wait(2000);
                homePage.Profile.Click();
                Wait(2000);
                homePage.Logout.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed with exception: {ex.Message}");
            }
        }


        public static void SafeAssert(Action assertion)
        {
            try
            {
                assertion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  // Log the error message but continue execution
            }
        }

        public static IEnumerable<TestCaseData> LoginJsonData()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\source\\repos\\QA-Homeweb-Automation-3.0\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.PFLogin)
                                                        && !string.IsNullOrEmpty(data.PFPassword)
                                                        && data.Url == "https://homeweb.ca");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.PFLogin, loginData.PFPassword, loginData.Url);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData1()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\source\\repos\\QA-Homeweb-Automation-3.0\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.PFLogin1)
                                                        && !string.IsNullOrEmpty(data.PFPassword)
                                                        && data.Url == "https://homeweb.ca");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.PFLogin1, loginData.PFPassword, loginData.Url);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData2()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\source\\repos\\QA-Homeweb-Automation-3.0\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.PFLogin2)
                                                        && !string.IsNullOrEmpty(data.PFPassword)
                                                        && data.Url == "https://homeweb.ca");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.PFLogin2, loginData.PFPassword, loginData.Url);
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


        private void TryClick(IWebElement element)
        {
            try
            {
                element.Click();
            }
            catch (NoSuchElementException)
            {
                // Element not found, do nothing
            }
        }

        private void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        private void Wait(int milliseconds)
        {
            System.Threading.Thread.Sleep(milliseconds);
        }
        private void TakeScreenshot(string filePath)
        {
            ITakesScreenshot ssd = driver as ITakesScreenshot;
            Screenshot ss = ssd.GetScreenshot();
            ss.SaveAsFile(filePath + time.ToString("yy_dd_h_mm_ss") + ".png");
        }
    }




}

