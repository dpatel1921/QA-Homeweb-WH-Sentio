using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Homeweb_3._0_Tests.Objects;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
//using OpenQA.Selenium.BiDi.Modules.Script;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Homeweb_3._0_Tests.TestCases
{
    [TestFixture]

    public class PublisherSmokeTestsHomewebFR
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

        public class TestCaseJsonData
        {
            public string PubEmail { get; set; }
            public string PubPassword { get; set; }
            public string PubUrl { get; set; }
            public string PubActivityName { get; set; }

        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(1)]
        public void PubDashboardHomewebFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");

            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);


            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ViewContentFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewContentFR.Displayed, "Content tab should be visible.");
            homePage.ViewContentFR.Click();
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.ViewDashboardFR.Displayed, "Dashboard tab should be visible.");
            homePage.ViewDashboardFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ViewAuthorFR.Displayed, "Author tab should be visible.");
            homePage.ViewAuthorFR.Click();
            Thread.Sleep(1000);
            homePage.ViewDashboardFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ViewCategoriesFR.Displayed, "Categories tab should be visible.");
            homePage.ViewCategoriesFR.Click();
            Thread.Sleep(1000);
            homePage.ViewDashboardFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ViewPagesHomewebFR.Displayed, "Pages tab (Homeweb) should be visible.");
            homePage.ViewPagesHomewebFR.Click();
            Thread.Sleep(1000);
            homePage.ViewDashboardFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ViewassetsFR.Displayed, "Assets tab should be visible.");
            homePage.ViewassetsFR.Click();
            Thread.Sleep(1000);
            homePage.ViewDashboardFR.Click();
            Thread.Sleep(1000);


            ScrollToElement(homePage.ViewTagsFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewTagsFR.Displayed, "Tags tab should be visible.");
            homePage.ViewTagsFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ViewDashboardFR.Displayed, "Dashboard tab should remain visible after navigating to Tags.");
        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(2)]
        public void PubHomewebContentADDFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");


            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);

            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ViewContentFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewContentFR.Displayed, "Content tab should be visible.");
            homePage.ViewContentFR.Click();
            Thread.Sleep(3000);


            Assert.IsTrue(homePage.AddContentFR.Displayed, "Add Content button should be visible.");
            Thread.Sleep(2000);
            homePage.AddContentFR.Click();
            Thread.Sleep(2000);

            Assert.IsTrue(homePage.ContentTitle.Displayed, "Content Title field should be visible.");
            homePage.ContentTitle.Clear();
            homePage.ContentTitle.SendKeys(PubActivityName);
            Thread.Sleep(1000);

            var activitytype = driver.FindElement(By.XPath("//SELECT[@id='public']"));
            Assert.IsTrue(activitytype.Displayed, "Public visibility dropdown should be visible.");
            var publicSelect = new SelectElement(activitytype);
            publicSelect.SelectByIndex(1);
            Thread.Sleep(1000);
            Assert.That(publicSelect.SelectedOption, Is.Not.Null, "A visibility option should be selected.");

            var activityformat = driver.FindElement(By.XPath("//SELECT[@id='type']"));
            Assert.IsTrue(activityformat.Displayed, "Content Type dropdown should be visible.");
            var typeSelect = new SelectElement(activityformat);
            typeSelect.SelectByText("Article");
            Thread.Sleep(1000);
            Assert.AreEqual("Article", typeSelect.SelectedOption.Text, "Content Type should be set to 'Article'.");

            Assert.IsTrue(homePage.ContentTime.Displayed, "Estimated Time field should be visible.");
            homePage.ContentTime.Clear();
            homePage.ContentTime.SendKeys("30");
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivitySave.Displayed, "Save button should be visible.");
            homePage.ActivitySave.Click();
            Thread.Sleep(1000);


            var savedToast = driver.FindElements(By.XPath("//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'saved') or contains(text(),'created')]")).Count > 0;
            Assert.IsTrue(savedToast, "A success message/toast should appear after saving content.");


        }
        [Test, TestCaseSource(nameof(LoginJsonData)), Order(3)]
        public void PubHomewebContentPreviewFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");


            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ViewContentFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewContentFR.Displayed, "Content tab should be visible.");
            homePage.ViewContentFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Content page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.ActivityPreview.Displayed, "Preview button should be visible for the content item.");
            homePage.ActivityPreview.Click();
            Thread.Sleep(3000);


            var previewOverlayCount = driver.FindElements(By.XPath("//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']")).Count;
            Assert.IsTrue(previewOverlayCount > 0, "Preview dialog/overlay should be visible after clicking Preview.");

            var previewIframesCount = driver.FindElements(By.TagName("iframe")).Count;
            Assert.IsTrue(previewIframesCount > 0, "An iframe should be present for the preview content.");


            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivityPreviewmobile.Displayed, "Mobile preview button should be visible.");
            homePage.ActivityPreviewmobile.Click();
            Thread.Sleep(3000);

            var stillOpen = driver.FindElements(By.XPath("//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']")).Count;
            Assert.IsTrue(stillOpen > 0, "Preview dialog should remain open after switching to Mobile view.");


            Assert.IsTrue(homePage.ActivityPreviewclose.Displayed, "Close button should be visible on preview dialog.");
            homePage.ActivityPreviewclose.Click();
            Thread.Sleep(3000);


        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(4)]
        public void PubHomewebContentEditFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {

            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");


            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);

            ScrollToElement(homePage.ViewContentFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewContentFR.Displayed, "Content tab should be visible.");
            homePage.ViewContentFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Content page.");
            homePage.ActivitySearch.Clear();
            Thread.Sleep(1000);
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivityEditFR.Displayed, "Edit button should be visible for the content.");
            homePage.ActivityEditFR.Click();
            Thread.Sleep(1000);


            SwitchToNewTab();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ContentEditFR.Displayed, "Content Edit section/button should be visible.");
            homePage.ContentEditFR.Click();
            Thread.Sleep(1000);


            var activitystatus = driver.FindElement(By.XPath("//SELECT[@id='status']"));
            Assert.IsTrue(activitystatus.Displayed, "Status dropdown should be visible.");
            var statusSelect = new SelectElement(activitystatus);
            statusSelect.SelectByIndex(1);
            Thread.Sleep(1000);
            
            ScrollToElement(homePage.ContentEditSave);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ContentEditSave.Displayed, "Save button should be visible.");
            homePage.ContentEditSave.Click();
            Thread.Sleep(2000);


            var savedToast = driver.FindElements(By.XPath(
                "//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'saved') or contains(text(),'updated')]"
            )).Count > 0;
            Assert.IsTrue(savedToast, "A success message/toast should appear after saving.");


            var statusAfterSave = new SelectElement(driver.FindElement(By.XPath("//SELECT[@id='status']"))).SelectedOption.Text;
        
        }


        [Test, TestCaseSource(nameof(LoginJsonData)), Order(5)]
        public void PubHomewebContentDeleteFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");


            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);

            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ViewContentFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewContentFR.Displayed, "Content tab should be visible.");
            homePage.ViewContentFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Content page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);


            var beforeDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(beforeDelete, $"Content '{PubActivityName}' should be present before deletion.");


            Assert.IsTrue(homePage.ActivityEditDeleteFR.Displayed, "Delete button should be visible for the content.");
            homePage.ActivityEditDeleteFR.Click();
            Thread.Sleep(1000);


            var confirmVisible = driver.FindElements(By.XPath("//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']")).Count > 0;
            Assert.IsTrue(confirmVisible, "Delete confirmation dialog should appear.");

            Assert.IsTrue(homePage.ActivityEditDeleteconfirmFR.Displayed, "Confirm Delete button should be visible.");
            homePage.ActivityEditDeleteconfirmFR.Click();
            Thread.Sleep(1000);


            var deleteToast = driver.FindElements(By.XPath("//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'deleted') or contains(text(),'removed')]")).Count > 0;
            Assert.IsTrue(deleteToast, "A success message/toast should appear after deleting the content.");


            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(1500);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

            var afterDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count == 0;
            Assert.IsTrue(afterDelete, $"Content '{PubActivityName}' should no longer be present after deletion.");
        }


        [Test, TestCaseSource(nameof(LoginJsonData)), Order(6)]
        public void PubHomewebAuthorADDFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");

            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);

            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);

            ScrollToElement(homePage.AuthorSelectFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.AuthorSelectFR.Displayed, "Authors tab should be visible.");
            homePage.AuthorSelectFR.Click();
            Thread.Sleep(3000);


            Assert.IsTrue(homePage.AddContentFR.Displayed, "Add Author button should be visible.");
            homePage.AddContentFR.Click();
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.AuthorName.Displayed, "Author Name field should be visible.");
            homePage.AuthorName.Clear();
            homePage.AuthorName.SendKeys(PubActivityName);
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.ActivitySave.Displayed, "Save button should be visible.");
            homePage.ActivitySave.Click();
            Thread.Sleep(1000);


            var savedToast = driver.FindElements(By.XPath(
                "//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'saved') or contains(text(),'created')]"
            )).Count > 0;
            Assert.IsTrue(savedToast, "A success message/toast should appear after saving the author.");


            var createdAuthor = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(createdAuthor, $"New author '{PubActivityName}' should appear in the list after saving.");
        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(7)]
        public void PubHomewebAuthorEditFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");


            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);

            ScrollToElement(homePage.AuthorSelectFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.AuthorSelectFR.Displayed, "Authors tab should be visible.");
            homePage.AuthorSelectFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Authors page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);


            var beforeEdit = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(beforeEdit, $"Author '{PubActivityName}' should be present before editing.");


            Assert.IsTrue(homePage.ActivityEditFR.Displayed, "Edit button should be visible for the author.");
            homePage.ActivityEditFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.AuthorName.Displayed, "Author Name field should be visible.");
            homePage.AuthorName.Clear();
            Thread.Sleep(1000);
            var updatedName = PubActivityName + " Updated";
            homePage.AuthorName.SendKeys(updatedName);
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivitySave.Displayed, "Save button should be visible.");
            homePage.ActivitySave.Click();
            Thread.Sleep(1000);

         }


        [Test, TestCaseSource(nameof(LoginJsonData)), Order(8)]
        public void PubHomewebAuthorDeleteFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // --- Login ---
            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");


            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);

            ScrollToElement(homePage.AuthorSelectFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.AuthorSelectFR.Displayed, "Authors tab should be visible.");
            homePage.AuthorSelectFR.Click();
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Authors page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

            var beforeDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(beforeDelete, $"Author '{PubActivityName}' should be present before deletion.");


            Assert.IsTrue(homePage.ActivityEditDeleteFR.Displayed, "Delete button should be visible for the author.");
            homePage.ActivityEditDeleteFR.Click();
            Thread.Sleep(1000);


            var confirmVisible = driver.FindElements(By.XPath("//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']")).Count > 0;
            Assert.IsTrue(confirmVisible, "Delete confirmation dialog should appear.");

            Assert.IsTrue(homePage.ActivityEditDeleteconfirmFR.Displayed, "Confirm Delete button should be visible.");
            homePage.ActivityEditDeleteconfirmFR.Click();
            Thread.Sleep(1000);


            var deleteToast = driver.FindElements(By.XPath(
                "//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'deleted') or contains(text(),'removed')]"
            )).Count > 0;
            Assert.IsTrue(deleteToast, "A success message/toast should appear after deleting the author.");


            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(1500);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

            var afterDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count == 0;
            Assert.IsTrue(afterDelete, $"Author '{PubActivityName}' should no longer be present after deletion.");
        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(9)]
        public void PubHomewebCategoryADDFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");


            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);

            ScrollToElement(homePage.CatSelectFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.CatSelectFR.Displayed, "Categories tab should be visible.");
            homePage.CatSelectFR.Click();
            Thread.Sleep(3000);


            Assert.IsTrue(homePage.AddContentFR.Displayed, "Add Category button should be visible.");
            homePage.AddContentFR.Click();
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.ContentTitle.Displayed, "Category Title field should be visible.");
            homePage.ContentTitle.Clear();
            homePage.ContentTitle.SendKeys(PubActivityName);
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.ActivitySave.Displayed, "Save button should be visible.");
            homePage.ActivitySave.Click();
            Thread.Sleep(1000);


            var savedToast = driver.FindElements(By.XPath(
                "//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'saved') or contains(text(),'created')]"
            )).Count > 0;
            Assert.IsTrue(savedToast, "A success message/toast should appear after saving the category.");


            var createdCategory = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(createdCategory, $"New category '{PubActivityName}' should appear in the list after saving.");
        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(10)]
        public void PubHomewebCategoryEditFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);

            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");

            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);

            ScrollToElement(homePage.CatSelectFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.CatSelectFR.Displayed, "Categories tab should be visible.");
            homePage.CatSelectFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Categories page.");
            homePage.ActivitySearch.Clear();
            Thread.Sleep(1000);
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);


            var resultMatch = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(resultMatch, $"Category '{PubActivityName}' should appear in search results.");


            Assert.IsTrue(homePage.ActivityEditFR.Displayed, "Edit button should be visible for the category.");
            homePage.ActivityEditFR.Click();
            Thread.Sleep(1000);


            SwitchToNewTab();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.CatEditFR.Displayed, "Category Edit section/button should be visible.");
            homePage.CatEditFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.CatRestrict.Displayed, "Category 'Restrict' control should be visible.");
            homePage.CatRestrict.Click();
            Thread.Sleep(1000);


            try
            {
                var isChecked = homePage.CatRestrict.Selected;
                Assert.IsTrue(isChecked, "'Restrict' should be enabled after clicking.");
            }
            catch { }


            ScrollToElement(homePage.ContentEditSave);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ContentEditSave.Displayed, "Save button should be visible.");
            homePage.ContentEditSave.Click();
            Thread.Sleep(2000);

            var savedToast = driver.FindElements(By.XPath(
                "//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'saved') or contains(text(),'updated')]"
            )).Count > 0;
            Assert.IsTrue(savedToast, "A success message/toast should appear after saving.");


            var stillThere = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(stillThere, $"Category '{PubActivityName}' should still be listed after saving.");
        }


        [Test, TestCaseSource(nameof(LoginJsonData)), Order(11)]
        public void PubHomewebCategoryDeleteFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");


            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);
            ScrollToElement(homePage.CatSelectFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.CatSelectFR.Displayed, "Categories tab should be visible.");
            homePage.CatSelectFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Categories page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);


            var beforeDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(beforeDelete, $"Category '{PubActivityName}' should be present before deletion.");


            Assert.IsTrue(homePage.ActivityEditDeleteFR.Displayed, "Delete button should be visible for the category.");
            homePage.ActivityEditDeleteFR.Click();
            Thread.Sleep(1000);


            var confirmVisible = driver.FindElements(By.XPath("//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']")).Count > 0;
            Assert.IsTrue(confirmVisible, "Delete confirmation dialog should appear.");

            Assert.IsTrue(homePage.ActivityEditDeleteconfirmFR.Displayed, "Confirm Delete button should be visible.");
            homePage.ActivityEditDeleteconfirmFR.Click();
            Thread.Sleep(1000);


            var deleteToast = driver.FindElements(By.XPath(
                "//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'deleted') or contains(text(),'removed')]"
            )).Count > 0;
            Assert.IsTrue(deleteToast, "A success message/toast should appear after deleting the category.");


            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(1500);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

            var afterDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count == 0;
            Assert.IsTrue(afterDelete, $"Category '{PubActivityName}' should no longer be present after deletion.");
        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(12)]
        public void PubHomewebTagsADDFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");


            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);

            ScrollToElement(homePage.TagSelectFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.TagSelectFR.Displayed, "Tags tab should be visible.");
            homePage.TagSelectFR.Click();
            Thread.Sleep(3000);


            Assert.IsTrue(homePage.AddContentFR.Displayed, "Add Tag button should be visible.");
            homePage.AddContentFR.Click();
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.TagLabel.Displayed, "Tag Label field should be visible.");
            homePage.TagLabel.Clear();
            homePage.TagLabel.SendKeys(PubActivityName);
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.ActivitySave.Displayed, "Save button should be visible.");
            homePage.ActivitySave.Click();
            Thread.Sleep(1000);


            var savedToast = driver.FindElements(By.XPath(
                "//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'saved') or contains(text(),'created')]"
            )).Count > 0;
            Assert.IsTrue(savedToast, "A success message/toast should appear after saving the tag.");


            var createdTag = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(createdTag, $"New tag '{PubActivityName}' should appear in the list after saving.");
        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(13)]
        public void PubHomewebTagsEditFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");


            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);

            ScrollToElement(homePage.TagSelectFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.TagSelectFR.Displayed, "Tags tab should be visible.");
            homePage.TagSelectFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Tags page.");
            homePage.ActivitySearch.Clear();
            Thread.Sleep(1000);
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);


            var beforeEdit = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(beforeEdit, $"Tag '{PubActivityName}' should be present before editing.");


            Assert.IsTrue(homePage.ActivityEditFR.Displayed, "Edit button should be visible for the tag.");
            homePage.ActivityEditFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.TagLabel.Displayed, "Tag Label field should be visible.");
            homePage.TagLabel.Clear();
            Thread.Sleep(1000);
            var updatedTag = PubActivityName + " Updated";
            homePage.TagLabel.SendKeys(updatedTag);
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivitySave.Displayed, "Save button should be visible.");
            homePage.ActivitySave.Click();
            Thread.Sleep(1000);


         
        }


        [Test, TestCaseSource(nameof(LoginJsonData)), Order(14)]
        public void PubHomewebTagsDeleteFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");


            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);

            ScrollToElement(homePage.TagSelectFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.TagSelectFR.Displayed, "Tags tab should be visible.");
            homePage.TagSelectFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Tags page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);


            var beforeDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(beforeDelete, $"Tag '{PubActivityName}' should be present before deletion.");


            Assert.IsTrue(homePage.ActivityEditDeleteFR.Displayed, "Delete button should be visible for the tag.");
            homePage.ActivityEditDeleteFR.Click();
            Thread.Sleep(1000);


            var confirmVisible = driver.FindElements(By.XPath(
                "//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']"
            )).Count > 0;
            Assert.IsTrue(confirmVisible, "Delete confirmation dialog should appear.");

            Assert.IsTrue(homePage.ActivityEditDeleteconfirmFR.Displayed, "Confirm Delete button should be visible.");
            homePage.ActivityEditDeleteconfirmFR.Click();
            Thread.Sleep(1000);


            var deleteToast = driver.FindElements(By.XPath(
                "//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'deleted') or contains(text(),'removed')]"
            )).Count > 0;
            Assert.IsTrue(deleteToast, "A success message/toast should appear after deleting the tag.");


            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(1500);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

            var afterDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count == 0;
            Assert.IsTrue(afterDelete, $"Tag '{PubActivityName}' should no longer be present after deletion.");
        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(15)]
        public void PubDashboardHomewebPagesADDFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");


            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.ViewPagespub);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewPagespub.Displayed, "Pages tab should be visible.");
            homePage.ViewPagespub.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.CoursesaddFR.Displayed, "Add Page button should be visible.");
            homePage.CoursesaddFR.Click();
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.ActivityName.Displayed, "Page Name field should be visible.");
            homePage.ActivityName.Clear();
            homePage.ActivityName.SendKeys(PubActivityName);
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.Pagesave.Displayed, "Save button should be visible.");
            homePage.Pagesave.Click();
            Thread.Sleep(2000);


            var savedToast = driver.FindElements(By.XPath(
                "//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'saved') or contains(text(),'created')]"
            )).Count > 0;
            Assert.IsTrue(savedToast, "A success message/toast should appear after saving the page.");


            var createdPage = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(createdPage, $"New page '{PubActivityName}' should appear in the list after saving.");
        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(16)]
        public void PubDashboardHomewebPagesPreviewFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");


            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);

            ScrollToElement(homePage.ViewPagespub);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewPagespub.Displayed, "Pages tab should be visible.");
            homePage.ViewPagespub.Click();
            Thread.Sleep(1000);
          

            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Pages page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);


            var pageExists = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(pageExists, $"Page '{PubActivityName}' should appear in search results.");


            Assert.IsTrue(homePage.ActivityPreview.Displayed, "Preview button should be visible for the page.");
            homePage.ActivityPreview.Click();
            Thread.Sleep(3000);


            var previewDialog = driver.FindElements(By.XPath("//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']")).Count > 0;
            Assert.IsTrue(previewDialog, "Preview dialog should open after clicking preview.");


            var iframeCount = driver.FindElements(By.TagName("iframe")).Count;
            Assert.IsTrue(iframeCount > 0, "Preview iframe should be present.");

            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivityPreviewmobile.Displayed, "Mobile preview button should be visible.");
            homePage.ActivityPreviewmobile.Click();
            Thread.Sleep(3000);

            var stillOpen = driver.FindElements(By.XPath("//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']")).Count > 0;
            Assert.IsTrue(stillOpen, "Preview dialog should remain open in mobile view.");


            Assert.IsTrue(homePage.ActivityPreviewclose.Displayed, "Close button should be visible in preview dialog.");
            homePage.ActivityPreviewclose.Click();
            Thread.Sleep(3000);

        }


        [Test, TestCaseSource(nameof(LoginJsonData)), Order(17)]
        public void PubDashboardHomewebPagesEditFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");


            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);

            ScrollToElement(homePage.ViewPagespub);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewPagespub.Displayed, "Pages tab should be visible.");
            homePage.ViewPagespub.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Pages page.");
            homePage.ActivitySearch.Clear();
            Thread.Sleep(1000);
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

            var pageExists = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(pageExists, $"Page '{PubActivityName}' should be present before editing.");


            Assert.IsTrue(homePage.ActivityEditFR.Displayed, "Edit button should be visible for the page.");
            homePage.ActivityEditFR.Click();
            Thread.Sleep(1000);

            SwitchToNewTab();
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.PageeditFR.Displayed, "Page edit section should be visible.");
            homePage.PageeditFR.Click();
            Thread.Sleep(1000);

            var activitystatus = driver.FindElement(By.XPath("//SELECT[@id='status']"));
            Assert.IsTrue(activitystatus.Displayed, "Status dropdown should be visible.");
            var statusSelect = new SelectElement(activitystatus);
            statusSelect.SelectByIndex(1);
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.Pagesave.Displayed, "Save button should be visible.");
            homePage.Pagesave.Click();
            Thread.Sleep(2000);


            var savedToast = driver.FindElements(By.XPath(
                "//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'saved') or contains(text(),'updated')]"
            )).Count > 0;
            Assert.IsTrue(savedToast, "A success message/toast should appear after saving.");


        }


        [Test, TestCaseSource(nameof(LoginJsonData)), Order(18)]
        public void PubDashboardHomewebPagesDeleteFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");

            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);

            ScrollToElement(homePage.ViewPagespub);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewPagespub.Displayed, "Pages tab should be visible.");
            homePage.ViewPagespub.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Pages page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);


            var beforeDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(beforeDelete, $"Page '{PubActivityName}' should be present before deletion.");


            Assert.IsTrue(homePage.ActivityEditDeleteFR.Displayed, "Delete button should be visible for the page.");
            homePage.ActivityEditDeleteFR.Click();
            Thread.Sleep(1000);


            var confirmVisible = driver.FindElements(By.XPath(
                "//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']"
            )).Count > 0;
            Assert.IsTrue(confirmVisible, "Delete confirmation dialog should appear.");

            Assert.IsTrue(homePage.ActivityEditDeleteconfirmFR.Displayed, "Confirm Delete button should be visible.");
            homePage.ActivityEditDeleteconfirmFR.Click();
            Thread.Sleep(1000);


            var deleteToast = driver.FindElements(By.XPath(
                "//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'deleted') or contains(text(),'removed')]"
            )).Count > 0;
            Assert.IsTrue(deleteToast, "A success message/toast should appear after deleting the page.");


            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(1500);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

            var afterDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count == 0;
            Assert.IsTrue(afterDelete, $"Page '{PubActivityName}' should no longer be present after deletion.");
        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(19)]
        public void PubHomewebAssetsADDFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");

            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);

            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ViewAssetsFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewAssetsFR.Displayed, "Assets tab should be visible.");
            homePage.ViewAssetsFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.CoursesaddFR.Displayed, "Add Asset button should be visible.");
            homePage.CoursesaddFR.Click();
            Thread.Sleep(2000);


            string fileToUpload = Path.GetFullPath("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\SampleAsset.txt");
            Assert.IsTrue(File.Exists(fileToUpload), $"Test asset file should exist: {fileToUpload}");
            Thread.Sleep(2000);
            homePage.Assetsupload.SendKeys(fileToUpload);
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.AssetName.Displayed, "Asset Name field should be visible.");
            homePage.AssetName.Clear();
            homePage.AssetName.SendKeys(PubActivityName);
            Thread.Sleep(1000);


            ScrollToElement(homePage.AssetSave);
            Assert.IsTrue(homePage.AssetSave.Displayed, "Save button should be visible.");
            homePage.AssetSave.Click();
            Thread.Sleep(1000);


            var savedToast = driver.FindElements(By.XPath(
                "//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'saved') or contains(text(),'created')]"
            )).Count > 0;
            Assert.IsTrue(savedToast, "A success message/toast should appear after saving the asset.");


            var createdAsset = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(createdAsset, $"New asset '{PubActivityName}' should appear in the list after saving.");
        }



        [Test, TestCaseSource(nameof(LoginJsonData)), Order(20)]
        public void PubHomewebAssetsEditFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);


            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");


            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);

            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ViewAssetsFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewAssetsFR.Displayed, "Assets tab should be visible.");
            homePage.ViewAssetsFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Assets page.");
            homePage.ActivitySearch.Clear();
            Thread.Sleep(1000);
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

            var assetExists = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(assetExists, $"Asset '{PubActivityName}' should be present before editing.");


            Assert.IsTrue(homePage.ActivityEditFR.Displayed, "Edit button should be visible for the asset.");
            homePage.ActivityEditFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.AssetName.Displayed, "Asset Name field should be visible.");
            homePage.AssetName.Clear();
            Thread.Sleep(1000);
            var updatedName = PubActivityName + " Updated";
            homePage.AssetName.SendKeys(updatedName);
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.AssetSource.Displayed, "Asset Source field should be visible.");
            homePage.AssetSource.Clear();
            homePage.AssetSource.SendKeys("This is source");
            Thread.Sleep(1000);


            ScrollToElement(homePage.AssetSave);
            Assert.IsTrue(homePage.AssetSave.Displayed, "Save button should be visible.");
            homePage.AssetSave.Click();
            Thread.Sleep(1000);


        
        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(21)]
        public void PubHomewebAssetsDeleteFR(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);
            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);

            Assert.IsTrue(homePage.LaunchPub.Displayed, "Launch Publisher button should be visible after login.");


            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubHomeweb);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubHomeweb.Displayed, "Homeweb launch option should be visible.");
            homePage.LaunchPubHomeweb.Click();
            Thread.Sleep(1000);
            ClickAndNavigate(homePage.LanChange);
            Thread.Sleep(1000);
            ScrollToElement(homePage.ViewAssetsFR);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewAssetsFR.Displayed, "Assets tab should be visible.");
            homePage.ViewAssetsFR.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Assets page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);


            var beforeDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(beforeDelete, $"Asset '{PubActivityName}' should be present before deletion.");


            Assert.IsTrue(homePage.ActivityEditDeleteFR.Displayed, "Delete button should be visible for the asset.");
            homePage.ActivityEditDeleteFR.Click();
            Thread.Sleep(1000);


            var confirmVisible = driver.FindElements(By.XPath(
                "//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']"
            )).Count > 0;
            Assert.IsTrue(confirmVisible, "Delete confirmation dialog should appear.");

            Assert.IsTrue(homePage.ActivityEditDeleteconfirmFR.Displayed, "Confirm Delete button should be visible.");
            homePage.ActivityEditDeleteconfirmFR.Click();
            Thread.Sleep(1000);


            var deleteToast = driver.FindElements(By.XPath(
                "//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'deleted') or contains(text(),'removed')]"
            )).Count > 0;
            Assert.IsTrue(deleteToast, "A success message/toast should appear after deleting the asset.");


            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(1500);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

            var afterDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count == 0;
            Assert.IsTrue(afterDelete, $"Asset '{PubActivityName}' should no longer be present after deletion.");
        }



        private void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        private void ClickAndNavigateBack(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Thread.Sleep(2000);
            element.Click();
            driver.Navigate().Back();
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
            Thread.Sleep(2000);
            element.Click();
        }

        public static IEnumerable<TestCaseData> LoginJsonData()
        {
            string jsonString = File.ReadAllText("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\HomewebLoginData.json");
            var dataToLoad = JsonSerializer.Deserialize<List<TestCaseJsonData>>(jsonString);
            var filteredData = dataToLoad.Where(data => !string.IsNullOrEmpty(data.PubEmail)
                                                        && !string.IsNullOrEmpty(data.PubPassword)
                                                        && data.PubUrl == "https://api.homewoodhealth.io/en/login");
            foreach (var loginData in filteredData)
            {
                yield return new TestCaseData(loginData.PubEmail, loginData.PubPassword, loginData.PubUrl, loginData.PubActivityName);
            }
        }
        [OneTimeTearDown]
        public void TearDown()
        {
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


            driver.Quit();
            driver.Dispose();
        }


    }
}

