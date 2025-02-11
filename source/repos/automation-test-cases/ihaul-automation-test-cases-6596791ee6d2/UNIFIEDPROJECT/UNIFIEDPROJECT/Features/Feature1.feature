 Feature: User Authentication

  Scenario: User chooses to continue as guest
    Given the application is launched
    When the user provides input "not interested"
    Then the user should be able to continue as guest

  Scenario: User chooses to sign up
    Given the application is launched
    When the user provides input "new number"
    Then the user should be directed to the signup page
    And the user completes the signup process

  Scenario: User chooses to log in
    Given the application is launched
    When the user provides input "existing number"
    Then the user should be directed to the login page
    And the user completes the login process