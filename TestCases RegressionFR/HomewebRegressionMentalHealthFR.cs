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

namespace Homeweb_3._0_Tests.TestCases_Regression
{
    [TestFixture]
    public class HomewebRegressionMentalHealthFR
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
            public string HWLogin1 { get; set; }
            public string HWPassword1 { get; set; }
            public string Url { get; set; }




        }

        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void MentalHealthFR(string HWLogin1, string HWPassword1, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new HomewebRegressionObjectsFR();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(HWLogin1);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword1);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            ClickAndNavigate(RegObj.Mental);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Mentalhealth10steps);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Mentalhealth10steps);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.MentalExperincingDep);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.MentalExperincingDep);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Mentalchildrenandyouth);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalchildrenandyouth);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalchildrenandyouth1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalchildrenandyouth1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalchildrenandyouth2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalchildrenandyouth2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalcyberbully);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalcyberbully);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalcyberbully1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalcyberbully1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalcyberbully2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalcyberbully2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalcopingwith);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalcopingwith);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalcopingwith1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalcopingwith1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalcopingwithdep);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalcopingwithdep);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalcovid19);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalcovid19);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalcovid191);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalcovid191);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalcreatingafuture);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalcreatingafuture);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaldatingwhile);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentaldatingwhile);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaldealingwith);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentaldealingwith);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaldevelopingresiliency);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentaldevelopingresiliency);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalembracingdifferent);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalembracingdifferent);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalembracingdifferent1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalembracingdifferent1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalembracingdifferent2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalembracingdifferent2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalforest);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalforest);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalgrief);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalgrief);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalgriefworkplace);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalgriefworkplace);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalmaid);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalmaid);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);

            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.LogoutFR.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void MentalHealthFR1(string HWLogin1, string HWPassword1, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new HomewebRegressionObjectsFR();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(HWLogin1);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword1);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            ClickAndNavigate(RegObj.Mental);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Mentalhealingwounds);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Mentalhealingwounds);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalhealingwounds1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalhealingwounds1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.MentalHealthy);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.MentalHealthy);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.MentalHoliday);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.MentalHoliday);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.MentalHowtakingcare);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.MentalHowtakingcare);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalhowto);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalhowto);
            Thread.Sleep(1000);
            driver.Navigate().Back();
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalhowincrease);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalhowincrease);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            driver.Navigate().Back();
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalindigineouspeople);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalindigineouspeople);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalindigineouspeople1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalindigineouspeople1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalindigineouspeople2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalindigineouspeople2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalinfertility);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalinfertility);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalinterconnections);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalinterconnections);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalintimate);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalintimate);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.MentalCBT);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.MentalCBT);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.MentalCBT1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.MentalCBT1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.MentalMaintaining);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.MentalMaintaining);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            driver.Navigate().Back();
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalhealthcheckup);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalhealthcheckup);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalmodernworkplace1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalmodernworkplace1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalmodernworkplace2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalmodernworkplace2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalmoralinjury);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalmoralinjury);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalmoving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalmoving);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            driver.Navigate().Back();
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalmywellness);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalmywellness);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalmywellness1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalmywellness1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);

            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.LogoutFR.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void MentalHealthFR2(string HWLogin1, string HWPassword1, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new HomewebRegressionObjectsFR();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(HWLogin1);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword1);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            ClickAndNavigate(RegObj.Mental);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Mentalnavigating);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Mentalnavigating);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            driver.Navigate().Back();
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalnavigatingsupport);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalnavigatingsupport);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Mentalnavigatingpanic);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalnavigatingpanic);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalnavigatingpanic1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalnavigatingpanic1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalovercoming);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalovercoming);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalovercomingwinter);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalovercomingwinter);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalpostpartem);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalpostpartem);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalraising);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalraising);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalreducingmental);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalreducingmental);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalresponsibleoptimism);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalresponsibleoptimism);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalsecondary);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalsecondary);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalsexualabuse);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalsexualabuse);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalsexualabuse1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalsexualabuse1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalsexualysfunction);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalsexualysfunction);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalspotting);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalspotting);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalstaying);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalstaying);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalstigma);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalstigma);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalstress);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalstress);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalstressfinding1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalstressfinding1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalstressfinding2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalstressfinding2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalstressfinding3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalstressfinding3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalsuicideprevention);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalsuicideprevention);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalsupportingillness);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalsupportingillness);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.LogoutFR.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void MentalHealthFR3(string HWLogin1, string HWPassword1, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new HomewebRegressionObjectsFR();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(HWLogin1);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword1);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            ClickAndNavigate(RegObj.Mental);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Mentalsupportingholidays);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Mentalsupportingholidays);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalsurviving);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalsurviving);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            driver.Navigate().Back();
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Mentaltakingchargestress);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentaltakingchargestress);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltakingcontrolanger);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentaltakingcontrolanger);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltakingcontrolmood);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentaltakingcontrolmood);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltalkingtokids);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentaltalkingtokids);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaldangerssocial);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentaldangerssocial);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalimpactof);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalimpactof);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalimpactof1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalimpactof1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalintersectio1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalintersectio1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalintersectio2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalintersectio2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalmanyfaces);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalmanyfaces);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalptsd);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalptsd);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalweightofwinter);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalweightofwinter);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalweightofwinter1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalweightofwinter1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Mentaltoomuchscreen);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentaltoomuchscreen);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltoomuchscreen1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentaltoomuchscreen1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltrauma);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentaltrauma);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltrauma1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentaltrauma1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalunderstandingdepression);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalunderstandingdepression);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalunderstandingeating);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalunderstandingeating);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalunderstandingeating1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalunderstandingeating1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalunderstandingeating2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalunderstandingeating2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.LogoutFR.Click();

            // Quit the driver
            driver.Quit();
        }
        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void MentalHealthFR4(string HWLogin1, string HWPassword1, string Url)
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            var RegObj = new HomewebRegressionObjectsFR();
            PageFactory.InitElements(driver, RegObj);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Login process

            wait.Until(d => homePage.Login.Displayed);
            homePage.Login.Click();

            homePage.UserName.SendKeys(HWLogin1);

            homePage.Next.Click();

            homePage.Password.SendKeys(HWPassword1);

            homePage.Submit.Submit();

            Thread.Sleep(2000);
            ClickAndNavigate(homePage.Browse);
            Thread.Sleep(1000);
            ScrollToElement(homePage.LanChange);
            Thread.Sleep(1000);

            homePage.LanChange.Click();
            ClickAndNavigate(RegObj.Mental);
            Thread.Sleep(2000);
            ScrollToElement(RegObj.Mentalunderstandingmental);
            Thread.Sleep(2000);
            ClickAndNavigate(RegObj.Mentalunderstandingmental);
            Thread.Sleep(2000);

            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalunderstandingchronic1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalunderstandingchronic1);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Mentalunderstandingchronic2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalunderstandingchronic2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalunderstandingchronic3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalunderstandingchronic3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalwebinar1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalwebinar1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalwebinar2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalwebinar2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalwebinar3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalwebinar3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalwebinar4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalwebinar4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalwebinar5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalwebinar5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalwhatis);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalwhatis);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalwhensomeone);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalwhensomeone);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalwhennextceleb);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalwhennextceleb);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalwhenyoufear);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalwhenyoufear);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalwhenyoufear1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalwhenyoufear1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);

            ScrollToElement(RegObj.Mentalwomenhealth1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalwomenhealth1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalwomenhealth2);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalwomenhealth2);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalwomenhealth3);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalwomenhealth3);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalwomenhealth4);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalwomenhealth4);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalwomenhealth5);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalwomenhealth5);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalwomenhealth6);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalwomenhealth6);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalwomenhealth7);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalwomenhealth7);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentalyouthteen);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalyouthteen);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            ScrollToElement(RegObj.Mentalyouthteen1);
            Thread.Sleep(1000);

            ClickAndNavigate(RegObj.Mentalyouthteen1);
            Thread.Sleep(1000);
            ScrollToElement(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ClickAndNavigate(RegObj.Mentaltag);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ProfileFR);
            Thread.Sleep(1000);
            // Profile and Logout
            ClickAndNavigate(homePage.ProfileFR);

            homePage.Logout.Click();

            // Quit the driver
            driver.Quit();
        }




        private void ClickAndNavigate(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            element.Click();
        }
        private void ClickAndNavigateBack(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => element.Displayed);
            element.Click();
            driver.Navigate().Back();
        }
        private void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        private void SwitchToNewTab()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(d => driver.WindowHandles.Count > 1);
            var newTab = driver.WindowHandles.Last();
            driver.SwitchTo().Window(newTab);
        }
        public static IEnumerable<TestCaseData> LoginJsonData()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.HWLogin1)
                                                        && !string.IsNullOrEmpty(data.HWPassword1)
                                                        && data.Url == "https://homeweb.ca");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.HWLogin1, loginData.HWPassword1, loginData.Url);
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
    }
}
