Feature: FizzBuzz transformed integer to string

	Scenario: Number divisible by three should be Fizz
		Given a number 15
		When is divisible by three
		Then the result should be Fizz