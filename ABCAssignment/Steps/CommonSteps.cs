using System;
using System.Linq;
using ABCAssignment.Common;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using System.Net;
using System.Windows;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Configuration;

namespace ABCAssignment.Steps
{
    [Binding]
    public sealed class CommonSteps
    {
        string SearchPageURL = System.Configuration.ConfigurationManager.AppSettings["SearchPageURL"];

        string ABCNewsURL = System.Configuration.ConfigurationManager.AppSettings["ABCNewsURL"];
        string ABCRadioURL = System.Configuration.ConfigurationManager.AppSettings["ABCRadioURL"];

        [When(@"i have opened a Chrome browser")]
        [Given(@"i have opened a Chrome browser")]
        public void GivenIHaveOpenedChromeBrowser()
        {
            PropertiesCollection.driver = new ChromeDriver(@"C:\Users\fukha\Desktop\chromedriver_win32");
        }
        [Given(@"i have opened a FireFox browser")]
        public void GivenIHaveOpenedFFBrowser()
        {
            PropertiesCollection.driver = new FirefoxDriver();

        }
        [Given(@"i am on ABC website")]
        [Then(@"i am on ABC website")]
        [When(@"i am on ABC website")]
        public void GivenIAmOnABCbsite()
        {

            PropertiesCollection.driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(40));

            try
            {
                PropertiesCollection.driver.Navigate().GoToUrl(ABCNewsURL);
        //        PropertiesCollection.driver.Manage().Window.Maximize();

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        [Given(@"I am on search page")]
        public void GivenSearchResultPage()
        {

            PropertiesCollection.driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(40));

            try
            {
                PropertiesCollection.driver.Navigate().GoToUrl(SearchPageURL);
                PropertiesCollection.driver.Manage().Window.Maximize();

            }
            catch (Exception e)
            {
                throw e;
            }

        }
        [Given(@"i am on ABC Radio website")]
        public void GivenIAmOnABCRadioWebsite()
        {
            PropertiesCollection.driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(40));

            try
            {
                PropertiesCollection.driver.Navigate().GoToUrl(ABCRadioURL);
                PropertiesCollection.driver.Manage().Window.Maximize();

            }
            catch (Exception e)
            {
                throw e;
            }
        }



    }


}

