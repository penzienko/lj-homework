Feature: Test scenarious for Form page

@req-ui-01 @moderate
Scenario: Page Title
  Given I have navigated to the application
  When I click form menu
  Then The title should be "UI Testing Site"

@req-ui-02 @moderate
Scenario: Company Logo
  Given I have navigated to the application
  When I click form menu
  Then The company logo should be visible

@req-ui-05 @high
Scenario: Menu navigation
  Given I have navigated to the application
  When I click form menu
  Then I should get navigated to the form page

@req-ui-06 @low
Scenario:  Button active status
  Given I have navigated to the application
  When I click form menu
  Then It should turn to active status

@req-ui-11 @high
Scenario: Form's elements
  Given I have navigated to the application
  When I click form menu
  Then I see 1 of input element
  And I see 1 of submit element

@req-ui-12 @high
Scenario Outline: Greetings message
  Given I have navigated to the application
  And I click form menu
  When I type <value> the input field 
  And I submit the form
  Then I should get navigated to the hello page
  And I see following text <result>
  
  Examples:
  | value   | result         |
  | John    | Hello John!    |
  | Sophia  | Hello Sophia!  |
  | Charlie | Hello Charlie! |
  | Emily   | Hello Emily!   |