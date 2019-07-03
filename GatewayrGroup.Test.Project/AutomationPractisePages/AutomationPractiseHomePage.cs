using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace GatewayrGroup.Test.Project.AutomationPractisePages
{
    class AutomationPractiseHomePage
    {
        internal void ClickonSignInLink(IWebDriver driver)
        {
            driver.FindElement(By.CssSelector("a.login")).Click();

        }

        internal void ClickonTshirtfromWomenCategory(IWebDriver driver)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath(".//div[@id='block_top_menu']//a[@title='Women']"))).Build().Perform();
            Thread.Sleep(800);

            action.MoveToElement(driver.FindElement(By.XPath("(.//div[@id='block_top_menu']//a[@title='T-shirts'])[1]"))).Click().Build().Perform();

            //  WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromHours(2));
           // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(".//select[@id='selectProductSort']")));
        }
    }
}
