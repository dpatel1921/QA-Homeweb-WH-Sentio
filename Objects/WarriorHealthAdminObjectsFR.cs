using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WarriorHealthBeta.Objects
{
    public class WarriorHealthAdminObjectsFR
    {
        private IWebDriver driver;
        [FindsBy(How = How.Id, Using = "emailAddress")]
        public IWebElement EmailInput { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement Emailbutton { get; set; }
        [FindsBy(How = How.Id, Using = "verificationCode")]
        public IWebElement Verificationcode { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement Loginbutton { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Inscriptions']")]
        public IWebElement Enrollments { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='text'][text()='Français']")]
        public IWebElement EnrollmentsLan { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@aria-label='[FR] Change language']")]
        public IWebElement EnrollmentsLanEN { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Organisations']")]
        public IWebElement Organizations { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Utilisateurs']")]
        public IWebElement Sidebar { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Réquisitions']")]
        public IWebElement Sidebar1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Services payants']")]
        public IWebElement Sidebar2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Services gratuits']")]
        public IWebElement Sidebar3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Ressources']")]
        public IWebElement Sidebar4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Liste de diffusion']")]
        public IWebElement Sidebar5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Reporting']")]
        public IWebElement Sidebar6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//img[@alt='Guerriers blessés']")]
        public IWebElement Sidebar7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//img[@alt='Homewood Santé']")]
        public IWebElement Sidebar8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//img[@alt='Partenaires de santé Trillium']")]
        public IWebElement Sidebar9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//img[@alt='Centre de toxicomanie et de santé mentale']")]
        public IWebElement Sidebar10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//img[@alt='Les bottes sur le terrain']")]
        public IWebElement Sidebar11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//img[@alt='Gouvernement de l’Ontario']")]
        public IWebElement Sidebar12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//img[@alt='Warrior Health']")]
        public IWebElement Logo { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@type='button']")]
        public IWebElement Enroll { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='alert-message']")]
        public IWebElement Alert { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[@class='text']")]
        public IWebElement StartOver { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='forgot-password']")]
        public IWebElement NoCode { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Ajouter']")]
        public IWebElement OrgAdd { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='title']")]
        public IWebElement OrgName { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='addressLine1']")]
        public IWebElement OrgAddress { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='city']")]
        public IWebElement OrgCity { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='postalCode']")]
        public IWebElement OrgPostal { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[2]")]
        public IWebElement OrgCreate { get; set; }
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[1]/span[1]")]
        public IWebElement OrgProfile { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@href='/app/fr/global/admin/organizations'])[2]")]
        public IWebElement Back { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='search']")]
        public IWebElement Search { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@role='button'][text()='Français']")]
        public IWebElement OrgLan { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@role='button'][text()='Anglais']")]
        public IWebElement OrgLanEn { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='label']")]
        public IWebElement OrgNamechange { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[1]")]
        public IWebElement OrgNamesave { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='slogan']")]
        public IWebElement Slogan { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[2]")]
        public IWebElement Infosave { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='addressLine1']")]
        public IWebElement AddressInfo { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[3]")]
        public IWebElement AddressSave { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='supportPhone']")]
        public IWebElement Phone { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[4]")]
        public IWebElement Contactsave { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[1]")]
        public IWebElement AddUser { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='firstName']")]
        public IWebElement Firstname { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='lastName']")]
        public IWebElement Lastname { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[2]")]
        public IWebElement Usersave { get; set; }
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[1]")]
        public IWebElement Edituser1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='phone']")]
        public IWebElement EditPhone { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-primary btn-icon-spaced']")]
        public IWebElement EditSave { get; set; }
        [FindsBy(How = How.XPath, Using = "//tbody/tr[12]/td[1]")]
        public IWebElement DeleteUser { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@type='button'])[2]")]
        public IWebElement Deletebutton { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-danger btn-icon-spaced mx-1']")]
        public IWebElement Deleteselect { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='requisitionVendor']")]
        public IWebElement ReqVendor { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='requisitionCustomer']")]
        public IWebElement ReqCustomer { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@role='button'][text()='Traitée']")]
        public IWebElement Processed { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='title']")]
        public IWebElement PaidService { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[2]")]
        public IWebElement PaidServicecreate { get; set; }
        [FindsBy(How = How.XPath, Using = "//table[contains(@class,'table collection-table')]/tbody[1]/tr[2]/td[1]")]
        public IWebElement PaidServiceselect { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space(text())='Back']")]
        public IWebElement Paidback { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='title']")]
        public IWebElement ServiceTitle { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[1]")]
        public IWebElement Servicesave { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[2]")]
        public IWebElement Servicesave1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[3]")]
        public IWebElement Servicesave2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-outline-muted btn-sm dropdown-toggle btn-icon-start w-100']")]
        public IWebElement Servicepricing { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space(text())='Individual - In Person']")]
        public IWebElement Servicepricing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@for='form-resource-pricing']")]
        public IWebElement Servicepricingsave { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='sku-0']")]
        public IWebElement Servicepricingsku { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='price-0']")]
        public IWebElement Servicepricingprice { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='participants-0']")]
        public IWebElement Servicepricingmin { get; set; }
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/main[1]/div[1]/div[1]/section[1]/div[3]/div[2]/form[1]/section[1]/div[2]/div[3]/div[2]/div[4]/input[1]")]
        public IWebElement Servicepricingmax { get; set; }
        [FindsBy(How = How.XPath, Using = "(//input[@aria-label='Datepicker input'])[1]")]
        public IWebElement Servicepricingdate { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space(text())='Select']")]
        public IWebElement Servicepricingdate1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[text()='10']")]
        public IWebElement Servicepricingdate2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//TD[@class='table-col-author'])[1]")]
        public IWebElement Freeserviceselect { get; set; }

        [FindsBy(How = How.XPath, Using = "(//A[@href='/app/fr/global/admin/services/core'])[2]")]
        public IWebElement Freeserviceback { get; set; }
        [FindsBy(How = How.XPath, Using = "//TEXTAREA[@id='summary']")]
        public IWebElement Freeservicesummary { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[1]")]
        public IWebElement Freeservicesummarybutton { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[4]")]
        public IWebElement Freeservicesaccess { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='label']")]
        public IWebElement Freeservicesaccessemail { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@href='/app/fr/global/admin/resources'])[2]")]
        public IWebElement Resourcesback { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@type='button'])[22]")]
        public IWebElement ResourcesDelete { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-danger btn-icon-spaced mx-1']")]
        public IWebElement ResourcesDelete1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@type='button'])[2]")]
        public IWebElement MailinglistDelete { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-danger btn-icon-spaced mx-1']")]
        public IWebElement MailinglistDelete1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//TD[@class='table-col-type']")]
        public IWebElement OrgDelete { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@type='button'])[23]")]
        public IWebElement OrgDelete1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-danger btn-icon-spaced mx-1']")]
        public IWebElement OrgDelete2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@id='modal-form-user-close-modal']")]
        public IWebElement Userclose { get; set; }

        [FindsBy(How = How.XPath, Using = "(//A[@href='/app/fr/global/admin/services/basket'])[2]")]
        public IWebElement ServiceBack { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@type='button'])[3]")]
        public IWebElement Pricingremove { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@id='modal-form-organization-close-modal']")]
        public IWebElement OrgClose { get; set; }

        //RegressionFR

        [FindsBy(How = How.XPath, Using = "//TEXTAREA[@id='summary']")]
        public IWebElement ROrgprofile { get; set; }

    }
}
