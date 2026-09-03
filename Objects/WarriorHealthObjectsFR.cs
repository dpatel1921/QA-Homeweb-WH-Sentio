using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorHealthBeta.Objects
{
    internal class WarriorHealthObjectsFR
    {
        private IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//A[@href='/fr'][text()='Accueil']")]
        public IWebElement Home { get; set; }
        [FindsBy(How = How.XPath, Using = "//nav[@class='navbar navbar-expand-lg']//img[@alt='Warrior Health']")]
        public IWebElement WHlogo { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'link home')]")]
        public IWebElement Home1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/fr/browse'][text()='Parcourir']")]
        public IWebElement Browse { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/fr/assessments/'][text()='Évaluations']")]
        public IWebElement Assessments { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/fr/resources/search'][text()='Chercher']")]
        public IWebElement Search { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/fr/faq'][text()='FAQs']")]
        public IWebElement FAQ { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/fr/about'][text()='À propos de nous']")]
        public IWebElement AboutUs { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/fr/pso/'][text()='Pour les organismes de sécurité publique']")]
        public IWebElement PSO { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='text'][text()='Français']")]
        public IWebElement Toggle { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='text'][text()='English']")]
        public IWebElement ToggleEng { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Pour les individus']")]
        public IWebElement ForIndividuals { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Pour les familles']")]
        public IWebElement ForFamilies { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Pour les organisations']")]
        public IWebElement ForOrgs { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Soutien par les pairs 24/7']")]
        public IWebElement PeerSupport { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Soutien en cas de crise 24/7']")]
        public IWebElement CrisisSupport { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='container-partners']//img[@alt='Guerriers blessés']")]
        public IWebElement Poweredby1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='container-partners']//img[@alt='Homewood Santé']")]
        public IWebElement Poweredby2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='container-partners']//img[@alt='Partenaires de santé Trillium']")]
        public IWebElement Poweredby3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='container-partners']//img[@alt='Centre de toxicomanie et de santé mentale']")]
        public IWebElement Poweredby4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='container-partners']//img[@alt='Les bottes sur le terrain']")]
        public IWebElement Poweredby5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='container-partners']//img[@alt='Gouvernement de l’Ontario']")]
        public IWebElement Poweredby6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/fr/browse'][text()='Tous les articles']")]
        public IWebElement Coreservice { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/fr/assessments/'][text()='Obtenir une recommandation']")]
        public IWebElement GetRecommendation { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Ressources en santé mentale']")]
        public IWebElement PSPservice1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='TCC']")]
        public IWebElement PSPservice2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='TCC pour les familles']")]
        public IWebElement PSPservice3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//P[@class='card-title'][text()='Gestion de crise : considérations et soutien'])[1]")]
        public IWebElement PSPresource1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Le préjudice moral : Un guide pratique pour les employé·e·s']")]
        public IWebElement PSPresource2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Leadership et préjudice moral : Conseils pour soutenir votre équipe']")]
        public IWebElement PSPresource3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Blessure de stress post-traumatique (BSPT) en milieu de travail : Compréhension, soutien et rétablissement']")]
        public IWebElement PSPresource4 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//P[@class='card-title'][text()='Soutenir les premiers répondants face au traumatisme et au stress'])[1]")]
        public IWebElement PSPresource5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Soutenir un retour au travail réussi']")]
        public IWebElement PSPresource6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Les blessures invisibles des troubles de santé mentale']")]
        public IWebElement PSPresource7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Les multiples visages du trouble de stress post-traumatique (TSPT)']")]
        public IWebElement PSPresource8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Votre stratégie pour un milieu de travail sain : comment les employé·es peuvent contribuer à un environnement positif']")]
        public IWebElement PSPresource9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='What is a Trauma Exposed Professional (TExP)?']")]
        public IWebElement PSPresource10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='TCCI autoguidée pour les proches des membres du PSP : Le cours de bien-être de PSPNET']")]
        public IWebElement PSPFamily1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//img[@alt='Image pour Sentio iTCC : Thérapie cognitivo-comportementale auto-guidée en ligne pour le personnel de la sécurité publique et leurs familles']")]
        public IWebElement PSPFamily2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Aider un proche à travers le traumatisme et les symptômes de BSPT/TSPT']")]
        public IWebElement PSPFamily3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Comment annoncer votre séparation ou divorce à votre enfant']")]
        public IWebElement PSPFamily4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='L’importance des liens sociaux pour le bien-être']")]
        public IWebElement PSPFamily5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='La retraite et votre relation de couple']")]
        public IWebElement PSPFamily6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Soutenir les employé·e·s en deuil']")]
        public IWebElement PSPFamily7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Composer avec la perte par suicide et traverser le deuil']")]
        public IWebElement PSPFamily8 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//P[@class='card-title'])[21]")]
        public IWebElement PSPFamily9 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//P[@class='card-title'][text()='Gestion de crise : considérations et soutien'])[2]")]
        public IWebElement PSPFamily10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Prévention du suicide : signes à surveiller et façons d’aider']")]
        public IWebElement PSPFamily11 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//P[@class='card-title'][text()='Soutenir les premiers répondants face au traumatisme et au stress'])[2]")]
        public IWebElement PSPFamily12 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div[class='col-partners col-12 col-md-8 col-xl-6'] img[alt='Guerriers blessés']")]
        public IWebElement Footer1 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div[class='col-partners col-12 col-md-8 col-xl-6'] img[alt='Homewood Santé']")]
        public IWebElement Footer2 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div[class='col-partners col-12 col-md-8 col-xl-6'] img[alt='Partenaires de santé Trillium']")]
        public IWebElement Footer3 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div[class='col-partners col-12 col-md-8 col-xl-6'] img[alt='Centre de toxicomanie et de santé mentale']")]
        public IWebElement Footer4 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div[class='col-partners col-12 col-md-8 col-xl-6'] img[alt='Les bottes sur le terrain']")]
        public IWebElement Footer5 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div[class='col-partners col-12 col-md-8 col-xl-6'] img[alt='Gouvernement de l’Ontario']")]
        public IWebElement Footer6 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[href='/fr/subscribe']")]
        public IWebElement Footer7 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[href='mailto:info@warriorhealth.ca?subject=Demande%20de%20renseignements%20sur%20le%20site%20Web%20de%20Warrior%20Health']")]
        public IWebElement Footer8 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "ul[class='footer-nav'] a[target='_blank']")]
        public IWebElement Footer9 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "footer[class='footer footer-standard footer-fr '] li:nth-child(2) a:nth-child(1)")]
        public IWebElement Footer10 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[href='/fr/terms-of-service']")]
        public IWebElement Footer11 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[href='/fr/privacy-policy']")]
        public IWebElement Footer12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='searchResources']")]
        public IWebElement Searchitem { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Browse']")]
        public IWebElement Browse1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/fr/assessments/'][text()='Obtenir une recommandation']")]
        public IWebElement Browse2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/fr/browse/WH67f554b33ddbc2083391167'][text()='Traumatisme ']")]
        public IWebElement Browse3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Blessure de stress post-traumatique (BSPT) en milieu de travail : Compréhension, soutien et rétablissement']")]
        public IWebElement Browse4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/fr/browse/WH68088912abb734074538463'][text()='PSPNET ']")]
        public IWebElement Browse5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Cours de bien-être TCCI avec le soutien de thérapeutes pour les membres du PSP : Le cours de bien-être de PSPNET']")]
        public IWebElement Browse6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@target='_self'][text()='Soutien par les pairs 24/7']")]
        public IWebElement Browse7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@target='_self'][text()='Soutien en cas de crise 24/7']")]
        public IWebElement Browse8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@target='_blank'][text()='Répertoire des prestataires de soins de santé conscients de leurs responsabilités professionnelles']")]
        public IWebElement Browse9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'link search')]")]
        public IWebElement Search1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Search']")]
        public IWebElement Search2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Aider un proche à travers le traumatisme et les symptômes de BSPT/TSPT']")]
        public IWebElement Search3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Aider un proche à travers le traumatisme et les symptômes de BSPT/TSPT']")]
        public IWebElement Search4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//picture[@class='wh-logo']//img[@alt='Warrior Health']")]
        public IWebElement Aboutus1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='partners']//img[@alt='Guerriers blessés']")]
        public IWebElement Aboutus2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='partners']//img[@alt='Homewood Santé']")]
        public IWebElement Aboutus3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='partners']//img[@alt='Partenaires de santé Trillium']")]
        public IWebElement Aboutus4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='partners']//img[@alt='Centre de toxicomanie et de santé mentale']")]
        public IWebElement Aboutus5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='partners']//img[@alt='Les bottes sur le terrain']")]
        public IWebElement Aboutus6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='col-12 col-xl-6 col-text']//a[@aria-label='Inscrire mon organisation'][normalize-space()='Inscrire mon organisation']")]
        public IWebElement Enroll1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='col-12 col-xl-6 col-text']//a[@aria-label='Se connecter'][normalize-space()='Se connecter']")]
        public IWebElement Enroll2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//li[contains(text(),'Consulter les')]//a[contains(text(),'FAQs')]")]
        public IWebElement Enroll3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@target='_blank'][text()='Se connecter']")]
        public IWebElement Enroll4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='col-12 col-xl-7 col-text']//a[@aria-label='Inscrire mon organisation'][normalize-space()='Inscrire mon organisation']")]
        public IWebElement Enroll5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='col-12 col-xl-7 col-text']//a[@aria-label='Se connecter'][normalize-space()='Se connecter']")]
        public IWebElement Enroll6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-primary'][text()='Commencer']")]
        public IWebElement Assessment1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@type='button'][text()=' Commencer les mesures de dépistage ']")]
        public IWebElement NewAssessment { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Pas du tout'])[1]")]
        public IWebElement Assessment2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Pas du tout'])[2]")]
        public IWebElement Assessment3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='range-undefined']")]
        public IWebElement Select { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@role='button'][text()='Suivant']")]
        public IWebElement Next { get; set; }

        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Non'])[1]")]
        public IWebElement Assessment4 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Non'])[2]")]
        public IWebElement Assessment5 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Non'])[3]")]
        public IWebElement Assessment6 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Non'])[4]")]
        public IWebElement Assessment7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@role='button'][text()='Très bon']")]
        public IWebElement Assessment8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[@class='card-title'][text()='Améliorez votre sommeil avec Sentio iTCC']")]
        public IWebElement Assessment9 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Neutre'])[1]")]
        public IWebElement Assessment10 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Neutre'])[2]")]
        public IWebElement Assessment11 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Neutre'])[3]")]
        public IWebElement Assessment12 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Neutre'])[4]")]
        public IWebElement Assessment13 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Neutre'])[5]")]
        public IWebElement Assessment14 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Neutre'])[6]")]
        public IWebElement Assessment15 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='jamais/très faiblement'])[1]")]
        public IWebElement Assessment16 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='jamais/très faiblement'])[2]")]
        public IWebElement Assessment17 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='jamais/très faiblement'])[3]")]
        public IWebElement Assessment18 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='jamais/très faiblement'])[4]")]
        public IWebElement Assessment19 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='jamais/très faiblement'])[5]")]
        public IWebElement Assessment20 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='jamais/très faiblement'])[6]")]
        public IWebElement Assessment21 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'])[1]")]
        public IWebElement Assessment22 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'])[5]")]
        public IWebElement Assessment23 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'])[9]")]
        public IWebElement Assessment24 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'])[13]")]
        public IWebElement Assessment25 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'])[17]")]
        public IWebElement Assessment26 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'])[21]")]
        public IWebElement Assessment27 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'])[25]")]
        public IWebElement Assessment28 { get; set; }

        [FindsBy(How = How.XPath, Using = "//INPUT[@id='organization']")]
        public IWebElement OrgEnroll1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='firstName']")]
        public IWebElement OrgEnroll2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='title']")]
        public IWebElement OrgEnroll3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='emailAddress']")]
        public IWebElement OrgEnroll4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='phone']")]
        public IWebElement OrgEnroll5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='city']")]
        public IWebElement OrgEnroll6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-primary'][text()=' Soumettre ']")]
        public IWebElement OrgEnroll7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='lastName']")]
        public IWebElement OrgEnroll8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='addressLine1']")]
        public IWebElement OrgEnroll9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//DIV[@class='name svelte-13dp8ho'][text()='NAVIGATIO​N SUPPORT CHAT']")]
        public IWebElement ChatBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@title='Minimize']//*[name()='svg']")]
        public IWebElement ChatMin { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='postalCode']")]
        public IWebElement OrgEnroll10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='authorizedRepresentative']")]
        public IWebElement OrgEnroll11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-primary']")]
        public IWebElement EmailSign1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='accordion-button'])[1]")]
        public IWebElement FAQ1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='https://woundedwarriors.ca/fr/']")]
        public IWebElement Founder1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='https://homewoodhealth.com/fr/']")]
        public IWebElement Founder2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='https://www.thp.ca']")]
        public IWebElement Founder3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='https://www.camh.ca/fr/']")]
        public IWebElement Founder4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='https://www.bootsontheground.ca/']")]
        public IWebElement Founder5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='name']")]
        public IWebElement OrgEmailupdate { get; set; }






    }
}
