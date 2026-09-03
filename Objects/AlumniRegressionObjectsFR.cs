using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeweb_3._0_Tests.Objects
{
    internal class AlumniRegressionObjectsFR
    {
        //Alumni AddictionFR
        private IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Dépendance']")]
        public IWebElement AlumniAddiction { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Aider les personnes aux prises avec un problème de dépendance']")]
        public IWebElement AlumniAddiction1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/dependance'][text()='Dépendance']")]
        public IWebElement AlumniAddictiontag { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Aider les personnes aux prises avec un problème de dépendance'])[1]")]
        public IWebElement AlumniAddiction2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Aider les personnes aux prises avec un problème de dépendance'])[2]")]
        public IWebElement AlumniAddiction3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Bâtissez l’avenir que vous méritez']")]
        public IWebElement AlumniAddiction4 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Cessez de fumer et retrouvez votre liberté!'])[1]")]
        public IWebElement AlumniAddiction5 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Cessez de fumer et retrouvez votre liberté!'])[2]")]
        public IWebElement AlumniAddiction6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cinq façons de gérer l’état de manque pendant la période de votre rétablissement']")]
        public IWebElement AlumniAddiction7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment contrôler sa consommation d’alcool']")]
        public IWebElement AlumniAddiction8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment parler à ses enfants d’antécédents familiaux de dépendance']")]
        public IWebElement AlumniAddiction9 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment parler à ses enfants de santé mentale et de toxicomanie']")]
        public IWebElement AlumniAddiction10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment survivre aux Fêtes quand on a cessé de boire']")]
        public IWebElement AlumniAddiction11 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Comprendre la dépendance']")]
        public IWebElement AlumniAddiction12 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[12]")]
        public IWebElement AlumniAddiction13 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[13]")]
        public IWebElement AlumniAddiction14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dépression et anxiété']")]
        public IWebElement AlumniAddiction15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Éviter Les Dépendances De Substitution']")]
        public IWebElement AlumniAddiction16 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[16]")]
        public IWebElement AlumniAddiction17 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[17]")]
        public IWebElement AlumniAddiction18 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[18]")]
        public IWebElement AlumniAddiction19 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’affirmation de soi comme aide au rétablissement de la toxicomanie']")]
        public IWebElement AlumniAddiction20 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le vapotage : la nouvelle dépendance des adolescents*']")]
        public IWebElement AlumniAddiction21 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[21]")]
        public IWebElement AlumniAddiction22 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les Fêtes de fin d’année']")]
        public IWebElement AlumniAddiction23 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les relations de couple pendant le rétablissement']")]
        public IWebElement AlumniAddiction24 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Leur influence positive sur la santé mentale et le rétablissement de la toxicomanie']")]
        public IWebElement AlumniAddiction25 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[25]")]
        public IWebElement AlumniAddiction26 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[26]")]
        public IWebElement AlumniAddiction27 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Se créer un réseau de soutien']")]
        public IWebElement AlumniAddiction28 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir un ex-toxicomane* pendant les fêtes']")]
        public IWebElement AlumniAddiction29 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stigmatisation et toxicomanie']")]
        public IWebElement AlumniAddiction30 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Tout ce que vous pensez de la dépendance est faux']")]
        public IWebElement AlumniAddiction31 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Trop de temps d’écran?']")]
        public IWebElement AlumniAddiction32 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Une rechute n’est pas un échec : comment se remettre dans la bonne voie']")]
        public IWebElement AlumniAddiction33 { get; set; }

        //AlumniLifeskillsFR

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Compétences de la vie']")]
        public IWebElement AlumniLS1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Une saine dose de confiance en soi donne la résil')]")]
        public IWebElement AlumniLS2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/competences-de-la-vie'][text()='Compétences de la vie']")]
        public IWebElement AlumniLS2tag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment augmenter votre confiance en vous']")]
        public IWebElement AlumniLS3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment éviter de réagir de façon excessive']")]
        public IWebElement AlumniLS4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment gérer son stress et concilier travail et vie personnelle']")]
        public IWebElement AlumniLS5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser sa colère']")]
        public IWebElement AlumniLS6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser son humeur']")]
        public IWebElement AlumniLS7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser son stress']")]
        public IWebElement AlumniLS8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment s’adapter au changement']")]
        public IWebElement AlumniLS9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment saisir la chance de vous exprimer']")]
        public IWebElement AlumniLS10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment se maintenir en bonne santé psychologique']")]
        public IWebElement AlumniLS11 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[10]")]
        public IWebElement AlumniLS12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’importance d’être en lien avec la collectivité']")]
        public IWebElement AlumniLS13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La gestion du stress en milieu de travail']")]
        public IWebElement AlumniLS14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La monoparentalité']")]
        public IWebElement AlumniLS15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La résilience']")]
        public IWebElement AlumniLS16 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La respiration détendue']")]
        public IWebElement AlumniLS17 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le mieux-être psychologique au travail']")]
        public IWebElement AlumniLS18 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les parents au travail']")]
        public IWebElement AlumniLS19 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mettez de l’ordre dans vos finances et réduisez votre niveau de stress']")]
        public IWebElement AlumniLS20 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[19]")]
        public IWebElement AlumniLS21 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vous venez de vivre un évènement pénible']")]
        public IWebElement AlumniLS22 { get; set; }

        //Alumni RelationshipsFR

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Des relations']")]
        public IWebElement AlumniRS1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Avec les nombreuses pressions exercées sur les enf')]")]
        public IWebElement AlumniRS2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/des-relations'][text()='Des relations']")]
        public IWebElement AlumniRStag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Avoir une relation de couple saine tout en préservant son individualité']")]
        public IWebElement AlumniRS3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment conserver vos sentiments amoureux']")]
        public IWebElement AlumniRS4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment rétablir la confiance dans votre couple']")]
        public IWebElement AlumniRS5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Conflits relationnels']")]
        public IWebElement AlumniRS6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’adolescent* d’aujourd’hui']")]
        public IWebElement AlumniRS7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’importance d’être en lien avec la collectivité']")]
        public IWebElement AlumniRS8 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[7]")]
        public IWebElement AlumniRS9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La séparation et le divorce']")]
        public IWebElement AlumniRS10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le pouvoir bienfaisant d’une bonne action']")]
        public IWebElement AlumniRS11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les choses à faire et à ne pas faire pour vivre une relation saine']")]
        public IWebElement AlumniRS12 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les relations de couple pendant le rétablissement'])[1]")]
        public IWebElement AlumniRS13 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Les relations de couple pendant le rétablissement'])[2]")]
        public IWebElement AlumniRS14 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[13]")]
        public IWebElement AlumniRS15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Se créer un réseau de soutien']")]
        public IWebElement AlumniRS16 { get; set; }

        //AlumniRecoveryFR


        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Récupération']")]
        public IWebElement AlumniRecovery { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Une saine dose de confiance en soi donne la résil')]")]
        public IWebElement AlumniRecovery1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/recuperation'][text()='Récupération']")]
        public IWebElement AlumniRecoverytag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Bâtissez l’avenir que vous méritez']")]
        public IWebElement AlumniRecovery2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cessez de fumer et retrouvez votre liberté!']")]
        public IWebElement AlumniRecovery3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment augmenter votre confiance en vous']")]
        public IWebElement AlumniRecovery4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment éviter de réagir de façon excessive']")]
        public IWebElement AlumniRecovery5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment jouir d’un bon sommeil']")]
        public IWebElement AlumniRecovery6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment l’empathie peut soutenir une personne en rétablissement']")]
        public IWebElement AlumniRecovery7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser sa colère']")]
        public IWebElement AlumniRecovery8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser son humeur']")]
        public IWebElement AlumniRecovery9 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser son stress']")]
        public IWebElement AlumniRecovery10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment saisir la chance de vous exprimer']")]
        public IWebElement AlumniRecovery11 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment se maintenir en bonne santé psychologique']")]
        public IWebElement AlumniRecovery12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment survivre aux Fêtes quand on a cessé de boire']")]
        public IWebElement AlumniRecovery13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dépression et anxiété']")]
        public IWebElement AlumniRecovery14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Éviter Les Dépendances De Substitution']")]
        public IWebElement AlumniRecovery15 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[16]")]
        public IWebElement AlumniRecovery16 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[17]")]
        public IWebElement AlumniRecovery17 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’importance de la détente']")]
        public IWebElement AlumniRecovery18 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La gestion du stress en milieu de travail']")]
        public IWebElement AlumniRecovery19 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La pratique quotidienne de la méditation de pleine conscience']")]
        public IWebElement AlumniRecovery20 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La résilience']")]
        public IWebElement AlumniRecovery21 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le changement intérieur et le rétablissement à long terme : Bâtir l’avenir que vous méritez.']")]
        public IWebElement AlumniRecovery22 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les Fêtes de fin d’année']")]
        public IWebElement AlumniRecovery23 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les nombreux visages du TSPT']")]
        public IWebElement AlumniRecovery24 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les relations de couple pendant le rétablissement']")]
        public IWebElement AlumniRecovery25 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Leur influence positive sur la santé mentale et le rétablissement de la toxicomanie']")]
        public IWebElement AlumniRecovery26 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mesures pour recouvrer la santé mentale']")]
        public IWebElement AlumniRecovery27 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Rétablissement ne signifie pas solitude']")]
        public IWebElement AlumniRecovery28 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Se créer un réseau de soutien']")]
        public IWebElement AlumniRecovery29 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir un ex-toxicomane* pendant les fêtes']")]
        public IWebElement AlumniRecovery30 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Surmonter la déprime de l’hiver']")]
        public IWebElement AlumniRecovery31 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Surmonter ses phobies']")]
        public IWebElement AlumniRecovery32 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Une rechute n’est pas un échec : comment se remettre dans la bonne voie']")]
        public IWebElement AlumniRecovery33 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vivre au quotidien le recouvrement de sa santé mentale']")]
        public IWebElement AlumniRecovery34 { get; set; }
      

        //AlumniWellnessTogetherFR
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/recuperation/espace-mieux-etre-canada'][text()='Espace Mieux-Etre Canada']")]
        public IWebElement Alumniwellness1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Appelez au 1-855-805-4858 pour parler avec un cons')]")]
        public IWebElement Alumniwellness2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/recuperation/espace-mieux-etre-canada'][text()='Espace Mieux-Etre Canada']")]
        public IWebElement Alumniwellnesstag { get; set; }

        //AlumniHealingFR

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Guérir avec Homewood']")]
        public IWebElement AlumniHealing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Comment survivre aux Fêtes quand on se rétablit d’un trouble lié à l’usage de substances']")]
        public IWebElement AlumniHealing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/guerir-avec-homewood'][text()='Guérir avec Homewood']")]
        public IWebElement AlumniHealingtag { get; set; }
        [FindsBy(How = How.XPath, Using = "///SPAN[@class='title h1'][text()='Conscience mentale de l’ici-maintenant : technique 5-4-3-2-1']")]
        public IWebElement AlumniHealing2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Conscience physique de l’ici-maintenant : Observation d’un objet']")]
        public IWebElement AlumniHealing3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Introduction à la conscience de l’ici-maintenant']")]
        public IWebElement AlumniHealing4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’histoire d’Peter']")]
        public IWebElement AlumniHealing5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La conscience de l’ici-maintenant : la bienveillance apaisante']")]
        public IWebElement AlumniHealing6 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[6]")]
        public IWebElement AlumniHealing7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'La pleine conscience pour calmer l’anxiété : Le ba')]")]
        public IWebElement AlumniHealing8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La pleine conscience pour calmer l’anxiété : le corps et la respiration']")]
        public IWebElement AlumniHealing9 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La pleine conscience pour calmer l’anxiété à l’aide de sons et de pensées conscientes']")]
        public IWebElement AlumniHealing10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La respiration consciente pour soulager le stress']")]
        public IWebElement AlumniHealing11 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La stigmatisation d’un trouble lié à la consommation de substances psychoactives']")]
        public IWebElement AlumniHealing12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Relaxation musculaire totale pour réduire le stress et la tension']")]
        public IWebElement AlumniHealing13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Veiller à son bien-être dans ses relations avec ses proches']")]
        public IWebElement AlumniHealing14 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[14]")]
        public IWebElement AlumniHealing15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire : COVID-19 : Transition et changement']")]
        public IWebElement AlumniHealing16 { get; set; }

        //AlumniGettingStartedFR

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Commencer']")]
        public IWebElement AlumniGettingStarted { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Étiez-vous craintif* dans le noir quand vous étiez')]")]
        public IWebElement AlumniGettingStarted1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/commencer'][text()='Commencer']")]
        public IWebElement AlumniGettingStartedtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Améliorer les relations familiales']")]
        public IWebElement AlumniGettingStarted2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Découvrir les visages de l’anxiété']")]
        public IWebElement AlumniGettingStarted3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Déveloper la résilience']")]
        public IWebElement AlumniGettingStarted4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Faire face au deuil et à la perte']")]
        public IWebElement AlumniGettingStarted5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Leur influence positive sur la santé mentale et le rétablissement de la toxicomanie']")]
        public IWebElement AlumniGettingStarted6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maîtrisez votre stress avant qu’il ne soit trop tard!']")]
        public IWebElement AlumniGettingStarted7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Prendre le contrôle de son humeur']")]
        public IWebElement AlumniGettingStarted8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Prendre le contrôle de votre humeur : des habitudes saines']")]
        public IWebElement AlumniGettingStarted9 { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Prendre le contrôle de votre humeur : gérer vos ém')]")]
        public IWebElement AlumniGettingStarted10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Service IntelliVie']")]
        public IWebElement AlumniGettingStarted11 { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Prendre le contrôle de votre humeur : introduction']")]
        public IWebElement AlumniGettingStarted12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Prendre le contrôle de votre humeur : réduire la t')]")]
        public IWebElement AlumniGettingStarted13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Prendre le contrôle de votre humeur : restez conne')]")]
        public IWebElement AlumniGettingStarted14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Prenez le contrôle de votre humeur : soyez actif']")]
        public IWebElement AlumniGettingStarted15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quand un proche est gravement malade']")]
        public IWebElement AlumniGettingStarted16 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Résilience (Exercice)']")]
        public IWebElement AlumniGettingStarted17 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[16]")]
        public IWebElement AlumniGettingStarted18 { get; set; }

        //AlumniWebinarsFR

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Webinaires']")]
        public IWebElement AlumniWebinars { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ce webinaire porte sur les effets psychologiques d')]")]
        public IWebElement AlumniWebinars1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/webinaires'][text()='Webinaires']")]
        public IWebElement AlumniWebinarstag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19 : Qu’est-ce que la langueur et pourquoi faut-il s’en soucier?']")]
        public IWebElement AlumniWebinars2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[2]")]
        public IWebElement AlumniWebinars3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pratiquer la pleine conscience et la gratitude pendant les vacances']")]
        public IWebElement AlumniWebinars4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire : COVID-19 – Stratégies d’autosoins pour contrer l’usure, l’isolement et la solitude']")]
        public IWebElement AlumniWebinars5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire : COVID-19 : Transition et changement']")]
        public IWebElement AlumniWebinars6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire : Gérer le trouble affectif saisonnier en temps de pandémie']")]
        public IWebElement AlumniWebinars7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire: COVID-19 : Transition et changement']")]
        public IWebElement AlumniWebinars8 { get; set; }

        //AlumniCrisisFR

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Crise']")]
        public IWebElement AlumniCrisis { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Comment gérer la perte de son emploi']")]
        public IWebElement AlumniCrisis1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/crise'][text()='Crise']")]
        public IWebElement AlumniCrisistag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’agression et le harcèlement sexuels']")]
        public IWebElement AlumniCrisis2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les nombreux visages du TSPT']")]
        public IWebElement AlumniCrisis3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[3]")]
        public IWebElement AlumniCrisis4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Service IntelliVie']")]
        public IWebElement AlumniCrisis5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vivre un évènement perturbateur']")]
        public IWebElement AlumniCrisis6 { get; set; }

        //AlumniCovidFR

        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/crise/covid19'][text()='COVID19']")]
        public IWebElement AlumniCovid { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Bibliothèque santé et mieux-être']")]
        public IWebElement AlumniCovid1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/crise/covid19'][text()='COVID19']")]
        public IWebElement AlumniCovidtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Célébrer les Fêtes de façon sécuritaire']")]
        public IWebElement AlumniCovid2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Chassez vos soucis financiers et commencez à épargner']")]
        public IWebElement AlumniCovid3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser son humeur']")]
        public IWebElement AlumniCovid4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser son stress']")]
        public IWebElement AlumniCovid5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19 : protéger la santé mentale des enfants']")]
        public IWebElement AlumniCovid6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19 : Qu’est-ce que la langueur et pourquoi faut-il s’en soucier?']")]
        public IWebElement AlumniCovid7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dépression et anxiété']")]
        public IWebElement AlumniCovid8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='La résilience']")]
        public IWebElement AlumniCovid9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les rapports humains pour lutter contre la solitude et l’isolement pendant les Fêtes']")]
        public IWebElement AlumniCovid10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Lorsque les prochaines fêtes sont loin :']")]
        public IWebElement AlumniCovid11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maîtrisez votre stress avant qu’il ne soit trop tard!']")]
        public IWebElement AlumniCovid12 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[12]")]
        public IWebElement AlumniCovid13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quand un proche est gravement malade']")]
        public IWebElement AlumniCovid14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire : COVID-19 – Stratégies d’autosoins pour contrer l’usure, l’isolement et la solitude']")]
        public IWebElement AlumniCovid15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire : Gérer le trouble affectif saisonnier en temps de pandémie']")]
        public IWebElement AlumniCovid16 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire: COVID-19 : Transition et changement']")]
        public IWebElement AlumniCovid17 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire: COVID-19 La deuxième vague et votre santé mentale']")]
        public IWebElement AlumniCovid18 { get; set; }

        //AlumniMentalHealthFR

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Santé mentale']")]
        public IWebElement AlumniMentalHealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cet article présente des stratégies et des conseil')]")]
        public IWebElement AlumniMentalHealth1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/fr/resources/category/permalink/sante-mentale'][text()='Santé mentale']")]
        public IWebElement AlumniMentalHealthtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Aller au-delà de l’anxiété']")]
        public IWebElement AlumniMentalHealth2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Améliorer son estime de soi']")]
        public IWebElement AlumniMentalHealth3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Bâtissez l’avenir que vous méritez']")]
        public IWebElement AlumniMentalHealth4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment augmenter votre confiance en vous']")]
        public IWebElement AlumniMentalHealth5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment éviter de réagir de façon excessive']")]
        public IWebElement AlumniMentalHealth6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser sa colère']")]
        public IWebElement AlumniMentalHealth7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment maîtriser son humeur']")]
        public IWebElement AlumniMentalHealth8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment parler à ses enfants de santé mentale et de toxicomanie']")]
        public IWebElement AlumniMentalHealth9 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment rester en bonne santé mentale pendant le temps des Fêtes']")]
        public IWebElement AlumniMentalHealth10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comment se maintenir en bonne santé psychologique']")]
        public IWebElement AlumniMentalHealth11 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre la dépression']")]
        public IWebElement AlumniMentalHealth12 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[12]")]
        public IWebElement AlumniMentalHealth13 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[13]")]
        public IWebElement AlumniMentalHealth14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Comprendre, faire face et aider']")]
        public IWebElement AlumniMentalHealth15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19 : protéger la santé mentale des enfants']")]
        public IWebElement AlumniMentalHealth16 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19 : Qu’est-ce que la langueur et pourquoi faut-il s’en soucier?']")]
        public IWebElement AlumniMentalHealth17 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dépression et anxiété']")]
        public IWebElement AlumniMentalHealth18 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Dépression saisonnière et pensées toxiques'])[1]")]
        public IWebElement AlumniMentalHealth19 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Dépression saisonnière et pensées toxiques'])[2]")]
        public IWebElement AlumniMentalHealth20 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dix conseils à suivre pour atteindre l’équilibre travail-vie personnelle']")]
        public IWebElement AlumniMentalHealth21 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gérer la dépression saisonnière']")]
        public IWebElement AlumniMentalHealth22 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Guérir les blessures invisibles']")]
        public IWebElement AlumniMentalHealth23 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Intégration de mentalités différentes : comment la neurodiversité renforce les milieux de travail']")]
        public IWebElement AlumniMentalHealth24 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Intégration de mentalités différentes (Audio)']")]
        public IWebElement AlumniMentalHealth25 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Intégration de mentalités différentes (Vidéo)']")]
        public IWebElement AlumniMentalHealth26 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[26]")]
        public IWebElement AlumniMentalHealth27 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='L’agression et le harcèlement sexuels']")]
        public IWebElement AlumniMentalHealth28 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​La santé mentale des enfants et des adolescents*']")]
        public IWebElement AlumniMentalHealth29 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Le santé mentale des femmes']")]
        public IWebElement AlumniMentalHealth30 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les bienfaits de l’exercice pour la santé mentale']")]
        public IWebElement AlumniMentalHealth31 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les nombreux visages du TSPT']")]
        public IWebElement AlumniMentalHealth32 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les rapports humains pour lutter contre la solitude et l’isolement pendant les Fêtes']")]
        public IWebElement AlumniMentalHealth33 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Les relations de couple pendant le rétablissement']")]
        public IWebElement AlumniMentalHealth34 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Lorsque les prochaines fêtes sont loin :']")]
        public IWebElement AlumniMentalHealth35 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maîtrisez votre stress']")]
        public IWebElement AlumniMentalHealth36 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mesures pour recouvrer la santé mentale']")]
        public IWebElement AlumniMentalHealth37 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mettez de l’ordre dans vos finances et réduisez votre niveau de stress']")]
        public IWebElement AlumniMentalHealth38 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Parler à ses enfants de la santé mentale']")]
        public IWebElement AlumniMentalHealth39 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pour en finir avec les mythes sur la maladie mentale!']")]
        public IWebElement AlumniMentalHealth40 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[40]")]
        public IWebElement AlumniMentalHealth41 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[41]")]
        public IWebElement AlumniMentalHealth42 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Réduire la stigmatisation entourant les problèmes de santé mentale']")]
        public IWebElement AlumniMentalHealth43 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Service IntelliVie']")]
        public IWebElement AlumniMentalHealth44 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soutenir un ex-toxicomane* pendant les fêtes']")]
        public IWebElement AlumniMentalHealth45 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[45]")]
        public IWebElement AlumniMentalHealth46 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Surmonter la déprime de l’hiver']")]
        public IWebElement AlumniMentalHealth47 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Surmonter ses phobies']")]
        public IWebElement AlumniMentalHealth48 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Techniques de relaxation pour gérer le stress']")]
        public IWebElement AlumniMentalHealth49 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vivre au quotidien le recouvrement de sa santé mentale']")]
        public IWebElement AlumniMentalHealth50 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vivre un évènement perturbateur']")]
        public IWebElement AlumniMentalHealth51 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire: COVID-19 : Transition et changement']")]
        public IWebElement AlumniMentalHealth52 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinaire: COVID-19 La deuxième vague et votre santé mentale']")]
        public IWebElement AlumniMentalHealth53 { get; set; }



    }
}
