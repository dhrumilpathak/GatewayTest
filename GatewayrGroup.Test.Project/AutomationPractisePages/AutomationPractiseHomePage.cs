using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using GatewayrGroup.Test.Project.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace GatewayrGroup.Test.Project.AutomationPractisePages
{
    class AutomationPractiseHomePage
    {
       
        GenericMethods _genericmethod = new GenericMethods();
        internal void ClickonSignInLink(IWebDriver driver)
        {

            _genericmethod.explicit_waits(driver, By.CssSelector("a.login"));
            driver.FindElement(By.CssSelector("a.login")).Click();
            _genericmethod.explicit_waits(driver, By.Name("SubmitLogin"));
        }

        internal void ClickonTshirtfromWomenCategory(IWebDriver driver)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath(".//div[@id='block_top_menu']//a[@title='Women']"))).Build().Perform();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            action.MoveToElement(driver.FindElement(By.XPath("(.//div[@id='block_top_menu']//a[@title='T-shirts'])[1]"))).Click().Build().Perform();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Console.WriteLine("Hello");
            //  WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromHours(2));
            // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(".//select[@id='selectProductSort']")));
        }
    }
}
