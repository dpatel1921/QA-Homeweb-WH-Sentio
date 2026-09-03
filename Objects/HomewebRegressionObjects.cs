using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeweb_3._0_Tests.Objects
{
    internal class HomewebRegressionObjects
    {
        //Getting Started
        private IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Getting Started']")]
        public IWebElement Gettingstarted { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We’ll all experience great highs and great lows du')]")]
        public IWebElement BuildingResi { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='https://www.unh.edu/health/stress-resilience']")]
        public IWebElement BuildingResilink1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='https://www.apa.org/topics/resilience']")]
        public IWebElement BuildingResilink2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'https://www.pickthebrain.com/blog/4-steps-to-build')]")]
        public IWebElement BuildingResilink3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'https://www.pickthebrain.com/10-tips-for-developin')]")]
        public IWebElement BuildingResilink4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'https://www.psychologytoday.com/ca/blog/design-you')]")]
        public IWebElement BuildingResilink5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'https://www.everydayhealth.com/wellness/resilience')]")]
        public IWebElement BuildingResilink6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'https://time.com/4306492/boost-emotional-resilienc')]")]
        public IWebElement BuildingResilink7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'https://www.mayoclinic.org/tests-procedures/resili')]")]
        public IWebElement BuildingResilink8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Coping with Grief and Loss']")]
        public IWebElement Copingwith { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/getting-started'][text()='Getting Started']")]
        public IWebElement Gettingstartedtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Grief and Loss Coaching']")]
        public IWebElement Griefandloss { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article will teach you about: How to communic')]")]
        public IWebElement ImprovingFamily { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Were you ever afraid of the dark when you were a c')]")]
        public IWebElement MovingBeyond { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Positive Influences on Mental Health and Addiction']")]
        public IWebElement Positiveinfluence { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This e-course will: Introduce you to the concept o')]")]
        public IWebElement Resilience { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Thinking about how to manage stress may be the las')]")]
        public IWebElement TakingCharge { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This e-course will let you: Access a self-guided c')]")]
        public IWebElement TakingControlMood { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article will teach you about: How diet affect')]")]
        public IWebElement TakingControlMood1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article will teach you about: Symptoms of dep')]")]
        public IWebElement TakingControlMood2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article will teach you about: The difference ')]")]
        public IWebElement TakingControlMood3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article will teach you about: Understand how ')]")]
        public IWebElement TakingControlMood4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article will teach you about: The major sourc')]")]
        public IWebElement TakingControlMood5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'How family members related to each other – its dyn')]")]
        public IWebElement Impactoftech { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Approximately three million Canadians have an anxi')]")]
        public IWebElement Uncoveringthefaces { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When someone we love faces a serious illness our e')]")]
        public IWebElement Whensomeoneclose { get; set; }

        //StudentLife
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Student Life']")]
        public IWebElement StudentLife { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Most people aren’t fond of change. We like our ha')]")]
        public IWebElement Adaptingtochange { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/student-life'][text()='Student Life']")]
        public IWebElement Studentlifetag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We might not like to admit it, but most of us have')]")]
        public IWebElement Breakthose { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Seasonal Affective Disorder (SAD), often referred ')]")]
        public IWebElement Dealingwithread { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='5 Minute Video']")]
        public IWebElement Dealingwithvideo { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'A common challenge in sticking to a healthy diet i')]")]
        public IWebElement EatingHealthier { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Get Control of Your Money']")]
        public IWebElement GetControl { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How Can I Cope With My Feelings About the Future?']")]
        public IWebElement HowcanIcope { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Avoid Overreacting']")]
        public IWebElement Howtoavoid { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Improve Sleep']")]
        public IWebElement Howtoimprove { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Increase Your Self-Confidence']")]
        public IWebElement Howtoincrease { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Maintain a Healthy Relationship With Food']")]
        public IWebElement Howtomaintain { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Humour Therapy and the Power of Laughter']")]
        public IWebElement Humourtherapy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Life Smart Coaching Services']")]
        public IWebElement Lifesmart { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maintaining Good Mental Health']")]
        public IWebElement MaintainingGood { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Moving Beyond Anxiety']")]
        public IWebElement Movingbeyond { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Raising Your Self-Esteem']")]
        public IWebElement Raisingself { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Spotting Signs of Suicide']")]
        public IWebElement Spottingsigns { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stop Smoking and Get Your Life Back!']")]
        public IWebElement Stopsmoking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Surviving Another September']")]
        public IWebElement Survivingsept { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Charge of Stress']")]
        public IWebElement Takingchargeofstress { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Dangers of Social Media on Your Mental Health']")]
        public IWebElement Dansgersofsocial { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='When Habits Become Addictions']")]
        public IWebElement Whenhabits { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Addiction']")]
        public IWebElement Addiction { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@href='/app/en/resources/category/permalink/student-life/addiction']")]
        public IWebElement Addictiontag { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Understanding Eating Disorders (Audio)']")]
        public IWebElement UnderstandingEating { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Understanding Eating Disorders (Video)']")]
        public IWebElement UnderstandingEatingvideo { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Understanding Eating Disorders: A Compassionate Ap')]")]
        public IWebElement UnderstandingEatingread { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Quitting smoking takes more than willpower. We kno')]")]
        public IWebElement Stopsmokingaddiction { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Finances']")]
        public IWebElement Srudentlifefinance { get; set; }
        [FindsBy(How = How.XPath, Using = "//main[@id='content']//p[1]")]
        public IWebElement Getcontrolofmoney { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Finances']")]
        public IWebElement Financetag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@href='/app/en/resources/category/permalink/student-life/mental-health']")]
        public IWebElement Mentalhealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Although it’s normal to feel sad or upset from tim')]")]
        public IWebElement AmIExperiencing { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@href='/app/en/resources/category/permalink/student-life/mental-health']")]
        public IWebElement Mentalhealthtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Back to School can Bring big Changes']")]
        public IWebElement Backtoschool { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[text()=' In this session, Homewood Health will discuss the psychological impacts the ongoing COVID-19 pandemic has on our children, while highlighting factors that can promote and preserve their mental health, well-being and resiliency during and beyond the pandemic. ']")]
        public IWebElement Covid19 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Dealing with Seasonal Depression']")]
        public IWebElement Dealingwithseasonal { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When you feel overwhelmed, build a bigger picture.')]")]
        public IWebElement Howtoavoidoverreacting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'If you want to improve your self-confidence, you n')]")]
        public IWebElement Howtoincreaseyour { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'How would you rate your mental and emotional state')]")]
        public IWebElement Maintaininggood { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​A healthy amount of self-esteem gives us the resi')]")]
        public IWebElement Raisingyourself { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Do you know how to spot the signs of suicide? Lear')]")]
        public IWebElement Spottingsignsof { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When was the last time you liked a post on Faceboo')]")]
        public IWebElement Thedangersof { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article breaks down what eating disorders are')]")]
        public IWebElement Understandingeating { get; set; }

        //Tools
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Tools']")]
        public IWebElement Tools { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Often as summer days are winding down, it’s common')]")]
        public IWebElement Toolsbacktoschool { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Tools']")]
        public IWebElement ToolsTag { get; set; }
        [FindsBy(How = How.XPath, Using = "(//P[text()=' Clients can communicate with a professionally trained counsellor from the comfort of their own home. '])[1]")]
        public IWebElement Toolsecounselling { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[text()=' Homeweb e-Learning courses provide self-paced, private, and personalized learning experiences designed to improve personal health and well-being and/or workplace effectiveness. ']")]
        public IWebElement Toolsecourses { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Employee/Member Orientation']")]
        public IWebElement Toolsmemberorientation { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Understanding the types of therapy available to yo')]")]
        public IWebElement ToolsIntrotoCBT { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Whether you need to find a nursing home for an agi')]")]
        public IWebElement ToolsLS { get; set; }
        [FindsBy(How = How.XPath, Using = "(//P[text()=' Clients can communicate with a professionally trained counsellor from the comfort of their own home. '])[2]")]
        public IWebElement ToolsVideo { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Counselling']")]
        public IWebElement Counselling { get; set; }
        [FindsBy(How = How.XPath, Using = "//section[@class='article-featured']//p[contains(text(),'Clients can communicate with a professionally trai')]")]
        public IWebElement ECounselling { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Counselling']")]
        public IWebElement Counsellingtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Understanding the types of therapy available to yo')]")]
        public IWebElement IntroCBT { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Many people find it fairly easy to think of ways t')]")]
        public IWebElement IntroCBTpod { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='content']//p[contains(text(),'Clients can communicate with a professionally trai')]")]
        public IWebElement videocounselling { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='E-courses']")]
        public IWebElement ecourses { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Homeweb e-Learning courses provide self-paced, pri')]")]
        public IWebElement ecourses1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='E-courses']")]
        public IWebElement ecoursestag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course offers self-care strategies for coping')]")]
        public IWebElement embracingworkplace { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course is about developing parenting practice')]")]
        public IWebElement foundationsofeffective { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Leadership Strategies for Supporting Mental Health']")]
        public IWebElement leadership1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Module 1 of training on leadership strategies for ')]")]
        public IWebElement leadership2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Module 2 of training on leadership strategies for ')]")]
        public IWebElement leadership3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[6]//div[1]//div[1]//div[1]//div[1]//span[1]")]
        public IWebElement leadership4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Module 4 of training on leadership strategies for ')]")]
        public IWebElement leadership5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'For most of us, retirement presents a new chapter ')]")]
        public IWebElement preparingforretirement { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course features video segments of a psycholog')]")]
        public IWebElement resilience { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Are you questioning whether you should stay in you')]")]
        public IWebElement resolvingconflict { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course helps participants learn when unwelcom')]")]
        public IWebElement respectinworkplace { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Thinking optimistically, rather than negatively or')]")]
        public IWebElement responsibleoptimism { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Quitting smoking takes more than willpower. We kno')]")]
        public IWebElement stopsmokingtools { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course can help you manage angry feelings and')]")]
        public IWebElement takingcontrolofanger { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Job loss or transition is a difficult process for')]")]
        public IWebElement takingcontrolofjobloss { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Most people feel that they are under “higher than ')]")]
        public IWebElement takingcontrolofstress { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'A satisfying career comes about as a result of str')]")]
        public IWebElement takingcontrolofcareer { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Feelings of sadness are normal but sometimes they ')]")]
        public IWebElement takingcontrolofmood { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='iCBT']")]
        public IWebElement iCBT { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Sentio is online cognitive behavioural therapy (CB')]")]
        public IWebElement Sentio { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='iCBT']")]
        public IWebElement iCBTtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Orientation']")]
        public IWebElement Orientation { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This orientation is about the services offered as ')]")]
        public IWebElement employeeorientation { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Orientation']")]
        public IWebElement Orientationtag { get; set; }

        // Webinars
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Webinars']")]
        public IWebElement webinars { get; set; }
        [FindsBy(How = How.XPath, Using = "//section[@class='article-featured']//p[contains(text(),'In this session, Homewood Health will discuss the ')]")]
        public IWebElement Covid19support { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Webinars']")]
        public IWebElement webinartag { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='content']//p[contains(text(),'In this session, Homewood Health will discuss the ')]")]
        public IWebElement Covid19whatis { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='Hosted by Katherine Sisak.']")]
        public IWebElement Mentalhealthcovid { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Presented by Regional Director EFAP - Western Regi')]")]
        public IWebElement practicingmindfulness { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Webinar : Dealing with Seasonal Affective Disorder']")]
        public IWebElement Webinardealingwith { get; set; }
        [FindsBy(How = How.XPath, Using = "(//P[text()=' Presented by: Sandy Kriegish, Clinical Manager and Account Executive '])[2]")]
        public IWebElement Webinarthesecondwave { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[text()=' This session helped participants understand anxiety and depression, typical reactions, and equipped participants with strategies, tips and tools for regulating managing their own emotions as well as tips for supporting others who may be experiencing difficulties. ']")]
        public IWebElement Webinarcovid19mental { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/60802f6c5f7daadb4a707adb']")]
        public IWebElement Webinarcovid19loneliness { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[text()=' This session adopts a solutions-focused lens and explores different change management styles to assist employees in finding ways to navigate change as they move forward following the pandemic. ']")]
        public IWebElement Webinarcovid19transition { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Empathy is a key component of emotional intelligen')]")]
        public IWebElement Webinardevelopeing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This session explores the importance of creating a')]")]
        public IWebElement Webinarinclusion { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='Presented by Katherine Sisak, M.S.W., R.S.W., RP']")]
        public IWebElement WebinarCBT { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Presented by Cynthia Keys M.A., BEd., CCC., RCAT.,')]")]
        public IWebElement Webinarreducinganxiety { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Webinar: Social Media: The Impact on Mental Health']")]
        public IWebElement Webinarsocialmedia { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This session will provide participants with a high')]")]
        public IWebElement Webinarwomensmental { get; set; }

        //Wellness Sessions
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Wellness Sessions']")]
        public IWebElement Wellnesssessions { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​In today’s society, there remains a lack of aware')]")]
        public IWebElement Wellnesssessionbeyondstigma { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/wellness-sessions'][text()='Wellness Sessions']")]
        public IWebElement Wellnesssessionstag { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Building Resilience']")]
        public IWebElement Wellresilience { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Every time people interact, there is an opportunit')]")]
        public IWebElement Wellbuilding { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Successful work groups are comprised of individual')]")]
        public IWebElement Wellimproving { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Time is a precious resource. The phrase “time is m')]")]
        public IWebElement Wellmanaging { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​When stressors overwhelm us, effective techniques')]")]
        public IWebElement Wellstress { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Art of Relaxation']")]
        public IWebElement Wellartof { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Change is a fact of life, but letting go of the fa')]")]
        public IWebElement Wellfundamentals { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course is designed to help participants under')]")]
        public IWebElement Welljourney { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This session will introduce participants to some o')]")]
        public IWebElement Wellscience { get; set; }

        //Mental Health
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Mental Health']")]
        public IWebElement Mental { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Work life-balance is an individual measurement and')]")]
        public IWebElement Mentalhealth10steps { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Mental Health']")]
        public IWebElement Mentaltag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Although it’s normal to feel sad or upset from tim')]")]
        public IWebElement MentalExperincingDep { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We explore a wide range of contributing factors th')]")]
        public IWebElement Mentalchildrenandyouth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this podcast, we explore a wide range of contri')]")]
        public IWebElement Mentalchildrenandyouth1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this video, we explore a wide range of contribu')]")]
        public IWebElement Mentalchildrenandyouth2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This video will explore where children are current')]")]
        public IWebElement Mentalcyberbully { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This podcast will explore where children are curre')]")]
        public IWebElement Mentalcyberbully1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article will explore where children are curre')]")]
        public IWebElement Mentalcyberbully2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this article, we’ll be exploring the topic of p')]")]
        public IWebElement Mentalcopingwith { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Many of us have experienced challenging moments in')]")]
        public IWebElement Mentalcopingwith1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Everyone feels sad or down at times, and normally ')]")]
        public IWebElement Mentalcopingwithdep { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@href='/app/en/resources/category/permalink/mental-health']")]
        public IWebElement Mentalcopingwithdeptag { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[11]")]
        public IWebElement Mentalcovid19 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19: What is Languishing and Why is it Important?']")]
        public IWebElement Mentalcovid191 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When you think about your life and the weeks, mont')]")]
        public IWebElement Mentalcreatingafuture { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'During your recovery, you need to allow yourself t')]")]
        public IWebElement Mentaldatingwhile { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Dealing with Seasonal Depression']")]
        public IWebElement Mentaldealingwith { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'How often in life have you crossed paths with thos')]")]
        public IWebElement Mentaldevelopingresiliency { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Listen to how neurodiversity can be your workplace')]")]
        public IWebElement Mentalembracingdifferent { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Watch how neurodiverse minds, from autism to ADHD,')]")]
        public IWebElement Mentalembracingdifferent1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article explores the importance of embracing ')]")]
        public IWebElement Mentalembracingdifferent2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Forest Bathing']")]
        public IWebElement Mentalforest { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Grieving is a natural response that can be overwhe')]")]
        public IWebElement Mentalgrief { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'As we go through life we will eventually experienc')]")]
        public IWebElement Mentalgriefworkplace { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The loss of a loved one is a painful experience. T')]")]
        public IWebElement Mentalmaid { get; set; }

        //MentalHealth1
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Healing the Invisible Wounds'])[1]")]
        public IWebElement Mentalhealingwounds { get; set; }
        [FindsBy(How = How.XPath, Using = "//P[text()=' Exploring Moral Injury in Healthcare ']")]
        public IWebElement Mentalhealingwounds1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When we feel safe, secure and well connected to ou')]")]
        public IWebElement MentalHealthy { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Are you approaching winter celebrations and the ho')]")]
        public IWebElement MentalHoliday { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Financial stress can affect more than your wallet;')]")]
        public IWebElement MentalHowtakingcare { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@href='/app/en/resources/category/permalink/mental-health']")]
        public IWebElement MentalHowtakingcaretag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When you feel overwhelmed, build a bigger picture.')]")]
        public IWebElement Mentalhowto { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'If you want to improve your self-confidence, you n')]")]
        public IWebElement Mentalhowincrease { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This podcast will briefly touch on some of the eff')]")]
        public IWebElement Mentalindigineouspeople { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Indigenous Peoples and Trauma'])[3]")]
        public IWebElement Mentalindigineouspeople1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Indigenous Peoples and Trauma'])[2]")]
        public IWebElement Mentalindigineouspeople2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Infertility is defined as the inability to conceiv')]")]
        public IWebElement Mentalinfertility { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Most people know that stress is something to reduc')]")]
        public IWebElement Mentalinterconnections { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Intimate Partner Violence']")]
        public IWebElement Mentalintimate { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Understanding the types of therapy available to yo')]")]
        public IWebElement MentalCBT { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Many people find it fairly easy to think of ways t')]")]
        public IWebElement MentalCBT1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Talking about mental health with friends, family, ')]")]
        public IWebElement MentalLetstalk { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'How would you rate your mental and emotional state')]")]
        public IWebElement MentalMaintaining { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Mental health checkup: preparing for the year ahead'])[2]")]
        public IWebElement Mentalhealthcheckup { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Modern Workplace Hazards'])[1]")]
        public IWebElement Mentalmodernworkplace1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Modern Workplace Hazards'])[2]")]
        public IWebElement Mentalmodernworkplace2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Moral injury is the damage done to one’s conscienc')]")]
        public IWebElement Mentalmoralinjury { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Moving Beyond Anxiety']")]
        public IWebElement Mentalmoving { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this video, we’re sharing information about how')]")]
        public IWebElement Mentalmywellness { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this podcast, we’re sharing information about h')]")]
        public IWebElement Mentalmywellness1 { get; set; }

        //MentalHealth2
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'There has been no other time in recent history whe')]")]
        public IWebElement Mentalnavigating { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'There are many stereotypes of masculinity. Men are')]")]
        public IWebElement Mentalnavigatingsupport { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Navigating Panic Disorder'])[1]")]
        public IWebElement Mentalnavigatingpanic { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Navigating Panic Disorder'])[2]")]
        public IWebElement Mentalnavigatingpanic1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'A phobia is an intense fear of something that, in ')]")]
        public IWebElement Mentalovercoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Most people are affected in some way, by a change ')]")]
        public IWebElement Mentalovercomingwinter { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In a review of forty-eight papers from eight longi')]")]
        public IWebElement Mentalpostpartem { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​A healthy amount of self-esteem gives us the resi')]")]
        public IWebElement Mentalraising { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Irrespective of age, culture or income, at least ')]")]
        public IWebElement Mentalreducingmental { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Thinking optimistically, rather than negatively or')]")]
        public IWebElement Mentalresponsibleoptimism { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The questions may start coming soon after having a')]")]
        public IWebElement Mentalsecondary { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Sexual Abuse and Sexual Harassment'])[1]")]
        public IWebElement Mentalsexualabuse { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Sexual Abuse and Sexual Harassment'])[2]")]
        public IWebElement Mentalsexualabuse1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Sex. It’s natural. It’s normal. It’s necessary. Bu')]")]
        public IWebElement Mentalsexualysfunction { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Do you know how to spot the signs of suicide? Lear')]")]
        public IWebElement Mentalspotting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'As we move into the last month of 2020, we know th')]")]
        public IWebElement Mentalstaying { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The relationship between addiction and stigma is u')]")]
        public IWebElement Mentalstigma { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Feeling stressed? Most of us feel pressured by the')]")]
        public IWebElement Mentalstress { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this video, we’ll look at stress categorically:')]")]
        public IWebElement Mentalstressfinding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this article, we’ll look at stress categoricall')]")]
        public IWebElement Mentalstressfinding2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this podcast, we’ll look at stress categoricall')]")]
        public IWebElement Mentalstressfinding3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The importance of mental health and overall well-b')]")]
        public IWebElement Mentalsuicideprevention { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'No matter what our age, cultural background or inc')]")]
        public IWebElement Mentalsupportingillness { get; set; }

        //MentalHealth3
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'For someone in recovery, the memories and celebrat')]")]
        public IWebElement Mentalsupportingholidays { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this podcast, we discuss letting go of the over')]")]
        public IWebElement Mentalsurviving { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'What can we do now to ensure we don’t end up payin')]")]
        public IWebElement Mentaltakingchargestress { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course can help you manage angry feelings and')]")]
        public IWebElement Mentaltakingcontrolanger { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Feelings of sadness are normal but sometimes they ')]")]
        public IWebElement Mentaltakingcontrolmood { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When a family member is working to improve their m')]")]
        public IWebElement Mentaltalkingtokids { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When was the last time you liked a post on Faceboo')]")]
        public IWebElement Mentaldangerssocial { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[80]//div[1]//div[1]//div[1]//div[1]//p[1]")]
        public IWebElement Mentalimpactof { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[80]//div[1]//div[1]//div[1]//div[1]//span[1]")]
        public IWebElement Mentalimpactof1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='The Intersection of Sexual Identity and Mental Health'])[1]")]
        public IWebElement Mentalintersectio1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='The Intersection of Sexual Identity and Mental Health'])[2]")]
        public IWebElement Mentalintersectio2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='The Many Faces of Anxiety']")]
        public IWebElement Mentalmanyfaces { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'PTSD does not discriminate; it can affect anyone r')]")]
        public IWebElement Mentalptsd { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='The Weight of Winter and Negative Thoughts'])[1]")]
        public IWebElement Mentalweightofwinter { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='The Weight of Winter and Negative Thoughts'])[2]")]
        public IWebElement Mentalweightofwinter1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Too Much Screen Time?']")]
        public IWebElement Mentaltoomuchscreen { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Too Much Screen Time? How It Affects Mental Health and What to Do About It']")]
        public IWebElement Mentaltoomuchscreen1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Trauma Informed Collaboration'])[1]")]
        public IWebElement Mentaltrauma { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Trauma Informed Collaboration'])[2]")]
        public IWebElement Mentaltrauma1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Everybody goes through ups and downs in their live')]")]
        public IWebElement Mentalunderstandingdepression { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Listen to myths, root causes, and how compassion c')]")]
        public IWebElement Mentalunderstandingeating { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Break the stigma around eating disorders. In this ')]")]
        public IWebElement Mentalunderstandingeating1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article breaks down what eating disorders are')]")]
        public IWebElement Mentalunderstandingeating2 { get; set; }

        //MentalHealth4
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The definition of mental health, the symptoms of m')]")]
        public IWebElement Mentalunderstandingmental { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this article, we discuss the criteria that make')]")]
        public IWebElement Mentalunderstandingchronic1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this podcast, we discuss the criteria that make')]")]
        public IWebElement Mentalunderstandingchronic2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this video, we discuss the criteria that make a')]")]
        public IWebElement Mentalunderstandingchronic3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Presented by: Sandy Kriegish, Clinical Manager and')]")]
        public IWebElement Mentalwebinar1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This session adopts a solutions-focused lens and e')]")]
        public IWebElement Mentalwebinar2{ get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Empathy is a key component of emotional intelligen')]")]
        public IWebElement Mentalwebinar3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Presented by Katherine Sisak, MSW, RSW, RP, this 1')]")]
        public IWebElement Mentalwebinar4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This session will provide participants with a high')]")]
        public IWebElement Mentalwebinar5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'What is mindfulness? What are its benefits? How ca')]")]
        public IWebElement Mentalwhatis { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​When living with Alzheimer’s or another form of d')]")]
        public IWebElement Mentalwhensomeone { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The onset of winter typically signifies the beginn')]")]
        public IWebElement Mentalwhennextceleb { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='When you Fear the Unknown: Coping with Uncertainty'])[1]")]
        public IWebElement Mentalwhenyoufear { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='When you Fear the Unknown: Coping with Uncertainty'])[2]")]
        public IWebElement Mentalwhenyoufear1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'A more in-depth look at women’s mental health, to ')]")]
        public IWebElement Mentalwomenhealth1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[111]//div[1]//div[1]//div[1]//div[1]//span[1]")]
        public IWebElement Mentalwomenhealth2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[112]//div[1]//div[1]//div[1]//div[1]//span[1]")]
        public IWebElement Mentalwomenhealth3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Women’s Mental Health'])[1]")]
        public IWebElement Mentalwomenhealth4 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Women’s Mental Health'])[2]")]
        public IWebElement Mentalwomenhealth5 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Women’s Mental Health: Concerns, Barriers and Support'])[1]")]
        public IWebElement Mentalwomenhealth6 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Women’s Mental Health: Concerns, Barriers and Support'])[2]")]
        public IWebElement Mentalwomenhealth7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'It’s no secret the emotions and actions of youth a')]")]
        public IWebElement Mentalyouthteen { get; set; }


        //Crisis
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Crisis']")]
        public IWebElement Crisis { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Many survivors of childhood sexual abuse experienc')]")]
        public IWebElement Crisischildhood { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Crisis']")]
        public IWebElement Crisistag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When major catastrophes happen they can overwhelm ')]")]
        public IWebElement Crisiscopingtraumatic { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Loss is an inevitable part of life. During our li')]")]
        public IWebElement Crisiscopingloss { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Everyone will deal with the death of a coworker di')]")]
        public IWebElement Crisiscopingcoworker { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Help you understand the reactions you may be exper')]")]
        public IWebElement Crisisukraine { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'As the months go by, the worldwide COVID-19 pandem')]")]
        public IWebElement Crisisemployeefatigue { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The trauma caused by acts of violence can and most')]")]
        public IWebElement Crisisexperiencingviolence { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In response to the recent social unrest taking pla')]")]
        public IWebElement Crisisexperiencingdisruptive { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Grieving is a natural response that can be overwhe')]")]
        public IWebElement Crisisgrief { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The loss of a loved one is a painful experience. T')]")]
        public IWebElement Crisismaid { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'While grieving is a natural process that we all go')]")]
        public IWebElement Crisislossofchild { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'One of the most difficult things an adult can face')]")]
        public IWebElement Crisishelpingchildren { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'After job loss or significant job change, many of ')]")]
        public IWebElement Crisishowtodeal { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In support of the families and communities impacte')]")]
        public IWebElement Crisisnovascotia { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When someone close to you passes away, not only ar')]")]
        public IWebElement Crisispractical { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Sexual Abuse and Sexual Harassment'])[1]")]
        public IWebElement Crisisabuse1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Sexual Abuse and Sexual Harassment'])[2]")]
        public IWebElement Crisisabuse2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The importance of mental health and overall well-b')]")]
        public IWebElement Crisissuicide { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Being witness to, or experiencing traumatic events')]")]
        public IWebElement Crisissupporting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Job loss or transition is a difficult process for')]")]
        public IWebElement Crisistakingcontrol { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​The Many Faces of Post-Traumatic Stress Disorder']")]
        public IWebElement Crisisptsd { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In recent years, it seems that an increasing numbe')]")]
        public IWebElement Crisiswhattodo { get; set; }

        //Crisiscovid19
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='COVID-19']")]
        public IWebElement Crisiscovid { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Hesitant about getting the new COVID-19 vaccine? H')]")]
        public IWebElement Crisiscovid10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/crisis/covid-19'][text()='COVID-19']")]
        public IWebElement Crisiscovidtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Five tips on taking care of your mental health dur')]")]
        public IWebElement Crisiscovidbeing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Knowing how to gather safely for celebrations is e')]")]
        public IWebElement Crisiscovidcelebrating { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Should I wear a face mask when I go out in public ')]")]
        public IWebElement Crisiscovid19masks { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Determine your risk of exposure and serious illnes')]")]
        public IWebElement Crisiscovid19assessment { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Find out more information about COVID-19 and its s')]")]
        public IWebElement Crisiscovid19symtoms { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[6]")]
        public IWebElement Crisiscovid19mental { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19: What is Languishing and Why is it Important?']")]
        public IWebElement Crisiscovid19languishing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='COVID-19: What to do if you get sick']")]
        public IWebElement Crisiscovid19sick { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'As the months go by, the worldwide COVID-19 pandem')]")]
        public IWebElement Crisiscovid19fatigue { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Hand Sanitizer Guide']")]
        public IWebElement Crisiscovid19sanitizer1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Hand Washing Guide']")]
        public IWebElement Crisiscovid19sanitizer2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this video, we explore how recent times have be')]")]
        public IWebElement Crisiscovid19healthy { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'If recent times have been tough on you and the peo')]")]
        public IWebElement Crisiscovid19healthy1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this podcast, we explore how recent times have ')]")]
        public IWebElement Crisiscovid19healthy2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Are you approaching winter celebrations and the ho')]")]
        public IWebElement Crisiscovid19holidaystress { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Intimate Partner Violence'])[1]")]
        public IWebElement Crisiscovid19intimate { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Intimate Partner Violence'])[2]")]
        public IWebElement Crisiscovid19intimate1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Intimate Partner Violence'])[3]")]
        public IWebElement Crisiscovid19intimate2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Living a Fulfilling Life'])[1]")]
        public IWebElement Crisiscovid19living { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Living a Fulfilling Life'])[2]")]
        public IWebElement Crisiscovid19living1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Living a Fulfilling Life'])[3]")]
        public IWebElement Crisiscovid19living2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'COVID-19’s enormous impact on our everyday lives c')]")]
        public IWebElement Crisiscovid19maintaining { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='Hosted by Katherine Sisak.']")]
        public IWebElement Crisiscovid19mentalduring { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Overcoming Financial Fatigue and Concern'])[1]")]
        public IWebElement Crisiscovid19overcoming { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Overcoming Financial Fatigue and Concern'])[2]")]
        public IWebElement Crisiscovid19overcoming1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='Tips for celebrating the holidays safely this year']")]
        public IWebElement Crisiscovid19preparing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article asks employers to consider the differ')]")]
        public IWebElement Crisiscovid19preparing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This podcast asks employers to consider the differ')]")]
        public IWebElement Crisiscovid19preparing2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This video asks employers to consider the differen')]")]
        public IWebElement Crisiscovid19preparing3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course features video segments of a psycholog')]")]
        public IWebElement Crisiscovid19resilience { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Sitting around at home more than usual? COVID-19 h')]")]
        public IWebElement Crisiscovid19stayingactive { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'As we move into the last month of 2020, we know th')]")]
        public IWebElement Crisiscovid19stayingconnected { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Some simple tips for staying safe and positive whi')]")]
        public IWebElement Crisiscovid19supporting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this video, we discuss letting go of the overwh')]")]
        public IWebElement Crisiscovid19surviving1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this podcast, we discuss letting go of the over')]")]
        public IWebElement Crisiscovid19surviving2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this article, we discuss letting go of the over')]")]
        public IWebElement Crisiscovid19surviving3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Thinking about how to manage stress may be the las')]")]
        public IWebElement Crisiscovid19taking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Stress']")]
        public IWebElement Crisiscovid19taking2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Taking Control of Your Mood']")]
        public IWebElement Crisiscovid19taking3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinar : Dealing with Seasonal Affective Disorder']")]
        public IWebElement Crisiscovid19webinar1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinar : The Second Wave and Your Mental Health']")]
        public IWebElement Crisiscovid19webinar2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This session helped participants understand anxiet')]")]
        public IWebElement Crisiscovid19webinar3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Webinar: COVID-19: Loneliness & Isolation Fatigue ')]")]
        public IWebElement Crisiscovid19webinar4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This session adopts a solutions-focused lens and e')]")]
        public IWebElement Crisiscovid19webinar5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Presented by Dr. Sandra Primiano, Ph.D., Psy.D, th')]")]
        public IWebElement Crisiscovid19webinar6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Presented by Cynthia Keys M.A., BEd., CCC., RCAT.,')]")]
        public IWebElement Crisiscovid19webinar7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When someone we love faces a serious illness our e')]")]
        public IWebElement Crisiscovid19whensomeone { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The onset of winter typically signifies the beginn')]")]
        public IWebElement Crisiscovid19whennext { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='You and Your Child - Coping with Vaccine Anxiety']")]
        public IWebElement Crisiscovid19youandyour { get; set; }

        //CririsMentalHealth

        [FindsBy(How = How.XPath, Using = "//a[@href='/app/en/resources/category/permalink/crisis/mental-health']")]
        public IWebElement Crisismental { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Although it’s normal to feel sad or upset from tim')]")]
        public IWebElement Crisismentaldepression { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@href='/app/en/resources/category/permalink/crisis/mental-health']")]
        public IWebElement Crisismentaltag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When major catastrophes happen they can overwhelm ')]")]
        public IWebElement Crisismentalcoping1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Loss is an inevitable part of life. During our li')]")]
        public IWebElement Crisismentalcoping2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Everyone will deal with the death of a coworker di')]")]
        public IWebElement Crisismentalcoping3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'As the months go by, the worldwide COVID-19 pandem')]")]
        public IWebElement Crisismentalemployee { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The trauma caused by acts of violence can and most')]")]
        public IWebElement Crisismentalexperience1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In response to the recent social unrest taking pla')]")]
        public IWebElement Crisismentalexperience2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Intimate Partner Violence'])[1]")]
        public IWebElement Crisismentalintimate1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Intimate Partner Violence'])[2]")]
        public IWebElement Crisismentalintimate2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='Hosted by Katherine Sisak.']")]
        public IWebElement Crisismentalhealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In support of the families and communities impacte')]")]
        public IWebElement Crisismentalnova { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Anyone can experience sexual abuse or sexual haras')]")]
        public IWebElement Crisismentalabuse { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The death of a close colleague or loved one is one')]")]
        public IWebElement Crisismentalsomeone { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Do you know how to spot the signs of suicide? Lear')]")]
        public IWebElement Crisismentalspotting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The importance of mental health and overall well-b')]")]
        public IWebElement Crisismentalsuicide { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Being witness to, or experiencing traumatic events')]")]
        public IWebElement Crisismentalsupporting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'No matter what our age, cultural background or inc')]")]
        public IWebElement Crisismentalsupporting1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Job loss or transition is a difficult process for')]")]
        public IWebElement Crisismentaltaking { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'PTSD does not discriminate; it can affect anyone r')]")]
        public IWebElement Crisismentalmanyfaces { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Listen to myths, root causes, and how compassion c')]")]
        public IWebElement CrisismentalUnderstanding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Break the stigma around eating disorders. In this ')]")]
        public IWebElement CrisismentalUnderstanding2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Presented by: Sandy Kriegish, Clinical Manager and')]")]
        public IWebElement Crisismentalwebinar1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This session helped participants understand anxiet')]")]
        public IWebElement Crisismentalwebinar2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Webinar: COVID-19: Loneliness & Isolation Fatigue ')]")]
        public IWebElement Crisismentalwebinar3 { get; set; }

        //CrisisParenting

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Parenting']")]
        public IWebElement Crisisparenting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'While grieving is a natural process that we all go')]")]
        public IWebElement Crisisparentinggrieving { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Parenting']")]
        public IWebElement Crisisparentingtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'One of the most difficult things an adult can face')]")]
        public IWebElement Crisisparentinghelping { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article will look at the different types of f')]")]
        public IWebElement Crisisparentingunderstanding { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Whether it’s holding hands, making out or having s')]")]
        public IWebElement Crisisparentingconsent { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@href='/app/en/resources/category/permalink/crisis/parenting']")]
        public IWebElement Crisisparentingtag1 { get; set; }

        //Family
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Family']")]
        public IWebElement Family { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Navigating and making gender-related changes is a ')]")]
        public IWebElement Familyresource { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/family'][text()='Family']")]
        public IWebElement Familytag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Kids respond differently to stress depending on t')]")]
        public IWebElement Familystress { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'An important part of establishing good sleeping ha')]")]
        public IWebElement Familybabies { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Come September, the carefree days of summers are r')]")]
        public IWebElement Familybackto { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Couples expecting their first baby can anticipate ')]")]
        public IWebElement Familybecoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'While many people celebrate and acknowledge romant')]")]
        public IWebElement Familybuilding { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Compared to a few decades ago, today’s men are muc')]")]
        public IWebElement Familycelebrating { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​All of us have some stress in our lives, but moth')]")]
        public IWebElement Familycelebrating1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Knowing how to gather safely for celebrations is e')]")]
        public IWebElement Familycelebrating2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'As a parent, one of the most important and complex')]")]
        public IWebElement Familychildcare { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The decision about who will take care of your chil')]")]
        public IWebElement Familychildcare1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We explore a wide range of contributing factors th')]")]
        public IWebElement Familychildren1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this video, we explore a wide range of contribu')]")]
        public IWebElement Familychildren2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this podcast, we explore a wide range of contri')]")]
        public IWebElement Familychildren3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Memories of long winter days are finally fading an')]")]
        public IWebElement Familychoosing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In a combined family, people come from different p')]")]
        public IWebElement Familycombining { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this session, Homewood Health will discuss the ')]")]
        public IWebElement Familycovid19 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When you reflect on your childhood you probably ha')]")]
        public IWebElement Familycreate { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Effective discipline isn’t about fear or force. It')]")]
        public IWebElement Familyeffective { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Balancing career responsibilities with family resp')]")]
        public IWebElement Familyeldercare { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Caregiving by its nature is not usually something ')]")]
        public IWebElement Familyemployees { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'During a separation and/or divorce, feelings of he')]")]
        public IWebElement Familyfamilylaw { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Caring for your parents or other seniors often req')]")]
        public IWebElement Familyfinancial1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Many families in Canada today carry credit card ba')]")]
        public IWebElement Familyfinancial2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Many parents reason that in order to get their chi')]")]
        public IWebElement Familyfoundations { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course is about developing parenting practice')]")]
        public IWebElement Familyfoundations1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The emotional and intellectual stages one passes t')]")]
        public IWebElement Familyfromkids { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Grandparents play a vital role in today’s society—')]")]
        public IWebElement Familygrand { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this podcast, we explore how recent times have ')]")]
        public IWebElement Familyhealthy { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'One of the most difficult things an adult can face')]")]
        public IWebElement Familyhelping { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'One of the most important decisions you will make ')]")]
        public IWebElement Familyhousing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Bed-wetting can be upsetting for the whole family.')]")]
        public IWebElement Familyhowto { get; set; }
        [FindsBy(How = How.XPath, Using = "(//P[text()=' Between the ages of two and five, children become more independent and assertive. They begin to walk, feed themselves, and their vocabulary increases almost on a daily basis. They learn to count and the rudiments of reading. Acquiring these and other skills leads to growing feelings of independence. '])[1]")]
        public IWebElement Familyhowto1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'To say that parenting is a journey of continued le')]")]
        public IWebElement Familyhowto2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When parents agree to separate, one of their more ')]")]
        public IWebElement Familyhowto3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'With so many pressures facing children and parents')]")]
        public IWebElement Familyimproving { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Infertility is defined as the inability to conceiv')]")]
        public IWebElement Familyinfertility { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Money. It is a simple five-letter word, but for ma')]")]
        public IWebElement Familyisittime { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Caring across the miles can be managed, but it wil')]")]
        public IWebElement Familylongdistance { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Having a baby is one of the most special times in ')]")]
        public IWebElement Familynewparent { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In a review of forty-eight papers from eight longi')]")]
        public IWebElement Familypostpartem { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Making a successful transition back to work after ')]")]
        public IWebElement Familypostpreparinglife { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'For most of us, retirement presents a new chapter ')]")]
        public IWebElement Familypreparing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Finding the time to care for and nurture our intim')]")]
        public IWebElement Familyrelationship { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Are you questioning whether you should stay in you')]")]
        public IWebElement Familyresolving { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The strong emotional bond a baby develops with mom')]")]
        public IWebElement Familysecure { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'More and more people are finding themselves caught')]")]
        public IWebElement Familyselfcare { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When a marriage or common-law relationship fails, ')]")]
        public IWebElement Familyseparation { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This year, in the spirit of practicing kindness an')]")]
        public IWebElement Familysetting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Being a parent is one of the most challenging jobs')]")]
        public IWebElement Familysingle { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The death of a close colleague or loved one is one')]")]
        public IWebElement Familysomeone { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Spirited children are also called challenging chil')]")]
        public IWebElement Familyspirited { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'As we move into the last month of 2020, we know th')]")]
        public IWebElement Familystaying { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'There are endless choices to be made about what to')]")]
        public IWebElement Familytaking { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'It is hard for many of us to accept that our child')]")]
        public IWebElement Familytalking { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When a family member is working to improve their m')]")]
        public IWebElement Familytalking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The digital revolution has given us new tools to m')]")]
        public IWebElement Familytech { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We are living in a time where there is convenient ')]")]
        public IWebElement Familytech1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Temper Tantrums']")]
        public IWebElement Familytantrums { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'It is beneficial for children to learn the value o')]")]
        public IWebElement Familygreatallowance { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'How family members related to each other – its dyn')]")]
        public IWebElement Familyimpact { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'A child’s happiness starts with a firm foundation ')]")]
        public IWebElement Familypositive { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Two out of every three Canadian women with childre')]")]
        public IWebElement Familyparent { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Raising happy, healthy teenagers has been a challe')]")]
        public IWebElement Familyteenagers { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article will look at the different types of f')]")]
        public IWebElement Familyunderstanding { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This podcast will briefly touch on the different t')]")]
        public IWebElement Familyunderstanding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'While the number of teens seen vaping seems to be ')]")]
        public IWebElement Familyvaping { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The onset of winter typically signifies the beginn')]")]
        public IWebElement Familywhenthe { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We all know that dealing with a 10 year-old is one')]")]
        public IWebElement Familyyour { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'It’s no secret the emotions and actions of youth a')]")]
        public IWebElement Familyyouth { get; set; }

        //FamilyCaregiving
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Caregiving']")]
        public IWebElement Familycaregiving { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'No one knows your parents as well as you do and no')]")]
        public IWebElement Familycaregivingparents { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/family/caregiving'][text()='Caregiving']")]
        public IWebElement Familycaregivingtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Balancing career responsibilities with family resp')]")]
        public IWebElement Familycaregivingelder { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Caregiving by its nature is not usually something ')]")]
        public IWebElement Familycaregivingemployees { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Caring for your parents or other seniors often req')]")]
        public IWebElement Familycaregivingfinancial { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'One of the most important decisions you will make ')]")]
        public IWebElement Familycaregivinghousing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Caring across the miles can be managed, but it wil')]")]
        public IWebElement Familycaregivinglong { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When someone requires 24-hour care, they often liv')]")]
        public IWebElement Familycaregivingrespite { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'More and more people are finding themselves caught')]")]
        public IWebElement Familycaregivingselfcare { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article will look at the different types of f')]")]
        public IWebElement Familycaregivingunder { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This podcast will briefly touch on the different t')]")]
        public IWebElement Familycaregivingunder1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This podcast will touch on the definition of menta')]")]
        public IWebElement Familycaregivingunder2 { get; set; }

        //FamilyCommunication
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Communication']")]
        public IWebElement Familycomm { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Navigating and making gender-related changes is a ')]")]
        public IWebElement Familycommtrans { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/family/communication'][text()='Communication']")]
        public IWebElement Familycommtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'While many people celebrate and acknowledge romant')]")]
        public IWebElement Familycommbuilding { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In a combined family, people come from different p')]")]
        public IWebElement Familycommcombining { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'With so many pressures facing children and parents')]")]
        public IWebElement Familycommimproving { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Finding the time to care for and nurture our intim')]")]
        public IWebElement Familycommrelationship { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'It is hard for many of us to accept that our child')]")]
        public IWebElement Familycommtalking { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When a family member is working to improve their m')]")]
        public IWebElement Familycommtalking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The digital revolution has given us new tools to m')]")]
        public IWebElement Familycommtech { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Raising happy, healthy teenagers has been a challe')]")]
        public IWebElement Familycommtodays { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Whether it’s holding hands, making out or having s')]")]
        public IWebElement Familycommconsent { get; set; }

        //FamilyFinances
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Finances']")]
        public IWebElement FamilyFin { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'How your financial well-being benefits your health')]")]
        public IWebElement FamilyFinben { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/family/finances'][text()='Finances']")]
        public IWebElement FamilyFintag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Financial and Mental Health']")]
        public IWebElement FamilyFinmental { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Achieving financial peace of mind is possible. By ')]")]
        public IWebElement FamilyFinconsultation { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Many families in Canada today carry credit card ba')]")]
        public IWebElement FamilyFinfitness { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When an individual decides to review their financi')]")]
        public IWebElement FamilyFinissues { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'5 simple financial self-care tips to help you achi')]")]
        public IWebElement FamilyFinselfcare { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Nearly 1/3 of Canadians spend about one hour each ')]")]
        public IWebElement FamilyFinstress { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The emotional and intellectual stages one passes t')]")]
        public IWebElement FamilyFinkidsto { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Money. It is a simple five-letter word, but for ma')]")]
        public IWebElement FamilyFintimefor { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Overcoming Financial Fatigue and Concern']")]
        public IWebElement FamilyFinovercoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We all know it’s never too soon to start saving fo')]")]
        public IWebElement FamilyFinplanning { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'For most of us, retirement presents a new chapter ')]")]
        public IWebElement FamilyFinpreparing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'There are endless choices to be made about what to')]")]
        public IWebElement FamilyFintaking { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'It is beneficial for children to learn the value o')]")]
        public IWebElement FamilyFinthe { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Debt can have a significant effect on our mental w')]")]
        public IWebElement FamilyFinthe1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='The Psychology of Debt'])[2]")]
        public IWebElement FamilyFinthe2 { get; set; }

        //FamilyParenting
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Parenting']")]
        public IWebElement FamilyParenting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Kids respond differently to stress depending on t')]")]
        public IWebElement FamilyParstress { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/family/parenting'][text()='Parenting']")]
        public IWebElement FamilyParstag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='ADHD and your family']")]
        public IWebElement FamilyParadhd { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'An important part of establishing good sleeping ha')]")]
        public IWebElement FamilyParbabies { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Often as summer days are winding down, it’s common')]")]
        public IWebElement FamilyParbackto { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Come September, the carefree days of summers are r')]")]
        public IWebElement FamilyParbackto1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Couples expecting their first baby can anticipate ')]")]
        public IWebElement FamilyParbecoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Compared to a few decades ago, today’s men are muc')]")]
        public IWebElement FamilyParcelebratingdads { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​All of us have some stress in our lives, but moth')]")]
        public IWebElement FamilyParcelebratingmoms { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'As a parent, one of the most important and complex')]")]
        public IWebElement FamilyParchildcare1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The decision about who will take care of your chil')]")]
        public IWebElement FamilyParchildcare2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This video will explore where children are current')]")]
        public IWebElement FamilyParchildren { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This podcast will explore where children are curre')]")]
        public IWebElement FamilyParchildren1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Memories of long winter days are finally fading an')]")]
        public IWebElement FamilyParchoosing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In a combined family, people come from different p')]")]
        public IWebElement FamilyParcombining { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When you reflect on your childhood you probably ha')]")]
        public IWebElement FamilyParcreate { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Effective discipline isn’t about fear or force. It')]")]
        public IWebElement FamilyPareffective { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Many parents reason that in order to get their chi')]")]
        public IWebElement FamilyParfoundations1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course is about developing parenting practice')]")]
        public IWebElement FamilyParfoundations2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Grandparenting']")]
        public IWebElement FamilyPargrand { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The loss of a loved one is a painful experience. T')]")]
        public IWebElement FamilyParMaid { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Helping Children and Teenagers Through the Loss of a Loved One']")]
        public IWebElement FamilyParhelping { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Bed-wetting can be upsetting for the whole family.')]")]
        public IWebElement FamilyParhowto { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[23]")]
        public IWebElement FamilyParhowto1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When parents agree to separate, one of their more ')]")]
        public IWebElement FamilyParhowto2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'With so many pressures facing children and parents')]")]
        public IWebElement FamilyParimproving { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Having a baby is one of the most special times in ')]")]
        public IWebElement FamilyParnewparent { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Making a successful transition back to work after ')]")]
        public IWebElement FamilyParpreparing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The strong emotional bond a baby develops with mom')]")]
        public IWebElement FamilyParsecure { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When a marriage or common-law relationship fails, ')]")]
        public IWebElement FamilyParseparation { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Single Parenting']")]
        public IWebElement FamilyParsingle { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Spirited children are also called challenging chil')]")]
        public IWebElement FamilyParspirited { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Spotting Signs of Suicide']")]
        public IWebElement FamilyParspotting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Talking to Your Kids About Drugs and Alcohol']")]
        public IWebElement FamilyPartalking { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When a family member is working to improve their m')]")]
        public IWebElement FamilyPartalking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Temper Tantrums']")]
        public IWebElement FamilyPartamper { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'How family members related to each other – its dyn')]")]
        public IWebElement FamilyPartheimpact { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'A child’s happiness starts with a firm foundation ')]")]
        public IWebElement FamilyParthepower { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Two out of every three Canadian women with childre')]")]
        public IWebElement FamilyPartheworking { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Raising happy, healthy teenagers has been a challe')]")]
        public IWebElement FamilyParteenagers { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'While the number of teens seen vaping seems to be ')]")]
        public IWebElement FamilyParvaping { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Whether it’s holding hands, making out or having s')]")]
        public IWebElement FamilyParconsent { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We all know that dealing with a 10 year-old is one')]")]
        public IWebElement FamilyParyour { get; set; }

        //LegalFinancial
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Legal & Financial']")]
        public IWebElement LegFin { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'During a separation and/or divorce, feelings of he')]")]
        public IWebElement LegFinFam { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Legal & Financial']")]
        public IWebElement LegFintag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Caring for your parents or other seniors often req')]")]
        public IWebElement LegFinmatters { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Achieving financial peace of mind is possible. By ')]")]
        public IWebElement LegFinconsultation { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Many families in Canada today carry credit card ba')]")]
        public IWebElement LegFinfitness { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When an individual decides to review their financi')]")]
        public IWebElement LegFinconsider { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The emotional and intellectual stages one passes t')]")]
        public IWebElement LegFinretirement { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Get Control of Your Money']")]
        public IWebElement LegFinget { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Many people these days are feeling very unsettled')]")]
        public IWebElement LegFinorder { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Financial stress can affect more than your wallet;')]")]
        public IWebElement LegFinhow { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Money. It is a simple five-letter word, but for ma')]")]
        public IWebElement LegFinisit { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Starting a new calendar year can be exciting and r')]")]
        public IWebElement LegFinovercoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Are you excited or apprehensive about retiring? Ch')]")]
        public IWebElement LegFinpre { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'For most of us, retirement presents a new chapter ')]")]
        public IWebElement LegFinretirementpre { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The purpose of this article is to give you a brief')]")]
        public IWebElement LegFinquestions { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Financial planners tell us it’s never too soon to ')]")]
        public IWebElement LegFincontent { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'On average, Canadians spend $1,137 apiece on food,')]")]
        public IWebElement LegFinspending { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'There are endless choices to be made about what to')]")]
        public IWebElement LegFintaking { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'It is beneficial for children to learn the value o')]")]
        public IWebElement LegFinallowance { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Real Estate law is the body of law that regulates ')]")]
        public IWebElement LegFinreal { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'More and more retirees are choosing to carry on do')]")]
        public IWebElement LegFinworking { get; set; }

        //LegalFinancialManagement
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Financial Management']")]
        public IWebElement LegFinMan { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Achieving financial peace of mind is possible. By ')]")]
        public IWebElement LegFinMancons { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/finances/financial-management'][text()='Financial Management']")]
        public IWebElement LegFinMantag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Many families in Canada today carry credit card ba')]")]
        public IWebElement LegFinManFitness { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Nearly 1/3 of Canadians spend about one hour each ')]")]
        public IWebElement LegFinManStress { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The emotional and intellectual stages one passes t')]")]
        public IWebElement LegFinManRetirement { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Many people these days are feeling very unsettled')]")]
        public IWebElement LegFinManGetting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Money. It is a simple five-letter word, but for ma')]")]
        public IWebElement LegFinManisit { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'On average, Canadians spend $1,137 apiece on food,')]")]
        public IWebElement LegFinManspending { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'There are endless choices to be made about what to')]")]
        public IWebElement LegFinMantaking { get; set; }

        //LegalFinancialLegal
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Legal']")]
        public IWebElement LFL { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'During a separation and/or divorce, feelings of he')]")]
        public IWebElement LFLFamily { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/finances/legal'][text()='Legal']")]
        public IWebElement LFLTag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The following article summaries key concepts and p')]")]
        public IWebElement LFLintro { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The purpose of this article is to give you a brief')]")]
        public IWebElement LFLQuestions { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Real Estate law is the body of law that regulates ')]")]
        public IWebElement LFLLaw { get; set; }

        //LegalFinancialMentalHealth
        [FindsBy(How = How.XPath, Using = "//a[@href='/app/en/resources/category/permalink/finances/mental-health']")]
        public IWebElement LFMental { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'How your financial situation affects your physical')]")]
        public IWebElement LFMentaPhysical { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/finances/mental-health'][text()='Mental Health']")]
        public IWebElement LFMentaltag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Achieving financial peace of mind is possible. By ')]")]
        public IWebElement LFMentalconsulatation { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Many families in Canada today carry credit card ba')]")]
        public IWebElement LFMentalfitness { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Nearly 1/3 of Canadians spend about one hour each ')]")]
        public IWebElement LFMentalstress { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Get Control of Your Money']")]
        public IWebElement LFMentalgetcontrol { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Financial stress can affect more than your wallet;')]")]
        public IWebElement LFMentalhow { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Starting a new calendar year can be exciting and r')]")]
        public IWebElement LFMentalovercoming { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Overcoming Financial Fatigue and Concern'])[2]")]
        public IWebElement LFMentalovercoming1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Financial planners tell us it’s never too soon to ')]")]
        public IWebElement LFMentalretire { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'On average, Canadians spend $1,137 apiece on food,')]")]
        public IWebElement LFMentalspending { get; set; }

        //Lifestyle
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Lifestyle']")]
        public IWebElement Lifetyle { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'All is calm? All is bright? Holiday stress can tur')]")]
        public IWebElement Lifetyletis { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle'][text()='Lifestyle']")]
        public IWebElement Lifetyletag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The term work-life balance is often misunderstood ')]")]
        public IWebElement Lifetyle10steps { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Few things have a greater impact on one’s life tha')]")]
        public IWebElement Lifetyle360 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Kids respond differently to stress depending on t')]")]
        public IWebElement Lifetylestress { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'You may have thought you had outgrown zits when yo')]")]
        public IWebElement Lifetyleacne { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Most people aren’t fond of change. We like our ha')]")]
        public IWebElement Lifetyladapting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Regardless of income, race, colour, religion or g')]")]
        public IWebElement Lifetyladdiction { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Arthritis involves more than 100 different condit')]")]
        public IWebElement Lifetylarthritis { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Prepare yourself for piles of leaves, a Thanksgivi')]")]
        public IWebElement LifetylAutumn { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'There are some who believe that addictive personal')]")]
        public IWebElement LifetylAvoiding { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Have you ever purchased a bunch of daffodils to su')]")]
        public IWebElement Lifetylbeyond { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'You may not be riding over 200 km a day in the Tou')]")]
        public IWebElement Lifetylbike { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Are you happy with how you look? Have you ever loo')]")]
        public IWebElement Lifetylbody { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We might not like to admit it, but most of us have')]")]
        public IWebElement Lifetylbreak { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Try this breathing technique that is designed to h')]")]
        public IWebElement Lifetylbreathe { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Building Healthy Relationships While Maintaining Individuality']")]
        public IWebElement Lifetylbuilding { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Our lives are full of ups and downs that bring joy')]")]
        public IWebElement Lifetylbuilding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We’ll all experience great highs and great lows du')]")]
        public IWebElement Lifetylbuilding2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ready to take your career to the next level… but n')]")]
        public IWebElement Lifetylcareer { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Compared to a few decades ago, today’s men are muc')]")]
        public IWebElement Lifetylcelebdad { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​All of us have some stress in our lives, but moth')]")]
        public IWebElement Lifetylcelebmom { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'As a parent, one of the most important and complex')]")]
        public IWebElement Lifetylchildcare { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Germs can easily find a home in the moist, dark co')]")]
        public IWebElement Lifetylcleanup { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​People need people — by nature, we are social bei')]")]
        public IWebElement Lifetylconnecting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Millions of Canadians use birth control, and yet m')]")]
        public IWebElement Lifetylcontraption { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Controlling Your Alcohol Consumption']")]
        public IWebElement Lifetylcontrolling { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When major catastrophes happen they can overwhelm ')]")]
        public IWebElement Lifetylcoping { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this article, we’ll be exploring the topic of p')]")]
        public IWebElement Lifetylcoping1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Everyone feels sad or down at times, and normally ')]")]
        public IWebElement Lifetylcoping2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Loss is an inevitable part of life. During our li')]")]
        public IWebElement Lifetylcoping3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Cosmetic Procedures']")]
        public IWebElement Lifetylcosmetic { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Seasonal Affective Disorder (SAD), often referred ')]")]
        public IWebElement LifetylDealing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Seasonal Affective Disorder (SAD) - often referred')]")]
        public IWebElement LifetylDealing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​If you work in policing, health care, transportat')]")]
        public IWebElement LifetylDealing2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Some people have experienced a serious illness, so')]")]
        public IWebElement Lifetyldisability { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Eating Healthy is one of the most important thing')]")]
        public IWebElement Lifetyleating { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'A common challenge in sticking to a healthy diet i')]")]
        public IWebElement Lifetyleating1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ecological grief is known as strong feelings of fe')]")]
        public IWebElement Lifetyleco { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cardiovascular disease or heart disease is the num')]")]
        public IWebElement Lifetylensuring { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Nearly everyone has been hurt by the actions or wo')]")]
        public IWebElement Lifetylfinding { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'You unload your bundle of groceries into the cupbo')]")]
        public IWebElement Lifetylfood { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course is about developing parenting practice')]")]
        public IWebElement Lifetylfoundations { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Get lost in travel without losing track of healthy')]")]
        public IWebElement Lifetylgetaway { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'If you are one of the millions of workers in Canad')]")]
        public IWebElement Lifetylgetting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Getting the Most From Medication']")]
        public IWebElement Lifetylgetting1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Whether this is your first or your tenth work expe')]")]
        public IWebElement Lifetylgoing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Grandparents play a vital role in today’s society—')]")]
        public IWebElement Lifetylgrandparent { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Grieving is a natural response that can be overwhe')]")]
        public IWebElement Lifetylgrief { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'During the holiday season, many of us find it chal')]")]
        public IWebElement Lifetylhappy { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Everyone enjoys a little shopping, a stroll in the')]")]
        public IWebElement Lifetylharmful { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Despite the fact there is a strong correlation bet')]")]
        public IWebElement Lifetylhealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​There is no getting around it. We are all aging. ')]")]
        public IWebElement Lifetylhealth1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'With the holidays upon us, there will be an endles')]")]
        public IWebElement Lifetylhealth2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'A garden provides so much &ndash; a bounty of whol')]")]
        public IWebElement Lifetylhealth3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When we feel safe, secure and well connected to ou')]")]
        public IWebElement Lifetylhealth4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We sometimes need to be reminded it’s the intangib')]")]
        public IWebElement Lifetylhealth5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Are you approaching winter celebrations with appre')]")]
        public IWebElement Lifetylholiday { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Scan the food labels on supermarket shelves. Do yo')]")]
        public IWebElement Lifetylhow { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When you feel overwhelmed, build a bigger picture.')]")]
        public IWebElement Lifetylhowavoid { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Festivals and holidays, especially those occurring')]")]
        public IWebElement Lifetylhowcombat { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'After job loss or significant job change, many of ')]")]
        public IWebElement Lifetylhowdeal { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Between the ages of two and five, children become ')]")]
        public IWebElement Lifetylhowpreschooler { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Defuse Entrenched Conflicts']")]
        public IWebElement Lifetylhowdefuse { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Improve Sleep']")]
        public IWebElement Lifetylhowsleep { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Increase Your Self-Confidence']")]
        public IWebElement Lifetylhowself { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Maintain a Healthy Relationship With Food']")]
        public IWebElement Lifetylmaintain { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Reduce Holiday Stress']")]
        public IWebElement Lifetylreduce { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Support Children Who Identify As LGBTQ2+']")]
        public IWebElement LifetylLGB { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Take the Chance to Express Yourself']")]
        public IWebElement Lifetylchance { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Tell Your Child About Your Separation or Divorce']")]
        public IWebElement Lifetylseparation { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Humour Therapy and the Power of Laughter']")]
        public IWebElement Lifetylhumour { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Take note of sounds around you. Shift your attenti')]")]
        public IWebElement LifetylIdentity { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Immigrant Employees Settling in North America'])[1]")]
        public IWebElement LifetylImmigrant { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Immigrant Employees Settling in North America'])[2]")]
        public IWebElement LifetylImmigrant1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Chances are good that one of your new year’s resol')]")]
        public IWebElement Lifetylimproving { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Most people know that stress is something to reduc')]")]
        public IWebElement Lifetylinterconnections { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Understanding the types of therapy available to yo')]")]
        public IWebElement LifetylCBT { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Money. It is a simple five-letter word, but for ma')]")]
        public IWebElement Lifetylmoney { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ready to take your health and well-being to the ne')]")]
        public IWebElement Lifetyljump { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='June is National Post-Traumatic Stress Disorder Awareness Month']")]
        public IWebElement Lifetyljune { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Keep Your Resolutions']")]
        public IWebElement Lifetylkeep { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Keeping Your Love Alive']")]
        public IWebElement Lifetylkeeping { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'There is much to know about eating disorders, and ')]")]
        public IWebElement Lifetyllearning { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Do you have an unhealthy habit that you would like')]")]
        public IWebElement Lifetyllearning1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Who doesn’t feel a little bewildered and overwhelm')]")]
        public IWebElement Lifetyllegal { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Today’s workplace is a reflection of our nation -')]")]
        public IWebElement LifetylLGBTQ { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We have heard it before, eating well and regular e')]")]
        public IWebElement LifetylLinking { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Living a Fulfilling Life'])[1]")]
        public IWebElement LifetylLiving { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Living a Fulfilling Life'])[2]")]
        public IWebElement LifetylLiving1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Living a Fulfilling Life'])[3]")]
        public IWebElement LifetylLiving2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Looking on the Bright Side... Outside']")]
        public IWebElement LifetylLooking { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'How would you rate your mental and emotional state')]")]
        public IWebElement Lifetylmaintaining { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'It’s time for the razzle-dazzle of holiday windows')]")]
        public IWebElement Lifetylmaintaining1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Managing Workplace Stress']")]
        public IWebElement Lifetylmanaging { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Work-life balance is an individual measurement and')]")]
        public IWebElement Lifetylmetimeg { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Meditation is often recommended as a way of reduci')]")]
        public IWebElement Lifetylmeditation { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Men and women experience many of the same mental ')]")]
        public IWebElement Lifetylmens { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Mental Illness Mythbusters']")]
        public IWebElement Lifetylmentalillness { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Every person can benefit from mindfulness meditati')]")]
        public IWebElement Lifetylmindfulness { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Were you ever afraid of the dark when you were a c')]")]
        public IWebElement Lifetylmoving { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'There has been no other time in recent history whe')]")]
        public IWebElement Lifetylnavigating { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='New Parent Support']")]
        public IWebElement Lifetylnewparent { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Nutritional Coaching']")]
        public IWebElement Lifetylnutritional { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Overcoming Phobias']")]
        public IWebElement Lifetylovercoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Overcoming the Winter Weather Blues']")]
        public IWebElement Lifetylovercoming1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Being in recovery can sometimes feel like you have')]")]
        public IWebElement Lifetylpositive { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Are you excited or apprehensive about retiring? Ch')]")]
        public IWebElement Lifetylpre { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Time to pack away the decorations, organize the ho')]")]
        public IWebElement Lifetylpreparing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'For most of us, retirement presents a new chapter ')]")]
        public IWebElement Lifetylpreparing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Post-traumatic stress disorder (PTSD) is most ofte')]")]
        public IWebElement Lifetylptsd { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Race and ethnicity are often used interchangeably ')]")]
        public IWebElement Lifetylrace { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​A healthy amount of self-esteem gives us the resi')]")]
        public IWebElement Lifetylraising { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Congratulations! You made it through the holiday s')]")]
        public IWebElement Lifetylreenergizing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The holidays are a wonderful time of year, but it ')]")]
        public IWebElement Lifetylreducing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Irrespective of age, culture or income, at least ')]")]
        public IWebElement Lifetylreducingmental { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Conflict is inevitable in all relationships. Under')]")]
        public IWebElement Lifetylrelationshipdis { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Finding the time to care for and nurture our intim')]")]
        public IWebElement Lifetylrelationshipsol { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Resilience']")]
        public IWebElement Lifetylresilience { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Resilience Through Chronic Physical Conditions']")]
        public IWebElement Lifetylresiliencecond { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Resolving Conflict in Intimate Relationships']")]
        public IWebElement Lifetylresolving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Responsible Optimism']")]
        public IWebElement Lifetylresponsible { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Restoring Trust After Infidelity']")]
        public IWebElement Lifetylrestoring { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'With evolving demands, challenges faced in our eve')]")]
        public IWebElement Lifetylselfcare { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Separation and Divorce']")]
        public IWebElement Lifetyldivorce { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Setting Healthy Holiday Boundaries']")]
        public IWebElement Lifetylsetting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Shift Worker Support']")]
        public IWebElement Lifetylshift { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Being a parent is one of the most challenging jobs')]")]
        public IWebElement Lifetylsingle { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Do you wake up each morning without the aid of an ')]")]
        public IWebElement Lifetylsleep { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'If you are a smoker who has tried quitting, you kn')]")]
        public IWebElement Lifetylsmoking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Social Networking: Give a Lift to Your Life']")]
        public IWebElement Lifetylsocial { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Someone Close To You Ends Their Life by Suicide: Getting through a difficult time']")]
        public IWebElement Lifetylsomeone { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Someone Close to You Has Passed Away']")]
        public IWebElement Lifetylsomeone1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Someone Close to You Has Passed Away: Mourning and What You can Expect']")]
        public IWebElement Lifetylsomeone2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stop Being so Busy']")]
        public IWebElement Lifetylstop { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stop Smoking and Get Your Life Back!']")]
        public IWebElement Lifetylsmoking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'With the growing awareness of how social media can')]")]
        public IWebElement Lifetylstudent { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Summer Skin Hazards']")]
        public IWebElement Lifetylsummerskin { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting First Responders']")]
        public IWebElement Lifetylsupporting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Someone With a Mental Illness']")]
        public IWebElement Lifetylsupporting1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Those in Recovery During the Holidays']")]
        public IWebElement Lifetylsupporting2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Thinking about how to manage stress may be the las')]")]
        public IWebElement Lifetyltakingstress1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'What can we do now to ensure we don’t end up payin')]")]
        public IWebElement Lifetyltakingstress2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course is for anyone who is trying to control')]")]
        public IWebElement Lifetyltakingcontrol { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course can help you manage angry feelings and')]")]
        public IWebElement Lifetyltakingcontrol1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Job loss or transition is a difficult process for')]")]
        public IWebElement Lifetyltakingcontrol2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Most people feel that they are under “higher than ')]")]
        public IWebElement Lifetyltakingcontrol3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'A satisfying career comes about as a result of str')]")]
        public IWebElement Lifetyltakingcontrol4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Feelings of sadness are normal but sometimes they ')]")]
        public IWebElement Lifetyltakingcontrol5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Mental illness is the leading cause of disability')]")]
        public IWebElement Lifetyltalking { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'It is hard for many of us to accept that our child')]")]
        public IWebElement Lifetyltalking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When a family member is working to improve their m')]")]
        public IWebElement Lifetyltalking2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Technology and Relationships']")]
        public IWebElement Lifetyltech { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Eating a wide variety of fresh, vitamin-rich foods')]")]
        public IWebElement Lifetylbenefits { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'While adjusting to night work may never be complet')]")]
        public IWebElement Lifetylbiology { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cosmetic surgery is becoming mainstream and, for b')]")]
        public IWebElement Lifetylcosmeticsurgery { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When was the last time you liked a post on Faceboo')]")]
        public IWebElement Lifetyldangers { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='The Healing Power of Helping Others']")]
        public IWebElement Lifetylhealing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Impact of Alcohol']")]
        public IWebElement Lifetylimpactalcohol { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Impact of Sleep on Your Health']")]
        public IWebElement Lifetylimpactsleep { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Impact of Technology on Family Dynamics']")]
        public IWebElement Lifetylimpacttech { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Importance of Relaxation']")]
        public IWebElement Lifetylimportance { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Importance of Sleep']")]
        public IWebElement Lifetylimportancesleep { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Invisible Wounds of Mental Health Disorders']")]
        public IWebElement Lifetylinvisible { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Link Between Concussion and Depression']")]
        public IWebElement Lifetylthelink { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Anxiety, regardless of a person’s psychological or')]")]
        public IWebElement Lifetylthemany { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​The Many Faces of Post-Traumatic Stress Disorder']")]
        public IWebElement Lifetyltheptsd { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Power of a Positive Attitude']")]
        public IWebElement Lifetylthepower { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Sobering Facts About Addiction']")]
        public IWebElement Lifetylthesobering { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Weight of Winter and Negative Thoughts']")]
        public IWebElement Lifetyltheweight { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Two out of every three Canadian women with childre')]")]
        public IWebElement Lifetyltheworking { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Times are tight &ndash; and so are your shoulders.')]")]
        public IWebElement Lifetyltips { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Raising happy, healthy teenagers has been a challe')]")]
        public IWebElement Lifetyltodays { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Too Much Screen Time?'])[1]")]
        public IWebElement Lifetyltoomuch { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Too Much Screen Time?'])[2]")]
        public IWebElement Lifetyltoomuch1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Approximately three million Canadians have an anxi')]")]
        public IWebElement Lifetyluncovering { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Gone are the days when you bounced out of bed rea')]")]
        public IWebElement Lifetylunderstanding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Depression']")]
        public IWebElement Lifetylunderstanding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Understanding Family Dynamics']")]
        public IWebElement Lifetylunderstanding2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Do you remember how you felt on your last vacation')]")]
        public IWebElement Lifetylvacation { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'While the number of teens seen vaping seems to be ')]")]
        public IWebElement Lifetylvaping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Visualization']")]
        public IWebElement Lifetylvisualization { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'For most of us, the holiday season can be a fun an')]")]
        public IWebElement Lifetylwellness { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'A model of anger breaks your anger down into small')]")]
        public IWebElement Lifetylwhat { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='What Is Mindfulness, and How Can I Practise It?']")]
        public IWebElement Lifetylpractiseit { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='When Habits Become Addictions']")]
        public IWebElement Lifetylwhenhabits { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='When Someone Close to You Has a Serious Illness']")]
        public IWebElement Lifetylwhensomeone { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Why Good Posture Matters']")]
        public IWebElement Lifetylwhygood { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Winter Weather Well-being']")]
        public IWebElement Lifetylwinter { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Wintertime Health and Safety']")]
        public IWebElement Lifetylwintertime { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'A more in-depth look at women’s mental health, to ')]")]
        public IWebElement Lifetylwomen { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'More and more retirees are choosing to carry on do')]")]
        public IWebElement Lifetylworking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Working Around the Clock']")]
        public IWebElement Lifetylworking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Has something traumatic recently occurred in your ')]")]
        public IWebElement Lifetylyouhave { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Youth, Teens and Mental Health']")]
        public IWebElement Lifetylyouth { get; set; }

        //LifestyleAddiction
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Addiction']")]
        public IWebElement Lifetyladd { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Regardless of income, race, colour, religion or g')]")]
        public IWebElement Lifetyladdrecovery { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle/addiction'][text()='Addiction']")]
        public IWebElement Lifetyladdtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'There are some who believe that addictive personal')]")]
        public IWebElement Lifetyladdsubs { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We might not like to admit it, but most of us have')]")]
        public IWebElement Lifetyladdbreak { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The immediate effect of alcohol is that reactions ')]")]
        public IWebElement Lifetyladdcontrolling { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'During your recovery, you need to allow yourself t')]")]
        public IWebElement Lifetyladddating { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Everyone enjoys a little shopping, a stroll in the')]")]
        public IWebElement Lifetyladdharmless { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How Empathy Can Support Someone In Recovery']")]
        public IWebElement Lifetyladdhow { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Being in recovery can sometimes feel like you have')]")]
        public IWebElement Lifetyladdpositive { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'One of the often-overlooked challenges with addict')]")]
        public IWebElement Lifetyladdsupporting { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Supporting those with Addiction'])[2]")]
        public IWebElement Lifetyladdsupporting1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Supporting those with Addiction'])[3]")]
        public IWebElement Lifetyladdsupporting2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course is for anyone who is trying to control')]")]
        public IWebElement Lifetyladdtaking { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We are living in a time where there is convenient ')]")]
        public IWebElement Lifetyladdtech { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When was the last time you liked a post on Faceboo')]")]
        public IWebElement Lifetyladddangers { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Most people know that drunk driving is dangerous, ')]")]
        public IWebElement Lifetyladdalcohol { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Addiction does not discriminate. Regardless of age')]")]
        public IWebElement Lifetyladdsobering { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Listen to myths, root causes, and how compassion c')]")]
        public IWebElement Lifetyladdunderstanding { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Break the stigma around eating disorders. In this ')]")]
        public IWebElement Lifetyladdunderstanding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article breaks down what eating disorders are')]")]
        public IWebElement Lifetyladdunderstanding2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vaping: The New Teen Addiction']")]
        public IWebElement Lifetyladdvaping { get; set; }

        //LifestyleCareerDevelopment
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle/career-development'][text()='Career Development']")]
        public IWebElement Lifetylcareerdev { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this article, we explore the definition of burn')]")]
        public IWebElement Lifetylcareerdevburn { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle/career-development'][text()='Career Development']")]
        public IWebElement Lifetylcareerdevtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ready to take your career to the next level… but n')]")]
        public IWebElement Lifetylcareerdevcareer { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This podcast describes why it is so fundamental fo')]")]
        public IWebElement Lifetylcareerdevcreating { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Demotions can occur for a variety of reasons: comp')]")]
        public IWebElement Lifetylcareerdeveffectively { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Health-Promoting Leadership Strategies']")]
        public IWebElement Lifetylcareerdevhealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How Can I Cope With My Feelings About the Future?']")]
        public IWebElement Lifetylcareerdevhow { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Get the Information You Need From a Job Interview']")]
        public IWebElement Lifetylcareerdevhowjob { get; set; }

        //LifestyleChildcare

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Childcare']")]
        public IWebElement Lifetylchild { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='A Stress Check-Up for Kids']")]
        public IWebElement Lifetylchildstress { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle/childcare'][text()='Childcare']")]
        public IWebElement Lifetylchildcaretag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='ADHD and your family']")]
        public IWebElement Lifetylchildcareadhd { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Are You Ready for Another Child?']")]
        public IWebElement Lifetylchildcareare { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'An important part of establishing good sleeping ha')]")]
        public IWebElement Lifetylchildcarebabies { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Baby Care Safety Tips']")]
        public IWebElement Lifetylchildcarebaby { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Back to School: A Healthy Start']")]
        public IWebElement Lifetylchildcareback { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Becoming a Parent']")]
        public IWebElement Lifetylchildcarebecoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Bedwetting and Kids Away from Home']")]
        public IWebElement Lifetylchildcarebedwetting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Bedwetting and the Holidays']")]
        public IWebElement Lifetylchildcarebedwetting1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Bedwetting: Back to School']")]
        public IWebElement Lifetylchildcarebedwetting2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Breast-feeding: Getting Started']")]
        public IWebElement Lifetylchildcarebreast { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Children have thinner and more delicate skin than ')]")]
        public IWebElement Lifetylchildcarecaring { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Premature babies, or preemies, particularly those ')]")]
        public IWebElement Lifetylchildcarecaring1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Compared to a few decades ago, today’s men are muc')]")]
        public IWebElement Lifetylchildcaredads { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​All of us have some stress in our lives, but moth')]")]
        public IWebElement Lifetylchildcaremoms { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Childcare and Parenting']")]
        public IWebElement Lifetylchildcare1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Childcare Checklists']")]
        public IWebElement Lifetylchildcare2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Childhood Vaccines: Is Your Child Fully Protected?']")]
        public IWebElement Lifetylchildcarechildhood { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Choosing a Summer Camp']")]
        public IWebElement Lifetylchildcarechoosing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In a combined family, people come from different p')]")]
        public IWebElement Lifetylchildcarecombining { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When you reflect on your childhood you probably ha')]")]
        public IWebElement Lifetylchildcarecreate { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dry Mornings for Bedwetters']")]
        public IWebElement Lifetylchildcaredry { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Eating for Two - Nutrition During Pregnancy']")]
        public IWebElement Lifetylchildcareeating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Effective Discipline']")]
        public IWebElement Lifetylchildcareeffective { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Foundations of Effective Parenting'])[1]")]
        public IWebElement Lifetylchildcarefoundations { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Foundations of Effective Parenting'])[2]")]
        public IWebElement Lifetylchildcarefoundations1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Grandparents play a vital role in today’s society—')]")]
        public IWebElement Lifetylchildcaregrand { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Halloween brings potential health and safety hazar')]")]
        public IWebElement Lifetylchildcarehalloween { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Bed-wetting can be upsetting for the whole family.')]")]
        public IWebElement Lifetylchildcarehow { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Between the ages of two and five, children become ')]")]
        public IWebElement Lifetylchildcarehow1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'To say that parenting is a journey of continued le')]")]
        public IWebElement Lifetylchildcarehow2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When parents agree to separate, one of their more ')]")]
        public IWebElement Lifetylchildcarehow3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Did you know that some children have a higher risk')]")]
        public IWebElement Lifetylchildcareisyour { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Kicks, Rolls, and Other In-Utero Moves']")]
        public IWebElement Lifetylchildcarekicks { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Breast-feeding Issues']")]
        public IWebElement Lifetylchildcaremanaging { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='New Parent Support']")]
        public IWebElement Lifetylchildcarenewparent { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Online Life: Is It Healthy?']")]
        public IWebElement Lifetylchildcareonline { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Planning for Maternity Leave']")]
        public IWebElement Lifetylchildcareplanning { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='School Health and Happiness']")]
        public IWebElement Lifetylchildcareschool { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Secure Attachments']")]
        public IWebElement Lifetylchildcaresecure { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Separation and Divorce']")]
        public IWebElement Lifetylchildcareseparation { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Single Parenting']")]
        public IWebElement Lifetylchildcaresingle { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Spirited Children']")]
        public IWebElement Lifetylchildcarespirited { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Talking to Your Kids About Drugs and Alcohol']")]
        public IWebElement Lifetylchildcaretalking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Technology and Screen Time']")]
        public IWebElement Lifetylchildcaretech { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'You may be aware of what bedwetting is, but do you')]")]
        public IWebElement Lifetylchildcareimpact { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'A child’s happiness starts with a firm foundation ')]")]
        public IWebElement Lifetylchildcarepower { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Two out of every three Canadian women with childre')]")]
        public IWebElement Lifetylchildcareworking { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This podcast will briefly touch on the different t')]")]
        public IWebElement Lifetylchildcareunderstanding { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'There is no reason to watch your child suffer from')]")]
        public IWebElement Lifetylchildcarevaccination { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Whether it’s holding hands, making out or having s')]")]
        public IWebElement Lifetylchildcarewhatconsent { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'What should you do if you notice a rash on your ch')]")]
        public IWebElement Lifetylchildcarewhatdo { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Trudging through the winter months, we bundle our ')]")]
        public IWebElement Lifetylchildcareworkingout { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We all know that dealing with a 10 year-old is one')]")]
        public IWebElement Lifetylchildcareyouth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'It’s no secret the emotions and actions of youth a')]")]
        public IWebElement Lifetylchildcareyouth1 { get; set; }

        //LifestyleCommunication

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Communication']")]
        public IWebElement Lifetylcommunication { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'While many people celebrate and acknowledge romant')]")]
        public IWebElement Lifetylcommbuild { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle/communication'][text()='Communication']")]
        public IWebElement Lifetylcommtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Defuse Entrenched Conflicts']")]
        public IWebElement Lifetylcommdefuse { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'To say that parenting is a journey of continued le')]")]
        public IWebElement Lifetylcommlgbtq { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Conflict is inevitable in all relationships. Under')]")]
        public IWebElement Lifetylcommrelation { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Finding the time to care for and nurture our intim')]")]
        public IWebElement Lifetylcommsolution { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Trust in a relationship is usually based on recipr')]")]
        public IWebElement Lifetylcommrestoring { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The digital revolution has given us new tools to m')]")]
        public IWebElement Lifetylcommtech { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this article, we will explore how screen time a')]")]
        public IWebElement Lifetylcommtoo { get; set; }

        //LifestyleDiseaseManagement

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Disease Management']")]
        public IWebElement LifetylDisMan { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Feeling overwhelmed by everything you need to do t')]")]
        public IWebElement LifetylDisman10easy { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle/conditions-and-disease-management'][text()='Disease Management']")]
        public IWebElement LifetylDismantag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Feeling overwhelmed by everything you have to do t')]")]
        public IWebElement LifetylDisman10must { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Are you taking medication as part of your psoriasi')]")]
        public IWebElement LifetylDisman10things { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Want to maintain your ability? Here are 10 things ')]")]
        public IWebElement LifetylDisman10tips { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Soaps, moisturizers, TLC: all help manage your pso')]")]
        public IWebElement LifetylDisman5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='5 Winter Heart Risks']")]
        public IWebElement LifetylDisman5winter { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'An active lifestyle is the key to keeping fit and ')]")]
        public IWebElement LifetylDismanactive { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='AFib: 5 Outdoor Exercise Ideas!']")]
        public IWebElement LifetylDismanafib { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Planning to fly during the flu season? As you prep')]")]
        public IWebElement LifetylDismanairtravel { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Millions of Canadians suffer from allergies and as')]")]
        public IWebElement LifetylDismanallergy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Allergy Prevention and Treatment']")]
        public IWebElement LifetylDismanprevention { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='Do you know what you need to about anemia?']")]
        public IWebElement LifetylDismananaemia { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Are you at risk for atrial fibrillation? Find out ')]")]
        public IWebElement LifetylDismanrisk { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Over 6 million Canadians have some form of arthrit')]")]
        public IWebElement LifetylDismanarthritis { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'More than half of all Canadians with asthma do not')]")]
        public IWebElement LifetylDismanashtma { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='Do you know how to manage and treat asthma?']")]
        public IWebElement LifetylDismanashtma1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Want to get the most out of your skin cancer treat')]")]
        public IWebElement LifetylDismanbe { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'If you have cancer, you might be nervous at the th')]")]
        public IWebElement LifetylDismancancer { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Medical research focuses on how to treat and beat ')]")]
        public IWebElement LifetylDismancancertips { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'On weekends and after school, your kids have more ')]")]
        public IWebElement LifetylDismanchildhood { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ever wondered whether managing your cholesterol wa')]")]
        public IWebElement LifetylDismancholestoral { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'COPD is a chronic lung disease that affects many C')]")]
        public IWebElement LifetylDismanchronic { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Colorectal cancer is the third most common cancer ')]")]
        public IWebElement LifetylDismancolorectal { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Have you used a herbal remedy to relieve a headach')]")]
        public IWebElement LifetylDismancompl { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'There are many different treatments available for ')]")]
        public IWebElement LifetylDismancoping { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'What is CRP, and how does it relate to cholesterol')]")]
        public IWebElement LifetylDismancrp { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Did you know that you can reduce your risk of cert')]")]
        public IWebElement LifetylDismancutting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Diabetes is a chronic condition and requires speci')]")]
        public IWebElement LifetylDismandiabetes { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When you have diabetes, controlling your blood sug')]")]
        public IWebElement LifetylDismandiabetes1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Diabetes can affect many parts of your body and in')]")]
        public IWebElement LifetylDismandiabetes2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Diabetes is a serious condition that affects the b')]")]
        public IWebElement LifetylDismandiabetes3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Most of us have had diarrhea at some point in our ')]")]
        public IWebElement LifetylDismandiarrhea { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Are you seeing a dermatologist for your psoriasis?')]")]
        public IWebElement LifetylDismandoyou { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'So, you caught a cold. Not surprising, considering')]")]
        public IWebElement LifetylDismandoit { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[34]")]
        public IWebElement LifetylDismandont { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'If you have a drug allergy, taking a medication th')]")]
        public IWebElement LifetylDismandrug { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Your infant scrapes her tiny, razor-sharp nails ac')]")]
        public IWebElement LifetylDismaneczema { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Your infant scrapes her tiny, razor-sharp nails ac')]")]
        public IWebElement LifetylDismaneczema1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Erectile dysfunction is a major downer (pun intend')]")]
        public IWebElement LifetylDismanerectile { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We get most of our information about the world fro')]")]
        public IWebElement LifetylDismaneye { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Eye symptoms can be signs of infection, irritation')]")]
        public IWebElement LifetylDismaneyesym { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Like the rest of your body, your eyes can deterior')]")]
        public IWebElement LifetylDismaneyesight { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Develop a battle plan against the flu this year. K')]")]
        public IWebElement LifetylDismanflu { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Two types of HPV cause approximately 90% of cases ')]")]
        public IWebElement LifetylDismangenital { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Two types of HPV cause approximately 90% of cases ')]")]
        public IWebElement LifetylDismanhealthy { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Having high cholesterol puts you at an increased r')]")]
        public IWebElement LifetylDismanheart { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'What is the link between clean teeth and a healthy')]")]
        public IWebElement LifetylDismanheartfacts { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Heart disease is the leading killer of Canadians. ')]")]
        public IWebElement LifetylDismanhearthealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When you have multiple sclerosis (MS), the last th')]")]
        public IWebElement LifetylDismanhelp { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Each year, the Canadian Hypertension Education Pro')]")]
        public IWebElement LifetylDismanhigh { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Home Testing Kits']")]
        public IWebElement LifetylDismanhome { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How MS Medications Are Given']")]
        public IWebElement LifetylDismanhowMS { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Prevent a Second Stroke']")]
        public IWebElement LifetylDismanhowtoprevent { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Talk to Your Doctor']")]
        public IWebElement LifetylDismanhowtotalk { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[1]//div[1]//div[1]//div[1]//div[1]")]
        public IWebElement LifetylDismanHPV { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='HPV Facts and Myths']")]
        public IWebElement LifetylDismanHPV1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='HPV Vaccination']")]
        public IWebElement LifetylDismanHPV2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='HPV: Visiting Your Doctor']")]
        public IWebElement LifetylDismanHPV3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'More than 3 million Canadians have diabetes, and m')]")]
        public IWebElement LifetylDismanimpaired { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Impetigo']")]
        public IWebElement LifetylDismanimpetigo { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Integrative Medicine: the ABCs']")]
        public IWebElement LifetylDismanintegrative { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Most people know that stress is something to reduc')]")]
        public IWebElement LifetylDismaninterconnections { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'One of the first things people see is your smile..')]")]
        public IWebElement LifetylDismankeeping { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'You can live a healthy life despite having atrial ')]")]
        public IWebElement LifetylDismankeeping1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Do you know what asthma is - and whether you have ')]")]
        public IWebElement LifetylDismanlearn { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Learn About Osteoporosis']")]
        public IWebElement LifetylDismanlearn1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Use these strategies to tackle the social and emot')]")]
        public IWebElement LifetylDismanliving { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Living with psoriasis presents a variety of challe')]")]
        public IWebElement LifetylDismanliving1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'If you have MS, you likely want to do everything y')]")]
        public IWebElement LifetylDismanmake { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Prostate cancer is cancer of the prostate gland. I')]")]
        public IWebElement LifetylDismanmanaging { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Are you living your life to the fullest? Have you ')]")]
        public IWebElement LifetylDismanmoretime { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Nearly half of people with MS suffer from depressi')]")]
        public IWebElement LifetylDismanmsdepression { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS and Employment']")]
        public IWebElement LifetylDismanmsemp { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS and Exercise']")]
        public IWebElement LifetylDismanmsexe { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS and Healthy Eating']")]
        public IWebElement LifetylDismanmshealthy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS and Memory']")]
        public IWebElement LifetylDismanmsmemory { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS and Nutrition']")]
        public IWebElement LifetylDismanmsnutrition { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS and Pregnancy']")]
        public IWebElement LifetylDismanmspreg { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS and Quality Sleep']")]
        public IWebElement LifetylDismanmsquality { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS and Sexuality']")]
        public IWebElement LifetylDismanmssex { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS and Spasticity']")]
        public IWebElement LifetylDismanmsspa { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS and Travel']")]
        public IWebElement LifetylDismanmstravel { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS and Your Support Network']")]
        public IWebElement LifetylDismanmssupport { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS Medication Self-Injection']")]
        public IWebElement LifetylDismanmsmedication { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS Medication Side Effects']")]
        public IWebElement LifetylDismanmsmedication1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Back to School']")]
        public IWebElement LifetylDismanmsback { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Bowel and Bladder Issues']")]
        public IWebElement LifetylDismanmsbowel { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Cognitive Function']")]
        public IWebElement LifetylDismanmscog { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Controlling Pain']")]
        public IWebElement LifetylDismanmscontrol { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Coping with Fatigue']")]
        public IWebElement LifetylDismanmscoping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Dealing with Relapses']")]
        public IWebElement LifetylDismanmsdealing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Dealing with Tremor']")]
        public IWebElement LifetylDismanmsdealing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Doctor Visits']")]
        public IWebElement LifetylDismanmsdoctor { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Exercise Tips']")]
        public IWebElement LifetylDismanmsexercise { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Facts and Myths']")]
        public IWebElement LifetylDismanmsfacts { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Have Faith']")]
        public IWebElement LifetylDismanmshave { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Help at Home']")]
        public IWebElement LifetylDismanmshelp { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Internet Information Tips']")]
        public IWebElement LifetylDismanmsinternet { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Managing Stress']")]
        public IWebElement LifetylDismanmsmanaging { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Managing Your Medications']")]
        public IWebElement LifetylDismanmsmanaging1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Managing Your Weight']")]
        public IWebElement LifetylDismanmsmanaging2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Rehabilitation Services']")]
        public IWebElement LifetylDismanmsrehab { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Stem Cell Transplant']")]
        public IWebElement LifetylDismanmsstem { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Tips For Caregivers']")]
        public IWebElement LifetylDismanmstips { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Understanding Clinical Trials']")]
        public IWebElement LifetylDismanmsunderstand { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Vitamins and Minerals']")]
        public IWebElement LifetylDismanmsvitamin { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Ways to Help']")]
        public IWebElement LifetylDismanmsways { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Your Condition and Your Children']")]
        public IWebElement LifetylDismanmsyour { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Multiple Sclerosis']")]
        public IWebElement LifetylDismanmsmultiple { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Nicotine Craving!']")]
        public IWebElement LifetylDismanmsnicotine { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Nutrition Edition']")]
        public IWebElement LifetylDismannutrition { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Obsessive-Compulsive Disorder (OCD)']")]
        public IWebElement LifetylDismanocd { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Oh No! Not Another Yeast Infection']")]
        public IWebElement LifetylDismanohno { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Osteoporosis']")]
        public IWebElement LifetylDismanosteoporosis { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Osteoporosis Prevention and Treatment']")]
        public IWebElement LifetylDismanosteoporosis1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Overcoming Common Psoriasis Treatment Challenges']")]
        public IWebElement LifetylDismanovercoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Peptic Ulcer Disease']")]
        public IWebElement LifetylDismanpeptic { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Picking the Right Vaccination for Specific Adult Populations']")]
        public IWebElement LifetylDismanpicking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Plant Sterols: Fight Cholesterol Naturally']")]
        public IWebElement LifetylDismanplant { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'What do Robert De Niro, Nelson Mandela, Rudy Giuli')]")]
        public IWebElement LifetylDismanprostate { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Skin cancer is the most common type of cancer, and')]")]
        public IWebElement LifetylDismanprotecting { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[122]")]
        public IWebElement LifetylDismanpsoriasis { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Psoriasis: Are You Keeping Up?']")]
        public IWebElement LifetylDismanpsoriasis1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Psoriasis: Control Your Triggers']")]
        public IWebElement LifetylDismanpsoriasis2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Psoriasis: How to Get Your Life Back']")]
        public IWebElement LifetylDismanpsoriasis3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Psoriasis: Managing and Preventing Flare-Ups']")]
        public IWebElement LifetylDismanpsoriasis4{ get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quitting Smoking? Your Pharmacist Can Help']")]
        public IWebElement LifetylDismanquitting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Rare Diseases: Why Diagnosis Can Be So Difficult']")]
        public IWebElement LifetylDismanrare { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Recently Diagnosed with AFib?']")]
        public IWebElement LifetylDismanrecently { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Reduce Your Type 2 Diabetes Risk']")]
        public IWebElement LifetylDismanreduce { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Reducing the Risk of AFib-related Stroke: Know Your Options']")]
        public IWebElement LifetylDismanreducing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'An estimated 2% to 3% of the general population su')]")]
        public IWebElement LifetylDismanseason { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Sexuality and MS: Questions and Answers']")]
        public IWebElement LifetylDismansexuality { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The term sexually transmitted infections (STIs) is')]")]
        public IWebElement LifetylDismantrans { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Should I get a seasonal flu shot?']")]
        public IWebElement LifetylDismanshot { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Smoking Cessation']")]
        public IWebElement LifetylDismansmoking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Staying Healthy on Medication']")]
        public IWebElement LifetylDismanstaying { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Staying Up-to-Date with Your Adult Vaccinations']")]
        public IWebElement LifetylDismanstaying1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sticking with MS Treatment']")]
        public IWebElement LifetylDismansticking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stop Smoking']")]
        public IWebElement LifetylDismanstopsmk { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stroke']")]
        public IWebElement LifetylDismanstroke { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'With atrial fibrillation (AFib), the risk of a str')]")]
        public IWebElement LifetylDismanstroke1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stroke Risk: What Every Caregiver Needs to Know']")]
        public IWebElement LifetylDismanstroke2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Talking to Friends and Family about MS']")]
        public IWebElement LifetylDismantalking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Talking to Your Doctor about Allergies']")]
        public IWebElement LifetylDismantalking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Future of Primary Health Care']")]
        public IWebElement LifetylDismanthe { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Great Outdoors']")]
        public IWebElement LifetylDismanthegreat { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Personal Toll of IBD']")]
        public IWebElement LifetylDismanthepersonal { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Thyroid Disease: Hyperthyroidism and Hypothyroidism']")]
        public IWebElement LifetylDismanthroid { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Thyroid Disease: Thyroid Nodules']")]
        public IWebElement LifetylDismanthroid1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Top 10 Things You Need to Know About HPV Vaccination']")]
        public IWebElement LifetylDismantop10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Travel Bugs']")]
        public IWebElement LifetylDismantravel { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Treating Psoriasis with Biologics']")]
        public IWebElement LifetylDismantreating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='West Nile Virus']")]
        public IWebElement LifetylDismanwest { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Did you know that more than half of all women who ')]")]
        public IWebElement LifetylDismanwhat { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='What Is Psoriatic Arthritis?']")]
        public IWebElement LifetylDismanwhat1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='When Alcohol Use Becomes Problematic']")]
        public IWebElement LifetylDismanwhen { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Work out your heart']")]
        public IWebElement LifetylDismanworkout { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Yeast Infections: Fact vs. Fiction']")]
        public IWebElement LifetylDismanyeast { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='You and Your Child - Coping with Vaccine Anxiety']")]
        public IWebElement LifetylDismanyoucan { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='You Can Control Your IBD!']")]
        public IWebElement LifetylDismanyouand { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='You, your doctor, and your cholesterol levels']//SPAN[@class='title h1'][text()='You Can Control Your IBD!']")]
        public IWebElement LifetylDismanyouyour { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[163]")]
        public IWebElement LifetylDismanyourbad { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Your Blood Vessels: Healthy for Life']")]
        public IWebElement LifetylDismanyourvessels { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[165]")]
        public IWebElement LifetylDismanyourcholesterol { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Your Heart and Summer Fun']")]
        public IWebElement LifetylDismanyourheart { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Your Treatment: Making a Commitment']")]
        public IWebElement LifetylDismanyourtreatment { get; set; }

        //LifestyleDEI
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Diversity and Inclusion']")]
        public IWebElement LifetylDEI { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='2SLGBTQ+ Inclusivity in the Workplace']")]
        public IWebElement LifetylDEI2LGBT { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle/diversity-and-inclusion'][text()='Diversity and Inclusion']")]
        public IWebElement LifetylDEITag { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='collection']//a[1]")]
        public IWebElement LifetylDEILGBworkplace { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Aside from race and sex, age is something that we ')]")]
        public IWebElement LifetylDEIageism { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'If we want to build diverse and inclusive communit')]")]
        public IWebElement LifetylDEIallies { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Anti-Asian Racism and Xenophobia']")]
        public IWebElement LifetylDEIanti { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Being Antiracist']")]
        public IWebElement LifetylDEIbeing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article explains gender expression and gender')]")]
        public IWebElement LifetylDEIbiological { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this article, we will examine how organizations')]")]
        public IWebElement LifetylDEIbuilding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Coming Out to Your Colleagues']")]
        public IWebElement LifetylDEIcoming { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Navigating and making gender-related changes is a ')]")]
        public IWebElement LifetylDEIcoming1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Creating Safe Spaces']")]
        public IWebElement LifetylDEIcreating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Critical Race Theory']")]
        public IWebElement LifetylDEIcritical { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Engaging Employees in Multi-generational Workplaces']")]
        public IWebElement LifetylDEIengaging { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Forms of Privilege']")]
        public IWebElement LifetylDEIForms { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Gender: Need to Know']")]
        public IWebElement LifetylDEIgender { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Immigrant Employees Settling in North America'])[1]")]
        public IWebElement LifetylDEIimmigrant { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Immigrant Employees Settling in North America'])[2]")]
        public IWebElement LifetylDEIimmigrant1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Impacts of Racism on Health and Intergenerational Trauma']")]
        public IWebElement LifetylDEIimpacts { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Implicit Biases']")]
        public IWebElement LifetylDEIimpl { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Inclusive Language in the Workplace']")]
        public IWebElement LifetylDEIinc { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Indigenous People: A Canadian Summary']")]
        public IWebElement LifetylDEIindi { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Indigenous Peoples and Trauma']")]
        public IWebElement LifetylDEIindi1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Intersectionality']")]
        public IWebElement LifetylDEIinter { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Microaggressions']")]
        public IWebElement LifetylDEImicro { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Navigating Transphobia']")]
        public IWebElement LifetylDEInavi { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Race and Ethnicity: The Current Climate']")]
        public IWebElement LifetylDEIrace { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Religion in the Workplace']")]
        public IWebElement LifetylDEIreligion { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Residential School Graves']")]
        public IWebElement LifetylDEIresi { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sexual and Reproductive Health: A Guide for Trans and Gender Diverse People']")]
        public IWebElement LifetylDEIsex { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Social Transitioning']")]
        public IWebElement LifetylDEIsocial { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Your Colleague Coming Out']")]
        public IWebElement LifetylDEIsupporting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Systemic Racism']")]
        public IWebElement LifetylDEISys { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding the History of Racism']")]
        public IWebElement LifetylDEIunder { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Webinar: Inclusion and Belonging in the Workplace']")]
        public IWebElement LifetylDEIwebinar { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='White Privilege']")]
        public IWebElement LifetylDEIwhite { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Workplace Expectations: Dress Codes']")]
        public IWebElement LifetylDEIworkplace { get; set; }


        //LifestyleEmployeeNewsletters

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Employee Newsletters']")]
        public IWebElement LifetylEmpNews { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The term work-life balance is often misunderstood ')]")]
        public IWebElement LifetylEmpNews10steps { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle/employee-newsletter'][text()='Employee Newsletters']")]
        public IWebElement LifetylEmpNewstag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Few things have a greater impact on one’s life tha')]")]
        public IWebElement LifetylEmpNews360 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Regardless of income, race, colour, religion or g')]")]
        public IWebElement LifetylEmpNewsaddiction { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'There are some who believe that addictive personal')]")]
        public IWebElement LifetylEmpNewsavoiding { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Often as summer days are winding down, it’s common')]")]
        public IWebElement LifetylEmpNewsbacktoschool { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this article, we explore the definition of burn')]")]
        public IWebElement LifetylEmpNewsburnout { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article will explore where children are curre')]")]
        public IWebElement LifetylEmpNewschildern { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'You might instinctively know that listening carefu')]")]
        public IWebElement LifetylEmpNewscompassion { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this article, we’ll be exploring the topic of p')]")]
        public IWebElement LifetylEmpNewscoping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Creating Safe Spaces']")]
        public IWebElement LifetylEmpNewscreating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Creating the Future You Deserve']")]
        public IWebElement LifetylEmpNewscreating1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Creating Work-Life Balance']")]
        public IWebElement LifetylEmpNewscreating2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dealing with Seasonal Depression']")]
        public IWebElement LifetylEmpNewsdealing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Does this sound familiar? To get ahead, employees ')]")]
        public IWebElement LifetylEmpNewsencouraging { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Nearly 1/3 of Canadians spend about one hour each ')]")]
        public IWebElement LifetylEmpNewsfinancial { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='Exploring Moral Injury in Healthcare']")]
        public IWebElement LifetylEmpNewshealing { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Healing the Invisible Wounds'])[2]")]
        public IWebElement LifetylEmpNewshealing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When we feel safe, secure and well connected to ou')]")]
        public IWebElement LifetylEmpNewshealthy { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Are you approaching winter celebrations with appre')]")]
        public IWebElement LifetylEmpNewsholiday { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Financial stress can affect more than your wallet;')]")]
        public IWebElement LifetylEmpNewshow { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='How to be an Ally'])[1]")]
        public IWebElement LifetylEmpNewshow1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='How to be an Ally'])[2]")]
        public IWebElement LifetylEmpNewshow2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Combat Your Post-Holiday Depression']")]
        public IWebElement LifetylEmpNewshow3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Support Children Who Identify As LGBTQ2+']")]
        public IWebElement LifetylEmpNewshow4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Workplaces are trying hard to be diverse, inclusiv')]")]
        public IWebElement LifetylEmpNewsindi { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Most people know that stress is something to reduc')]")]
        public IWebElement LifetylEmpNewsinter { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Interconnections Between Stress, Diabetes, Nutrition, and Mental Health'])[2]")]
        public IWebElement LifetylEmpNewsinter1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Introduction to Cognitive Behavioural Therapy (CBT)']")]
        public IWebElement LifetylEmpNewscbt { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Kickstart Your Wellness'])[1]")]
        public IWebElement LifetylEmpNewskickstart { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Kickstart Your Wellness'])[2]")]
        public IWebElement LifetylEmpNewskickstart1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Kickstart Your Wellness'])[3]")]
        public IWebElement LifetylEmpNewskickstart2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'There is much to know about eating disorders, and ')]")]
        public IWebElement LifetylEmpNewslearning { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Today’s workplace is a reflection of our nation -')]")]
        public IWebElement LifetylEmpNewslgbt { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Taking care of ourselves often takes a backseat to')]")]
        public IWebElement LifetylEmpNewsmetime { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Men and women experience many of the same mental ')]")]
        public IWebElement LifetylEmpNewsmens { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Mental health checkup: preparing for the year ahead'])[1]")]
        public IWebElement LifetylEmpNewsmental { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Mental health checkup: preparing for the year ahead'])[2]")]
        public IWebElement LifetylEmpNewsmental1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Mental health checkup: preparing for the year ahead'])[3]")]
        public IWebElement LifetylEmpNewsmental2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mindfulness: Meditation and Everyday Practice']")]
        public IWebElement LifetylEmpNewsmindful { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Navigating Panic Disorder'])[1]")]
        public IWebElement LifetylEmpNewsnavi { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Navigating Panic Disorder'])[2]")]
        public IWebElement LifetylEmpNewsnavi1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Being in recovery can sometimes feel like you have')]")]
        public IWebElement LifetylEmpNewspositive { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In a review of forty-eight papers from eight longi')]")]
        public IWebElement LifetylEmpNewspreparing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article asks employers to consider the differ')]")]
        public IWebElement LifetylEmpNewspreparing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This video asks employers to consider the differen')]")]
        public IWebElement LifetylEmpNewspreparing2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Taking breaks is key to maintaining good mental an')]")]
        public IWebElement LifetylEmpNewspreventing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Post-traumatic stress disorder (PTSD) is most ofte')]")]
        public IWebElement LifetylEmpNewsptsd { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The holidays are a wonderful time of year, but it ')]")]
        public IWebElement LifetylEmpNewsreducing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This year, in the spirit of practicing kindness an')]")]
        public IWebElement LifetylEmpNewssetting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Anyone can experience sexual abuse or sexual haras')]")]
        public IWebElement LifetylEmpNewssexual { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Sex. It’s natural. It’s normal. It’s necessary. Bu')]")]
        public IWebElement LifetylEmpNewssexual1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'One in three Canadians say work stress is getting ')]")]
        public IWebElement LifetylEmpNewssix { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The relationship between addiction and stigma is u')]")]
        public IWebElement LifetylEmpNewsstigma { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In this article, we’ll look at stress categoricall')]")]
        public IWebElement LifetylEmpNewsstudent { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The importance of mental health and overall well-b')]")]
        public IWebElement LifetylEmpNewssuicide { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Being witness to, or experiencing traumatic events')]")]
        public IWebElement LifetylEmpNewssupporting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'For someone in recovery, the memories and celebrat')]")]
        public IWebElement LifetylEmpNewssupporting1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Teaching Inclusivity and Inclusive Language'])[1]")]
        public IWebElement LifetylEmpNewsteaching { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Teaching Inclusivity and Inclusive Language'])[2]")]
        public IWebElement LifetylEmpNewsteaching1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Teaching Inclusivity and Inclusive Language'])[3]")]
        public IWebElement LifetylEmpNewsteaching2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[63]//div[1]//div[1]//div[1]//div[1]//span[1]")]
        public IWebElement LifetylEmpNewsimpact { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[64]//div[1]//div[1]//div[1]//div[1]//span[1]")]
        public IWebElement LifetylEmpNewsimpact1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[65]//div[1]//div[1]//div[1]//div[1]//p[1]")]
        public IWebElement LifetylEmpNewsimpact2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Impact of Trauma and Adversity on Mental Health']")]
        public IWebElement LifetylEmpNewsimpact3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Impact of Trauma and Adversity on Mental Health (Listen)']")]
        public IWebElement LifetylEmpNewsimpact4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Impact of Trauma and Adversity on Mental Health (Video)']")]
        public IWebElement LifetylEmpNewsimpact5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Importance of Sleep']")]
        public IWebElement LifetylEmpNewsimportance { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='The Intersection of Sexual Identity and Mental Health'])[1]")]
        public IWebElement LifetylEmpNewsintersection { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='The Intersection of Sexual Identity and Mental Health'])[2]")]
        public IWebElement LifetylEmpNewsintersection1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Invisible Wounds of Mental Health Disorders']")]
        public IWebElement LifetylEmpNewsinvisible { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Many Faces of Anxiety']")]
        public IWebElement LifetylEmpNewsmanyfaces { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​The Many Faces of Post-Traumatic Stress Disorder']")]
        public IWebElement LifetylEmpNewsmanyptsd { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='The Psychology of Debt'])[1]")]
        public IWebElement LifetylEmpNewspsychology { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='The Psychology of Debt'])[2]")]
        public IWebElement LifetylEmpNewspsychology1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Sobering Facts About Addiction']")]
        public IWebElement LifetylEmpNewsobering { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Trauma Informed Collaboration'])[1]")]
        public IWebElement LifetylEmpNewstrauma { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Trauma Informed Collaboration'])[2]")]
        public IWebElement LifetylEmpNewstrauma1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Approximately three million Canadians have an anxi')]")]
        public IWebElement LifetylEmpNewsuncovering { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Everybody goes through ups and downs in their live')]")]
        public IWebElement LifetylEmpNewsunderstanding { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The definition of mental health, the symptoms of m')]")]
        public IWebElement LifetylEmpNewsunderstanding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Do you remember how you felt on your last vacation')]")]
        public IWebElement LifetylEmpNewsvacation { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​When living with Alzheimer’s or another form of d')]")]
        public IWebElement LifetylEmpNewswhen { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We do our best to talk ourselves into believing ma')]")]
        public IWebElement LifetylEmpNewswhen1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'A more in-depth look at women’s mental health, to ')]")]
        public IWebElement LifetylEmpNewswomen { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[88]//div[1]//div[1]//div[1]//div[1]//span[1]")]
        public IWebElement LifetylEmpNewswomen1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[89]//div[1]//div[1]//div[1]//div[1]//span[1]")]
        public IWebElement LifetylEmpNeewwomen2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Sex and gender interact with a variety of other de')]")]
        public IWebElement LifetylEmpNewswomen3 { get; set; }

        //LifestyleFitness

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Fitness']")]
        public IWebElement LifetylFitness { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Arthritis involves more than 100 different condit')]")]
        public IWebElement LifetylFitarth { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle/fitness'][text()='Fitness']")]
        public IWebElement LifetylFittag{ get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cardiovascular disease or heart disease is the num')]")]
        public IWebElement LifetylFitens { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Getting the Most From Medication']")]
        public IWebElement LifetylFitgetting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Headaches']")]
        public IWebElement LifetylFithead { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Healthy Aging']")]
        public IWebElement LifetylFithealthy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Improve Sleep']")]
        public IWebElement LifetylFithowto { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Identify Areas of Tension']")]
        public IWebElement LifetylFitidentify { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Improving Your Physical Fitness']")]
        public IWebElement LifetylFitimproving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Learning to Change a Habit']")]
        public IWebElement LifetylFitlearning { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Linking Exercise and Nutrition to a Healthy Mind']")]
        public IWebElement LifetylFitlinking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Looking on the Bright Side... Outside']")]
        public IWebElement LifetylFitlooking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Nutritional Supplements']")]
        public IWebElement LifetylFitnut { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pain']")]
        public IWebElement LifetylFitpain { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Resilience Through Chronic Physical Conditions']")]
        public IWebElement LifetylFitresilience { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Self-Care: Time And Attention For You']")]
        public IWebElement LifetylFitselfcare { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[16]//div[1]//div[1]//div[1]//div[1]//p[1]")]
        public IWebElement LifetylFitseniors { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Do you wake up each morning without the aid of an ')]")]
        public IWebElement LifetylFitsleep { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'If you are a smoker who has tried quitting, you kn')]")]
        public IWebElement LifetylFitsmoke { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Social Media Diet and Fitness'])[1]")]
        public IWebElement LifetylFitsocial { get; set; }
        [FindsBy(How = How.XPath, Using = "/(//SPAN[@class='title h1'][text()='Social Media Diet and Fitness'])[2]")]
        public IWebElement LifetylFitsocial1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sports Injuries']")]
        public IWebElement LifetylFitsports { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stop Smoking and Get Your Life Back!']")]
        public IWebElement LifetylFitstop { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stroke']")]
        public IWebElement LifetylFitstroke { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Travel Health']")]
        public IWebElement LifetylFittravel { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Eating Disorders (Audio)']")]
        public IWebElement LifetylFitunderstanding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Eating Disorders: A Compassionate Approach to Increasing Awareness and Offering Support']")]
        public IWebElement LifetylFitundefstanding1{ get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Your 50s: A Health Guide for Women']")]
        public IWebElement LifetylFitwomen { get; set; }

        //LifestyleHealthandwellness
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Health and Wellness']")]
        public IWebElement Lifetylheawell { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'On weekends and after school, your kids have more ')]")]
        public IWebElement Lifetylheawellchild { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle/health-and-wellness'][text()='Health and Wellness']")]
        public IWebElement Lifetylheawelltag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This podcast describes why it is so fundamental fo')]")]
        public IWebElement Lifetylheawellcreating { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Many Canadians suffer from eating disorders. Eatin')]")]
        public IWebElement Lifetylheawelleating { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We get most of our information about the world fro')]")]
        public IWebElement Lifetylheawelleye { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'People with allergies often take their medications')]")]
        public IWebElement Lifetylheawellfaq { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Practicing good hand hygiene is how we can all hel')]")]
        public IWebElement Lifetylheawellhand { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='Are you making the right use of hand sanitizer?']")]
        public IWebElement Lifetylheawellsani { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Everyone knows what it')]")]
        public IWebElement Lifetylheawellheadaches { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Hearing During the Holidays']")]
        public IWebElement Lifetylheawellholidays { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Introduction to Cognitive Behavioural Therapy (CBT)']")]
        public IWebElement Lifetylheawellcbt { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Learn About Osteoarthritis']")]
        public IWebElement Lifetylheawelllearn { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Learn About Rheumatoid Arthritis']")]
        public IWebElement Lifetylheawelllearn1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Living with Rheumatoid Arthritis']")]
        public IWebElement Lifetylheawellliving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Making Self-Care a Priority']")]
        public IWebElement Lifetylheawellmaking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mental health checkup: preparing for the year ahead']")]
        public IWebElement Lifetylheawellmental { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='MS: Exercise Tips']")]
        public IWebElement Lifetylheawellms { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Organ Donation: The Gift of Life']")]
        public IWebElement Lifetylheawellorgan { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Pain is an unfortunate part of life. Even though e')]")]
        public IWebElement Lifetylheawellpain { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quitting Smoking: The Road to Recovery']")]
        public IWebElement Lifetylheawellquit { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quitting Smoking? Your Pharmacist Can Help']")]
        public IWebElement Lifetylheawellquit1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sexually Transmitted Infections']")]
        public IWebElement Lifetylheawelltrans { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Like good nutrition and exercise, adequate sleep i')]")]
        public IWebElement Lifetylheawellsleep { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Quitting smoking is an important step towards bett')]")]
        public IWebElement Lifetylheawellsmoking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Social Media Diet and Fitness']")]
        public IWebElement Lifetylheawellsocial { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sports Injuries']")]
        public IWebElement Lifetylheawellsports { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sun Protection']")]
        public IWebElement Lifetylheawellsun { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sun Safety']")]
        public IWebElement Lifetylheawellsun1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Role of a Pharmacist']")]
        public IWebElement Lifetylheawellrole { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Weight of Winter and Negative Thoughts']")]
        public IWebElement Lifetylheawellwinter { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Too Much Screen Time?'])[1]")]
        public IWebElement Lifetylheawelltoo { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Too Much Screen Time?'])[2]")]
        public IWebElement Lifetylheawelltoo1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Too Much Screen Time? How It Affects Mental Health and What to Do About It']")]
        public IWebElement Lifetylheawelltoo2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Eating Disorders (Audio)']")]
        public IWebElement Lifetylheawellunderstanding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Eating Disorders (Video)']")]
        public IWebElement Lifetylheawellunderstanding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Family Dynamics']")]
        public IWebElement Lifetylheawellunderstanding2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Mental Health and Mental Illness']")]
        public IWebElement Lifetylheawellunderstanding3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Weight Loss']")]
        public IWebElement Lifetylheawellweight { get; set; }

        //LifestyleMentalHealth

        [FindsBy(How = How.XPath, Using = "//a[@href='/app/en/resources/category/permalink/lifestyle/mental-health']")]
        public IWebElement Lifetylmentalhealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The term work-life balance is often misunderstood ')]")]
        public IWebElement Lifetylmenhea { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle/mental-health'][text()='Mental Health']")]
        public IWebElement Lifetylmenheatag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Few things have a greater impact on one’s life tha')]")]
        public IWebElement Lifetylmenhea360 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Kids respond differently to stress depending on t')]")]
        public IWebElement Lifetylmenheastress { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Most people aren’t fond of change. We like our ha')]")]
        public IWebElement Lifetylmenheaadapting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Although it’s normal to feel sad or upset from tim')]")]
        public IWebElement Lifetylmenheaami { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Have you ever purchased a bunch of daffodils to su')]")]
        public IWebElement Lifetylmenheabeyond { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Are you happy with how you look? Have you ever loo')]")]
        public IWebElement Lifetylmenheabody { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We might not like to admit it, but most of us have')]")]
        public IWebElement Lifetylmenheabreak { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Try this breathing technique that is designed to h')]")]
        public IWebElement Lifetylmenheabreathe { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'While many people celebrate and acknowledge romant')]")]
        public IWebElement Lifetylmenheabuilding { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We’ll all experience great highs and great lows du')]")]
        public IWebElement Lifetylmenheabuilding1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Many survivors of childhood sexual abuse experienc')]")]
        public IWebElement Lifetylmenheachild { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This article will explore where children are curre')]")]
        public IWebElement Lifetylmenheachild1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​People need people — by nature, we are social bei')]")]
        public IWebElement Lifetylmenheaconnecting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Everyone feels sad or down at times, and normally ')]")]
        public IWebElement Lifetylmenheacoping { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Loss is an inevitable part of life. During our li')]")]
        public IWebElement Lifetylmenheacoping1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Seasonal Affective Disorder (SAD), often referred ')]")]
        public IWebElement Lifetylmenheadealing { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Dealing with Seasonal Depression'])[2]")]
        public IWebElement Lifetylmenheadealing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dealing With Shift Work']")]
        public IWebElement Lifetylmenheadealing2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Developing Resiliency']")]
        public IWebElement Lifetylmenheaedeveloping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Financial and Mental Health']")]
        public IWebElement Lifetylmenheaefin { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Finding Forgiveness']")]
        public IWebElement Lifetylmenheaefinding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Getting Adequate Sleep']")]
        public IWebElement Lifetylmenheaegetting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Going Abroad to Work']")]
        public IWebElement Lifetylmenheaegoing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'When we feel safe, secure and well connected to ou')]")]
        public IWebElement Lifetylmenheahealthy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Holiday Stress and Anxiety Prevention']")]
        public IWebElement Lifetylmenheaholiday{ get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Avoid Overreacting']")]
        public IWebElement Lifetylmenheahow { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Combat Your Post-Holiday Depression']")]
        public IWebElement Lifetylmenheahow1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Increase Your Self-Confidence']")]
        public IWebElement Lifetylmenheahow2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Reduce Holiday Stress']")]
        public IWebElement Lifetylmenheahow3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Take the Chance to Express Yourself']")]
        public IWebElement Lifetylmenheahow4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Humour Therapy and the Power of Laughter']")]
        public IWebElement Lifetylmenheahumour { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Identify Areas of Tension']")]
        public IWebElement Lifetylmenheaidentify { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Importance of Sleep']")]
        public IWebElement Lifetylmenheaimp { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Indigenous Peoples and Trauma']")]
        public IWebElement Lifetylmenheaindi { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='June is National Post-Traumatic Stress Disorder Awareness Month']")]
        public IWebElement Lifetylmenheajune { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Keeping Your Love Alive']")]
        public IWebElement Lifetylmenheakeeping { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Kickstart Your Wellness'])[1]")]
        public IWebElement Lifetylmenheakickstart { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Kickstart Your Wellness'])[2]")]
        public IWebElement Lifetylmenheakickstart1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Kickstart Your Wellness'])[3]")]
        public IWebElement Lifetylmenheakickstart2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Learning About Eating Disorders']")]
        public IWebElement Lifetylmenhealearning { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Learning to Change a Habit']")]
        public IWebElement Lifetylmenhealearning1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Legal Advisory']")]
        public IWebElement Lifetylmenhealegal { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='LGBTQ+ Mental Health']")]
        public IWebElement Lifetylmenhealgbtq { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Looking on the Bright Side... Outside']")]
        public IWebElement Lifetylmenhealooking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maintaining Good Mental Health']")]
        public IWebElement Lifetylmenheamaintaining { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Maintaining Your Mental and Physical Health During the Holidays']")]
        public IWebElement Lifetylmenheamaintaining1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Workplace Stress']")]
        public IWebElement Lifetylmenheamanaging { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Me-Time: Managing Stress and Finding Work-Life Balance']")]
        public IWebElement Lifetylmenheametime { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Men and women experience many of the same mental ')]")]
        public IWebElement Lifetylmenheamenmental { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​It’s time to dispel some common myths about menta')]")]
        public IWebElement Lifetylmenheamenillness { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Every person can benefit from mindfulness meditati')]")]
        public IWebElement Lifetylmenheamenmindfulness { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Moving Beyond Anxiety']")]
        public IWebElement Lifetylmenheamenmoving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Navigating Life in Mental Health Recovery']")]
        public IWebElement Lifetylmenheamennavigate { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Overcoming Phobias']")]
        public IWebElement Lifetylmenheamenpho { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Most people are affected in some way, by a change ')]")]
        public IWebElement Lifetylmenheamenover { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Being in recovery can sometimes feel like you have')]")]
        public IWebElement Lifetylmenheamenpositive { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Time to pack away the decorations, organize the ho')]")]
        public IWebElement Lifetylmenheamenpreparing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Post-traumatic stress disorder (PTSD) is most ofte')]")]
        public IWebElement Lifetylmenheamenptsd { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'“Racism and the trauma that results from racism ex')]")]
        public IWebElement Lifetylmenheamenracial { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​A healthy amount of self-esteem gives us the resi')]")]
        public IWebElement Lifetylmenheamenraising { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Congratulations! You made it through the holiday s')]")]
        public IWebElement Lifetylmenheamenreenergizing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The holidays are a wonderful time of year, but it ')]")]
        public IWebElement Lifetylmenheamenreducing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Irrespective of age, culture or income, at least ')]")]
        public IWebElement Lifetylmenheamenreducing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Resilience']")]
        public IWebElement Lifetylmenheamenresilience { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Responsible Optimism']")]
        public IWebElement Lifetylmenheamenresposible { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Separation and Divorce']")]
        public IWebElement Lifetylmenheamensepa { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Sexual Abuse and Sexual Harassment'])[1]")]
        public IWebElement Lifetylmenheamensexual { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Sexual Abuse and Sexual Harassment'])[2]")]
        public IWebElement Lifetylmenheamensexual1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Shift Worker Support']")]
        public IWebElement Lifetylmenheamenshift { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sleep Better, Feel Better']")]
        public IWebElement Lifetylmenheasleep { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The death of someone close to you is one of the mo')]")]
        public IWebElement Lifetylmenheasomeone { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The death of a close colleague or loved one is one')]")]
        public IWebElement Lifetylmenheasomeone1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The death of a loved one is one of the most painfu')]")]
        public IWebElement Lifetylmenheasomeone2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Do you know how to spot the signs of suicide? Lear')]")]
        public IWebElement Lifetylmenheaspotting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Being constantly busy helps us feel involved and r')]")]
        public IWebElement Lifetylmenheastop { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Feeling stressed? Most of us feel pressured by the')]")]
        public IWebElement Lifetylmenheastress1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'With the growing awareness of how social media can')]")]
        public IWebElement Lifetylmenheastudent { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Being witness to, or experiencing traumatic events')]")]
        public IWebElement Lifetylmenheasupporting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Someone With a Mental Illness']")]
        public IWebElement Lifetylmenheasupporting1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Those in Recovery During the Holidays']")]
        public IWebElement Lifetylmenheasupporting2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Surviving Another September'])[1]")]
        public IWebElement Lifetylmenheasurviving { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Surviving Another September'])[2]")]
        public IWebElement Lifetylmenheasurviving1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Surviving September']")]
        public IWebElement Lifetylmenheasurviving2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Charge of Stress']")]
        public IWebElement Lifetylmenheataking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Anger']")]
        public IWebElement Lifetylmenheataking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Job Loss and Transition']")]
        public IWebElement Lifetylmenheataking2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Talking About Mental Illness']")]
        public IWebElement Lifetylmenheataking3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Talking to Your Kids About Mental Health and Addiction']")]
        public IWebElement Lifetylmenheatalking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Biology of Your Internal Clock']")]
        public IWebElement Lifetylmenheathe { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Dangers of Social Media on Your Mental Health']")]
        public IWebElement Lifetylmenheathe1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Healing Power of Helping Others']")]
        public IWebElement Lifetylmenheathe2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Importance of Relaxation']")]
        public IWebElement Lifetylmenheathe3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Importance of Sleep']")]
        public IWebElement Lifetylmenheathe4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Invisible Wounds of Mental Health Disorders']")]
        public IWebElement Lifetylmenheathe5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Link Between Concussion and Depression']")]
        public IWebElement Lifetylmenheathe6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Many Faces of Anxiety']")]
        public IWebElement Lifetylmenheathe7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​The Many Faces of Post-Traumatic Stress Disorder']")]
        public IWebElement Lifetylmenheathe8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Power of a Positive Attitude']")]
        public IWebElement Lifetylmenheathe9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Too Much Screen Time?']")]
        public IWebElement Lifetylmenheatoo { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Uncovering the Faces of Anxiety']")]
        public IWebElement Lifetylmenheauncovering { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Depression']")]
        public IWebElement Lifetylmenheaunder1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Eating Disorders (Video)']")]
        public IWebElement Lifetylmenheaunder2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Understanding Family Dynamics'])[1]")]
        public IWebElement Lifetylmenheaunder3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Understanding Family Dynamics'])[2]")]
        public IWebElement Lifetylmenheaunder4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Mental Health and Mental Illness']")]
        public IWebElement Lifetylmenheaunder5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Vacation: Relax, Refresh and Reconnect']")]
        public IWebElement Lifetylmenheavacation { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Visualization']")]
        public IWebElement Lifetylmenheavis { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Wellness During the Holiday Season']")]
        public IWebElement Lifetylmenheawellness { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='What Causes Anger?']")]
        public IWebElement Lifetylmenheawhat { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='What Is Mindfulness, and How Can I Practise It?']")]
        public IWebElement Lifetylmenheawhat1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='When Someone Close to You Has a Serious Illness']")]
        public IWebElement Lifetylmenheawhen { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'A more in-depth look at women’s mental health, to ')]")]
        public IWebElement Lifetylmenheawomen { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'We’re sharing some of the ideas and realities we’v')]")]
        public IWebElement Lifetylmenheawomen1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Many sectors require shift work (e.g., healthcare,')]")]
        public IWebElement Lifetylmenheaworking { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Has something traumatic recently occurred in your ')]")]
        public IWebElement Lifetylmenheayou { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'It’s no secret the emotions and actions of youth a')]")]
        public IWebElement Lifetylmenheayouth { get; set; }

        //LifestyleNutritionGeneralFitness

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Nutrition & General Fitness']")]
        public IWebElement LifestyleNutritionGeneralFitness { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Feeling overwhelmed by everything you have to do t')]")]
        public IWebElement LifestyleNut { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Nutrition & General Fitness']")]
        public IWebElement LifestyleNuttag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Skim your finger across your cheek. Is the surface')]")]
        public IWebElement LifestyleNut12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='4 Steps to Post-holiday Rejuvenation']")]
        public IWebElement LifestyleNut4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='5 Heart Healthy Resolutions: Stay on track']")]
        public IWebElement LifestyleNut5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='5 Ways to Avoid Digestive Problems on the Go']")]
        public IWebElement LifestyleNut5ways { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='6 Skin Flaws that Give Away Your Age']")]
        public IWebElement LifestyleNut6skin { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Active Living']")]
        public IWebElement LifestyleNutactive { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Aging Skin and Wrinkles']")]
        public IWebElement LifestyleNutaging { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Air Travel During Flu Season']")]
        public IWebElement LifestyleNutair { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Allergies and the Great Outdoors']")]
        public IWebElement LifestyleNutallergies { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Allergies in Motherhood']")]
        public IWebElement LifestyleNutallergies1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Allergy Prevention and Treatment']")]
        public IWebElement LifestyleNutallergies2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Allergy Signs and Symptoms']")]
        public IWebElement LifestyleNutallergies3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Andropause: A Turning Point for Men']")]
        public IWebElement LifestyleNutandro { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Anemia Overview']")]
        public IWebElement LifestyleNutanemia { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Arthritis involves more than 100 different condit')]")]
        public IWebElement LifestyleNutarth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'For some people, allergy season lasts all year and')]")]
        public IWebElement LifestyleNutavoid { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The quality of your sleep depends so much on the q')]")]
        public IWebElement LifestyleNutbed { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Breast Health']")]
        public IWebElement LifestyleNutbreast { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Caring for Sensitive Teeth']")]
        public IWebElement LifestyleNutcaring{ get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Celebrities and Fertility']")]
        public IWebElement LifestyleNutceleb { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Learn more about the importance of being caught up')]")]
        public IWebElement LifestyleNutchild { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Whether you wear shoes for fashion or for function')]")]
        public IWebElement LifestyleNutchoosing { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'There are more ways you damage your teeth every da')]")]
        public IWebElement LifestyleNutcommon { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'So many different things can affect bowel habits &')]")]
        public IWebElement LifestyleNutconstipation { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Sticking to a nutritious diet can be a whole lot e')]")]
        public IWebElement LifestyleNutcooking { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Unfortunately, miscarriage occurs in about 15% to ')]")]
        public IWebElement LifestyleNutcoping { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'A healthy diet includes fruits and vegetables in a')]")]
        public IWebElement LifestyleNutcrack { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dandruff FAQ']")]
        public IWebElement LifestyleNutdand { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dealing With Shift Work']")]
        public IWebElement LifestyleNutdealing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dental Procedures']")]
        public IWebElement LifestyleNutdental { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Detoxing: What You Need to Know']")]
        public IWebElement LifestyleNutdetox { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Diarrhea – Did You Know?']")]
        public IWebElement LifestyleNutdiarr { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[33]")]
        public IWebElement LifestyleNutdont { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dreams: The Mysteries of Sleep']")]
        public IWebElement LifestyleNutdreams { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Drug Allergies']")]
        public IWebElement LifestyleNutdrug { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Eat Your Way to a Healthier-Looking Scalp']")]
        public IWebElement LifestyleNuteat { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Eating Disorders']")]
        public IWebElement LifestyleNuteating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Eating Healthier']")]
        public IWebElement LifestyleNuteating1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Eating Healthier on the Run']")]
        public IWebElement LifestyleNuteating2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Eczema in Infants and Children']")]
        public IWebElement LifestyleNuteczema { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Ensuring a Healthy Heart']")]
        public IWebElement LifestyleNutensure { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[42]")]
        public IWebElement LifestyleNuterectile { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Erectile Dysfunction: Myths and Facts']")]
        public IWebElement LifestyleNuterectile1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[44]")]
        public IWebElement LifestyleNutexfol { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Eye Symptoms and Signs']")]
        public IWebElement LifestyleNuteye { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Fad vs. Fat: Popular diets']")]
        public IWebElement LifestyleNutfad { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='FAQs about Allergies and Medications']")]
        public IWebElement LifestyleNutfaq { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Fertility and Your Sex Life']")]
        public IWebElement LifestyleNutfert { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Fertility Clinic FAQ']")]
        public IWebElement LifestyleNutfert1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Financial and Physical Health']")]
        public IWebElement LifestyleNutfin { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Fish: Nutrition and Safety']")]
        public IWebElement LifestyleNutfish { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Food Allergy, Food Enemy?']")]
        public IWebElement LifestyleNutfood { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Food and You']")]
        public IWebElement LifestyleNutfood1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Food Storage and Shelf Life']")]
        public IWebElement LifestyleNutfood2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Foot Care: Put Some Spring in Your Step']")]
        public IWebElement LifestyleNutfoot { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Get Away - in Good Health!']")]
        public IWebElement LifestyleNutget { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Getting Involved in Research']")]
        public IWebElement LifestyleNutgetting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Getting Pregnant: Know the Right Time to Try']")]
        public IWebElement LifestyleNutgetting1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Hand Hygiene How-to: Protecting Yourself and Others from COVID-19']")]
        public IWebElement LifestyleNuthand { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Hand Washing Guide']")]
        public IWebElement LifestyleNuthand1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Happy Healthy Holidays!']")]
        public IWebElement LifestyleNuthappy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Healthy Eating During the Holidays']")]
        public IWebElement LifestyleNuthealthy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Healthy Hair Essentials']")]
        public IWebElement LifestyleNuthealthy1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Healthy Skin by the Numbers']")]
        public IWebElement LifestyleNuthealthy2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Hearing During the Holidays']")]
        public IWebElement LifestyleNutholidays { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Heart Facts: 7 Things You Never Knew']")]
        public IWebElement LifestyleNutheart { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How 4 Facial Treatments Really Work']")]
        public IWebElement LifestyleNuthow { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How Food Label Savvy Are You?']")]
        public IWebElement LifestyleNuthow1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Boost Your Immune System']")]
        public IWebElement LifestyleNuthow2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Maintain a Healthy Relationship With Food']")]
        public IWebElement LifestyleNuthow3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Talk to Your Doctor']")]
        public IWebElement LifestyleNuthow4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Increasing Your Chances of Pregnancy Before Fertility Treatments']")]
        public IWebElement LifestyleNutincr { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Indoor Exercises for Seniors']")]
        public IWebElement LifestyleNutindoor { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Infertility: More common than you may think']")]
        public IWebElement LifestyleNutinfer { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Infertility: Tipping the Scales in Your Favour']")]
        public IWebElement LifestyleNutinfer1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Infertility: What Are the Signs?']")]
        public IWebElement LifestyleNutinfer2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Integrative Medicine: the ABCs']")]
        public IWebElement LifestyleNutinteg { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Itches, Twitches, Tickles, and Pops']")]
        public IWebElement LifestyleNutitches { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Jumpstart your Wellness']")]
        public IWebElement LifestyleNutjump{get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Keep Your Resolutions']")]
        public IWebElement LifestyleNutkeep { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Keeping a Healthy Smile']")]
        public IWebElement LifestyleNutkeep1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Keeping Fit']")]
        public IWebElement LifestyleNutkeep2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Keeping Your Mouth Healthy While Travelling']")]
        public IWebElement LifestyleNutkeep3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Learn About Osteoarthritis']")]
        public IWebElement LifestyleNutlearn { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Learn About Rheumatoid Arthritis']")]
        public IWebElement LifestyleNutlearn1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Learning to Change a Habit']")]
        public IWebElement LifestyleNutlearn2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Linking Exercise and Nutrition to a Healthy Mind']")]
        public IWebElement LifestyleNutlink { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Living with Rheumatoid Arthritis']")]
        public IWebElement LifestyleNutliving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Milk']")]
        public IWebElement LifestyleNutmilk { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='My Wellness'])[1]")]
        public IWebElement LifestyleNutmy { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='My Wellness'])[2]")]
        public IWebElement LifestyleNutmy1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Nicotine Craving!']")]
        public IWebElement LifestyleNutnico { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Not-So-Simple Sleep']")]
        public IWebElement LifestyleNutnotso { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Nutrition and Fitness']")]
        public IWebElement LifestyleNutnut { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Nutrition Edition']")]
        public IWebElement LifestyleNutnut1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Nutritional Coaching']")]
        public IWebElement LifestyleNutnut2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Nutritional Supplements']")]
        public IWebElement LifestyleNutnut3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Oh No! Not Another Yeast Infection']")]
        public IWebElement LifestyleNutohno { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Oral Care and Your Medical Conditions']")]
        public IWebElement LifestyleNutoral { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Plant Sterols: Fight Cholesterol Naturally']")]
        public IWebElement LifestyleNutplant { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='PMS: Are You Prepared?']")]
        public IWebElement LifestyleNutpmp { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Preparing for a Colonoscopy']")]
        public IWebElement LifestyleNutpreparing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Preparing to Quit Smoking']")]
        public IWebElement LifestyleNutpreparing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Probiotic Basics']")]
        public IWebElement LifestyleNutprobiotic { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Probiotics and your gut']")]
        public IWebElement LifestyleNutprobiotic1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quitting Smoking: The Road to Recovery']")]
        public IWebElement LifestyleNutquit { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Quitting Smoking? Your Pharmacist Can Help']")]
        public IWebElement LifestyleNutquit1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Reduce Your Type 2 Diabetes Risk']")]
        public IWebElement LifestyleNutreduce { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Run... for Your Life']")]
        public IWebElement LifestyleNutrun { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Scalp Care by the Seasons']")]
        public IWebElement LifestyleNutscalp { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Skin Care in Your 30s and Beyond']")]
        public IWebElement LifestyleNutskin { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sleep Facts and Fiction']")]
        public IWebElement LifestyleNutsleep { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sleeping Through the Night with Colds or Allergies']")]
        public IWebElement LifestyleNutsleep1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Smoking Cessation']")]
        public IWebElement LifestyleNutsmoke { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Social Media Diet and Fitness'])[1]")]
        public IWebElement LifestyleNutsocial { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Social Media Diet and Fitness'])[2]")]
        public IWebElement LifestyleNutsocial1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Social Media Diet and Fitness'])[3]")]
        public IWebElement LifestyleNutsocial2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Staying Active During COVID-19']")]
        public IWebElement LifestyleNutstaying { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Staying Up-to-Date with Your Adult Vaccinations']")]
        public IWebElement LifestyleNutstaying1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stop Smoking']")]
        public IWebElement LifestyleNutstopsmoking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stress and Your Body']")]
        public IWebElement LifestyleNutstress { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Summer Beauty from the Inside Out']")]
        public IWebElement LifestyleNutsummer { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Summertime and Your Health']")]
        public IWebElement LifestyleNutsummer1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sun Protection']")]
        public IWebElement LifestyleNutsun { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Telling Your Partner About Incontinence']")]
        public IWebElement LifestyleNuttelling { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The 10 Commandments of a Healthy Digestive System']")]
        public IWebElement LifestyleNutthe1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Air We Breathe: Is It Safe?']")]
        public IWebElement LifestyleNutthe2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​The Benefits of Eating Superfoods']")]
        public IWebElement LifestyleNutthe3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Future of Primary Health Care']")]
        public IWebElement LifestyleNutthe4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Impact of Alcohol']")]
        public IWebElement LifestyleNutthe5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Impact of Sleep on Your Health']")]
        public IWebElement LifestyleNutthe6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The pros of probiotics']")]
        public IWebElement LifestyleNutthe7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Role of a Pharmacist']")]
        public IWebElement LifestyleNutthe8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Thyroid Disease: Hyperthyroidism and Hypothyroidism']")]
        public IWebElement LifestyleNutthy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Time for Spring Cleaning!']")]
        public IWebElement LifestyleNuttime { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Tips for Head-to-Toe Self-Massage']")]
        public IWebElement LifestyleNuttips { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Travel Bugs']")]
        public IWebElement LifestyleNuttravel { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Trying to Get Pregnant Is Stressing Me Out!']")]
        public IWebElement LifestyleNutttrying { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Eating Disorders (Video)']")]
        public IWebElement LifestyleNutunderstand { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Eating Disorders: A Compassionate Approach to Increasing Awareness and Offering Support']")]
        public IWebElement LifestyleNutunderstand1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[142]")]
        public IWebElement LifestyleNutwater { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Weight Loss']")]
        public IWebElement LifestyleNutwhat { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='What Causes Heartburn and Indigestion?']")]
        public IWebElement LifestyleNutwhat1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[146]")]
        public IWebElement LifestyleNutwhat2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='What You Need to Know about Salmonella']")]
        public IWebElement LifestyleNutwhat3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Why Do People Get Allergies?']")]
        public IWebElement LifestyleNutwhy { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Why Good Posture Matters']")]
        public IWebElement LifestyleNutwhy1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Winter Weather Well-being']")]
        public IWebElement LifestyleNutwinter { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Work out your heart']")]
        public IWebElement LifestyleNutworkout { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Working Out in a Winter Wonderland']")]
        public IWebElement LifestyleNutwork1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Workout Guide: Pilates, Spin, and Zumba']")]
        public IWebElement LifestyleNutwork2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Yoga: Stretch for Your Health']")]
        public IWebElement LifestyleNutyoga { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='You and Your Child - Coping with Vaccine Anxiety']")]
        public IWebElement LifestyleNutyou { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='You, your doctor, and your cholesterol levels']")]
        public IWebElement LifestyleNutyou1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Your 20s: A Health Guide for Women']")]
        public IWebElement LifestyleNutyour { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Your 30s: A Health Guide for Women']")]
        public IWebElement LifestyleNutyour1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Your 40s: A Health Guide for Women']")]
        public IWebElement LifestyleNutyour2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Your 50s: A Health Guide for Women']")]
        public IWebElement LifestyleNutyour3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Your Blood Vessels: Healthy for Life']")]
        public IWebElement LifestyleNutyour4 { get; set; }

        //WorkPlace
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Workplace']")]
        public IWebElement WorkPlace { get; set; }
        [FindsBy(How = How.XPath, Using = "  //p[contains(text(),'Work life-balance is an individual measurement and')] ")]
        public IWebElement WorkPlace10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace'][text()='Workplace']")]
        public IWebElement WorkPlacetag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The term work-life balance is often misunderstood ')]")]
        public IWebElement WorkPlace101 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='2SLGBTQ+ Inclusivity in the Workplace']")]
        public IWebElement WorkPlace2SL { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='A Resource Guide for Trans and Gender Diverse People']")]
        public IWebElement WorkPlaceAres { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Avoiding the Top 10 Interview Mistakes']")]
        public IWebElement WorkPlaceavoid { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Building a Healthy Workplace']")]
        public IWebElement WorkPlacebuild { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Burnout: What is it and How to Cope']")]
        public IWebElement WorkPlaceburnout { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Career Counselling']")]
        public IWebElement WorkPlacecareer { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Coping With the Death of a Coworker']")]
        public IWebElement WorkPlacecoping { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Creating a Healthy Workplace'])[1]")]
        public IWebElement WorkPlacecreating { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Creating a Healthy Workplace'])[2]")]
        public IWebElement WorkPlacecreating1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Creating a Healthy Workplace'])[3]")]
        public IWebElement WorkPlacecreating2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dealing with Dismissals in the Workplace']")]
        public IWebElement WorkPlacedealing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dealing With Shift Work']")]
        public IWebElement WorkPlacedealing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Disability Prevention Tips at Work']")]
        public IWebElement WorkPlacedisability { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Does Work Have to be Stressful?']")]
        public IWebElement WorkPlacedoes { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Effectively Managing a Demotion']")]
        public IWebElement WorkPlaceeffect { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Embracing Different Minds: How Neurodiversity Strengthens Workplaces']")]
        public IWebElement WorkPlaceemb { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Embracing Workplace Change']")]
        public IWebElement WorkPlaceemb1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Engaging Employees in Multi-generational Workplaces']")]
        public IWebElement WorkPlaceeng { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Facing a Job Loss']")]
        public IWebElement WorkPlacefacing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Getting Adequate Sleep']")]
        public IWebElement WorkPlacegetting { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Going Abroad to Work'])[1]")]
        public IWebElement WorkPlacegoing { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Going Abroad to Work'])[2]")]
        public IWebElement WorkPlacegoing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Grief in the Workplace']")]
        public IWebElement WorkPlacegrief { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Health-Promoting Leadership Strategies']")]
        public IWebElement WorkPlacehealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Helping a Troubled Employee']")]
        public IWebElement WorkPlacehelping { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Helping Grieving Employees']")]
        public IWebElement WorkPlacehelping1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Deal With Job Loss']")]
        public IWebElement WorkPlacehow { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Defuse Entrenched Conflicts']")]
        public IWebElement WorkPlacehow1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Get the Information You Need From a Job Interview']")]
        public IWebElement WorkPlacehow2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Improve Your Writing Skills']")]
        public IWebElement WorkPlacehow3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Immigrant Employees Settling in North America']")]
        public IWebElement WorkPlaceimm { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Improving Your Physical Fitness']")]
        public IWebElement WorkPlaceimprove { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Workplace Change']")]
        public IWebElement WorkPlaceman { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Workplace Conflict']")]
        public IWebElement WorkPlaceman1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Workplace Stress']")]
        public IWebElement WorkPlaceman2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Me-Time: Managing Stress and Finding Work-Life Balance']")]
        public IWebElement WorkPlacemetime { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mental Wellness at Work']")]
        public IWebElement WorkPlacemental { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Modern Workplace Hazards'])[1]")]
        public IWebElement WorkPlacemod { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Modern Workplace Hazards'])[2]")]
        public IWebElement WorkPlacemod1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Moving Beyond Anxiety']")]
        public IWebElement WorkPlacemov { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Preparing your Business for Post-Pandemic'])[1]")]
        public IWebElement WorkPlaceprep { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Preparing your Business for Post-Pandemic'])[2]")]
        public IWebElement WorkPlaceprep1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Preparing your Business for Post-Pandemic'])[3]")]
        public IWebElement WorkPlaceprep2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='PTSD in the Workplace: Solutions and Support']")]
        public IWebElement WorkPlaceptsd { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Resilience']")]
        public IWebElement WorkPlaceres { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Respect in the Workplace']")]
        public IWebElement WorkPlaceresp { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Shift Worker Support']")]
        public IWebElement WorkPlaceshift { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Six Steps to Reducing Work Stress']")]
        public IWebElement WorkPlacesteps { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stages of Team Development']")]
        public IWebElement WorkPlacestages { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Neurodivergent Colleagues']")]
        public IWebElement WorkPlacesupport { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Your Colleague Coming Out']")]
        public IWebElement WorkPlacesupport1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Anger']")]
        public IWebElement WorkPlacetaking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Job Loss and Transition']")]
        public IWebElement WorkPlacetaking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Stress']")]
        public IWebElement WorkPlacetaking2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Your Career']")]
        public IWebElement WorkPlacetaking3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Your Mood']")]
        public IWebElement WorkPlacetaking4 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Ten Ways to Integrate Physical Activity into Your Workplace'])[1]")]
        public IWebElement WorkPlaceten { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Ten Ways to Integrate Physical Activity into Your Workplace'])[2]")]
        public IWebElement WorkPlaceten2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Importance of Personality Diversity']")]
        public IWebElement WorkPlaceimportance { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Invisible Wounds of Mental Health Disorders']")]
        public IWebElement WorkPlaceinvisible { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Working Parent']")]
        public IWebElement WorkPlacethe { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Thriving in Hybrid Work Environments']")]
        public IWebElement WorkPlacethriving { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Tips for Leading Multi-Generational Teams']")]
        public IWebElement WorkPlacetips { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Gone are the days when you bounced out of bed rea')]")]
        public IWebElement WorkPlaceunder { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Visualization']")]
        public IWebElement WorkPlacevis { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Presented by Cynthia Keys M.A., BEd., CCC., RCAT.,')]")]
        public IWebElement WorkPlacewebinar { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='What Causes Anger?']")]
        public IWebElement WorkPlacewhat { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='What to Do If a Co-Worker Is Suicidal']")]
        public IWebElement WorkPlacewhat1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Working After Retirement']")]
        public IWebElement WorkPlaceworking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Working Around the Clock']")]
        public IWebElement WorkPlaceworking1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Workplace Expectations: Dress Codes']")]
        public IWebElement WorkPlaceworking2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[74]")]
        public IWebElement WorkPlaceyou { get; set; }

        //WorkPlace CareerDevelopment
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Career Development']")]
        public IWebElement WorkPlaceCD { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Your hiring decision may not be influenced by phon')]")]
        public IWebElement WorkPlaceCD1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace/career-development'][text()='Career Development']")]
        public IWebElement WorkPlaceCDtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Burnout: What is it and How to Cope']")]
        public IWebElement WorkPlaceCD2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Career Counselling']")]
        public IWebElement WorkPlaceCD3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Embracing Workplace Change']")]
        public IWebElement WorkPlaceCD4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Going Abroad to Work']")]
        public IWebElement WorkPlaceCD5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Get the Information You Need From a Job Interview']")]
        public IWebElement WorkPlaceCD6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Improve Your Writing Skills']")]
        public IWebElement WorkPlaceCD7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Preventing Burnout']")]
        public IWebElement WorkPlaceCD8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Your Career']")]
        public IWebElement WorkPlaceCD9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Thriving in Hybrid Work Environments']")]
        public IWebElement WorkPlaceCD10 { get; set; }


        //WorkPlaceChangeTransition

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Change/Transition']")]
        public IWebElement WorkPlaceCT{ get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Demotions can occur for a variety of reasons: comp')]")]
        public IWebElement WorkPlaceCT1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace/change-transition'][text()='Change/Transition']")]
        public IWebElement WorkPlaceCTtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Embracing Workplace Change']")]
        public IWebElement WorkPlaceCT2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Helping Veterans Transition to a Civilian Workplace']")]
        public IWebElement WorkPlaceCT3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How Can I Cope With My Feelings About the Future?']")]
        public IWebElement WorkPlaceCT4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Deal With Job Loss']")]
        public IWebElement WorkPlaceCT5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Workplace Change']")]
        public IWebElement WorkPlaceCT6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Job Loss and Transition']")]
        public IWebElement WorkPlaceCT7 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='The Weight of Winter and Negative Thoughts'])[1]")]
        public IWebElement WorkPlaceCT8 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='The Weight of Winter and Negative Thoughts'])[2]")]
        public IWebElement WorkPlaceCT9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Transitioning to a Civilian Workplace: A Guide for Veterans']")]
        public IWebElement WorkPlaceCT10 { get; set; }

        //Workplace Communication
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace/communication'][text()='Communication']")]
        public IWebElement WorkPlaceComm { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='2SLGBTQ+ Inclusivity in the Workplace']")]
        public IWebElement WorkPlaceComm1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace/communication'][text()='Communication']")]
        public IWebElement WorkPlaceCommtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Engaging Employees in Multi-generational Workplaces']")]
        public IWebElement WorkPlaceComm2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Survive']")]
        public IWebElement WorkPlaceComm3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Immigrant Employees Settling in North America'])[1]")]
        public IWebElement WorkPlaceComm4 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Immigrant Employees Settling in North America'])[2]")]
        public IWebElement WorkPlaceComm5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Workplace Conflict']")]
        public IWebElement WorkPlaceComm6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Respect in the Workplace']")]
        public IWebElement WorkPlaceComm7 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Teaching Inclusivity and Inclusive Language'])[1]")]
        public IWebElement WorkPlaceComm8 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Teaching Inclusivity and Inclusive Language'])[2]")]
        public IWebElement WorkPlaceComm9 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Teaching Inclusivity and Inclusive Language'])[3]")]
        public IWebElement WorkPlaceComm10 { get; set; }

        //Workplace Fitness

        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace/fitness'][text()='Fitness']")]
        public IWebElement WorkPlaceFitness { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Does Work Have to be Stressful?']")]
        public IWebElement WorkPlaceFitness1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace/fitness'][text()='Fitness']")]
        public IWebElement WorkPlaceFitnesstag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Getting Adequate Sleep']")]
        public IWebElement WorkPlaceFitness2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Improving Your Physical Fitness']")]
        public IWebElement WorkPlaceFitness3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Social Media Diet and Fitness']")]
        public IWebElement WorkPlaceFitness4 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Ten Ways to Integrate Physical Activity into Your Workplace'])[1]")]
        public IWebElement WorkPlaceFitness5 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Ten Ways to Integrate Physical Activity into Your Workplace'])[2]")]
        public IWebElement WorkPlaceFitness6 { get; set; }

        //WorkPlaceManagement

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Management']")]
        public IWebElement WorkPlacemgmt { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='2SLGBTQ+ Inclusivity in the Workplace']")]
        public IWebElement WorkPlacemgmt2SL { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace/management'][text()='Management']")]
        public IWebElement workplacemgmttag { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Building a Healthy Workplace']")]
        public IWebElement WorkPlacemgmtbuilding { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Creating a Healthy Workplace'])[1]")]
        public IWebElement WorkPlacemgmtcreate { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Creating a Healthy Workplace'])[2]")]
        public IWebElement WorkPlacemgmtcreate1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Does Work Have to be Stressful?']")]
        public IWebElement WorkPlacemgmtdoes { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Embracing Different Minds (Audio)']")]
        public IWebElement WorkPlacemgmtembracing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Embracing Different Minds (Video)']")]
        public IWebElement WorkPlacemgmtembracing1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Embracing Different Minds: How Neurodiversity Strengthens Workplaces']")]
        public IWebElement WorkPlacemgmtembracing2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Encouraging Work-Life Balance']")]
        public IWebElement WorkPlacemgmtencourage { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Health-Promoting Leadership Strategies']")]
        public IWebElement WorkPlacemgmthealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Helping a Troubled Employee']")]
        public IWebElement WorkPlacemgmthelp { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Helping Grieving Employees']")]
        public IWebElement WorkPlacemgmthelp1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Defuse Entrenched Conflicts']")]
        public IWebElement WorkPlacemgmthow { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Immigrant Employees Settling in North America'])[1]")]
        public IWebElement WorkPlacemgmtimm { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Immigrant Employees Settling in North America'])[2]")]
        public IWebElement WorkPlacemgmtimm1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Workplace Stress']")]
        public IWebElement WorkPlacemgmtwokrplace { get; set; }
       
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Modern Workplace Hazards'])[1]")]
        public IWebElement WorkPlacemgmtmod { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Modern Workplace Hazards'])[2]")]
        public IWebElement WorkPlacemgmtmod1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Respect in the Workplace']")]
        public IWebElement WorkPlacemgmtrespect { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Stages of Team Development']")]
        public IWebElement WorkPlacemgmtstages { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Your Career']")]
        public IWebElement WorkPlacemgmttalking { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Invisible Wounds of Mental Health Disorders']")]
        public IWebElement WorkPlacemgmtthe { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Thriving in Hybrid Work Environments'])[1]")]
        public IWebElement WorkPlacemgmtthrive { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Thriving in Hybrid Work Environments'])[2]")]
        public IWebElement WorkPlacemgmtthrive1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Tips for Leading Multi-Generational Teams']")]
        public IWebElement WorkPlacemgmttips { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Tips for Leading Multi-Generational Teams']")]
        public IWebElement WorkPlacemgmtunder { get; set; }

        //WorkPlaceMentalHealth

        [FindsBy(How = How.XPath, Using = "//a[@href='/app/en/resources/category/permalink/workplace/mental-health']")]
        public IWebElement WorkPlacementalhealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The term work-life balance is often misunderstood ')]")]
        public IWebElement WorkPlacemenhealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace/mental-health'][text()='Mental Health']")]
        public IWebElement WorkPlacemenhealthtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Although it’s normal to feel sad or upset from tim')]")]
        public IWebElement WorkPlacementalhealth1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Building a Healthy Workplace']")]
        public IWebElement WorkPlacementalhealth2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Burnout: What is it and How to Cope'])[1]")]
        public IWebElement WorkPlacementalhealth3 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Burnout: What is it and How to Cope'])[2]")]
        public IWebElement WorkPlacementalhealth4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Compassion Fatigue']")]
        public IWebElement WorkPlacementalhealth5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Creating Work-Life Balance']")]
        public IWebElement WorkPlacementalhealth6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Dealing With Shift Work']")]
        public IWebElement WorkPlacementalhealth7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Does Work Have to be Stressful?']")]
        public IWebElement WorkPlacementalhealth8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Encouraging Work-Life Balance']")]
        public IWebElement WorkPlacementalhealth9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Facing a Job Loss']")]
        public IWebElement WorkPlacementalhealth10 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Finding Work-Life Balance in a Post-Pandemic World'])[1]")]
        public IWebElement WorkPlacementalhealth11 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Finding Work-Life Balance in a Post-Pandemic World'])[2]")]
        public IWebElement WorkPlacementalhealth12 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Finding Work-Life Balance in a Post-Pandemic World'])[3]")]
        public IWebElement WorkPlacementalhealth13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Going Abroad to Work']")]
        public IWebElement WorkPlacementalhealth14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Deal With Job Loss']")]
        public IWebElement WorkPlacementalhealth15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Workplace Change']")]
        public IWebElement WorkPlacementalhealth16 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Workplace Conflict']")]
        public IWebElement WorkPlacementalhealth17 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Workplace Stress']")]
        public IWebElement WorkPlacementalhealth18 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Me-Time: Managing Stress and Finding Work-Life Balance']")]
        public IWebElement WorkPlacementalhealth19 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Mental Wellness at Work']")]
        public IWebElement WorkPlacementalhealth20 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Moving Beyond Anxiety']")]
        public IWebElement WorkPlacementalhealth21 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='PTSD in the Workplace: Solutions and Support']")]
        public IWebElement WorkPlacementalhealth22 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Resilience']")]
        public IWebElement WorkPlacementalhealth23 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Sentio by Homewood Health']")]
        public IWebElement WorkPlacementalhealth24 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Shift Worker Support']")]
        public IWebElement WorkPlacementalhealth25 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Six Steps to Reducing Work Stress']")]
        public IWebElement WorkPlacementalhealth26 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Anger']")]
        public IWebElement WorkPlacementalhealth27 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Job Loss and Transition']")]
        public IWebElement WorkPlacementalhealth28 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Your Mood']")]
        public IWebElement WorkPlacementalhealth29 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Invisible Wounds of Mental Health Disorders']")]
        public IWebElement WorkPlacementalhealth30 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​Gone are the days when you bounced out of bed rea')]")]
        public IWebElement WorkPlacementalhealth31 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Visualization']")]
        public IWebElement WorkPlacementalhealth32 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='What Causes Anger?']")]
        public IWebElement WorkPlacementalhealth33 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='What to Do If a Co-Worker Is Suicidal']")]
        public IWebElement WorkPlacementalhealth34 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Working Around the Clock']")]
        public IWebElement WorkPlacementalhealth35 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'])[36]")]
        public IWebElement WorkPlacementalhealth36 { get; set; }

        //Workplace Transition
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Transition']")]
        public IWebElement WorkPlacetransition { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='A Resource Guide for Trans and Gender Diverse People']")]
        public IWebElement WorkPlacetransition1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace/transition'][text()='Transition']")]
        public IWebElement WorkPlacetransitiontag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Embracing Workplace Change']")]
        public IWebElement WorkPlacetransition2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Going Abroad to Work']")]
        public IWebElement WorkPlacetransition3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Helping Veterans Transition to a Civilian Workplace']")]
        public IWebElement WorkPlacetransition4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Workplace Change']")]
        public IWebElement WorkPlacetransition5 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Preparing your Business for Post-Pandemic'])[1]")]
        public IWebElement WorkPlacetransition6 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Preparing your Business for Post-Pandemic'])[2]")]
        public IWebElement WorkPlacetransition7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Job Loss and Transition']")]
        public IWebElement WorkPlacetransition8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Taking Control of Your Career']")]
        public IWebElement WorkPlacetransition9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Weight of Winter and Negative Thoughts']")]
        public IWebElement WorkPlacetransition10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Transitioning to a Civilian Workplace: A Guide for Veterans']")]
        public IWebElement WorkPlacetransition11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Presented by Dr. Sandra Primiano, Ph.D., Psy.D, th')]")]
        public IWebElement WorkPlacetransition12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Presented by Cynthia Keys M.A., BEd., CCC., RCAT.,')]")]
        public IWebElement WorkPlacetransition13 { get; set; }

        //ManagerRegression
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Tools']")]
        public IWebElement Managertools { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'E-Courses for managers, supervisors or key personn')]")]
        public IWebElement Managertoolsecourses { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/tools'][text()='Tools']")]
        public IWebElement Managertoolstag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Have a look at some PDF resources for managers, su')]")]
        public IWebElement Managertoolsres { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='E-courses']")]
        public IWebElement Managertoolsecourses1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='content']//p[contains(text(),'Homeweb e-Learning courses provide self-paced, pri')]")]
        public IWebElement Managertoolsecoursesmanagers { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/tools/e-courses'][text()='E-courses']")]
        public IWebElement Managertoolsecoursestag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course presents the fundamentals of effective')]")]
        public IWebElement Managertoolsecoursesfund { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'For Key Persons and supervisors leading employees ')]")]
        public IWebElement Managertoolsecourseslead { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Certain kinds of workplace issues give rise to wor')]")]
        public IWebElement Managertoolsecoursesmanaging { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course helps key persons and supervisors iden')]")]
        public IWebElement Managertoolsecoursessupport { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The purpose of this course is to help key persons ')]")]
        public IWebElement Managertoolsecoursesvalue { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Mental Health']")]
        public IWebElement Managermentalhealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Infertility can be one of the most upsetting exper')]")]
        public IWebElement Managermentalhealthfertility { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/mental-health'][text()='Mental Health']")]
        public IWebElement Managermentalhealthtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Moral Injury and the Path to Wellness – A Guide for Employers']")]
        public IWebElement Managermentalhealthguide { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Crisis']")]
        public IWebElement Managercrisis { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Have you ever thought about how you would react an')]")]
        public IWebElement Managercrisismanagement { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/crisis'][text()='Crisis']")]
        public IWebElement Managercrisistag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In light of the recent major flooding and the poss')]")]
        public IWebElement Managercrisisflooding { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Family']")]
        public IWebElement Managerfamily { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Fertility Treatments and Your Mental Health']")]
        public IWebElement Managerfamilyfert { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/family'][text()='Family']")]
        public IWebElement Managerfamilytag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'For employers, the sandwich generation means a sig')]")]
        public IWebElement Managerfamilyworking { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Caregiving']")]
        public IWebElement Managerfamilycaregiving { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/family/caregiving'][text()='Caregiving']")]
        public IWebElement Managerfamilycaregivingtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Lifestyle']")]
        public IWebElement ManagerLifestyle { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'You have just learned about important changes that')]")]
        public IWebElement ManagerLifestylefacing { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle'][text()='Lifestyle']")]
        public IWebElement ManagerLifestyletag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'For Key Persons and supervisors leading employees ')]")]
        public IWebElement ManagerLifestyleleading { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'If you were asked to think about what someone with')]")]
        public IWebElement ManagerLifestyleuncovering { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Addiction']")]
        public IWebElement ManagerLifestyleaddiction { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'If you were asked to think about what someone with')]")]
        public IWebElement ManagerLifestyleaddictionuncover { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle/addiction'][text()='Addiction']")]
        public IWebElement ManagerLifestyleaddictiontag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Diversity and Inclusion']")]
        public IWebElement ManagerLifestyleDEI { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'​This podcast should help you understand the myria')]")]
        public IWebElement ManagerLifestyleDEI1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle/diversity-and-inclusion'][text()='Diversity and Inclusion']")]
        public IWebElement ManagerLifestyleDEItag { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Supporting Employees with Disabilities'])[2]")]
        public IWebElement ManagerLifestyleDEI2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Supporting Employees with Disabilities'])[3]")]
        public IWebElement ManagerLifestyleDEI3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Fitness']")]
        public IWebElement ManagerLifestyleFitness { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Pain management has evolved to include more types ')]")]
        public IWebElement ManagerLifestyleFitnesepain { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle/fitness'][text()='Fitness']")]
        public IWebElement ManagerLifestyleFitnesstag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Manager Newsletters']")]
        public IWebElement ManagerLifestyleNewsletter { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='2SLGBTQ+ Inclusivity in the Workplace']")]
        public IWebElement ManagerLifestyleNews2SLG { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle/manager-newsletters'][text()='Manager Newsletters']")]
        public IWebElement ManagerLifestyleNewstag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='2SLGBTQ+ Inclusivity in the Workplace']")]
        public IWebElement ManagerLifestyleNews2SLG1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Embracing Different Minds (Audio)']")]
        public IWebElement ManagerLifestyleNewsletter1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Embracing Different Minds (Video)']")]
        public IWebElement ManagerLifestyleNewsletter2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Embracing Different Minds: How Neurodiversity Strengthens Workplaces']")]
        public IWebElement ManagerLifestyleNewsletter3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Guiding Employees Through Change']")]
        public IWebElement ManagerLifestyleNewsletter4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Support Employees with Children Attending School']")]
        public IWebElement ManagerLifestyleNewsletter5 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Immigrant Employees Settling in North America'])[1]")]
        public IWebElement ManagerLifestyleNewsletter6 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Immigrant Employees Settling in North America'])[2]")]
        public IWebElement ManagerLifestyleNewsletter7 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Leading the Way'])[1]")]
        public IWebElement ManagerLifestyleNewsletter8 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Leading the Way'])[2]")]
        public IWebElement ManagerLifestyleNewsletter9 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Leading the Way'])[3]")]
        public IWebElement ManagerLifestyleNewsletter10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Leading with Empathy and Supporting Employee Success']")]
        public IWebElement ManagerLifestyleNewsletter11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Employee Motivation']")]
        public IWebElement ManagerLifestyleNewsletter12 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Modern Workplace Hazards'])[1]")]
        public IWebElement ManagerLifestyleNewsletter13 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Modern Workplace Hazards'])[2]")]
        public IWebElement ManagerLifestyleNewsletter14 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Nurturing Well-Being for Peak Performance'])[1]")]
        public IWebElement ManagerLifestyleNewsletter15 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Nurturing Well-Being for Peak Performance'])[2]")]
        public IWebElement ManagerLifestyleNewsletter16 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Nurturing Well-Being for Peak Performance'])[3]")]
        public IWebElement ManagerLifestyleNewsletter17 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Pain Management']")]
        public IWebElement ManagerLifestyleNewsletter18 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Promoting Psychological Health While Going Through Change']")]
        public IWebElement ManagerLifestyleNewsletter19 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Supporting Employees with Disabilities'])[1]")]
        public IWebElement ManagerLifestyleNewsletter20 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Supporting Employees with Disabilities'])[2]")]
        public IWebElement ManagerLifestyleNewsletter21 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Supporting Employees with Disabilities'])[3]")]
        public IWebElement ManagerLifestyleNewsletter22 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Men in Getting Mental Health and Addiction Support']")]
        public IWebElement ManagerLifestyleNewsletter23 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Successful Return to Work']")]
        public IWebElement ManagerLifestyleNewsletter24 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Ten Ways to Integrate Physical Activity into Your Workplace'])[1]")]
        public IWebElement ManagerLifestyleNewsletter25 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Ten Ways to Integrate Physical Activity into Your Workplace'])[2]")]
        public IWebElement ManagerLifestyleNewsletter26 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='The Importance of Personality Diversity']")]
        public IWebElement ManagerLifestyleNewsletter27 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Tips for Creating a Healthy Workplace']")]
        public IWebElement ManagerLifestyleNewsletter28 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Tips for Leading Multi-Generational Teams']")]
        public IWebElement ManagerLifestyleNewsletter29 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Transgender : Where to Find and How to Give Support']")]
        public IWebElement ManagerLifestyleNewsletter30 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Uncovering Hidden Addictions']")]
        public IWebElement ManagerLifestyleNewsletter31 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Addiction']")]
        public IWebElement ManagerLifestyleNewsletter32 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='When Abuse and Violence Come to Work']")]
        public IWebElement ManagerLifestyleNewsletter33 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@href='/app/en/resources/category/permalink/lifestyle/mental-health']")]
        public IWebElement ManagerLifestyleMentalHealth { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'You have just learned about important changes that')]")]
        public IWebElement ManagerLifestyleMenhea { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle/mental-health'][text()='Mental Health']")]
        public IWebElement ManagerLifestyleMenheatag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Workplace']")]
        public IWebElement ManagerWorkplace { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cannabis became legal for all adults in Canada on ')]")]
        public IWebElement ManagerWorkplacecann { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace'][text()='Workplace']")]
        public IWebElement ManagerWorkplacetag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'What makes teams effective? This article outlines ')]")]
        public IWebElement ManagerWorkplaceteams { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Connecting Healthy Sleep and Workplace Safety']")]
        public IWebElement ManagerWorkplaceconnecting { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Have you ever thought about how you would react an')]")]
        public IWebElement ManagerWorkplacecrisis { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'It’s in an organization’s best interest to retain ')]")]
        public IWebElement ManagerWorkplaceemployer { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'In today’s fast-paced and ever-changing business e')]")]
        public IWebElement ManagerWorkplacefacilitating { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Facing a Major Work Transition']")]
        public IWebElement ManagerWorkplacefacing { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Fundamentals of Effective Supervision']")]
        public IWebElement ManagerWorkplacefund { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Guiding Employees Through Change']")]
        public IWebElement ManagerWorkplaceguiding { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Support Employees with Children Attending School']")]
        public IWebElement ManagerWorkplacehowto { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Leading the Human Side of Change']")]
        public IWebElement ManagerWorkplaceleading { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Sensitive Employee Issues']")]
        public IWebElement ManagerWorkplacemanaging { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Optimizing Resiliency'])[1]")]
        public IWebElement ManagerWorkplaceopt { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Optimizing Resiliency'])[2]")]
        public IWebElement ManagerWorkplaceopt1 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Optimizing Resiliency'])[3]")]
        public IWebElement ManagerWorkplaceopt2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Promoting Psychological Health While Going Through Change']")]
        public IWebElement ManagerWorkplacepromoting { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Resources for Managers']")]
        public IWebElement ManagerWorkplaceres { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Employees Affected by Flooding']")]
        public IWebElement ManagerWorkplacesup { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Employees that Work Around the Clock']")]
        public IWebElement ManagerWorkplacesup1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Men in Getting Mental Health and Addiction Support']")]
        public IWebElement ManagerWorkplacesup2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Respect in the Workplace']")]
        public IWebElement ManagerWorkplacesup3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Successful Return to Work']")]
        public IWebElement ManagerWorkplacesup4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Transgender and Gender Diverse Employees']")]
        public IWebElement ManagerWorkplacesup5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Tips for Creating a Healthy Workplace']")]
        public IWebElement ManagerWorkplacetips { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Transgender : Where to Find and How to Give Support']")]
        public IWebElement ManagerWorkplacetrans { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Understanding Addiction']")]
        public IWebElement ManagerWorkplaceunder { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Values-Based Leadership']")]
        public IWebElement ManagerWorkplacevalue { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='When Abuse and Violence Come to Work']")]
        public IWebElement ManagerWorkplacewhen { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Workplace Equity']")]
        public IWebElement ManagerWorkplacework { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Career Development']")]
        public IWebElement ManagerWorkplacecareer { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Facing a Major Work Transition']")]
        public IWebElement ManagerWorkplacecareertrans { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace/career-development'][text()='Career Development']")]
        public IWebElement ManagerWorkplacecareertag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course helps key persons and supervisors iden')]")]
        public IWebElement ManagerWorkplacecareersupport { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Communication']")]
        public IWebElement ManagerWorkplacecareercomm { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course presents the fundamentals of effective')]")]
        public IWebElement ManagerWorkplacecommfund { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace/communication'][text()='Communication']")]
        public IWebElement ManagerWorkplacecommtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Certain kinds of workplace issues give rise to wor')]")]
        public IWebElement ManagerWorkplacecommsens { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'This course helps key persons and supervisors iden')]")]
        public IWebElement ManagerWorkplacecommsupport { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Transgender : Where to Find and How to Give Support']")]
        public IWebElement ManagerWorkplacecommtrans { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Management']")]
        public IWebElement ManagerWorkplacemgmt { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Cannabis became legal for all adults in Canada on ')]")]
        public IWebElement ManagerWorkplacemgmtcann { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace/management'][text()='Management']")]
        public IWebElement ManagerWorkplacemgmttag { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'What makes teams effective? This article outlines ')]")]
        public IWebElement ManagerWorkplacemgmt1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Have you ever thought about how you would react an')]")]
        public IWebElement ManagerWorkplacemgmt2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Employer Strategies to Retain Employees']")]
        public IWebElement ManagerWorkplacemgmt3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Facilitating Resilience in the Workplace']")]
        public IWebElement ManagerWorkplacemgmt4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Fundamentals of Effective Supervision']")]
        public IWebElement ManagerWorkplacemgmt5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Guiding Employees Through Change']")]
        public IWebElement ManagerWorkplacemgmt6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='How to Support Employees with Children Attending School']")]
        public IWebElement ManagerWorkplacemgmt7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Leading the Human Side of Change']")]
        public IWebElement ManagerWorkplacemgmt8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Leading the Way']")]
        public IWebElement ManagerWorkplacemgmt9 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Leading with Empathy and Supporting Employee Success'])[1]")]
        public IWebElement ManagerWorkplacemgmt10 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Leading with Empathy and Supporting Employee Success'])[2]")]
        public IWebElement ManagerWorkplacemgmt11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Employee Motivation']")]
        public IWebElement ManagerWorkplacemgmt12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Managing Sensitive Employee Issues']")]
        public IWebElement ManagerWorkplacemgmt13 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Managing Teams Remotely'])[1]")]
        public IWebElement ManagerWorkplacemgmt14 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Managing Teams Remotely'])[2]")]
        public IWebElement ManagerWorkplacemgmt15 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Managing Teams Remotely'])[3]")]
        public IWebElement ManagerWorkplacemgmt16 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Moral Injury and the Path to Wellness – A Guide for Employers']")]
        public IWebElement ManagerWorkplacemgmt17 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Nurturing Well-Being for Peak Performance'])[1]")]
        public IWebElement ManagerWorkplacemgmt18 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Nurturing Well-Being for Peak Performance'])[2]")]
        public IWebElement ManagerWorkplacemgmt19 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Optimizing Resiliency'])[1]")]
        public IWebElement ManagerWorkplacemgmt20 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Optimizing Resiliency'])[2]")]
        public IWebElement ManagerWorkplacemgmt21 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//SPAN[@class='title h1'][text()='Optimizing Resiliency'])[3]")]
        public IWebElement ManagerWorkplacemgmt22 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Resources for Managers']")]
        public IWebElement ManagerWorkplacemgmt23 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Employees Affected by Flooding']")]
        public IWebElement ManagerWorkplacemgm24 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Employees with Disabilities']")]
        public IWebElement ManagerWorkplacemgmt25 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Neurodiversity in the Workplace']")]
        public IWebElement ManagerWorkplacemgmt26 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Respect in the Workplace']")]
        public IWebElement ManagerWorkplacemgmt27 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Successful Return to Work']")]
        public IWebElement ManagerWorkplacemgmt28 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Transgender and Gender Diverse Employees']")]
        public IWebElement ManagerWorkplacemgmt29 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Tips for Creating a Healthy Workplace']")]
        public IWebElement ManagerWorkplacemgmt30 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Transgender : Where to Find and How to Give Support']")]
        public IWebElement ManagerWorkplacemgmt31 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Values-Based Leadership']")]
        public IWebElement ManagerWorkplacemgmt32 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@href='/app/en/resources/category/permalink/workplace/mental-health']")]
        public IWebElement ManagerWorkplacementhea { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Healthy work environments promote positive work-li')]")]
        public IWebElement ManagerWorkplacementhea1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace/mental-health'][text()='Mental Health']")]
        public IWebElement ManagerWorkplacementheatag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Facilitating Resilience in the Workplace']")]
        public IWebElement ManagerWorkplacementhea2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Facing a Major Work Transition']")]
        public IWebElement ManagerWorkplacementhea3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Leading the Way']")]
        public IWebElement ManagerWorkplacementhea4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Employees that Work Around the Clock']")]
        public IWebElement ManagerWorkplacementhea5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Employees with Disabilities']")]
        public IWebElement ManagerWorkplacementhea6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Supporting Men in Getting Mental Health and Addiction Support']")]
        public IWebElement ManagerWorkplacementhea7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='When Abuse and Violence Come to Work']")]
        public IWebElement ManagerWorkplacementhea8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Transition']")]
        public IWebElement ManagerWorkplacetransition { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Leading the Human Side of Change']")]
        public IWebElement ManagerWorkplacetransition1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace/transition'][text()='Transition']")]
        public IWebElement ManagerWorkplacetransitiontag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Promoting Psychological Health While Going Through Change']")]
        public IWebElement ManagerWorkplacetransition2 { get; set; }

        //PlanAdmin Regression

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='HR Resources']")]
        public IWebElement PlanAdminHRres { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Code of Conduct']")]
        public IWebElement PlanAdminHRres1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/hr-resources'][text()='HR Resources']")]
        public IWebElement PlanAdminHRrestag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Code of Ethics']")]
        public IWebElement PlanAdminHRres2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Confidentiality']")]
        public IWebElement PlanAdminHRres3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Confirmation of Offer Letter']")]
        public IWebElement PlanAdminHRres4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Covenant Not to Compete']")]
        public IWebElement PlanAdminHRres5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Decline Letter Form']")]
        public IWebElement PlanAdminHRres6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Employment Agreement']")]
        public IWebElement PlanAdminHRres7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Harassment / Discrimination Complaints']")]
        public IWebElement PlanAdminHRres8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='HR: Supporting Transgender and Gender Diverse Employees']")]
        public IWebElement PlanAdminHRres9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Performance Evaluations']")]
        public IWebElement PlanAdminHRres10 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Performance Management Sample Form']")]
        public IWebElement PlanAdminHRres11 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Performance Notification']")]
        public IWebElement PlanAdminHRres12 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Probation Review']")]
        public IWebElement PlanAdminHRres13 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Purpose']")]
        public IWebElement PlanAdminHRres14 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Recruitment Interview']")]
        public IWebElement PlanAdminHRres15 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Reference Check Form']")]
        public IWebElement PlanAdminHRres16 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Some Problems with Performance Management Forms']")]
        public IWebElement PlanAdminHRres17 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='What Is Performance Management?']")]
        public IWebElement PlanAdminHRres18 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Employee Handbooks']")]
        public IWebElement PlanAdminHRresemphand { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Code of Conduct']")]
        public IWebElement PlanAdminHRresemphand1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/hr-resources/employee-handbooks'][text()='Employee Handbooks']")]
        public IWebElement PlanAdminHRresemphandtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Code of Ethics']")]
        public IWebElement PlanAdminHRresemphand2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Confidentiality']")]
        public IWebElement PlanAdminHRresemphand3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Confirmation of Offer Letter']")]
        public IWebElement PlanAdminHRresemphand4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Covenant Not to Compete']")]
        public IWebElement PlanAdminHRresemphand5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Employment Agreement']")]
        public IWebElement PlanAdminHRresemphand6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Generic Job Description']")]
        public IWebElement PlanAdminHRresemphand7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Harassment / Discrimination Complaints']")]
        public IWebElement PlanAdminHRresemphand8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Probation Review']")]
        public IWebElement PlanAdminHRresemphand9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Job Descriptions']")]
        public IWebElement PlanAdminHRresJD { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'As a Human Resources professional, here is a templ')]")]
        public IWebElement PlanAdminHRresJD1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/hr-resources/job-descriptions'][text()='Job Descriptions']")]
        public IWebElement PlanAdminHRresJDtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Thriving in Hybrid Work Environments']")]
        public IWebElement PlanAdminHRresJD2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Performance Management']")]
        public IWebElement PlanAdminHRresPM { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The core of any performance evaluation program is ')]")]
        public IWebElement PlanAdminHRresPM1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/hr-resources/performance-management'][text()='Performance Management']")]
        public IWebElement PlanAdminHRresPMtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Performance Management Sample Form']")]
        public IWebElement PlanAdminHRresPM2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Performance Notification']")]
        public IWebElement PlanAdminHRresPM3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='​Some Problems with Performance Management Forms']")]
        public IWebElement PlanAdminHRresPM4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='What Is Performance Management?']")]
        public IWebElement PlanAdminHRresPM5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Probationary Period']")]
        public IWebElement PlanAdminHRresPP { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Purpose']")]
        public IWebElement PlanAdminHRresPP1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/hr-resources/probationary-period'][text()='Probationary Period']")]
        public IWebElement PlanAdminHRresPPtag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Recruitment']")]
        public IWebElement PlanAdminHRresrec { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title'][text()='Recruitment Interview']")]
        public IWebElement PlanAdminHRresrec1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/hr-resources/recruitment'][text()='Recruitment']")]
        public IWebElement PlanAdminHRresrectag { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='Reference Check Form']")]
        public IWebElement PlanAdminHRresrec2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Lifestyle']")]
        public IWebElement PlanAdminLS { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Many sectors require shift work (e.g., healthcare,')]")]
        public IWebElement PlanAdminLS1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle'][text()='Lifestyle']")]
        public IWebElement PlanAdminLStag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Mental Health']")]
        public IWebElement PlanAdminLSmenhea { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Many sectors require shift work (e.g., healthcare,')]")]
        public IWebElement PlanAdminLSmenhea1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/lifestyle/mental-health'][text()='Mental Health']")]
        public IWebElement PlanAdminLSmenheatag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Workplace']")]
        public IWebElement PlanAdminWP { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Mental Health']")]
        public IWebElement PlanAdminWPmenhea { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Many sectors require shift work (e.g., healthcare,')]")]
        public IWebElement PlanAdminWPmenhea1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace/mental-health'][text()='Mental Health']")]
        public IWebElement PlanAdminWPmenheatag { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Transition']")]
        public IWebElement PlanAdminWPtransition { get; set; }
        [FindsBy(How = How.XPath, Using = "//SPAN[@class='title h1'][text()='HR: Supporting Transgender and Gender Diverse Employees']")]
        public IWebElement PlanAdminWPtransition1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//A[@href='/app/en/resources/category/permalink/workplace/transition'][text()='Transition']")]
        public IWebElement PlanAdminWPtransitiontag { get; set; }






















    }
}





