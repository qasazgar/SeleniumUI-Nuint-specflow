Feature: DraftStockSymbol
	By Custmer
	I Want  Draft purchase of shares from the stock exchange symbol
	so 

@GotoClient@LogoutClient@Drft@Buy@Day
Scenario: 01) Save Buy the draft information of the stock symbol in the time frame of the day
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   serach Stock Symbol  فملی
	And   Order the stock symbol IRO1MSMI0001 enter the minimum price plus 0 and the minimum number plus 0
	When  Save stock symbol draft information
	Then  The result Should be Drft Stock Symbol

@GotoClient@LogoutClient@Drft@Buy @InTheMoment
Scenario: 02)Save Buy the draft information of the stock symbol in the time frame at the moment 
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   serach Stock Symbol  فملی
	And   Select advanced panel type and select Time range type in the moment
	And   Order the stock symbol IRO1MSMI0001 enter the minimum price plus 0 and the minimum number plus 0
	When  Save stock symbol draft information
	Then  The result Should be Drft Stock Symbol

@GotoClient@LogoutClient@Drft@Buy @ValidUntilCancelled
Scenario: 03)Save Buy the draft information of the stock symbol in the time frame Valid Until Cancelled 
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   serach Stock Symbol  فملی
	And   Select Advanced panel type and select Time range type Valid until cancelled
	And   Order the stock symbol IRO1MSMI0001 enter the minimum price plus 0 and the minimum number plus 0
	When  Save stock symbol draft information
	Then  The result Should be Drft Stock Symbol

@GotoClient@LogoutClient@Drft @Buy @ValidUntilDate
Scenario: 04)Save Buy the draft information of the stock symbol in the time frame Valid Until Date  
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   serach Stock Symbol  فملی
	And   Select Advanced panel type and select Time range type Valid until date
	And   Order the stock symbol IRO1MSMI0001 enter the minimum price plus 0 and the minimum number plus 0
	When  Draft Stock Symbol Valid Until Date
	Then  The result Should be Drft Stock Symbol

	#-----------------------------------------------------------------------------------
	#Sell
@GotoClient@LogoutClient@Drft@Sell@inTheDay
Scenario: 05)Save Sell the draft information of the stock symbol in the time frame of the day
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   serach Stock Symbol  فملی
	And   Go to tab Sell
	And   Order the stock symbol IRO1MSMI0001 enter the minimum price plus 0 and the minimum number plus 0
	When  Save stock symbol draft information
	Then  The result Should be Drft Stock Symbol

@GotoClient@Drft@Sell @InTheMoment
Scenario: 06)Save Sell the draft information of the stock symbol in the time frame at the moment 
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   serach Stock Symbol  فملی
	And   Go to tab Sell
	And   Select advanced panel type and select Time range type in the moment
	And   Order the stock symbol IRO1MSMI0001 enter the minimum price plus 0 and the minimum number plus 0
	When  Save stock symbol draft information
	Then  The result Should be Drft Stock Symbol

@GotoClient@LogoutClient@Drft@Sell @ValidUntilCancelled
	Scenario: 07)Save Sell the draft information of the stock symbol in the time frame Valid Until Cancelled  
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   serach Stock Symbol  فملی
	And   Go to tab Sell
    And   Select Advanced panel type and select Time range type Valid until cancelled
	And   Order the stock symbol IRO1MSMI0001 enter the minimum price plus 0 and the minimum number plus 0
	When  Save stock symbol draft information
	Then  The result Should be Drft Stock Symbol


@GotoClient@Drft@Sell @ValidUntilDate
Scenario: 08)Save Sell the draft information of the stock symbol in the time frame Valid Until Date   
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   serach Stock Symbol  فملی
	And   Go to tab Sell
	And   Select Advanced panel type and select Time range type Valid until date
	And   Order the stock symbol IRO1MSMI0001 enter the minimum price plus 0 and the minimum number plus 0
	When  Save stock symbol draft information
	Then  The result Should be Drft Stock Symbol