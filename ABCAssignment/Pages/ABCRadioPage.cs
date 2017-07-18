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
using OpenQA.Selenium.Support.UI;

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

        [FindsBy(How = How.Id, Using = "search-simple-input-query")]
        public IWebElement SearchboxID { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='content']/div[1]/div/div[2]/ul/li[3]/div/div[1]/h3/a")]
        public IWebElement SearchContentXpath { get; set; }

        [FindsBy(How = How.Id, Using = "u_0_2")]
        public IWebElement FbSharebtnID { get; set; }

        [FindsBy(How = How.XPath, Using = "u_0_2")]
        public IWebElement popupwindowtitleXpath { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='content']/div[1]/div/div/div[1]/ul/li/a")]
        public IWebElement DownloadAudioXpath { get; set; }

        

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
        public void Search(string Searchtext)

        {
            Wrapper.FillTextBoxandEnter(SearchboxID, Searchtext);
        }
        public void SearchContentVerification(string Searchcontent)

            {

            string text=Wrapper.GetText(SearchContentXpath);
            Assert.IsTrue(text.IndexOf(Searchcontent, StringComparison.OrdinalIgnoreCase)>= 0);
        }

        public void ClickFBShare()

        {
            Wrapper.ClickElement(FbSharebtnID);
        }
        public void PopupVerification()

        {
            Wrapper.SwitchWindow(PropertiesCollection.driver);
            WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(5));
            wait.Until(driver => driver.Url.Contains("https://www.facebook.com"));

        }
        public void AudioMp3Verification()

        {
            Wrapper.SwitchWindow(PropertiesCollection.driver);
            WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(5));
            wait.Until(driver => driver.Url.Contains("http://mpegmedia.abc.net.au"));

        }

        public void ClickDownloadAudio()

        {
            Wrapper.ClickElement(DownloadAudioXpath);
        }
        
            public void VerifyAudioLoaded()

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
         
        }

    }



}
