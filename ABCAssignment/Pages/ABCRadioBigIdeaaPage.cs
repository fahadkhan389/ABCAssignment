using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ABCAssignment.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ABCAssignment.Pages
{
    class ABCRadioBigIdeaaPage
    {
        

        public ABCRadioBigIdeaaPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.XPath, Using = ".//*[@id='rn-navigation']/ul/li[2]/a")]
        public IWebElement ProgramsecXpath { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='rn-programindex']/li[11]/a")]
        public IWebElement BidIdeasXpath { get; set; }

        

        public void ConfirmTitle(string title)

        {
            string Actualtitle=Wrapper.GetPageTitle();
            Assert.IsTrue(Actualtitle.Contains(title));
        }
    }
    

 
}
