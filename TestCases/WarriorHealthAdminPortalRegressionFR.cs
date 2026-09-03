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
    public class WarriorHealthAdminPortalRegressionFR : AuthenticatedTestBase
    {
        protected bool IsElementDisplayed(By locator)
        {
            return driver
                .FindElements(locator)
                .Any(e => e.Displayed);
        }
        [Test, Order(1)]
        public void WHSideBarRegressionFR()
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
        public void EnrollmentsRegressionFR()
        {
            test.Info("Test for Enrollments");
            Thread.Sleep(2000);
            WHFR.EnrollmentsLan.Click();
            Thread.Sleep(1000);
            WHFR.Enrollments.Click();
            Thread.Sleep(1000);
            var dropdown3 = driver.FindElement(By.XPath("//SELECT[@id='userStatusFilter']"));
            new SelectElement(dropdown3).SelectByText("Denied");
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='userStatusFilter']"));
            new SelectElement(dropdown).SelectByText("Approved");
            Thread.Sleep(2000);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='userStatusFilter']"));
            new SelectElement(dropdown1).SelectByText("Pending");
            Thread.Sleep(2000);
            var dropdown2 = driver.FindElement(By.XPath("//SELECT[@id='userStatusFilter']"));
            new SelectElement(dropdown2).SelectByText("Tout");
            Thread.Sleep(2000);
            WHFR.Search.SendKeys(Config.SearchInvalid);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            WHFR.Search.Clear();
            WHFR.Search.SendKeys(Config.SearchValid);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            WHFR.Search.Clear();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.SearchUpper);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Search.Clear();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.SearchTrailing);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Search.Clear();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.SearchSpecial);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Search.Clear();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.SearchEmpty);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Search.Clear();
            Thread.Sleep(1000);
            try
            {
                WH.Rapprove.Click();
                Thread.Sleep(1000);
                WH.RDeny.Click();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
            }


        }
        [Test, Order(3)]
        public void OrganizationsAddRegressionFR()
        {
            test.Info("Test for Organization Add regression");
            WHFR.EnrollmentsLan.Click();
            Thread.Sleep(1000);
            WHFR.Organizations.Click();
            Thread.Sleep(1000);
            WHFR.OrgAdd.Click();
            Thread.Sleep(1000);
            try
            {
                ScrollToElement(WHFR.OrgClose);
                Thread.Sleep(1000);
                WHFR.OrgClose.Click();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            { }
            WHFR.OrgAdd.Click();
            Thread.Sleep(1000);
            WHFR.OrgName.SendKeys("");
            Thread.Sleep(1000);
            WHFR.OrgCreate.Click();
            Thread.Sleep(2000);
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
            catch (Exception ex)
            { }


        }
        [Test, Order(4)]
        public void OrganizationsSearchRegressionFR()
        {
            test.Info("Tests for Org Filters");
            WHFR.EnrollmentsLan.Click();
            Thread.Sleep(1000);
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
            WHFR.Search.SendKeys(Config.SearchTrailing);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Search.Clear();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.SearchSpecial);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Search.Clear();
            Thread.Sleep(1000);
            WHFR.Search.SendKeys(Config.SearchEmpty);
            Thread.Sleep(1000);
            WHFR.Search.Submit();
            Thread.Sleep(1000);
            WHFR.Search.Clear();
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
        public void OrganizationProfileRegressionFR()
        {
            test.Info("Tests for Org Edit Slogan");
            WHFR.EnrollmentsLan.Click();
            Thread.Sleep(1000);
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
            WHFR.OrgNamechange.SendKeys(Config.SearchSpecial);
            Thread.Sleep(2000);
            ScrollToElement(WHFR.OrgNamesave);
            Thread.Sleep(1000);
            WHFR.OrgNamesave.Click();
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
            WHFR.Slogan.SendKeys(Config.SearchSpecial);
            Thread.Sleep(1000);
            ScrollToElement(WHFR.OrgNamesave);
            Thread.Sleep(1000);
            WHFR.OrgNamesave.Click();
            Thread.Sleep(1000);
            WHFR.Slogan.Clear();
            Thread.Sleep(1000);
            WHFR.Slogan.SendKeys("");
            Thread.Sleep(1000);
            ScrollToElement(WHFR.OrgNamesave);
            Thread.Sleep(1000);
            WHFR.OrgNamesave.Click();
            Thread.Sleep(1000);
            WHFR.Slogan.Clear();
            Thread.Sleep(1000);
            WHFR.Slogan.SendKeys(Config.SearchTrailing);
            Thread.Sleep(1000);
            ScrollToElement(WHFR.OrgNamesave);
            Thread.Sleep(1000);
            WHFR.OrgNamesave.Click();
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
        public void OrganizationProfileOverviewRegressionFR()
        {
            test.Info("Tests for Org Edit Summary");
            WHFR.EnrollmentsLan.Click();
            Thread.Sleep(1000);
            WHFR.Organizations.Click();
            Thread.Sleep(2000);
            WHFR.OrgProfile.Click();
            Thread.Sleep(1000);
            WHFR.OrgLan.Click();
            Thread.Sleep(1000);
            WHFR.OrgLanEn.Click();
            Thread.Sleep(1000);
            ScrollToElement(WHFR.ROrgprofile);
            Thread.Sleep(1000);
            WHFR.ROrgprofile.Clear();
            Thread.Sleep(1000);
            WHFR.ROrgprofile.SendKeys(Config.SearchSpecial);
            Thread.Sleep(1000);
            ScrollToElement(WHFR.OrgNamesave);
            Thread.Sleep(1000);
            WHFR.OrgNamesave.Click();
            Thread.Sleep(1000);
            WHFR.ROrgprofile.Clear();
            Thread.Sleep(1000);
            WHFR.ROrgprofile.SendKeys("");
            Thread.Sleep(1000);
            ScrollToElement(WHFR.OrgNamesave);
            Thread.Sleep(1000);
            WHFR.OrgNamesave.Click();
            Thread.Sleep(1000);
            WHFR.ROrgprofile.Clear();
            Thread.Sleep(1000);
            WHFR.ROrgprofile.SendKeys(Config.SearchTrailing);
            Thread.Sleep(1000);
            ScrollToElement(WHFR.OrgNamesave);
            Thread.Sleep(1000);
            WHFR.OrgNamesave.Click();
            Thread.Sleep(1000);
            WHFR.ROrgprofile.Clear();
            Thread.Sleep(1000);
            WHFR.ROrgprofile.SendKeys(Config.Slogan);
            Thread.Sleep(1000);
            ScrollToElement(WHFR.OrgNamesave);
            Thread.Sleep(1000);
            WHFR.OrgNamesave.Click();
            Thread.Sleep(1000);

        }

    }
}*/
