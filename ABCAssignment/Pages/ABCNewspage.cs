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
    class ABCNewspage
    {
        public ABCNewspage()
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

        public void VerifyNewsBannerLoaded()
        {
            Assert.IsTrue(Wrapper.IsElementDisplayed(NewsBannerLinkXpath));

        }

        public void ClickJustInLink()
        {
            Wrapper.ClickElement(JustinLinkXpath);

        }
        public void VerifyVideoLoaded()
        {
            Boolean status = Wrapper.VerifyLoading();
            if (status)
            {
                Console.WriteLine("Page loaded successfully");
            }
            else
            {
                Assert.Fail();
            }
            Wrapper.ClickElement(PlayVideoBtnId);

        }
        public void VerifyImageLoaded()
        {
            Boolean status = Wrapper.VerifyImageLoading(ImageXpath);
            if (status)
            {
                Console.WriteLine("image loaded successfully");
            }
            else
            {
                Assert.Fail();
            }
        }
            }
}  