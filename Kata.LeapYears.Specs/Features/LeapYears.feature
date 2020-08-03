Feature: Leap Years kata (https://codingdojo.org/kata/LeapYears/)


Scenario: All years divisible by 400 are leap years
	Given year 2000
	When year divisible by 400
	Then the result should be leap year

Scenario: All years divisible by 100 are leap years
	Given year 2000
	When year divisible by 100
	Then the result should be leap year

Scenario: All years divisible by 4 but not by 100 are leap years
	Given year 2004
	When year divisible by 4
	And year not divisible by 100
	Then the result should be leap year