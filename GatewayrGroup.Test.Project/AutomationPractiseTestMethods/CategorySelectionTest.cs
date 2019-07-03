using GatewayrGroup.Test.Project.AutomationPractisePages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GatewayrGroup.Test.Project.AutomationPractiseTestMethods
{

    [TestFixture]
    class CategorySelectionTest : AutomationPractiseBaseClass
    {
        AutomationPractiseHomePage _AutomationPractiseHomePage = new AutomationPractiseHomePage();
        SignInDetailsPage _signInDetailsPage = new SignInDetailsPage();
        ProductPage _productpage = new ProductPage();


        /// <summary>
        /// This test case is about where user enter Login details and selects product from the Women category and click on add tyo cart
        /// where we verify the quanatiy,color and total price for the product.
        /// </summary>
        /// 
        [Author("Dhrumil Pathak")]
        [Description("245435")]
        [Category("SmokeTest")]
        [Test]
        public void SelectWomenProductCategoryTest()
        {
            #region 

            OpenAutomationPractiseUrl(driver);  // This will open the url 
            _AutomationPractiseHomePage.ClickonSignInLink(driver); // This will open the home page and will will wait till its loaded properly.

            _signInDetailsPage.EnterUserName(driver); // It will enter user name 
            _signInDetailsPage.EnterPassword(driver); // it will enter password 

            _signInDetailsPage.ClickOnSignInButton(driver); // Click on the sign in button
            Thread.Sleep(1000);

            _AutomationPractiseHomePage.ClickonTshirtfromWomenCategory(driver);// click on the product
            _productpage.SelectProduct(driver);
            _productpage.ClickOnAddToCartButton(driver);  //Click on the Add to card button 

            string orderplacesuccessfullymessage = driver.FindElement(By.XPath(".//*[@id='layer_cart']//h2")).Text;  // it will grab the inner text and grab the succesfull text.      
            StringAssert.AreEqualIgnoringCase(orderplacesuccessfullymessage, "Product successfully added to your shopping cart");



            string orderplacedproductname = driver.FindElement(By.Id("layer_cart_product_title")).Text;
            string orderplaceactualresult = "Faded Short Sleeve T-shirts";
            Assert.AreEqual(orderplacedproductname.Trim(), orderplaceactualresult.Trim(), "Order place product text is improper");


            string orderplacedproductcolor = driver.FindElement(By.Id("layer_cart_product_attributes")).Text;
            Assert.That(orderplacedproductcolor, Is.EqualTo("Orange, S"), "the order placed color is not proper"); // Check the successful message is proper or not.

            string orderplacedquantity = driver.FindElement(By.Id("layer_cart_product_quantity")).Text;
            Assert.That(orderplacedquantity, Is.EqualTo("1"), "The quantity is not same ");

            string orperplacebaseprice = driver.FindElement(By.Id("layer_cart_product_price")).Text;
            Assert.That(orperplacebaseprice, Is.EqualTo("$16.51"), "The price is not matching with the expected result ");

            string orderplacedtotalprice = driver.FindElement(By.XPath("//*[@class='ajax_block_cart_total']")).Text;
            Assert.That(orderplacedtotalprice, Is.EqualTo("$18.51"), "The total price is not corect");  // Successfull verify the base Price for the product

            #endregion

        }
       
       

    }
}