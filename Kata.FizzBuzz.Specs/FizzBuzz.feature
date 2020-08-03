Feature: FizzBuzz transformed integer to string

	Scenario: Number divisible by three should be Fizz
		Given a number 9
		When is divisible by three
		Then the result should be Fizz

	Scenario: Number divisible by five should be Buzz
		Given a number 20
		When is divisible by five
		Then the result should be Buzz

	Scenario: Number divisible by and three and five should be Buzz
		Given a number 15
		When is divisible by three and five
		Then the result should be FizzBuzz