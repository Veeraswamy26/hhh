Feature: Feature1

A short summary of the feature
@launch
Scenario: app launch
	Given display splash screen
	When click on get next
	Then display login page
@social@login
Scenario: social login
	Given click on fa cebook or google
	When if userexists  login or signup when new mail or number is detected
	Then if login then l og out
@login
Scenario: app login/signup
	Given api end point and authorization
	When display respective scereen
	Then logout from the page
	@login
Scenario: app login/signupkjjv
	Given api end point and authorization
	When display respective scereen
	Then logout from the page
@booking
Scenario: booking flow
	Given home page is displayed
	When click on set pick up and drop off

	

