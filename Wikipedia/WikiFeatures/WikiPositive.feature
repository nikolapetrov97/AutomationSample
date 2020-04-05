Feature: Google searching for wikipedia and log in

@positive
Scenario: Successful login
	Given I navigate to google
	And I search for "wikipedia login"
	And I click on the search buttonn
	And I select wikipedia site
	And I click on the login
	When I enter "automationendava" acc
	And I enter "automationendava!" passwordd
	And I click on the Login button
	Then I should see successful login
