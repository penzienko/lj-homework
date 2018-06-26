Feature: Test scenarious for Hello page

@req-ui-01 @moderate
Scenario: Page Title
  Given I have navigated to the application
  When I open the Hello page
  Then The title should be "UI Testing Site"

@req-ui-02 @moderate
Scenario: Company Logo
  Given I have navigated to the application
  When I open the Hello page
  Then The company logo should be visible