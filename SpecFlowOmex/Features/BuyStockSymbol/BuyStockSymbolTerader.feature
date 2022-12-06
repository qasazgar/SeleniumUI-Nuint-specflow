Feature: BuyStockSymbolTrader
		 By Trader
		 I Want Edit Buy  one Stock Symbol خساپا  
		 so   Edit Buy stock symbol with amounts and numbers in different time periods
		 
@GotostationDev@LogoutUserStation@BuyMin@inTheDay@Positivetest
Scenario Outline:   Buy stock symbol  with a minimum amount and a minimum number of day
	Given LoginUser Trader With Username testtrader And Password P@10+1020
	And   Search Stock Symbol  وپست
	And   Search And Select Customer name نامنی باران سادات
	And   Order the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>
	And    select Time range type <timerange>
	When  Save stock symbol Buy order Trader information
	Then  the result should Buy shares of the Stock symbol

Examples: 
	    | price | number | plusprice | plusnumber | timerange    |
	    | min   | min    | 0          | 0           | روز          |
	    | min   | max    | 0          | 0           | انجام و حذف  |
	    | max   | max    | 0          | 0           | معتبر تا لغو |
        | max   | min    | 0          | 0           |معتبر تا تاریخ|
