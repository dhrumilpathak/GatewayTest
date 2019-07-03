using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GatewayrGroup.Test.Project.AutomationPractisePages
{
    class SignInDetailsPage
    {
        string emailadress = "gtl_test@thegatewaycorp.com";
        string password = "Gtl@123";

        internal void EnterUserName(IWebDriver driver) => driver.FindElement(By.Id("email")).SendKeys(emailadress);

        internal void EnterPassword(IWebDriver driver) => driver.FindElement(By.Id("passwd")).SendKeys(password);

        internal void ClickOnSignInButton(IWebDriver driver)
        {

            driver.FindElement(By.Name("SubmitLogin")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromHours(2));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(".//a[@class='logout']")));

        }


    }
}
