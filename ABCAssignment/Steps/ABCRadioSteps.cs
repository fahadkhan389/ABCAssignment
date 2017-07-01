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
    public class ABCRadioSteps
    {
        [When(@"i go to program section and select Big Ideas")]
        public void GivenIGoToProgramSection()
        {
            try
            {
                ABCRadioPage mypage = new ABCRadioPage();
                mypage.MouseHover();
            }
            catch (Exception e)
            {
                throw e;
            }

                }


        [Then(@"i shold be redirected to Big ideas page with title ""(.*)""")]
        public void ThenISholdBeRedirectedToBigIdeasPageWithTitle(string title)
        {
            try
            {
                ABCRadioBigIdeaaPage mypage = new ABCRadioBigIdeaaPage();
                mypage.ConfirmTitle(title);
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
        [When(@"i navigate to last item in the banner")]
        public void GivenINavigateToLastItemInTheBanner()
        {
            try
            {
                ABCRadioPage mypage = new ABCRadioPage();
                mypage.BannerNavigation();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    
    [Then(@"i should be able to select the last program")]
        public void WhenISelectTheLastProgram()
        {

        try
        {
            ABCRadioPage mypage = new ABCRadioPage();
            mypage.SelectLastItemfromBanner();
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

        [When(@"i enter text ""(.*)"" in searchbox and press enter")]
        public void WhenIEnterTextInSearchboxAndPressEnter(string Searchtext)
        {
            try
            {
                ABCRadioPage mypage = new ABCRadioPage();
                mypage.Search(Searchtext);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [Then(@"i should be able to see search contents ""(.*)""")]
        public void ThenIShouldBeAbleToSeeSearchContents(string Searchcontent)
        {
            try
            {
                ABCRadioPage mypage = new ABCRadioPage();
                mypage.SearchContentVerification(Searchcontent);
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
        [Given(@"i am on Fortunate universe program")]
        public void GivenIAmOnFortunateUniverseProgram()
        {
            PropertiesCollection.driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(40));

            try
            {
                PropertiesCollection.driver.Navigate().GoToUrl("http://www.abc.net.au/radionational/programs/bigideas/a-fortunate-universe/8076406");
                PropertiesCollection.driver.Manage().Window.Maximize();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [When(@"i click on facebook share icon")]
        public void WhenIClickOnFacebookShareIcon()
        {
            try
            {
                ABCRadioPage mypage = new ABCRadioPage();
                mypage.ClickFBShare();
            }
            catch (Exception e)
            {
                throw e;
            }
        
        }

        [Then(@"facebook popup should be opened")]
        public void ThenFacebookPopupShouldBeOpened()
        {
            try
            {
                ABCRadioPage mypage = new ABCRadioPage();
                mypage.PopupVerification();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [When(@"i click on Download Audio")]
        public void WhenIClickOnDownloadAudio()
        {
            try
            {
                ABCRadioPage mypage = new ABCRadioPage();
                mypage.ClickDownloadAudio();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [Then(@"Should be directed to audio file")]
        public void ThenShouldBeDirectedToMpFile()
        {
            try
            {
                ABCRadioPage mypage = new ABCRadioPage();
                mypage.AudioMp3Verification();
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
        [When(@"i am on Fortunate universe audio file")]
        public void WhenIAmOnFortunateUniverseAudioFile()
        {

            try
            {
                PropertiesCollection.driver.Navigate().GoToUrl("https://radio.abc.net.au/programitem/pg1aGbWlx6?play=true");
                PropertiesCollection.driver.Manage().Window.Maximize();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [Then(@"Audio file should be loaded successfully")]
        public void ThenAudioFileShouldBeLoadedSuccessfully()
        {
            try
            {
                ABCRadioPage mypage = new ABCRadioPage();
                mypage.VerifyAudioLoaded();
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
