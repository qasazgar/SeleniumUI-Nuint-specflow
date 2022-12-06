Feature: CreateSymbolClient 
	Simple calculator for adding two numbers

@GotoClient@LogoutClient
Scenario Outline: Added  Default Stock Symbol 

	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And  serach Stock Symbol  <Symbol>  
	When Click Icon Add Panel Stock Symbol 
	Then the result should be Created 7 Default Stock Symbol
Examples:
     
	 | Symbol |
	 | فملی   |



