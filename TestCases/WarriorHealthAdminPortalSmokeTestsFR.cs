/*using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorHealthBeta.TestCases
{
    [TestFixture]
    public class WarriorHealthAdminPortalSmokeTestsFR : AuthenticatedTestBase
    {
        protected bool IsElementDisplayed(By locator)
        {
            return driver
                .FindElements(locator)
                .Any(e => e.Displayed);
        }
        [Test, Order(1)]
        public void WHSideBarFR()
        {
            test.Info("Tests for sidebar links");
            Thread.Sleep(2000);
            WHFR.EnrollmentsLan.Click();
            Thread.Sleep(1000);
            WHFR.Enrollments.Click();
            Thread.Sleep(1000);
            WHFR.Organizations.Click();
            Thread.Sleep(1000);
            WHFR.Sidebar.Click();
            Thread.Sleep(1000);
            WHFR.Sidebar1.Click();
            Thread.Sleep(1000);
            WHFR.Sidebar2.Click();
            Thread.Sleep(1000);
            WHFR.Sidebar3.Click();
            Thread.Sleep(1000);
            WHFR.Sidebar4.Click();
            Thread.Sleep(1000);
            WHFR.Sidebar5.Click();
            Thread.Sleep(1000);
            ScrollToElement(WHFR.Sidebar7);
            ClickAndSwitchNewTab(WHFR.Sidebar7);
            Thread.Sleep(1000);
            ClickAndSwitchNewTab(WHFR.Sidebar8);
            Thread.Sleep(1000);
            ClickAndSwitchNewTab(WHFR.Sidebar9);
            Thread.Sleep(1000);
            ClickAndSwitchNewTab(WHFR.Sidebar10);
            Thread.Sleep(1000);
            ClickAndSwitchNewTab(WHFR.Sidebar11);
            Thread.Sleep(1000);
            ClickAndSwitchNewTab(WHFR.Sidebar12);
            Thread.Sleep(1000);
            ScrollToElement(WHFR.EnrollmentsLanEN);
            Thread.Sleep(1000);
            WHFR.EnrollmentsLanEN.Click();
            Thread.Sleep(1000);
            WHFR.EnrollmentsLan.Click();
            Thread.Sleep(1000);



        }
        [Test, Order(2)]
        public void EnrollmentsFR()
        {
            test.Info("Test for Enrollments");
            Thread.Sleep(2000);
         
            WHFR.Enrollments.Click();
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
            WHFR.Search.SendKeys(Config.SearchInvalid);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            WHFR.Search.Clear();
            WHFR.Search.SendKeys(Config.SearchValid);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.EnrollmentsLanEN.Click();
            Thread.Sleep(1000);
            WHFR.EnrollmentsLan.Click();
            Thread.Sleep(1000);
         

        }
        [Test, Order(3)]
        public void OrganizationsAddFR()
        {
            test.Info("Test for Organization Add");
          
            WHFR.Organizations.Click();
            Thread.Sleep(1000);
            WHFR.OrgAdd.Click();
            Thread.Sleep(1000);
            WHFR.OrgName.SendKeys(Config.Name);
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='orgType']"));
            new SelectElement(dropdown).SelectByText("Fondateur");
            WHFR.OrgAddress.SendKeys(Config.Address);
            Thread.Sleep(1000);
            WHFR.OrgCity.SendKeys(Config.City);
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='province']"));
            new SelectElement(dropdown1).SelectByText("l'Ontario");
            WHFR.OrgPostal.SendKeys(Config.PostalCode);
            Thread.Sleep(1000);
            WHFR.OrgCreate.Click();
            Thread.Sleep(2000);
            try
            {
                ScrollToElement(WHFR.OrgClose);
                Thread.Sleep(1000);
                WHFR.OrgClose.Click();
                Thread.Sleep(1000);
            }

            catch
            {



            }


        }
        [Test, Order(4)]
        public void OrganizationsContinueFR()
        {
            test.Info("Tests for Org Filters");
         
            WHFR.Organizations.Click();
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("//select[@id='orgTypeFilter']"));
            new SelectElement(dropdown).SelectByText("Fondateur");
            Thread.Sleep(1000);
            var dropdown2 = driver.FindElement(By.XPath("//select[@id='orgTypeFilter']"));
            new SelectElement(dropdown2).SelectByText("Partenaire");
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='orgStatusFilter']"));
            new SelectElement(dropdown1).SelectByText("Active");
            Thread.Sleep(1000);
            WHFR.OrgProfile.Click();
            Thread.Sleep(1000);
            WHFR.Back.Click();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.SearchInvalid);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Search.Clear();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.SearchValid);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.OrgDelete.Click();
            Thread.Sleep(1000);
            try
            {
                ScrollToElement(WHFR.OrgDelete1);
                Thread.Sleep(1000);
                WHFR.OrgDelete1.Click();
                Thread.Sleep(1000);
                WHFR.OrgDelete2.Click();
                Thread.Sleep(1000);
            }
            catch (Exception ex) { }



        }
        [Test, Order(5)]
        public void OrganizationProfileFR()
        {
            test.Info("Tests for Org Edit");
          
            WHFR.Organizations.Click();
            Thread.Sleep(2000);
            WHFR.OrgProfile.Click();
            Thread.Sleep(1000);
            WHFR.OrgLan.Click();
            Thread.Sleep(1000);
            WHFR.OrgLanEn.Click();
            Thread.Sleep(1000);
            WHFR.OrgNamechange.Clear();
            Thread.Sleep(1000);
            WHFR.OrgNamechange.SendKeys(Config.OrgName);
            Thread.Sleep(2000);
            ScrollToElement(WHFR.OrgNamesave);
            Thread.Sleep(1000);
            WHFR.OrgNamesave.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//div[@class='alert-header']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");
            Thread.Sleep(1000);
            WHFR.Slogan.Clear();
            Thread.Sleep(1000);
            WHFR.Slogan.SendKeys(Config.Slogan);
            Thread.Sleep(1000);
            ScrollToElement(WHFR.OrgNamesave);
            Thread.Sleep(1000);
            WHFR.OrgNamesave.Click();
            Thread.Sleep(1000);
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");



        }

        [Test, Order(6)]
        public void OrganizationProfileInfoFR()
        {
            test.Info("Tests for Orgs Status");
           
            WHFR.Organizations.Click();
            Thread.Sleep(2000);
            WHFR.OrgProfile.Click();
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//select[@id='status']"));
            new SelectElement(dropdown).SelectByText("Inactive");
            Thread.Sleep(1000);
            WHFR.Infosave.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//div[@class='alert-header']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//select[@id='status']"));
            new SelectElement(dropdown1).SelectByText("Active");
            Thread.Sleep(1000);
            WHFR.Infosave.Click();
            Thread.Sleep(1000);
            Assert.IsTrue(
              IsElementDisplayed(bannerLocator),
              "Banner appearing on page");



        }
        [Test, Order(7)]
        public void OrganizationProfileLocationFR()
        {
            test.Info("Tests for Orgs Location");
            WHFR.Organizations.Click();
            Thread.Sleep(2000);
            WHFR.OrgProfile.Click();
            Thread.Sleep(1000);
            ScrollToElement(WHFR.AddressInfo);
            Thread.Sleep(1000);
            WHFR.AddressInfo.Clear();
            Thread.Sleep(1000);
            WHFR.AddressInfo.SendKeys(Config.AddressLoc);
            Thread.Sleep(1000);
            WHFR.AddressSave.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//div[@class='alert-header']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");
            Thread.Sleep(1000);
            ScrollToElement(WHFR.AddressInfo);
            Thread.Sleep(1000);
            WHFR.AddressInfo.Clear();
            Thread.Sleep(1000);
            WHFR.AddressInfo.SendKeys(Config.Address);
            Thread.Sleep(1000);
            WHFR.AddressSave.Click();
            Thread.Sleep(1000);
            Assert.IsTrue(
             IsElementDisplayed(bannerLocator),
             "Banner appearing on page");



        }
        [Test, Order(8)]
        public void OrganizationProfileContactFR()
        {
            test.Info("Tests for Orgs Profile");
         
            WHFR.Organizations.Click();
            Thread.Sleep(2000);
            WHFR.OrgProfile.Click();
            Thread.Sleep(1000);
            ScrollToElement(WHFR.Phone);
            Thread.Sleep(1000);
            WHFR.Phone.Clear();
            Thread.Sleep(1000);
            WHFR.Phone.SendKeys(Config.Phone);
            Thread.Sleep(1000);
            ScrollToElement(WHFR.Contactsave);
            Thread.Sleep(1000);
            WHFR.Contactsave.Click();
            Thread.Sleep(1000);



        }
        [Test, Order(9)]
        public void UsersDigestuserexistFR()
        {
            test.Info("Tests for Users existing or not");
          
            WHFR.Sidebar.Click();
            Thread.Sleep(2000);
            WHFR.AddUser.Click();
            Thread.Sleep(1000);
            WHFR.Firstname.SendKeys(Config.FirstName);
            Thread.Sleep(1000);
            WHFR.Lastname.SendKeys(Config.LastName);
            Thread.Sleep(1000);
            WHFR.EmailInput.SendKeys(Config.Email);
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='organization']"));
            new SelectElement(dropdown).SelectByText("CAMH");
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='role']"));
            new SelectElement(dropdown1).SelectByText("ROLE_GLOBAL_ADMIN");
            Thread.Sleep(1000);
            var dropdown2 = driver.FindElement(By.XPath("//SELECT[@id='status']"));
            new SelectElement(dropdown2).SelectByText("Actif");
            Thread.Sleep(1000);
            var dropdown3 = driver.FindElement(By.XPath("//SELECT[@id='locale']"));
            new SelectElement(dropdown3).SelectByText("Anglais");
            Thread.Sleep(1000);
            var dropdown4 = driver.FindElement(By.XPath("//SELECT[@id='timezone']"));
            new SelectElement(dropdown4).SelectByText("Pacifique");
            Thread.Sleep(1000);
            WHFR.Usersave.Click();
            Thread.Sleep(1000);
      
            ScrollToElement(WHFR.Userclose);
            Thread.Sleep(1000);
            WHFR.Userclose.Click();
            Thread.Sleep(1000);

        }
        [Test, Order(10)]
        public void UsersDigestnewuserFR()
        {
            test.Info("Tests for adding new user");
            WHFR.Sidebar.Click();
            Thread.Sleep(2000);
            WHFR.AddUser.Click();
            Thread.Sleep(1000);
            WHFR.Firstname.SendKeys(Config.FirstName);
            Thread.Sleep(1000);
            WHFR.Lastname.SendKeys(Config.LastName);
            Thread.Sleep(1000);
            WHFR.EmailInput.SendKeys(Config.EmailNew);
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='organization']"));
            new SelectElement(dropdown).SelectByText("CAMH");
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='role']"));
            new SelectElement(dropdown1).SelectByText("ROLE_GLOBAL_ADMIN");
            Thread.Sleep(1000);
            var dropdown2 = driver.FindElement(By.XPath("//SELECT[@id='status']"));
            new SelectElement(dropdown2).SelectByText("Actif");
            Thread.Sleep(1000);
            var dropdown3 = driver.FindElement(By.XPath("//SELECT[@id='locale']"));
            new SelectElement(dropdown3).SelectByText("Anglais");
            Thread.Sleep(1000);
            var dropdown4 = driver.FindElement(By.XPath("//SELECT[@id='timezone']"));
            new SelectElement(dropdown4).SelectByText("Pacifique");
            Thread.Sleep(1000);
            WHFR.Usersave.Click();
            Thread.Sleep(1000);
        }
        [Test, Order(11)]
        public void UsersDigestFiltersFR()
        {
            test.Info("Tests for User Filters");
        
            WHFR.Sidebar.Click();
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("//select[@id='userRoleFilter']"));
            new SelectElement(dropdown).SelectByText("ROLE_GLOBAL_ADMIN");
            Thread.Sleep(2000);
            var dropdown1 = driver.FindElement(By.XPath("//select[@id='userStatusFilter']"));
            new SelectElement(dropdown1).SelectByText("Active");
            Thread.Sleep(2000);
            WHFR.Search.SendKeys(Config.SearchInvalid);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Search.Clear();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.SearchValid);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
        }
        [Test, Order(12)]
        public void UsersDigestEditUserFR()
        {
            test.Info("Tests for Edit User");
          
            WHFR.Sidebar.Click();
            Thread.Sleep(2000);
            WHFR.Edituser1.Click();
            Thread.Sleep(1000);
            WHFR.EditPhone.Clear();
            Thread.Sleep(1000);
            WHFR.EditPhone.SendKeys(Config.Phone);
            Thread.Sleep(1000);
            ScrollToElement(WHFR.EditSave);
            Thread.Sleep(1000);
            WHFR.EditSave.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//div[@class='alert-header']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");
            Thread.Sleep(1000);
            WHFR.EditPhone.Clear();
            Thread.Sleep(1000);
            WHFR.EditPhone.SendKeys(Config.Phonereal);
            Thread.Sleep(1000);
            ScrollToElement(WHFR.EditSave);
            Thread.Sleep(1000);
            WHFR.EditSave.Click();
            Assert.IsTrue(
             IsElementDisplayed(bannerLocator),
             "Banner appearing on page");



        }
        [Test, Order(13)]
        public void UsersDigestSearchUserFR()
        {
            test.Info("Tests for search User");
         
            WHFR.Sidebar.Click();
            Thread.Sleep(2000);
            WHFR.Search.SendKeys(Config.SearchName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Search.Clear();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.SearchNameValid);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);



        }
        [Test, Order(14)]
        public void UsersDigestDeleteUserFR()
        {
            test.Info("Tests for delete user");
          
            WHFR.Sidebar.Click();
            Thread.Sleep(2000);
            ScrollToElement(WHFR.DeleteUser);
            Thread.Sleep(1000);
            WHFR.DeleteUser.Click();
            Thread.Sleep(1000);
            WHFR.Deletebutton.Click();
            Thread.Sleep(1000);
            WHFR.Deleteselect.Click();
            Thread.Sleep(1000);



        }
        [Test, Order(15)]
        public void RequisitionsDigestFilterFR()
        {
            test.Info("Tests for Requisition Filters");
           
            WHFR.Sidebar1.Click();
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("//select[@id='reqFilter']"));
            new SelectElement(dropdown).SelectByIndex(1);
            Thread.Sleep(1000);
            WHFR.ReqVendor.SendKeys(Config.ReqVendor);
            Thread.Sleep(1000);
            Actions act = new Actions(driver);
            act.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(1000);
            WHFR.ReqCustomer.SendKeys(Config.ReqCustomer);
            Thread.Sleep(1000);
            act.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);





        }
        [Test, Order(16)]
        public void RequisitionsDigestSearchProcessedFR()
        {
            test.Info("Tests for Req Search and Processed");
          
            WHFR.Sidebar1.Click();
            Thread.Sleep(2000);
            WHFR.Search.SendKeys(Config.SKUWrng);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Search.Clear();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.SKU);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Processed.Click();
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//select[@id='reqFilter']"));
            new SelectElement(dropdown).SelectByIndex(1);
            Thread.Sleep(1000);
            WHFR.ReqVendor.SendKeys(Config.ReqVendor);
            Thread.Sleep(1000);
            Actions act = new Actions(driver);
            act.SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            WHFR.Search.SendKeys(Config.SKUWrng);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Search.Clear();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.SKUPro);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);



        }
        [Test, Order(17)]
        public void PaidServicesDigestFR()
        {
            test.Info("Tests for Paid Services");
           
            WHFR.Sidebar2.Click();
            Thread.Sleep(2000);
            WHFR.OrgAdd.Click();
            Thread.Sleep(2000);
            WHFR.PaidService.SendKeys(Config.ServiceTitle);
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='organization']"));
            new SelectElement(dropdown).SelectByIndex(3);
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='severity']"));
            new SelectElement(dropdown1).SelectByIndex(2);
            Thread.Sleep(1000);
            WHFR.PaidServicecreate.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//div[@class='alert-header']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");



        }
        [Test, Order(18)]
        public void PaidServicesDigestFiltersFR()
        {
            test.Info("Tests for Paid services filters");
         
            WHFR.Sidebar2.Click();
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("//select[@id='userOrgFilter']"));
            new SelectElement(dropdown).SelectByIndex(3);
            Thread.Sleep(2000);
            var dropdown1 = driver.FindElement(By.XPath("//select[@id='userStatusFilter']"));
            new SelectElement(dropdown1).SelectByText("Draft");
            Thread.Sleep(2000);
            WHFR.Search.SendKeys(Config.SearchName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Search.Clear();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.PaidServiceselect.Click();
            Thread.Sleep(1000);
            WHFR.ServiceBack.Click();
            Thread.Sleep(1000);



        }
        [Test, Order(19)]
        public void PaidServicesDetailsFR()
        {
            test.Info("Tests for Paid services details");
      
            WHFR.Sidebar2.Click();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.PaidServiceselect.Click();
            Thread.Sleep(1000);
            WHFR.ServiceTitle.Clear();
            Thread.Sleep(1000);
            WHFR.ServiceTitle.SendKeys(Config.PaidServiceName);
            Thread.Sleep(1000);
            WHFR.Servicesave.Click();


        }
        [Test, Order(20)]
        public void PaidServicesDetailsinfoFR()
        {
            test.Info("Tests for paid services info");
          
            WHFR.Sidebar2.Click();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.PaidServiceselect.Click();
            Thread.Sleep(1000);
            WHFR.OrgLan.Click();
            Thread.Sleep(1000);
            WHFR.OrgLanEn.Click();
            Thread.Sleep(1000);
            ScrollToElement(WHFR.Servicesave1);
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='status']"));
            new SelectElement(dropdown).SelectByText("Ready for Review");
            Thread.Sleep(1000);
            WHFR.Servicesave1.Click();
            Thread.Sleep(1000);
            ScrollToElement(WHFR.Servicesave2);
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='severity']"));
            new SelectElement(dropdown1).SelectByIndex(2);
            Thread.Sleep(1000);
            WHFR.Servicesave2.Click();
            Thread.Sleep(1000);



        }
        [Test, Order(21)]
        public void PaidServicesDetailsPricingFR()
        {
            test.Info("Tests for paid services pricing");
         
            WHFR.Sidebar2.Click();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.PaidServiceselect.Click();
            Thread.Sleep(1000);
            WHFR.Pricingremove.Click();
            Thread.Sleep(1000);

            WHFR.Servicepricing.Click();
            Thread.Sleep(1000);
            WHFR.Servicepricing1.Click();
            Thread.Sleep(1000);
            ScrollToElement(WHFR.Servicepricingsave);
            Thread.Sleep(1000);
            WHFR.Servicepricingsku.SendKeys(Config.Service1);
            Thread.Sleep(1000);
            WHFR.Servicepricingprice.SendKeys(Config.Service2);
            Thread.Sleep(1000);
            WHFR.Servicepricingmin.SendKeys(Config.Service3);
            Thread.Sleep(1000);
            WHFR.Servicepricingmax.SendKeys(Config.Service4);
            Thread.Sleep(1000);
            WHFR.Servicepricingdate.Click();
            Thread.Sleep(1000);
            WHFR.Servicepricingdate2.Click();
            Thread.Sleep(1000);
            ScrollToElement(WHFR.Servicepricingdate1);
            Thread.Sleep(1000);
            WHFR.Servicepricingdate1.Click();
            Thread.Sleep(1000);
            WHFR.Servicepricingsave.Click();
            Thread.Sleep(1000);



        }
        [Test, Order(22)]
        public void FreeServicesDigestFR()
        {
            test.Info("Tests for Free services");
            
            WHFR.Sidebar3.Click();
            Thread.Sleep(2000);
            WHFR.OrgAdd.Click();
            Thread.Sleep(2000);
            WHFR.PaidService.SendKeys(Config.ServiceTitle);
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='organization']"));
            new SelectElement(dropdown).SelectByIndex(3);
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='severity']"));
            new SelectElement(dropdown1).SelectByIndex(2);
            Thread.Sleep(1000);
            WHFR.PaidServicecreate.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//div[@class='alert-header']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");



        }
        [Test, Order(23)]
        public void FreeServicesDigestFiltersFR()
        {
            test.Info("Tests for free services filters");
            WHFR.Sidebar3.Click();
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='userOrgFilter']"));
            new SelectElement(dropdown).SelectByIndex(3);
            Thread.Sleep(2000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='userStatusFilter']"));
            new SelectElement(dropdown1).SelectByText("Draft");
            Thread.Sleep(2000);
            WHFR.Search.SendKeys(Config.SearchName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Search.Clear();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Freeserviceselect.Click();
            Thread.Sleep(1000);
            WHFR.Freeserviceback.Click();
            Thread.Sleep(1000);



        }
        [Test, Order(24)]
        public void FreeServicesDetailsFR()
        {
            test.Info("Tests for free services details");
            WHFR.Sidebar3.Click();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Freeserviceselect.Click();
            Thread.Sleep(1000);
            WHFR.ServiceTitle.Clear();
            Thread.Sleep(1000);
            WHFR.ServiceTitle.SendKeys(Config.PaidServiceName);
            Thread.Sleep(1000);
            WHFR.Freeservicesummary.SendKeys(Config.PaidServiceName);
            Thread.Sleep(1000);
            ScrollToElement(WHFR.Freeservicesummarybutton);
            Thread.Sleep(1000);
            WHFR.Freeservicesummarybutton.Click();




        }
        [Test, Order(25)]
        public void FreeServicesDetailsinfoFR()
        {
            test.Info("Tests for free services status");
            WHFR.Sidebar3.Click();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Freeserviceselect.Click();
            Thread.Sleep(1000);
            WHFR.OrgLan.Click();
            Thread.Sleep(1000);
            WHFR.OrgLanEn.Click();
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='status']"));
            new SelectElement(dropdown).SelectByText("Ready for Review");
            Thread.Sleep(1000);
            WHFR.Servicesave1.Click();

            Thread.Sleep(1000);
            ScrollToElement(WHFR.Servicesave2);
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='severity']"));
            new SelectElement(dropdown1).SelectByIndex(2);
            Thread.Sleep(1000);
            WHFR.Servicesave2.Click();
            Thread.Sleep(1000);



        }
        [Test, Order(26)]
        public void FreeServicesAccessFR()
        {
            test.Info("Tests for free service access");
            WHFR.Sidebar3.Click();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Freeserviceselect.Click();
            Thread.Sleep(1000);
            ScrollToElement(WHFR.Freeservicesaccess);
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='link-type']"));
            new SelectElement(dropdown).SelectByIndex(2);
            Thread.Sleep(1000);
            WHFR.Freeservicesaccessemail.Clear();
            Thread.Sleep(1000);
            WHFR.Freeservicesaccessemail.SendKeys(Config.EmailNew);
            Thread.Sleep(1000);
            WHFR.Freeservicesaccess.Click();
            Thread.Sleep(1000);




        }
        [Test, Order(27)]
        public void ResourcesDigestFR()
        {
            test.Info("Tests for resource create");
         
            WHFR.Sidebar4.Click();
            Thread.Sleep(2000);
            WHFR.OrgAdd.Click();
            Thread.Sleep(2000);
            WHFR.PaidService.SendKeys(Config.ServiceTitle);
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='organization']"));
            new SelectElement(dropdown).SelectByIndex(3);
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='severity']"));
            new SelectElement(dropdown1).SelectByIndex(2);
            Thread.Sleep(1000);
            WHFR.PaidServicecreate.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//div[@class='alert-header']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");


        }
        [Test, Order(28)]
        public void ResourcesFiltersFR()
        {
            test.Info("Tests for resource filter");
            WHFR.Sidebar4.Click();
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='userOrgFilter']"));
            new SelectElement(dropdown).SelectByIndex(3);
            Thread.Sleep(2000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='userStatusFilter']"));
            new SelectElement(dropdown1).SelectByText("Draft");
            Thread.Sleep(2000);
            WHFR.Search.SendKeys(Config.SearchName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Search.Clear();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Freeserviceselect.Click();
            Thread.Sleep(1000);
            WHFR.Resourcesback.Click();
            Thread.Sleep(1000);



        }
        [Test, Order(29)]
        public void ResourcesDetailsFR()
        {
            test.Info("Tests for resource edit");
            WHFR.Sidebar4.Click();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Freeserviceselect.Click();
            Thread.Sleep(1000);
            WHFR.ServiceTitle.Clear();
            Thread.Sleep(1000);
            WHFR.ServiceTitle.SendKeys(Config.PaidServiceName);
            Thread.Sleep(1000);
            WHFR.Freeservicesummary.SendKeys(Config.PaidServiceName);
            Thread.Sleep(1000);
            ScrollToElement(WHFR.Freeservicesummarybutton);
            Thread.Sleep(1000);
            WHFR.Freeservicesummarybutton.Click();




        }
        [Test, Order(30)]
        public void ResourcesDetailsinfoFR()
        {
            test.Info("Tests for resource info");
            WHFR.Sidebar4.Click();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Freeserviceselect.Click();
            Thread.Sleep(1000);
            WHFR.OrgLan.Click();
            Thread.Sleep(1000);
            WHFR.OrgLanEn.Click();
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='status']"));
            new SelectElement(dropdown).SelectByText("Ready for Review");
            Thread.Sleep(1000);
            WHFR.Servicesave1.Click();

            Thread.Sleep(1000);
            ScrollToElement(WHFR.Servicesave2);
            Thread.Sleep(1000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='severity']"));
            new SelectElement(dropdown1).SelectByIndex(2);
            Thread.Sleep(1000);
            WHFR.Servicesave2.Click();
            Thread.Sleep(1000);




        }
        [Test, Order(31)]
        public void ResourcesDeleteFR()
        {
            test.Info("Tests for resource delete");
            WHFR.Sidebar4.Click();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Freeserviceselect.Click();
            Thread.Sleep(1000);
            ScrollToElement(WHFR.ResourcesDelete);
            Thread.Sleep(1000);
            WHFR.ResourcesDelete.Click();
            Thread.Sleep(1000);
            WHFR.ResourcesDelete1.Click();
            Thread.Sleep(1000);




        }
        [Test, Order(32)]
        public void MailingFiltersFR()
        {
            test.Info("Tests for Mailing filters");
        
            WHFR.Sidebar5.Click();
            Thread.Sleep(2000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='subscriberType']"));
            new SelectElement(dropdown).SelectByIndex(1);
            Thread.Sleep(2000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='subscriberType']"));
            new SelectElement(dropdown1).SelectByIndex(1);
            Thread.Sleep(2000);
            WHFR.Search.SendKeys(Config.SearchName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Search.Clear();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.ServiceName);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);



        }
        [Test, Order(33)]
        public void MailinglistDeleteFR()
        {
            test.Info("Tests for Mailing delete");
            WHFR.Sidebar5.Click();
            Thread.Sleep(1000);
            ScrollToElement(WHFR.MailinglistDelete);
            Thread.Sleep(1000);
            WHFR.MailinglistDelete.Click();
            Thread.Sleep(1000);
            WHFR.MailinglistDelete1.Click();
            Thread.Sleep(1000);
            var bannerLocator = By.XPath("//div[@class='alert-header']");
            Assert.IsTrue(
                IsElementDisplayed(bannerLocator),
                "Banner appearing on page");


        }

    }
}*/
