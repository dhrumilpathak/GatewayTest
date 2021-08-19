using GatewayrGroup.Test.Project.AutomationPractisePages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace GatewayrGroup.Test.Project.AutomationPractiseTestMethods
{
    class GoogleSearchTest : AutomationPractiseBaseClass
    {
        GooglePages _Googlepage = new GooglePages();

     
        [Description("284720")]
        [Category("SmokeTest")]
        [TestCase("Dhrumil Pathak")]
        public void OpenVerifyNewtabpageTitle_Test(string name)
        {          

            OpenGoogle(driver);         // open google 
            _Googlepage.EnterName(driver).SendKeys(name + Keys.Enter); // Enter the Name from the Testcase Data attribute 
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(5);
            _Googlepage.Clickon3rdLink(driver);  //Click on the 3rd link on the page.
            _Googlepage.NavigatetoNewTab(driver); // Navigate to new TAb and set the focus of the driver to the new tab 
            string pagetitle = driver.Title;    //gets the page title 
            if (pagetitle.Equals("Dhrumil Pathak | Facebook"))
            {


                Assert.That(pagetitle, Is.EqualTo("Dhrumil Pathak | Facebook"),
                    " The page title is not matching as expected");   // verify the Page title.

            }
            else if(pagetitle.Equals("Dhrumil Pathak - Quora"))
            {
                Assert.That(pagetitle, Is.EqualTo("Dhrumil Pathak - Quora"));
            }

            else 
            {
                Assert.That(pagetitle, Is.EqualTo("Dhrumil Pathak - Action and work speak louder then the profile and text in Vadodara, Vadodara"));
            }

            

        }
    }
}
