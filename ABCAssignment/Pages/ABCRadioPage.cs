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
    class ABCRadioPage
    {
        

        public ABCRadioPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.XPath, Using = ".//*[@id='rn-navigation']/ul/li[2]/a")]
        public IWebElement ProgramsecXpath { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='rn-programindex']/li[11]/a")]
        public IWebElement BidIdeasXpath { get; set; }

        [FindsBy(How = How.Id, Using = "right-arrow")]
        public IWebElement RightArrowBtn { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='content']/div[1]/div/div/div[2]/ul/li[21]/a/div/img")]
        public IWebElement LastBannerItemXpath { get; set; }

        

        public void MouseHover()

        {
            Wrapper.MouseHoverOver(ProgramsecXpath,BidIdeasXpath);
            
        }
        public void BannerNavigation()

        {
            Wrapper.NavigateBanner(RightArrowBtn);

        }
        public void SelectLastItemfromBanner()

        {
            Wrapper.ClickElement(LastBannerItemXpath);
           }
        

    }
    

 
}
