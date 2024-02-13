Feature: Multiplication
  Feature: Multiplication
    In order to calculate products
    As a user
    I want to multiply two numbers



@tag1

    Scenario: Multiply two positive numbers
        Given I have entered 5 into the calculator
        And I have entered 10 into the calculator
        When I press multiply
        Then the result should be 50 on the screen

