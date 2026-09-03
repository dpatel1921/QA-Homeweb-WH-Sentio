/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace WarriorHealthBeta.TestCases
{
    [TestFixture]
    public class WarriorHealthAdminPortalSmokeTests : AuthenticatedTestBase
    {
        protected bool IsElementDisplayed(By locator)
        {
            return driver
                .FindElements(locator)
                .Any(e => e.Displayed);
        }


        [Test, Order(1)]
        public void WHSideBar()
        {
            test.Info("Tests for sidebar links");
            WH.Enrollments.Click();
            Thread.Sleep(1000);
            WH.Organizations.Click();
            Thread.Sleep(1000);
            WH.Sidebar.Click();
            Thread.Sleep(1000);
            WH.Sidebar1.Click();
            Thread.Sleep(1000);
            WH.Sidebar2.Click();
            Thread.Sleep(1000);
            WH.Sidebar3.Click();
            Thread.Sleep(1000);
            WH.Sidebar4.Click();
            Thread.Sleep(1000);
            WH.Sidebar5.Click();
            Thread.Sleep(1000);
            ScrollToElement(WH.Sidebar7);
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
            ScrollToElement(WH.EnrollmentsLan);
            Thread.Sleep(1000);
            WH.EnrollmentsLan.Click();
            Thread.Sleep(1000);
            WH.EnrollmentsLanEN.Click();
            Thread.Sleep(1000);
           



        }
        [Test, Order(2)]
        public void Enrollments()
        {
            test.Info("Test for Enrollments");
            WH.Enrollments.Click();
            Thread.Sleep(1000);
            WH.EnrollmentsLan.Click();
            Thread.Sleep(1000);
            WH.EnrollmentsLanEN.Click();
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='userStatusFilter']"));
            new SelectElement(dropdown).SelectByText("Approved");
            Thread.Sleep(2000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='userStatusFilter']"));
            new SelectElement(dropdown1).SelectByText("Pending");
            Thread.Sleep(2000);
            var dropdown2 = driver.FindElement(By.XPath("//SELECT[@id='userStatusFilter']"));
            new SelectElement(dropdown2).SelectByText("Denied");
            Thread.Sleep(2000);
            WH.Search.SendKeys(Config.SearchInvalid);
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.SearchValid);
            Thread.Sleep(1000);
            WH.EnrollmentsLan.Click();
            Thread.Sleep(1000);
            WH.EnrollmentsLanEN.Click();
            Thread.Sleep(1000);

        }

        [Test, Order(3)]
        public void OrganizationsAdd()
        {
            test.Info("Test for Organization Add");
            WH.Organizations.Click();
            Thread.Sleep(1000);
            WH.EnrollmentsLan.Click();
            Thread.Sleep(1000);
            WH.EnrollmentsLanEN.Click();
            Thread.Sleep(1000);
            WH.OrgAdd.Click();
            Thread.Sleep(1000);
            WH.OrgName.SendKeys(Config.Name);
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='orgType']"));
            new SelectElement(dropdown).SelectByText("Founder");
            WH.OrgAddress.SendKeys(Config.Address);
            Thread.Sleep(1000);
            WH.OrgCity.SendKeys(Config.City);
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='province']"));
            new SelectElement(dropdown1).SelectByText("Ontario");
            WH.OrgPostal.SendKeys(Config.PostalCode);
            Thread.Sleep(1000);
            WH.OrgCreate.Click();
            Thread.Sleep(2000);
            try
            {
                ScrollToElement(WH.OrgClose);
                Thread.Sleep(1000);
                WH.OrgClose.Click();
                Thread.Sleep(1000);
            }

            catch{



            }


        }

        [Test, Order(4)]
        public void OrganizationsContinue()
        {
            test.Info("Tests for Org Filters");
            WH.Organizations.Click();
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("//select[@id='orgTypeFilter']"));
            new SelectElement(dropdown).SelectByText("Founder");
            Thread.Sleep(1000); 
            var dropdown2 = driver.FindElement(By.XPath("//select[@id='orgTypeFilter']"));
            new SelectElement(dropdown2).SelectByText("Partner");
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='orgStatusFilter']"));
            new SelectElement(dropdown1).SelectByText("Active");
            Thread.Sleep(1000);
            WH.OrgProfile.Click();
            Thread.Sleep(1000);
            WH.Back.Click();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.SearchInvalid);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Search.Clear();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.SearchValid);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.OrgDelete.Click();
            Thread.Sleep(1000);
            try
            {
                ScrollToElement(WH.OrgDelete1);
                Thread.Sleep(1000);
                WH.OrgDelete1.Click();
                Thread.Sleep(1000);
                WH.OrgDelete2.Click();
                Thread.Sleep(1000);
            }
            catch (Exception ex) { }


        }
        [Test, Order(5)]
        public void OrganizationProfile()
        {
            test.Info("Tests for Org Edit");
            WH.Organizations.Click();
            Thread.Sleep(2000);
            WH.OrgProfile.Click();
            Thread.Sleep(1000);
            WH.OrgLan.Click();
            Thread.Sleep(1000);
            WH.OrgLanEn.Click();
            Thread.Sleep(1000);
            WH.OrgNamechange.Clear();
            Thread.Sleep(1000);
            WH.OrgNamechange.SendKeys(Config.OrgName);
            Thread.Sleep(2000);
            ScrollToElement(WH.OrgNamesave);
            Thread.Sleep(1000);
            WH.OrgNamesave.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//div[@class='alert-header']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");
            Thread.Sleep(1000);
            WH.Slogan.Clear();
            Thread.Sleep(1000);
            WH.Slogan.SendKeys(Config.Slogan);
            Thread.Sleep(1000);
            ScrollToElement(WH.OrgNamesave);
            Thread.Sleep(1000);
            WH.OrgNamesave.Click();
            Thread.Sleep(1000);
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");
       


        }

        [Test, Order(6)]
        public void OrganizationProfileInfo()
        {
            test.Info("Tests for Orgs Status");
            WH.Organizations.Click();
            Thread.Sleep(2000);
            WH.OrgProfile.Click();
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//select[@id='status']"));
            new SelectElement(dropdown).SelectByText("Inactive");
            Thread.Sleep(1000);
            WH.Infosave.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//div[@class='alert-header']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//select[@id='status']"));
            new SelectElement(dropdown1).SelectByText("Active");
            Thread.Sleep(1000);
            WH.Infosave.Click();
            Thread.Sleep(1000);
            Assert.IsTrue(
              IsElementDisplayed(bannerLocator),
              "Banner appearing on page");
            


        }
        [Test, Order(7)]
        public void OrganizationProfileLocation()
        {
            test.Info("Tests for Orgs Location");
            WH.Organizations.Click();
            Thread.Sleep(2000);
            WH.OrgProfile.Click();
            Thread.Sleep(1000);
            ScrollToElement(WH.AddressInfo);
            Thread.Sleep(1000);
            WH.AddressInfo.Clear();
            Thread.Sleep(1000);
            WH.AddressInfo.SendKeys(Config.AddressLoc);
            Thread.Sleep(1000);
            WH.AddressSave.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//div[@class='alert-header']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");
            Thread.Sleep(1000);
            ScrollToElement(WH.AddressInfo);
            Thread.Sleep(1000);
            WH.AddressInfo.Clear();
            Thread.Sleep(1000);
            WH.AddressInfo.SendKeys(Config.Address);
            Thread.Sleep(1000);
            WH.AddressSave.Click();
            Thread.Sleep(1000);
            Assert.IsTrue(
             IsElementDisplayed(bannerLocator),
             "Banner appearing on page");
         


        }
        [Test, Order(8)]
        public void OrganizationProfileContact()
        {
            test.Info("Tests for Orgs Profile");
            WH.Organizations.Click();
            Thread.Sleep(2000);
            WH.OrgProfile.Click();
            Thread.Sleep(1000);
            ScrollToElement(WH.Phone);
            Thread.Sleep(1000);
            WH.Phone.Clear();
            Thread.Sleep(1000);
            WH.Phone.SendKeys(Config.Phone);
            Thread.Sleep(1000);
            WH.Contactsave.Click();
            Thread.Sleep(1000);
         
      
            
        }
        
        [Test, Order(9)]
        public void UsersDigestuserexist()
        {
            test.Info("Tests for Users existing or not");
            WH.Sidebar.Click();
            Thread.Sleep(2000);
            WH.AddUser.Click();
            Thread.Sleep(1000);
            WH.Firstname.SendKeys(Config.FirstName);
            Thread.Sleep(1000);
            WH.Lastname.SendKeys(Config.LastName);
            Thread.Sleep(1000);
            WH.EmailInput.SendKeys(Config.Email);
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='organization']"));
            new SelectElement(dropdown).SelectByText("CAMH");
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='role']"));
            new SelectElement(dropdown1).SelectByText("ROLE_GLOBAL_ADMIN");
            Thread.Sleep(1000);
            var dropdown2 = driver.FindElement(By.XPath("//SELECT[@id='status']"));
            new SelectElement(dropdown2).SelectByText("Active");
            Thread.Sleep(1000);
            var dropdown3 = driver.FindElement(By.XPath("//SELECT[@id='locale']"));
            new SelectElement(dropdown3).SelectByText("English");
            Thread.Sleep(1000);
            var dropdown4 = driver.FindElement(By.XPath("//SELECT[@id='timezone']"));
            new SelectElement(dropdown4).SelectByText("Pacific");
            Thread.Sleep(1000);
            WH.Usersave.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//DIV[@class='alert-message'][text()='User already exists']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");
            Thread.Sleep(1000);
            ScrollToElement(WH.Userclose);
            Thread.Sleep(1000);
            WH.Userclose.Click();
            Thread.Sleep(1000);
            

            


        }
        [Test, Order(10)]
        public void UsersDigestnewuser()
        {
            test.Info("Tests for adding new user");
            WH.Sidebar.Click();
            Thread.Sleep(2000);
            WH.AddUser.Click();
            Thread.Sleep(1000);
            WH.Firstname.SendKeys(Config.FirstName);
            Thread.Sleep(1000);
            WH.Lastname.SendKeys(Config.LastName);
            Thread.Sleep(1000);
            WH.EmailInput.SendKeys(Config.EmailNew);
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='organization']"));
            new SelectElement(dropdown).SelectByText("CAMH");
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='role']"));
            new SelectElement(dropdown1).SelectByText("ROLE_GLOBAL_ADMIN");
            Thread.Sleep(1000);
            var dropdown2 = driver.FindElement(By.XPath("//SELECT[@id='status']"));
            new SelectElement(dropdown2).SelectByText("Active");
            Thread.Sleep(1000);
            var dropdown3 = driver.FindElement(By.XPath("//SELECT[@id='locale']"));
            new SelectElement(dropdown3).SelectByText("English");
            Thread.Sleep(1000);
            var dropdown4 = driver.FindElement(By.XPath("//SELECT[@id='timezone']"));
            new SelectElement(dropdown4).SelectByText("Pacific");
            Thread.Sleep(1000);
            WH.Usersave.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//div[@class='alert-header']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");
            Thread.Sleep(1000);


          


        }
        [Test, Order(11)]
        public void UsersDigestFilters()
        {
            test.Info("Tests for User Filters");
            WH.Sidebar.Click();
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("//select[@id='userRoleFilter']"));
            new SelectElement(dropdown).SelectByText("ROLE_GLOBAL_ADMIN");
            Thread.Sleep(2000);
            var dropdown1 = driver.FindElement(By.XPath("//select[@id='userStatusFilter']"));
            new SelectElement(dropdown1).SelectByText("Active");
            Thread.Sleep(2000);
            WH.Search.SendKeys(Config.SearchInvalid);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Search.Clear();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.SearchValid);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
       


        }
        [Test, Order(12)]
        public void UsersDigestEditUser()
        {
            test.Info("Tests for Edit User");
            WH.Sidebar.Click();
            Thread.Sleep(2000);
            WH.Edituser1.Click();
            Thread.Sleep(1000);
            WH.EditPhone.Clear();
            Thread.Sleep(1000);
            WH.EditPhone.SendKeys(Config.Phone);
            Thread.Sleep(1000);
            ScrollToElement(WH.EditSave);
            Thread.Sleep(1000);
            WH.EditSave.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//div[@class='alert-header']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");
            Thread.Sleep(1000);
            WH.EditPhone.Clear();
            Thread.Sleep(1000);
            WH.EditPhone.SendKeys(Config.Phonereal);
            Thread.Sleep(1000);
            ScrollToElement(WH.EditSave);
            Thread.Sleep(1000);
            WH.EditSave.Click();
            Assert.IsTrue(
             IsElementDisplayed(bannerLocator),
             "Banner appearing on page");
          


        }
        [Test, Order(13)]
        public void UsersDigestSearchUser()
        {
            test.Info("Tests for search User");
            WH.Sidebar.Click();
            Thread.Sleep(2000);
            WH.Search.SendKeys(Config.SearchName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Search.Clear();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.SearchNameValid);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            


        }
        [Test , Order(14)]
        public void UsersDigestDeleteUser()
        {
            test.Info("Tests for delete user");
            WH.Sidebar.Click();
            Thread.Sleep(2000);
            ScrollToElement(WH.DeleteUser);
            Thread.Sleep(1000);
            WH.DeleteUser.Click();
            Thread.Sleep(1000);
            WH.Deletebutton.Click();
            Thread.Sleep(1000);
            WH.Deleteselect.Click();
            Thread.Sleep(1000);
       


        }
        [Test, Order(15)]
        public void RequisitionsDigestFilter()
        {
            test.Info("Tests for Requisition Filters");
            WH.Sidebar1.Click();
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("//select[@id='reqFilter']"));
            new SelectElement(dropdown).SelectByText("Initiated");
            Thread.Sleep(1000);
            WH.ReqVendor.SendKeys(Config.ReqVendor);
            Thread.Sleep(1000);
            Actions act = new Actions(driver);
            act.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(1000);
            WH.ReqCustomer.SendKeys(Config.ReqCustomer);
            Thread.Sleep(1000);
            act.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
           

       


        }
        [Test, Order(16)]
        public void RequisitionsDigestSearchProcessed()
        {
            test.Info("Tests for Req Search and Processed");
            WH.Sidebar1.Click();
            Thread.Sleep(2000);
            WH.Search.SendKeys(Config.SKUWrng);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Search.Clear();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.SKU);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Processed.Click();
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//select[@id='reqFilter']"));
            new SelectElement(dropdown).SelectByText("Delivered");
            Thread.Sleep(1000);
            WH.ReqVendor.SendKeys(Config.ReqVendor);
            Thread.Sleep(1000);
            Actions act = new Actions(driver);
            act.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            WH.Search.SendKeys(Config.SKUWrng);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Search.Clear();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.SKUPro);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
       


        }
        [Test, Order(17)]
        public void PaidServicesDigest()
        {
            test.Info("Tests for Paid Services");
            WH.Sidebar2.Click();
            Thread.Sleep(2000);
            WH.OrgAdd.Click();
            Thread.Sleep(2000);
            WH.PaidService.SendKeys(Config.ServiceTitle);
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("//select[@aria-label='Select']"));
            new SelectElement(dropdown).SelectByText("CAMH");
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//select[@aria-label='Intensity']"));
            new SelectElement(dropdown1).SelectByText("Severe");
            Thread.Sleep(1000);
            WH.PaidServicecreate.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//div[@class='alert-header']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");
      


        }
        [Test, Order(18)]
        public void PaidServicesDigestFilters()
        {
            test.Info("Tests for Paid services filters");
            WH.Sidebar2.Click();
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("(//select[@aria-label='Sort'])[1]"));
            new SelectElement(dropdown).SelectByText("CAMH");
            Thread.Sleep(2000);
            var dropdown1 = driver.FindElement(By.XPath("(//select[@aria-label='Sort'])[2]"));
            new SelectElement(dropdown1).SelectByText("Draft");
            Thread.Sleep(2000);
            WH.Search.SendKeys(Config.SearchName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Search.Clear();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.PaidServiceselect.Click();
            Thread.Sleep(1000);
            WH.ServiceBack.Click();
            Thread.Sleep(1000);
        
          

        }
        [Test, Order(19)]
        public void PaidServicesDetails()
        {
            test.Info("Tests for Paid services details");
            WH.Sidebar2.Click();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.PaidServiceselect.Click();
            Thread.Sleep(1000);
            WH.ServiceTitle.Clear();
            Thread.Sleep(1000);
            WH.ServiceTitle.SendKeys(Config.PaidServiceName);
            Thread.Sleep(1000);
            WH.Servicesave.Click();
              

        }
        [Test, Order(20)]
        public void PaidServicesDetailsinfo()
        {
            test.Info("Tests for paid services info");
            WH.Sidebar2.Click();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.PaidServiceselect.Click();
            Thread.Sleep(1000);
            WH.OrgLan.Click();
            Thread.Sleep(1000);
            WH.OrgLanEn.Click();
            Thread.Sleep(1000);
            ScrollToElement(WH.Servicesave1);
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//select[@aria-label='Status']"));
            new SelectElement(dropdown).SelectByText("Ready for Review");
            Thread.Sleep(1000);
            WH.Servicesave1.Click();
            Thread.Sleep(1000);
            ScrollToElement(WH.Servicesave1);
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//select[@aria-label='Intensity']"));
            new SelectElement(dropdown1).SelectByText("Severe");
            Thread.Sleep(1000);
            WH.Servicesave1.Click();
            Thread.Sleep(1000);
        


        }
        [Test, Order(21)]
        public void PaidServicesDetailsPricing()
        {
            test.Info("Tests for paid services pricing");
            WH.Sidebar2.Click();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.PaidServiceselect.Click();
            Thread.Sleep(1000);
            WH.Pricingremove.Click();
            Thread.Sleep(1000);

            WH.Servicepricing.Click();
            Thread.Sleep(1000);
            WH.Servicepricing1.Click();
            Thread.Sleep(1000);
            ScrollToElement(WH.Servicepricingsave);
            Thread.Sleep(1000);
            WH.Servicepricingsku.SendKeys(Config.Service1);
            Thread.Sleep(1000);
            WH.Servicepricingprice.SendKeys(Config.Service2);
            Thread.Sleep(1000);
            WH.Servicepricingmin.SendKeys(Config.Service3);
            Thread.Sleep(1000);
            WH.Servicepricingmax.SendKeys(Config.Service4);
            Thread.Sleep(1000);
            WH.Servicepricingdate.Click();
            Thread.Sleep(1000);
            WH.Servicepricingdate2.Click();
            Thread.Sleep(1000);
            WH.Servicepricingdate1.Click();
            Thread.Sleep(1000);
            WH.Servicepricingsave.Click();
            Thread.Sleep(1000);
          


        }
        [Test, Order(22)]
        public void FreeServicesDigest()
        {
            test.Info("Tests for Free services");
            WH.Sidebar3.Click();
            Thread.Sleep(2000);
            WH.OrgAdd.Click();
            Thread.Sleep(2000);
            WH.PaidService.SendKeys(Config.ServiceTitle);
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("//select[@aria-label='Select']"));
            new SelectElement(dropdown).SelectByText("CAMH");
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//select[@aria-label='Intensity']"));
            new SelectElement(dropdown1).SelectByText("Severe");
            Thread.Sleep(1000);
            WH.PaidServicecreate.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//div[@class='alert-header']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");



        }
        [Test, Order(23)]
        public void FreeServicesDigestFilters()
        {
            test.Info("Tests for free services filters");
            WH.Sidebar3.Click();
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("(//select[@aria-label='Sort'])[1]"));
            new SelectElement(dropdown).SelectByText("CAMH");
            Thread.Sleep(2000);
            var dropdown1 = driver.FindElement(By.XPath("(//select[@aria-label='Sort'])[2]"));
            new SelectElement(dropdown1).SelectByText("Draft");
            Thread.Sleep(2000);
            WH.Search.SendKeys(Config.SearchName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Search.Clear();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Freeserviceselect.Click();
            Thread.Sleep(1000);
            WH.Freeserviceback.Click();
            Thread.Sleep(1000);
          


        }
        [Test, Order(24)]
        public void FreeServicesDetails()
        {
            test.Info("Tests for free services details");
            WH.Sidebar3.Click();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Freeserviceselect.Click();
            Thread.Sleep(1000);
            WH.ServiceTitle.Clear();
            Thread.Sleep(1000);
            WH.ServiceTitle.SendKeys(Config.PaidServiceName);
            Thread.Sleep(1000);
            WH.Freeservicesummary.SendKeys(Config.PaidServiceName);
            Thread.Sleep(1000);
            ScrollToElement(WH.Freeservicesummarybutton);
            Thread.Sleep(1000);
            WH.Freeservicesummarybutton.Click();
        



        }
        [Test, Order(25)]
        public void FreeServicesDetailsinfo()
        {
            test.Info("Tests for free services status");
            WH.Sidebar3.Click();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Freeserviceselect.Click();
            Thread.Sleep(1000);
            WH.OrgLan.Click();
            Thread.Sleep(1000);
            WH.OrgLanEn.Click();
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//select[@aria-label='Status']"));
            new SelectElement(dropdown).SelectByText("Ready for Review");
            Thread.Sleep(1000);
            WH.Servicesave1.Click();
        
            Thread.Sleep(1000);
            ScrollToElement(WH.Servicesave1);
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//select[@aria-label='Intensity']"));
            new SelectElement(dropdown1).SelectByText("Severe");
            Thread.Sleep(1000);
            WH.Servicesave1.Click();
            Thread.Sleep(1000);
          


        }
        [Test, Order(26)]
        public void FreeServicesAccess()
        {
            test.Info("Tests for free service access");
            WH.Sidebar3.Click();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Freeserviceselect.Click();
            Thread.Sleep(1000);
            ScrollToElement(WH.Freeservicesaccess);
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='link-type']"));
            new SelectElement(dropdown).SelectByText("Email address");
            Thread.Sleep(1000);
            WH.Freeservicesaccessemail.Clear();
            Thread.Sleep(1000);
            WH.Freeservicesaccessemail.SendKeys(Config.EmailNew);
            Thread.Sleep(1000);
            WH.Freeservicesaccess.Click();
            Thread.Sleep(1000);
        



        }
        [Test, Order(27)]
        public void ResourcesDigest()
        {
            test.Info("Tests for resource create");
            WH.Sidebar4.Click();
            Thread.Sleep(2000);
            WH.OrgAdd.Click();
            Thread.Sleep(2000);
            WH.PaidService.SendKeys(Config.ServiceTitle);
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("//select[@aria-label='Select']"));
            new SelectElement(dropdown).SelectByText("CAMH");
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//select[@aria-label='Intensity']"));
            new SelectElement(dropdown1).SelectByText("Severe");
            Thread.Sleep(1000);
            WH.PaidServicecreate.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//div[@class='alert-header']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");


        }
        [Test, Order(28)]
        public void ResourcesFilters()
        {
            test.Info("Tests for resource filter");
            WH.Sidebar4.Click();
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("(//select[@aria-label='Sort'])[1]"));
            new SelectElement(dropdown).SelectByText("CAMH");
            Thread.Sleep(2000);
            var dropdown1 = driver.FindElement(By.XPath("(//select[@aria-label='Sort'])[2]"));
            new SelectElement(dropdown1).SelectByText("Draft");
            Thread.Sleep(2000);
            WH.Search.SendKeys(Config.SearchName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Search.Clear();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Freeserviceselect.Click();
            Thread.Sleep(1000);
            WH.Resourcesback.Click();
            Thread.Sleep(1000);
          


        }
        [Test, Order(29)]
        public void ResourcesDetails()
        {
            test.Info("Tests for resource edit");
            WH.Sidebar4.Click();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Freeserviceselect.Click();
            Thread.Sleep(1000);
            WH.ServiceTitle.Clear();
            Thread.Sleep(1000);
            WH.ServiceTitle.SendKeys(Config.PaidServiceName);
            Thread.Sleep(1000);
            WH.Freeservicesummary.SendKeys(Config.PaidServiceName);
            Thread.Sleep(1000);
            ScrollToElement(WH.Freeservicesummarybutton);
            Thread.Sleep(1000);
            WH.Freeservicesummarybutton.Click();
           
   


        }
        [Test, Order(30)]
        public void ResourcesDetailsinfo()
        {
            test.Info("Tests for resource info");
            WH.Sidebar4.Click();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Freeserviceselect.Click();
            Thread.Sleep(1000);
            WH.OrgLan.Click();
            Thread.Sleep(1000);
            WH.OrgLanEn.Click();
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//select[@aria-label='Status']"));
            new SelectElement(dropdown).SelectByText("Ready for Review");
            Thread.Sleep(1000);
            WH.Servicesave1.Click();
         
            Thread.Sleep(1000);
            ScrollToElement(WH.Servicesave1);
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//select[@aria-label='Intensity']"));
            new SelectElement(dropdown1).SelectByText("Severe");
            Thread.Sleep(1000);
            WH.Servicesave1.Click();
            Thread.Sleep(1000);
       
    


        }
        [Test, Order(31)]
        public void ResourcesDelete()
        {
            test.Info("Tests for resource delete");
            WH.Sidebar4.Click();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Freeserviceselect.Click();
            Thread.Sleep(1000);
            ScrollToElement(WH.ResourcesDelete);
            Thread.Sleep(1000);
            WH.ResourcesDelete.Click();
            Thread.Sleep(1000);
            WH.ResourcesDelete1.Click();
            Thread.Sleep(1000);
      
         


        }
        [Test, Order(32)]
        public void MailingFilters()
        {
            test.Info("Tests for Mailing filters");
            WH.Sidebar5.Click();
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='subscriberType']"));
            new SelectElement(dropdown).SelectByText("Individual");
            Thread.Sleep(2000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='subscriberType']"));
            new SelectElement(dropdown1).SelectByText("Organization");
            Thread.Sleep(2000);
            WH.Search.SendKeys(Config.SearchName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
            WH.Search.Clear();
            Thread.Sleep(1000);
            WH.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WH.Search.Submit();
            Thread.Sleep(1000);
       


        }
        [Test, Order(33)]
        public void MailinglistDelete()
        {
            test.Info("Tests for Mailing delete");
            WH.Sidebar5.Click();
            Thread.Sleep(1000);
            ScrollToElement(WH.MailinglistDelete);
            Thread.Sleep(1000);
            WH.MailinglistDelete.Click();
            Thread.Sleep(1000);
            WH.MailinglistDelete1.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//div[@class='alert-header']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");
       

        }
    }
}*/
