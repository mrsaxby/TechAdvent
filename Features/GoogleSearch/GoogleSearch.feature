@GoogleSearch
Feature: GoogleSearch

@SomeTicketRef 
Scenario: Navigate to google and search for FaceBook
	Given I navigate to 'https://www.google.com/'
	And I reject the site cookies
	When I search for facebook
	And I click the first result
	Then The first result is 'https://en-gb.facebook.com'