Feature: LauncherStockSymbol
	By Custmer
	I Want  Launcher for selling shares of the stock exchange symbol
	so 

@GotoClient@LogoutClient@Drft@Buy
Scenario Outline:  Launcher Buy stock symbol with  amount and  number 
		Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	And   Select Advanced panel type
	And   Select Time range type Cleint <timerange>
	And   order the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client
	When  Save stock symbol Launcher order Customer information
	Then  the result should Launcher Buy shares of the Stock symbol by the Customer

Examples: 
	    | price | number | plusprice | plusnumber | timerange    |
	    | min   | min    | 0          | 0           | روز          |
	    | min   | max    | 0          | 0           | انجام و حذف  |
	    | max   | max    | 0          | 0           | معتبر تا لغو |
        | max   | min    | 0          | 0           |معتبر تا تاریخ|

#----------------------------
#Sell Draft

@GotoClient@LogoutClient@Drft@Sell
Scenario Outline:  Launcher Sell stock symbol with  amount and  number 
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	And   Go to tab Sell
	And   Select Advanced panel type
	And   Select Time range type Cleint <timerange>
	And   order Sell the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client 
	When  Save stock symbol Launcher order Customer information
	Then  the result should Launcher Buy shares of the Stock symbol by the Customer

Examples: 
	    | price | number | plusprice | plusnumber | timerange    |
	    | min   | min    | 0          | 0           | روز          |
	    | min   | max    | 0          | 0           | انجام و حذف  |
	    | max   | max    | 0          | 0           | معتبر تا لغو |
        | max   | min    | 0          | 0           |معتبر تا تاریخ|








#@GotoClient@LogoutClient@Launcher@Buy@Day
#Scenario: 01) Save Buy the Launcher information of the stock symbol in the time frame of the day
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And   serach Stock Symbol  فملی
#	And   Order the stock symbol IRO1MSMI0001 enter the minimum price plus 0 and the minimum number plus 0
#	When  Save stock symbol Launcher information
#	Then  The result Should be Launcher Stock Symbol
#
#
#
#
#@GotoClient@LogoutClient@Launcher@Buy @InTheMoment
#Scenario: 02)Save Buy the Launcher information of the stock symbol in the time frame at the moment 
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And   serach Stock Symbol  فملی
#	And   Select advanced panel type and select Time range type in the moment
#	And   Order the stock symbol IRO1MSMI0001 enter the minimum price plus 0 and the minimum number plus 0
#	When  Save stock symbol Launcher information
#	Then  The result Should be Launcher Stock Symbol
#
#@GotoClient@LogoutClient@Launcher@Buy @ValidUntilCancelled
#Scenario: 03)Save Buy the Launcher information of the stock symbol in the time frame Valid Until Cancelled 
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And   serach Stock Symbol  فملی
#	And   Select Advanced panel type and select Time range type Valid until cancelled
#	And   Order the stock symbol IRO1MSMI0001 enter the minimum price plus 0 and the minimum number plus 0
#	When  Save stock symbol Launcher information
#	Then  The result Should be Launcher Stock Symbol
#
#@GotoClient@LogoutClient@Launcher @Buy @ValidUntilDate
#Scenario: 04)Save Buy the Launcher information of the stock symbol in the time frame Valid Until Date  
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And   serach Stock Symbol  فملی
#	And   Select Advanced panel type and select Time range type Valid until date
#	And   Order the stock symbol IRO1MSMI0001 enter the minimum price plus 0 and the minimum number plus 0
#	When  Save stock symbol Launcher information
#	Then  The result Should be Launcher Stock Symbol
#
#	#-----------------------------------------------------------------------------------
#	#Sell
#@GotoClient@LogoutClient@Launcher@Sell@inTheDay
#Scenario: 05)Save Sell the Launcher information of the stock symbol in the time frame of the day
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And   serach Stock Symbol  فملی
#	And   Go to tab Sell
#	And   Order the stock symbol IRO1MSMI0001 enter the minimum price plus 0 and the minimum number plus 0
#	When  Save stock symbol Launcher information
#	Then  The result Should be Launcher Stock Symbol
#
#@GotoClient@Launcher@Sell @InTheMoment
#Scenario: 06)Save Sell the Launcher information of the stock symbol in the time frame at the moment 
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And   serach Stock Symbol  فملی
#	And   Go to tab Sell
#	And   Select advanced panel type and select Time range type in the moment
#	And   Order the stock symbol IRO1MSMI0001 enter the minimum price plus 0 and the minimum number plus 0
#	When  Save stock symbol Launcher information
#	Then  The result Should be Launcher Stock Symbol
#
#@GotoClient@LogoutClient@Launcher@Sell @ValidUntilCancelled
#	Scenario: 07)Save Sell the Launcher information of the stock symbol in the time frame Valid Until Cancelled  
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And   serach Stock Symbol  فملی
#	And   Go to tab Sell
#    And   Select Advanced panel type and select Time range type Valid until cancelled
#	And   Order the stock symbol IRO1MSMI0001 enter the minimum price plus 0 and the minimum number plus 0
#	When  Save stock symbol Launcher information
#	Then  The result Should be Launcher Stock Symbol
#
#@GotoClient@Launcher@Sell @ValidUntilDate
#Scenario: 08)Save Sell the Launcher information of the stock symbol in the time frame Valid Until Date   
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And   serach Stock Symbol  فملی
#	And   Go to tab Sell
#	And   Select Advanced panel type and select Time range type Valid until date
#	And   Order the stock symbol IRO1MSMI0001 enter the minimum price plus 0 and the minimum number plus 0
#	When  Save stock symbol Launcher information
#	Then  The result Should be Launcher Stock Symbol