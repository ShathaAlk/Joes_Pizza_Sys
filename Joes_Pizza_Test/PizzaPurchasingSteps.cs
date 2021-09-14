using Joes_Pizza_Test.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;


namespace Joes_Pizza_Test
{
    [Binding]
    public class PizzaPurchasingSteps
    {
        //Create objects 
        Pages_ElementsDefinition elm = new Pages_ElementsDefinition();
        IWebDriver webDriver = new FirefoxDriver();

        [Given(@"launch joe's pizza website")]
        public void GivenLaunchJoeSPizzaWebsite()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44379/");
            elm = new Pages_ElementsDefinition(webDriver);
        }
        
        [Given(@"select pizza")]
        public void GivenSelectPizza()
        {
            elm.ClickbtnAddToCart1();
            elm.ClickbtnAddToCart2();
            elm.ClickbtnAddToCart3();
            elm.ClickbtnAddToCart1();

            //if the customer clicks on the same product, an alert message will be shown.
            if (elm.IsAlertExistent())
            {
                webDriver.SwitchTo().Alert();
                webDriver.SwitchTo().Alert().Accept();
                webDriver.SwitchTo().DefaultContent();
            }
        }

        [Given(@"Click on Cart Icon")]
        public void GivenClickOnCartIcon()
        {
            //Click on the cart icon to display the Order Checkout page
            elm.ClickCart();
        }

        [Then(@"Order Checkout page should be displayed")]
        public void ThenOrderCheckoutPageShouldBeDisplayed()
        {
            
            //Using Assert to verify the existence of the Order Checkout page
            Assert.That(elm.IslnkCheckoutPageExist, Is.True);
        }

        [Then(@"change the quantity in Checkout page")]
        public void ThenChangeTheQuantityInCheckoutPage()
        {
            //The customer can increase or decrease the quantity or even delete the item from the cart.
            //elm.ClickbtnIncrease1();
            //elm.ClickbtnIncrease1();
            //elm.ClickbtnIncrease2();
            //elm.ClickbtnDecrease();
            //elm.ClickbtnDeleteItem();
        }

        [Then(@"Click on Checkout button")]
        public void ThenClickOnCheckoutButton()
        {
            //Click on the Checkout button to display the Order Confirmation page
            elm.ClickbtnCheckout();
        }

        [Then(@"Order Confirmation page should be displayed")]
        public void ThenOrderConfirmationPageShouldBeDisplayed()
        {
            
            //Using Assert to verify the existence of the Order Confirmation page
            Assert.That(elm.IslnkOrderPageExist, Is.True);
        }
    }

}
