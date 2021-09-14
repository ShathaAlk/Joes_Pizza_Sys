using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joes_Pizza_Test.pages
{
    public class Pages_ElementsDefinition
    {
        public IWebDriver WebDriver { get; }
        public Pages_ElementsDefinition(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public Pages_ElementsDefinition() { }
       
        //UI elements
        //Home Page Elements
        public IWebElement btnAddToCart1 => WebDriver.FindElement(By.XPath("//a[@href='/Home/AddToCart/3']"));
        public IWebElement btnAddToCart2 => WebDriver.FindElement(By.XPath("//a[@href='/Home/AddToCart/4']"));
        public IWebElement btnAddToCart3 => WebDriver.FindElement(By.XPath("//a[@href='/Home/AddToCart/5']"));
        public IWebElement lnkCart => WebDriver.FindElement(By.XPath("//a[@href='/Home/OrderCheckout']"));

        //Order Checkout Page Elements
        //NOTE:These IWebElement numbers are constantly changing automatically.
        public IWebElement btnIncrease1 => WebDriver.FindElement(By.XPath("//a[@href='/Home/IncreaseQuantity/230']"));
        public IWebElement btnIncrease2 => WebDriver.FindElement(By.XPath("//a[@href='/Home/IncreaseQuantity/231']"));
        public IWebElement btnDecrease1 => WebDriver.FindElement(By.XPath("//a[@href='/Home/DecreaseQuantity/230']"));
        public IWebElement btnDeleteItem => WebDriver.FindElement(By.XPath("//a[@href='/Home/DeleteItem/232']"));
        public IWebElement btnCheckout => WebDriver.FindElement(By.XPath("//a[@href='/Home/Checkout']"));
        public IWebElement lnkCheckoutPage => WebDriver.FindElement(By.CssSelector(".Customeritems"));

        //Order Confirmation Page Elements
        public IWebElement lnkOrderPage => WebDriver.FindElement(By.CssSelector(".rowClass"));


        //Home Page Methods
        public void ClickbtnAddToCart1() => btnAddToCart1.Click();
        public void ClickbtnAddToCart2() => btnAddToCart2.Click();
        public void ClickbtnAddToCart3() => btnAddToCart3.Click();

        //Check if the alert exists
        public Boolean IsAlertExistent()
        {
            try
            {
                WebDriver.SwitchTo().Alert();
                return true;
            } 
            catch (Exception e)
            {
                return false;
            } 
        }
        public void ClickCart() => lnkCart.Click();

        //Order Checkout Page Methods
        public void ClickbtnIncrease1() => btnIncrease1.Click();
        public void ClickbtnIncrease2() => btnIncrease2.Click();
        public void ClickbtnDecrease() => btnDecrease1.Click();
        public void ClickbtnDeleteItem() => btnDeleteItem.Click();
        public void ClickbtnCheckout() => btnCheckout.Click();
        public bool IslnkCheckoutPageExist() => lnkCheckoutPage.Displayed;

        //Order Confirmation Page Methods
        public bool IslnkOrderPageExist() => lnkOrderPage.Displayed;
    }
}
