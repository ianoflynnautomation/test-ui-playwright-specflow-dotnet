Feature: Login
	In order to access the website
	As a user
	I want to be able to login to the website

Background: 
	Given I navigate to the website home page

@AcceptanceTest
Scenario Outline: Active user can log in successfully
	When I login with a valid users credentials <userName> <password>
	Then the user should be logged in successfully

	Examples:
		| userName                | password     |
		| standard_user           | secret_sauce |
		| problem_user            | secret_sauce |
		| performance_glitch_user | secret_sauce |

@AcceptanceTest
Scenario: Locked Out user cannot log in successfully
	When I login with users credentials
		| UserName        | Password     |
		| locked_out_user | secret_sauce |
	Then the user should not be logged in
