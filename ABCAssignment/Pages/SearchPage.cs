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
    class SearchPage
    {
        public SearchPage()
        {

            PageFactory.InitElements(PropertiesCollection.driver, this);

        }

        [FindsBy(How = How.XPath, Using = "/html//div[@id='headerMainMenu']/div[@class='header-search']//input[@type='text']")]
        public IWebElement Searchboxtxt { get; set; }


        public void Search(string Searchtext)

        {
            Wrapper.FillTextBoxandEnter(Searchboxtxt, Searchtext);
        }



    }

}

    

