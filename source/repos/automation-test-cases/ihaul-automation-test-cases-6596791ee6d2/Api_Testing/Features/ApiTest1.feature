
Feature: API Testing

  Scenario: Successful GET request with JWT token
    Given the API endpoint is set up
    When the user sends a GET request to "/api/v1/admin/getAllUsers" with JWT token
    Then the response should be successful with status code 200