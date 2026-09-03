using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorHealthBeta.Objects
{
    internal class HomePageObjects
    {
        private IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//a[@class='link home active']")]
        public IWebElement Home { get; set; }
        [FindsBy(How = How.XPath, Using = "//IMG[@src='https://warriorhealth-cdn.s3.ca-central-1.amazonaws.com/logos/warrior-health-logo.png']")]
        public IWebElement WHlogo { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'link home')]")]
        public IWebElement Home1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/en/browse'][text()='Browse']")]
        public IWebElement Browse { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/en/assessments/'][text()='Assessments']")]
        public IWebElement Assessments { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/en/resources/search'][text()='Search']")]
        public IWebElement Search { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/en/faq'][text()='FAQs']")]
        public IWebElement FAQ { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/en/about'][text()='About Us']")]
        public IWebElement AboutUs { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/en/pso/'][text()='For Public Safety Organizations']")]
        public IWebElement PSO { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='text'][text()='Français']")]
        public IWebElement Toggle { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='text'][text()='English']")]
        public IWebElement ToggleEng { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@aria-label='For Individuals']")]
        public IWebElement ForIndividuals { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@aria-label='For Families']")]
        public IWebElement ForFamilies { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='For Organizations']")]
        public IWebElement ForOrgs { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='24/7 Peer Support']")]
        public IWebElement PeerSupport { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='24/7 Crisis Support']")]
        public IWebElement CrisisSupport { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='container-partners']//img[@alt='Wounded Warriors']")]
        public IWebElement Poweredby1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='container-partners']//img[@alt='Homewood Health']")]
        public IWebElement Poweredby2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='container-partners']//img[@alt='Trillium Health Partners']")]
        public IWebElement Poweredby3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='container-partners']//img[@alt='Centre for Addiction and Mental Health']")]
        public IWebElement Poweredby4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='container-partners']//img[@alt='Boots on the Ground']")]
        public IWebElement Poweredby5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='container-partners']//img[@alt='Government of Ontario']")]
        public IWebElement Poweredby6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/en/browse'][text()='Browse all']")]
        public IWebElement Coreservice { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/en/assessments/'][text()='Get recommendation']")]
        public IWebElement GetRecommendation { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Mental Health Resources']")]
        public IWebElement PSPservice1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='iCBT']")]
        public IWebElement PSPservice2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='iCBT Family']")]
        public IWebElement PSPservice3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//P[@class='card-title'][text()='Crisis Management: Considerations and Support'])[1]")]
        public IWebElement PSPresource1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Moral Injury: An Employee’s Guide to Understanding and Coping']")]
        public IWebElement PSPresource2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Leadership and Moral Injury: Tips to Support Your Team']")]
        public IWebElement PSPresource3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Post-Traumatic Stress Injury (PTSI) in the Workplace: Understanding, Support, and Recovery']")]
        public IWebElement PSPresource4 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//P[@class='card-title'][text()='Supporting First Responders Through Trauma and Stress'])[1]")]
        public IWebElement PSPresource5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Supporting Successful Return to Work']")]
        public IWebElement PSPresource6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='The Invisible Wounds of Mental Health Disorders']")]
        public IWebElement PSPresource7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='The Many Faces of Post-Traumatic Stress Disorder (PTSD)']")]
        public IWebElement PSPresource8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Your Healthy Workplace Strategy: How Employees Can Build a Positive Work Environment']")]
        public IWebElement PSPresource9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='What is a Trauma Exposed Professional (TExP)?']")]
        public IWebElement PSPresource10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Self-Guided ICBT for Spouse or Significant Others of PSP: The SSO Wellbeing Course by PSPNET']")]
        public IWebElement PSPFamily1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Sentio iCBT: Online Self-Guided Therapy for Public')]")]
        public IWebElement PSPFamily2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Helping Grieving Employees']")]
        public IWebElement PSPFamily3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Helping Someone You Care About Through Trauma & Sy')]")]
        public IWebElement PSPFamily4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='How to Tell Your Child About Your Separation or Divorce']")]
        public IWebElement PSPFamily5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Retirement and Your Relationship']")]
        public IWebElement PSPFamily6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='The Importance of Social Connections for Well-Being']")]
        public IWebElement PSPFamily7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='Coping with a Suicide Loss & Navigating Grief']")]
        public IWebElement PSPFamily8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//section[contains(@class,'zone zone-resource-digest resource-grid')]//p[@class='card-title'][normalize-space()='Crisis Management: Considerations and Support']")]
        public IWebElement PSPFamily9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Suicide Prevention: What to Look for and How to Help']")]
        public IWebElement PSPFamily10 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//P[@class='card-title'][text()='Supporting First Responders Through Trauma and Stress'])[2]")]
        public IWebElement PSPFamily11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Understanding Self-Harm and Suicide: Recognizing the Signs and Finding Support']")]
        public IWebElement PSPFamily12 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div[class='col-partners col-12 col-md-8 col-xl-6'] img[alt='Wounded Warriors']")]
        public IWebElement Footer1 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div[class='col-partners col-12 col-md-8 col-xl-6'] img[alt='Homewood Health']")]
        public IWebElement Footer2 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div[class='col-partners col-12 col-md-8 col-xl-6'] img[alt='Trillium Health Partners']")]
        public IWebElement Footer3 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div[class='col-partners col-12 col-md-8 col-xl-6'] img[alt='Centre for Addiction and Mental Health']")]
        public IWebElement Footer4 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div[class='col-partners col-12 col-md-8 col-xl-6'] img[alt='Boots on the Ground']")]
        public IWebElement Footer5 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div[class='col-partners col-12 col-md-8 col-xl-6'] img[alt='Government of Ontario']")]
        public IWebElement Footer6 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[href='/en/subscribe']")]
        public IWebElement Footer7 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[href='mailto:info@warriorhealth.ca?subject=Inquiry%20from%20Warrior%20Health%20Website']")]
        public IWebElement Footer8 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "ul[class='footer-nav'] a[target='_blank']")]
        public IWebElement Footer9 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "footer[class='footer footer-standard footer-en '] li:nth-child(2) a:nth-child(1)")]
        public IWebElement Footer10 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[href='/en/terms-of-service']")]
        public IWebElement Footer11 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[href='/en/privacy-policy']")]
        public IWebElement Footer12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='searchResources']")]
        public IWebElement Searchitem { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Browse']")]
        public IWebElement Browse1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/en/assessments/'][text()='Get recommendation']")]
        public IWebElement Browse2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Trauma']")]
        public IWebElement Browse3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Supporting First Responders Through Trauma and Str')]")]
        public IWebElement Browse4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='PSPNET']")]
        public IWebElement Browse5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Therapist-Guided ICBT for PSP: The PSP PTSD Course by PSPNET']")]
        public IWebElement Browse6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='24/7 Peer Support']")]
        public IWebElement Browse7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='24/7 Crisis Support']")]
        public IWebElement Browse8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Occupationally Aware Healthcare Provider Directory']")]
        public IWebElement Browse9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'link search')]")]
        public IWebElement Search1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Search']")]
        public IWebElement Search2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Mindfulness for Anxiety - Body Scan']")]
        public IWebElement Search3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Leadership and Moral Injury: Tips to Support Your Team']")]
        public IWebElement Search4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='How Shift Work Affects Your Sleep Cycles']")]
        public IWebElement Search5 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//IMG[@src='https://warriorhealth-cdn.s3.ca-central-1.amazonaws.com/logos/warrior-health-logo.png'])[2]")]
        public IWebElement Aboutus1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//IMG[@src='https://warriorhealth-cdn.s3.ca-central-1.amazonaws.com/logos/navy/WH-consortium-partner-wounded-warriors-(navy).png']")]
        public IWebElement Aboutus2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//IMG[@src='https://warriorhealth-cdn.s3.ca-central-1.amazonaws.com/logos/navy/WH-consortium-partner-homewood-health-(navy).png']")]
        public IWebElement Aboutus3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//IMG[@src='https://warriorhealth-cdn.s3.ca-central-1.amazonaws.com/logos/navy/WH-consortium-partner-trillium-health-partners-(navy).png']")]
        public IWebElement Aboutus4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//IMG[@src='https://warriorhealth-cdn.s3.ca-central-1.amazonaws.com/logos/navy/WH-consortium-partner-CAMH-(navy).png']")]
        public IWebElement Aboutus5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//IMG[@src='https://warriorhealth-cdn.s3.ca-central-1.amazonaws.com/logos/navy/WH-consortium-partner-boots-on-the-ground-(navy).png']")]
        public IWebElement Aboutus6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='col-12 col-xl-6 col-text']//a[@aria-label='Enroll my organization'][normalize-space()='Enroll my organization']")]
        public IWebElement Enroll1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='col-12 col-xl-6 col-text']//a[@aria-label='Log in'][normalize-space()='Log in']")]
        public IWebElement Enroll2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//li[contains(text(),'Check the')]//a[contains(text(),'FAQs')]")]
        public IWebElement Enroll3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@target='_blank'][text()='Log in']")]
        public IWebElement Enroll4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='col-12 col-xl-7 col-text']//a[@aria-label='Enroll my organization'][normalize-space()='Enroll my organization']")]
        public IWebElement Enroll5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='col-12 col-xl-7 col-text']//a[@aria-label='Log in'][normalize-space()='Log in']")]
        public IWebElement Enroll6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@class='btn btn-primary'][text()='Start Screening Measures']")]
        public IWebElement Assessment1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@role='button'][text()='Not at all']")]
        public IWebElement Assessment2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='range-SQS1']")]
        public IWebElement Assessment3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@role='button'][text()='No']")]
        public IWebElement Assessment4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@role='button'][text()='Very good']")]
        public IWebElement Assessment5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='2SLGBTQ+ Inclusivity in the Workplace']")]
        public IWebElement Assessment6 { get; set; }

        [FindsBy(How = How.XPath, Using = "//INPUT[@id='organization']")]
        public IWebElement OrgEnroll1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='name']")]
        public IWebElement OrgEnroll2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='title']")]
        public IWebElement OrgEnroll3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='emailAddress']")]
        public IWebElement OrgEnroll4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='phone']")]
        public IWebElement OrgEnroll5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='city']")]
        public IWebElement OrgEnroll6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-primary'][text()=' Submit ']")]
        public IWebElement OrgEnroll7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-primary'][text()=' Sign up ']")]
        public IWebElement EmailSign1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='What is Warrior Health?']")]
        public IWebElement FAQ1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='https://woundedwarriors.ca/']")]
        public IWebElement Founder1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='https://homewoodhealth.com']")]
        public IWebElement Founder2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='https://www.thp.ca']")]
        public IWebElement Founder3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='https://www.camh.ca/']")]
        public IWebElement Founder4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='https://www.bootsontheground.ca/']")]
        public IWebElement Founder5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='https://woundedwarriors.ca/']")]
        public IWebElement Founder6 { get; set; }





    }
}
