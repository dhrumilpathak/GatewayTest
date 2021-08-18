using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using System.Threading;


namespace GatewayrGroup.Test.Project
{

  
    class AutomationPractiseBaseClass
    {
        public IWebDriver driver = null;

        [SetUp]
        public void Setup()
        {

            /// it will take the Chromedriver automatically from the project folder 

           driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)); 
       

        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
            driver.Quit();
        }

        internal void OpenAutomationPractiseUrl(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
         
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromHours(2));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("a.login")));
            driver.Manage().Window.Maximize();
        }

        internal void OpenGoogle(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.google.com/");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(5);
            driver.Manage().Window.Maximize();
        }
    }
}
