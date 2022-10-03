Feature: e2eCookieHappyPathFeature1
	Customer can play the cookie game

@mytag
Scenario Outline: Customer can sell cookies
	Given i navigate to CookieClicker website
	And input "<NAMES>"
	And click start
	And click cookies button
	When i click sell cookies button
	Then cookies button is functional 




	Scenarios: 
	         | NAMES        |
	         | Jason Bourne |
