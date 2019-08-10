using BunningsAssign.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BunningsAssign.Steps
{
    [Binding]
    public sealed class AddingWishListProductSteps
    {

        [Given(@"i enter text ""(.*)"" to search and enter")]
        public void GivenIEnterTextToSearch(string searchtxt)
        {
            SearchPage mypage = new SearchPage();
            mypage.Search(searchtxt);
             }


        [Given(@"I Click on Search Button from search Result page")]
        public void GivenIClickOnSearchButtonFromSearchResultPage()
        {
          }

        [Given(@"I select any random paint from search Result page")]
        public void GivenISelectAnyRandomPaintFromSearchResultPage()
        {

        }

        [Given(@"I click Add to Cart button from product detail page")]
        public void GivenIClickAddToCartButtonFromProductDetailPage()
        {

        }

        [When(@"i go to wishlistpage")]
        public void WhenIGoToWishlistpage()
        {

        }

        [Then(@"paint should be added in wish list page")]
        public void ThenPaintShouldBeAddedInWishListPage()
        {
         }

    }
}
