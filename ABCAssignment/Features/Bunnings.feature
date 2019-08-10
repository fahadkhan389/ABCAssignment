Feature: AddingProduct
		As Bunning Customer Searchfor Paint
		Select any random Paint
		I want to add randomly selected paint as Wish List and verify it 
		
@Bunnings
Scenario: Select paint randomly and add it as wish list and verify it
        Given i have opened a Chrome browser
	    Given I am on search page
		And i enter text "Paint" to search and enter
		And I select any random paint from search Result page
		And I click Add to Cart button from product detail page
		When i go to wishlistpage
		Then paint should be added in wish list page
