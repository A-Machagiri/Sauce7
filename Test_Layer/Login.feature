Feature: Login Functionality
  As a user, I want to be able to log in to the application so that I can access my account.

  Scenario: Successful Login
    Given I am on the login page
    When I enter valid credentials
    And I click the login button
    Then I should be redirected to the dashboard

  Scenario: Unsuccessful Login
    Given I am on the login page
    When I enter invalid credentials
    And I click the login button
    Then I should see an error message