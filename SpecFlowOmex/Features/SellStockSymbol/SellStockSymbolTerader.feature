Feature: SellStockSymbolTerader
	  By Customer
	  	 I Want Sell  one Stock Symbol خساپا  
		 so  Sell stock symbol with amounts and numbers in different time periods


@GotostationDev@LogoutUserStation@BuyMin@inTheDay@Positivetest
Scenario Outline:  Sell stock symbol with  amount and  number of Range time 
	Given LoginUser Trader With Username testtrader And Password P@10+1020
	And   Search Stock Symbol  وپست
	And   Go to tab Sell Station
	And   Search And Select Customer name نامنی باران سادات
	And   Order the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>
	And    select Time range type <timerange>
	When  Save stock symbol Sell order Trader information
	Then  the result should Sell shares of the Stock symbol

Examples: 
	    | price | number | plusprice | plusnumber | timerange    |
	    | min   | min    | 0          | 0           | روز          |
	    | min   | max    | 0          | 0           | انجام و حذف  |
	    | max   | max    | 0          | 0           | معتبر تا لغو |
        | max   | min    | 0          | 0           |معتبر تا تاریخ|
#@GotoClient@LogoutClient@SellMin@inTheDay@NegativeTest
#Scenario: Not Selling the stock symbol With out of range amount and minimum number in the time period of the day
#
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And serach Stock Symbol  خساپا
#	And Go to tab Sell
#	When Maximum price plus 2 and number plus 0 are given to stock symbol IRO1SIPA0001 and error out of price range
#	Then the result should Error message The price is not in the allowed range
# 
# @GotoClient@LogoutClient@SellMin@inTheDay@NegativeTest
#Scenario: Not Selling the stock symbol With out of range Number and maximum amount in the time period of the day
#
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And serach Stock Symbol  خساپا
#	And Go to tab Sell
#	When Maximum price plus 0 and number plus 1 are given to stock symbol IRO1SIPA0001 and error out of number range
#	Then the result should Error message The number is not in the allowed range
#
# @GotoClient@LogoutClient@SellMin@inTheDay@NegativeTest
#Scenario: Not Selling the stock symbol With out of range Number and amount in the time period of the day
#
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And serach Stock Symbol  خساپا
#	And Go to tab Sell
#	When Maximum price plus -1 and number plus -1 are given to stock symbol IRO1SIPA0001 and error out of number And Price range
#	Then the result should Error message The number And Price is not in the allowed range
#
#@GotoClient@LogoutClient@SellMin@inTheDay@Positivetest
#Scenario:  Sell stock symbol  with a minimum amount and a minimum number of day
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And serach Stock Symbol  وپست
#	And Go to tab Sell
#	And Order the stock symbol IRO1BPST0001 enter the minimum price plus 0 and the minimum number plus 0
#	When Save stock symbol Sell order information
#	Then the result should Sell shares of the symbol
#
#@GotoClient@LogoutClient@SellMin @InTheMoment@Positivetest
#Scenario:  Sell stock symbol  with a minimum amount and a minimum number at the Moment
#
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And serach Stock Symbol  وپست
#	And Go to tab Sell
#	And  Select advanced panel type and select Time range type in the moment
#	And  Order the stock symbol IRO1BPST0001 enter the minimum price plus 0 and the minimum number plus 0
#	When Save stock symbol Sell order information
#	Then the result should Sell shares of the symbol 
#
#@GotoClient@LogoutClient@SellMin @ValidUntilCancelled@Positivetest
#Scenario: Sell the stock symbol with the minimum and minimum order quantity until order cancellation
# 
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And serach Stock Symbol  وپست
#	And Go to tab Sell
#	And  Select Advanced panel type and select Time range type Valid until cancelled
#	And  Order the stock symbol IRO1BPST0001 enter the minimum price plus 0 and the minimum number plus 0
#	When Save stock symbol Sell order information
#	Then the result should Sell shares of the symbol 
#
#@GotoClient@LogoutClient@SellMin @ValidUntilDate@Positivetest
#Scenario: Sell the stock symbol at the minimum and minimum number on the specified date
#
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#    And serach Stock Symbol  وپست
#	And Go to tab Sell
#	And  Select Advanced panel type and select Time range type Valid until date
#	And  Order the stock symbol IRO1BPST0001 enter the minimum price plus 0 and the minimum number plus 0
#	When Save stock symbol Sell order information
#	Then the result should Sell shares of the symbol 
#
#@GotoClient@LogoutClient@SellMin @ValidUntilDate@Positivetest
#Scenario: Sell the stock symbol at the maximum and maximum number on the specified date
#
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	 And serach Stock Symbol  وپست
#	And Go to tab Sell
#	And  Select Advanced panel type and select Time range type Valid until date
#	And  Order the stock symbol IRO1BPST0001 enter the maximum price plus 0 and the maximum number plus 0
#	When Save stock symbol Sell order information
#	Then the result should Sell shares of the symbol 
#
#@GotoClient@LogoutClient@Sell@inTheDay@DeleteOrder@Positivetest
#Scenario:  Sell stock symbol  with a minimum amount and a minimum number of day And Delete Order
#
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And serach Stock Symbol  خساپا
#	And Go to tab Sell
#	And Order the stock symbol IRO1SIPA0001 enter the minimum price plus 0 and the minimum number plus 0 
#	When Delete order Bought shares of the symbol
#	Then the result should Sell shares of the symbol
#
#@GotoClient@LogoutClient@Sell@inTheDay@EditOrderNumber@Positivetest
#Scenario:  Sell stock symbol  with a minimum amount and a minimum number of day And Edit Order Number
#
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And  serach Stock Symbol  خساپا
#	And  Go to tab Sell
#	And  Order the stock symbol IRO1SIPA0001 enter the minimum price plus 0 and the minimum number plus 0 
#	When Edit order Bought shares of the symbol
#	Then the result should Sell shares of the symbol
#	
#@GotoClient@LogoutClient@Sell@inTheDay@EditOrderPrice@Positivetest
#Scenario:  Sell stock symbol  with a minimum amount and a minimum number of day And Edit Order Price
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And serach Stock Symbol  خساپا
#	And Go to tab Sell
#	And  Order the stock symbol IRO1SIPA0001 enter the minimum price plus 0 and the minimum number plus 0 
#	When Edit Order Price  Bought shares of the symbol
#	Then the result should Sell shares of the symbol