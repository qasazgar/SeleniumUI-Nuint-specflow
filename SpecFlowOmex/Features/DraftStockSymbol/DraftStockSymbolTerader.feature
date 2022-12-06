Feature: DraftStockSymbolTerader
	By Custmer
	I Want  Draft purchase of shares from the stock exchange symbol
	so 


	@GotostationDev@LogoutUserStation@BuyMin@inTheDay@Positivetest
Scenario Outline:  Draft Buy stock symbol with  amount and  number of Range time 
	Given LoginUser Trader With Username testtrader And Password P@10+1020
	And   Search Stock Symbol  وپست
	And   Search And Select Customer name نامنی باران سادات
	And   Order the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>
	And    select Time range type <timerange>
	When  Save stock symbol Draft order Trader information
	Then  the result should Draft Buy shares of the Stock symbol

Examples: 
	    | price | number | plusprice | plusnumber | timerange    |
	    | min   | min    | 0          | 0           | روز          |
	    | min   | max    | 0          | 0           | انجام و حذف  |
	    | max   | max    | 0          | 0           | معتبر تا لغو |
        | max   | min    | 0          | 0           |معتبر تا تاریخ|

	@GotostationDev@LogoutUserStation@BuyMin@inTheDay@Positivetest
Scenario Outline:  Draft  Sell stock symbol with  amount and  number of Range time 
	Given LoginUser Trader With Username testtrader And Password P@10+1020
	And   Search Stock Symbol  وپست
	And   Go to tab Sell Station
	And   Search And Select Customer name نامنی باران سادات
	And   Order the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>
	And    select Time range type <timerange>
	When  Save stock symbol Draft order Trader information
	Then  the result should Draft Sell shares of the Stock symbol

Examples: 
	    | price | number | plusprice | plusnumber | timerange    |
	    | min   | min    | 0          | 0           | روز          |
	    | min   | max    | 0          | 0           | انجام و حذف  |
	    | max   | max    | 0          | 0           | معتبر تا لغو |
        | max   | min    | 0          | 0           |معتبر تا تاریخ|








