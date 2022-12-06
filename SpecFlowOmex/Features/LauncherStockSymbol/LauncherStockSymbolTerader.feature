Feature: LauncherStockSymbolTerader
	By Custmer
	I Want  Launcher for selling And Buying shares of the stock exchange symbol
	so  
	#Buy#Launcher
	@GotostationDev@LogoutUserStation@BuyMin@inTheDay@Positivetest
Scenario Outline:  Launcher Buy stock symbol with  amount and  number of Range time 
	Given LoginUser Trader With Username testtrader And Password P@10+1020
	And   Search Stock Symbol  وپست
	And   Search And Select Customer name نامنی باران سادات
	And   Order the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>
	And    select Time range type <timerange>
	When  Save stock symbol Launcher order Trader information
	Then  the result should Launcher shares of the Stock symbol

Examples: 
	    | price | number | plusprice | plusnumber | timerange    |
	    | min   | min    | 0          | 0           | روز          |
	    | min   | max    | 0          | 0           | انجام و حذف  |
	    | max   | max    | 0          | 0           | معتبر تا لغو |
        | max   | min    | 0          | 0           |معتبر تا تاریخ|

		#Sell#Launcher
	@GotostationDev@LogoutUserStation@BuyMin@inTheDay@Positivetest
Scenario Outline:  Launcher Sell stock symbol with  amount and  number of Range time 
	Given LoginUser Trader With Username testtrader And Password P@10+1020
	And   Search Stock Symbol  وپست
	And   Go to tab Sell Station
	And   Search And Select Customer name نامنی باران سادات
	And   order Sell the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client 
	And   select Time range type <timerange>
	When  Save stock symbol Launcher order Trader information
	Then  the result should Launcher shares of the Stock symbol

Examples: 
	    | price | number | plusprice | plusnumber | timerange    |
	    | min   | min    | 0          | 0           | روز          |
	    | min   | max    | 0          | 0           | انجام و حذف  |
	    | max   | max    | 0          | 0           | معتبر تا لغو |
        | max   | min    | 0          | 0           |معتبر تا تاریخ|

