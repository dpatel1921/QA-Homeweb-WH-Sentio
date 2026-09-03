/*using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System.Text.Json;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using AutoItX3Lib;
using System.Collections.Generic;
using NUnit.Framework.Internal;
using AventStack.ExtentReports;
using System.Security.Policy;
using System.Diagnostics;
using SeleniumExtras.WaitHelpers;
using System.Data;
using WarriorHealthBeta.Objects;


namespace WarriorHealthBeta.TestCases
{
    [TestFixture]
    public class WarriorHealthSmokeTestsFR
    {
        private IWebDriver driver;
        AutoItX3 au3 = new AutoItX3();
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
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);

            var options = new ChromeOptions();
            options.AddArgument("start-maximized");
            driver = new ChromeDriver(options);

            driver.Manage().Window.Maximize();
        }
        public class TestCaseJsonData
        {
            public string Login { get; set; }
            public string Password { get; set; }
            public string Url { get; set; }
            public string Invalid { get; set; }
            public string Valid { get; set; }
            public string Search1 { get; set; }
            public string Search2 { get; set; }
            public string Search3 { get; set; }
            public string OrgName { get; set; }
            public string RepName { get; set; }
            public string RepTitle { get; set; }
            public string RepEmail { get; set; }
            public string RepPhone { get; set; }
            public string City { get; set; }
            public string Province { get; set; }
            public string Valid1 { get; set; }
            public string RepLastName { get; set; }
            public string AddressLine { get; set; }
            public string PostalCode { get; set; }
        }
        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void LoginValidationFR(string Login, string Password, string Url)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var homePage = new WarriorHealthObjectsFR();
            PageFactory.InitElements(driver, homePage);
            string username = Login;
            string password = Password;

            string url = $"https://{username}:{password}@staging.warriorhealth.ca/en";
            driver.Navigate().GoToUrl(url);
            TakeScreenshot("C:\\TestData\\WarriorHealth\\Login_");
            driver.Close();

        }
        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void SmokeHeaderFR(string Login, string Password, string Url)
        {
            NavigateWithCredentials(Login, Password);
            var home = new WarriorHealthObjectsFR();
            PageFactory.InitElements(driver, home);



            ScrollAndClick(home.Toggle);
            ScrollAndClick(home.WHlogo);
            Thread.Sleep(5000);
            ScrollAndClick(home.ChatBox);
          
            ScrollAndClick(home.Home);
            ScrollAndClick(home.Browse);
            ScrollAndClick(home.Assessments);
            ScrollAndClick(home.Search);
            ScrollAndClick(home.FAQ);
            ScrollAndClick(home.AboutUs);
            ScrollAndClick(home.PSO);
          
            driver.Close();

        }
        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void SmokeFooterFR(string Login, string Password, string Url)
        {
            NavigateWithCredentials(Login, Password);
            var home = new WarriorHealthObjectsFR();
            PageFactory.InitElements(driver, home);
            ScrollAndClick(home.Toggle);
            ScrollAndClick(home.Footer1);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Footer2);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Footer3);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Footer4);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Footer5);
            ScrollAndClick(home.Home1);
            ClickAndSwitch(home.Footer6);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Footer7);
            ScrollAndClick(home.Home1);
            ClickAndSwitch(home.Footer9);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Footer10);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Footer11);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Footer12);
            ScrollAndClick(home.Home1);

            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");
           
            driver.Close();
        }

        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void SmokeHomeFR(string Login, string Password, string Url)
        {
            NavigateWithCredentials(Login, Password);
            var home = new WarriorHealthObjectsFR();
            PageFactory.InitElements(driver, home);
            ScrollAndClick(home.Toggle);
            ScrollAndClick(home.ForIndividuals);
            ScrollAndClick(home.ForFamilies);
            ScrollAndClick(home.ForOrgs);
            driver.Navigate().Back();

            ScrollAndClick(home.PeerSupport);
            driver.Navigate().Back();
            ScrollAndClick(home.CrisisSupport);
            driver.Navigate().Back();

            ScrollAndClick(home.Poweredby1);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Poweredby2);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Poweredby3);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Poweredby4);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Poweredby5);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Poweredby6);
            ScrollAndClick(home.Home1);

            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");
         
            driver.Close();

        }

        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void SmokePSPFR(string Login, string Password, string Url)
        {
            NavigateWithCredentials(Login, Password);
            var home = new WarriorHealthObjectsFR();
            PageFactory.InitElements(driver, home);
            ScrollAndClick(home.Toggle);
            ScrollAndClick(home.Home);
            ScrollAndClick(home.Coreservice);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.GetRecommendation);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPservice1);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPservice2);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPservice3);
            ScrollAndClick(home.Home1);

            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");
           
            driver.Close();

        }
        [Test, TestCaseSource(nameof(LoginJsonData1))]
        public void SmokePSPresourcesFR(string Login, string Password, string Url, string Invalid, string Valid, string Valid1)
        {
            NavigateWithCredentials(Login, Password);
            var home = new WarriorHealthObjectsFR();
            PageFactory.InitElements(driver, home);
            ScrollAndClick(home.Toggle);
            ScrollAndClick(home.Home);
            ScrollAndClick(home.PSPresource1);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPresource2);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPresource3);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPresource4);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPresource5);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPresource6);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPresource7);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPresource8);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPresource9);
            ScrollAndClick(home.Home1);

            ScrollAndClick(home.Searchitem);
            home.Searchitem.SendKeys(Invalid);
            home.Searchitem.Submit();
            ;

            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Searchitem);
            home.Searchitem.Clear();
            home.Searchitem.SendKeys(Valid1);
            home.Searchitem.Submit();


            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");
            driver.Close();

        }

        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void SmokePSPresourcesforfamiliesFR(string Login, string Password, string Url)
        {
            NavigateWithCredentials(Login, Password);
            var home = new WarriorHealthObjectsFR();
            PageFactory.InitElements(driver, home);
            ScrollAndClick(home.Toggle);
           // ScrollAndClick(home.PSPFamily1);
            //ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPFamily3);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPFamily4);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPFamily5);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPFamily6);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPFamily7);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPFamily8);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPFamily9);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPFamily10);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPFamily11);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.PSPFamily12);
            ScrollAndClick(home.Home1);

            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");
           
            driver.Close();

        }

        [Test, TestCaseSource(nameof(LoginJsonData1))]
        public void SmokeBrowseFR(string Login, string Password, string Url, string Invalid, string Valid,string Valid1)
        {
            NavigateWithCredentials(Login, Password);
            var home = new WarriorHealthObjectsFR();
            PageFactory.InitElements(driver, home);
            ScrollAndClick(home.Toggle);
            ScrollAndClick(home.Browse);
            ScrollAndClick(home.Browse2);
            ScrollAndClick(home.Browse);
            ScrollAndClick(home.Browse3);
            ScrollAndClick(home.Browse);
            ScrollAndClick(home.Browse4);
            ScrollAndClick(home.Browse);
            ScrollAndClick(home.Browse5);
            ScrollAndClick(home.Browse);
            ScrollAndClick(home.Browse7);
            ScrollAndClick(home.Browse);
            ScrollAndClick(home.Browse8);
            ScrollAndClick(home.Browse);
            ClickAndSwitch(home.Browse9);

            ScrollAndClick(home.Searchitem);
            home.Searchitem.SendKeys(Invalid);
            home.Searchitem.Submit();


            ScrollAndClick(home.Browse);
            ScrollAndClick(home.Searchitem);
            home.Searchitem.Clear();
            home.Searchitem.SendKeys(Valid1);
            home.Searchitem.Submit();


            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");
            driver.Close();


        }

        [Test, TestCaseSource(nameof(LoginJsonData))]
        public void SmokeSearchFR(string Login, string Password, string Url, string Invalid, string Valid,
            string Search1, string Search2, string Valid1, string Search3)
        {
            NavigateWithCredentials(Login, Password);
            var home = new WarriorHealthObjectsFR();
            PageFactory.InitElements(driver, home);
            ScrollAndClick(home.Toggle);

            ScrollAndClick(home.Search);
            ScrollAndClick(home.Searchitem);
            home.Searchitem.SendKeys(Invalid);
            home.Searchitem.Submit();


            ScrollAndClick(home.Searchitem);
            home.Searchitem.Clear();
            home.Searchitem.SendKeys(Valid1);
            home.Searchitem.Submit();


            ScrollAndClick(home.Search3);
            //ScrollAndClick(home.Search4);
            //ScrollAndClick(home.Search5);

            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");
            driver.Close();

        }

        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void SmokeAboutUsFR(string Login, string Password, string Url)
        {
            NavigateWithCredentials(Login, Password);
            var home = new WarriorHealthObjectsFR();
            PageFactory.InitElements(driver, home);
            ScrollAndClick(home.Toggle);

            ScrollAndClick(home.AboutUs);
            ScrollAndClick(home.WHlogo);
            ScrollAndClick(home.AboutUs);
            ScrollAndClick(home.Aboutus1);
            ScrollAndClick(home.AboutUs);
            ScrollAndClick(home.Aboutus2);
            ScrollAndClick(home.AboutUs);
            ScrollAndClick(home.Aboutus3);
            ScrollAndClick(home.AboutUs);
            ScrollAndClick(home.Aboutus4);
            ScrollAndClick(home.AboutUs);
            ScrollAndClick(home.Aboutus5);
            ScrollAndClick(home.AboutUs);
            ScrollAndClick(home.Aboutus6);

            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");
          
            driver.Close();

        }

        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void SmokeEnrollFR(string Login, string Password, string Url)
        {
            NavigateWithCredentials(Login, Password);
            var home = new WarriorHealthObjectsFR();
            PageFactory.InitElements(driver, home);
            Thread.Sleep(2000);
            home.Toggle.Click();
            Thread.Sleep(1000);
            ScrollToElement(home.ForOrgs);
            Thread.Sleep(1000);

            home.ForOrgs.Click();
            Thread.Sleep(2000);
            ScrollToElement(home.Enroll1);
            home.Enroll1.Click();
            Thread.Sleep(1000);
            driver.Navigate().Back();
            Thread.Sleep(1000);
            ScrollToElement(home.Enroll2);
            Thread.Sleep(2000);
            home.Enroll2.Click();
            Thread.Sleep(2000);
            var newTab1 = driver.WindowHandles.Last();
            driver.SwitchTo().Window(newTab1);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            ScrollToElement(home.Enroll3);
            Thread.Sleep(2000);
            home.Enroll3.Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            ScrollToElement(home.Enroll4);
            Thread.Sleep(2000);
            home.Enroll4.Click();
            Thread.Sleep(2000);
            var newTab = driver.WindowHandles.Last();
            driver.SwitchTo().Window(newTab);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            ScrollToElement(home.Enroll5);
            Thread.Sleep(2000);
            home.Enroll5.Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();

            ScrollToElement(home.Enroll6);
            Thread.Sleep(2000);
            home.Enroll6.Click();
            Thread.Sleep(2000);
            var newTab2 = driver.WindowHandles.Last();
            driver.SwitchTo().Window(newTab2);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);


            ScrollAndClick(home.Aboutus1);
            driver.Navigate().Back();
            ScrollAndClick(home.Aboutus2);
            driver.Navigate().Back();
            ScrollAndClick(home.Aboutus3);
            driver.Navigate().Back();
            ScrollAndClick(home.Aboutus4);
            driver.Navigate().Back();
            ScrollAndClick(home.Aboutus5);
            driver.Navigate().Back();
            ScrollAndClick(home.Aboutus6);

            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");

            driver.Close();

        }

        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void SmokeAssessmentFR(string Login, string Password, string Url)
        {
            NavigateWithCredentials(Login, Password);
            var home = new WarriorHealthObjectsFR();
            PageFactory.InitElements(driver, home);

            Thread.Sleep(2000);
            home.Toggle.Click();
            ScrollAndClick(home.Assessments);
            home.Assessment1.Click();
            Thread.Sleep(2000);
            home.NewAssessment.Click();
            Thread.Sleep(2000);
            home.Assessment2.Click();
            Thread.Sleep(2000);
            home.Assessment3.Click();
            Thread.Sleep(2000);
            home.Assessment2.Click();
            Thread.Sleep(2000);
            home.Assessment3.Click();
            Thread.Sleep(1000);
            home.Assessment2.Click();
            Thread.Sleep(1000);
            home.Assessment3.Click();
            Thread.Sleep(1000);
            // drag a slider
            new Actions(driver).DragAndDropToOffset(home.Select, 50, 0).Perform();
            ScrollAndClick(home.Next);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment4);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment5);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment6);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment7);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment8);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment10);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment11);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment12);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment13);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment14);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment15);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment16);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment17);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment18);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment19);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment20);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment21);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment22);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment23);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment24);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment25);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment26);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment27);
            Thread.Sleep(1000);
            ScrollAndClick(home.Assessment28);
            Thread.Sleep(1000);
            ScrollAndClick(home.Home1);

            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");

            driver.Close();

        }
        [Test, TestCaseSource(nameof(LoginJsonData3))]
        public void SmokeEnrollorgFR(string Login, string Password, string Url, string OrgName, string RepName,
            string RepTitle, string RepEmail, string RepPhone, string City, string Province, string RepLastName,
            string AddressLine, string PostalCode)
        {
            NavigateWithCredentials(Login, Password);
            var home = new WarriorHealthObjectsFR();
            PageFactory.InitElements(driver, home);
            ScrollAndClick(home.Toggle);

            ScrollAndClick(home.ForOrgs);
            ScrollAndClick(home.Enroll1);
            home.OrgEnroll1.SendKeys(OrgName);
            home.OrgEnroll2.SendKeys(RepName);
            home.OrgEnroll8.SendKeys(RepLastName);
            home.OrgEnroll3.SendKeys(RepTitle);
            home.OrgEnroll4.SendKeys(GenerateUniqueEmail());
            home.OrgEnroll5.SendKeys(RepPhone);
            var dropdown1 = driver.FindElement(By.XPath("//select[@id='locale']"));
            new SelectElement(dropdown1).SelectByText("Anglais");
            Thread.Sleep(1000);
            home.OrgEnroll9.SendKeys(AddressLine);
            Thread.Sleep(1000);
            home.OrgEnroll6.SendKeys(City);
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='province']"));
            new SelectElement(dropdown).SelectByText("l'Ontario");
            Thread.Sleep(1000);
            home.OrgEnroll10.SendKeys(PostalCode);
            ScrollAndClick(home.OrgEnroll11);
            ScrollAndClick(home.OrgEnroll7);
            Thread.Sleep(1000);



            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");
            driver.Close();

        }
        [Test, TestCaseSource(nameof(LoginJsonData4))]
        public void SmokeEmailUpdatesFR(string Login, string Password, string Url, string OrgName, string RepName,
            string RepTitle, string RepEmail, string RepPhone)
        {
            NavigateWithCredentials(Login, Password);
            var home = new WarriorHealthObjectsFR();
            PageFactory.InitElements(driver, home);
            ScrollAndClick(home.Toggle);

            ScrollAndClick(home.Footer7);
            home.OrgEmailupdate.SendKeys(RepName);
            home.OrgEnroll4.SendKeys(GenerateUniqueEmail());
            home.OrgEnroll3.SendKeys(RepTitle);
            home.OrgEnroll1.SendKeys(OrgName);
            home.OrgEnroll5.SendKeys(RepPhone);
            ScrollAndClick(home.EmailSign1);

            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");

            driver.Close();


        }
        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void SmokeFAQFR(string Login, string Password, string Url)
        {
            NavigateWithCredentials(Login, Password);
            var home = new WarriorHealthObjectsFR();
            PageFactory.InitElements(driver, home);
            ScrollAndClick(home.Toggle);

            ScrollAndClick(home.FAQ);
            ScrollAndClick(home.FAQ1);
            ScrollAndClick(home.FAQ1);

            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");

            driver.Close();
        }


        [Test, TestCaseSource(nameof(LoginJsonData2))]
        public void SmokeFounderFR(string Login, string Password, string Url)
        {

            NavigateWithCredentials(Login, Password);
            var home = new WarriorHealthObjectsFR();
            PageFactory.InitElements(driver, home);
            ScrollAndClick(home.Toggle);

            ScrollAndClick(home.Poweredby1);
            ClickAndSwitch(home.Founder1);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Poweredby2);
            ClickAndSwitch(home.Founder2);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Poweredby3);
            ClickAndSwitch(home.Founder3);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Poweredby4);
            ClickAndSwitch(home.Founder4);
            ScrollAndClick(home.Home1);
            ScrollAndClick(home.Poweredby5);
            ClickAndSwitch(home.Founder5);
            ScrollAndClick(home.Home1);
            ClickAndSwitch(home.Poweredby6);

            TakeScreenshot("C:\\TestData\\WarriorHealth\\Home_");

            driver.Close();

        }



        public static IEnumerable<TestCaseData> LoginJsonData()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\WarriorHealthBeta\\TestData\\TestData.Json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.Login)
                                                        && !string.IsNullOrEmpty(data.Password)
                                                        && data.Url == "https://staging.warriorhealth.ca/en");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Login, loginData.Password, loginData.Url, loginData.Invalid,
                    loginData.Valid, loginData.Search1, loginData.Search2, loginData.Search3, loginData.Valid1);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData1()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\WarriorHealthBeta\\TestData\\TestData.Json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.Login)
                                                        && !string.IsNullOrEmpty(data.Password)
                                                        && data.Url == "https://staging.warriorhealth.ca/en");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Login, loginData.Password, loginData.Url, loginData.Invalid,
                    loginData.Valid, loginData.Valid1);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData2()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\WarriorHealthBeta\\TestData\\TestData.Json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.Login)
                                                        && !string.IsNullOrEmpty(data.Password)
                                                        && data.Url == "https://staging.warriorhealth.ca/en");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Login, loginData.Password, loginData.Url);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData3()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\WarriorHealthBeta\\TestData\\TestData.Json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.Login)
                                                        && !string.IsNullOrEmpty(data.Password)
                                                        && data.Url == "https://staging.warriorhealth.ca/en");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Login, loginData.Password, loginData.Url, loginData.OrgName,
                    loginData.RepName, loginData.RepTitle, loginData.RepEmail, loginData.RepPhone, loginData.City, loginData.Province,
                    loginData.RepLastName, loginData.AddressLine, loginData.PostalCode);
            }
        }
        public static IEnumerable<TestCaseData> LoginJsonData4()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\WarriorHealthBeta\\TestData\\TestData.Json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.Login)
                                                        && !string.IsNullOrEmpty(data.Password)
                                                        && data.Url == "https://staging.warriorhealth.ca/en");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.Login, loginData.Password, loginData.Url, loginData.OrgName,
                    loginData.RepName, loginData.RepTitle, loginData.RepEmail, loginData.RepPhone);
            }
        }
        private void TakeScreenshot(string filePath)
        {
            ITakesScreenshot ssd = driver as ITakesScreenshot;
            Screenshot ss = ssd.GetScreenshot();
            ss.SaveAsFile(filePath + time.ToString("yy_dd_h_mm_ss") + ".png");
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            // Flush the extent reports
            extent.Flush();
        }
        private void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
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
        private void ClickAndNavigate(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => element.Displayed);
            element.Click();
        }
        private static string GenerateUniqueEmail()
        {
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            return $"testuser_{timestamp}@demo.com";
        }
        private void NavigateWithCredentials(string user, string pass)
        {
            driver.Navigate().GoToUrl($"https://{user}:{pass}@staging.warriorhealth.ca/en");
        }
        private void ScrollAndClick(IWebElement el)
        {
            // Scroll into view
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", el);
            // Wait until clickable
            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                .Until(d => el.Displayed && el.Enabled);
            // Try clicking, fallback to JS on intercept
            try
            {
                el.Click();
            }
            catch (ElementClickInterceptedException)
            {
                js.ExecuteScript("arguments[0].click();", el);
            }
        }
        private void ClickAndSwitch(IWebElement el)
        {
            ScrollAndClick(el);
            var tab = driver.WindowHandles.Last();
            driver.SwitchTo().Window(tab);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
        }
        [TearDown]
        public void Endtest()
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
            driver.Quit();
            driver.Dispose();
        }

    }
}
*/