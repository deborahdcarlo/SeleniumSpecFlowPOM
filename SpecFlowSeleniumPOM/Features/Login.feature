Feature: Login
	Test the login functionality of application
	It will verify if the username and password combinations are working as expected

@SmokeTest
Scenario Outline: Verify if the login functionality is working
	Given I have navigated to my applicaton
	And I typed the <username> and <password>
	When I click on login button
	Then I should see the EA page

Examples: 
| username | password |
| admin    | admin    |
| deborah  | deborah  |
