Feature: Test scenarious for Home page

@req-ui-01 @moderate
Scenario: Page Title
  Given I have navigated to the application
  When I click home menu
  Then The title should be "UI Testing Site"

@req-ui-02 @moderate
Scenario: Company Logo
  Given I have navigated to the application
  When I click home menu
  Then The company logo should be visible

@req-ui-03 @high
Scenario: Menu navigation
  Given I have navigated to the application
  When I click home menu
  Then I should get navigated to the home page


@req-ui-04 @low
Scenario:  Button active status
  Given I have navigated to the application
  When I click home menu
  Then It should turn to active status

@req-ui-09 @req-ui-10 @low
Scenario Outline: Text on the Home page
  Given I have navigated to the application
  When I click home menu
  Then I see <text> in <tagName> tag

  Examples: 
  | text																					| tagName |
  | Welcome to the Docler Holding QA Department												| h1      |
  | This site is dedicated to perform some exercises and demonstrate automated web testing. | p       |