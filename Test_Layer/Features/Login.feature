Feature: Login Functionality

Scenario: Successful Login
    Given the user navigates to the login page
    When the user enters valid credentials
    Then the user should be successfully logged in and see the products page