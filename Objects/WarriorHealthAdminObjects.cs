using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorHealthBeta.Objects
{
    public class WarriorHealthAdminObjects
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
        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Enrollments']")]
        public IWebElement Enrollments { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='text'][text()='Français']")]
        public IWebElement EnrollmentsLan { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@aria-label='[FR] Change language']")]
        public IWebElement EnrollmentsLanEN { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Organizations']")]
        public IWebElement Organizations { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Users']")]
        public IWebElement Sidebar { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Requisitions']")]
        public IWebElement Sidebar1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Paid Services']")]
        public IWebElement Sidebar2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Free Services']")]
        public IWebElement Sidebar3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Resources']")]
        public IWebElement Sidebar4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Mailing List']")]
        public IWebElement Sidebar5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Reporting']")]
        public IWebElement Sidebar6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//img[@alt='Wounded Warriors']")]
        public IWebElement Sidebar7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//img[@alt='Homewood Health']")]
        public IWebElement Sidebar8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//img[@alt='Trillium Health Partners']")]
        public IWebElement Sidebar9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//img[@alt='Canadian Mental Health']")]
        public IWebElement Sidebar10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//img[@alt='Boots on the Ground']")]
        public IWebElement Sidebar11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//img[@alt='Government of Ontario']")]
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
        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Add']")]
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
        [FindsBy(How = How.XPath, Using = "(//A[@href='/app/en/global/admin/organizations'])[2]")]
        public IWebElement Back { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='search']")]
        public IWebElement Search { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='French']")]
        public IWebElement OrgLan { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='English']")]
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
        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Save']")]
        public IWebElement EditSave { get; set; }
        [FindsBy(How = How.XPath, Using = "//tbody/tr[12]/td[1]")]
        public IWebElement DeleteUser { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@type='button']//span[@class='text'][normalize-space()='Delete']")]
        public IWebElement Deletebutton { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Delete'])[2]")]
        public IWebElement Deleteselect { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='requisitionVendor']")]
        public IWebElement ReqVendor { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='requisitionCustomer']")]
        public IWebElement ReqCustomer { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Processed']")]
        public IWebElement Processed { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='title']")]
        public IWebElement PaidService { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[2]")]
        public IWebElement PaidServicecreate { get; set; }
        [FindsBy(How = How.XPath, Using = "(//TD[@class='table-col-author'])[2]")]
        public IWebElement PaidServiceselect { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space(text())='Back']")]
        public IWebElement Paidback { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Title']")]
        public IWebElement ServiceTitle { get; set; }
        [FindsBy(How = How.XPath, Using = "(//button[@aria-label='Save'])[1]")]
        public IWebElement Servicesave { get; set; }
        [FindsBy(How = How.XPath, Using = "(//button[@aria-label='Save'])[2]")]
        public IWebElement Servicesave1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//button[@aria-label='Save'])[3]")]
        public IWebElement Servicesave2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@data-bs-toggle='dropdown']")]
        public IWebElement Servicepricing { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space(text())='Individual - In Person']")]
        public IWebElement Servicepricing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@for='form-resource-pricing']")]
        public IWebElement Servicepricingsave { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@aria-label='SKU']")]
        public IWebElement Servicepricingsku { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Price ($)']")]
        public IWebElement Servicepricingprice { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Minimum Participants']")]
        public IWebElement Servicepricingmin { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Maximum Participants']")]
        public IWebElement Servicepricingmax { get; set; }
        [FindsBy(How = How.XPath, Using = "(//input[@aria-label='Datepicker input'])[1]")]
        public IWebElement Servicepricingdate { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space(text())='Select']")]
        public IWebElement Servicepricingdate1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[text()='10']")]
        public IWebElement Servicepricingdate2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//TD[@class='table-col-author'])[1]")]
        public IWebElement Freeserviceselect { get; set; }

        [FindsBy(How = How.XPath, Using = "(//A[@href='/app/en/global/admin/services/core'])[2]")]
        public IWebElement Freeserviceback { get; set; }
        [FindsBy(How = How.XPath, Using = "//TEXTAREA[@id='summary']")]
        public IWebElement Freeservicesummary { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[1]")]
        public IWebElement Freeservicesummarybutton { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[4]")]
        public IWebElement Freeservicesaccess { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='label']")]
        public IWebElement Freeservicesaccessemail { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@href='/app/en/global/admin/resources'])[2]")]
        public IWebElement Resourcesback { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Delete'])[1]")]
        public IWebElement ResourcesDelete { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Delete'])[2]")]
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

        [FindsBy(How = How.XPath, Using = "(//A[@href='/app/en/global/admin/services/basket'])[2]")]
        public IWebElement ServiceBack { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@type='button'])[3]")]
        public IWebElement Pricingremove { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@id='modal-form-organization-close-modal']")]
        public IWebElement OrgClose { get; set; }

        //PSO


        [FindsBy(How = How.XPath, Using = "//SPAN[@class='text'][text()='Organization Profile']")]
        public IWebElement Side1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='text'][text()='Requisitions']")]
        public IWebElement Side2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[1]")]
        public IWebElement PSOOrgsave { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[2]")]
        public IWebElement PSOOrgsave1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Purchase Services']")]
        public IWebElement PSOreqpurchase { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Acheter des services']")]
        public IWebElement PSOreqpurchaseFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//DIV[@class='item-topic'])[1]")]
        public IWebElement PSOreqpurchaseselect { get; set; }
        [FindsBy(How = How.XPath, Using = "(//DIV[@class='item-topic'])[1]")]
        public IWebElement PSOreqpurchaseselectFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-outline-muted btn-xs me-2'])[1]")]
        public IWebElement PSOreqpurchasebutton { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-primary btn-review-cart btn-icon-start']")]
        public IWebElement PSOreqpurchasereview { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='requisitionReviewed']")]
        public IWebElement PSOreqpurchasecheck { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Confirm']")]
        public IWebElement PSOreqpurchaseconfirm { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Confirmer']")]
        public IWebElement PSOreqpurchaseconfirmFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@href='/app/en/pso/requisitions'])[2]")]
        public IWebElement PSOreqpurchasedone { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@href='/app/fr/pso/requisitions'])[2]")]
        public IWebElement PSOreqpurchasedoneFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@role='button'][text()='Remove']")]
        public IWebElement PSOreqpurchaseremove { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@role='button'][text()='Retirer']")]
        public IWebElement PSOreqpurchaseremoveFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@href='#'][text()='Download Request'])[1]")]
        public IWebElement PSOreqdownload { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@href='#'][text()='Demande de téléchargement'])[1]")]
        public IWebElement PSOreqdownloadFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-outline-primary btn-icon-spaced']")]
        public IWebElement PSOreqprint { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@id='modal-print-download-close-modal']")]
        public IWebElement PSOreqprintclose { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-outline-muted btn-sm btn-actions dropdown-toggle'][text()=' Actions '])[1]")]
        public IWebElement PSOreqaction { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@class='dropdown-item'][text()='Message Provider'])[1]")]
        public IWebElement PSOreqaction1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@class='dropdown-item'][text()='Fournisseur de messages'])[1]")]
        public IWebElement PSOreqaction1FR { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='MORE_INFORMATION']")]
        public IWebElement PSOreqaction2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@type='submit'])[2]")]
        public IWebElement PSOreqaction3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@class='dropdown-item'][text()='Request Cancellation'])[1]")]
        public IWebElement PSOreqaction4 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@class='dropdown-item'])[2]")]
        public IWebElement PSOreqaction4FR { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='CANCEL_DATES_NOT_SUITABLE']")]
        public IWebElement PSOreqaction5 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@type='submit'])[3]")]
        public IWebElement PSOreqaction6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@aria-label=\"Profil de l'organisation\"]//span[@class='text']")]
        public IWebElement PSOside1fr { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Réquisitions']")]
        public IWebElement PSOside2fr { get; set; }

        //Regression
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-approve']")]
        public IWebElement Rapprove { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-deny']")]
        public IWebElement RDeny { get; set; }
        [FindsBy(How = How.XPath, Using = "//TEXTAREA[@id='summary']")]
        public IWebElement ROrgprofile { get; set; }
        [FindsBy(How = How.XPath, Using = "//I[@class='fa-solid fa-bold']")]
        public IWebElement ROrgedit { get; set; }
        [FindsBy(How = How.XPath, Using = "//I[@class='fa-solid fa-italic']")]
        public IWebElement ROrgedit1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//I[@class='fa-solid fa-underline']")]
        public IWebElement ROrgedit2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//I[@class='fa-solid fa-link']")]
        public IWebElement ROrgedit3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//I[@class='fa-solid fa-font']")]
        public IWebElement ROrgedit4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//I[@class='fa-solid fa-subscript']")]
        public IWebElement ROrgedit5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//I[@class='fa-solid fa-superscript']")]
        public IWebElement ROrgedit6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//I[@class='fa-solid fa-list-ul']")]
        public IWebElement ROrgedit7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//I[@class='fa-solid fa-list-ol']")]
        public IWebElement ROrgedit8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//I[@class='fa-solid fa-align-left']")]
        public IWebElement ROrgedit9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//I[@class='fa-solid fa-align-center']")]
        public IWebElement ROrgedit10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//I[@class='fa-solid fa-align-right']")]
        public IWebElement ROrgedit11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//I[@class='fa-solid fa-quote-right']")]
        public IWebElement ROrgedit12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//I[@class='fa-solid fa-text-slash']")]
        public IWebElement ROrgedit13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//I[@class='fa-solid fa-code']")]
        public IWebElement ROrgedit14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//I[@class='fa-solid fa-rotate-left']")]
        public IWebElement ROrgedit15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='supportEmail']")]
        public IWebElement RSupportEmail { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='websiteUrl']")]
        public IWebElement RSupportURL { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='resource-category']")]
        public IWebElement RPaidserviceres { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@id='modal-form-service-close-modal']")]
        public IWebElement RPaidservicsmodel { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='multiselect-tag-remove-icon'])[1]")]
        public IWebElement RPaidservicecatremove { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='resource-issues']")]
        public IWebElement RPaidservicePrimary { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='multiselect-tag-remove-icon'])[5]")]
        public IWebElement RPaidservicePrimaryremove { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='multiselect-clear-icon'])[1]")]
        public IWebElement RPaidserviceclearall{ get; set; }
        [FindsBy(How = How.XPath, Using = "//TEXTAREA[@id='summary']")]
        public IWebElement RPaidservicesummary { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-primary btn-icon-spaced'])[3]")]
        public IWebElement RPaidservicesave { get; set; }

        [FindsBy(How = How.XPath, Using = "(//A[@href='/app/en/global/admin/services/core'])[2]")]
        public IWebElement RFreeServiceback { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@id='modal-form-resource-close-modal']")]
        public IWebElement RResourcemodelclose { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='featuredResource']")]
        public IWebElement RResourcefeatured { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@href='/app/en/global/admin/resources'])[2]")]
        public IWebElement RResourceback { get; set; }


    }
}
