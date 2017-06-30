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

    [Then(@"i should be redirected to last program")]
        public void ThenIShouldBeRedirectedToLastProgram()
        {
            ScenarioContext.Current.Pending();
        }



    }

}
