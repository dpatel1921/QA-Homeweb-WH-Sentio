using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Homeweb_3._0_Tests.Objects
{
   
     class HomewebLoginObjects
    {
        private IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Sign In']")]
        public IWebElement Login { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Sign In']")]
        public IWebElement LoginSentio { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='text'][text()='Se connecter']")]
        public IWebElement LoginFR { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='emailAddress']")]
        public IWebElement UserName { get; set; }
    
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement Next { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@type='submit'])[1]")]
        public IWebElement NextFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='password']")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement Submit { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Toggle Account Menu']")]
        public IWebElement Profile { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Basculer le menu du compte']")]
        public IWebElement ProfileFR { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Sign out']")]
        public IWebElement Logout { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Se déconnecter']")]
        public IWebElement LogoutFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='forgot-password']")]
        public IWebElement ForgotPassword { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#Email")]
        public IWebElement Enteremail { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button[type='submit']")]
        public IWebElement Buttonsubmit { get; set; }

        // Registration Objects Homeweb
        [FindsBy(How = How.CssSelector, Using = "a[title='Register']")]
        public IWebElement Register { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#orgSearchText")]
        public IWebElement Orgsearch { get; set; }

        [FindsBy(How = How.XPath, Using = "id(\"btnOrgSearch\")")]
        public IWebElement Searchbutton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".list-group-item > a")]
        public IWebElement Selectitem { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#clientEnteredCode")]
        public IWebElement Companycode { get; set; }
        [FindsBy(How = How.XPath, Using = "id(\"clientEnteredCodeNext\")")]
        public IWebElement Nextstep { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#firstname")]
        public IWebElement Firstname { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#lastname")]
        public IWebElement LastName { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#email")]
        public IWebElement Email { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#password")]
        public IWebElement Password1 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#chkHhiPolicy")]
        public IWebElement CheckPolicy { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#noAccepMarket")]
        public IWebElement Marketing { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button#next")]
        public IWebElement NextButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#employee")]
        public IWebElement Employee { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button#next")]
        public IWebElement NextButton1 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#jobTitle")]
        public IWebElement JobTitle { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button#completeReg")]
        public IWebElement RegComplete { get; set; }

        // Registration objects homeweb FR
     
        [FindsBy(How = How.CssSelector, Using = "a[title=\"S'inscrire\"]")]
        public IWebElement RegisterFR { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#orgSearchText")]
        public IWebElement OrgsearchFR { get; set; }

        [FindsBy(How = How.XPath, Using = "id(\"btnOrgSearch\")")]
        public IWebElement SearchbuttonFR { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".list-group-item > a")]
        public IWebElement SelectitemFR { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#registrationCode")]
        public IWebElement CompanycodeFR { get; set; }
        [FindsBy(How = How.XPath, Using = "id(\"clientEnteredCodeNext\")")]
        public IWebElement NextstepFR { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#firstname")]
        public IWebElement FirstnameFR { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#lastname")]
        public IWebElement LastNameFR { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#email")]
        public IWebElement EmailFR { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#password")]
        public IWebElement Password1FR { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#chkHhiPolicy")]
        public IWebElement CheckPolicyFR { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#noAccepMarket")]
        public IWebElement MarketingFR { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#next")]
        public IWebElement NextButtonFR { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#employee")]
        public IWebElement EmployeeFR { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button#next")]
        public IWebElement NextButton1FR { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#jobTitle")]
        public IWebElement JobTitleFR { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button#completeReg")]
        public IWebElement RegCompleteFR { get; set; }

        // Landing Page objects


        [FindsBy(How = How.CssSelector, Using = "a[title='Register']")]
        public IWebElement Signup { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[title='Sign in']")]
        public IWebElement Signup1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@title='Understanding The Complex Relationship and Invisible Battle: How PTSD and Addiction Are Connected']")]
        public IWebElement Article1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@title='Embracing Hope and Healing During a Fertility Journey']")]
        public IWebElement Article2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@title='Leading Through Crises: 7 Key Areas for Supporting Employees']")]
        public IWebElement Article3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@title='Leading Through Crises: 7 Key Areas for Supporting Employees']")]
        public IWebElement Articleextra { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='FR']")]
        public IWebElement LanChange { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[title='Accueillir l’espoir et le rétablissement lors d’un parcours de fertilitée']")]
        public IWebElement Article4 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[title='Comprendre les liens complexes et la lutte invisible : liens entre l’état de stress post-traumatique et la dépendance']")]
        public IWebElement Article5 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[title='Diriger en temps de crise : les sept domaines principaux du soutien du personnel']")]
        public IWebElement Article6 { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".main-recommendation-list > li:nth-child(1) > a")]
     
        [FindsBy(How = How.CssSelector, Using = "a[href='/en/about']")]
        public IWebElement Homewood { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[href='/en/terms-of-service']")]
        public IWebElement Termsofservice { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[href='/en/privacy-policy']")]
        public IWebElement Privacypolicy { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[href='/en/accessibility']")]
        public IWebElement Accessibility { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[href='/fr/about']")]
        public IWebElement HomewoodFR { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[href='/fr/terms-of-service']")]
        public IWebElement TermsofserviceFR { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[href='/fr/privacy-policy']")]
        public IWebElement PrivacypolicyFR { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a[href='/fr/accessibility']")]
        public IWebElement AccessibilityFR { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[title=\"S'inscrire\"]")]
        public IWebElement SignupFR { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[title='Se connecter']")]
        public IWebElement Signup1FR { get; set; }

        // Alumni reg objects
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='registrationCode']")]
        public IWebElement Alumnireg { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#registrationCode")]
        public IWebElement AlumniregFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='city']")]
        public IWebElement Alumnicity { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#city")]
        public IWebElement AlumnicityFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@id='addTreatment']")]
        public IWebElement Addtreatment { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#addTreatment")]
        public IWebElement AddtreatmentFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@id='completeReg']")]
        public IWebElement alumicompletereg { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#completeReg")]
        public IWebElement alumicompleteregFR { get; set; }

        // PBC reg objects
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'0407 Holding Ltd. dba Anchor Inn & Suites[44233] [')]")]
        public IWebElement PBCadditionaldetails { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@id='register']")]
        public IWebElement PBCNextbutton { get; set; }

        // Homeweb dashboard 
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/wellness/pulsecheck']")]
        public IWebElement Checkin { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Accueil']")]
        public IWebElement CheckinFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='currentFeeling']")]
        public IWebElement Gettingby { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Watch tutorial']")]
        public IWebElement Watchtutorial { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Visionner le tutoriel']")]
        public IWebElement WatchtutorialFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@type='button'][normalize-space()='Continue']")]
        public IWebElement Continue { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@type='button'][normalize-space()='Continuer']")]
        public IWebElement ContinueFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='mood-excited']")]
        public IWebElement Moodselect { get; set; }
  
        [FindsBy(How = How.XPath, Using = "//button[@type='button'][normalize-space()='Continue']")]
        public IWebElement Moodselectcontinue { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Dashboard']")]
        public IWebElement BacktoDashboard { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Tableau de bord']")]
        public IWebElement BacktoDashboardFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Launch Pathfinder']")]
        public IWebElement Launchpathfinder { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Lancer l’Interface Parcours')]")]
        public IWebElement LaunchpathfinderFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources']")]
        public IWebElement Browse { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Consultation Du Site']")]
        public IWebElement BrowseFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Read now']")]
        public IWebElement Recommends { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='item item-dashboard item-pathfinder-recommends-v2 col-12 col-lg-8 mt-5 col-12 col-lg-6']//a[1]")]
        public IWebElement RecommendsFR { get; set; }
        [FindsBy(How = How.XPath, Using = "id(\"container-manager\")/DIV[1]/SECTION[1]/DIV[1]/DIV[5]/DIV[1]/DIV[1]/A[1]")]
        public IWebElement Pulsecheckrecommends { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='tile-resource-card col-12 col-md-6 col-lg-4 polaroid']//span[@class='polaroid-link'][normalize-space()='More information']")]
        public IWebElement Selfdirected { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='tile-resource-card col-12 col-md-6 col-lg-4 polaroid']//span[@class='polaroid-link']")]
        public IWebElement SelfdirectedFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='tile-resource-card col-12 col-md-6 col-lg-4 mt-4 mt-md-0 polaroid']//span[@class='polaroid-link'][normalize-space()='More information']")]
        public IWebElement Additionalresources { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='tile-resource-card col-12 col-md-6 col-lg-4 mt-4 mt-md-0 polaroid']//span[@class='polaroid-link']")]
        public IWebElement AdditionalresourcesFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='The Invisible Wounds of Mental Health Disorders']")]
        public IWebElement Additionalresources1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='5 Minute Read']")]
        public IWebElement Article{ get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='row section-dashboard']//div[3]//a[1]//div[2]//span[1]")]
        public IWebElement ArticleFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-secondary btn-icon-end']")]
        public IWebElement Monthreading { get; set; }
     
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Resources']")]
        public IWebElement Resources { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Ressources']")]
        public IWebElement ResourcesFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Wellness']")]
        public IWebElement Wellness { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Bien-être']")]
        public IWebElement WellnessFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[@class='text'][normalize-space()='EN']")]
        public IWebElement LanchangeEN { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Search']")]
        public IWebElement Search { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Recherche']")]
        public IWebElement SearchFR { get; set; }


        // Homewebresources

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Tools']")]
        public IWebElement Tools { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/outils']")]
        public IWebElement ToolsFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Childcare Resource Locator by LifestageCare']")]
        public IWebElement Childcarelocator { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Localisateur de ressources pour les soins aux enfa')]")]
        public IWebElement ChildcarelocatorFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@class='btn btn-primary d-inline-block'][text()='Access Childcare Resource Locator by LifestageCare']")]
        public IWebElement Childcarelocatorstart { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-primary d-inline-block']")]
        public IWebElement ChildcarelocatorstartFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-primary'][text()='Close']")]
        public IWebElement Childcarelocatorstop { get; set; }
        [FindsBy(How = How.XPath, Using = "//i[@class='fa-solid fa-chevron-right']")]
        public IWebElement Childcarelocatoraccept { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Tools']")]
        public IWebElement Backtotools { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Health and Wellness Library']")]
        public IWebElement HealthandWellness { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Le Questionnaire santé']")]
        public IWebElement HealthandWellnessFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Head to the library']")]
        public IWebElement HealthandWellnesslibrary { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-primary d-inline-block']")]
        public IWebElement HealthandWellnesslibraryFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The Health Risk Assessment offers an assessment on')]")]
        public IWebElement Healthriskassessment { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@class='btn btn-primary d-inline-block'][text()='Access Health Risk Assessment']")]
        public IWebElement Healthriskassessmentaccept { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Sentio by Homewood Health']")]
        public IWebElement Sentio { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Sentio par Homewood Santé']")]
        public IWebElement SentioFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@class='btn btn-primary d-inline-block'][text()='Access Sentio']")]
        public IWebElement SentioStart { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-primary d-inline-block']")]
        public IWebElement SentioStartFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@data-bs-dismiss='modal'][text()='Accept']")]
        public IWebElement SentioAccept { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='https://sentioapp.com'][text()='Access Sentio iCBT']")]
        public IWebElement Sentiostartbutton { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Depression & Anxiety']")]
        public IWebElement PBCdepression { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@class='btn btn-primary d-inline-block'][text()='Access iVolve']")]
        public IWebElement PBCStart { get; set; }

        //homeweb resources

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Webinars']")]
        public IWebElement Webinars { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='content']//p[contains(text(),'In this session, Homewood Health will discuss the ')]")]
        public IWebElement Covid19 { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@title='Play']")]
        public IWebElement Youtube { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Resources']")]
        public IWebElement BacktoResources { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Wellness Sessions']")]
        public IWebElement Wellnesssessions { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​In today’s society, there remains a lack of aware')]")]
        public IWebElement Beyondstigma { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Student Life']")]
        public IWebElement Buildyourresi { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Crisis']")]
        public IWebElement MentalHealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The death of a close colleague or loved one is one')]")]
        public IWebElement Childmentalpodcast { get; set; }
        [FindsBy(How = How.XPath, Using = "//audio[@type='audio/mpeg']")]
        public IWebElement Podcastplay { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Most people aren’t fond of change. We like our ha')]")]
        public IWebElement Adpatingtochange { get; set; }

        //Sentio
        [FindsBy(How = How.XPath, Using = "(//a[@class='btn btn-primary'])[2]")]
        public IWebElement SentioAnxiety { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@href='/app/en/program/anxiety/overview']")]
        public IWebElement SentioAnxiety1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@href='/app/en/program/mental-health-wellness/overview']")]
        public IWebElement SentioMentalHealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@href='/app/en/program/coexisting-anxiety-depression/overview']")]
        public IWebElement SentioCoexist { get; set; }
        [FindsBy(How = How.XPath, Using = "(//p[text()='Begin your program by completing a brief assessment so we can evaluate if this program is right for you.']/following-sibling::a)[1]")]
        public IWebElement SentioMentalHealthbegin { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@href='/app/en/sentio/dashboard'][text()='Get started'])[1]")]
        public IWebElement SentioGetStarted { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Learn More']")]
        public IWebElement SentioLearnmore { get; set; }
        [FindsBy(How = How.XPath, Using = "//img[@class='lockup-logo logo-desktop d-none d-md-block']")]
        public IWebElement SentioHome { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/en/login'][text()='Get Started']")]
        public IWebElement SentioGetStarted1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Create Account']")]
        public IWebElement SentioCreateAccount { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='d-inline-block']")]
        public IWebElement SentioHowTo { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='https://homewoodhealth.com/contact/'][text()='Contact Homewood Health']")]
        public IWebElement SentioContactHH { get; set; }
        [FindsBy(How = How.XPath, Using = "(//IMG[@class='store-image'])[1]")]
        public IWebElement SentioAppstore1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//IMG[@class='store-image'])[2]")]
        public IWebElement SentioAppstore2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//IMG[@src='https://homewood-cdn.s3.ca-central-1.amazonaws.com/client/images/uploads/google-play.png']")]
        public IWebElement SentioAppstore3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//IMG[@src='https://homewood-cdn.s3.ca-central-1.amazonaws.com/client/images/uploads/app-store.png']")]
        public IWebElement SentioAppstore4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-primary pulse-primary']")]
        public IWebElement SentioAnxietyBegin { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Not at all'])[1]")]
        public IWebElement SentioAnxietyQuestion1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Not at all'])[2]")]
        public IWebElement SentioAnxietyQuestion2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Not at all'])[3]")]
        public IWebElement SentioAnxietyQuestion3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Not at all'])[4]")]
        public IWebElement SentioAnxietyQuestion4 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Not at all'])[5]")]
        public IWebElement SentioAnxietyQuestion5 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Not at all'])[6]")]
        public IWebElement SentioAnxietyQuestion6 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Not at all'])[7]")]
        public IWebElement SentioAnxietyQuestion7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@id='submitBtn']")]
        public IWebElement SentioAnxietystartprogram { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@href='/app/en/program/anxiety/selected/64/understanding-anxiety-first-step-toward-relief'])[1]")]
        public IWebElement SentioAnxietycourse { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Next']")]
        public IWebElement SentioAnxietycourse1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement SentioAnxietycoursesubmit { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Continue with electives']")]
        public IWebElement SentioAnxietycourseelectives { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement SentioAnxietymoodtracker { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Complete']")]
        public IWebElement SentioAnxietymoodcomplete { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-primary']")]
        public IWebElement SentioAnxietymoodtracker1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space(text())='Start Task']")]
        public IWebElement SentioAnxietymoodtracker2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='text'][text()='Dashboard']")]
        public IWebElement SentioDashboard { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='withdraw']")]
        public IWebElement SentioWithdraw { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/program/depression/withdraw'][text()='withdraw']")]
        public IWebElement SentioWithdraw1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement SentioEndTreatment { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@href='/app/en/program/depression/overview']")]
        public IWebElement SentioDepression { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Not at all'])[8]")]
        public IWebElement SentioDepressionQuestion8 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Not at all'])[9]")]
        public IWebElement SentioDepressionQuestion9 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//a[@data-pulse-class='pulse-primary'])[1]")]
        public IWebElement SentioDeperessionBegin { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'btn btn-outline-primary')]")]
        public IWebElement Sentiogeneralassessment { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/sentio/assessments/general/start'][text()='Begin assessment quiz']")]
        public IWebElement Sentiogeneralassessmentbegin { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@class='btn btn-primary'][text()='View programs']")]
        public IWebElement Sentiogeneralassessmentviewprograms { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space(text())='About Sentio']")]
        public IWebElement Aboutsentio { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space(text())='Welcome']")]
        public IWebElement Welcome { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space(text())='FAQs']")]
        public IWebElement SentioFAQ { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space(text())='Terms of Service']")]
        public IWebElement SentioTerms { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space(text())='Terms of Service']")]
        public IWebElement SentioPrivacy { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space(text())='Accessibility']")]
        public IWebElement SentioAccessibility { get; set; }
        [FindsBy(How = How.XPath, Using = "(//a[contains(@class,'btn btn-primary')])[2]")]
        public IWebElement SentioProgramNext { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='text'][text()='Tasks']")]
        public IWebElement SentioTasks { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Thought Journal']")]
        public IWebElement SentioTasksjournal { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-primary']")]
        public IWebElement SentioTasksjournal1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//textarea[@id='question1']")]
        public IWebElement SentioTasksjournal2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Next '])[1]")]
        public IWebElement SentioTasksjournal3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//textarea[@id='question2']")]
        public IWebElement SentioTasksjournal4 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Next '])[2]")]
        public IWebElement SentioTasksjournal5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//textarea[@id='question3']")]
        public IWebElement SentioTasksjournal6 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Next '])[3]")]
        public IWebElement SentioTasksjournal7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//textarea[@id='question4']")]
        public IWebElement SentioTasksjournal8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='text'][text()='Submit ']")]
        public IWebElement SentioTasksjournal9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Mood Check']")]
        public IWebElement SentioTasksMood { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[@for='question1option1']")]
        public IWebElement SentioTasksMood1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Cognitive Restructuring']")]
        public IWebElement SentioTasksCog { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Select a previous entry']")]
        public IWebElement SentioTasksCog1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@type='button'][text()='Select entry']")]
        public IWebElement SentioTasksCog2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Next '])[4]")]
        public IWebElement SentioTasksCog3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//TEXTAREA[@id='question5']")]
        public IWebElement SentioTasksCog4 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Next '])[5]")]
        public IWebElement SentioAnxietynext5 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Next '])[6]")]
        public IWebElement SentioAnxietynext6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//TEXTAREA[@id='question6']")]
        public IWebElement SentioAnxietyquestion6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//TEXTAREA[@id='question7']")]
        public IWebElement SentioAnxietyquestion7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='question1option1']")]
        public IWebElement SentioAnxietyinput1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='question2option1']")]
        public IWebElement SentioAnxietyinput2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='question3option1']")]
        public IWebElement SentioAnxietyinput3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='question4option1']")]
        public IWebElement SentioAnxietyinput4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='question5option1']")]
        public IWebElement SentioAnxietyinput5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='question6option1']")]
        public IWebElement SentioAnxietyinput6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='question7option1']")]
        public IWebElement SentioAnxietyinput7 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Next '])[7]")]
        public IWebElement SentioAnxietynext7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='question8option1']")]
        public IWebElement SentioAnxietyinput8 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Next '])[8]")]
        public IWebElement SentioAnxietynext8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//TEXTAREA[@id='question9']")]
        public IWebElement SentioAnxietyquestion9 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@type='button'][text()='Select entry'])[1]")]
        public IWebElement SentioAnxietyselectentry { get; set; }
        [FindsBy(How = How.XPath, Using = "//TEXTAREA[@id='question8']")]
        public IWebElement SentioAnxietyquestion8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@type='submit'][text()='Complete program']")]
        public IWebElement SentioAnxietycompleteprogram { get; set; }

        //SentioFR
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/program/anxiete-1/overview'][text()='Voir le programme']")]
        public IWebElement SentioAnxietyFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/sentio/dashboard'][text()='Pour commencer']")]
        public IWebElement SentioGetStartedFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@href='/app/fr/sentio/program/anxiete-1/assessments/start/Q1-17525941257703-F42FD142F40F69'])[1]")]
        public IWebElement SentioAnxietyBeginFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Pas du tout'])[1]")]
        public IWebElement SentioAnxietyQuestion1FR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Pas du tout'])[2]")]
        public IWebElement SentioAnxietyQuestion2FR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Pas du tout'])[3]")]
        public IWebElement SentioAnxietyQuestion3FR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Pas du tout'])[4]")]
        public IWebElement SentioAnxietyQuestion4FR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Pas du tout'])[5]")]
        public IWebElement SentioAnxietyQuestion5FR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Pas du tout'])[6]")]
        public IWebElement SentioAnxietyQuestion6FR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Pas du tout'])[7]")]
        public IWebElement SentioAnxietyQuestion7FR { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@id='submitBtn']")]
        public IWebElement SentioAnxietystartprogramFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/program/depression-1/overview'][text()='Voir le programme']")]
        public IWebElement SentioDepressionFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Pas du tout'])[8]")]
        public IWebElement SentioDepressionQuestion8FR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'][text()='Pas du tout'])[9]")]
        public IWebElement SentioDepressionQuestion9FR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@href='/app/fr/program/depression-1/assessments/start/Q1-17525941257703-CEBDF601492111'])[1]")]
        public IWebElement SentioDeperessionBeginFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@class='btn btn-outline-primary btn-icon-end']")]
        public IWebElement SentiogeneralassessmentFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@href='/app/fr/assessments/general/start'])[2]")]
        public IWebElement SentiogeneralassessmentbeginFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@class='btn btn-primary'][text()='Voir les programmes']")]
        public IWebElement SentiogeneralassessmentviewprogramsFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@href='/fr/about'][text()='À propos de Sentio'])[2]")]
        public IWebElement AboutsentioFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/fr/faq'][text()='FAQs']")]
        public IWebElement SentioFAQFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@href='/fr/terms'])[2]")]
        public IWebElement SentioTermsFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//A[@href='/fr/privacy'][text()='Politique de confidentialité'])[2]")]
        public IWebElement SentioPrivacyFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/fr/accessibility'][text()='Accessibilité']")]
        public IWebElement SentioAccessibilityFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//a[contains(@class,'btn btn-primary')])[2]")]
        public IWebElement SentioProgramNextFR { get; set; }

        //Pathfinder

        [FindsBy(How = How.CssSelector, Using = "input#myFeeling")]
        public IWebElement Slider { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a.button:nth-child(4)")]
        public IWebElement Checkin1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".dsg-canvas--alignEnd > a")]
        public IWebElement Watchtutorial1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".u-hide--palm > .buttonNext")]
        public IWebElement Continue1 { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".buttonOptions:nth-child(2) > span")]
        public IWebElement Takemedashboard { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Launch Pathfinder']")]
        public IWebElement Pathfinder { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Lancer l’Interface Parcours')]")]
        public IWebElement PathfinderFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Mental health & addiction']")]
        public IWebElement Problemissue { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Dépendance et santé mentale']")]
        public IWebElement ProblemissueFR { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button.buttonOptions:nth-child(1)")]
        public IWebElement Problemselect { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a.dashboard-link")]
        public IWebElement backtodashboard { get; set; }
        [FindsBy(How = How.CssSelector, Using = "li:nth-child(2) > .button")]
        public IWebElement Tools1 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a.siteNav-language")]
        public IWebElement Language { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".resultItem:nth-child(1) .resultTitle")]
        public IWebElement Article10 { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".resultItem:nth-child(15) .resultTitle")]
        public IWebElement Video { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".sidebarNav-item:nth-child(6) > a")]
        public IWebElement sidebar { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".resultItem:nth-child(3) .resultTitle")]
        public IWebElement podcast { get; set; }
        [FindsBy(How = How.CssSelector, Using = "p:nth-child(1) > a")]
        public IWebElement Forgotpassword { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#Email")]
        public IWebElement Enteremail1 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button.btn-primary")]
        public IWebElement Buttonsubmit1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Extremely upset to the point that I cannot functio')]")]
        public IWebElement PFAssessment { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Bouleversé/e au point de ne pas pouvoir fonctionne')]")]
        public IWebElement PFAssessmentFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Grief & bereavement']")]
        public IWebElement Problemissue1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Deuil ou pertes affectives']")]
        public IWebElement Problemissue1FR { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Never']")]
        public IWebElement PFAssessment1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Jamais']")]
        public IWebElement PFAssessment1FR { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Never']")]
        public IWebElement PFAssessment2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Never']")]
        public IWebElement PFAssessment3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Never']")]
        public IWebElement PFAssessment4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Get started']")]
        public IWebElement PFAssessmentbutton { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Alors commençons']")]
        public IWebElement PFAssessmentbuttonFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[@for='4']//i[@role='presentation']")]
        public IWebElement Star { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".radio-group:nth-child(4) > label")]
        public IWebElement Radio { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-outline-primary-offwhite btn-icon-end submit-inner']")]
        public IWebElement Next1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement EmailNext { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-outline-muted-white btn-answer']")]
        public IWebElement Meetnow { get; set; }
   
        [FindsBy(How = How.XPath, Using = "//DIV[@class='dp__cell_inner dp__pointer dp__cell_highlight_active dp__today dp__active_date']")]
        public IWebElement SelectDate { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div[class='collection collection-provider-matches d-flex'] div:nth-child(1) div:nth-child(1) div:nth-child(2) div:nth-child(1) div:nth-child(2) button:nth-child(1)")]
        public IWebElement SelectTime { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@type='button'])[6]")]
        public IWebElement SelectMode { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-tall btn-outline-muted-white btn-booking btn-reschedule']")]
        public IWebElement SelectYes { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Text']")]
        public IWebElement SelectText { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Par message texte']")]
        public IWebElement SelectTextFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@type='submit'])[1]")]
        public IWebElement SelectNext { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='acceptPhoneTerms']")]
        public IWebElement SelectCheck { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-outline-primary']")]
        public IWebElement SelectDashboard { get; set; }
        [FindsBy(How = How.CssSelector, Using = "label:nth-child(3)")]
        public IWebElement SelectRating { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button.buttonRounded--white:nth-child(2)")]
        public IWebElement Reschedule { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a.buttonOptions:nth-child(1)")]
        public IWebElement Iunderstandreschedule { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@class='btn btn-outline-primary'][text()=' Cancel ']")]
        public IWebElement Cancel { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-outline-muted-white btn-booking btn-cancel'][text()=' Yes ']")]
        public IWebElement CancelYes { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn-link'][text()=' end services']")]
        public IWebElement EndServices { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='btn-link']")]
        public IWebElement EndServicesFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-outline-primary']")]
        public IWebElement YesDone { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-outline-muted-white btn-booking btn-cancel cancel-confirm']")]
        public IWebElement YesEnd { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='640B10D4-B872-4557-9178-B2DC1C222487']")]
        public IWebElement Reason { get; set; }


        //Publisher Sentio

        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Launch Publisher']")]
        public IWebElement LaunchPub { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Access Sentio Content']")]
        public IWebElement LaunchPubSentio { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='View activities']")]
        public IWebElement ViewActivities { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Voir les activités']")]
        public IWebElement ViewActivitiesFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Dashboard']")]
        public IWebElement ViewDashboard { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Tableau de bord']")]
        public IWebElement ViewDashboardFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='View courses']")]
        public IWebElement ViewCourses { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Voir les cours']")]
        public IWebElement ViewCoursesFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='View programs']")]
        public IWebElement ViewPrograms { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Voir les programmes']")]
        public IWebElement ViewProgramsFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='View pages']")]
        public IWebElement ViewPages { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Afficher les pages']")]
        public IWebElement ViewPagesFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='View assets']")]
        public IWebElement Viewassets { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Afficher les actifs']")]
        public IWebElement ViewassetsFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Add Activity']")]
        public IWebElement AddActivity { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='referenceTitle']")]
        public IWebElement ActivityName { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-save text-uppercase btn-icon-spaced'])[1]")]
        public IWebElement ActivitySave { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='search']")]
        public IWebElement ActivitySearch { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Preview']")]
        public IWebElement ActivityPreview { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Mobile']")]
        public IWebElement ActivityPreviewmobile { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@id='modal-close']")]
        public IWebElement ActivityPreviewclose { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='text'][text()='Edit']")]
        public IWebElement ActivityEdit { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Modifier'])[1]")]
        public IWebElement ActivityEditFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='text'][text()='Edit Details']")]
        public IWebElement ActivityEditdetails { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='text'][text()='Modifier les détails']")]
        public IWebElement ActivityEditdetailsFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-save text-uppercase btn-icon-spaced'])[2]")]
        public IWebElement ActivityEditsave { get; set; }
        [FindsBy(How = How.XPath, Using = "(//button[@aria-label='Close'])[3]")]
        public IWebElement ActivityEditClose { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Delete'])[1]")]
        public IWebElement ActivityEditDelete { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Supprimer'])[1]")]
        public IWebElement ActivityEditDeleteFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Delete'])[2]")]
        public IWebElement ActivityEditDeleteconfirm { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-danger btn-icon-spaced mx-1']")]
        public IWebElement ActivityEditDeleteconfirmFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Delete'])[3]")]
        public IWebElement ActivityEditDeleteconfirm1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Supprimer'])[3]")]
        public IWebElement ActivityEditDeleteconfirm1FR { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Courses']")]
        public IWebElement ViewCoursespub { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Cours']")]
        public IWebElement ViewCoursespubFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[text()='Add']")]
        public IWebElement Coursesadd { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Ajouter']")]
        public IWebElement CoursesaddFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-save text-uppercase btn-icon-spaced'])[2]")]
        public IWebElement Coursessave { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Programs']")]
        public IWebElement ViewProgramspub { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='text'][text()='Programmes'])[1]")]
        public IWebElement ViewProgramspubFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Pages']")]
        public IWebElement ViewPagespub { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Pages']")]
        public IWebElement ViewPagespubFR { get; set; }

        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-save text-uppercase btn-icon-spaced'])[1]")]
        public IWebElement Pagesave { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Edit Status']")]
        public IWebElement Pageedit { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@type='button'])[2]")]
        public IWebElement PageeditFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Assets']")]
        public IWebElement ViewAssets { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Actifs']")]
        public IWebElement ViewAssetsFR { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input[name='input-fileUpload']")]
        public IWebElement Assetsupload { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='title']")]
        public IWebElement AssetName { get; set; }
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='btn btn-save text-uppercase btn-icon-spaced']")]
        public IWebElement AssetSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//INPUT[@id='source']")]
        public IWebElement AssetSource { get; set; }

        // Publisher Homeweb

        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Access Homeweb Content']")]
        public IWebElement LaunchPubHomeweb { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='View content']")]
        public IWebElement ViewContent { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Afficher le contenu']")]
        public IWebElement ViewContentFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='View authors']")]
        public IWebElement ViewAuthor { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Voir les auteurs']")]
        public IWebElement ViewAuthorFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='View categories']")]
        public IWebElement ViewCategories { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Afficher les catégories']")]
        public IWebElement ViewCategoriesFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='View pages']")]
        public IWebElement ViewPagesHomeweb { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Afficher les pages']")]
        public IWebElement ViewPagesHomewebFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='View tags']")]
        public IWebElement ViewTags { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Voir les tags']")]
        public IWebElement ViewTagsFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[text()='Add']")]
        public IWebElement AddContent { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@role='button'])[2]")]
        public IWebElement AddContentFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='referenceTitle']")]
        public IWebElement ContentTitle { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='estimatedTime']")]
        public IWebElement ContentTime { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='text'][text()='Edit Metadata']")]
        public IWebElement ContentEdit { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Modifier les métadonnées']")]
        public IWebElement ContentEditFR { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='btn btn-save text-uppercase btn-icon-spaced'])[1]")]
        public IWebElement ContentEditSave { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Authors']")]
        public IWebElement AuthorSelect { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Auteurs']")]
        public IWebElement AuthorSelectFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='name']")]
        public IWebElement AuthorName { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Categories']")]
        public IWebElement CatSelect { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Catégories']")]
        public IWebElement CatSelectFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='name']")]
        public IWebElement CatName { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Edit Details']")]
        public IWebElement CatEdit { get; set; }
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@type='button'])[2]")]
        public IWebElement CatEditFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='restrictResource']")]
        public IWebElement CatRestrict { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Tags']")]
        public IWebElement TagSelect { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Balises']")]
        public IWebElement TagSelectFR { get; set; }
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='label']")]
        public IWebElement TagLabel { get; set; }
    }
}
