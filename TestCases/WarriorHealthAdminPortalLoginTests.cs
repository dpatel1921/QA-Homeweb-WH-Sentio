using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using WarriorHealthBeta.Objects; 

namespace WarriorHealthBeta.TestCases
{
    [TestFixture]
    public class WarriorHealthAdminPortalLoginTests
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private WarriorHealthAdminObjects WH;

        private const string Url = "https://stgadmin.warriorhealth.ca/en/login";
       

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            WH = new WarriorHealthAdminObjects();
            PageFactory.InitElements(driver, WH);

            driver.Navigate().GoToUrl(Url);
          
          
        }
        protected bool IsElementDisplayed(By locator)
        {
            return driver
                .FindElements(locator)    
                .Any(e => e.Displayed);   
        }

        [Test]
        public void LoginPage_Header()
        {

            WH.Logo.Click();
            Thread.Sleep(1000);
            WH.EnrollmentsLan.Click();
            Thread.Sleep(1000);
            WH.EnrollmentsLanEN.Click();
            Thread.Sleep(1000);


        }

        [Test]
        public void Login_IntialState()
        {
            ClickAndSwitchNewTab(WH.Sidebar7);
            Thread.Sleep(1000);
            ClickAndSwitchNewTab(WH.Sidebar8);
            Thread.Sleep(1000);
            ClickAndSwitchNewTab(WH.Sidebar9);
            Thread.Sleep(1000);
            ClickAndSwitchNewTab(WH.Sidebar10);
            Thread.Sleep(1000);
            ClickAndSwitchNewTab(WH.Sidebar11);
            Thread.Sleep(1000);
            ClickAndSwitchNewTab(WH.Sidebar12);
            Thread.Sleep(1000);
            ClickAndSwitchNewTab(WH.Enroll);
            Thread.Sleep(1000);

        }

        [Test]
        public void Login_Invalid()
        {

            WH.EmailInput.SendKeys("Test@demo.com");
            Thread.Sleep(1000);
            WH.Emailbutton.Click();
            Thread.Sleep(1000);

            var bannerLocator = By.XPath("//div[@class='alert-message']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");
        }

        [Test]
        public void Login_Invalid1()
        {

            WH.EmailInput.SendKeys("dpatel@homewoodhealth.com");
            Thread.Sleep(1000);
            WH.Emailbutton.Click();
            Thread.Sleep(1000);
            WH.Verificationcode.SendKeys("000000");
            Thread.Sleep(1000);
            WH.Loginbutton.Click();

            var bannerLocator = By.XPath("//div[@class='alert-message']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Error appearing on page");
        }


        [Test]
        public void Login_StartOver()
        {
            WH.EmailInput.SendKeys("dpatel@homewoodhealth.com");
            Thread.Sleep(1000);
            WH.Emailbutton.Click();
            Thread.Sleep(1000);
            WH.StartOver.Click();
            Thread.Sleep(1000);

            var buttonlocator = By.XPath("//button[@type='submit']");
            Assert.IsTrue(
                IsElementDisplayed(buttonlocator),
                "Error appearing on page");
        }

        [Test]
        public void Login_NoCode()
        {
            WH.EmailInput.SendKeys("dpatel@homewoodhealth.com");
            Thread.Sleep(1000);
            WH.Emailbutton.Click();
            Thread.Sleep(1000);
            WH.NoCode.Click();
            Thread.Sleep(1000);

            var buttonlocator = By.XPath("//button[@type='submit']");
            Assert.IsTrue(
                IsElementDisplayed(buttonlocator),
                "Error appearing on page");
        }

        

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
                driver.Quit();
            driver.Dispose();
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
    }
}
