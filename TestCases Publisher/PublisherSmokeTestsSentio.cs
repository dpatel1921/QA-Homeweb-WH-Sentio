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

    public class  PublisherSmokeTestsSentio
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
        public void PubDashboardSentio(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
        {
            // Navigate to the provided URL
            driver.Navigate().GoToUrl(PubUrl);

            var homePage = new HomewebLoginObjects();
            PageFactory.InitElements(driver, homePage);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            homePage.UserName.SendKeys(PubEmail);
            homePage.Next.Click();
            homePage.Password.SendKeys(PubPassword);
            homePage.Submit.Submit();
            Thread.Sleep(2000);
            ScrollToElement(homePage.LaunchPub);
            Thread.Sleep(1000);
            homePage.LaunchPub.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.LaunchPubSentio);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.ViewActivities);
            Assert.IsTrue(homePage.ViewActivities.Displayed, "Activities tab should be visible.");
            homePage.ViewActivities.Click();

      
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewDashboard.Displayed, "Dashboard should be visible.");
            homePage.ViewDashboard.Click();

            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewCourses.Displayed, "Courses tab should be visible.");
            homePage.ViewCourses.Click();

            Thread.Sleep(1000);
            homePage.ViewDashboard.Click();

       
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewPrograms.Displayed, "Programs tab should be visible.");
            homePage.ViewPrograms.Click();

            Thread.Sleep(1000);
            homePage.ViewDashboard.Click();

            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewPages.Displayed, "Pages tab should be visible.");
            homePage.ViewPages.Click();

       
            Thread.Sleep(1000);
            homePage.ViewDashboard.Click();

            
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.Viewassets.Displayed, "Assets tab should be visible.");
            homePage.Viewassets.Click();

            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewDashboard.Displayed, "Dashboard should still be visible after Assets.");
            homePage.ViewDashboard.Click();
        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(2)]
        public void PubDashboardSentioActivitesADD(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);


            ScrollToElement(homePage.ViewActivities);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewActivities.Displayed, "Activities tab should be visible.");
            homePage.ViewActivities.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.AddActivity.Displayed, "Add Activity button should be visible on Activities page.");
            homePage.AddActivity.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivityName.Displayed, "Activity Name field should be visible.");
            homePage.ActivityName.SendKeys(PubActivityName);
            Thread.Sleep(1000);

            var activitytype = driver.FindElement(By.XPath("//SELECT[@id='type']"));
            Assert.IsTrue(activitytype.Displayed, "Activity Type dropdown should be visible.");
            Assert.DoesNotThrow(() => new SelectElement(activitytype).SelectByText("Resource"),
                "Should be able to select 'Resource' in Activity Type.");
            Thread.Sleep(1000);

            var activityformat = driver.FindElement(By.XPath("//SELECT[@id='format']"));
            Assert.IsTrue(activityformat.Displayed, "Activity Format dropdown should be visible.");
            Assert.DoesNotThrow(() => new SelectElement(activityformat).SelectByText("Text"),
                "Should be able to select 'Text' in Activity Format.");
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.ActivitySave.Displayed, "Save button should be visible.");
            homePage.ActivitySave.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ViewActivities.Displayed, "After saving, Activities tab should still be visible.");

        }


        [Test, TestCaseSource(nameof(LoginJsonData)), Order(3)]
        public void PubDashboardSentioActivitesPreview(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);


            ScrollToElement(homePage.ViewActivities);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewActivities.Displayed, "Activities tab should be visible.");
            homePage.ViewActivities.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Activity search box should be visible on Activities page.");
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);


            var resultMatch = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(resultMatch, $"Activity '{PubActivityName}' should appear in search results.");

            Assert.IsTrue(homePage.ActivityPreview.Displayed, "Preview button should be visible for the activity.");
            homePage.ActivityPreview.Click();
            Thread.Sleep(3000);


            var previewOverlay = driver.FindElements(By.XPath("//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']")).Count;
            Assert.IsTrue(previewOverlay > 0, "Preview dialog/overlay should be visible after clicking Preview.");


            var previewIframes = driver.FindElements(By.TagName("iframe")).Count;
            Assert.IsTrue(previewIframes > 0, "An iframe should be present for the preview content.");


            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.ActivityPreviewmobile.Displayed, "Mobile preview toggle/button should be visible.");
            homePage.ActivityPreviewmobile.Click();
            Thread.Sleep(3000);


            var stillOpen = driver.FindElements(By.XPath("//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']")).Count;
            Assert.IsTrue(stillOpen > 0, "Preview dialog should remain open after switching to Mobile.");


            Assert.IsTrue(homePage.ActivityPreviewclose.Displayed, "Close button should be visible on the preview dialog.");
            homePage.ActivityPreviewclose.Click();
            Thread.Sleep(3000);

        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(4)]
        public void PubDashboardSentioActivitesEdit(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);

      
            ScrollToElement(homePage.ViewActivities);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewActivities.Displayed, "Activities tab should be visible.");
            homePage.ViewActivities.Click();
            Thread.Sleep(1000);

        
            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Activity search box should be visible on Activities page.");
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);


            var resultMatch = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(resultMatch, $"Activity '{PubActivityName}' should appear in search results.");

       
            Assert.IsTrue(homePage.ActivityEdit.Displayed, "Edit button should be visible for the activity.");
            homePage.ActivityEdit.Click();
            Thread.Sleep(1000);

       
            SwitchToNewTab();
            Thread.Sleep(1000);

     
            Assert.IsTrue(homePage.ActivityEditdetails.Displayed, "Edit details button should be visible on the edit page.");
            homePage.ActivityEditdetails.Click();
            Thread.Sleep(1000);

       
            var activitystatus = driver.FindElement(By.XPath("//SELECT[@id='status']"));
            Assert.IsTrue(activitystatus.Displayed, "Status dropdown should be visible.");
            var statusSelect = new SelectElement(activitystatus);
            statusSelect.SelectByText("Published");
            Thread.Sleep(1000);

          
            Assert.AreEqual("Published", statusSelect.SelectedOption.Text, "Status should be set to 'Published'.");

            Assert.IsTrue(homePage.ActivityEditsave.Displayed, "Save button should be visible on the edit page.");
            homePage.ActivityEditsave.Click();
            Thread.Sleep(2000);       

}
        [Test, TestCaseSource(nameof(LoginJsonData)), Order(5)]
        public void PubDashboardSentioActivitesDelete(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);

     
            ScrollToElement(homePage.ViewActivities);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewActivities.Displayed, "Activities tab should be visible.");
            homePage.ViewActivities.Click();
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Activity search box should be visible on Activities page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);       
          
            Assert.IsTrue(homePage.ActivityEditDelete.Displayed, "Delete button should be visible for the activity.");
            homePage.ActivityEditDelete.Click();
            Thread.Sleep(2000);
                   
            homePage.ActivityEditDeleteconfirm1.Click();
            Thread.Sleep(2000);          
                 
        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(6)]
        public void PubDashboardSentioCoursesADD(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);

           
            ScrollToElement(homePage.ViewCoursespub);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewCoursespub.Displayed, "Courses tab should be visible.");
            homePage.ViewCoursespub.Click();
            Thread.Sleep(1000);

       
            Assert.IsTrue(homePage.Coursesadd.Displayed, "Add Course button should be visible on Courses page.");
            homePage.Coursesadd.Click();
            Thread.Sleep(1000);

           
            Assert.IsTrue(homePage.ActivityName.Displayed, "Course Name field should be visible.");
            homePage.ActivityName.Clear();
            homePage.ActivityName.SendKeys(PubActivityName);
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.Coursessave.Displayed, "Save button should be visible.");
            homePage.Coursessave.Click();
            Thread.Sleep(2000);

            var savedToast = driver.FindElements(By.XPath("//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'saved') or contains(text(),'created')]")).Count > 0;
            Assert.IsTrue(savedToast, "A success message/toast should appear after saving the course.");

           
            var createdCourse = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(createdCourse, $"New course '{PubActivityName}' should appear on the page after saving.");
        

        }
        [Test, TestCaseSource(nameof(LoginJsonData)), Order(7)]
        public void PubDashboardSentioCoursesPreview(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);

        
            ScrollToElement(homePage.ViewCoursespub);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewCoursespub.Displayed, "Courses tab should be visible.");
            homePage.ViewCoursespub.Click();
            Thread.Sleep(1000);

     
            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Courses page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);

         
            var resultMatch = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(resultMatch, $"Course '{PubActivityName}' should appear in search results.");

         
            Assert.IsTrue(homePage.ActivityPreview.Displayed, "Preview button should be visible for the course.");
            homePage.ActivityPreview.Click();
            Thread.Sleep(3000);

        
            var previewOverlayCount = driver.FindElements(By.XPath("//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']")).Count;
            Assert.IsTrue(previewOverlayCount > 0, "Preview dialog/overlay should be visible after clicking Preview.");

            var previewIframesCount = driver.FindElements(By.TagName("iframe")).Count;
            Assert.IsTrue(previewIframesCount > 0, "An iframe should be present for the preview content.");

          
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);

          
            Assert.IsTrue(homePage.ActivityPreviewmobile.Displayed, "Mobile preview toggle should be visible.");
            homePage.ActivityPreviewmobile.Click();
            Thread.Sleep(3000);

      
            var stillOpen = driver.FindElements(By.XPath("//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']")).Count;
            Assert.IsTrue(stillOpen > 0, "Preview dialog should remain open after switching to Mobile.");

          
            Assert.IsTrue(homePage.ActivityPreviewclose.Displayed, "Close button should be visible on the preview.");
            homePage.ActivityPreviewclose.Click();
            Thread.Sleep(3000);

        
        }


        [Test, TestCaseSource(nameof(LoginJsonData)), Order(8)]
        public void PubDashboardSentioCoursesEdit(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);

        
            ScrollToElement(homePage.ViewCoursespub);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewCoursespub.Displayed, "Courses tab should be visible.");
            homePage.ViewCoursespub.Click();
            Thread.Sleep(1000);

     
            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Courses page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

     
            var resultMatch = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(resultMatch, $"Course '{PubActivityName}' should appear in search results.");

     
            Assert.IsTrue(homePage.ActivityEdit.Displayed, "Edit button should be visible for the course.");
            homePage.ActivityEdit.Click();
            Thread.Sleep(1000);

    
            SwitchToNewTab();
            Thread.Sleep(1000);

      
            Assert.IsTrue(homePage.ActivityEditdetails.Displayed, "Edit details button should be visible on the edit page.");
            homePage.ActivityEditdetails.Click();
            Thread.Sleep(1000);

       
            var activitystatus = driver.FindElement(By.XPath("//SELECT[@id='status']"));
            Assert.IsTrue(activitystatus.Displayed, "Status dropdown should be visible.");
            var statusSelect = new SelectElement(activitystatus);
            statusSelect.SelectByText("Published");
            Thread.Sleep(1000);

         
            Assert.AreEqual("Published", statusSelect.SelectedOption.Text, "Status should be set to 'Published' before saving.");

       
            Assert.IsTrue(homePage.ActivityEditsave.Displayed, "Save button should be visible on the edit page.");
            homePage.ActivityEditsave.Click();
            Thread.Sleep(2000);

        
            var savedToast = driver.FindElements(By.XPath("//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'saved') or contains(text(),'updated')]")).Count > 0;
            Assert.IsTrue(savedToast, "A success message/toast should appear after saving changes.");

        
            var statusAfterSave = new SelectElement(driver.FindElement(By.XPath("//SELECT[@id='status']"))).SelectedOption.Text;
            Assert.AreEqual("Published", statusAfterSave, "Status should remain 'Published' after saving.");
        }


        [Test, TestCaseSource(nameof(LoginJsonData)), Order(9)]
        public void PubDashboardSentioCoursesDelete(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);

     
            ScrollToElement(homePage.ViewCoursespub);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewCoursespub.Displayed, "Courses tab should be visible.");
            homePage.ViewCoursespub.Click();
            Thread.Sleep(1000);

 
            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Courses page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

         
            var beforeDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(beforeDelete, $"Course '{PubActivityName}' should exist before deletion.");

           
            Assert.IsTrue(homePage.ActivityEditDelete.Displayed, "Delete button should be visible for the course.");
            homePage.ActivityEditDelete.Click();
            Thread.Sleep(1000);

        
            var confirmVisible = driver.FindElements(By.XPath("//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']")).Count > 0;
            Assert.IsTrue(confirmVisible, "Delete confirmation dialog should appear.");

            Assert.IsTrue(homePage.ActivityEditDeleteconfirm.Displayed, "Confirm Delete button should be visible.");
            homePage.ActivityEditDeleteconfirm.Click();
            Thread.Sleep(1000);

        
            var deleteToast = driver.FindElements(By.XPath("//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'deleted') or contains(text(),'removed')]")).Count > 0;
            Assert.IsTrue(deleteToast, "A success message/toast should appear after deleting the course.");

        
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(1500);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

            var afterDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count == 0;
            Assert.IsTrue(afterDelete, $"Course '{PubActivityName}' should no longer be present after deletion.");
        }


        [Test, TestCaseSource(nameof(LoginJsonData)), Order(10)]
        public void PubDashboardSentioProgramsADD(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);

     
            ScrollToElement(homePage.ViewProgramspub);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewProgramspub.Displayed, "Programs tab should be visible.");
            homePage.ViewProgramspub.Click();
            Thread.Sleep(1000);

    
            Assert.IsTrue(homePage.Coursesadd.Displayed, "Add Program button should be visible on Programs page.");
            homePage.Coursesadd.Click();
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.ActivityName.Displayed, "Program Name field should be visible.");
            homePage.ActivityName.Clear();
            homePage.ActivityName.SendKeys(PubActivityName);
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.Coursessave.Displayed, "Save button should be visible.");
            homePage.Coursessave.Click();
            Thread.Sleep(2000);

         
            var savedToast = driver.FindElements(By.XPath("//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'saved') or contains(text(),'created')]")).Count > 0;
            Assert.IsTrue(savedToast, "A success message/toast should appear after saving the program.");

            var createdProgram = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(createdProgram, $"New program '{PubActivityName}' should appear on the page after saving.");
        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(11)]
        public void PubDashboardSentioProgramsPreview(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);

            ScrollToElement(homePage.ViewProgramspub);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewProgramspub.Displayed, "Programs tab should be visible.");
            homePage.ViewProgramspub.Click();
            Thread.Sleep(1000);

        
            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Programs page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);

          
            var resultMatch = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(resultMatch, $"Program '{PubActivityName}' should appear in search results.");

       
            Assert.IsTrue(homePage.ActivityPreview.Displayed, "Preview button should be visible for the program.");
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


        [Test, TestCaseSource(nameof(LoginJsonData)), Order(12)]
        public void PubDashboardSentioProgramsEdit(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);

        
            ScrollToElement(homePage.ViewProgramspub);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewProgramspub.Displayed, "Programs tab should be visible.");
            homePage.ViewProgramspub.Click();
            Thread.Sleep(1000);

           
            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Programs page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

         
            var resultMatch = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(resultMatch, $"Program '{PubActivityName}' should appear in search results.");

          
            Assert.IsTrue(homePage.ActivityEdit.Displayed, "Edit button should be visible for the program.");
            homePage.ActivityEdit.Click();
            Thread.Sleep(1000);

      
            SwitchToNewTab();
            Thread.Sleep(1000);

      
            Assert.IsTrue(homePage.ActivityEditdetails.Displayed, "Edit details button should be visible on the edit page.");
            homePage.ActivityEditdetails.Click();
            Thread.Sleep(1000);

         
            var activitystatus = driver.FindElement(By.XPath("//SELECT[@id='status']"));
            Assert.IsTrue(activitystatus.Displayed, "Status dropdown should be visible.");
            var statusSelect = new SelectElement(activitystatus);
            statusSelect.SelectByText("Published");
            Thread.Sleep(1000);

        
            Assert.AreEqual("Published", statusSelect.SelectedOption.Text, "Status should be set to 'Published' before saving.");

         
            Assert.IsTrue(homePage.ActivityEditsave.Displayed, "Save button should be visible.");
            homePage.ActivityEditsave.Click();
            Thread.Sleep(2000);

       
            var savedToast = driver.FindElements(By.XPath("//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'saved') or contains(text(),'updated')]")).Count > 0;
            Assert.IsTrue(savedToast, "A success message/toast should appear after saving.");

       
            var statusAfterSave = new SelectElement(driver.FindElement(By.XPath("//SELECT[@id='status']"))).SelectedOption.Text;
            Assert.AreEqual("Published", statusAfterSave, "Status should remain 'Published' after saving.");
        }


        [Test, TestCaseSource(nameof(LoginJsonData)), Order(13)]
        public void PubDashboardSentioProgramsDelete(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);

     
            ScrollToElement(homePage.ViewProgramspub);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewProgramspub.Displayed, "Programs tab should be visible.");
            homePage.ViewProgramspub.Click();
            Thread.Sleep(1000);

          
            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Programs page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

       
            var beforeDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(beforeDelete, $"Program '{PubActivityName}' should be present before deletion.");

         
            Assert.IsTrue(homePage.ActivityEditDelete.Displayed, "Delete button should be visible for the program.");
            homePage.ActivityEditDelete.Click();
            Thread.Sleep(1000);

    
            var confirmVisible = driver.FindElements(By.XPath("//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']")).Count > 0;
            Assert.IsTrue(confirmVisible, "Delete confirmation dialog should appear.");

            Assert.IsTrue(homePage.ActivityEditDeleteconfirm.Displayed, "Confirm Delete button should be visible.");
            homePage.ActivityEditDeleteconfirm.Click();
            Thread.Sleep(1000);

            var deleteToast = driver.FindElements(By.XPath("//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'deleted') or contains(text(),'removed')]")).Count > 0;
            Assert.IsTrue(deleteToast, "A success message/toast should appear after deleting the program.");

           
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(1500);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

            var afterDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count == 0;
            Assert.IsTrue(afterDelete, $"Program '{PubActivityName}' should no longer be present after deletion.");
        }


        [Test, TestCaseSource(nameof(LoginJsonData)), Order(14)]
        public void PubDashboardSentioPagesADD(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);

  
            ScrollToElement(homePage.ViewPagespub);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewPagespub.Displayed, "Pages tab should be visible.");
            homePage.ViewPagespub.Click();
            Thread.Sleep(1000);


            Assert.IsTrue(homePage.Coursesadd.Displayed, "Add Page button should be visible on Pages page.");
            homePage.Coursesadd.Click();
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.ActivityName.Displayed, "Page Name field should be visible.");
            homePage.ActivityName.Clear();
            homePage.ActivityName.SendKeys(PubActivityName);
            Thread.Sleep(1000);

            Assert.IsTrue(homePage.Pagesave.Displayed, "Save button should be visible.");
            homePage.Pagesave.Click();
            Thread.Sleep(2000);

      
            var savedToast = driver.FindElements(By.XPath("//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'saved') or contains(text(),'created')]")).Count > 0;
            Assert.IsTrue(savedToast, "A success message/toast should appear after saving the page.");

           
            var createdPage = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(createdPage, $"New page '{PubActivityName}' should appear on the page after saving.");
        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(15)]
        public void PubDashboardSentioPagesPreview(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
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

          
            var resultMatch = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(resultMatch, $"Page '{PubActivityName}' should appear in search results.");

      
            Assert.IsTrue(homePage.ActivityPreview.Displayed, "Preview button should be visible for the page.");
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

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(16)]
        public void PubDashboardSentioPagesEdit(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);

           
            ScrollToElement(homePage.ViewPagespub);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewPagespub.Displayed, "Pages tab should be visible.");
            homePage.ViewPagespub.Click();
            Thread.Sleep(1000);

    
            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Pages page.");
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

        
            var resultMatch = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(resultMatch, $"Page '{PubActivityName}' should appear in search results.");

            Assert.IsTrue(homePage.ActivityEdit.Displayed, "Edit button should be visible for the page.");
            homePage.ActivityEdit.Click();
            Thread.Sleep(1000);

         
            SwitchToNewTab();
            Thread.Sleep(1000);

 
            Assert.IsTrue(homePage.Pageedit.Displayed, "Page edit section/button should be visible.");
            homePage.Pageedit.Click();
            Thread.Sleep(1000);

         
            var activitystatus = driver.FindElement(By.XPath("//SELECT[@id='status']"));
            Assert.IsTrue(activitystatus.Displayed, "Status dropdown should be visible.");
            var statusSelect = new SelectElement(activitystatus);
            statusSelect.SelectByText("Published");
            Thread.Sleep(1000);

       
            Assert.AreEqual("Published", statusSelect.SelectedOption.Text, "Status should be set to 'Published' before saving.");

           
            Assert.IsTrue(homePage.Pagesave.Displayed, "Save button should be visible on the edit page.");
            homePage.Pagesave.Click();
            Thread.Sleep(2000);

         
            var savedToast = driver.FindElements(By.XPath("//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'saved') or contains(text(),'updated')]")).Count > 0;
            Assert.IsTrue(savedToast, "A success message/toast should appear after saving.");

       
            var statusAfterSave = new SelectElement(driver.FindElement(By.XPath("//SELECT[@id='status']"))).SelectedOption.Text;
            Assert.AreEqual("Published", statusAfterSave, "Status should remain 'Published' after saving.");
        }

        [Test, TestCaseSource(nameof(LoginJsonData)), Order(17)]
        public void PubDashboardSentioPagesDelete(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
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

           
            Assert.IsTrue(homePage.ActivityEditDelete.Displayed, "Delete button should be visible for the page.");
            homePage.ActivityEditDelete.Click();
            Thread.Sleep(1000);

        
            var confirmVisible = driver.FindElements(By.XPath("//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']")).Count > 0;
            Assert.IsTrue(confirmVisible, "Delete confirmation dialog should appear.");

            Assert.IsTrue(homePage.ActivityEditDeleteconfirm.Displayed, "Confirm Delete button should be visible.");
            homePage.ActivityEditDeleteconfirm.Click();
            Thread.Sleep(1000);

          
            var deleteToast = driver.FindElements(By.XPath("//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'deleted') or contains(text(),'removed')]")).Count > 0;
            Assert.IsTrue(deleteToast, "A success message/toast should appear after deleting the page.");

      
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(1500);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

            var afterDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count == 0;
            Assert.IsTrue(afterDelete, $"Page '{PubActivityName}' should no longer be present after deletion.");
        }


        [Test, TestCaseSource(nameof(LoginJsonData)), Order(18)]
        public void PubDashboardSentioAssetsADD(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);

         
            ScrollToElement(homePage.ViewAssets);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewAssets.Displayed, "Assets tab should be visible.");
            homePage.ViewAssets.Click();
            Thread.Sleep(1000);

           
            Assert.IsTrue(homePage.Coursesadd.Displayed, "Add Asset button should be visible on Assets page.");
            homePage.Coursesadd.Click();
            Thread.Sleep(2000);


            string fileToUpload = Path.GetFullPath("C:\\Users\\dpatel\\Source\\repos\\Homeweb 3.0 Tests\\TestData\\SampleAsset.txt");
            Assert.IsTrue(File.Exists(fileToUpload), $"Test file '{fileToUpload}' must exist before upload.");
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

       
            var savedToast = driver.FindElements(By.XPath("//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'uploaded') or contains(text(),'saved') or contains(text(),'created')]")).Count > 0;
            Assert.IsTrue(savedToast, "A success message/toast should appear after uploading the asset.");

         
            var createdAsset = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(createdAsset, $"New asset '{PubActivityName}' should appear in the list after saving.");
        }



        [Test, TestCaseSource(nameof(LoginJsonData)), Order(19)]
        public void PubDashboardSentioAssetsEdit(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);

       
            ScrollToElement(homePage.ViewAssets);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewAssets.Displayed, "Assets tab should be visible.");
            homePage.ViewAssets.Click();
            Thread.Sleep(1000);

           
            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Assets page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

       
            var beforeEdit = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(beforeEdit, $"Asset '{PubActivityName}' should be present before editing.");

            
            Assert.IsTrue(homePage.ActivityEdit.Displayed, "Edit button should be visible for the asset.");
            homePage.ActivityEdit.Click();
            Thread.Sleep(1000);

     
            Assert.IsTrue(homePage.AssetName.Displayed, "Asset Name field should be visible.");
            homePage.AssetName.Clear();
            Thread.Sleep(1000);
            homePage.AssetName.SendKeys(PubActivityName + " Updated"); 
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


        [Test, TestCaseSource(nameof(LoginJsonData)), Order(20)]
        public void PubDashboardSentioAssetsDelete(string PubEmail, string PubPassword, string PubUrl, string PubActivityName)
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

            ScrollToElement(homePage.LaunchPubSentio);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.LaunchPubSentio.Displayed, "Sentio option should be visible.");
            homePage.LaunchPubSentio.Click();
            Thread.Sleep(1000);

         
            ScrollToElement(homePage.ViewAssets);
            Thread.Sleep(1000);
            Assert.IsTrue(homePage.ViewAssets.Displayed, "Assets tab should be visible.");
            homePage.ViewAssets.Click();
            Thread.Sleep(1000);

        
            Assert.IsTrue(homePage.ActivitySearch.Displayed, "Search box should be visible on Assets page.");
            homePage.ActivitySearch.Clear();
            homePage.ActivitySearch.SendKeys(PubActivityName);
            Thread.Sleep(2000);
            homePage.ActivitySearch.Submit();
            Thread.Sleep(1000);

         
            var beforeDelete = driver.FindElements(By.XPath($"//*[contains(text(), '{PubActivityName}')]")).Count > 0;
            Assert.IsTrue(beforeDelete, $"Asset '{PubActivityName}' should be present before deletion.");

          
            Assert.IsTrue(homePage.ActivityEditDelete.Displayed, "Delete button should be visible for the asset.");
            homePage.ActivityEditDelete.Click();
            Thread.Sleep(1000);

         
            var confirmVisible = driver.FindElements(By.XPath("//*[contains(@class,'modal') or contains(@class,'dialog') or @role='dialog']")).Count > 0;
            Assert.IsTrue(confirmVisible, "Delete confirmation dialog should appear.");

            Assert.IsTrue(homePage.ActivityEditDeleteconfirm.Displayed, "Confirm Delete button should be visible.");
            homePage.ActivityEditDeleteconfirm.Click();
            Thread.Sleep(1000);

       
            var deleteToast = driver.FindElements(By.XPath("//*[contains(@class,'toast') or contains(@class,'alert') or contains(text(),'deleted') or contains(text(),'removed')]")).Count > 0;
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

