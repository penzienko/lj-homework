Feature: Test scenarious for Error page
#According to the requirements we are checking all the pages for logo and title
#In this case it an example of failed tests

@req-ui-01 @moderate
Scenario: Page Title
  Given I have navigated to the application
  When I click error menu
  Then The title should be "UI Testing Site"

@req-ui-02 @moderate
Scenario: Company Logo
  Given I have navigated to the application
  When I click error menu
  Then The company logo should be visible

@req-ui-03 @high
Scenario: Menu navigation
  Given I have navigated to the application
  When I click error menu
  Then I should get navigated to the error page

@req-ui-07 @high
Scenario: 404 HTTP response code for error page
  Given I have navigated to the application
  When I click error menu
  Then I should get "404" HTTP response code