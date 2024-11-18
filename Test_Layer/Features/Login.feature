# Test_Layer/Features/Login.feature
Feature: Login

Scenario: Successful Login
    Given I navigate to "https://www.saucedemo.com/"
    When I enter valid credentials
    And I click the login button
    Then I should be redirected to the product page

Scenario: Failed Login
    Given I navigate to "https://www.saucedemo.com/"
    When I enter invalid credentials
    And I click the login button
    Then I should see an error message