using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeweb_3._0_Tests.Objects
{
    internal class AlumniRegressionObjects
    {
        //Alumni Addiction
        private IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Addiction']")]
        public IWebElement AlumniAddiction { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Recovering from an addiction takes time and practi')]")]
        public IWebElement AlumniAddiction1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/addiction'][text()='Addiction']")]
        public IWebElement AlumniAddictiontag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Addiction and Recovery Help Sheet']")]
        public IWebElement AlumniAddiction2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Addiction and Relapse Help Sheet']")]
        public IWebElement AlumniAddiction3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[3]")]
        public IWebElement AlumniAddiction4 { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Avoiding Substitute Addictions']")]
        public IWebElement AlumniAddiction5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Building a Support System']")]
        public IWebElement AlumniAddiction6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Creating the Future You Deserve']")]
        public IWebElement AlumniAddiction7 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[7]")]
        public IWebElement AlumniAddiction8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Welcome to i-Volve, Homewood’s online, self-paced ')]")]
        public IWebElement AlumniAddiction9 { get; set; }
       
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Everything You Think You Know About Addiction Is Wrong']")]
        public IWebElement AlumniAddiction10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Holiday Celebrations']")]
        public IWebElement AlumniAddiction11 { get; set; }
       
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Talk to Your Children about a Family History of Addiction']")]
        public IWebElement AlumniAddiction12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Navigating the Holidays When You’re in Recovery']")]
        public IWebElement AlumniAddiction13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Positive Influences on Mental Health and Addiction']")]
        public IWebElement AlumniAddiction14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Relapse does not equal failure: Getting back on track']")]
        public IWebElement AlumniAddiction15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stigma and Addiction']")]
        public IWebElement AlumniAddiction16 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Stop Smoking and Get Your Life Back!'])[1]")]
        public IWebElement AlumniAddiction17 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Stop Smoking and Get Your Life Back!'])[2]")]
        public IWebElement AlumniAddiction18 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Suicide Prevention: Uncovering the Signs']")]
        public IWebElement AlumniAddiction19 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Those in Recovery During the Holidays']")]
        public IWebElement AlumniAddiction20 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Supporting those with Addiction'])[1]")]
        public IWebElement AlumniAddiction21 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Supporting those with Addiction'])[2]")]
        public IWebElement AlumniAddiction22 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Supporting those with Addiction'])[3]")]
        public IWebElement AlumniAddiction23 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Alcohol Use']")]
        public IWebElement AlumniAddiction24 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Talking to Your Kids About Drugs and Alcohol']")]
        public IWebElement AlumniAddiction25 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Talking to Your Kids About Mental Health and Addiction']")]
        public IWebElement AlumniAddiction26 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Impact of Alcohol']")]
        public IWebElement AlumniAddiction27 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Too Much Screen Time?']")]
        public IWebElement AlumniAddiction28 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Addiction']")]
        public IWebElement AlumniAddiction29 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Eating Disorders (Audio)']")]
        public IWebElement AlumniAddiction30 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Eating Disorders (Video)']")]
        public IWebElement AlumniAddiction31 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Using Assertive Communication Skills to Support Addiction Recovery']")]
        public IWebElement AlumniAddiction32 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vaping: The New Teen Addiction']")]
        public IWebElement AlumniAddiction33 { get; set; }

        //AlumniLifeskills

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Life Skills']")]
        public IWebElement AlumniLS1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Most people aren’t fond of change. We like our ha')]")]
        public IWebElement AlumniLS2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/life-skills'][text()='Life Skills']")]
        public IWebElement AlumniLS2tag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Breathe to Relax']")]
        public IWebElement AlumniLS3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Connecting With the Community']")]
        public IWebElement AlumniLS4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='From Kids to Retirement']")]
        public IWebElement AlumniLS5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How Taking Care of Your Finances Can Reduce Your Stress Level']")]
        public IWebElement AlumniLS6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Avoid Overreacting']")]
        public IWebElement AlumniLS7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Increase Your Self-Confidence']")]
        public IWebElement AlumniLS8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Take the Chance to Express Yourself']")]
        public IWebElement AlumniLS9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maintaining Good Mental Health']")]
        public IWebElement AlumniLS10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Workplace Stress']")]
        public IWebElement AlumniLS11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Me-Time: Managing Stress and Finding Work-Life Balance']")]
        public IWebElement AlumniLS12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mental Wellness at Work']")]
        public IWebElement AlumniLS13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Raising Your Self-Esteem']")]
        public IWebElement AlumniLS14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Resilience']")]
        public IWebElement AlumniLS15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Single Parenting']")]
        public IWebElement AlumniLS16 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Anger']")]
        public IWebElement AlumniLS17 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Stress']")]
        public IWebElement AlumniLS18 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Your Mood']")]
        public IWebElement AlumniLS19 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Impact of Technology on Family Dynamics']")]
        public IWebElement AlumniLS20 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Working Parent']")]
        public IWebElement AlumniLS21 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[20]")]
        public IWebElement AlumniLS22 { get; set; }

        //Alumni Relationships

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Relationships']")]
        public IWebElement AlumniRS1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​The motivational speaker, Jim Rohn, penned a conc')]")]
        public IWebElement AlumniRS2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/relationships'][text()='Relationships']")]
        public IWebElement AlumniRStag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Building Healthy Relationships While Maintaining Individuality']")]
        public IWebElement AlumniRS3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Connecting With the Community']")]
        public IWebElement AlumniRS4 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[3]")]
        public IWebElement AlumniRS5 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[4]")]
        public IWebElement AlumniRS6 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[5]")]
        public IWebElement AlumniRS7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Improving Relationships']")]
        public IWebElement AlumniRS8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Keeping Your Love Alive']")]
        public IWebElement AlumniRS9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Relationship Disputes']")]
        public IWebElement AlumniRS10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Resolving Conflict in Intimate Relationships']")]
        public IWebElement AlumniRS11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Restoring Trust After Infidelity']")]
        public IWebElement AlumniRS12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Separation and Divorce']")]
        public IWebElement AlumniRS13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Healing Power of Helping Others']")]
        public IWebElement AlumniRS14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Impact of Technology on Family Dynamics']")]
        public IWebElement AlumniRS15 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[14]")]
        public IWebElement AlumniRS16 { get; set; }

        //AlumniRecovery

       
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Recovery']")]
        public IWebElement AlumniRecovery { get; set; }
        [FindsBy(How = How.XPath, Using = "//section[@class='article-featured']//p[contains(text(),'Get support from our recovery board')]")]
        public IWebElement AlumniRecovery1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/recovery'][text()='Recovery']")]
        public IWebElement AlumniRecoverytag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Addiction and Relapse Help Sheet']")]
        public IWebElement AlumniRecovery2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[2]")]
        public IWebElement AlumniRecovery3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Avoiding Substitute Addictions']")]
        public IWebElement AlumniRecovery4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Building a Support System']")]
        public IWebElement AlumniRecovery5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Creating the Future You Deserve']")]
        public IWebElement AlumniRecovery6 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[6]")]
        public IWebElement AlumniRecovery7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Depression & Anxiety']")]
        public IWebElement AlumniRecovery8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Getting Adequate Sleep']")]
        public IWebElement AlumniRecovery9 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Healthy Habits: Actions to Recovery']")]
        public IWebElement AlumniRecovery10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Holiday Celebrations']")]
        public IWebElement AlumniRecovery11 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How Empathy Can Support Someone In Recovery']")]
        public IWebElement AlumniRecovery12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Avoid Overreacting']")]
        public IWebElement AlumniRecovery13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Increase Your Self-Confidence']")]
        public IWebElement AlumniRecovery14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Take the Chance to Express Yourself']")]
        public IWebElement AlumniRecovery15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Inner Change and Long-Term Recovery: Creating the Future You Deserve']")]
        public IWebElement AlumniRecovery16 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maintaining Good Mental Health']")]
        public IWebElement AlumniRecovery17 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Workplace Stress']")]
        public IWebElement AlumniRecovery18 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mindfulness: Meditation and Everyday Practice']")]
        public IWebElement AlumniRecovery19 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Navigating Life in Mental Health Recovery']")]
        public IWebElement AlumniRecovery20 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Navigating the Holidays When You’re in Recovery']")]
        public IWebElement AlumniRecovery21 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='No Need to Be a Hermit in Recovery']")]
        public IWebElement AlumniRecovery22 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Overcoming Phobias']")]
        public IWebElement AlumniRecovery23 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Overcoming the Winter Weather Blues']")]
        public IWebElement AlumniRecovery24 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Positive Influences on Mental Health and Addiction']")]
        public IWebElement AlumniRecovery25 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Raising Your Self-Esteem']")]
        public IWebElement AlumniRecovery26 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Relapse does not equal failure: Getting back on track']")]
        public IWebElement AlumniRecovery27 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Resilience']")]
        public IWebElement AlumniRecovery28 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stop Smoking and Get Your Life Back!']")]
        public IWebElement AlumniRecovery29 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Those in Recovery During the Holidays']")]
        public IWebElement AlumniRecovery30 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Anger']")]
        public IWebElement AlumniRecovery31 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Stress']")]
        public IWebElement AlumniRecovery32 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Your Mood']")]
        public IWebElement AlumniRecovery33 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Importance of Relaxation']")]
        public IWebElement AlumniRecovery34 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​The Many Faces of Post-Traumatic Stress Disorder']")]
        public IWebElement AlumniRecovery35 { get; set; }

        //AlumniWellnessTogether
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Wellness Together Canada']")]
        public IWebElement Alumniwellness1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Take That Step Get Connected']")]
        public IWebElement Alumniwellness2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/recovery/wtc'][text()='Wellness Together Canada']")]
        public IWebElement Alumniwellnesstag { get; set; }

        //AlumniHealing

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Healing with Homewood']")]
        public IWebElement AlumniHealing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='An Introduction to Grounding']")]
        public IWebElement AlumniHealing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/healing-with-homewood'][text()='Healing with Homewood']")]
        public IWebElement AlumniHealingtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dealing with the Stigma of a Substance Use Disorder']")]
        public IWebElement AlumniHealing2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Eating Disorder Recovery over the holidays']")]
        public IWebElement AlumniHealing3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Full Body Muscle Relaxation for Stress and Tension']")]
        public IWebElement AlumniHealing4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maintaining Healthy Boundaries with Family and Friends']")]
        public IWebElement AlumniHealing5 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[5]")]
        public IWebElement AlumniHealing6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mindful Breathing for Stress Relief']")]
        public IWebElement AlumniHealing7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mindfulness for Anxiety - Body Scan']")]
        public IWebElement AlumniHealing8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mindfulness for Anxiety - Mindful Movement']")]
        public IWebElement AlumniHealing9 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mindfulness for Anxiety: Sounds and Thoughts']")]
        public IWebElement AlumniHealing10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mindfulness for Anxiety: The Body and Breath']")]
        public IWebElement AlumniHealing11 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Navigating the holidays while in recovery']")]
        public IWebElement AlumniHealing12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Peter’s Story']")]
        public IWebElement AlumniHealing13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Physical Grounding: Object Exploration']")]
        public IWebElement AlumniHealing14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Soothing Grounding: Loving Kindness']")]
        public IWebElement AlumniHealing15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinar: COVID-19: Transition and Change']")]
        public IWebElement AlumniHealing16 { get; set; }

        //AlumniGettingStarted
       
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Getting Started']")]
        public IWebElement AlumniGettingStarted { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We’ll all experience great highs and great lows du')]")]
        public IWebElement AlumniGettingStarted1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/getting-started'][text()='Getting Started']")]
        public IWebElement AlumniGettingStartedtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Coping with Grief and Loss']")]
        public IWebElement AlumniGettingStarted2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Grief and Loss Coaching']")]
        public IWebElement AlumniGettingStarted3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Improving Family Relationships']")]
        public IWebElement AlumniGettingStarted4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Moving Beyond Anxiety']")]
        public IWebElement AlumniGettingStarted5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Positive Influences on Mental Health and Addiction']")]
        public IWebElement AlumniGettingStarted6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Resilience (Exercise)']")]
        public IWebElement AlumniGettingStarted7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Charge of Stress']")]
        public IWebElement AlumniGettingStarted8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Mood']")]
        public IWebElement AlumniGettingStarted9 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Your Mood: Get Active']")]
        public IWebElement AlumniGettingStarted10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Your Mood: Healthy Habits']")]
        public IWebElement AlumniGettingStarted11 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Your Mood: Intro']")]
        public IWebElement AlumniGettingStarted12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Your Mood: Manage Your Feelings']")]
        public IWebElement AlumniGettingStarted13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Your Mood: Reduce Tension']")]
        public IWebElement AlumniGettingStarted14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Your Mood: Stay Connected']")]
        public IWebElement AlumniGettingStarted15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Impact of Technology on Family Dynamics']")]
        public IWebElement AlumniGettingStarted16 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Uncovering the Faces of Anxiety']")]
        public IWebElement AlumniGettingStarted17 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='When Someone Close to You Has a Serious Illness']")]
        public IWebElement AlumniGettingStarted18 { get; set; }

        //AlumniWebinars

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Webinars']")]
        public IWebElement AlumniWebinars { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title']")]
        public IWebElement AlumniWebinars1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/webinars'][text()='Webinars']")]
        public IWebElement AlumniWebinarstag { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[1]")]
        public IWebElement AlumniWebinars2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19: What is Languishing and Why is it Important?']")]
        public IWebElement AlumniWebinars3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Practicing Mindfulness and Gratitude Over The Holidays']")]
        public IWebElement AlumniWebinars4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinar : Dealing with Seasonal Affective Disorder']")]
        public IWebElement AlumniWebinars5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Webinar: COVID-19: Loneliness & Isolation Fatigue ')]")]
        public IWebElement AlumniWebinars6 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Webinar: COVID-19: Transition and Change'])[1]")]
        public IWebElement AlumniWebinars7 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Webinar: COVID-19: Transition and Change'])[2]")]
        public IWebElement AlumniWebinars8 { get; set; }

        //AlumniCrisis

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Crisis']")]
        public IWebElement AlumniCrisis { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In response to the recent social unrest taking pla')]")]
        public IWebElement AlumniCrisis1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/crisis'][text()='Crisis']")]
        public IWebElement AlumniCrisistag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Grief and Loss Coaching']")]
        public IWebElement AlumniCrisis2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sexual Abuse and Sexual Harassment']")]
        public IWebElement AlumniCrisis3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Suicide Prevention: Uncovering the Signs']")]
        public IWebElement AlumniCrisis4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Job Loss and Transition']")]
        public IWebElement AlumniCrisis5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​The Many Faces of Post-Traumatic Stress Disorder']")]
        public IWebElement AlumniCrisis6 { get; set; }

        //AlumniCovid
        
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='COVID-19']")]
        public IWebElement AlumniCovid { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Knowing how to gather safely for celebrations is e')]")]
        public IWebElement AlumniCovid1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/crisis/covid-19'][text()='COVID-19']")]
        public IWebElement AlumniCovidtag { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[1]")]
        public IWebElement AlumniCovid2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19: What is Languishing and Why is it Important?']")]
        public IWebElement AlumniCovid3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Welcome to i-Volve, Homewood’s online, self-paced ')]")]
        public IWebElement AlumniCovid4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Holiday Stress and Anxiety Prevention']")]
        public IWebElement AlumniCovid5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Overcoming Financial Fatigue and Concern']")]
        public IWebElement AlumniCovid6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Resilience']")]
        public IWebElement AlumniCovid7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Staying Connected to Combat Loneliness and Isolation During the Holidays']")]
        public IWebElement AlumniCovid8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Charge of Stress']")]
        public IWebElement AlumniCovid9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Stress']")]
        public IWebElement AlumniCovid10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Your Mood']")]
        public IWebElement AlumniCovid11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinar : Dealing with Seasonal Affective Disorder']")]
        public IWebElement AlumniCovid12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinar: COVID-19 The Second Wave and Your Mental Health']")]
        public IWebElement AlumniCovid13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Webinar: COVID-19: Loneliness & Isolation Fatigue ')]")]
        public IWebElement AlumniCovid14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinar: COVID-19: Transition and Change']")]
        public IWebElement AlumniCovid15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='When Someone Close to You Has a Serious Illness']")]
        public IWebElement AlumniCovid16 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='When the Next Celebration isn’t Just Around the Corner']")]
        public IWebElement AlumniCovid17 { get; set; }

        //AlumniMentalHealth

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Mental Health']")]
        public IWebElement AlumniMentalHealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Work life-balance is an individual measurement and')]")]
        public IWebElement AlumniMentalHealth1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/mental-health'][text()='Mental Health']")]
        public IWebElement AlumniMentalHealthtag { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[1]")]
        public IWebElement AlumniMentalHealth2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19: What is Languishing and Why is it Important?']")]
        public IWebElement AlumniMentalHealth3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Creating the Future You Deserve']")]
        public IWebElement AlumniMentalHealth4 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[4]")]
        public IWebElement AlumniMentalHealth5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dealing with Seasonal Depression']")]
        public IWebElement AlumniMentalHealth6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Welcome to i-Volve, Homewood’s online, self-paced ')]")]
        public IWebElement AlumniMentalHealth7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Embracing Different Minds (Audio)']")]
        public IWebElement AlumniMentalHealth8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Embracing Different Minds (Video)']")]
        public IWebElement AlumniMentalHealth9 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Embracing Different Minds: How Neurodiversity Strengthens Workplaces']")]
        public IWebElement AlumniMentalHealth10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Experiencing Disruptive Events']")]
        public IWebElement AlumniMentalHealth11 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Grief and Loss Coaching']")]
        public IWebElement AlumniMentalHealth12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Healing the Invisible Wounds']")]
        public IWebElement AlumniMentalHealth13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Healthy Habits: Actions to Recovery']")]
        public IWebElement AlumniMentalHealth14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Holiday Stress and Anxiety Prevention']")]
        public IWebElement AlumniMentalHealth15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How Taking Care of Your Finances Can Reduce Your Stress Level']")]
        public IWebElement AlumniMentalHealth16 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Avoid Overreacting']")]
        public IWebElement AlumniMentalHealth17 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Increase Your Self-Confidence']")]
        public IWebElement AlumniMentalHealth18 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Stay Mentally Healthy During the Holidays']")]
        public IWebElement AlumniMentalHealth19 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maintaining Good Mental Health']")]
        public IWebElement AlumniMentalHealth20 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mental Health Benefits of Exercise']")]
        public IWebElement AlumniMentalHealth21 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mental Illness Mythbusters']")]
        public IWebElement AlumniMentalHealth22 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Moving Beyond Anxiety']")]
        public IWebElement AlumniMentalHealth23 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Navigating Life in Mental Health Recovery']")]
        public IWebElement AlumniMentalHealth24 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Navigating Panic Disorder']")]
        public IWebElement AlumniMentalHealth25 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Overcoming Phobias']")]
        public IWebElement AlumniMentalHealth26 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Overcoming the Winter Weather Blues']")]
        public IWebElement AlumniMentalHealth27 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Raising Your Self-Esteem']")]
        public IWebElement AlumniMentalHealth28 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Reducing Mental Health Stigma']")]
        public IWebElement AlumniMentalHealth29 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Relaxation Techniques to Deal with Stress']")]
        public IWebElement AlumniMentalHealth30 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Responsible Optimism']")]
        public IWebElement AlumniMentalHealth31 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sexual Abuse and Sexual Harassment']")]
        public IWebElement AlumniMentalHealth32 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Staying Connected to Combat Loneliness and Isolation During the Holidays']")]
        public IWebElement AlumniMentalHealth33 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Suicide Prevention: Uncovering the Signs']")]
        public IWebElement AlumniMentalHealth34 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Someone With a Mental Illness']")]
        public IWebElement AlumniMentalHealth35 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Supporting someone you care about with PTSD']")]
        public IWebElement AlumniMentalHealth36 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Those in Recovery During the Holidays']")]
        public IWebElement AlumniMentalHealth37 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Charge of Stress']")]
        public IWebElement AlumniMentalHealth38 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Anger']")]
        public IWebElement AlumniMentalHealth39 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Your Mood']")]
        public IWebElement AlumniMentalHealth40 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Talking to Your Children about Mental Health']")]
        public IWebElement AlumniMentalHealth41 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Talking to Your Kids About Mental Health and Addiction']")]
        public IWebElement AlumniMentalHealth42 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​The Many Faces of Post-Traumatic Stress Disorder']")]
        public IWebElement AlumniMentalHealth43 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='The Weight of Winter and Negative Thoughts'])[1]")]
        public IWebElement AlumniMentalHealth44 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='The Weight of Winter and Negative Thoughts'])[2]")]
        public IWebElement AlumniMentalHealth45 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Depression']")]
        public IWebElement AlumniMentalHealth46 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Eating Disorders (Audio)']")]
        public IWebElement AlumniMentalHealth47 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Eating Disorders (Video)']")]
        public IWebElement AlumniMentalHealth48 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinar: COVID-19 The Second Wave and Your Mental Health']")]
        public IWebElement AlumniMentalHealth49 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinar: COVID-19: Transition and Change']")]
        public IWebElement AlumniMentalHealth50 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='When the Next Celebration isn’t Just Around the Corner']")]
        public IWebElement AlumniMentalHealth51 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[51]")]
        public IWebElement AlumniMentalHealth52 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Youth, Teens and Mental Health']")]
        public IWebElement AlumniMentalHealth53 { get; set; }
     


    }
}
