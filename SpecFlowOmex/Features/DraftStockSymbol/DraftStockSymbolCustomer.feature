Feature: DraftStockSymbolCustomer
	By Custmer
	I Want  Draft purchase of shares from the stock exchange symbol
	so 



@GotoClient@LogoutClient@Drft@Buy@Day
Scenario Outline:  Draft Buy stock symbol with  amount and  number 
		Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	And   Select Advanced panel type
	And   Select Time range type Cleint <timerange>
	And   order the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client
	When  Save stock symbol Draft order Customer information
	Then  the result should Draft Buy shares of the Stock symbol by the Customer

Examples: 
	    | price | number | plusprice | plusnumber | timerange    |
	    | min   | min    | 0          | 0           | روز          |
	    | min   | max    | 0          | 0           | انجام و حذف  |
	    | max   | max    | 0          | 0           | معتبر تا لغو |
        | max   | min    | 0          | 0           |معتبر تا تاریخ|

#----------------------------
#Sell Draft

@GotoClient@LogoutClient@Drft@Sell
Scenario Outline:  Draft Sell stock symbol with  amount and  number 
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	And   Go to tab Sell
	And   Select Advanced panel type
	And   Select Time range type Cleint <timerange>
	And   order Sell the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client 
	When  Save stock symbol Draft order Customer information
	Then  the result should Draft Buy shares of the Stock symbol by the Customer

Examples: 
	    | price | number | plusprice | plusnumber | timerange    |
	    | min   | min    | 0          | 0           | روز          |
	    | min   | max    | 0          | 0           | انجام و حذف  |
	    | max   | max    | 0          | 0           | معتبر تا لغو |
        | max   | min    | 0          | 0           |معتبر تا تاریخ|
