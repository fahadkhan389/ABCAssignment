using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABCAssignment.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ABCAssignment.Pages
{
    class JustinPage
    {
        public JustinPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.XPath, Using = ".//*[@id='main_content']/div/div/div[1]/div/ul/li[1]/h3/a")]
        public IWebElement ArticleTitleXpath { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='main_content']/div/div/div[1]/div/ul/li[1]/p[1]")]
        public IWebElement ArticleTimeStampXpath { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='main_content']/div/div/div[1]/div/ul/li[1]/p[2]")]
        public IWebElement ArticleTextXpath { get; set; }
        
        public void VerifyTitle()
        {
            Assert.IsTrue(string.Equals(Wrapper.GetTitle(), "Just In - ABC News (Australian Broadcasting Corporation)"));
            
        }

        public void VerifyArticle()
        {
            Assert.IsTrue(Wrapper.IsElementDisplayed(ArticleTitleXpath));
            Assert.IsTrue(Wrapper.IsElementDisplayed(ArticleTimeStampXpath));
            Assert.IsTrue(Wrapper.IsElementDisplayed(ArticleTextXpath));

        }


    }
}
