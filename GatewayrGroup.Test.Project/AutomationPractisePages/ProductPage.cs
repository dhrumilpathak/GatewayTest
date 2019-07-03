using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GatewayrGroup.Test.Project.AutomationPractisePages
{
    class ProductPage
    {
        internal void SelectProduct(IWebDriver driver)
        {

            driver.FindElement(By.XPath("//a[contains(text(),'Faded Short Sleeve T-shirts')]")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromHours(2));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("product_comments_block_extra")));

        }

        internal void ClickOnAddToCartButton(IWebDriver driver)
        {
            driver.FindElement(By.XPath(".//*[@id='add_to_cart']")).Click();
            Thread.Sleep(2000);
        }
    }
}
