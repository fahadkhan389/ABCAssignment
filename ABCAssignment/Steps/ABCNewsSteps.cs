using System;
using ABCAssignment.Pages;
using ABCAssignment.Common;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace ABCAssignment.Steps
{
    [Binding]
    public class ABCNewsSteps
    {
        string ABCNewsURL = System.Configuration.ConfigurationManager.AppSettings["ABCNewsURL"];

        [Then(@"i am on ABC website and it loaded successfully")]
        public void GivenIAmOnABCbsite()
        {

            PropertiesCollection.driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(40));

            try
            {
                PropertiesCollection.driver.Navigate().GoToUrl(ABCNewsURL);
                PropertiesCollection.driver.Manage().Window.Maximize();
                Console.WriteLine("Page has loaded successfully within 40 seconds");
            }
            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                PropertiesCollection.driver.Close();
                PropertiesCollection.driver.Quit();
            }
        }

        [Then(@"NewsBanner should be loaded successfully")]
        public void ThenNewsBannerShouldBeLoadedSuccessfully()
        {
            try
            {
                ABCNewspage mypage = new ABCNewspage();
                mypage.VerifyNewsBannerLoaded();
            }
            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                PropertiesCollection.driver.Close();
                PropertiesCollection.driver.Quit();
            }


        }

        [When(@"i click on just in link")]
        public void WhenIClickOnJustInLink()
        {
            try
            {
                ABCNewspage mypage = new ABCNewspage();
                mypage.ClickJustInLink();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        [Then(@"I should be redirected to Justin page")]
        public void ThenIShouldBeRedirectedToJustinPage()
        {
            try
            {
                JustinPage mypage = new JustinPage();
                mypage.VerifyTitle();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                PropertiesCollection.driver.Close();
                PropertiesCollection.driver.Quit();
            }

        }
        [Then(@"Article title,time stamp and text should be loaded successfully")]
        public void ThenArticleTitleTimeStampAndTextShouldBeLoadedSuccessfully()
        {
            try
            {
                JustinPage mypage = new JustinPage();
                mypage.VerifyArticle();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                PropertiesCollection.driver.Close();
                PropertiesCollection.driver.Quit();
            }

        }

        [When(@"i am on video page")]
        public void WhenIAmOnVideoPage()
        {
            try
            {
                PropertiesCollection.driver.Navigate().GoToUrl("http://www.abc.net.au/news/2017-02-09/weatherill-promises-to-intervene-dramatically/8254908");
                PropertiesCollection.driver.Manage().Window.Maximize();
            }

            catch (Exception e)
            {
                throw e;
            }

        }
        /// <summary>
        /// comment test
        /// </summary>
        [When(@"i am on image page")]
        public void WhenIAmOnImagePage()
        {
            try
            {
                PropertiesCollection.driver.Navigate().GoToUrl("http://www.abc.net.au/news/2017-02-10/abc-open-pic-of-the-week/8256256");
                PropertiesCollection.driver.Manage().Window.Maximize();
            }

            catch (Exception e)
            {
                throw e;
            }

        }


        [Then(@"Video should be loaded and appeared successfully")]
        public void ThenVideoShouldBeLoadedAndAppearedSuccessfully()
        {
            try
            {
                ABCNewspage mypage = new ABCNewspage();
                mypage.VerifyVideoLoaded();
            }
            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                PropertiesCollection.driver.Close();
                PropertiesCollection.driver.Quit();
            }

        }

        [Then(@"image should be loaded and appeared successfully")]
        public void ThenImageShouldBeLoadedAndAppearedSuccessfully()
        {
            try
            {
                ABCNewspage mypage = new ABCNewspage();
                mypage.VerifyImageLoaded();
            }
            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                PropertiesCollection.driver.Close();
                PropertiesCollection.driver.Quit();
            }
        }
       

    }

}
