Feature: Google searching for wikipedia


@negative
Scenario: Unsuccessful login
	Given I navigate to googlee
	And I search "wikipedia loginn"
	And I click on the search button
	And I select wiki site
	And I click on the login buttonn
	When I enter name "automationendava"
	And I enter password "automationendava!!"
	And I click on the Login
	Then I should see unsuccessful login
