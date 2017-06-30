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
	