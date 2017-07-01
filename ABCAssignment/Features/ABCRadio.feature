Feature: ABCRadio
    As online ABC Radio user
	I should be able to navigate to different sections
@ABCRadio
Scenario: Verify can navigate to program from the program sub-menu
	Given i have opened a Chrome browser
	And i am on ABC Radio website
	When i go to program section and select Big Ideas
	Then i shold be redirected to Big ideas page with title "Big Ideas"

Scenario: Navigate to last item in the program guide and select the last program.
	Given i have opened a Chrome browser
	And i am on ABC Radio website
	When i navigate to last item in the banner
	Then i should be able to select the last program

Scenario: Verify can search for content in search bar and that content is returned.
	Given i have opened a Chrome browser
	And i am on ABC Radio website
	When i enter text "fair trade" in searchbox and press enter
	Then i should be able to see search contents "fair trade"
	
	Scenario: Verify you can click on social media share icon and correct pop-up appears.
	Given i have opened a FireFox browser
	And i am on Fortunate universe program
	When i click on facebook share icon
	Then facebook popup should be opened

	Scenario: Verify you can click Download video and you are directed to mp3 file.
	Given i have opened a FireFox browser
	And i am on Fortunate universe program
	When i click on Download Audio
	Then Should be directed to audio file

	Scenario: Verify that audio player loads successfully.
	Given i have opened a FireFox browser
	When i am on Fortunate universe audio file
	Then Audio file should be loaded successfully
