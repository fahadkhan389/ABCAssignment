using System;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace ABCAssignment.Common
{
    public class Wrapper
    {


        public static void FilltextBox(IWebElement element, string value)
        {
            element.SendKeys(value);

        }
        public static void FillTextBoxandEnter(IWebElement element, string value)
        {
            element.SendKeys(value);
            element.SendKeys(Keys.Enter);

        }

        public static Boolean IsElementDisplayed(IWebElement element)

        {
            return (element.Displayed && element.Enabled);

        }

        public static void ClickElement(IWebElement element)
        {
            element.Click();
            Thread.Sleep(5000);

        }
        
        public static string GetAttributeText(IWebElement element)
        {
            return element.GetAttribute("value");
            
        }
        public static string GetText(IWebElement element)
        {
            return element.Text;
            
        }

        //public static IWebElement ClickWhenReady(By locator, System.TimeSpan timeout)
        //{

        //    IWebElement element = null;

        //    WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, timeout);

        //   return element = wait.Until(ExpectedConditions.ElementToBeClickable(locator));

        //}


        public static string GetTitle()
        {
            return PropertiesCollection.driver.Title;
        }
        public static Boolean VerifyLoading()
        {
            
            IJavaScriptExecutor js = PropertiesCollection.driver as IJavaScriptExecutor;
            string state = (string)js.ExecuteScript("return document.readyState");
            return string.Equals(state, "complete");
            

        }
        public static Boolean VerifyImageLoading(IWebElement image)
        {
            IJavaScriptExecutor js = PropertiesCollection.driver as IJavaScriptExecutor;

            Boolean ImagePresent = (Boolean)js.ExecuteScript("return arguments[0].complete && typeof arguments[0].naturalWidth != \"undefined\" && arguments[0].naturalWidth > 0", image);
            return ImagePresent;
        }
        public static void MouseHoverOver(IWebElement element1, IWebElement element2)
        {
            Actions action = new Actions(PropertiesCollection.driver);
            action.MoveToElement(element1).Click().Build().Perform();
            Thread.Sleep(2000);
            action.MoveToElement(element2).Click().Build().Perform();
           

        }
        public static string GetPageTitle()
        {
            return PropertiesCollection.driver.Title;

        }

        public static void NavigateBanner(IWebElement element)
        {
            for (int i = 0; i < 4; i++)
            {
                element.Click();
                Thread.Sleep(2000);
                    
                    }
            
        }
        public static void SwitchWindow(IWebDriver driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            }


    }
}

