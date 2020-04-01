Feature: DemoAzureApp

@Regression
Scenario: Validate Important Link on the application
	Given the user has launched the application
	And the user is able to see the Learn More button
	When the user clicks onto Learn More
	Then the asp page opens up

@Smoke
Scenario: Validate whether the application has been 
	Given the user has launched the application
	And the user is able to see the Learn More button in the application

