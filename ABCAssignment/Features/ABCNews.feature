Feature: ABCNews
	As online ABC News user
	I should be able to navigate to different sections 
		
@ABCNews
Scenario: Verify page is loading correctly
	When i have opened a Chrome browser
	Then i am on ABC website and it loaded successfully

Scenario: Verify NewsBanner loading correctly
	Given i have opened a Chrome browser
	When i am on ABC website
	Then NewsBanner should be loaded successfully
	
Scenario: Verify Just-in link is clickable via the link on primary navigation
	Given i have opened a Chrome browser
	And i am on ABC website
	When i click on just in link
	Then I should be redirected to Justin page 

Scenario: Verify Artile title,time stamp and text
	Given i have opened a Chrome browser
	And i am on ABC website
	When i click on just in link
	Then Article title,time stamp and text should be loaded successfully

Scenario: Verify Video loads and appears successfully
	Given i have opened a Chrome browser
	When i am on video page
	Then Video should be loaded and appeared successfully

	Scenario: Verify image loads and appears successfully
	Given i have opened a Chrome browser
	When i am on image page
	Then image should be loaded and appeared successfully
