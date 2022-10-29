Feature: Login

@regression
Scenario Outline: Active user can log in successfully
	Given I navigate to the website home page
	When I login with a valid users credentials <userName> <password>
	Then the user should be logged in successfully

	Examples:
		| userName                | password     |
		| standard_user           | secret_sauce |
		| problem_user            | secret_sauce |
		| performance_glitch_user | secret_sauce |

@regression
Scenario: Locked Out user cannot log in successfully
	Given I navigate to the website home page
	When I login with users credentials
		| UserName        | Password     |
		| locked_out_user | secret_sauce |
	Then the user should not be logged in
