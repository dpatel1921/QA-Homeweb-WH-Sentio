/*using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Helpers;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Diagnostics;

namespace WarriorHealth
{
    public class WarriorHealthAdminSmokeTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void LoginAndVerify2FAEmailOTP()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            driver.Navigate().GoToUrl("https://stgadmin.warriorhealth.ca/en/login");

           
            driver.FindElement(By.Id("emailAddress")).SendKeys("warriorhealth58@gmail.com");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

         
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("verificationCode")));

         
            string otp = null;
            var sw = Stopwatch.StartNew();
            while (sw.Elapsed < TimeSpan.FromSeconds(60) && otp == null)
            {
                otp = Email2FA.GetVerificationCodeFromEmail(
                    "warriorhealth58@gmail.com",
                    "vndjfensmnwdlqet",   
                    "Warrior Health - Verification Code"
                );
                if (otp == null)
                    Thread.Sleep(2_000);
            }
            Assert.IsNotNull(otp, "Timed out waiting for OTP in email.");

        
            driver.FindElement(By.Id("verificationCode")).SendKeys(otp);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            wait.Until(ExpectedConditions.UrlContains("dashboard"));
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
   

}*/

