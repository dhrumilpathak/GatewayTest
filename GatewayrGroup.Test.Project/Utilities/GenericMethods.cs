using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using System.Threading;


namespace GatewayrGroup.Test.Project.Utilities
{
      class   GenericMethods :AutomationPractiseBaseClass
    {

        public void explicit_waits(IWebDriver driver  , By Locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Locator));
        }

    }
}

