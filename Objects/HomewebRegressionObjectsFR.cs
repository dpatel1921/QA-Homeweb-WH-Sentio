using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeweb_3._0_Tests.Objects
{
    internal class HomewebRegressionObjectsFR
    {
        //Getting Started FR
        private IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Commencer']")]
        public IWebElement Gettingstarted { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Étiez-vous craintif* dans le noir quand vous étiez')]")]
        public IWebElement BuildingResi { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cet article vous apprendra : Comment mieux communi')]")]
        public IWebElement Copingwith { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/commencer'][text()='Commencer']")]
        public IWebElement Gettingstartedtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Environ trois millions de Canadiens* sont actuelle')]")]
        public IWebElement Griefandloss { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Vous-même ou d')]")]
        public IWebElement ImprovingFamily { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cet article vous apprendra à : Ce à quoi vous atte')]")]
        public IWebElement MovingBeyond { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Travailler à son rétablissement revient parfois un')]")]
        public IWebElement Positiveinfluence { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Prendre les moyens de gérer votre stress est proba')]")]
        public IWebElement Resilience { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ce cours en ligne vous permettra de : Accéder à un')]")]
        public IWebElement TakingCharge { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Prendre le contrôle de votre humeur : des habitudes saines']")]
        public IWebElement TakingControlMood { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cet article vous apprendra : La différence entre ê')]")]
        public IWebElement TakingControlMood1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cet article vous renseignera sur : Les symptômes d')]")]
        public IWebElement TakingControlMood2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cet article vous apprendra : Comprendre comment le')]")]
        public IWebElement TakingControlMood3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cet article vous apprendra : Les principales sourc')]")]
        public IWebElement TakingControlMood4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Prenez le contrôle de votre humeur : soyez actif']")]
        public IWebElement TakingControlMood5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quand un proche est gravement malade']")]
        public IWebElement Impactoftech { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Résilience (Exercice)']")]
        public IWebElement Uncoveringthefaces { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'La dynamique familiale, soit les relations entre m')]")]
        public IWebElement Whensomeoneclose { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Le deuil est une réaction naturelle potentiellemen')]")]
        public IWebElement Whensomeoneclose1 { get; set; }

        //StudentLife FR

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Vie étudiante']")]
        public IWebElement StudentLife { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Étiez-vous craintif* dans le noir quand vous étiez')]")]
        public IWebElement Adaptingtochange { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/vie-etudiante'][text()='Vie étudiante']")]
        public IWebElement Studentlifetag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Une saine dose de confiance en soi donne la résil')]")]
        public IWebElement Breakthose { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Pour cesser de fumer, il faut plus que de la volon')]")]
        public IWebElement Dealingwithread { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Vous cherchez une résidence pour vos parents âgés?')]")]
        public IWebElement Dealingwithvideo { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Nous n')]")]
        public IWebElement EatingHealthier { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Imaginez que votre corps est un enfant à qui vous ')]")]
        public IWebElement GetControl { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Il arrive à la plupart des gens de manquer de con')]")]
        public IWebElement HowcanIcope { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Après la perte de notre emploi ou après un changem')]")]
        public IWebElement Howtoavoid { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Il est facile de se faire du souci au sujet de ses')]")]
        public IWebElement Howtoimprove { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'La relation que nous entretenons avec la nourritur')]")]
        public IWebElement Howtoincrease { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Comment entrevois-tu l’avenir? Comment gérer mes s')]")]
        public IWebElement Howtomaintain { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​La plupart des gens ne raffolent pas du changemen')]")]
        public IWebElement Humourtherapy { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Comment qualifieriez-vous votre état psychologique')]")]
        public IWebElement Lifesmart { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Gérer la dépression saisonnière'])[1]")]
        public IWebElement MaintainingGood { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Gérer la dépression saisonnière'])[2]")]
        public IWebElement Movingbeyond { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La thérapie par l’humour et le pouvoir du rire']")]
        public IWebElement Raisingself { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les risques des médias sociaux pour votre santé mentale']")]
        public IWebElement Spottingsigns { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Nous avons tous de mauvaises et de bonnes habitude')]")]
        public IWebElement Stopsmoking { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Prendre les moyens de gérer votre stress est proba')]")]
        public IWebElement Survivingsept { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'L’un des principaux défis à relever lorsque l’on v')]")]
        public IWebElement Takingchargeofstress { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Sais-tu comment repérer les signes précurseurs du ')]")]
        public IWebElement Dansgersofsocial { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Survivre à un Septembre']")]
        public IWebElement Whenhabits { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Dépendance']")]
        public IWebElement Addiction { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/vie-etudiante/dependance'][text()='Dépendance']")]
        public IWebElement Addictiontag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Pour cesser de fumer, il faut plus que de la volon')]")]
        public IWebElement UnderstandingEating { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cet article explique ce que sont les troubles alim')]")]
        public IWebElement UnderstandingEatingvideo { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Écoutez les mythes, les causes profondes et commen')]")]
        public IWebElement UnderstandingEatingread { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Brisez les préjugés autour des troubles alimentair')]")]
        public IWebElement Stopsmokingaddiction { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Finances']")]
        public IWebElement Srudentlifefinance { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Il est facile de se faire du souci au sujet de ses')]")]
        public IWebElement Getcontrolofmoney { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/vie-etudiante/finances'][text()='Finances']")]
        public IWebElement Financetag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Santé Mentale']")]
        public IWebElement Mentalhealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Une saine dose de confiance en soi donne la résil')]")]
        public IWebElement AmIExperiencing { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/vie-etudiante/sante-mentale'][text()='Santé Mentale']")]
        public IWebElement Mentalhealthtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Il arrive à la plupart des gens de manquer de con')]")]
        public IWebElement Backtoschool { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Bien qu’il soit normal de se sentir triste ou cont')]")]
        public IWebElement Covid19 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Après la perte de notre emploi ou après un changem')]")]
        public IWebElement Dealingwithseasonal { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Comment qualifieriez-vous votre état psychologique')]")]
        public IWebElement Howtoavoidoverreacting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cet article explique ce que sont les troubles alim')]")]
        public IWebElement Howtoincreaseyour { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ce webinaire porte sur les effets psychologiques d')]")]
        public IWebElement Maintaininggood { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Le trouble affectif saisonnier (TAS), souvent app')]")]
        public IWebElement Raisingyourself { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'À mesure que la fin de l’été approche, les enfants')]")]
        public IWebElement Spottingsignsof { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'À quand remonte votre dernier clic « J’aime » dans')]")]
        public IWebElement Thedangersof { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Sais-tu comment repérer les signes précurseurs du ')]")]
        public IWebElement Understandingeating { get; set; }

        //Tools FR
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Outils']")]
        public IWebElement Tools { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Vous cherchez une résidence pour vos parents âgés?')]")]
        public IWebElement Toolsbacktoschool { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/outils'][text()='Outils']")]
        public IWebElement ToolsTag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Counseling en ligne']")]
        public IWebElement Toolsecounselling { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Counseling par vidéoconférence']")]
        public IWebElement Toolsecourses { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cours en ligne']")]
        public IWebElement Toolsmemberorientation { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Introduction à la thérapie cognitive-comportementale (TCC)']")]
        public IWebElement ToolsIntrotoCBT { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La rentrée peut être synonyme de changements importants']")]
        public IWebElement ToolsLS { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'La présente séance d’orientation a pour but de vou')]")]
        public IWebElement ToolsVideo { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Counseling']")]
        public IWebElement Counselling { get; set; }
        [FindsBy(How = How.XPath, Using = "//section[@class='article-featured']//p[contains(text(),'La clientèle peut communiquer avec un·e thérapeute')]")]
        public IWebElement ECounselling { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/outils/counseling'][text()='Counseling']")]
        public IWebElement Counsellingtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='content']//p[contains(text(),'La clientèle peut communiquer avec un·e thérapeute')]")]
        public IWebElement IntroCBT { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Il est important de comprendre les types de thérap')]")]
        public IWebElement IntroCBTpod { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Il est assez facile pour la plupart des gens de tr')]")]
        public IWebElement videocounselling { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Cours en ligne']")]
        public IWebElement ecourses { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Pour cesser de fumer, il faut plus que de la volon')]")]
        public IWebElement ecourses1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/outils/cours-en-ligne'][text()='Cours en ligne']")]
        public IWebElement ecoursestag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer la perte de son emploi']")]
        public IWebElement embracingworkplace { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser sa colère']")]
        public IWebElement foundationsofeffective { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser son humeur']")]
        public IWebElement leadership1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser son stress']")]
        public IWebElement leadership2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment prendre sa carrière en main']")]
        public IWebElement leadership3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ce cours offre des stratégies personnelles visant ')]")]
        public IWebElement leadership4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment vous préparer à la retraite']")]
        public IWebElement leadership5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cours en ligne']")]
        public IWebElement preparingforretirement { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Penser de façon optimiste, plutôt que de façon nég')]")]
        public IWebElement resilience { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ce cours comprend des segments vidéo dans lesquels')]")]
        public IWebElement resolvingconflict { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[11]")]
        public IWebElement respectinworkplace { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le respect en milieu de travail']")]
        public IWebElement responsibleoptimism { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les fondements de la compétence parentale']")]
        public IWebElement stopsmokingtools { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Il s')]")]
        public IWebElement takingcontrolofanger { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Module 1 de la formation sur les stratégies de lea')]")]
        public IWebElement takingcontrolofjobloss { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Module 2 de la formation sur les stratégies de lea')]")]
        public IWebElement takingcontrolofstress { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Module 3 de la formation sur les stratégies de lea')]")]
        public IWebElement takingcontrolofcareer { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Module 4 de la formation sur les stratégies de lea')]")]
        public IWebElement takingcontrolofmood { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='tcc']")]
        public IWebElement iCBT { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Sentio aide à améliorer votre santé mentale et à r')]")]
        public IWebElement Sentio { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/outils/tcc'][text()='tcc']")]
        public IWebElement iCBTtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Orientation']")]
        public IWebElement Orientation { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'La présente séance d’orientation a pour but de vou')]")]
        public IWebElement employeeorientation { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/outils/orientation'][text()='Orientation']")]
        public IWebElement Orientationtag { get; set; }

        // Webinars
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Webinaires']")]
        public IWebElement webinars { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ce webinaire porte sur les effets psychologiques d')]")]
        public IWebElement Covid19support { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/webinaires'][text()='Webinaires']")]
        public IWebElement webinartag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ce webinaire porte sur l’effet de la langueur sur ')]")]
        public IWebElement Covid19whatis { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Introduction à la thérapie cognitive-comportementale (TCC)']")]
        public IWebElement Mentalhealthcovid { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé mentale des professionnels de la santé en période de pandémie']")]
        public IWebElement practicingmindfulness { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pratiquer la pleine conscience et la gratitude pendant les vacances']")]
        public IWebElement Webinardealingwith { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire : L’Effet des médias sociaux sur la santé mentale']")]
        public IWebElement Webinarthesecondwave { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Animée par Sandra Primiano, Ph.D., psychologue che')]")]
        public IWebElement Webinarcovid19mental { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire : COVID-19 – Stratégies d’autosoins pour contrer l’usure, l’isolement et la solitude']")]
        public IWebElement Webinarcovid19loneliness { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'L’empathie est un élément clé de l’intelligence ém')]")]
        public IWebElement Webinarcovid19transition { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Animé par: Gabrielle Provencher M.Sc., R.S.W., R.M')]")]
        public IWebElement Webinardevelopeing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cette conférence porte sur l’importance de créer u')]")]
        public IWebElement Webinarinclusion { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Animé par Jocelyn Labbé, ce webinaire d’une durée ')]")]
        public IWebElement WebinarCBT { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cette conférence fournit aux participant·e·s une i')]")]
        public IWebElement Webinarreducinganxiety { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Dans une optique axée sur les solutions, différent')]")]
        public IWebElement Webinarsocialmedia { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Animé par: Jacques Coderre Lareau B. Sc. Psy., D.E')]")]
        public IWebElement Webinarwomensmental { get; set; }

        //Wellness Sessions
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Cours de mieux-etre']")]
        public IWebElement Wellnesssessions { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'La réussite des groupes de travail repose sur les ')]")]
        public IWebElement Wellnesssessionbeyondstigma { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/cours-de-mieuxetre'][text()='Cours de mieux-etre']")]
        public IWebElement Wellnesssessionstag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Lorsque nous sommes submergés par le stress, des t')]")]
        public IWebElement Wellresilience { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Développer sa résilience']")]
        public IWebElement Wellbuilding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Éléments fondamentaux du changement et de la transition']")]
        public IWebElement Wellimproving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='En route vers le mieux-être, une étape à la fois']")]
        public IWebElement Wellmanaging { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Établir des relations de travail']")]
        public IWebElement Wellstress { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gestion de votre temps et de votre énergie']")]
        public IWebElement Wellartof { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’art de la détente']")]
        public IWebElement Wellfundamentals { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La science du bonheur']")]
        public IWebElement Welljourney { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mettre fin à la stigmatisation']")]
        public IWebElement Wellscience { get; set; }

        //Mental Health
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Santé mentale']")]
        public IWebElement Mental { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Étiez-vous craintif* dans le noir quand vous étiez')]")]
        public IWebElement Mentalhealth10steps { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/sante-mentale'][text()='Santé mentale']")]
        public IWebElement Mentaltag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Une saine dose de confiance en soi donne la résil')]")]
        public IWebElement MentalExperincingDep { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Aperçu des liens entre stress, diabète, alimentati')]")]
        public IWebElement Mentalchildrenandyouth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Lorsque vous songez à votre vie et aux semaines, a')]")]
        public IWebElement Mentalchildrenandyouth1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[4]")]
        public IWebElement Mentalchildrenandyouth2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[5]")]
        public IWebElement Mentalcyberbully { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Nos expériences de vie façonnent qui nous sommes, ')]")]
        public IWebElement Mentalcyberbully1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Collaboration adaptée aux traumatismes'])[2]")]
        public IWebElement Mentalcyberbully2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment augmenter votre confiance en vous']")]
        public IWebElement Mentalcopingwith { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment éviter de réagir de façon excessive']")]
        public IWebElement Mentalcopingwith1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser sa colère']")]
        public IWebElement Mentalcopingwithdep { get; set; }
     
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser son humeur']")]
        public IWebElement Mentalcovid19 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment parler à ses enfants de santé mentale et de toxicomanie']")]
        public IWebElement Mentalcovid191 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment se maintenir en bonne santé psychologique']")]
        public IWebElement Mentalcreatingafuture { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='​Comprendre la maladie mentale concomitante à une maladie physique chronique'])[1]")]
        public IWebElement Mentaldatingwhile { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='​Comprendre la maladie mentale concomitante à une maladie physique chronique'])[2]")]
        public IWebElement Mentaldealingwith { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='​Comprendre la maladie mentale concomitante à une maladie physique chronique'])[3]")]
        public IWebElement Mentaldevelopingresiliency { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre la santé mentale et la maladie mentale']")]
        public IWebElement Mentalembracingdifferent { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre les troubles alimentaires : une approche compatissante pour accroître la sensibilisation et offrir du soutien']")]
        public IWebElement Mentalembracingdifferent1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[20]")]
        public IWebElement Mentalembracingdifferent2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[21]")]
        public IWebElement Mentalforest { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Comprendre, faire face et aider'])[1]")]
        public IWebElement Mentalgrief { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Comprendre, faire face et aider'])[2]")]
        public IWebElement Mentalgriefworkplace { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19 : protéger la santé mentale des enfants']")]
        public IWebElement Mentalmaid { get; set; }

        //MentalHealth1
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19 : Qu’est-ce que la langueur et pourquoi faut-il s’en soucier?']")]
        public IWebElement Mentalhealingwounds { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Dépression saisonnière et pensées toxiques'])[1]")]
        public IWebElement Mentalhealingwounds1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Dépression saisonnière et pensées toxiques'])[2]")]
        public IWebElement MentalHealthy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dix conseils à suivre pour atteindre l’équilibre travail-vie personnelle']")]
        public IWebElement MentalHoliday { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dysfonction sexuelle et sexomanie']")]
        public IWebElement MentalHowtakingcare { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Entamer une conversation sur la santé mentale']")]
        public IWebElement Mentalhowto { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Est-ce que je souffre de dépression?']")]
        public IWebElement Mentalhowincrease { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face à la dépression']")]
        public IWebElement Mentalindigineouspeople { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face aux traumatismes de l’enfance']")]
        public IWebElement Mentalindigineouspeople1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face aux traumatismes de l’enfance qui résultent de violence et de négligence vécues dans le passé']")]
        public IWebElement Mentalindigineouspeople2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gérer la dépression saisonnière']")]
        public IWebElement Mentalinfertility { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Guérir les blessures invisibles'])[1]")]
        public IWebElement Mentalinterconnections { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Guérir les blessures invisibles'])[2]")]
        public IWebElement Mentalintimate { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Intégration de mentalités différentes : comment la neurodiversité renforce les milieux de travail']")]
        public IWebElement MentalCBT { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Intégration de mentalités différentes (Audio)']")]
        public IWebElement MentalCBT1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Intégration de mentalités différentes (Vidéo)']")]
        public IWebElement MentalLetstalk { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Introduction à la thérapie cognitive-comportementale (TCC)'])[1]")]
        public IWebElement MentalMaintaining { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Introduction à la thérapie cognitive-comportementale (TCC)'])[2]")]
        public IWebElement Mentalhealthcheckup { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Dans cette vidéo, nous allons aborder certains des')]")]
        public IWebElement Mentalmodernworkplace1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Dans cet article, nous allons aborder certains des')]")]
        public IWebElement Mentalmodernworkplace2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Penser de façon optimiste, plutôt que de façon nég')]")]
        public IWebElement Mentalmoralinjury { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='L’agression et le harcèlement sexuels'])[1]")]
        public IWebElement Mentalmoving { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='L’agression et le harcèlement sexuels'])[2]")]
        public IWebElement Mentalmywellness { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’infertilité et votre santé mentale']")]
        public IWebElement Mentalmywellness1 { get; set; }

        //MentalHealth2
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’infertilité secondaire et votre santé mentale']")]
        public IWebElement Mentalnavigating { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='L’intersection entre l’identité sexuelle et la santé mentale'])[1]")]
        public IWebElement Mentalnavigatingsupport { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='L’intersection entre l’identité sexuelle et la santé mentale'])[2]")]
        public IWebElement Mentalnavigatingpanic { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La dépression post-partum']")]
        public IWebElement Mentalnavigatingpanic1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La Santé Mentale Des Enfants et Des Adolescents']")]
        public IWebElement Mentalovercoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Dans ce podcast, nous abordons un éventail de fact')]")]
        public IWebElement Mentalovercomingwinter { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Nul n’ignore les hauts, les bas, les bizarreries e')]")]
        public IWebElement Mentalpostpartem { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Dans cette vidéo, nous abordons un éventail de fac')]")]
        public IWebElement Mentalraising { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La sante mentale des femmes']")]
        public IWebElement Mentalreducingmental { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé mentale des femmes']")]
        public IWebElement Mentalresponsibleoptimism { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La santé mentale des femmes : préoccupations, obstacles et soutien'])[1]")]
        public IWebElement Mentalsecondary { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La santé mentale des femmes : préoccupations, obstacles et soutien'])[2]")]
        public IWebElement Mentalsexualabuse { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La santé mentale des jeunes : technologie et cyberintimidation'])[1]")]
        public IWebElement Mentalsexualabuse1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La santé mentale des jeunes : technologie et cyberintimidation'])[2]")]
        public IWebElement Mentalsexualysfunction { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La santé mentale des jeunes : technologie et cyberintimidation'])[3]")]
        public IWebElement Mentalspotting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La sylvothérapie']")]
        public IWebElement Mentalstaying { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La Violence Conjugale']")]
        public IWebElement Mentalstigma { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le deuil en milieu de travail']")]
        public IWebElement Mentalstress { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le deuil et l’aide médicale à mourir']")]
        public IWebElement Mentalstressfinding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le préjudice moral : comment se sentir mieux']")]
        public IWebElement Mentalstressfinding2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le santé mentale des femmes']")]
        public IWebElement Mentalstressfinding3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[70]//div[1]//div[1]//div[1]//div[1]//span[1]")]
        public IWebElement Mentalsuicideprevention { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[71]//div[1]//div[1]//div[1]//div[1]//span[1]")]
        public IWebElement Mentalsupportingillness { get; set; }

        //MentalHealth3
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les nombreuses facettes de l’anxiété']")]
        public IWebElement Mentalsupportingholidays { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les nombreux visages du TSPT']")]
        public IWebElement Mentalsurviving { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les peuples autochtones et les traumatismes'])[1]")]
        public IWebElement Mentaltakingchargestress { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les peuples autochtones et les traumatismes'])[2]")]
        public IWebElement Mentaltakingcontrolanger { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les peuples autochtones et les traumatismes'])[3]")]
        public IWebElement Mentaltakingcontrolmood { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les rapports humains pour lutter contre la solitude et l’isolement pendant les Fêtes']")]
        public IWebElement Mentaltalkingtokids { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les relations de couple pendant le rétablissement']")]
        public IWebElement Mentaldangerssocial { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les risques d’aujourd’hui en milieu de travail'])[1]")]
        public IWebElement Mentalimpactof { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les risques d’aujourd’hui en milieu de travail'])[2]")]
        public IWebElement Mentalimpactof1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les risques des médias sociaux pour votre santé mentale']")]
        public IWebElement Mentalintersectio1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Lorsque les prochaines fêtes sont loin :']")]
        public IWebElement Mentalintersectio2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maîtrisez votre stress']")]
        public IWebElement Mentalmanyfaces { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mesures pour recouvrer la santé mentale']")]
        public IWebElement Mentalptsd { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mettez de l’ordre dans vos finances et réduisez votre niveau de stress']")]
        public IWebElement Mentalweightofwinter { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mieux comprendre les enjeux de santé mentale chez les hommes et offrir du soutien']")]
        public IWebElement Mentalweightofwinter1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Mon mieux-être'])[1]")]
        public IWebElement Mentaltoomuchscreen { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Mon mieux-être'])[2]")]
        public IWebElement Mentaltoomuchscreen1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pour en finir avec les mythes sur la maladie mentale!']")]
        public IWebElement Mentaltrauma { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Vous anticipez les Fêtes de fin d’année avec appré')]")]
        public IWebElement Mentaltrauma1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'En ces temps sans précédent, la santé mentale et l')]")]
        public IWebElement Mentalunderstandingdepression { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Qu’est-ce que la pleine conscience? Quels en sont ')]")]
        public IWebElement Mentalunderstandingeating { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Quand on craint l’inconnu : faire face à l’incertitude'])[1]")]
        public IWebElement Mentalunderstandingeating1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Quand on craint l’inconnu : faire face à l’incertitude'])[2]")]
        public IWebElement Mentalunderstandingeating2 { get; set; }

        //MentalHealth4
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quand un être cher est atteint de la maladie d’alzheimer ou de démence']")]
        public IWebElement Mentalunderstandingmental { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Réduire la stigmatisation entourant les problèmes de santé mentale']")]
        public IWebElement Mentalunderstandingchronic1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Résilience']")]
        public IWebElement Mentalunderstandingchronic2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Service IntelliVie']")]
        public IWebElement Mentalunderstandingchronic3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Signes précurseurs du suicide']")]
        public IWebElement Mentalwebinar1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir un ex-toxicomane* pendant les fêtes']")]
        public IWebElement Mentalwebinar2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[101]")]
        public IWebElement Mentalwebinar3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[text()=' Le lien entre dépendance et stigmatisation est sans aucun doute compliqué. ']")]
        public IWebElement Mentalwebinar4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stress']")]
        public IWebElement Mentalwebinar5 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Stress – Viser l’équilibre'])[1]")]
        public IWebElement Mentalwhatis { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Stress – Viser l’équilibre'])[2]")]
        public IWebElement Mentalwhensomeone { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Stress – Viser l’équilibre'])[3]")]
        public IWebElement Mentalwhennextceleb { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Surmonter la déprime de l’hiver']")]
        public IWebElement Mentalwhenyoufear { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Surmonter ses phobies']")]
        public IWebElement Mentalwhenyoufear1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Survivre à un Septembre']")]
        public IWebElement Mentalwomenhealth1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Trop de temps d’écran : effets sur la santé mentale et façons d’y remédier']")]
        public IWebElement Mentalwomenhealth2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Trop de temps d’écran?']")]
        public IWebElement Mentalwomenhealth3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vivre au quotidien le recouvrement de sa santé mentale']")]
        public IWebElement Mentalwomenhealth4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire : L’Effet des médias sociaux sur la santé mentale']")]
        public IWebElement Mentalwomenhealth5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'L’empathie est un élément clé de l’intelligence ém')]")]
        public IWebElement Mentalwomenhealth6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cette conférence fournit aux participant·e·s une i')]")]
        public IWebElement Mentalwomenhealth7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Dans une optique axée sur les solutions, différent')]")]
        public IWebElement Mentalyouthteen { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Animé par: Jacques Coderre Lareau B. Sc. Psy., D.E')]")]
        public IWebElement Mentalyouthteen1 { get; set; }

        //Crisis
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Crise']")]
        public IWebElement Crisis { get; set; }
        [FindsBy(How = How.XPath, Using = "//section[@class='article-featured']//p[contains(text(),'L')]")]
        public IWebElement Crisischildhood { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/crise'][text()='Crise']")]
        public IWebElement Crisistag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Après la perte de notre emploi ou après un changem')]")]
        public IWebElement Crisiscopingtraumatic { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer la perte de son emploi']")]
        public IWebElement Crisiscopingloss { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer le deuil']")]
        public IWebElement Crisiscopingcoworker { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Être victime d’un acte de violence']")]
        public IWebElement Crisisukraine { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face à un évènement traumatisant']")]
        public IWebElement Crisisemployeefatigue { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Chaque personne a sa façon particulière de faire f')]")]
        public IWebElement Crisisexperiencingviolence { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Bien que le deuil soit un processus naturel ressen')]")]
        public IWebElement Crisisexperiencingdisruptive { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='L’agression et le harcèlement sexuels'])[1]")]
        public IWebElement Crisisgrief { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='L’agression et le harcèlement sexuels'])[2]")]
        public IWebElement Crisismaid { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[10]")]
        public IWebElement Crisislossofchild { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La guerre en Ukraine']")]
        public IWebElement Crisishelpingchildren { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le deuil et l’aide médicale à mourir']")]
        public IWebElement Crisishowtodeal { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[13]")]
        public IWebElement Crisisnovascotia { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les nombreux visages du TSPT']")]
        public IWebElement Crisispractical { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Nouvelle-Écosse - Être victime d’un acte de violence ou de terrorisme']")]
        public IWebElement Crisisabuse1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[16]")]
        public IWebElement Crisisabuse2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Que faire quand un collègue présente des tendances suicidaires']")]
        public IWebElement Crisissuicide { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Service IntelliVie']")]
        public IWebElement Crisissupporting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les premiers intervenants*']")]
        public IWebElement Crisistakingcontrol { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Usure, isolement et solitude des employés*']")]
        public IWebElement Crisisptsd { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Violence sexuelle pendant l’enfance']")]
        public IWebElement Crisiswhattodo { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vivre un évènement perturbateur']")]
        public IWebElement Crisiswhattodo1 { get; set; }

        //Crisiscovid19
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/crise/covid19'][text()='COVID19']")]
        public IWebElement Crisiscovid { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='10 idées reçues sur le vaccin contre la COVID-19']")]
        public IWebElement Crisiscovid10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/crise/covid19'][text()='COVID19']")]
        public IWebElement Crisiscovidtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Bibliothèque santé et mieux-être']")]
        public IWebElement Crisiscovidbeing { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[2]")]
        public IWebElement Crisiscovidcelebrating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Célébrer les Fêtes de façon sécuritaire']")]
        public IWebElement Crisiscovid19masks { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Chassez vos soucis financiers et commencez à épargner'])[1]")]
        public IWebElement Crisiscovid19assessment { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Chassez vos soucis financiers et commencez à épargner'])[2]")]
        public IWebElement Crisiscovid19symtoms { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser son humeur']")]
        public IWebElement Crisiscovid19mental { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser son stress']")]
        public IWebElement Crisiscovid19languishing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19 : Évaluation du risque']")]
        public IWebElement Crisiscovid19sick { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19 : protéger la santé mentale des enfants']")]
        public IWebElement Crisiscovid19fatigue { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19 : Qu’est-ce que la langueur et pourquoi faut-il s’en soucier?']")]
        public IWebElement Crisiscovid19sanitizer1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19 : que faire si vous tombez malade?']")]
        public IWebElement Crisiscovid19sanitizer2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Apprenez-en plus sur la COVID-19, ses symptômes, c')]")]
        public IWebElement Crisiscovid19healthy { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Des relations saines'])[1]")]
        public IWebElement Crisiscovid19healthy1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Des relations saines'])[2]")]
        public IWebElement Crisiscovid19healthy2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Des relations saines'])[3]")]
        public IWebElement Crisiscovid19holidaystress { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Désinfectant pour les mains : un guide']")]
        public IWebElement Crisiscovid19intimate { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La COVID-19 et les masques faciaux : ce que l’on doit savoir']")]
        public IWebElement Crisiscovid19intimate1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La résilience']")]
        public IWebElement Crisiscovid19intimate2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé mentale des professionnels de la santé en période de pandémie']")]
        public IWebElement Crisiscovid19living { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La Violence Conjugale'])[1]")]
        public IWebElement Crisiscovid19living1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La Violence Conjugale'])[2]")]
        public IWebElement Crisiscovid19living2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La Violence Conjugale'])[3]")]
        public IWebElement Crisiscovid19maintaining { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Lavage des mains : un guide']")]
        public IWebElement Crisiscovid19mentalduring { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les rapports humains pour lutter contre la solitude et l’isolement pendant les Fêtes']")]
        public IWebElement Crisiscovid19overcoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Lorsque les prochaines fêtes sont loin :']")]
        public IWebElement Crisiscovid19overcoming1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maîtrisez votre stress avant qu’il ne soit trop tard!']")]
        public IWebElement Crisiscovid19preparing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Prendre soin de sa santé mentale pendant la pandémie de COVID-19']")]
        public IWebElement Crisiscovid19preparing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Préparer votre entreprise à l’après-pandémie'])[1]")]
        public IWebElement Crisiscovid19preparing2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Préparer votre entreprise à l’après-pandémie'])[2]")]
        public IWebElement Crisiscovid19preparing3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Préparer votre entreprise à l’après-pandémie'])[3]")]
        public IWebElement Crisiscovid19resilience { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Vous anticipez les Fêtes de fin d’année avec appré')]")]
        public IWebElement Crisiscovid19stayingactive { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quand un proche est gravement malade']")]
        public IWebElement Crisiscovid19stayingconnected { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Rester actif pendant la pandémie de COVID-19']")]
        public IWebElement Crisiscovid19supporting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Se rétablir et rester en sécurité tout en respectant la distanciation sociale']")]
        public IWebElement Crisiscovid19surviving1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sentio par Homewood Santé']")]
        public IWebElement Crisiscovid19surviving2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les travailleurs de première ligne durant la pandémie de COVID-19']")]
        public IWebElement Crisiscovid19surviving3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Survivre à un Septembre'])[1]")]
        public IWebElement Crisiscovid19taking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Survivre à un Septembre'])[2]")]
        public IWebElement Crisiscovid19taking2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Survivre à un Septembre'])[3]")]
        public IWebElement Crisiscovid19taking3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Une Vie Épanouie'])[1]")]
        public IWebElement Crisiscovid19webinar1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Une Vie Épanouie'])[2]")]
        public IWebElement Crisiscovid19webinar2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Une Vie Épanouie'])[3]")]
        public IWebElement Crisiscovid19webinar3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Usure, isolement et solitude des employés*']")]
        public IWebElement Crisiscovid19webinar4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Vous ou votre enfant ressentez peut-&ecirc;tre de ')]")]
        public IWebElement Crisiscovid19webinar5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Animée par Sandra Primiano, Ph.D., psychologue che')]")]
        public IWebElement Crisiscovid19webinar6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire : COVID-19 – Stratégies d’autosoins pour contrer l’usure, l’isolement et la solitude']")]
        public IWebElement Crisiscovid19webinar7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire : Gérer le trouble affectif saisonnier en temps de pandémie']")]
        public IWebElement Crisiscovid19whensomeone { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire : Réduire l’anxiété et gérer la rentrée en temps de pandémie']")]
        public IWebElement Crisiscovid19whennext { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire à l’intention des enseignants* des niveaux postsecondaires']")]
        public IWebElement Crisiscovid19youandyour { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire: COVID-19 : Transition et changement']")]
        public IWebElement Crisiscovid19youandyour1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire: La deuxième vague et votre santé mentale']")]
        public IWebElement Crisiscovid19youandyour2 { get; set; }


        //CririsMentalHealth

        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/crise/sante-mentale'][text()='Santé mentale']")]
        public IWebElement Crisismental { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Comment gérer la perte de son emploi']")]
        public IWebElement Crisismentaldepression { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/crise/sante-mentale'][text()='Santé mentale']")]
        public IWebElement Crisismentaltag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer le deuil']")]
        public IWebElement Crisismentalcoping1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Écoutez les mythes, les causes profondes et commen')]")]
        public IWebElement Crisismentalcoping2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Brisez les préjugés autour des troubles alimentair')]")]
        public IWebElement Crisismentalcoping3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Bien qu’il soit normal de se sentir triste ou cont')]")]
        public IWebElement Crisismentalemployee { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Le traumatisme causé par un acte de violence peut ')]")]
        public IWebElement Crisismentalexperience1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'En présence d’un désastre, chacun d')]")]
        public IWebElement Crisismentalexperience2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Chaque personne a sa façon particulière de faire f')]")]
        public IWebElement Crisismentalintimate1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'N’importe qui peut être victime d’agression sexuel')]")]
        public IWebElement Crisismentalintimate2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[9]")]
        public IWebElement Crisismentalhealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé mentale des professionnels de la santé en période de pandémie']")]
        public IWebElement Crisismentalnova { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La Violence Conjugale'])[1]")]
        public IWebElement Crisismentalabuse { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La Violence Conjugale'])[2]")]
        public IWebElement Crisismentalsomeone { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les nombreux visages du TSPT']")]
        public IWebElement Crisismentalspotting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Nouvelle-Écosse - Être victime d’un acte de violence ou de terrorisme']")]
        public IWebElement Crisismentalsuicide { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'En ces temps sans précédent, la santé mentale et l')]")]
        public IWebElement Crisismentalsupporting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Sais-tu comment repérer les signes précurseurs du ')]")]
        public IWebElement Crisismentalsupporting1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Être témoin d’un évènement traumatisant ou en vivr')]")]
        public IWebElement Crisismentaltaking { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Quels que soient son âge, son milieu culturel ou s')]")]
        public IWebElement Crisismentalmanyfaces { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Au fil des mois, la pandémie mondiale de COVID-19 ')]")]
        public IWebElement CrisismentalUnderstanding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'En réponse à la récente agitation sociale qui a li')]")]
        public IWebElement CrisismentalUnderstanding2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Animée par Sandra Primiano, Ph.D., psychologue che')]")]
        public IWebElement Crisismentalwebinar1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire : COVID-19 – Stratégies d’autosoins pour contrer l’usure, l’isolement et la solitude']")]
        public IWebElement Crisismentalwebinar2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire : Gérer le trouble affectif saisonnier en temps de pandémie']")]
        public IWebElement Crisismentalwebinar3 { get; set; }

        //CrisisParenting

        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/crise/role-parental'][text()='Rôle parental']")]
        public IWebElement Crisisparenting { get; set; }
        [FindsBy(How = How.XPath, Using = "//section[@class='article-featured']//p[contains(text(),'L')]")]
        public IWebElement Crisisparentinggrieving { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/crise/role-parental'][text()='Rôle parental']")]
        public IWebElement Crisisparentingtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='C’est quoi le consentement?']")]
        public IWebElement Crisisparentinghelping { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Bien que le deuil soit un processus naturel ressen')]")]
        public IWebElement Crisisparentingunderstanding { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'On ne vous apprendra rien en vous disant qu’il n’y')]")]
        public IWebElement Crisisparentingconsent { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Le localisateur de services aux enfants peut vous ')]")]
        public IWebElement Crisisparentingconsent1 { get; set; }

        //Family
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Famille']")]
        public IWebElement Family { get; set; }
        [FindsBy(How = How.XPath, Using = "//section[@class='article-featured']//p[contains(text(),'L')]")]
        public IWebElement Familyresource { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/famille'][text()='Famille']")]
        public IWebElement Familytag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Améliorez vos relations familiales']")]
        public IWebElement Familystress { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Avoir une relation de couple saine tout en préservant son individualité']")]
        public IWebElement Familybabies { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Célébrer les Fêtes de façon sécuritaire']")]
        public IWebElement Familybackto { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Célébrons la fête des Mères']")]
        public IWebElement Familybecoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Choisir le bon camp d’été']")]
        public IWebElement Familybuilding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Comment aider votre enfant a cesser de mouiller son lit']")]
        public IWebElement Familycelebrating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment composer avec la transition de votre enfant de la pré-adolescence à l’adolescence']")]
        public IWebElement Familycelebrating1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer son argent']")]
        public IWebElement Familycelebrating2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Comment offrir du soutien aux enfants qui s’identifient comme LGBTQ2+']")]
        public IWebElement Familychildcare { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment parler à ses enfants de santé mentale et de toxicomanie']")]
        public IWebElement Familychildcare1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment parler à vos enfants de votre séparation ou divorce']")]
        public IWebElement Familychildren1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment planifier votre nouvelle vie et votre retour au travail suivant l’arrivée de votre bébé']")]
        public IWebElement Familychildren2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment vous préparer à la retraite']")]
        public IWebElement Familychildren3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19 : protéger la santé mentale des enfants']")]
        public IWebElement Familychoosing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Créer des moments précieux']")]
        public IWebElement Familycombining { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Des relations saines']")]
        public IWebElement Familycovid19 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Devenir parent']")]
        public IWebElement Familycreate { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Droit Familial']")]
        public IWebElement Familyeffective { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Entamer une conversation sur la santé mentale']")]
        public IWebElement Familyeldercare { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[20]")]
        public IWebElement Familyemployees { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Familles reconstituées']")]
        public IWebElement Familyfamilylaw { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Favoriser l’attachement']")]
        public IWebElement Familyfinancial1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Guide à l’intention des personnes transgenres et de genres divers']")]
        public IWebElement Familyfinancial2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Hommage aux pères']")]
        public IWebElement Familyfoundations { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’adolescent* d’aujourd’hui']")]
        public IWebElement Familyfoundations1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’art d’être grands-parents']")]
        public IWebElement Familyfromkids { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’autogestion de la santé pour la génération sandwich']")]
        public IWebElement Familygrand { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’enfant exubérant']")]
        public IWebElement Familyhealthy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’infertilité et votre santé mentale']")]
        public IWebElement Familyhelping { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[30]")]
        public IWebElement Familyhousing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La dépression post-partum']")]
        public IWebElement Familyhowto { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La discipline efficace']")]
        public IWebElement Familyhowto1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La dynamique familiale'])[1]")]
        public IWebElement Familyhowto2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La dynamique familiale'])[2]")]
        public IWebElement Familyhowto3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La monoparentalité']")]
        public IWebElement Familyimproving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La prestation de soins à distance']")]
        public IWebElement Familyinfertility { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La puissance d’une approche parentale positive']")]
        public IWebElement Familyisittime { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La rentrée scolaire']")]
        public IWebElement Familylongdistance { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[39]")]
        public IWebElement Familynewparent { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé financière']")]
        public IWebElement Familypostpartem { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La Santé Mentale Des Enfants et Des Adolescents']")]
        public IWebElement Familypostpreparinglife { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La Santé Mentale Des Enfants et Des Adolescents*']")]
        public IWebElement Familypreparing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé mentale des enfants et des adolescents*']")]
        public IWebElement Familyrelationship { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​La santé mentale des enfants et des adolescents*']")]
        public IWebElement Familyresolving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La séparation et le divorce']")]
        public IWebElement Familysecure { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La technologie et les relations interpersonnelles']")]
        public IWebElement Familyselfcare { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le grand débat sur l’allocation']")]
        public IWebElement Familyseparation { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le localisateur de services aux enfants']")]
        public IWebElement Familysetting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le moment de repenser vos finances?']")]
        public IWebElement Familysingle { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[50]")]
        public IWebElement Familysomeone { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le vapotage : la nouvelle dépendance des adolescents*']")]
        public IWebElement Familyspirited { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les bébés et le sommeil']")]
        public IWebElement Familystaying { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les employés aidants naturels']")]
        public IWebElement Familytaking { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[54]")]
        public IWebElement Familytalking { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les fondements de la compétence parentale'])[1]")]
        public IWebElement Familytalking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les fondements de la compétence parentale'])[2]")]
        public IWebElement Familytech { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les parents au travail']")]
        public IWebElement Familytech1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les rapports humains pour lutter contre la solitude et l’isolement pendant les Fêtes']")]
        public IWebElement Familytantrums { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les technologies et le temps passé devant un écran']")]
        public IWebElement Familygreatallowance { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Localisateur de services aux aînés']")]
        public IWebElement Familyimpact { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Lorsque les prochaines fêtes sont loin :']")]
        public IWebElement Familypositive { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Options d’hébergement pour les aînés']")]
        public IWebElement Familyparent { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[63]")]
        public IWebElement Familyteenagers { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Questions financières ou juridiques']")]
        public IWebElement Familyunderstanding { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[65]")]
        public IWebElement Familyunderstanding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Se fixer des limites protectrices pour un temps des fêtes sans stress']")]
        public IWebElement Familyvaping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Se préparer au retour au travail et à la vie avec bébé']")]
        public IWebElement Familywhenthe { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Solutions relationnelles']")]
        public IWebElement Familyyour { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutien aux aidants naturels (aînés/famille)']")]
        public IWebElement Familyyouth { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutien aux nouveaux parents']")]
        public IWebElement Familyyouth1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutien parental']")]
        public IWebElement Familyyouth2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Votre enfant d’âge préscolaire']")]
        public IWebElement Familyyouth3 { get; set; }

        //FamilyCaregiving
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Soins']")]
        public IWebElement Familycaregiving { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'La définition de la santé mentale, les symptômes d')]")]
        public IWebElement Familycaregivingparents { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/famille/soins'][text()='Soins']")]
        public IWebElement Familycaregivingtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'De plus en plus de gens se trouvent tiraillés entr')]")]
        public IWebElement Familycaregivingelder { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'On ne vous apprendra rien en vous disant qu’il n’y')]")]
        public IWebElement Familycaregivingemployees { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cette podcast examine différents aspects de la dyn')]")]
        public IWebElement Familycaregivingfinancial { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Être un aidant à distance est possible, mais cela ')]")]
        public IWebElement Familycaregivinghousing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Prendre soin de parents âgés n’est pas une respon')]")]
        public IWebElement Familycaregivinglong { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Options d’hébergement pour les aînés']")]
        public IWebElement Familycaregivingrespite { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Prendre soin de parents vieillissants']")]
        public IWebElement Familycaregivingselfcare { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Questions financières ou juridiques']")]
        public IWebElement Familycaregivingunder { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Services de répit']")]
        public IWebElement Familycaregivingunder1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutien aux aidants naturels (aînés/famille)']")]
        public IWebElement Familycaregivingunder2 { get; set; }

        //FamilyCommunication
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Communication']")]
        public IWebElement Familycomm { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Avec les nombreuses pressions exercées sur les enf')]")]
        public IWebElement Familycommtrans { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/famille/communication'][text()='Communication']")]
        public IWebElement Familycommtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Avoir une relation de couple saine tout en préservant son individualité']")]
        public IWebElement Familycommbuilding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='C’est quoi le consentement?']")]
        public IWebElement Familycommcombining { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment parler à ses enfants de santé mentale et de toxicomanie']")]
        public IWebElement Familycommimproving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Entamer une conversation sur la santé mentale']")]
        public IWebElement Familycommrelationship { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Familles reconstituées']")]
        public IWebElement Familycommtalking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Guide à l’intention des personnes transgenres et de genres divers']")]
        public IWebElement Familycommtalking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’adolescent* d’aujourd’hui']")]
        public IWebElement Familycommtech { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La technologie et les relations interpersonnelles']")]
        public IWebElement Familycommtodays { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[9]")]
        public IWebElement Familycommconsent { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Solutions relationnelles']")]
        public IWebElement Familycommconsent1 { get; set; }

        //FamilyFinances
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Finances']")]
        public IWebElement FamilyFin { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'5 conseils simples pour vous aider à atteindre vos')]")]
        public IWebElement FamilyFinben { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/famille/finances'][text()='Finances']")]
        public IWebElement FamilyFintag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Dans cette podcast, nous examinerons les moyens de')]")]
        public IWebElement FamilyFinmental { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer son argent']")]
        public IWebElement FamilyFinconsultation { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment vous préparer à la retraite']")]
        public IWebElement FamilyFinfitness { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Considérations financières sous la loupe']")]
        public IWebElement FamilyFinissues { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[5]")]
        public IWebElement FamilyFinselfcare { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Information et consultation financières']")]
        public IWebElement FamilyFinstress { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La psychologie de la dette'])[1]")]
        public IWebElement FamilyFinkidsto { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La psychologie de la dette'])[2]")]
        public IWebElement FamilyFintimefor { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé financière']")]
        public IWebElement FamilyFinovercoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le grand débat sur l’allocation']")]
        public IWebElement FamilyFinplanning { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le moment de repenser vos finances?']")]
        public IWebElement FamilyFinpreparing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le stress financier']")]
        public IWebElement FamilyFintaking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les avantages d’une bonne santé financière']")]
        public IWebElement FamilyFinthe { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Planifier votre sécurité financière à la retraite']")]
        public IWebElement FamilyFinthe1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Santé financière et santé mentale']")]
        public IWebElement FamilyFinthe2 { get; set; }

        //FamilyParenting
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Éducation des enfants']")]
        public IWebElement FamilyParenting { get; set; }
        [FindsBy(How = How.XPath, Using = "//section[@class='article-featured']//p[contains(text(),'L')]")]
        public IWebElement FamilyParstress { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/famille/education-des-enfants'][text()='Éducation des enfants']")]
        public IWebElement FamilyParstag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Avec les nombreuses pressions exercées sur les enf')]")]
        public IWebElement FamilyParadhd { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Qu’il s’agisse de se tenir la main, de s’embrasser')]")]
        public IWebElement FamilyParbabies { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Nous avons tous plus ou moins de stress dans notre')]")]
        public IWebElement FamilyParbackto { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Choisir le bon camp d’été']")]
        public IWebElement FamilyParbackto1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Comment aider votre enfant a cesser de mouiller son lit']")]
        public IWebElement FamilyParbecoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment composer avec la transition de votre enfant de la pré-adolescence à l’adolescence']")]
        public IWebElement FamilyParcelebratingdads { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment parler à ses enfants de santé mentale et de toxicomanie']")]
        public IWebElement FamilyParcelebratingmoms { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment parler à vos enfants de votre séparation ou divorce']")]
        public IWebElement FamilyParchildcare1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment planifier votre nouvelle vie et votre retour au travail suivant l’arrivée de votre bébé']")]
        public IWebElement FamilyParchildcare2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Créer des moments précieux']")]
        public IWebElement FamilyParchildren { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Devenir parent']")]
        public IWebElement FamilyParchildren1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Familles reconstituées']")]
        public IWebElement FamilyParchoosing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Favoriser l’attachement']")]
        public IWebElement FamilyParcombining { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Hommage aux pères']")]
        public IWebElement FamilyParcreate { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’adolescent* d’aujourd’hui']")]
        public IWebElement FamilyPareffective { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’art d’être grands-parents']")]
        public IWebElement FamilyParfoundations1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’enfant exubérant']")]
        public IWebElement FamilyParfoundations2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La discipline efficace']")]
        public IWebElement FamilyPargrand { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La monoparentalité']")]
        public IWebElement FamilyParMaid { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La puissance d’une approche parentale positive']")]
        public IWebElement FamilyParhelping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La rentrée peut être synonyme de changements importants']")]
        public IWebElement FamilyParhowto { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La rentrée scolaire']")]
        public IWebElement FamilyParhowto1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La santé mentale des jeunes : technologie et cyberintimidation'])[1]")]
        public IWebElement FamilyParhowto2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La santé mentale des jeunes : technologie et cyberintimidation'])[2]")]
        public IWebElement FamilyParimproving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La séparation et le divorce']")]
        public IWebElement FamilyParnewparent { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le deuil et l’aide médicale à mourir']")]
        public IWebElement FamilyParpreparing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le localisateur de services aux enfants']")]
        public IWebElement FamilyParsecure { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[28]")]
        public IWebElement FamilyParseparation { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le TDAH et votre famille']")]
        public IWebElement FamilyParsingle { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le vapotage : la nouvelle dépendance des adolescents*']")]
        public IWebElement FamilyParspirited { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les bébés et le sommeil']")]
        public IWebElement FamilyParspotting { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[32]")]
        public IWebElement FamilyPartalking { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les fondements de la compétence parentale'])[1]")]
        public IWebElement FamilyPartalking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les fondements de la compétence parentale'])[2]")]
        public IWebElement FamilyPartamper { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les parents au travail']")]
        public IWebElement FamilyPartheimpact { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[36]")]
        public IWebElement FamilyParthepower { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[37]")]
        public IWebElement FamilyPartheworking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Se préparer au retour au travail et à la vie avec bébé']")]
        public IWebElement FamilyParteenagers { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Signes précurseurs du suicide']")]
        public IWebElement FamilyParvaping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutien aux nouveaux parents']")]
        public IWebElement FamilyParconsent { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutien parental']")]
        public IWebElement FamilyParyour { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Votre enfant d’âge préscolaire']")]
        public IWebElement FamilyParyour1 { get; set; }

        //LegalFinancial
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Droit et finance']")]
        public IWebElement LegFin { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Les planificatrices et planificateurs financiers n')]")]
        public IWebElement LegFinFam { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/droit-et-finance'][text()='Droit et finance']")]
        public IWebElement LegFintag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Chassez vos soucis financiers et commencez à épargner']")]
        public IWebElement LegFinmatters { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer son argent']")]
        public IWebElement LegFinconsultation { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer votre argent et dresser un budget mensuel']")]
        public IWebElement LegFinfitness { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment mettre de l’ordre dans vos finances']")]
        public IWebElement LegFinconsider { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment vous préparer à la retraite']")]
        public IWebElement LegFinretirement { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Considérations financières sous la loupe']")]
        public IWebElement LegFinget { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Droit Familial']")]
        public IWebElement LegFinorder { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[8]")]
        public IWebElement LegFinhow { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Information et consultation financières']")]
        public IWebElement LegFinisit { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé financière']")]
        public IWebElement LegFinovercoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le grand débat sur l’allocation']")]
        public IWebElement LegFinpre { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le moment de repenser vos finances?']")]
        public IWebElement LegFinretirementpre { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le Testament']")]
        public IWebElement LegFinquestions { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le travail après la retraite']")]
        public IWebElement LegFincontent { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mettez de l’ordre dans vos finances et réduisez votre niveau de stress']")]
        public IWebElement LegFinspending { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Planification de la retraite']")]
        public IWebElement LegFintaking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pour dépenser judicieusement pendant la période des Fêtes']")]
        public IWebElement LegFinallowance { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Qu’est-ce que le droit immobilier?']")]
        public IWebElement LegFinreal { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Questions financières ou juridiques']")]
        public IWebElement LegFinworking { get; set; }

        //LegalFinancialManagement
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Gestion financière']")]
        public IWebElement LegFinMan { get; set; }
        [FindsBy(How = How.XPath, Using = "//section[@class='article-featured']//p[1]")]
        public IWebElement LegFinMancons { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/finances/gestion-financiere'][text()='Gestion financière']")]
        public IWebElement LegFinMantag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment mettre de l’ordre dans vos finances']")]
        public IWebElement LegFinManFitness { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[2]")]
        public IWebElement LegFinManStress { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Information et consultation financières']")]
        public IWebElement LegFinManRetirement { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé financière']")]
        public IWebElement LegFinManGetting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le moment de repenser vos finances?']")]
        public IWebElement LegFinManisit { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le stress financier']")]
        public IWebElement LegFinManspending { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pour dépenser judicieusement pendant la période des Fêtes']")]
        public IWebElement LegFinMantaking { get; set; }

        //LegalFinancialLegal
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Légal']")]
        public IWebElement LFL { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Pendant une séparation ou un divorce, vous pourrie')]")]
        public IWebElement LFLFamily { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/finances/legale'][text()='Légal']")]
        public IWebElement LFLTag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Introduction au droit']")]
        public IWebElement LFLintro { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le Testament']")]
        public IWebElement LFLQuestions { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Qu’est-ce que le droit immobilier?']")]
        public IWebElement LFLLaw { get; set; }

        //LegalFinancialMentalHealth
        [FindsBy(How = How.XPath, Using = "//a[@href='/app/fr/resources/category/permalink/finances/sante-mentale']")]
        public IWebElement LFMental { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Les planificatrices et planificateurs financiers n')]")]
        public IWebElement LFMentaPhysical { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/finances/sante-mentale'][text()='Santé mentale']")]
        public IWebElement LFMentaltag { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Chassez vos soucis financiers et commencez à épargner'])[1]")]
        public IWebElement LFMentalconsulatation { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Chassez vos soucis financiers et commencez à épargner'])[2]")]
        public IWebElement LFMentalfitness { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer votre argent et dresser un budget mensuel']")]
        public IWebElement LFMentalstress { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Information et consultation financières']")]
        public IWebElement LFMentalgetcontrol { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé financière']")]
        public IWebElement LFMentalhow { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le stress financier']")]
        public IWebElement LFMentalovercoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mettez de l’ordre dans vos finances et réduisez votre niveau de stress']")]
        public IWebElement LFMentalovercoming1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pour dépenser judicieusement pendant la période des Fêtes']")]
        public IWebElement LFMentalretire { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Santé financière et santé physique']")]
        public IWebElement LFMentalspending { get; set; }

        //Lifestyle
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Mode de vie']")]
        public IWebElement Lifetyle { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Peu de choses ont une plus grande incidence sur la')]")]
        public IWebElement Lifetyletis { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie'][text()='Mode de vie']")]
        public IWebElement Lifetyletag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='À votre santé et bon voyage!']")]
        public IWebElement Lifetyle10steps { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Aborder la maladie mentale']")]
        public IWebElement Lifetyle360 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Acheter : Thérapie-emplettes ou folie des achats?']")]
        public IWebElement Lifetylestress { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Acné : ça ne touche pas que les ados']")]
        public IWebElement Lifetyleacne { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Aller au-delà de l’anxiété']")]
        public IWebElement Lifetyladapting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Améliorer son estime de soi']")]
        public IWebElement Lifetyladdiction { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Aperçu des liens entre stress, diabète, alimentation et santé mentale']")]
        public IWebElement Lifetylarthritis { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Au-delà de la stigmatisation']")]
        public IWebElement LifetylAutumn { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Avoir une relation de couple saine tout en préservant son individualité']")]
        public IWebElement LifetylAvoiding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Bien manger pendant la période des Fêtes']")]
        public IWebElement Lifetylbeyond { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[11]")]
        public IWebElement Lifetylbike { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Célébrons la fête des Mères']")]
        public IWebElement Lifetylbody { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cessez de fumer et retrouvez votre liberté!']")]
        public IWebElement Lifetylbreak { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cessez de vouloir trop en faire']")]
        public IWebElement Lifetylbreathe { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Coaching en nutrition']")]
        public IWebElement Lifetylbuilding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment abandonner ses mauvaises habitudes']")]
        public IWebElement Lifetylbuilding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment améliorer votre forme physique']")]
        public IWebElement Lifetylbuilding2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment améliorer votre sommeil']")]
        public IWebElement Lifetylcareer { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment augmenter votre confiance en vous']")]
        public IWebElement Lifetylcelebdad { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment changer une habitude']")]
        public IWebElement Lifetylcelebmom { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment combattre la déprime d’après les fêtes']")]
        public IWebElement Lifetylchildcare { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment conserver vos sentiments amoureux']")]
        public IWebElement Lifetylcleanup { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment contrôler sa consommation d’alcool']")]
        public IWebElement Lifetylconnecting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment contrôler votre consommation d’alcool']")]
        public IWebElement Lifetylcontraption { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment désamorcer un conflit']")]
        public IWebElement Lifetylcontrolling { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment éviter de réagir de façon excessive']")]
        public IWebElement Lifetylcoping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment faire face à la perte de son emploi']")]
        public IWebElement Lifetylcoping1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer la perte de son emploi']")]
        public IWebElement Lifetylcoping2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer le deuil']")]
        public IWebElement Lifetylcoping3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer son stress et concilier travail et vie personnelle']")]
        public IWebElement Lifetylcosmetic { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment jouir d’un bon sommeil']")]
        public IWebElement LifetylDealing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maintenir une relation saine avec la nourriture']")]
        public IWebElement LifetylDealing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser sa colère']")]
        public IWebElement LifetylDealing2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser son humeur']")]
        public IWebElement Lifetyldisability { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser son stress']")]
        public IWebElement Lifetyleating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Comment offrir du soutien aux enfants qui s’identifient comme LGBTQ2+']")]
        public IWebElement Lifetyleating1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment parler à ses enfants de santé mentale et de toxicomanie']")]
        public IWebElement Lifetyleco { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment parler à vos enfants de votre séparation ou divorce']")]
        public IWebElement Lifetylensuring { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment prendre sa carrière en main']")]
        public IWebElement Lifetylfinding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment réduire le stress des fêtes']")]
        public IWebElement Lifetylfood { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment rétablir la confiance dans votre couple']")]
        public IWebElement Lifetylfoundations { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment s’adapter au changement']")]
        public IWebElement Lifetylgetaway { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment saisir la chance de vous exprimer']")]
        public IWebElement Lifetylgetting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment se maintenir en bonne santé psychologique']")]
        public IWebElement Lifetylgetting1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment tirer le maximum de vos médicaments']")]
        public IWebElement Lifetylgoing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment vous préparer à la retraite']")]
        public IWebElement Lifetylgrandparent { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre et prévenir l’épuisement professionnel?']")]
        public IWebElement Lifetylgrief { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre la dépression']")]
        public IWebElement Lifetylhappy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Conflits relationnels']")]
        public IWebElement Lifetylharmful { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Conseils de prévention des invalidités au travail']")]
        public IWebElement Lifetylhealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Contraception']")]
        public IWebElement Lifetylhealth1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Découvrir les visages de l’anxiété']")]
        public IWebElement Lifetylhealth2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dépendance et rétablissement']")]
        public IWebElement Lifetylhealth3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dépression saisonnière et pensées toxiques']")]
        public IWebElement Lifetylhealth4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Déveloper la résilience']")]
        public IWebElement Lifetylhealth5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Développer sa résilience']")]
        public IWebElement Lifetylholiday { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dix conseils à suivre pour atteindre l’équilibre travail-vie personnelle']")]
        public IWebElement Lifetylhow { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='En quoi consistent les troubles de l’alimentation?']")]
        public IWebElement Lifetylhowavoid { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Entamer une conversation sur la santé mentale']")]
        public IWebElement Lifetylhowcombat { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Éviter Les Dépendances De Substitution']")]
        public IWebElement Lifetylhowdeal { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face à la dépression']")]
        public IWebElement Lifetylhowpreschooler { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face à un évènement traumatisant']")]
        public IWebElement Lifetylhowdefuse { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face aux traumatismes de l’enfance']")]
        public IWebElement Lifetylhowsleep { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Gérer la dépression saisonnière'])[1]")]
        public IWebElement Lifetylhowself { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Gérer la dépression saisonnière'])[2]")]
        public IWebElement Lifetylmaintain { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Hommage aux pères']")]
        public IWebElement Lifetylreduce { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Information et consultation juridiques']")]
        public IWebElement LifetylLGB { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Interventions cosmétiques']")]
        public IWebElement Lifetylchance { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Introduction à la thérapie cognitive-comportementale (TCC)']")]
        public IWebElement Lifetylseparation { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Jardin propice à la santé, jardinier en bonne santé']")]
        public IWebElement Lifetylhumour { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Joie et santé pour le temps des Fêtes!']")]
        public IWebElement LifetylIdentity { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Juin est le mois national de sensibilisation au trouble de stress post-traumatique']")]
        public IWebElement LifetylImmigrant { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[73]")]
        public IWebElement LifetylImmigrant1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[74]")]
        public IWebElement Lifetylimproving { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[75]")]
        public IWebElement Lifetylinterconnections { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[76]")]
        public IWebElement LifetylCBT { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’adolescent* d’aujourd’hui']")]
        public IWebElement Lifetylmoney { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’amélioration personnelle : prendre soin de soi et de sa santé']")]
        public IWebElement Lifetyljump { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’art d’être grands-parents']")]
        public IWebElement Lifetyljune { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’importance d’être en lien avec la collectivité']")]
        public IWebElement Lifetylkeep { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’importance de la détente']")]
        public IWebElement Lifetylkeeping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’importance du sommeil']")]
        public IWebElement Lifetyllearning { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’influence du sommeil sur la santé']")]
        public IWebElement Lifetyllearning1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La biologie de notre « horloge interne »']")]
        public IWebElement Lifetyllegal { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[85]")]
        public IWebElement LifetylLGBTQ { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La dépendance : des faits qui font réfléchir']")]
        public IWebElement LifetylLinking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La dynamique familiale']")]
        public IWebElement LifetylLiving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La gestion du stress en milieu de travail']")]
        public IWebElement LifetylLiving1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La méditation']")]
        public IWebElement LifetylLiving2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La monoparentalité']")]
        public IWebElement LifetylLooking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La pratique quotidienne de la méditation de pleine conscience']")]
        public IWebElement Lifetylmaintaining { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La résilience']")]
        public IWebElement Lifetylmaintaining1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[93]")]
        public IWebElement Lifetylmanaging { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La respiration détendue']")]
        public IWebElement Lifetylmetimeg { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé et la sécurité en hiver']")]
        public IWebElement Lifetylmeditation { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​La santé mentale des enfants et des adolescents*']")]
        public IWebElement Lifetylmens { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé mentale des étudiants*']")]
        public IWebElement Lifetylmentalillness { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé mentale des hommes']")]
        public IWebElement Lifetylmindfulness { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La sécurité à bicyclette']")]
        public IWebElement Lifetylmoving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La séparation et le divorce']")]
        public IWebElement Lifetylnavigating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La technologie et les relations interpersonnelles']")]
        public IWebElement Lifetylnewparent { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La thérapie par l’humour et le pouvoir du rire']")]
        public IWebElement Lifetylnutritional { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La visualisation']")]
        public IWebElement Lifetylovercoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le décès d’un proche']")]
        public IWebElement Lifetylovercoming1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le deuil écologique']")]
        public IWebElement Lifetylpositive { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le lien entre l’exercice et la nutrition et la bonne santé mentale']")]
        public IWebElement Lifetylpre { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le lien qui existe entre la commotion cérébrale et la dépression']")]
        public IWebElement Lifetylpreparing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le localisateur de services aux enfants']")]
        public IWebElement Lifetylpreparing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le mieux-être durant la période des Fêtes']")]
        public IWebElement Lifetylptsd { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le moment de repenser vos finances?']")]
        public IWebElement Lifetylrace { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le pouvoir bienfaisant d’une bonne action']")]
        public IWebElement Lifetylraising { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le pouvoir d’une attitude positive']")]
        public IWebElement Lifetylreenergizing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le Questionnaire santé']")]
        public IWebElement Lifetylreducing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le santé mentale des femmes']")]
        public IWebElement Lifetylreducingmental { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le sommeil, c’est la santé']")]
        public IWebElement Lifetylrelationshipdis { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[116]")]
        public IWebElement Lifetylrelationshipsol { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le travail après la retraite']")]
        public IWebElement Lifetylresilience { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le travail par quarts']")]
        public IWebElement Lifetylresiliencecond { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le TSPT au travail: Solutions et Soutien']")]
        public IWebElement Lifetylresolving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le vapotage : la nouvelle dépendance des adolescents*']")]
        public IWebElement Lifetylresponsible { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les blessures invisibles des troubles de santé mentale']")]
        public IWebElement Lifetylrestoring { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les choses à faire et à ne pas faire pour vivre une relation saine']")]
        public IWebElement Lifetylselfcare { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les composantes de la colère?']")]
        public IWebElement Lifetyldivorce { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[124]")]
        public IWebElement Lifetylsetting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les défis du travail par quarts']")]
        public IWebElement Lifetylshift { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les employé·e·s immigrant·e·s qui s’établissent en Amérique du Nord'])[1]")]
        public IWebElement Lifetylsingle { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les employé·e·s immigrant·e·s qui s’établissent en Amérique du Nord'])[2]")]
        public IWebElement Lifetylsleep { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les étiquettes nutritionnelles, vous les comprenez?']")]
        public IWebElement Lifetylsmoking { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[129]")]
        public IWebElement Lifetylsocial { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les fondements de la compétence parentale']")]
        public IWebElement Lifetylsomeone { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les LGBTQ+ et la santé mentale']")]
        public IWebElement Lifetylsomeone1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les mérites des superaliments']")]
        public IWebElement Lifetylsomeone2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les nombreuses facettes de l’anxiété']")]
        public IWebElement Lifetylstop { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les nombreux visages du TSPT']")]
        public IWebElement Lifetylsmoking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les parents au travail']")]
        public IWebElement Lifetylstudent { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les raisons pour maintenir une bonne posture']")]
        public IWebElement Lifetylsummerskin { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les risques des médias sociaux pour votre santé mentale']")]
        public IWebElement Lifetylsupporting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les sièges de tension']")]
        public IWebElement Lifetylsupporting1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les vacances : se relaxer, se revigorer, se retrouver']")]
        public IWebElement Lifetylsupporting2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Leur influence positive sur la santé mentale et le rétablissement de la toxicomanie']")]
        public IWebElement Lifetyltakingstress1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[141]")]
        public IWebElement Lifetyltakingstress2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maîtrisez votre stress']")]
        public IWebElement Lifetyltakingcontrol { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maîtrisez votre stress avant qu’il ne soit trop tard!']")]
        public IWebElement Lifetyltakingcontrol1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Manger sainement sur le pouce']")]
        public IWebElement Lifetyltakingcontrol2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mesures pour recouvrer la santé mentale']")]
        public IWebElement Lifetyltakingcontrol3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[146]")]
        public IWebElement Lifetyltakingcontrol4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Nettoyage de votre trousse de cosmétiques']")]
        public IWebElement Lifetyltakingcontrol5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Orientation professionnelle']")]
        public IWebElement Lifetyltalking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Parcours mieux-être']")]
        public IWebElement Lifetyltalking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[150]")]
        public IWebElement Lifetyltalking2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Planification de la retraite']")]
        public IWebElement Lifetyltech { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pour en finir avec les mythes sur la maladie mentale!']")]
        public IWebElement Lifetylbenefits { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pour la santé de votre cœur']")]
        public IWebElement Lifetylbiology { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[154]")]
        public IWebElement Lifetylcosmeticsurgery { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Préserver sa santé mentale et physique pendant le temps des Fêtes']")]
        public IWebElement Lifetyldangers { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[156]")]
        public IWebElement Lifetylhealing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Qu’est-ce que la pleine conscience et comment la pratiquer?']")]
        public IWebElement Lifetylimpactalcohol { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quand un proche est gravement malade']")]
        public IWebElement Lifetylimpactsleep { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quand un proche se suicide']")]
        public IWebElement Lifetylimpacttech { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Race et ethnicité : le climat actuel']")]
        public IWebElement Lifetylimportance { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Réduire la stigmatisation entourant les problèmes de santé mentale']")]
        public IWebElement Lifetylimportancesleep { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Réduire le stress du temps des fêtes']")]
        public IWebElement Lifetylinvisible { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Refaire ses forces pour la nouvelle année']")]
        public IWebElement Lifetylthelink { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Réseaux sociaux : donnez un coup de pouce à votre vie']")]
        public IWebElement Lifetylthemany { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Résilience']")]
        public IWebElement Lifetyltheptsd { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[166]")]
        public IWebElement Lifetylthepower { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Santé en automne']")]
        public IWebElement Lifetylthesobering { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Se fixer des limites protectrices pour un temps des fêtes sans stress']")]
        public IWebElement Lifetyltheweight { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Se préparer pour la nouvelle année en cultivant sa santé mentale']")]
        public IWebElement Lifetyltheworking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Service IntelliVie']")]
        public IWebElement Lifetyltips { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Solutions relationnelles']")]
        public IWebElement Lifetyltodays { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les premiers intervenants*']")]
        public IWebElement Lifetyltoomuch { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir un ex-toxicomane* pendant les fêtes']")]
        public IWebElement Lifetyltoomuch1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[174]")]
        public IWebElement Lifetyluncovering { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutien à l’abandon du tabac']")]
        public IWebElement Lifetylunderstanding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutien aux nouveaux parents']")]
        public IWebElement Lifetylunderstanding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutien aux travailleurs de quarts']")]
        public IWebElement Lifetylunderstanding2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutien parental']")]
        public IWebElement Lifetylvacation { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stockage des aliments et durée de conservation']")]
        public IWebElement Lifetylvaping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stratégies de leadership favorisant la santé']")]
        public IWebElement Lifetylvisualization { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Surmonter la déprime de l’hiver']")]
        public IWebElement Lifetylwellness { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Surmonter ses phobies']")]
        public IWebElement Lifetylwhat { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Tenir ses résolutions']")]
        public IWebElement Lifetylpractiseit { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Trop de temps d’écran?'])[1]")]
        public IWebElement Lifetylwhenhabits { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Trop de temps d’écran?'])[2]")]
        public IWebElement Lifetylwhensomeone { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Trouver la force de pardonner']")]
        public IWebElement Lifetylwhygood { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Une Vie Épanouie'])[1]")]
        public IWebElement Lifetylwinter { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Une Vie Épanouie'])[2]")]
        public IWebElement Lifetylwintertime { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Une Vie Épanouie'])[3]")]
        public IWebElement Lifetylwomen { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vers une meilleure alimentation']")]
        public IWebElement Lifetylworking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vieillir en santé']")]
        public IWebElement Lifetylworking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vivre au quotidien le recouvrement de sa santé mentale']")]
        public IWebElement Lifetylyouhave { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[193]")]
        public IWebElement Lifetylyouth { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vivre avec une maladie physique chronique']")]
        public IWebElement Lifetylyouth1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Voir le bon côté des choses… en plein air']")]
        public IWebElement Lifetylyouth2 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[196]")]
        public IWebElement Lifetylyouth3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vous venez de vivre un évènement pénible']")]
        public IWebElement Lifetylyouth4 { get; set; }

        //LifestyleAddiction
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Dépendance']")]
        public IWebElement Lifetyladd { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Tout le monde apprécie un peu de magasinage, une p')]")]
        public IWebElement Lifetyladdrecovery { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie/dependance'][text()='Dépendance']")]
        public IWebElement Lifetyladdtag { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Aider les personnes aux prises avec un problème de dépendance'])[1]")]
        public IWebElement Lifetyladdsubs { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Aider les personnes aux prises avec un problème de dépendance'])[2]")]
        public IWebElement Lifetyladdbreak { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Aider les personnes aux prises avec un problème de dépendance'])[3]")]
        public IWebElement Lifetyladdcontrolling { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment abandonner ses mauvaises habitudes']")]
        public IWebElement Lifetyladddating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment contrôler sa consommation d’alcool']")]
        public IWebElement Lifetyladdharmless { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment contrôler votre consommation d’alcool']")]
        public IWebElement Lifetyladdhow { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment l’empathie peut soutenir une personne en rétablissement']")]
        public IWebElement Lifetyladdpositive { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre les troubles alimentaires : une approche compatissante pour accroître la sensibilisation et offrir du soutien']")]
        public IWebElement Lifetyladdsupporting { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[9]")]
        public IWebElement Lifetyladdsupporting1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[10]")]
        public IWebElement Lifetyladdsupporting2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dépendance et rétablissement']")]
        public IWebElement Lifetyladdtaking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Éviter Les Dépendances De Substitution']")]
        public IWebElement Lifetyladdtech { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La dépendance : des faits qui font réfléchir']")]
        public IWebElement Lifetyladddangers { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Leur influence positive sur la santé mentale et le rétablissement de la toxicomanie']")]
        public IWebElement Lifetyladdalcohol { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le vapotage : la nouvelle dépendance des adolescents*']")]
        public IWebElement Lifetyladdsobering { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[16]")]
        public IWebElement Lifetyladdunderstanding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les relations de couple pendant le rétablissement']")]
        public IWebElement Lifetyladdunderstanding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les risques des médias sociaux pour votre santé mentale']")]
        public IWebElement Lifetyladdunderstanding2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les technologies et le temps passé devant un écran']")]
        public IWebElement Lifetyladdvaping { get; set; }

        //LifestyleCareerDevelopment
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Développement professionnel']")]
        public IWebElement Lifetylcareerdev { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Comment entrevois-tu l’avenir? Comment gérer mes s')]")]
        public IWebElement Lifetylcareerdevburn { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-vie/developpement-professionnel'][text()='Développement professionnel']")]
        public IWebElement Lifetylcareerdevtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment tirer de l’entrevue d’emploi l’information dont vous avez besoin']")]
        public IWebElement Lifetylcareerdevcareer { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Créer un équilibre travail-vie personnelle']")]
        public IWebElement Lifetylcareerdevcreating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gérer efficacement un déclassement ou une rétrogradation']")]
        public IWebElement Lifetylcareerdeveffectively { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’épuisement professionnel : Définition et solutions']")]
        public IWebElement Lifetylcareerdevhealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Orientation professionnelle']")]
        public IWebElement Lifetylcareerdevhow { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stratégies de leadership favorisant la santé']")]
        public IWebElement Lifetylcareerdevhowjob { get; set; }

        //LifestyleChildcare

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Services aux enfants']")]
        public IWebElement Lifetylchild { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Qu’il s’agisse de se tenir la main, de s’embrasser')]")]
        public IWebElement Lifetylchildstress { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie/services-aux-enfants'][text()='Services aux enfants']")]
        public IWebElement Lifetylchildcaretag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Célébrons la fête des Mères']")]
        public IWebElement Lifetylchildcareadhd { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Choisir le bon camp d’été']")]
        public IWebElement Lifetylchildcareare { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Comment aider votre enfant a cesser de mouiller son lit']")]
        public IWebElement Lifetylchildcarebabies { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment composer avec la transition de votre enfant de la pré-adolescence à l’adolescence']")]
        public IWebElement Lifetylchildcarebaby { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Comment offrir du soutien aux enfants qui s’identifient comme LGBTQ2+']")]
        public IWebElement Lifetylchildcareback { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment parler à vos enfants de votre séparation ou divorce']")]
        public IWebElement Lifetylchildcarebecoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Conseils pour la sécurité de bébé']")]
        public IWebElement Lifetylchildcarebedwetting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Coups de pied, culbutes et autres motions in utero']")]
        public IWebElement Lifetylchildcarebedwetting1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Créer des moments précieux']")]
        public IWebElement Lifetylchildcarebedwetting2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[10]")]
        public IWebElement Lifetylchildcarebreast { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Des soins pour la peau sensible de votre enfant : 5 top conseils pour les parents']")]
        public IWebElement Lifetylchildcarecaring { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Devenir parent']")]
        public IWebElement Lifetylchildcarecaring1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Êtes-vous prête à avoir un autre enfant?']")]
        public IWebElement Lifetylchildcaredads { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Familles reconstituées']")]
        public IWebElement Lifetylchildcaremoms { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Favoriser l’attachement']")]
        public IWebElement Lifetylchildcare1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Halloween en santé et sécurité']")]
        public IWebElement Lifetylchildcare2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[17]")]
        public IWebElement Lifetylchildcarechildhood { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Hommage aux pères']")]
        public IWebElement Lifetylchildcarechoosing { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[19]")]
        public IWebElement Lifetylchildcarecombining { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[20]")]
        public IWebElement Lifetylchildcarecreate { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’art d’être grands-parents']")]
        public IWebElement Lifetylchildcaredry { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’enfant exubérant']")]
        public IWebElement Lifetylchildcareeating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La discipline efficace']")]
        public IWebElement Lifetylchildcareeffective { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La dynamique familiale']")]
        public IWebElement Lifetylchildcarefoundations { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La monoparentalité']")]
        public IWebElement Lifetylchildcarefoundations1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La planification de votre congé de maternité']")]
        public IWebElement Lifetylchildcaregrand { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La puissance d’une approche parentale positive']")]
        public IWebElement Lifetylchildcarehalloween { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​La santé mentale des enfants et des adolescents*']")]
        public IWebElement Lifetylchildcarehow { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La séparation et le divorce']")]
        public IWebElement Lifetylchildcarehow1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La vaccination et votre enfant']")]
        public IWebElement Lifetylchildcarehow2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La vie en ligne : est-elle saine?']")]
        public IWebElement Lifetylchildcarehow3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le «pipi au lit» et le temps des fêtes']")]
        public IWebElement Lifetylchildcareisyour { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le «pipi au lit» et les nuits ailleurs']")]
        public IWebElement Lifetylchildcarekicks { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le pipi au lit à la rentrée des classes']")]
        public IWebElement Lifetylchildcaremanaging { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[36]")]
        public IWebElement Lifetylchildcarenewparent { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le TDAH et votre famille']")]
        public IWebElement Lifetylchildcareonline { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les bébés et le sommeil']")]
        public IWebElement Lifetylchildcareplanning { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[39]")]
        public IWebElement Lifetylchildcareschool { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[40]")]
        public IWebElement Lifetylchildcaresecure { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les fondements de la compétence parentale'])[1]")]
        public IWebElement Lifetylchildcareseparation { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les fondements de la compétence parentale'])[2]")]
        public IWebElement Lifetylchildcaresingle { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les parents au travail']")]
        public IWebElement Lifetylchildcarespirited { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les technologies et le temps passé devant un écran']")]
        public IWebElement Lifetylchildcaretalking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Manger pour deux – nutrition et grossesse']")]
        public IWebElement Lifetylchildcaretech { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[46]")]
        public IWebElement Lifetylchildcareimpact { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Prendre soin de votre bébé prématuré']")]
        public IWebElement Lifetylchildcarepower { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Que faire quand votre enfant a une éruption cutanée']")]
        public IWebElement Lifetylchildcareworking { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[49]")]
        public IWebElement Lifetylchildcareunderstanding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Se préparer au retour au travail et à la vie avec bébé']")]
        public IWebElement Lifetylchildcarevaccination { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutien aux nouveaux parents']")]
        public IWebElement Lifetylchildcarewhatconsent { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutien parental']")]
        public IWebElement Lifetylchildcarewhatdo { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Une rentrée des classes en santé']")]
        public IWebElement Lifetylchildcareworkingout { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vaccination des enfants: votre enfant est-il bien protégé?']")]
        public IWebElement Lifetylchildcareyouth { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Votre enfant est-il exposé à un risque élevé de maladie pouvant être prévenue par la vaccination?']")]
        public IWebElement Lifetylchildcareyouth1 { get; set; }

        //LifestyleCommunication

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Communication']")]
        public IWebElement Lifetylcommunication { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Si beaucoup de gens soulignent des occasions roman')]")]
        public IWebElement Lifetylcommbuild { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie/communication'][text()='Communication']")]
        public IWebElement Lifetylcommtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment désamorcer un conflit']")]
        public IWebElement Lifetylcommdefuse { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Comment offrir du soutien aux enfants qui s’identifient comme LGBTQ2+']")]
        public IWebElement Lifetylcommlgbtq { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment rétablir la confiance dans votre couple']")]
        public IWebElement Lifetylcommrelation { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Conflits relationnels']")]
        public IWebElement Lifetylcommsolution { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La technologie et les relations interpersonnelles']")]
        public IWebElement Lifetylcommrestoring { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Solutions relationnelles']")]
        public IWebElement Lifetylcommtech { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Trop de temps d’écran : effets sur la santé mentale et façons d’y remédier']")]
        public IWebElement Lifetylcommtoo { get; set; }

        //LifestyleDiseaseManagement

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Gestion des maladies']")]
        public IWebElement LifetylDisMan { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Savons, hydratants, soins quotidiens : tous aident')]")]
        public IWebElement LifetylDisman10easy { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie/gestion-des-maladies'][text()='Gestion des maladies']")]
        public IWebElement LifetylDismantag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()=' Dix choses que vous devez savoir à propos de votre médicament contre le psoriasis']")]
        public IWebElement LifetylDisman10must { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[2]")]
        public IWebElement LifetylDisman10things { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[3]")]
        public IWebElement LifetylDisman10tips { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()=' Le rythme se maintient : la FibA au quotidien']")]
        public IWebElement LifetylDisman5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()=' Les maladies rares – Ce qui rend le diagnostic si difficile']")]
        public IWebElement LifetylDisman5winter { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()=' Les stérols végétaux : pour combattre le cholestérol naturellement']")]
        public IWebElement LifetylDismanactive { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()=' Psoriasis : comment reprendre le contrôle de sa vie']")]
        public IWebElement LifetylDismanafib { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()=' Quelques faits concernant le cœur : Sept choses que vous ignoriez']")]
        public IWebElement LifetylDismanairtravel { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[9]")]
        public IWebElement LifetylDismanallergy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()=' Traitement contre le psoriasis : ne vous contentez pas de résultats mitigés!']")]
        public IWebElement LifetylDismanprevention { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[11]")]
        public IWebElement LifetylDismananaemia { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[12]")]
        public IWebElement LifetylDismanrisk { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[13]")]
        public IWebElement LifetylDismanarthritis { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='À propos de la diarrhée']")]
        public IWebElement LifetylDismanashtma { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Accident vasculaire cérébral']")]
        public IWebElement LifetylDismanashtma1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Aide à domicile']")]
        public IWebElement LifetylDismanbe { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Aidez votre médecin à comprendre vos priorités']")]
        public IWebElement LifetylDismancancer { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Allergie et asthme']")]
        public IWebElement LifetylDismancancertips { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Allergies médicamenteuses']")]
        public IWebElement LifetylDismanchildhood { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Aperçu des liens entre stress, diabète, alimentation et santé mentale']")]
        public IWebElement LifetylDismancholestoral { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Apprenez à maîtriser votre diabète']")]
        public IWebElement LifetylDismanchronic { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Arthrite']")]
        public IWebElement LifetylDismancolorectal { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='AVC et fibrillation auriculaire : présentez-vous un risque?']")]
        public IWebElement LifetylDismancompl { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Avez-vous besoin de consulter un dermatologue?']")]
        public IWebElement LifetylDismancoping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cancer colorectal : couper les risques']")]
        public IWebElement LifetylDismancrp { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cancer cutané : protégez votre peau']")]
        public IWebElement LifetylDismancutting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cancer de la prostate : histoire vécue']")]
        public IWebElement LifetylDismandiabetes { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cesser de fumer']")]
        public IWebElement LifetylDismandiabetes1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Choisir le bon vaccin pour la bonne catégorie de population adulte']")]
        public IWebElement LifetylDismandiabetes2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cinq risques pour le cœur en hiver']")]
        public IWebElement LifetylDismandiabetes3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment prévenir un deuxième AVC?']")]
        public IWebElement LifetylDismandiarrhea { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment un adulte peut maintenir sa vaccination à jour']")]
        public IWebElement LifetylDismandoyou { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='CRP, cholestérol et maladie cardiaque']")]
        public IWebElement LifetylDismandoit { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Des médicaments pour rester en santé']")]
        public IWebElement LifetylDismandont { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[35]")]
        public IWebElement LifetylDismandrug { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dix conseils pour rester en santé avec la SEP']")]
        public IWebElement LifetylDismaneczema { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Donner les médicaments contre la SP']")]
        public IWebElement LifetylDismaneczema1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Entraînez votre cœur']")]
        public IWebElement LifetylDismanerectile { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Êtes-vous à risque de fibrillation auriculaire?']")]
        public IWebElement LifetylDismaneye { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Évaluation de l’info médicale en ligne']")]
        public IWebElement LifetylDismaneyesym { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face à la fatigue de la SP']")]
        public IWebElement LifetylDismaneyesight { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face au cancer']")]
        public IWebElement LifetylDismanflu { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face aux défis de la SP avec espoir']")]
        public IWebElement LifetylDismangenital { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[44]")]
        public IWebElement LifetylDismanhealthy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gardez un sourire éclatant de santé!']")]
        public IWebElement LifetylDismanheart { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Impétigo']")]
        public IWebElement LifetylDismanheartfacts { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Infections transmissibles sexuellement']")]
        public IWebElement LifetylDismanhearthealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Intolérance au glucose']")]
        public IWebElement LifetylDismanhelp { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[49]")]
        public IWebElement LifetylDismanhigh { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[50]")]
        public IWebElement LifetylDismanhome { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[51]")]
        public IWebElement LifetylDismanhowMS { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[52]")]
        public IWebElement LifetylDismanhowtoprevent { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[53]")]
        public IWebElement LifetylDismanhowtotalk { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La désaccoutumance au tabac']")]
        public IWebElement LifetylDismanHPV { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La haute pression: quoi de neuf?']")]
        public IWebElement LifetylDismanHPV1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[56]")]
        public IWebElement LifetylDismanHPV2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La nutrition']")]
        public IWebElement LifetylDismanHPV3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La prise de médicaments contre la SEP sans peine']")]
        public IWebElement LifetylDismanimpaired { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La sclérose en plaques']")]
        public IWebElement LifetylDismanimpetigo { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La sclérose en plaques et la mémoire']")]
        public IWebElement LifetylDismanintegrative { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La sexualité et la SP : questions et réponses']")]
        public IWebElement LifetylDismaninterconnections { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La SP : traitement des rechutes']")]
        public IWebElement LifetylDismankeeping { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[63]")]
        public IWebElement LifetylDismankeeping1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[64]")]
        public IWebElement LifetylDismanlearn { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La SP et la dépression']")]
        public IWebElement LifetylDismanlearn1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La SP et la nutrition']")]
        public IWebElement LifetylDismanliving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La SP et la sexualité']")]
        public IWebElement LifetylDismanliving1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La SP: idées fausses et réalité']")]
        public IWebElement LifetylDismanmake { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La vaccination antigrippale, est-ce pour moi?']")]
        public IWebElement LifetylDismanmanaging { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La vie avec le cancer colorectal']")]
        public IWebElement LifetylDismanmoretime { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La visite au Médecin']")]
        public IWebElement LifetylDismanmsdepression { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le psoriasis : évitez les déclencheurs']")]
        public IWebElement LifetylDismanmsemp { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[73]")]
        public IWebElement LifetylDismanmsexe { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le b.a-ba de la médecine intégrative']")]
        public IWebElement LifetylDismanmshealthy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le cancer et la chimiothérapie']")]
        public IWebElement LifetylDismanmsmemory { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le cholestérol et vous : qui est aux commandes?']")]
        public IWebElement LifetylDismanmsnutrition { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le contrôle de votre poids malgré la SP']")]
        public IWebElement LifetylDismanmspreg { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le futur des soins de santé primaires']")]
        public IWebElement LifetylDismanmsquality { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le rhume et la grippe']")]
        public IWebElement LifetylDismanmssex { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[80]")]
        public IWebElement LifetylDismanmsspa { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le traitement du cholestérol : quels sont les bénéfices?']")]
        public IWebElement LifetylDismanmstravel { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le trouble affectif saisonnier']")]
        public IWebElement LifetylDismanmssupport { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[83]")]
        public IWebElement LifetylDismanmsmedication { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les 10 choses les plus importantes que vous devez savoir sur la vaccination contre le VPH']")]
        public IWebElement LifetylDismanmsmedication1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les faits sur les infections à levures']")]
        public IWebElement LifetylDismanmsback { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les petits tracas du voyageur']")]
        public IWebElement LifetylDismanmsbowel { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[87]")]
        public IWebElement LifetylDismanmscog { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les plaisirs du plein air']")]
        public IWebElement LifetylDismanmscontrol { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les répercussions des MII sur votre vie']")]
        public IWebElement LifetylDismanmscoping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les troubles obsessionnels-compulsifs']")]
        public IWebElement LifetylDismanmsdealing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les trousses de vérification à domicile']")]
        public IWebElement LifetylDismanmsdealing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les trucs de tout traitement médical']")]
        public IWebElement LifetylDismanmsdoctor { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Lorsque la consommation d’alcool devient problématique']")]
        public IWebElement LifetylDismanmsexercise { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maladie pulmonaire obstructive chronique']")]
        public IWebElement LifetylDismanmsfacts { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[95]")]
        public IWebElement LifetylDismanmshave { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maladies de la thyroïde: les nodules']")]
        public IWebElement LifetylDismanmshelp { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Médecine douce']")]
        public IWebElement LifetylDismanmsinternet { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mesures envers les tremblements de la SP']")]
        public IWebElement LifetylDismanmsmanaging { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mieux vivre avec le psoriasis']")]
        public IWebElement LifetylDismanmsmanaging1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[100]")]
        public IWebElement LifetylDismanmsmanaging2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Nouveauté dans le traitement du psoriasis']")]
        public IWebElement LifetylDismanmsrehab { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Obésité infantile']")]
        public IWebElement LifetylDismanmsstem { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Ostéoporose']")]
        public IWebElement LifetylDismanmstips { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[104]")]
        public IWebElement LifetylDismanmsunderstand { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Parler de la SP aux amis et à la famille']")]
        public IWebElement LifetylDismanmsvitamin { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pas encore une infection à levures !']")]
        public IWebElement LifetylDismanmsways { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Your Condition and Your Children']")]
        public IWebElement LifetylDismanmsyour { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[107]")]
        public IWebElement LifetylDismanmsmultiple { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Prévenir et gérer les poussées de psoriasis']")]
        public IWebElement LifetylDismanmsnicotine { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[109]")]
        public IWebElement LifetylDismannutrition { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Prévention et traitement des allergies']")]
        public IWebElement LifetylDismanocd { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Prise en charge du cancer avancé de la prostate']")]
        public IWebElement LifetylDismanohno { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[112]")]
        public IWebElement LifetylDismanosteoporosis { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[113]")]
        public IWebElement LifetylDismanosteoporosis1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Réadaptation et sclérose en plaques']")]
        public IWebElement LifetylDismanovercoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Réduire votre risque de cancer']")]
        public IWebElement LifetylDismanpeptic { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Réduisez votre risque de diabète de type 2']")]
        public IWebElement LifetylDismanpicking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Réduisez votre risque de maladies du cœur']")]
        public IWebElement LifetylDismanplant { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Respecter son traitement contre la SEP']")]
        public IWebElement LifetylDismanprostate { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Rester actif malgré la sclérose en plaques']")]
        public IWebElement LifetylDismanprotecting { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[120]")]
        public IWebElement LifetylDismanpsoriasis { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sachez parler à votre médecin']")]
        public IWebElement LifetylDismanpsoriasis1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Santé du cœur: 10 conseils incontournables']")]
        public IWebElement LifetylDismanpsoriasis2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sclérose en plaques : Rentrée scolaire']")]
        public IWebElement LifetylDismanpsoriasis3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Signes et symptômes oculaires']")]
        public IWebElement LifetylDismanpsoriasis4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soulagez vous-même votre rhume']")]
        public IWebElement LifetylDismanquitting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='SP : À la conquête de la spasticité']")]
        public IWebElement LifetylDismanrare { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[127]")]
        public IWebElement LifetylDismanrecently { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='SP : Comment aider']")]
        public IWebElement LifetylDismanreduce { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='SP : Comprendre les essais cliniques']")]
        public IWebElement LifetylDismanreducing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='SP : contrôler la douleur']")]
        public IWebElement LifetylDismanseason { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='SP : Organiser vos médicaments']")]
        public IWebElement LifetylDismansexuality { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='SP : problèmes intestinaux et vésicaux']")]
        public IWebElement LifetylDismantrans { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='SP : votre maladie et vos enfants']")]
        public IWebElement LifetylDismanshot { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='SP et fonction cognitive']")]
        public IWebElement LifetylDismansmoking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='SP et grossesse']")]
        public IWebElement LifetylDismanstaying { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='SP et la greffe de cellules souches']")]
        public IWebElement LifetylDismanstaying1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='SP: Effets secondaires des médicaments']")]
        public IWebElement LifetylDismansticking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stress et sclérose en plaques']")]
        public IWebElement LifetylDismanstopsmk { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Surmonter les obstacles courants liés au traitement contre le psoriasis']")]
        public IWebElement LifetylDismanstroke { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[140]")]
        public IWebElement LifetylDismanstroke1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[141]")]
        public IWebElement LifetylDismanstroke2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Troubles de la vue : comment y remédier?']")]
        public IWebElement LifetylDismantalking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Ulcères peptiques']")]
        public IWebElement LifetylDismantalking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Un coeur en bonne santé']")]
        public IWebElement LifetylDismanthe { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Un sommeil de qualité']")]
        public IWebElement LifetylDismanthegreat { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Une bonne acuité auditive']")]
        public IWebElement LifetylDismanthepersonal { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Une infection à levures, ou...?']")]
        public IWebElement LifetylDismanthroid { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Une saine alimentation et la SP']")]
        public IWebElement LifetylDismanthroid1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Une vie active']")]
        public IWebElement LifetylDismantop10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vaccin contre le VPH']")]
        public IWebElement LifetylDismantravel { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Verrues génitales et VPH']")]
        public IWebElement LifetylDismantreating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vie saine en mode diabète']")]
        public IWebElement LifetylDismanwest { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Virus du Nil occidental']")]
        public IWebElement LifetylDismanwhat { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vitamines, minéraux et SP']")]
        public IWebElement LifetylDismanwhat1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vivre avec le psoriasis']")]
        public IWebElement LifetylDismanwhen { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vos vaisseaux sanguins: en santé pour la vie']")]
        public IWebElement LifetylDismanworkout { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Votre guide de survie en cas de « mauvais rhume, journée occupée »']")]
        public IWebElement LifetylDismanyeast { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Votre santé oculaire']")]
        public IWebElement LifetylDismanyoucan { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Votre traitement: engagement à long terme']")]
        public IWebElement LifetylDismanyouand { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[160]")]
        public IWebElement LifetylDismanyouyour { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vous êtes sur le point de renoncer au tabac? Votre pharmacien peut vous aider']")]
        public IWebElement LifetylDismanyourbad { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vous pouvez maîtriser votre MII!']")]
        public IWebElement LifetylDismanyourvessels { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vous, votre médecin et vos taux de cholestérol']")]
        public IWebElement LifetylDismanyourcholesterol { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Voyager avec la SP']")]
        public IWebElement LifetylDismanyourheart { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Voyager en avion pendant la saison de la grippe']")]
        public IWebElement LifetylDismanyourtreatment { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='VPH: Au bureau du médecin']")]
        public IWebElement LifetylDismanyourtreatment1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='VPH: Faits et mythes']")]
        public IWebElement LifetylDismanyourtreatment2 { get; set; }

        //LifestyleDEI
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Diversité et inclusion']")]
        public IWebElement LifetylDEI { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Les initiatives favorisant la diversité et l')]")]
        public IWebElement LifetylDEI2LGBT { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie/diversite-et-inclusion'][text()='Diversité et inclusion']")]
        public IWebElement LifetylDEITag { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[1]")]
        public IWebElement LifetylDEILGBworkplace { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Création d’espaces sûrs']")]
        public IWebElement LifetylDEIageism { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Être antiraciste']")]
        public IWebElement LifetylDEIallies { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face à la transphobie']")]
        public IWebElement LifetylDEIanti { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Inclusion des personnes 2SLGBTQ+ en milieu de travail'])[1]")]
        public IWebElement LifetylDEIbeing { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Inclusion des personnes 2SLGBTQ+ en milieu de travail'])[2]")]
        public IWebElement LifetylDEIbiological { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’âgisme']")]
        public IWebElement LifetylDEIbuilding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’alliance inclusive dans les milieux de vie et de travail']")]
        public IWebElement LifetylDEIcoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’incidence du racisme sur la santé et les traumatismes intergénérationnels']")]
        public IWebElement LifetylDEIcoming1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='l’intersectionnalité']")]
        public IWebElement LifetylDEIcreating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La dotation en personnel dans des milieux de travail multigénérationnels']")]
        public IWebElement LifetylDEIcritical { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La religion sur le lieu de travail']")]
        public IWebElement LifetylDEIengaging { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé sexuelle et génésique']")]
        public IWebElement LifetylDEIForms { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La théorie critique de la race']")]
        public IWebElement LifetylDEIgender { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La transition sexuelle']")]
        public IWebElement LifetylDEIimmigrant { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le genre']")]
        public IWebElement LifetylDEIimmigrant1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Impacts of Racism on Health and Intergenerational Trauma']")]
        public IWebElement LifetylDEIimpacts { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le genre : ce qu’il faut savoir']")]
        public IWebElement LifetylDEIimpl { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le langage inclusif en milieu de travail']")]
        public IWebElement LifetylDEIinc { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le privilège blanc : Comment fonctionne le privilège racial']")]
        public IWebElement LifetylDEIindi { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le racisme anti-asiatique et la xénophobie']")]
        public IWebElement LifetylDEIindi1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le racisme systémique']")]
        public IWebElement LifetylDEIinter { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les employé·e·s immigrant·e·s qui s’établissent en Amérique du Nord'])[1]")]
        public IWebElement LifetylDEImicro { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les employé·e·s immigrant·e·s qui s’établissent en Amérique du Nord'])[2]")]
        public IWebElement LifetylDEInavi { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les microagressions : comment les gérer et que faire si vous en êtes coupable']")]
        public IWebElement LifetylDEIrace { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les partis pris implicites']")]
        public IWebElement LifetylDEIreligion { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les peuples autochtones : un aperçu canadien']")]
        public IWebElement LifetylDEIresi { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les peuples autochtones et les traumatismes']")]
        public IWebElement LifetylDEIsex { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les types de privilège']")]
        public IWebElement LifetylDEIsocial { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Promouvoir la conscience raciale au sein de l’organisation']")]
        public IWebElement LifetylDEIsupporting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Race et ethnicité : le climat actuel']")]
        public IWebElement LifetylDEISys { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Révéler son identité sexuelle']")]
        public IWebElement LifetylDEIunder { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sensibiliser les entreprises aux personnes racisées et au racisme : l’histoire du racisme']")]
        public IWebElement LifetylDEIwebinar { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir votre collègue qui affirme son identité']")]
        public IWebElement LifetylDEIwhite { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Tombes des pensionnats']")]
        public IWebElement LifetylDEIworkplace { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire : Inclusion et sentiment d’appartenance en milieu de travail']")]
        public IWebElement LifetylDEIworkplace1 { get; set; }


        //LifestyleEmployeeNewsletters

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Bulletin pour employés']")]
        public IWebElement LifetylEmpNews { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Peu de choses ont une plus grande incidence sur la')]")]
        public IWebElement LifetylEmpNews10steps { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie/lignes-de-vie'][text()='Bulletin pour employés']")]
        public IWebElement LifetylEmpNewstag { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Aperçu des liens entre stress, diabète, alimentation et santé mentale'])[1]")]
        public IWebElement LifetylEmpNews360 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Aperçu des liens entre stress, diabète, alimentation et santé mentale'])[2]")]
        public IWebElement LifetylEmpNewsaddiction { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Bâtissez l’avenir que vous méritez']")]
        public IWebElement LifetylEmpNewsavoiding { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[4]")]
        public IWebElement LifetylEmpNewsbacktoschool { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[5]")]
        public IWebElement LifetylEmpNewsburnout { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[6]")]
        public IWebElement LifetylEmpNewschildern { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Collaboration adaptée aux traumatismes'])[1]")]
        public IWebElement LifetylEmpNewscompassion { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Collaboration adaptée aux traumatismes'])[2]")]
        public IWebElement LifetylEmpNewscoping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment combattre la déprime d’après les fêtes']")]
        public IWebElement LifetylEmpNewscreating { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Comment être une personne alliée'])[1]")]
        public IWebElement LifetylEmpNewscreating1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Comment être une personne alliée'])[2]")]
        public IWebElement LifetylEmpNewscreating2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer son stress et concilier travail et vie personnelle']")]
        public IWebElement LifetylEmpNewsdealing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Comment offrir du soutien aux enfants qui s’identifient comme LGBTQ2+']")]
        public IWebElement LifetylEmpNewsencouraging { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre la dépression']")]
        public IWebElement LifetylEmpNewsfinancial { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre la santé mentale et la maladie mentale']")]
        public IWebElement LifetylEmpNewshealing { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Comprendre, faire face et aider'])[1]")]
        public IWebElement LifetylEmpNewshealing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Comprendre, faire face et aider'])[2]")]
        public IWebElement LifetylEmpNewshealthy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Création d’espaces sûrs']")]
        public IWebElement LifetylEmpNewsholiday { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Créer un équilibre travail-vie personnelle']")]
        public IWebElement LifetylEmpNewshow { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Découvrir les visages de l’anxiété']")]
        public IWebElement LifetylEmpNewshow1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dépendance et rétablissement']")]
        public IWebElement LifetylEmpNewshow2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dix conseils à suivre pour atteindre l’équilibre travail-vie personnelle']")]
        public IWebElement LifetylEmpNewshow3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Donnez le coup d’envoi à votre mieux-être!'])[1]")]
        public IWebElement LifetylEmpNewshow4 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Donnez le coup d’envoi à votre mieux-être!'])[2]")]
        public IWebElement LifetylEmpNewsindi { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Donnez le coup d’envoi à votre mieux-être!'])[3]")]
        public IWebElement LifetylEmpNewsinter { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dysfonction sexuelle et sexomanie']")]
        public IWebElement LifetylEmpNewsinter1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='En quoi consistent les troubles de l’alimentation?']")]
        public IWebElement LifetylEmpNewscbt { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Encourager la conciliation travail-vie personnelle']")]
        public IWebElement LifetylEmpNewskickstart { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Éviter Les Dépendances De Substitution']")]
        public IWebElement LifetylEmpNewskickstart1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire de l’autosoin sa priorité']")]
        public IWebElement LifetylEmpNewskickstart2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face aux traumatismes de l’enfance']")]
        public IWebElement LifetylEmpNewslearning { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gérer la dépression saisonnière']")]
        public IWebElement LifetylEmpNewslgbt { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Guérir les blessures invisibles'])[1]")]
        public IWebElement LifetylEmpNewsmetime { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Guérir les blessures invisibles'])[2]")]
        public IWebElement LifetylEmpNewsmens { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Introduction à la thérapie cognitive-comportementale (TCC)']")]
        public IWebElement LifetylEmpNewsmental { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[36]")]
        public IWebElement LifetylEmpNewsmental1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[37]")]
        public IWebElement LifetylEmpNewsmental2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[38]")]
        public IWebElement LifetylEmpNewsmindful { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’agression et le harcèlement sexuels']")]
        public IWebElement LifetylEmpNewsnavi { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’épuisement professionnel : Définition et solutions']")]
        public IWebElement LifetylEmpNewsnavi1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’importance du sommeil']")]
        public IWebElement LifetylEmpNewspositive { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='L’intersection entre l’identité sexuelle et la santé mentale'])[1]")]
        public IWebElement LifetylEmpNewspreparing { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='L’intersection entre l’identité sexuelle et la santé mentale'])[2]")]
        public IWebElement LifetylEmpNewspreparing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’usure de compassion']")]
        public IWebElement LifetylEmpNewspreparing2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La dépendance : des faits qui font réfléchir']")]
        public IWebElement LifetylEmpNewspreventing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La dépression post-partum']")]
        public IWebElement LifetylEmpNewsptsd { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La dynamique familiale']")]
        public IWebElement LifetylEmpNewsreducing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La pratique quotidienne de la méditation de pleine conscience']")]
        public IWebElement LifetylEmpNewssetting { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La psychologie de la dette'])[1]")]
        public IWebElement LifetylEmpNewssexual { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La psychologie de la dette'])[2]")]
        public IWebElement LifetylEmpNewssexual1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La rentrée peut être synonyme de changements importants']")]
        public IWebElement LifetylEmpNewssix { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé mentale des étudiants*']")]
        public IWebElement LifetylEmpNewsstigma { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé mentale des femmes : préoccupations, obstacles et soutien']")]
        public IWebElement LifetylEmpNewsstudent { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé mentale des hommes']")]
        public IWebElement LifetylEmpNewssuicide { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé mentale des jeunes : technologie et cyberintimidation']")]
        public IWebElement LifetylEmpNewssupporting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le santé mentale des femmes']")]
        public IWebElement LifetylEmpNewssupporting1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le stress financier']")]
        public IWebElement LifetylEmpNewsteaching { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le TSPT au travail: Solutions et Soutien']")]
        public IWebElement LifetylEmpNewsteaching1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les blessures invisibles des troubles de santé mentale']")]
        public IWebElement LifetylEmpNewsteaching2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les conséquences des traumatismes et de l’adversité sur la santé mentale']")]
        public IWebElement LifetylEmpNewsimpact { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les conséquences des traumatismes et de l’adversité sur la santé mentale (Écouter)']")]
        public IWebElement LifetylEmpNewsimpact1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les conséquences des traumatismes et de l’adversité sur la santé mentale (Vidéo)']")]
        public IWebElement LifetylEmpNewsimpact2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[63]//div[1]//div[1]//div[1]//div[1]//span[1]")]
        public IWebElement LifetylEmpNewsimpact3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[64]//div[1]//div[1]//div[1]//div[1]//span[1]")]
        public IWebElement LifetylEmpNewsimpact4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les LGBTQ+ et la santé mentale']")]
        public IWebElement LifetylEmpNewsimpact5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les nombreuses facettes de l’anxiété']")]
        public IWebElement LifetylEmpNewsimportance { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les nombreux visages du TSPT']")]
        public IWebElement LifetylEmpNewsintersection { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les peuples autochtones et les traumatismes']")]
        public IWebElement LifetylEmpNewsintersection1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les vacances : se relaxer, se revigorer, se retrouver']")]
        public IWebElement LifetylEmpNewsinvisible { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Leur influence positive sur la santé mentale et le rétablissement de la toxicomanie']")]
        public IWebElement LifetylEmpNewsmanyfaces { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mesures pour recouvrer la santé mentale']")]
        public IWebElement LifetylEmpNewsmanyptsd { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mettez de l’ordre dans vos finances et réduisez votre niveau de stress']")]
        public IWebElement LifetylEmpNewspsychology { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Préparer votre entreprise à l’après-pandémie'])[1]")]
        public IWebElement LifetylEmpNewspsychology1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Préparer votre entreprise à l’après-pandémie'])[2]")]
        public IWebElement LifetylEmpNewsobering { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Préparer votre entreprise à l’après-pandémie'])[3]")]
        public IWebElement LifetylEmpNewstrauma { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Prévenir l’épuisement professionnel']")]
        public IWebElement LifetylEmpNewstrauma1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[77]")]
        public IWebElement LifetylEmpNewsuncovering { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[78]")]
        public IWebElement LifetylEmpNewsunderstanding { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Promouvoir l’inclusivité et le langage inclusif'])[1]")]
        public IWebElement LifetylEmpNewsunderstanding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Promouvoir l’inclusivité et le langage inclusif'])[2]")]
        public IWebElement LifetylEmpNewsvacation { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Promouvoir l’inclusivité et le langage inclusif'])[3]")]
        public IWebElement LifetylEmpNewswhen { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quand on craint l’inconnu : faire face à l’incertitude']")]
        public IWebElement LifetylEmpNewswhen1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quand un être cher est atteint de la maladie d’alzheimer ou de démence']")]
        public IWebElement LifetylEmpNewswomen { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Réduire le stress du temps des fêtes']")]
        public IWebElement LifetylEmpNewswomen1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Réduire le stress professionnel en six étapes']")]
        public IWebElement LifetylEmpNeewwomen2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Se fixer des limites protectrices pour un temps des fêtes sans stress']")]
        public IWebElement LifetylEmpNewswomen3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les premiers intervenants*']")]
        public IWebElement LifetylEmpNewswomen4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir un ex-toxicomane* pendant les fêtes']")]
        public IWebElement LifetylEmpNewswomen5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stigmatisation et toxicomanie']")]
        public IWebElement LifetylEmpNewswomen6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stress – Viser l’équilibre']")]
        public IWebElement LifetylEmpNewswomen7 { get; set; }

        //LifestyleFitness

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Condition physique']")]
        public IWebElement LifetylFitness { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Accident vasculaire cérébral']")]
        public IWebElement LifetylFitarth { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie/condition-physique'][text()='Condition physique']")]
        public IWebElement LifetylFittag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Blessures sportives']")]
        public IWebElement LifetylFitens { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cessez de fumer et retrouvez votre liberté!']")]
        public IWebElement LifetylFitgetting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment améliorer votre forme physique']")]
        public IWebElement LifetylFithead { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment améliorer votre sommeil']")]
        public IWebElement LifetylFithealthy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment changer une habitude']")]
        public IWebElement LifetylFithowto { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment tirer le maximum de vos médicaments']")]
        public IWebElement LifetylFitidentify { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Compléments alimentaires']")]
        public IWebElement LifetylFitimproving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre les troubles alimentaires : une approche compatissante pour accroître la sensibilisation et offrir du soutien']")]
        public IWebElement LifetylFitlearning { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[9]")]
        public IWebElement LifetylFitlinking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’amélioration personnelle : prendre soin de soi et de sa santé']")]
        public IWebElement LifetylFitlooking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé en voyage']")]
        public IWebElement LifetylFitnut { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le lien entre l’exercice et la nutrition et la bonne santé mentale']")]
        public IWebElement LifetylFitpain { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le sommeil, c’est la santé']")]
        public IWebElement LifetylFitresilience { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les sièges de tension']")]
        public IWebElement LifetylFitselfcare { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maux de tête']")]
        public IWebElement LifetylFitseniors { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pour la santé de votre cœur']")]
        public IWebElement LifetylFitsleep { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Régime alimentaire et forme physique dans les médias sociaux']")]
        public IWebElement LifetylFitsmoke { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Régime et forme physique dans les médias sociaux']")]
        public IWebElement LifetylFitsocial { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Santé des aînés']")]
        public IWebElement LifetylFitsocial1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutien à l’abandon du tabac']")]
        public IWebElement LifetylFitsports { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vieillir en santé']")]
        public IWebElement LifetylFitstop { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[24]")]
        public IWebElement LifetylFitstroke { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vivre avec une maladie physique chronique']")]
        public IWebElement LifetylFittravel { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Voir le bon côté des choses… en plein air']")]
        public IWebElement LifetylFitunderstanding { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[27]")]
        public IWebElement LifetylFitundefstanding1 { get; set; }
   

        //LifestyleHealthandwellness
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Santé et bien-être']")]
        public IWebElement Lifetylheawell { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[@class='title']")]
        public IWebElement Lifetylheawellchild { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie/sante-et-bien-etre'][text()='Santé et bien-être']")]
        public IWebElement Lifetylheawelltag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='À propos de la polyarthrite rhumatoïde']")]
        public IWebElement Lifetylheawellcreating { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[2]")]
        public IWebElement Lifetylheawelleating { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[3]")]
        public IWebElement Lifetylheawelleye { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Blessures sportives']")]
        public IWebElement Lifetylheawellfaq { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cesser de fumer : En voie de rétablissement']")]
        public IWebElement Lifetylheawellhand { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre la santé mentale et la maladie mentale']")]
        public IWebElement Lifetylheawellsani { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[7]")]
        public IWebElement Lifetylheawellheadaches { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[8]")]
        public IWebElement Lifetylheawellholidays { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Créer un équilibre travail-vie personnelle']")]
        public IWebElement Lifetylheawellcbt { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dépression saisonnière et pensées toxiques']")]
        public IWebElement Lifetylheawelllearn { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Désinfectant pour les mains : un guide']")]
        public IWebElement Lifetylheawelllearn1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire de l’autosoin sa priorité']")]
        public IWebElement Lifetylheawellliving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='FAQ sur les allergies et les médicaments']")]
        public IWebElement Lifetylheawellmaking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Hygiène des mains : se protéger et protéger les autres de la COVID-19']")]
        public IWebElement Lifetylheawellmental { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Infections transmissibles sexuellement']")]
        public IWebElement Lifetylheawellms { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Introduction à la thérapie cognitive-comportementale (TCC)']")]
        public IWebElement Lifetylheawellorgan { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La désaccoutumance au tabac']")]
        public IWebElement Lifetylheawellpain { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La douleur']")]
        public IWebElement Lifetylheawellquit { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La dynamique familiale']")]
        public IWebElement Lifetylheawellquit1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[20]")]
        public IWebElement Lifetylheawelltrans { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[21]")]
        public IWebElement Lifetylheawellsleep { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maux de tête']")]
        public IWebElement Lifetylheawellsmoking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Social Media Diet and Fitness']")]
        public IWebElement Lifetylheawellsocial { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Obésité infantile']")]
        public IWebElement Lifetylheawellsports { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Perte de poids']")]
        public IWebElement Lifetylheawellsun { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pour une bonne nuit de sommeil']")]
        public IWebElement Lifetylheawellsun1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Protégez-vous contre le soleil']")]
        public IWebElement Lifetylheawellrole { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Prudence au soleil']")]
        public IWebElement Lifetylheawellwinter { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Prudence au soleil']")]
        public IWebElement Lifetylheawelltoo { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Rester actif malgré la sclérose en plaques']")]
        public IWebElement Lifetylheawelltoo1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Trop de temps d’écran : effets sur la santé mentale et façons d’y remédier']")]
        public IWebElement Lifetylheawelltoo2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Trop de temps d’écran?'])[1]")]
        public IWebElement Lifetylheawellunderstanding { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Trop de temps d’écran?'])[2]")]
        public IWebElement Lifetylheawellunderstanding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[33]")]
        public IWebElement Lifetylheawellunderstanding2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Votre santé oculaire']")]
        public IWebElement Lifetylheawellunderstanding3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vous êtes sur le point de renoncer au tabac? Votre pharmacien peut vous aider']")]
        public IWebElement Lifetylheawellweight { get; set; }

        //LifestyleMentalHealth

        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie/sante-mentale'][text()='Santé mentale']")]
        public IWebElement Lifetylmentalhealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='360 degrés de santé mentale']")]
        public IWebElement Lifetylmenhea { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie/sante-mentale'][text()='Santé mentale']")]
        public IWebElement Lifetylmenheatag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Aborder la maladie mentale']")]
        public IWebElement Lifetylmenhea360 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Aller au-delà de l’anxiété']")]
        public IWebElement Lifetylmenheastress { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Améliorer son estime de soi']")]
        public IWebElement Lifetylmenheaadapting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Au-delà de la stigmatisation']")]
        public IWebElement Lifetylmenheaami { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Avoir une relation de couple saine tout en préservant son individualité']")]
        public IWebElement Lifetylmenheabeyond { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cessez de vouloir trop en faire']")]
        public IWebElement Lifetylmenheabody { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment abandonner ses mauvaises habitudes']")]
        public IWebElement Lifetylmenheabreak { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment augmenter votre confiance en vous']")]
        public IWebElement Lifetylmenheabreathe { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment changer une habitude']")]
        public IWebElement Lifetylmenheabuilding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment combattre la déprime d’après les fêtes']")]
        public IWebElement Lifetylmenheabuilding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment conserver vos sentiments amoureux']")]
        public IWebElement Lifetylmenheachild { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment éviter de réagir de façon excessive']")]
        public IWebElement Lifetylmenheachild1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer la perte de son emploi']")]
        public IWebElement Lifetylmenheaconnecting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer le deuil']")]
        public IWebElement Lifetylmenheacoping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer son stress et concilier travail et vie personnelle']")]
        public IWebElement Lifetylmenheacoping1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment jouir d’un bon sommeil']")]
        public IWebElement Lifetylmenheadealing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser sa colère']")]
        public IWebElement Lifetylmenheadealing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment parler à ses enfants de santé mentale et de toxicomanie']")]
        public IWebElement Lifetylmenheadealing2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment réduire le stress des fêtes']")]
        public IWebElement Lifetylmenheaedeveloping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment s’adapter au changement']")]
        public IWebElement Lifetylmenheaefin { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment saisir la chance de vous exprimer']")]
        public IWebElement Lifetylmenheaefinding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment se maintenir en bonne santé psychologique']")]
        public IWebElement Lifetylmenheaegetting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre la dépression']")]
        public IWebElement Lifetylmenheaegoing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre la santé mentale et la maladie mentale']")]
        public IWebElement Lifetylmenheahealthy { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[25]")]
        public IWebElement Lifetylmenheaholiday { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Découvrir les visages de l’anxiété']")]
        public IWebElement Lifetylmenheahow { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Déveloper la résilience']")]
        public IWebElement Lifetylmenheahow1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dix conseils à suivre pour atteindre l’équilibre travail-vie personnelle']")]
        public IWebElement Lifetylmenheahow2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Donnez le coup d’envoi à votre mieux-être!'])[1]")]
        public IWebElement Lifetylmenheahow3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Donnez le coup d’envoi à votre mieux-être!'])[2]")]
        public IWebElement Lifetylmenheahow4 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Donnez le coup d’envoi à votre mieux-être!'])[3]")]
        public IWebElement Lifetylmenheahumour { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='En quoi consistent les troubles de l’alimentation?']")]
        public IWebElement Lifetylmenheaidentify { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Est-ce que je souffre de dépression?']")]
        public IWebElement Lifetylmenheaimp { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face à la dépression']")]
        public IWebElement Lifetylmenheaindi { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Gérer la dépression saisonnière'])[1]")]
        public IWebElement Lifetylmenheajune { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Gérer la dépression saisonnière'])[2]")]
        public IWebElement Lifetylmenheakeeping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Information et consultation juridiques']")]
        public IWebElement Lifetylmenheakickstart { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Juin est le mois national de sensibilisation au trouble de stress post-traumatique']")]
        public IWebElement Lifetylmenheakickstart1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[39]")]
        public IWebElement Lifetylmenheakickstart2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[40]")]
        public IWebElement Lifetylmenhealearning { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='L’agression et le harcèlement sexuels'])[1]")]
        public IWebElement Lifetylmenhealearning1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='L’agression et le harcèlement sexuels'])[2]")]
        public IWebElement Lifetylmenhealegal { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’importance d’être en lien avec la collectivité']")]
        public IWebElement Lifetylmenhealgbtq { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’importance de la détente']")]
        public IWebElement Lifetylmenhealooking { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='L’importance du sommeil'])[1]")]
        public IWebElement Lifetylmenheamaintaining { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='L’importance du sommeil'])[2]")]
        public IWebElement Lifetylmenheamaintaining1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La biologie de notre « horloge interne »']")]
        public IWebElement Lifetylmenheamanaging { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[48]")]
        public IWebElement Lifetylmenheametime { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La dynamique familiale'])[1]")]
        public IWebElement Lifetylmenheamenmental { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='La dynamique familiale'])[2]")]
        public IWebElement Lifetylmenheamenillness { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La gestion du stress en milieu de travail']")]
        public IWebElement Lifetylmenheamenmindfulness { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La pratique quotidienne de la méditation de pleine conscience']")]
        public IWebElement Lifetylmenheamenmoving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La résilience']")]
        public IWebElement Lifetylmenheamennavigate { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La respiration détendue']")]
        public IWebElement Lifetylmenheamenpho { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​La santé mentale des enfants et des adolescents*']")]
        public IWebElement Lifetylmenheamenover { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé mentale des étudiants*']")]
        public IWebElement Lifetylmenheamenpositive { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé mentale des femmes']")]
        public IWebElement Lifetylmenheamenpreparing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé mentale des hommes']")]
        public IWebElement Lifetylmenheamenptsd { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé mentale des jeunes : technologie et cyberintimidation']")]
        public IWebElement Lifetylmenheamenracial { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La séparation et le divorce']")]
        public IWebElement Lifetylmenheamenraising { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La thérapie par l’humour et le pouvoir du rire']")]
        public IWebElement Lifetylmenheamenreenergizing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La visualisation']")]
        public IWebElement Lifetylmenheamenreducing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le décès d’un proche']")]
        public IWebElement Lifetylmenheamenreducing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le lien qui existe entre la commotion cérébrale et la dépression']")]
        public IWebElement Lifetylmenheamenresilience { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le mieux-être durant la période des Fêtes']")]
        public IWebElement Lifetylmenheamenresposible { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le pouvoir bienfaisant d’une bonne action']")]
        public IWebElement Lifetylmenheamensepa { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le pouvoir d’une attitude positive']")]
        public IWebElement Lifetylmenheamensexual { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le santé mentale des femmes']")]
        public IWebElement Lifetylmenheamensexual1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le sommeil, c’est la santé']")]
        public IWebElement Lifetylmenheamenshift { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[71]")]
        public IWebElement Lifetylmenheasleep { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le travail par quarts']")]
        public IWebElement Lifetylmenheasomeone { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le TSPT au travail: Solutions et Soutien']")]
        public IWebElement Lifetylmenheasomeone1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les blessures invisibles des troubles de santé mentale']")]
        public IWebElement Lifetylmenheasomeone2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les composantes de la colère?']")]
        public IWebElement Lifetylmenheaspotting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les défis du travail par quarts']")]
        public IWebElement Lifetylmenheastop { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les LGBTQ+ et la santé mentale']")]
        public IWebElement Lifetylmenheastress1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les nombreuses facettes de l’anxiété']")]
        public IWebElement Lifetylmenheastudent { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les nombreux visages du TSPT']")]
        public IWebElement Lifetylmenheasupporting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les peuples autochtones et les traumatismes']")]
        public IWebElement Lifetylmenheasupporting1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les risques des médias sociaux pour votre santé mentale']")]
        public IWebElement Lifetylmenheasupporting2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les sièges de tension']")]
        public IWebElement Lifetylmenheasurviving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les vacances : se relaxer, se revigorer, se retrouver']")]
        public IWebElement Lifetylmenheasurviving1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Leur influence positive sur la santé mentale et le rétablissement de la toxicomanie']")]
        public IWebElement Lifetylmenheasurviving2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maîtrisez votre stress avant qu’il ne soit trop tard!']")]
        public IWebElement Lifetylmenheataking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mesures pour recouvrer la santé mentale']")]
        public IWebElement Lifetylmenheataking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[87]")]
        public IWebElement Lifetylmenheataking2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pour en finir avec les mythes sur la maladie mentale!']")]
        public IWebElement Lifetylmenheataking3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Préserver sa santé mentale et physique pendant le temps des Fêtes']")]
        public IWebElement Lifetylmenheatalking { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[90]")]
        public IWebElement Lifetylmenheathe { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Qu’est-ce que la pleine conscience et comment la pratiquer?']")]
        public IWebElement Lifetylmenheathe1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quand un proche est gravement malade']")]
        public IWebElement Lifetylmenheathe2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quand un proche se suicide']")]
        public IWebElement Lifetylmenheathe3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Réduire la stigmatisation entourant les problèmes de santé mentale']")]
        public IWebElement Lifetylmenheathe4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Réduire le stress du temps des fêtes']")]
        public IWebElement Lifetylmenheathe5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Refaire ses forces pour la nouvelle année']")]
        public IWebElement Lifetylmenheathe6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Résilience']")]
        public IWebElement Lifetylmenheathe7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Santé financière et santé mentale']")]
        public IWebElement Lifetylmenheathe8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Se préparer pour la nouvelle année en cultivant sa santé mentale']")]
        public IWebElement Lifetylmenheathe9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Signes précurseurs du suicide']")]
        public IWebElement Lifetylmenheatoo { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les premiers intervenants*']")]
        public IWebElement Lifetylmenheauncovering { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir un ex-toxicomane* pendant les fêtes']")]
        public IWebElement Lifetylmenheaunder1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[103]")]
        public IWebElement Lifetylmenheaunder2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutien aux travailleurs de quarts']")]
        public IWebElement Lifetylmenheaunder3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stress']")]
        public IWebElement Lifetylmenheaunder4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Surmonter la déprime de l’hiver']")]
        public IWebElement Lifetylmenheaunder5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Surmonter les défis de Septembre']")]
        public IWebElement Lifetylmenheavacation { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Surmonter ses phobies']")]
        public IWebElement Lifetylmenheavis { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Survivre à un Septembre'])[1]")]
        public IWebElement Lifetylmenheawellness { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Survivre à un Septembre'])[2]")]
        public IWebElement Lifetylmenheawhat { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Traumatisme racial']")]
        public IWebElement Lifetylmenheawhat1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Trop de temps d’écran?']")]
        public IWebElement Lifetylmenheawhen { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Trouver la force de pardonner']")]
        public IWebElement Lifetylmenheawomen { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Violence sexuelle pendant l’enfance']")]
        public IWebElement Lifetylmenheawomen1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vivre au quotidien le recouvrement de sa santé mentale']")]
        public IWebElement Lifetylmenheaworking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Voir le bon côté des choses… en plein air']")]
        public IWebElement Lifetylmenheayou { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vous venez de vivre un évènement pénible']")]
        public IWebElement Lifetylmenheayouth { get; set; }

        //LifestyleNutritionGeneralFitness

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Nutrition et condition physique générale']")]
        public IWebElement LifestyleNutritionGeneralFitness { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Les r&eacute;solutions de &laquo; sant&eacute; car')]")]
        public IWebElement LifestyleNut { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/nutrition-et-condition-physique-generale'][text()='Nutrition et condition physique générale']")]
        public IWebElement LifestyleNuttag { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[1]")]
        public IWebElement LifestyleNut12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()=' Infertilité : faire pencher la balance en votre faveur']")]
        public IWebElement LifestyleNut4 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[3]")]
        public IWebElement LifestyleNut5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()=' Le poisson : nutrition et salubrité']")]
        public IWebElement LifestyleNut5ways { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()=' Les stérols végétaux : pour combattre le cholestérol naturellement']")]
        public IWebElement LifestyleNut6skin { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[6]")]
        public IWebElement LifestyleNutactive { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()=' Quelques faits concernant le cœur : Sept choses que vous ignoriez']")]
        public IWebElement LifestyleNutaging { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='12 secrets pour une peau lisse et souple']")]
        public IWebElement LifestyleNutair { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='4 étapes pour repartir à neuf après les Fêtes']")]
        public IWebElement LifestyleNutallergies { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='5 façons de faire trêve aux problèmes digestifs']")]
        public IWebElement LifestyleNutallergies1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='6 défauts cutanés trahissent votre âge']")]
        public IWebElement LifestyleNutallergies2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[12]")]
        public IWebElement LifestyleNutallergies3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='À propos de la diarrhée']")]
        public IWebElement LifestyleNutandro { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='À propos de la polyarthrite rhumatoïde']")]
        public IWebElement LifestyleNutanemia { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='À propos des salmonelles']")]
        public IWebElement LifestyleNutarth { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='À votre santé et bon voyage!']")]
        public IWebElement LifestyleNutavoid { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The quality of your sleep depends so much on the q')]")]
        public IWebElement LifestyleNutbed { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Activités physiques intérieures pour les aînés']")]
        public IWebElement LifestyleNutbreast { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Allergie alimentaire ? Ennemi alimentaire ?']")]
        public IWebElement LifestyleNutcaring { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Allergies et maternité']")]
        public IWebElement LifestyleNutceleb { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Allergies médicamenteuses']")]
        public IWebElement LifestyleNutchild { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[21]")]
        public IWebElement LifestyleNutchoosing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Bien manger pendant la période des Fêtes']")]
        public IWebElement LifestyleNutcommon { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cesser de fumer']")]
        public IWebElement LifestyleNutconstipation { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cesser de fumer : En voie de rétablissement']")]
        public IWebElement LifestyleNutcooking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Choisir les bonnes chaussures']")]
        public IWebElement LifestyleNutcoping { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[26]")]
        public IWebElement LifestyleNutcrack { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Clinique de fertilité - FAQ']")]
        public IWebElement LifestyleNutdand { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment avouer votre incontinence à votre partenaire']")]
        public IWebElement LifestyleNutdealing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment changer une habitude']")]
        public IWebElement LifestyleNutdental { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment faire face à un avortement spontané']")]
        public IWebElement LifestyleNutdetox { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment laisser resplendir sa beauté en été']")]
        public IWebElement LifestyleNutdiarr { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maintenir une relation saine avec la nourriture']")]
        public IWebElement LifestyleNutdont { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment participer à la recherche']")]
        public IWebElement LifestyleNutdreams { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment renforcer vos défenses']")]
        public IWebElement LifestyleNutdrug { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment un adulte peut maintenir sa vaccination à jour']")]
        public IWebElement LifestyleNuteat { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Compléments alimentaires']")]
        public IWebElement LifestyleNuteating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre les troubles alimentaires : une approche compatissante pour accroître la sensibilisation et offrir du soutien']")]
        public IWebElement LifestyleNuteating1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[39]")]
        public IWebElement LifestyleNuteating2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Constipation']")]
        public IWebElement LifestyleNuteczema { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[41]")]
        public IWebElement LifestyleNutensure { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Courir... pour la vie !']")]
        public IWebElement LifestyleNuterectile { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[43]")]
        public IWebElement LifestyleNuterectile1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Découvrez comment 4 traitements pour le visage agissent vraiment']")]
        public IWebElement LifestyleNutexfol { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Démangeaisons, frémissements, chatouille et déclics']")]
        public IWebElement LifestyleNuteye { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Détoxication: ce que vous devez savoir']")]
        public IWebElement LifestyleNutfad { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Donner un nouveau look à votre chambre à coucher : en faire un sanctuaire du sommeil']")]
        public IWebElement LifestyleNutfaq { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dormir une nuit complète malgré le rhume et les allergies']")]
        public IWebElement LifestyleNutfert { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dysfonction érectile: mythes et réalités']")]
        public IWebElement LifestyleNutfert1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Entraînez votre cœur']")]
        public IWebElement LifestyleNutfin { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Essayer de devenir enceinte, ça me stresse au plus haut point!']")]
        public IWebElement LifestyleNutfish { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[52]")]
        public IWebElement LifestyleNutfood { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='FAQ sur les allergies et les médicaments']")]
        public IWebElement LifestyleNutfood1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='FAQ sur les pellicules']")]
        public IWebElement LifestyleNutfood2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Garder la forme']")]
        public IWebElement LifestyleNutfoot { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gardez un sourire éclatant de santé!']")]
        public IWebElement LifestyleNutget { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[57]")]
        public IWebElement LifestyleNutgetting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Hygiène des mains : se protéger et protéger les autres de la COVID-19']")]
        public IWebElement LifestyleNutgetting1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Interventions dentaires']")]
        public IWebElement LifestyleNuthand { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Joie et santé pour le temps des Fêtes!']")]
        public IWebElement LifestyleNuthand1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[61]")]
        public IWebElement LifestyleNuthappy { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[62]")]
        public IWebElement LifestyleNuthealthy { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[63]")]
        public IWebElement LifestyleNuthealthy1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[64]")]
        public IWebElement LifestyleNuthealthy2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[65]")]
        public IWebElement LifestyleNutholidays { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[66]")]
        public IWebElement LifestyleNutheart { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[67]")]
        public IWebElement LifestyleNuthow { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[68]")]
        public IWebElement LifestyleNuthow1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’influence du sommeil sur la santé']")]
        public IWebElement LifestyleNuthow2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La désaccoutumance au tabac']")]
        public IWebElement LifestyleNuthow3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La fertilité et votre vie sexuelle']")]
        public IWebElement LifestyleNuthow4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La nutrition']")]
        public IWebElement LifestyleNutincr { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La nutrition et la bonne forme physique']")]
        public IWebElement LifestyleNutindoor { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé du sein']")]
        public IWebElement LifestyleNutinfer { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La santé se prépare dans la cuisine']")]
        public IWebElement LifestyleNutinfer1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Lavage des mains : un guide']")]
        public IWebElement LifestyleNutinfer2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le b.a-ba de la médecine intégrative']")]
        public IWebElement LifestyleNutinteg { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le futur des soins de santé primaires']")]
        public IWebElement LifestyleNutitches { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le grand ménage du printemps!']")]
        public IWebElement LifestyleNutjump { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le lait']")]
        public IWebElement LifestyleNutkeep { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le lien entre l’exercice et la nutrition et la bonne santé mentale']")]
        public IWebElement LifestyleNutkeep1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le moment propice à la conception']")]
        public IWebElement LifestyleNutkeep2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le Questionnaire santé']")]
        public IWebElement LifestyleNutkeep3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[84]")]
        public IWebElement LifestyleNutlearn { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le stress et votre corps']")]
        public IWebElement LifestyleNutlearn1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le syndrome prémenstruel : êtes-vous prête?']")]
        public IWebElement LifestyleNutlearn2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le vieillissement cutané et les rides']")]
        public IWebElement LifestyleNutlink { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le yoga : des étirements pour la santé']")]
        public IWebElement LifestyleNutliving { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[89]")]
        public IWebElement LifestyleNutmilk { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les allergies et les plaisirs du plein air']")]
        public IWebElement LifestyleNutmy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les bienfaits des probiotiques']")]
        public IWebElement LifestyleNutmy1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les célébrités et la fertilité']")]
        public IWebElement LifestyleNutnico { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[93]")]
        public IWebElement LifestyleNutnotso { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les défis du travail par quarts']")]
        public IWebElement LifestyleNutnut { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les différents moyens d’endommager ses dents']")]
        public IWebElement LifestyleNutnut1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les étiquettes nutritionnelles, vous les comprenez?']")]
        public IWebElement LifestyleNutnut2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les incontournables de la santé capillaire']")]
        public IWebElement LifestyleNutnut3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les mérites des superaliments']")]
        public IWebElement LifestyleNutohno { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les mesures à prendre pour cesser de fumer']")]
        public IWebElement LifestyleNutoral { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les numéros gagnants pour une peau saine']")]
        public IWebElement LifestyleNutplant { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les petits tracas du voyageur']")]
        public IWebElement LifestyleNutpmp { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les probiotiques et votre intestin']")]
        public IWebElement LifestyleNutpreparing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les probiotiques, qu’est-ce que c’est?']")]
        public IWebElement LifestyleNutpreparing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les raisons pour maintenir une bonne posture']")]
        public IWebElement LifestyleNutprobiotic { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les rêves: les mystères du sommeil']")]
        public IWebElement LifestyleNutprobiotic1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[106]")]
        public IWebElement LifestyleNutquit { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les soins de la peau à 30 ans et plus']")]
        public IWebElement LifestyleNutquit1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les soins des pieds au printemps']")]
        public IWebElement LifestyleNutreduce { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les soins du cuir chevelu suivent les saisons']")]
        public IWebElement LifestyleNutrun { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les vrais et faux du sommeil']")]
        public IWebElement LifestyleNutscalp { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maintenir votre bouche saine en voyage']")]
        public IWebElement LifestyleNutskin { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[112]")]
        public IWebElement LifestyleNutsleep { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Manger sainement sur le pouce']")]
        public IWebElement LifestyleNutsleep1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mangez bien et votre cuir chevelu sera plus beau']")]
        public IWebElement LifestyleNutsmoke { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Mon mieux-être'])[1]")]
        public IWebElement LifestyleNutsocial { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Mon mieux-être'])[2]")]
        public IWebElement LifestyleNutsocial1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[117]")]
        public IWebElement LifestyleNutsocial2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Optimisez vos chances de conception avant les traitements de fécondation']")]
        public IWebElement LifestyleNutstaying { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Parcours mieux-être']")]
        public IWebElement LifestyleNutstaying1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pas encore une infection à levures !']")]
        public IWebElement LifestyleNutstopsmoking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pas si facile de bien dormir']")]
        public IWebElement LifestyleNutstress { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Perte de poids']")]
        public IWebElement LifestyleNutsummer { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pour la santé de votre cœur']")]
        public IWebElement LifestyleNutsummer1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[124]")]
        public IWebElement LifestyleNutsun { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pourquoi a-t-on des allergies?']")]
        public IWebElement LifestyleNuttelling { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Prendre soin des dents sensibles']")]
        public IWebElement LifestyleNutthe1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Préparatifs de coloscopie']")]
        public IWebElement LifestyleNutthe2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Prévention et traitement des allergies']")]
        public IWebElement LifestyleNutthe3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Protégez-vous contre le soleil']")]
        public IWebElement LifestyleNutthe4 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[130]")]
        public IWebElement LifestyleNutthe5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Réduisez votre risque de diabète de type 2']")]
        public IWebElement LifestyleNutthe6 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Régime alimentaire et forme physique dans les médias sociaux'])[1]")]
        public IWebElement LifestyleNutthe7 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Régime alimentaire et forme physique dans les médias sociaux'])[2]")]
        public IWebElement LifestyleNutthe8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Régime et forme physique dans les médias sociaux']")]
        public IWebElement LifestyleNutthy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Régimes à la mode: le poids des lubies !']")]
        public IWebElement LifestyleNuttime { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Rester actif pendant la pandémie de COVID-19']")]
        public IWebElement LifestyleNuttips { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[137]")]
        public IWebElement LifestyleNuttravel { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sachez parler à votre médecin']")]
        public IWebElement LifestyleNutttrying { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Santé du cœur: 10 conseils incontournables']")]
        public IWebElement LifestyleNutunderstand { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Santé financière et santé physique']")]
        public IWebElement LifestyleNutunderstand1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Signes et symptômes oculaires']")]
        public IWebElement LifestyleNutwater { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stockage des aliments et durée de conservation']")]
        public IWebElement LifestyleNutwhat { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Tenir ses résolutions']")]
        public IWebElement LifestyleNutwhat1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[144]")]
        public IWebElement LifestyleNutwhat2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Une vie active']")]
        public IWebElement LifestyleNutwhat3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vaccination des enfants: votre enfant est-il bien protégé?']")]
        public IWebElement LifestyleNutwhy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vers une meilleure alimentation']")]
        public IWebElement LifestyleNutwhy1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[148]")]
        public IWebElement LifestyleNutwinter { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vivre avec la polyarthrite rhumatoïde']")]
        public IWebElement LifestyleNutworkout { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[150]")]
        public IWebElement LifestyleNutwork1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[151]")]
        public IWebElement LifestyleNutwork2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[152]")]
        public IWebElement LifestyleNutyoga { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[153]")]
        public IWebElement LifestyleNutyou { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vos aliments']")]
        public IWebElement LifestyleNutyou1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vos vaisseaux sanguins: en santé pour la vie']")]
        public IWebElement LifestyleNutyour { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[156]")]
        public IWebElement LifestyleNutyour1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Votre été, votre santé']")]
        public IWebElement LifestyleNutyour2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[158]")]
        public IWebElement LifestyleNutyour3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vous êtes sur le point de renoncer au tabac? Votre pharmacien peut vous aider']")]
        public IWebElement LifestyleNutyour4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vous, votre médecin et vos taux de cholestérol']")]
        public IWebElement LifestyleNutyour5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Voyager en avion pendant la saison de la grippe']")]
        public IWebElement LifestyleNutyour6 { get; set; }

        //WorkPlace
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Milieu de travail']")]
        public IWebElement WorkPlace { get; set; }
        [FindsBy(How = How.XPath, Using = "  //section[@class='article-featured']//p[contains(text(),'Il n')] ")]
        public IWebElement WorkPlace10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/milieu-de-travail'][text()='Milieu de travail']")]
        public IWebElement WorkPlacetag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Aller au-delà de l’anxiété']")]
        public IWebElement WorkPlace101 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[2]")]
        public IWebElement WorkPlace2SL { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment améliorer vos compétences en rédaction']")]
        public IWebElement WorkPlaceAres { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment améliorer votre forme physique']")]
        public IWebElement WorkPlaceavoid { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment désamorcer un conflit']")]
        public IWebElement WorkPlacebuild { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment éviter les «10 pires erreurs» en entrevue d’emploi']")]
        public IWebElement WorkPlaceburnout { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Comment faire face à la perte de son emploi'])[1]")]
        public IWebElement WorkPlacecareer { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Comment faire face à la perte de son emploi'])[2]")]
        public IWebElement WorkPlacecoping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer la perte de son emploi']")]
        public IWebElement WorkPlacecreating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer son stress et concilier travail et vie personnelle']")]
        public IWebElement WorkPlacecreating1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment jouir d’un bon sommeil']")]
        public IWebElement WorkPlacecreating2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser sa colère']")]
        public IWebElement WorkPlacedealing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser son humeur']")]
        public IWebElement WorkPlacedealing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser son stress']")]
        public IWebElement WorkPlacedisability { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment prendre sa carrière en main']")]
        public IWebElement WorkPlacedoes { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[16]")]
        public IWebElement WorkPlaceeffect { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment tirer de l’entrevue d’emploi l’information dont vous avez besoin']")]
        public IWebElement WorkPlaceemb { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre et prévenir l’épuisement professionnel?']")]
        public IWebElement WorkPlaceemb1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Conseils de prévention des invalidités au travail']")]
        public IWebElement WorkPlaceeng { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Conseils en gestion d’équipes multigénérationnelles']")]
        public IWebElement WorkPlacefacing { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Dix conseils à suivre pour atteindre l’équilibre travail-vie personnelle'])[1]")]
        public IWebElement WorkPlacegetting { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Dix conseils à suivre pour atteindre l’équilibre travail-vie personnelle'])[2]")]
        public IWebElement WorkPlacegoing { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Dix façons d’intégrer l’activité physique dans votre milieu de travail'])[1]")]
        public IWebElement WorkPlacegoing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Dix façons d’intégrer l’activité physique dans votre milieu de travail'])[2]")]
        public IWebElement WorkPlacegrief { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Entamer une conversation sur la santé mentale']")]
        public IWebElement WorkPlacehealth { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[26]")]
        public IWebElement WorkPlacehelping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face aux congédiements ou aux mises à pied']")]
        public IWebElement WorkPlacehelping1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face aux périodes de changement et de transition au travail']")]
        public IWebElement WorkPlacehow { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Favoriser la santé en milieu de travail']")]
        public IWebElement WorkPlacehow1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Favoriser un milieu de travail sain'])[1]")]
        public IWebElement WorkPlacehow2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Favoriser un milieu de travail sain'])[2]")]
        public IWebElement WorkPlacehow3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Favoriser un milieu de travail sain'])[3]")]
        public IWebElement WorkPlaceimm { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gérer efficacement un déclassement ou une rétrogradation']")]
        public IWebElement WorkPlaceimprove { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Guide à l’intention des personnes transgenres et de genres divers']")]
        public IWebElement WorkPlaceman { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Inclusion des personnes 2SLGBTQ+ en milieu de travail']")]
        public IWebElement WorkPlaceman1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Intégration de mentalités différentes : comment la neurodiversité renforce les milieux de travail']")]
        public IWebElement WorkPlaceman2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’aide aux employés en détresse']")]
        public IWebElement WorkPlacemetime { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’épuisement professionnel : Définition et solutions']")]
        public IWebElement WorkPlacemental { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’importance de la diversité des personnalités']")]
        public IWebElement WorkPlacemod { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La dotation en personnel dans des milieux de travail multigénérationnels']")]
        public IWebElement WorkPlacemod1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La gestion des conflits en milieu de travail']")]
        public IWebElement WorkPlacemov { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La gestion du stress en milieu de travail']")]
        public IWebElement WorkPlaceprep { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La résilience']")]
        public IWebElement WorkPlaceprep1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La visualisation']")]
        public IWebElement WorkPlaceprep2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le deuil en milieu de travail']")]
        public IWebElement WorkPlaceptsd { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le mieux-être psychologique au travail']")]
        public IWebElement WorkPlaceres { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le respect en milieu de travail']")]
        public IWebElement WorkPlaceresp { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le travail après la retraite']")]
        public IWebElement WorkPlaceshift { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le travail doit-il absolument être stressant?']")]
        public IWebElement WorkPlacesteps { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le travail par quarts']")]
        public IWebElement WorkPlacestages { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le TSPT au travail: Solutions et Soutien']")]
        public IWebElement WorkPlacesupport { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les avantages d’un milieu de travail hybride']")]
        public IWebElement WorkPlacesupport1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les blessures invisibles des troubles de santé mentale']")]
        public IWebElement WorkPlacetaking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les composantes de la colère?']")]
        public IWebElement WorkPlacetaking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les défis du travail par quarts']")]
        public IWebElement WorkPlacetaking2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les employé·e·s immigrant·e·s qui s’établissent en Amérique du Nord']")]
        public IWebElement WorkPlacetaking3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les parents au travail']")]
        public IWebElement WorkPlacetaking4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les phases de développement d’une équipe']")]
        public IWebElement WorkPlaceten { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les risques d’aujourd’hui en milieu de travail'])[1]")]
        public IWebElement WorkPlaceten2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les risques d’aujourd’hui en milieu de travail'])[2]")]
        public IWebElement WorkPlaceimportance { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[61]")]
        public IWebElement WorkPlaceinvisible { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Orientation professionnelle']")]
        public IWebElement WorkPlacethe { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[63]")]
        public IWebElement WorkPlacethriving { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Préparer votre entreprise à l’après-pandémie'])[1]")]
        public IWebElement WorkPlacetips { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Préparer votre entreprise à l’après-pandémie'])[2]")]
        public IWebElement WorkPlaceunder { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Préparer votre entreprise à l’après-pandémie'])[3]")]
        public IWebElement WorkPlacevis { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Que faire quand un collègue présente des tendances suicidaires']")]
        public IWebElement WorkPlacewebinar { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='What Causes Anger?']")]
        public IWebElement WorkPlacewhat { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='What to Do If a Co-Worker Is Suicidal']")]
        public IWebElement WorkPlacewhat1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Réduire le stress professionnel en six étapes']")]
        public IWebElement WorkPlaceworking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les collègues neuroatypiques']")]
        public IWebElement WorkPlaceworking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir votre collègue qui affirme son identité']")]
        public IWebElement WorkPlaceworking2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutien aux travailleurs de quarts']")]
        public IWebElement WorkPlaceyou { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stratégies de leadership favorisant la santé']")]
        public IWebElement WorkPlaceyou1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vous venez de vivre un évènement pénible']")]
        public IWebElement WorkPlaceyou2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire : Réduire l’anxiété et gérer la rentrée en temps de pandémie']")]
        public IWebElement WorkPlaceyou3 { get; set; }

        //WorkPlace CareerDevelopment
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Perfectionnement professionnel']")]
        public IWebElement WorkPlaceCD { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'De bonnes habiletés en rédaction sont essentielles')]")]
        public IWebElement WorkPlaceCD1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/milieu-de-travail/perfectionnement-professionnel'][text()='Perfectionnement professionnel']")]
        public IWebElement WorkPlaceCDtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment éviter les «10 pires erreurs» en entrevue d’emploi']")]
        public IWebElement WorkPlaceCD2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment prendre sa carrière en main']")]
        public IWebElement WorkPlaceCD3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[3]")]
        public IWebElement WorkPlaceCD4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment tirer de l’entrevue d’emploi l’information dont vous avez besoin']")]
        public IWebElement WorkPlaceCD5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’épuisement professionnel : Définition et solutions']")]
        public IWebElement WorkPlaceCD6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les avantages d’un milieu de travail hybride']")]
        public IWebElement WorkPlaceCD7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Orientation professionnelle']")]
        public IWebElement WorkPlaceCD8 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[8]")]
        public IWebElement WorkPlaceCD9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Prévenir l’épuisement professionnel']")]
        public IWebElement WorkPlaceCD10 { get; set; }


        //WorkPlaceChangeTransition

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Transition/Changement']")]
        public IWebElement WorkPlaceCT { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'La transition entre une carrière dans les forces a')]")]
        public IWebElement WorkPlaceCT1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/milieu-de-travail/transitionchangement'][text()='Transition/Changement']")]
        public IWebElement WorkPlaceCTtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment faire face à la perte de son emploi']")]
        public IWebElement WorkPlaceCT2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer la perte de son emploi']")]
        public IWebElement WorkPlaceCT3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment puis-je gérer mes sentiments face à l’avenir?']")]
        public IWebElement WorkPlaceCT4 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[4]")]
        public IWebElement WorkPlaceCT5 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Dépression saisonnière et pensées toxiques'])[1]")]
        public IWebElement WorkPlaceCT6 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Dépression saisonnière et pensées toxiques'])[2]")]
        public IWebElement WorkPlaceCT7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face aux périodes de changement et de transition au travail']")]
        public IWebElement WorkPlaceCT8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gérer efficacement un déclassement ou une rétrogradation']")]
        public IWebElement WorkPlaceCT9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La transition vers un milieu de travail civil : guide à l’intention des ex-militaires']")]
        public IWebElement WorkPlaceCT10 { get; set; }

        //Workplace Communication
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Communication']")]
        public IWebElement WorkPlaceComm { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Nous ne sommes pas tous des h&eacute;ros de films ')]")]
        public IWebElement WorkPlaceComm1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/milieu-de-travail/communication'][text()='Communication']")]
        public IWebElement WorkPlaceCommtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Inclusion des personnes 2SLGBTQ+ en milieu de travail']")]
        public IWebElement WorkPlaceComm2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La dotation en personnel dans des milieux de travail multigénérationnels']")]
        public IWebElement WorkPlaceComm3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La gestion des conflits en milieu de travail']")]
        public IWebElement WorkPlaceComm4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le respect en milieu de travail']")]
        public IWebElement WorkPlaceComm5 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les employé·e·s immigrant·e·s qui s’établissent en Amérique du Nord'])[1]")]
        public IWebElement WorkPlaceComm6 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les employé·e·s immigrant·e·s qui s’établissent en Amérique du Nord'])[2]")]
        public IWebElement WorkPlaceComm7 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Promouvoir l’inclusivité et le langage inclusif'])[1]")]
        public IWebElement WorkPlaceComm8 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Promouvoir l’inclusivité et le langage inclusif'])[2]")]
        public IWebElement WorkPlaceComm9 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Promouvoir l’inclusivité et le langage inclusif'])[3]")]
        public IWebElement WorkPlaceComm10 { get; set; }

        //Workplace Fitness

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Condition physique']")]
        public IWebElement WorkPlaceFitness { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Il y a de fortes chances que l’une de vos résoluti')]")]
        public IWebElement WorkPlaceFitness1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/milieu-de-travail/condition-physique'][text()='Condition physique']")]
        public IWebElement WorkPlaceFitnesstag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment jouir d’un bon sommeil']")]
        public IWebElement WorkPlaceFitness2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Dix façons d’intégrer l’activité physique dans votre milieu de travail'])[1]")]
        public IWebElement WorkPlaceFitness3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Dix façons d’intégrer l’activité physique dans votre milieu de travail'])[2]")]
        public IWebElement WorkPlaceFitness4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le travail doit-il absolument être stressant?']")]
        public IWebElement WorkPlaceFitness5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Régime alimentaire et forme physique dans les médias sociaux']")]
        public IWebElement WorkPlaceFitness6 { get; set; }

        //WorkPlaceManagement

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Gestion']")]
        public IWebElement WorkPlacemgmt { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Il n')]")]
        public IWebElement WorkPlacemgmt2SL { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/milieu-de-travail/gestion'][text()='Gestion']")]
        public IWebElement workplacemgmttag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment désamorcer un conflit']")]
        public IWebElement WorkPlacemgmtbuilding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment prendre sa carrière en main']")]
        public IWebElement WorkPlacemgmtcreate { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre et prévenir l’épuisement professionnel?']")]
        public IWebElement WorkPlacemgmtcreate1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Conseils en gestion d’équipes multigénérationnelles']")]
        public IWebElement WorkPlacemgmtdoes { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Encourager la conciliation travail-vie personnelle']")]
        public IWebElement WorkPlacemgmtembracing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Favoriser la santé en milieu de travail']")]
        public IWebElement WorkPlacemgmtembracing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Favoriser un milieu de travail sain'])[1]")]
        public IWebElement WorkPlacemgmtembracing2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Favoriser un milieu de travail sain'])[2]")]
        public IWebElement WorkPlacemgmtencourage { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Inclusion des personnes 2SLGBTQ+ en milieu de travail']")]
        public IWebElement WorkPlacemgmthealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Intégration de mentalités différentes : comment la neurodiversité renforce les milieux de travail']")]
        public IWebElement WorkPlacemgmthelp { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Intégration de mentalités différentes (Audio)']")]
        public IWebElement WorkPlacemgmthelp1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Intégration de mentalités différentes (Vidéo)']")]
        public IWebElement WorkPlacemgmthow { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’aide aux employés en détresse']")]
        public IWebElement WorkPlacemgmtimm { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La gestion du stress en milieu de travail']")]
        public IWebElement WorkPlacemgmtimm1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le respect en milieu de travail']")]
        public IWebElement WorkPlacemgmtwokrplace { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le travail doit-il absolument être stressant?']")]
        public IWebElement WorkPlacemgmtmod { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les avantages d’un milieu de travail hybride'])[1]")]
        public IWebElement WorkPlacemgmtmod1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les avantages d’un milieu de travail hybride'])[2]")]
        public IWebElement WorkPlacemgmtrespect { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les blessures invisibles des troubles de santé mentale']")]
        public IWebElement WorkPlacemgmtstages { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les employé·e·s immigrant·e·s qui s’établissent en Amérique du Nord'])[1]")]
        public IWebElement WorkPlacemgmttalking { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les employé·e·s immigrant·e·s qui s’établissent en Amérique du Nord'])[2]")]
        public IWebElement WorkPlacemgmtthe { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les phases de développement d’une équipe']")]
        public IWebElement WorkPlacemgmtthrive { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les risques d’aujourd’hui en milieu de travail'])[1]")]
        public IWebElement WorkPlacemgmtthrive1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les risques d’aujourd’hui en milieu de travail'])[2]")]
        public IWebElement WorkPlacemgmttips { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stratégies de leadership favorisant la santé']")]
        public IWebElement WorkPlacemgmtunder { get; set; }

        //WorkPlaceMentalHealth

        [FindsBy(How = How.XPath, Using = "//a[@href='/app/fr/resources/category/permalink/milieu-de-travail/sante-mentale']")]
        public IWebElement WorkPlacementalhealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Étiez-vous craintif* dans le noir quand vous étiez')]")]
        public IWebElement WorkPlacemenhealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/milieu-de-travail/sante-mentale'][text()='Santé mentale']")]
        public IWebElement WorkPlacemenhealthtag { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Comment faire face à la perte de son emploi'])[1]")]
        public IWebElement WorkPlacementalhealth1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Comment faire face à la perte de son emploi'])[2]")]
        public IWebElement WorkPlacementalhealth2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer la perte de son emploi']")]
        public IWebElement WorkPlacementalhealth3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer son stress et concilier travail et vie personnelle']")]
        public IWebElement WorkPlacementalhealth4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser sa colère']")]
        public IWebElement WorkPlacementalhealth5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser son humeur']")]
        public IWebElement WorkPlacementalhealth6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre et prévenir l’épuisement professionnel?']")]
        public IWebElement WorkPlacementalhealth7 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Concilier travail-vie personnelle après la pandémie'])[1]")]
        public IWebElement WorkPlacementalhealth8 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Concilier travail-vie personnelle après la pandémie'])[2]")]
        public IWebElement WorkPlacementalhealth9 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Concilier travail-vie personnelle après la pandémie'])[3]")]
        public IWebElement WorkPlacementalhealth10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Créer un équilibre travail-vie personnelle']")]
        public IWebElement WorkPlacementalhealth11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dix conseils à suivre pour atteindre l’équilibre travail-vie personnelle']")]
        public IWebElement WorkPlacementalhealth12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Encourager la conciliation travail-vie personnelle']")]
        public IWebElement WorkPlacementalhealth13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Est-ce que je souffre de dépression?']")]
        public IWebElement WorkPlacementalhealth14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face aux périodes de changement et de transition au travail']")]
        public IWebElement WorkPlacementalhealth15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Favoriser la santé en milieu de travail']")]
        public IWebElement WorkPlacementalhealth16 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='L’épuisement professionnel : Définition et solutions'])[1]")]
        public IWebElement WorkPlacementalhealth17 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='L’épuisement professionnel : Définition et solutions'])[2]")]
        public IWebElement WorkPlacementalhealth18 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’usure de compassion']")]
        public IWebElement WorkPlacementalhealth19 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La gestion des conflits en milieu de travail']")]
        public IWebElement WorkPlacementalhealth20 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La gestion du stress en milieu de travail']")]
        public IWebElement WorkPlacementalhealth21 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La résilience']")]
        public IWebElement WorkPlacementalhealth22 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La visualisation']")]
        public IWebElement WorkPlacementalhealth23 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le mieux-être psychologique au travail']")]
        public IWebElement WorkPlacementalhealth24 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le travail doit-il absolument être stressant?']")]
        public IWebElement WorkPlacementalhealth25 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le travail par quarts']")]
        public IWebElement WorkPlacementalhealth26 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le TSPT au travail: Solutions et Soutien']")]
        public IWebElement WorkPlacementalhealth27 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les blessures invisibles des troubles de santé mentale']")]
        public IWebElement WorkPlacementalhealth28 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les composantes de la colère?']")]
        public IWebElement WorkPlacementalhealth29 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les défis du travail par quarts']")]
        public IWebElement WorkPlacementalhealth30 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[31]")]
        public IWebElement WorkPlacementalhealth31 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Que faire quand un collègue présente des tendances suicidaires']")]
        public IWebElement WorkPlacementalhealth32 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Réduire le stress professionnel en six étapes']")]
        public IWebElement WorkPlacementalhealth33 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sentio par Homewood Santé']")]
        public IWebElement WorkPlacementalhealth34 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutien aux travailleurs de quarts']")]
        public IWebElement WorkPlacementalhealth35 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vous venez de vivre un évènement pénible']")]
        public IWebElement WorkPlacementalhealth36 { get; set; }

        //Workplace Transition
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Transition et changement']")]
        public IWebElement WorkPlacetransition { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'La transition entre une carrière dans les forces a')]")]
        public IWebElement WorkPlacetransition1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/milieu-de-travail/transition-et-changement'][text()='Transition et changement']")]
        public IWebElement WorkPlacetransitiontag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer la perte de son emploi']")]
        public IWebElement WorkPlacetransition2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment prendre sa carrière en main']")]
        public IWebElement WorkPlacetransition3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[3]")]
        public IWebElement WorkPlacetransition4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dépression saisonnière et pensées toxiques']")]
        public IWebElement WorkPlacetransition5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face aux périodes de changement et de transition au travail']")]
        public IWebElement WorkPlacetransition6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Guide à l’intention des personnes transgenres et de genres divers']")]
        public IWebElement WorkPlacetransition7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La transition vers un milieu de travail civil : guide à l’intention des ex-militaires']")]
        public IWebElement WorkPlacetransition8 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[8]")]
        public IWebElement WorkPlacetransition9 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Préparer votre entreprise à l’après-pandémie'])[1]")]
        public IWebElement WorkPlacetransition10 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Préparer votre entreprise à l’après-pandémie'])[2]")]
        public IWebElement WorkPlacetransition11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire : Réduire l’anxiété et gérer la rentrée en temps de pandémie']")]
        public IWebElement WorkPlacetransition12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire à l’intention des enseignants* des niveaux postsecondaires']")]
        public IWebElement WorkPlacetransition13 { get; set; }

        //ManagerRegression
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Outils']")]
        public IWebElement Managertools { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Cours en ligne pour les managers, les superviseurs ou les personnes clés')]")]
        public IWebElement Managertoolsecourses { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/outils'][text()='Outils']")]
        public IWebElement Managertoolstag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Jetez un œil à quelques ressources PDF pour les gestionnaires, etc.')]")]
        public IWebElement Managertoolsres { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Cours en ligne']")]
        public IWebElement Managertoolsecourses1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='content']//p[contains(text(),'Les cours d'apprentissage en ligne Homeweb offrent des cours à votre rythme et à prix réduits.')]")]
        public IWebElement Managertoolsecoursesmanagers { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/outils/e-courses'][text()='Cours en ligne']")]
        public IWebElement Managertoolsecoursestag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ce cours présente les fondamentaux d'une gestion efficace')]")]
        public IWebElement Managertoolsecoursesfund { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Pour les personnes clés et les superviseurs dirigeant des employés ')]")]
        public IWebElement Managertoolsecourseslead { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Certains types de problèmes sur le lieu de travail donnent lieu à des')]")]
        public IWebElement Managertoolsecoursesmanaging { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ce cours aide les personnes clés et les superviseurs à identifier')]")]
        public IWebElement Managertoolsecoursessupport { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Le but de ce cours est d'aider les personnes clés ')]")]
        public IWebElement Managertoolsecoursesvalue { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Santé mentale']")]
        public IWebElement Managermentalhealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'L'infertilité peut être l'une des expériences les plus bouleversantes')]")]
        public IWebElement Managermentalhealthfertility { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/sante-mentale'][text()='Santé mentale']")]
        public IWebElement Managermentalhealthtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Blessure morale et chemin vers le bien-être – Guide à l’intention des employeurs']")]
        public IWebElement Managermentalhealthguide { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Crise']")]
        public IWebElement Managercrisis { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gestion de crises']")]
        public IWebElement Managercrisismanagement { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/crise'][text()='Crise']")]
        public IWebElement Managercrisistag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Aider des employés* touchés par une catastrophe naturelle']")]
        public IWebElement Managercrisisflooding { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Famille']")]
        public IWebElement Managerfamily { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les traitements de l’infertilité et votre santé mentale']")]
        public IWebElement Managerfamilyfert { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/famille'][text()='Famille']")]
        public IWebElement Managerfamilytag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’autogestion de la santé pour la génération sandwich']")]
        public IWebElement Managerfamilyworking { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Soins']")]
        public IWebElement Managerfamilycaregiving { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/famille/soins'][text()='Soins']")]
        public IWebElement Managerfamilycaregivingtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Mode de vie']")]
        public IWebElement ManagerLifestyle { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vous venez de vivre un évènement pénible']")]
        public IWebElement ManagerLifestylefacing { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie'][text()='Mode de vie']")]
        public IWebElement ManagerLifestyletag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Aperçu des liens entre stress, diabète, alimentation et santé mentale']")]
        public IWebElement ManagerLifestyleleading { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Découvrir vos dépendances cachées']")]
        public IWebElement ManagerLifestyleuncovering { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Dépendance']")]
        public IWebElement ManagerLifestyleaddiction { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Si on vous demandait de réfléchir à ce que quelqu'un avec')]")]
        public IWebElement ManagerLifestyleaddictionuncover { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie/addiction'][text()='Dépendance']")]
        public IWebElement ManagerLifestyleaddictiontag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Diversité et inclusion']")]
        public IWebElement ManagerLifestyleDEI { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Soutenir son personnel handicapé'])[1]")]
        public IWebElement ManagerLifestyleDEI1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie/diversite-et-inclusion'][text()='Diversité et inclusion']")]
        public IWebElement ManagerLifestyleDEItag { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Soutenir son personnel handicapé'])[2]")]
        public IWebElement ManagerLifestyleDEI2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Soutenir son personnel handicapé'])[3]")]
        public IWebElement ManagerLifestyleDEI3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Condition physique']")]
        public IWebElement ManagerLifestyleFitness { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Traitement de la douleur']")]
        public IWebElement ManagerLifestyleFitnesepain { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie/condition-physique'][text()='Condition physique']")]
        public IWebElement ManagerLifestyleFitnesstag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Bulletin pour gestionnaires']")]
        public IWebElement ManagerLifestyleNewsletter { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Aider les hommes à obtenir du soutien en santé mentale et en traitement de la toxicomanie']")]
        public IWebElement ManagerLifestyleNews2SLG { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie/vitalite'][text()='Bulletin pour gestionnaires']")]
        public IWebElement ManagerLifestyleNewstag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment aider des employés* qui sont parents d’enfants d’âge scolaire']")]
        public IWebElement ManagerLifestyleNews2SLG1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment guider vos employés en période de changement']")]
        public IWebElement ManagerLifestyleNewsletter1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Comprendre la dépendance']")]
        public IWebElement ManagerLifestyleNewsletter2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Conseils en gestion d’équipes multigénérationnelles']")]
        public IWebElement ManagerLifestyleNewsletter3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Conseils pour la création d’un milieu de travail stimulant']")]
        public IWebElement ManagerLifestyleNewsletter4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Découvrir vos dépendances cachées']")]
        public IWebElement ManagerLifestyleNewsletter5 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Dix façons d’intégrer l’activité physique dans votre milieu de travail'])[1]")]
        public IWebElement ManagerLifestyleNewsletter6 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Dix façons d’intégrer l’activité physique dans votre milieu de travail'])[2]")]
        public IWebElement ManagerLifestyleNewsletter7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faciliter une réintégration au travail durable']")]
        public IWebElement ManagerLifestyleNewsletter8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gérer les hauts et les bas de la motivation des employés*']")]
        public IWebElement ManagerLifestyleNewsletter9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Guide de gestion des mauvais traitements et des agressions']")]
        public IWebElement ManagerLifestyleNewsletter10 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Inclusion des personnes 2SLGBTQ+ en milieu de travail'])[1]")]
        public IWebElement ManagerLifestyleNewsletter11 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Inclusion des personnes 2SLGBTQ+ en milieu de travail'])[2]")]
        public IWebElement ManagerLifestyleNewsletter12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Intégration de mentalités différentes : comment la neurodiversité renforce les milieux de travail']")]
        public IWebElement ManagerLifestyleNewsletter13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Intégration de mentalités différentes (Audio)']")]
        public IWebElement ManagerLifestyleNewsletter14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Intégration de mentalités différentes (Vidéo)']")]
        public IWebElement ManagerLifestyleNewsletter15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’importance de la diversité des personnalités']")]
        public IWebElement ManagerLifestyleNewsletter16 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les employé·e·s immigrant·e·s qui s’établissent en Amérique du Nord'])[1]")]
        public IWebElement ManagerLifestyleNewsletter17 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les employé·e·s immigrant·e·s qui s’établissent en Amérique du Nord'])[2]")]
        public IWebElement ManagerLifestyleNewsletter18 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les risques d’aujourd’hui en milieu de travail'])[1]")]
        public IWebElement ManagerLifestyleNewsletter19 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les risques d’aujourd’hui en milieu de travail'])[2]")]
        public IWebElement ManagerLifestyleNewsletter20 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Montrer la voie'])[1]")]
        public IWebElement ManagerLifestyleNewsletter21 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Montrer la voie'])[2]")]
        public IWebElement ManagerLifestyleNewsletter22 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Montrer la voie'])[3]")]
        public IWebElement ManagerLifestyleNewsletter23 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Personnes transgenres']")]
        public IWebElement ManagerLifestyleNewsletter24 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Prendre soin de son bien-être pour avoir un rendement élevé'])[1]")]
        public IWebElement ManagerLifestyleNewsletter25 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Prendre soin de son bien-être pour avoir un rendement élevé'])[2]")]
        public IWebElement ManagerLifestyleNewsletter26 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Promouvoir la santé psychologique du personnel en période de changement organisationnel']")]
        public IWebElement ManagerLifestyleNewsletter27 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Soutenir son personnel handicapé'])[1]")]
        public IWebElement ManagerLifestyleNewsletter28 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Soutenir son personnel handicapé'])[2]")]
        public IWebElement ManagerLifestyleNewsletter29 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Soutenir son personnel handicapé'])[3]")]
        public IWebElement ManagerLifestyleNewsletter30 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Traitement de la douleur']")]
        public IWebElement ManagerLifestyleNewsletter31 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Un leadership bienveillant favorise la réussite']")]
        public IWebElement ManagerLifestyleNewsletter32 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie/sante-mentale'][text()='Santé mentale']")]
        public IWebElement ManagerLifestyleMentalHealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vous venez de vivre un évènement pénible']")]
        public IWebElement ManagerLifestyleMenhea { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie/sante-mentale'][text()='Santé mentale']")]
        public IWebElement ManagerLifestyleMenheatag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Lieu de travail']")]
        public IWebElement ManagerWorkplace { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Le cannabis est devenu légal pour tous les adultes au Canada le ')]")]
        public IWebElement ManagerWorkplacecann { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/milieu-de-travail'][text()='Lieu de travail']")]
        public IWebElement ManagerWorkplacetag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Qu'est-ce qui rend les équipes efficaces ? Cet article expliques ')]")]
        public IWebElement ManagerWorkplaceteams { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Lien entre sommeil sain et sécurité au travail']")]
        public IWebElement ManagerWorkplaceconnecting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Avez-vous déjà pensé à la façon dont vous réagiriez si')]")]
        public IWebElement ManagerWorkplacecrisis { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Il est dans l’intérêt d’une organisation de conserver ')]")]
        public IWebElement ManagerWorkplaceemployer { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Dans le monde des affaires actuel, en constante évolution et en évolution rapide')]")]
        public IWebElement ManagerWorkplacefacilitating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face à une transition professionnelle majeure']")]
        public IWebElement ManagerWorkplacefacing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Principes de base d'une supervision efficace']")]
        public IWebElement ManagerWorkplacefund { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Guider les employés à travers le changement']")]
        public IWebElement ManagerWorkplaceguiding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les employés dont les enfants vont à l'école']")]
        public IWebElement ManagerWorkplacehowto { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Diriger le côté humain du changement']")]
        public IWebElement ManagerWorkplaceleading { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gérer les enjeux sensibles des employés']")]
        public IWebElement ManagerWorkplacemanaging { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Optimiser la résilience'])[1]")]
        public IWebElement ManagerWorkplaceopt { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Optimiser la résilience'])[2]")]
        public IWebElement ManagerWorkplaceopt1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Optimiser la résilience'])[3]")]
        public IWebElement ManagerWorkplaceopt2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Promouvoir la santé psychologique en période de changement']")]
        public IWebElement ManagerWorkplacepromoting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Ressources pour les gestionnaires']")]
        public IWebElement ManagerWorkplaceres { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les employés touchés par les inondations']")]
        public IWebElement ManagerWorkplacesup { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les employés travaillant en continu']")]
        public IWebElement ManagerWorkplacesup1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les hommes dans l'accès à la santé mentale et à l'aide à la dépendance']")]
        public IWebElement ManagerWorkplacesup2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir le respect en milieu de travail']")]
        public IWebElement ManagerWorkplacesup3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Favoriser un retour au travail réussi']")]
        public IWebElement ManagerWorkplacesup4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les employés transgenres et de genre divers']")]
        public IWebElement ManagerWorkplacesup5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Conseils pour créer un milieu de travail sain']")]
        public IWebElement ManagerWorkplacetips { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Transgenre : où trouver et comment apporter du soutien']")]
        public IWebElement ManagerWorkplacetrans { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre la dépendance']")]
        public IWebElement ManagerWorkplaceunder { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Leadership basé sur les valeurs']")]
        public IWebElement ManagerWorkplacevalue { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quand les abus et la violence arrivent au travail']")]
        public IWebElement ManagerWorkplacewhen { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Équité en milieu de travail']")]
        public IWebElement ManagerWorkplacework { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Développement de carrière']")]
        public IWebElement ManagerWorkplacecareer { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face à une transition professionnelle majeure']")]
        public IWebElement ManagerWorkplacecareertrans { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/milieu-de-travail/career-development'][text()='Développement de carrière']")]
        public IWebElement ManagerWorkplacecareertag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ce cours aide les personnes clés et les superviseurs à identifier')]")]
        public IWebElement ManagerWorkplacecareersupport { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Communication']")]
        public IWebElement ManagerWorkplacecareercomm { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ce cours présente les fondamentaux d'une gestion efficace')]")]
        public IWebElement ManagerWorkplacecommfund { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/milieu-de-travail/communication'][text()='Communication']")]
        public IWebElement ManagerWorkplacecommtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Certains types de problèmes sur le lieu de travail donnent lieu à des')]")]
        public IWebElement ManagerWorkplacecommsens { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ce cours aide les personnes clés et les superviseurs à identifier')]")]
        public IWebElement ManagerWorkplacecommsupport { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Transgenre : où trouver et comment apporter du soutien']")]
        public IWebElement ManagerWorkplacecommtrans { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Gestion']")]
        public IWebElement ManagerWorkplacemgmt { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cannabis et le milieu de travail']")]
        public IWebElement ManagerWorkplacemgmtcann { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/milieu-de-travail/gestion'][text()='Gestion']")]
        public IWebElement ManagerWorkplacemgmttag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Intégration de mentalités différentes : comment la neurodiversité renforce les milieux de travail']")]
        public IWebElement ManagerWorkplacemgmt1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gestion de crises']")]
        public IWebElement ManagerWorkplacemgmt2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stratégies des employeurs pour retenir les employés']")]
        public IWebElement ManagerWorkplacemgmt3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Favoriser la résilience en milieu de travail']")]
        public IWebElement ManagerWorkplacemgmt4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Principes de base d'une supervision efficace']")]
        public IWebElement ManagerWorkplacemgmt5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Guider les employés à travers le changement']")]
        public IWebElement ManagerWorkplacemgmt6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les employés dont les enfants vont à l'école']")]
        public IWebElement ManagerWorkplacemgmt7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Diriger le côté humain du changement']")]
        public IWebElement ManagerWorkplacemgmt8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Montrer la voie']")]
        public IWebElement ManagerWorkplacemgmt9 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Diriger avec empathie et favoriser la réussite des employés'])[1]")]
        public IWebElement ManagerWorkplacemgmt10 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Diriger avec empathie et favoriser la réussite des employés'])[2]")]
        public IWebElement ManagerWorkplacemgmt11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gérer la motivation des employés']")]
        public IWebElement ManagerWorkplacemgmt12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gérer les enjeux sensibles des employés']")]
        public IWebElement ManagerWorkplacemgmt13 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Gérer des équipes à distance'])[1]")]
        public IWebElement ManagerWorkplacemgmt14 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Gérer des équipes à distance'])[2]")]
        public IWebElement ManagerWorkplacemgmt15 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Gérer des équipes à distance'])[3]")]
        public IWebElement ManagerWorkplacemgmt16 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Blessure morale et chemin vers le bien-être – Guide à l’intention des employeurs']")]
        public IWebElement ManagerWorkplacemgmt17 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Favoriser le bien-être pour une performance optimale'])[1]")]
        public IWebElement ManagerWorkplacemgmt18 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Favoriser le bien-être pour une performance optimale'])[2]")]
        public IWebElement ManagerWorkplacemgmt19 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Optimiser la résilience'])[1]")]
        public IWebElement ManagerWorkplacemgmt20 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Optimiser la résilience'])[2]")]
        public IWebElement ManagerWorkplacemgmt21 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Optimiser la résilience'])[3]")]
        public IWebElement ManagerWorkplacemgmt22 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Ressources pour les gestionnaires']")]
        public IWebElement ManagerWorkplacemgmt23 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les employés touchés par les inondations']")]
        public IWebElement ManagerWorkplacemgm24 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les employés en situation de handicap']")]
        public IWebElement ManagerWorkplacemgmt25 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir la neurodiversité en milieu de travail']")]
        public IWebElement ManagerWorkplacemgmt26 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir le respect en milieu de travail']")]
        public IWebElement ManagerWorkplacemgmt27 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Favoriser un retour au travail réussi']")]
        public IWebElement ManagerWorkplacemgmt28 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les employés transgenres et de genre divers']")]
        public IWebElement ManagerWorkplacemgmt29 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Conseils pour créer un milieu de travail sain']")]
        public IWebElement ManagerWorkplacemgmt30 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Transgenre : où trouver et comment apporter du soutien']")]
        public IWebElement ManagerWorkplacemgmt31 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Leadership basé sur les valeurs']")]
        public IWebElement ManagerWorkplacemgmt32 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@href='/app/fr/resources/category/permalink/milieu-de-travail/santé mentale']")]
        public IWebElement ManagerWorkplacementhea { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Des environnements de travail sains favorisent une vie professionnelle positive')]")]
        public IWebElement ManagerWorkplacementhea1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/milieu-de-travail/santé mentale'][text()='Santé mentale']")]
        public IWebElement ManagerWorkplacementheatag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Favoriser la résilience en milieu de travail']")]
        public IWebElement ManagerWorkplacementhea2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face à une transition professionnelle majeure']")]
        public IWebElement ManagerWorkplacementhea3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Montrer la voie']")]
        public IWebElement ManagerWorkplacementhea4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les employés travaillant en continu']")]
        public IWebElement ManagerWorkplacementhea5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les employés en situation de handicap']")]
        public IWebElement ManagerWorkplacementhea6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir les hommes dans l'accès à la santé mentale et à l'aide à la dépendance']")]
        public IWebElement ManagerWorkplacementhea7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quand les abus et la violence arrivent au travail']")]
        public IWebElement ManagerWorkplacementhea8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Transition']")]
        public IWebElement ManagerWorkplacetransition { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Diriger le côté humain du changement']")]
        public IWebElement ManagerWorkplacetransition1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/milieu-de-travail/transition'][text()='Transition']")]
        public IWebElement ManagerWorkplacetransitiontag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Promouvoir la santé psychologique en période de changement']")]
        public IWebElement ManagerWorkplacetransition2 { get; set; }

        //PlanAdmin Regression

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Documentation RH']")]
        public IWebElement PlanAdminHRres { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'En règle générale, un code de déontologie décrit l')]")]
        public IWebElement PlanAdminHRres1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/documentation-rh'][text()='Documentation RH']")]
        public IWebElement PlanAdminHRrestag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Code de déontologie relatif aux biens appartenant à l’entreprise']")]
        public IWebElement PlanAdminHRres2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Contrat d’engagement']")]
        public IWebElement PlanAdminHRres3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Convention sur la protection de l’information confidentielle']")]
        public IWebElement PlanAdminHRres4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Entente de non-concurrence']")]
        public IWebElement PlanAdminHRres5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Formulaire de contrôle des références']")]
        public IWebElement PlanAdminHRres6 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Formulaire de notification d’examen de la période d’essai'])[1]")]
        public IWebElement PlanAdminHRres7 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Formulaire de notification d’examen de la période d’essai'])[2]")]
        public IWebElement PlanAdminHRres8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Formulaire de plainte de harcèlement ou de discrimination']")]
        public IWebElement PlanAdminHRres9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gestion du rendement : évaluation de la performance']")]
        public IWebElement PlanAdminHRres10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gestion du rendement les carences des formulaires']")]
        public IWebElement PlanAdminHRres11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Lettre de confirmation d’offre d’emploi']")]
        public IWebElement PlanAdminHRres12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Lettre type de refus de candidature']")]
        public IWebElement PlanAdminHRres13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Planification du rendement et entretien d’évaluation']")]
        public IWebElement PlanAdminHRres14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Qu’est-ce que la gestion de rendement?']")]
        public IWebElement PlanAdminHRres15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Recrutement – Entrevue téléphonique']")]
        public IWebElement PlanAdminHRres16 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='RH: Soutenir les employés transgenres ou d’identités sexuelles diverses']")]
        public IWebElement PlanAdminHRres17 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Sanction disciplinaire à l’encontre d’un employé à l’essai']")]
        public IWebElement PlanAdminHRres18 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Guides destinés aux employés']")]
        public IWebElement PlanAdminHRresemphand { get; set; }
        [FindsBy(How = How.XPath, Using = "//section[@class='article-featured']")]
        public IWebElement PlanAdminHRresemphand1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/documentation-rh/guide-destines-aux-employes'][text()='Guides destinés aux employés']")]
        public IWebElement PlanAdminHRresemphandtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Code de déontologie relatif aux biens appartenant à l’entreprise']")]
        public IWebElement PlanAdminHRresemphand2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Contrat d’engagement']")]
        public IWebElement PlanAdminHRresemphand3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Convention sur la protection de l’information confidentielle']")]
        public IWebElement PlanAdminHRresemphand4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Description d’emploi générique']")]
        public IWebElement PlanAdminHRresemphand5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Entente de non-concurrence']")]
        public IWebElement PlanAdminHRresemphand6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Formulaire de notification d’examen de la période d’essai']")]
        public IWebElement PlanAdminHRresemphand7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Formulaire de plainte de harcèlement ou de discrimination']")]
        public IWebElement PlanAdminHRresemphand8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Lettre de confirmation d’offre d’emploi']")]
        public IWebElement PlanAdminHRresemphand9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Descriptions de postes']")]
        public IWebElement PlanAdminHRresJD { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Description d’emploi générique']")]
        public IWebElement PlanAdminHRresJD1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/documentation-rh/descriptions-des-postes'][text()='Descriptions de postes']")]
        public IWebElement PlanAdminHRresJDtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les avantages d’un milieu de travail hybride']")]
        public IWebElement PlanAdminHRresJD2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Gestion du rendement']")]
        public IWebElement PlanAdminHRresPM { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Formulaire de notification d’examen de la période d’essai']")]
        public IWebElement PlanAdminHRresPM1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/documentation-rh/gestion-du-rendement'][text()='Gestion du rendement']")]
        public IWebElement PlanAdminHRresPMtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gestion du rendement : évaluation de la performance']")]
        public IWebElement PlanAdminHRresPM2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gestion du rendement les carences des formulaires']")]
        public IWebElement PlanAdminHRresPM3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Planification du rendement et entretien d’évaluation']")]
        public IWebElement PlanAdminHRresPM4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Qu’est-ce que la gestion de rendement?']")]
        public IWebElement PlanAdminHRresPM5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Période de probation']")]
        public IWebElement PlanAdminHRresPP { get; set; }
        [FindsBy(How = How.XPath, Using = "///SPAN[@class='title'][text()='​Sanction disciplinaire à l’encontre d’un employé à l’essai']]")]
        public IWebElement PlanAdminHRresPP1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/documentation-rh/periode-de-probation'][text()='Période de probation']")]
        public IWebElement PlanAdminHRresPPtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Recrutement']")]
        public IWebElement PlanAdminHRresrec { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Formulaire de contrôle des références']")]
        public IWebElement PlanAdminHRresrec1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/documentation-rh/recrutement'][text()='Recrutement']")]
        public IWebElement PlanAdminHRresrectag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Recrutement – Entrevue téléphonique']")]
        public IWebElement PlanAdminHRresrec2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Mode de vie']")]
        public IWebElement PlanAdminLS { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le travail par quarts']")]
        public IWebElement PlanAdminLS1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie'][text()='Mode de vie']")]
        public IWebElement PlanAdminLStag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Santé mentale']")]
        public IWebElement PlanAdminLSmenhea { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le travail par quarts']")]
        public IWebElement PlanAdminLSmenhea1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/mode-de-vie/sante-mentale'][text()='Santé mentale']")]
        public IWebElement PlanAdminLSmenheatag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Milieu de travail']")]
        public IWebElement PlanAdminWP { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Santé mentale']")]
        public IWebElement PlanAdminWPmenhea { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le travail par quarts']")]
        public IWebElement PlanAdminWPmenhea1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/milieu-de-travail/sante-mentale'][text()='Santé mentale']")]
        public IWebElement PlanAdminWPmenheatag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Transition et changement']")]
        public IWebElement PlanAdminWPtransition { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='RH: Soutenir les employés transgenres ou d’identités sexuelles diverses']")]
        public IWebElement PlanAdminWPtransition1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/milieu-de-travail/transition-et-changement'][text()='Transition et changement']")]
        public IWebElement PlanAdminWPtransitiontag { get; set; }



    }
}
