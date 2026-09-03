#pragma warning disable NUnit1032  // “field driver should be Disposed in a [TearDown]”
/*using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Diagnostics;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using Helpers;
using WarriorHealthBeta.Objects;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework.Interfaces;

namespace WarriorHealthBeta.TestCases
{
    public class AuthenticatedTestBase
    {
        public IWebDriver driver;
        public WebDriverWait Wait;
        public TestConfig Config;
        public WarriorHealthAdminObjects WH;
        public WarriorHealthAdminObjectsFR WHFR;
        public ExtentReports extent;
        public ExtentTest test;
        private DateTime time = DateTime.Now;


        [OneTimeSetUp]


        public void OneTimeSetup()
        {
            extent = ExtentManager.GetReporter();
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            var jsonPath = @"C:\Users\dpatel\Source\repos\WarriorHealthBeta\TestData\TestDataAdmin.Json";
            if (!File.Exists(jsonPath))
                throw new FileNotFoundException($"Missing config file: {jsonPath}");


            var json = File.ReadAllText(jsonPath);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var configs = JsonSerializer.Deserialize<List<TestConfig>>(json, options)
                          ?? throw new Exception("No entries in TestDataAdmin.Json");


            Config = configs.First(c => c.Url.Contains("stgadmin"));

        

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            WH = new WarriorHealthAdminObjects();
            PageFactory.InitElements(driver, WH);

            WHFR = new WarriorHealthAdminObjectsFR();
            PageFactory.InitElements(driver, WHFR);

            driver.Navigate().GoToUrl(Config.Url);
            WH.EmailInput.SendKeys(Config.Email);
            WH.Emailbutton.Click();

            Wait.Until(ExpectedConditions.ElementIsVisible(
                By.Id("verificationCode")
            ));

         
            string otp = null;
            var sw = Stopwatch.StartNew();
            while (sw.Elapsed < TimeSpan.FromSeconds(120) && otp == null)
            {
                otp = Email2FA.GetVerificationCodeFromEmail(
                    Config.Email,
                    Config.AppPassword,
                    Config.SubjectKeyword
                );
                if (otp == null) Thread.Sleep(2_000);
            }
            if (otp == null)
                throw new Exception("Failed to retrieve OTP within timeout");

        
            WH.Verificationcode.SendKeys(otp);
            WH.Loginbutton.Click();

           
          
        }
        
        [TearDown]
        public void AfterEachTest()
        {
          
            if (extent == null || test == null || driver == null)
                return;

            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stack = TestContext.CurrentContext.Result.StackTrace;
            var msg = TestContext.CurrentContext.Result.Message;

            var logStatus = status switch
            {
                TestStatus.Passed => Status.Pass,
                TestStatus.Failed => Status.Fail,
                TestStatus.Skipped => Status.Skip,
                _ => Status.Warning
            };

            test.Log(logStatus, $"Test {logStatus}");
            if (status == TestStatus.Failed)
            {
                test.Log(Status.Fail, msg);
                if (!string.IsNullOrEmpty(stack))
                    test.Log(Status.Fail, stack);

                var screenshot = ((ITakesScreenshot)driver)
                    .GetScreenshot()
                    .AsBase64EncodedString;
                test.AddScreenCaptureFromBase64String(screenshot, "Failure Screenshot");
            }
           

        }

        [OneTimeTearDown]
        public void OneTimeTeardown()
        {
            extent.Flush();

            driver.Quit();

        }
        public void ClickAndSwitchNewTab(IWebElement element)
        {
            ClickAndNavigate(element);
            SwitchToNewTab();
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }
        public void SwitchToNewTab()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(d => driver.WindowHandles.Count > 1);
            var newTab = driver.WindowHandles.Last();
            driver.SwitchTo().Window(newTab);
        }
        public void ClickAndNavigate(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => element.Displayed);
            element.Click();
        }
        public void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
    }
}*/
