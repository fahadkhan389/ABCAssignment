using ABCAssignment.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunningsAssign.Pages
{
    public class ProductDetailPage
    {
        public ProductDetailPage()
        {

            PageFactory.InitElements(PropertiesCollection.driver, this);

        }

        [FindsBy(How = How.XPath, Using = ".//*[@id='header']/div[1]/a")]
        public IWebElement NewsBannerLinkXpath { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='n-justin']/a")]
        public IWebElement JustinLinkXpath { get; set; }

        [FindsBy(How = How.Id, Using = "jwplayer-video-0_display_button_play")]
        public IWebElement PlayVideoBtnId { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@src='http://www.abc.net.au/news/image/8255972-16x9-940x529.jpg']")]
        public IWebElement ImageXpath { get; set; }




    }

}
    
