using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace GatewayrGroup.Test.Project.AutomationPractisePages
{
    class GooglePages
    {
        internal IWebElement EnterName(IWebDriver driver) => driver.FindElement(By.XPath(".//input[@type='text']"));

        internal void Clickon3rdLink(IWebDriver driver)
        {
            

            IWebElement link = driver.FindElement(By.XPath("(.//*[@id='search']//a)[3]"));
            Actions newTab = new Actions(driver);
            newTab.KeyDown(Keys.Control).Click(link).Build().Perform();
            Thread.Sleep(5000);


            /// We can use another method to click on third link with 
            /// -> Grabing all the links with a tag , count the links 
            ///->  using for loop we can keep condtion >4 and with thus can click it.
            ///-> Here i have tried to create a dynamic xpath which will always click on 3link whatever it might be.
        }

        internal void  NavigatetoNewTab(IWebDriver driver)
        {
           var totalwindow =  driver.WindowHandles.Count;

            driver.SwitchTo().Window(driver.WindowHandles[1]);
         string url =    driver.Url;
            Console.WriteLine(url);

        }
    }
}
