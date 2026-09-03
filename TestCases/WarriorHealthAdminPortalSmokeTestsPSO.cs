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
    public class WarriorHealthAdminPortalSmokeTestsPSO : AuthenticatedTestBasePSO
    {
        protected bool IsElementDisplayed(By locator)
        {
            return driver
                .FindElements(locator)
                .Any(e => e.Displayed);
        }

        [Test, Order(1)]
        public void WHPSOSideBar()
        {
            test.Info("Tests for sidebar links");
            WH.Side1.Click();
            Thread.Sleep(1000);
            WH.Side2.Click();
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
        public void WHPSOOrgEdit()
        {
            test.Info("Tests for Org Edit");
            WH.Side1.Click();
            Thread.Sleep(1000);
            WH.OrgNamechange.Clear();
            Thread.Sleep(1000);
            WH.OrgNamechange.SendKeys(Config.OrgName);
            Thread.Sleep(1000);
            WH.PSOOrgsave.Click();
            Thread.Sleep(1000);
            WH.OrgLan.Click();
            Thread.Sleep(1000);
            WH.OrgLanEn.Click();
            Thread.Sleep(2000);
            ScrollToElement(WH.AddressInfo);
            Thread.Sleep(1000);
            WH.AddressInfo.Clear();
            Thread.Sleep(1000);
            WH.AddressInfo.SendKeys(Config.AddressLoc);
            Thread.Sleep(2000);
            ScrollToElement(WH.PSOOrgsave1);
            Thread.Sleep(1000);
            WH.PSOOrgsave1.Click();
            Thread.Sleep(1000);
        }
        [Test, Order(3)]
        public void WHPSOReqFilters()
        {
            test.Info("Tests for Req Filters");
            WH.Side2.Click();
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='reqFilter']"));
            new SelectElement(dropdown).SelectByText("Selecting");
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='reqFilter']"));
            new SelectElement(dropdown1).SelectByText("Initiated");
            var dropdown2 = driver.FindElement(By.XPath("//SELECT[@id='reqFilter']"));
            new SelectElement(dropdown2).SelectByText("Scheduled");
            var dropdown3 = driver.FindElement(By.XPath("//SELECT[@id='reqFilter']"));
            new SelectElement(dropdown3).SelectByText("Delivered");
            var dropdown4 = driver.FindElement(By.XPath("//SELECT[@id='reqFilter']"));
            new SelectElement(dropdown4).SelectByText("Cancelled");
            Thread.Sleep(1000);
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
        }
        [Test, Order(4)]
        public void WHPSOReqPurchaseServices()
        {
            test.Info("Tests for Add services");
            Thread.Sleep(2000);
            WH.PSOreqpurchase.Click();
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='manager-filter-topics']"));
            new SelectElement(dropdown).SelectByText("Leadership");
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='manager-filter-organization']"));
            new SelectElement(dropdown1).SelectByText("CA");
            WH.PSOreqpurchaseselect.Click();
            Thread.Sleep(1000);
            WH.PSOreqpurchasebutton.Click();
            Thread.Sleep(1000);
            WH.PSOreqpurchasereview.Click();
            Thread.Sleep(1000);
            WH.PSOreqpurchasecheck.Click();
            Thread.Sleep(1000);
            WH.PSOreqpurchaseconfirm.Click();
            Thread.Sleep(1000);
            WH.PSOreqpurchasedone.Click();
            Thread.Sleep(1000);
        }
        [Test, Order(5)]
        public void WHPSOReqPurchaseremove()
        {
            test.Info("Tests for remove services and download");
            Thread.Sleep(2000);
            WH.PSOreqpurchase.Click();
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='manager-filter-topics']"));
            new SelectElement(dropdown).SelectByText("Leadership");
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='manager-filter-organization']"));
            new SelectElement(dropdown1).SelectByText("CA");
            WH.PSOreqpurchaseselect.Click();
            Thread.Sleep(1000);
            WH.PSOreqpurchasebutton.Click();
            Thread.Sleep(1000);
            WH.PSOreqpurchasereview.Click();
            Thread.Sleep(1000);
            WH.PSOreqpurchaseremove.Click();
            Thread.Sleep(1000);
            WH.Side2.Click();
            Thread.Sleep(1000);
            WH.PSOreqdownload.Click();
            Thread.Sleep(1000);
            WH.PSOreqprintclose.Click();
            Thread.Sleep(1000);

        }
        [Test, Order(6)]
        public void WHPSOReqActions()
        {try
            {
                test.Info("Tests for req actions");
                Thread.Sleep(2000);
                ScrollToElement(WH.PSOreqaction);
                Thread.Sleep(1000);
                WH.PSOreqaction.Click();
                Thread.Sleep(1000);
                WH.PSOreqaction1.Click();
                Thread.Sleep(1000);
                WH.PSOreqaction2.Click();
                Thread.Sleep(1000);
                WH.PSOreqaction3.Click();
                Thread.Sleep(1000);
                WH.PSOreqaction.Click();
                Thread.Sleep(1000);
                WH.PSOreqaction4.Click();
                Thread.Sleep(1000);
                WH.PSOreqaction5.Click();
                Thread.Sleep(1000);
                WH.PSOreqaction6.Click();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
            }

        }
        [Test, Order(7)]
        public void WHPSOSideBarFR()
        {
            test.Info("Tests for sidebar links FR");
            WH.EnrollmentsLan.Click();
            Thread.Sleep(1000);
            WH.PSOside1fr.Click();
            Thread.Sleep(1000);
            WH.PSOside2fr.Click();
            Thread.Sleep(2000);
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
    
                 

        }
        [Test, Order(8)]
        public void WHPSOOrgEditFR()
        {
            test.Info("Tests for Org Edit FR");
            WH.PSOside1fr.Click();
            Thread.Sleep(1000);
            WH.OrgNamechange.Clear();
            Thread.Sleep(1000);
            WH.OrgNamechange.SendKeys(Config.OrgName);
            Thread.Sleep(1000);
            WH.PSOOrgsave.Click();
            Thread.Sleep(1000);
            WHFR.OrgLan.Click();
            Thread.Sleep(1000);
            WHFR.OrgLanEn.Click();
            Thread.Sleep(2000);
            ScrollToElement(WH.AddressInfo);
            Thread.Sleep(1000);
            WH.AddressInfo.Clear();
            Thread.Sleep(1000);
            WH.AddressInfo.SendKeys(Config.AddressLoc);
            Thread.Sleep(2000);
            ScrollToElement(WH.PSOOrgsave1);
            Thread.Sleep(1000);
            WH.PSOOrgsave1.Click();
            Thread.Sleep(1000);
        }
        [Test, Order(9)]
        public void WHPSOReqFiltersFR()
        {
            test.Info("Tests for Req Filters FR");
            WH.PSOside2fr.Click();
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='reqFilter']"));
            new SelectElement(dropdown).SelectByIndex(1);
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='reqFilter']"));
            new SelectElement(dropdown1).SelectByIndex(2);
            var dropdown2 = driver.FindElement(By.XPath("//SELECT[@id='reqFilter']"));
            new SelectElement(dropdown2).SelectByIndex(3);
            var dropdown3 = driver.FindElement(By.XPath("//SELECT[@id='reqFilter']"));
            new SelectElement(dropdown3).SelectByIndex(4);
            var dropdown4 = driver.FindElement(By.XPath("//SELECT[@id='reqFilter']"));
            new SelectElement(dropdown4).SelectByIndex(5);
            Thread.Sleep(1000);
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
        }
        [Test, Order(10)]
        public void WHPSOReqPurchaseServicesFR()
        {
            test.Info("Tests for Add services FR");
            WH.PSOreqpurchaseFR.Click();
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='manager-filter-topics']"));
            new SelectElement(dropdown).SelectByText("Leadership");
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='manager-filter-organization']"));
            new SelectElement(dropdown1).SelectByText("CAMH");
            Thread.Sleep(1000);
            WH.PSOreqpurchaseselectFR.Click();
            Thread.Sleep(2000);
            ScrollToElement(WH.PSOreqpurchasebutton);
            Thread.Sleep(1000);
            WH.PSOreqpurchasebutton.Click();
            Thread.Sleep(2000);
            ScrollToElement(WH.PSOreqpurchasereview);
            Thread.Sleep(1000);
            WH.PSOreqpurchasereview.Click();
            Thread.Sleep(1000);
            WH.PSOreqpurchasecheck.Click();
            Thread.Sleep(1000);
            WH.PSOreqpurchaseconfirmFR.Click();
            Thread.Sleep(1000);
            WH.PSOreqpurchasedoneFR.Click();
            Thread.Sleep(1000);
        }
        [Test, Order(11)]
        public void WHPSOReqPurchaseremoveFR()
        {
            test.Info("Tests for remove services and download FR");
            WH.PSOreqpurchaseFR.Click();
            Thread.Sleep(1000);
            var dropdown = driver.FindElement(By.XPath("//SELECT[@id='manager-filter-topics']"));
            new SelectElement(dropdown).SelectByText("Leadership");
            var dropdown1 = driver.FindElement(By.XPath("//SELECT[@id='manager-filter-organization']"));
            new SelectElement(dropdown1).SelectByText("CAMH");
            WH.PSOreqpurchaseselectFR.Click();
            Thread.Sleep(2000);
            ScrollToElement(WH.PSOreqpurchasebutton);
            Thread.Sleep(1000);
            WH.PSOreqpurchasebutton.Click();
            Thread.Sleep(2000);
            ScrollToElement(WH.PSOreqpurchasereview);
            Thread.Sleep(1000);
            WH.PSOreqpurchasereview.Click();
            Thread.Sleep(1000);
            WH.PSOreqpurchaseremoveFR.Click();
            Thread.Sleep(1000);
            WH.PSOside2fr.Click();
            Thread.Sleep(2000);
            ScrollToElement(WH.PSOreqdownloadFR);
            Thread.Sleep(1000);
            WH.PSOreqdownloadFR.Click();
            Thread.Sleep(1000);
            WH.PSOreqprintclose.Click();
            Thread.Sleep(1000);

        }
        [Test, Order(12)]
        public void WHPSOReqActionsFR()
        {
            test.Info("Tests for req actions FR");
            Thread.Sleep(2000);
            ScrollToElement(WH.PSOreqaction);
            Thread.Sleep(1000);
            WH.PSOreqaction.Click();
            Thread.Sleep(1000);
            WH.PSOreqaction1FR.Click();
            Thread.Sleep(1000);
            WH.PSOreqaction2.Click();
            Thread.Sleep(1000);
            WH.PSOreqaction3.Click();
            Thread.Sleep(1000);
            WH.PSOreqaction.Click();
            Thread.Sleep(1000);
            WH.PSOreqaction4FR.Click();
            Thread.Sleep(1000);
            WH.PSOreqaction5.Click();
            Thread.Sleep(1000);
            WH.PSOreqaction6.Click();
            Thread.Sleep(1000);

        }
    }
}*/
