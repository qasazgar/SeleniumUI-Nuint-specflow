Feature: SellStockSymbolCustomer
	  By Customer
	  	 I Want Sell  one Stock Symbol خساپا  
		 so  Sell stock symbol with amounts and numbers in different time periods

Feature: SellStockSymbolCustomer
		 By Customer
		 I Want Edit Sell  one Stock Symbol خساپا  	
		so   Edit Sell stock symbol with amounts and numbers in different time periods

Feature: SellStockSymbolCustomer
		 By Customer
		 I Want Edit Sell  one Stock Symbol خساپا  	
		so   Edit Sell stock symbol with amounts and numbers in different time periods

@GotoClient@LogoutClient@@SellMin@Positivetest
Scenario Outline:01)Sell stock symbol  with a price and a  number 
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
    And   Go to tab Sell
	And   Select Advanced panel type
	And   Select Time range type Cleint <timerange>
	And   order Sell the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client 
	When  Save stock symbol Sell order Customer information
	Then  The result is that the customer must Sell the shares of the stock symbol And Show massage سفارش با موفقیت ثبت شد
Examples: 
	    | price | number | plusprice | plusnumber | timerange |
	    | min   | min    | 0          | 0           | روز       |
	    | min   | max    | 0          | 0           | انجام و حذف |
	    | max   | min    | 0          | 0           | معتبر تا لغو |
        | max   | max    | 0          | 0           |معتبر تا تاریخ|
	
@GotoClient@LogoutClient@Sell@EditOrderNumber@Positivetest
Scenario: 02)Edit Sell stock symbol  with a price and a  number 
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	And   Go to tab Sell
	And   Select Advanced panel type
	And   Editing <TypeEdit> order the stock symbol IRO1BPST0001 Enter the <Editprice>imum price plus <EditPlusprice> and the <Editnumber>imum number plus <EditPlusnumber>  Client
	When  Edit order Bought shares of the symbol
	Then  the result should Edit Sell shares of the symbol And Show Massage ویرایش سفارش با موفقیت ثبت شد
Examples:  
		   |TypeEdit | Editprice | Editnumber | EditPlusprice | EditPlusnumber |	     
	       |تعداد    | min       | min        |      0        |         0       |
		   |تعداد    | min       | max        |      0        |         0       |
	       |قیمت     | max       | min        |        0      |         0       |  
		   |قیمت     | max       | max        |        0      |         0       |  

@GotoClient@LogoutClient@Sell@inTheDay@EditOrderNumber@Positivetest
Scenario:  02)Delete Sell stock symbol  with a price and a  number 
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	And   Select Advanced panel type
	When  Delete order Bought shares of the symbol
	Then  the result should Delete Sell shares of the symbol And Show Massage

@GotoClient@LogoutClient@@Sell@Positivetest
Scenario Outline: Computational investigation of purchasing power and value in Selling from a stock symbol
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	And   Go to tab Sell
	And   Select Advanced panel type
	And   order Sell the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client 
	When  Get text And Assert And Save stock symbol Sell order Customer information 
	Then  The result is that the customer must Sell the shares of the stock symbol And Show massage سفارش با موفقیت ثبت شد
Examples: 
	    | price | number | plusprice | plusnumber | timerange |
	    | min   | min    | 0          | 0           | روز       |
#خرید از یک نماد بورسی با قیمت یا تعداد خارج از رنج امکان پذیر نیست
@GotoClient@LogoutClient@NotSell@NegativeTest
Scenario Outline: It is not possible to Sell a stock symbol with a price or quantity outside the range
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	And   Go to tab Sell
	And   Select Advanced panel type
	And   Select Time range type Cleint <timerange>
	And   order Sell the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client 
	When  Error message <textmessageOutOfRangePrice>  And  <textmessageOutOfRangeNumber>is displayed
	Then  the result should Sell shares of the Stock symbol

Examples: 
	    | price | number | plusprice | plusnumber | timerange    | textmessageOutOfRangePrice | textmessageOutOfRangeNumber |
	    | min   | max    | 1         | 1           | انجام و حذف  | قیمت در بازه مجاز نیست     | تعداد در بازه مجاز نیست     |
	    | max   | min    | -1          | -1          | معتبر تا لغو | قیمت در بازه مجاز نیست     | تعداد در بازه مجاز نیست     |
#خرید از یک نماد بورسی با قیمت و تعداد خارج از رنج امکان پذیر نیست
@GotoClient@LogoutClient@NotSell@NegativeTest
Scenario Outline:It is not possible to Sell from a stock symbol with a price and quantity outside the range
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	And   Go to tab Sell
	And   Select Advanced panel type
	And   Select Time range type Cleint <timerange>
	And   order Sell the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client 
	When  Error message <textmessageOutOfRangePrice>  And  <textmessageOutOfRangeNumber>is displayed
	Then  the result should Sell shares of the Stock symbol

Examples: 
	    | price | number | plusprice | plusnumber | timerange    | textmessageOutOfRangePrice | textmessageOutOfRangeNumber |
	    | min   | max    | -1         | 1           | انجام و حذف  | قیمت در بازه مجاز نیست     | تعداد در بازه مجاز نیست     |
	    | max   | min    | 1          | -1          | معتبر تا لغو | قیمت در بازه مجاز نیست     | تعداد در بازه مجاز نیست     |

@GotoClient@LogoutClient@@Sell@Positivetest
Scenario Outline: Sell stock symbol  with a Stock transaction value 
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	And   Go to tab Sell
	And   Select Advanced panel type
	And   Select Time range type Cleint <timerange>
	And   Enter the value of the stock exchange transaction <transactionvalue>  
	And   order the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> Client
	When  Save stock symbol Sell order Customer information
	Then  The result is that the customer must Sell the shares of the stock symbol And Show massage
Examples: 
	    | price | plusprice | timerange | transactionvalue |
	    | min   | 0         | روز       | 1000000          |




































#@GotoClient@LogoutClient@@Sell@Positivetest
#Scenario Outline:Sell stock symbol  with a amount and a  number 
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And   Search Stock Symbol Client  وپست
#	And   Go to tab Sell
#	And   Select Advanced panel type
#	And   Select Time range type Cleint <timerange>
#	And   order the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client
#	When  Save stock symbol Sell order Customer information
#	Then  the result should Sell shares of the Stock symbol
#
#Examples: 
#	    | price | number | plusprice | plusnumber | timerange    |
#	    | min   | min    | 0          | 0           | روز          |
#	    | min   | max    | 0          | 0           | انجام و حذف  |
#	    | max   | max    | 0          | 0           | معتبر تا لغو |
#        | max   | max    | 0          | 0           |معتبر تا تاریخ|
#	
#
#@GotoClient@LogoutClient@NotSell@NegativeTest
#Scenario Outline:Not Sell stock symbol  with a amount  number  out of range time
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And   Search Stock Symbol Client  وپست
#	And Go to tab Sell
#	And   Select Advanced panel type
#	And   Select Time range type Cleint <timerange>
#	And   order the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client
#	When  Error message <textmessageOutOfRangePrice>  And  <textmessageOutOfRangeNumber>is displayed
#	Then  the result should Sell shares of the Stock symbol
#
#Examples: 
#	    | price | number | plusprice | plusnumber | timerange    | textmessageOutOfRangePrice | textmessageOutOfRangeNumber |
#	    | min   | max    | -1         | 1           | انجام و حذف  | قیمت در بازه مجاز نیست     | تعداد در بازه مجاز نیست     |
#	    | max   | min    | 1          | -1          | معتبر تا لغو | قیمت در بازه مجاز نیست     | تعداد در بازه مجاز نیست     |
#
#@GotoClient@LogoutClient@NotSell@NegativeTest
#Scenario Outline:Not Sell stock symbol  with a amount and  number  out of range time
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And   Search Stock Symbol Client  وپست
#	And Go to tab Sell
#	And   Select Advanced panel type
#	And   Select Time range type Cleint <timerange>
#	And   order the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client
#	When  Error message <textmessageOutOfRangePrice>  And  <textmessageOutOfRangeNumber>is displayed
#	Then  the result should Sell shares of the Stock symbol
#
#Examples: 
#	    | price | number | plusprice | plusnumber | timerange    | textmessageOutOfRangePrice | textmessageOutOfRangeNumber |
#	    | min   | max    | -1         | 1           | انجام و حذف  | قیمت در بازه مجاز نیست     | تعداد در بازه مجاز نیست     |
#	    | max   | min    | 1          | -1          | معتبر تا لغو | قیمت در بازه مجاز نیست     | تعداد در بازه مجاز نیست     |
#
#
#@GotoClient@LogoutClient@Sell@inTheDay@EditOrderNumber@Positivetest
#Scenario:  Sell stock symbol  with a  amount and number of day And Edit Order Number And Price
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And   Search Stock Symbol Client  وپست
#	And   Go to tab Sell
#	And   Editing <TypeEdit> order the stock symbol IRO1BPST0001 Enter the <Editprice>imum price plus <EditPlusprice> and the <Editnumber>imum number plus <EditPlusnumber>  Client
#	When  Edit order Bought shares of the symbol
#	Then  the result should Edit Sell shares of the symbol And Show Massage
#Examples:  
#		   |TypeEdit | Editprice | Editnumber | EditPlusprice | EditPlusnumber |	     
#	       |تعداد    | min       | min        |      0         |         0       |
#		   |تعداد    | min       | max        |      0         |         0       |
#	       |قیمت     | max       | max        |        0      |         0       |  
#		   |قیمت     | min       | max        |        0      |         0       |  
#
#@GotoClient@LogoutClient@Sell@inTheDay@EditOrderNumber@Positivetest
#Scenario:  Sell stock symbol  with a  amount and number of day And Delete Order 
#	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
#	And   Search Stock Symbol Client  وپست
#	When  Delete order Bought shares of the symbol
#	Then  the result should Delete Sell shares of the symbol And Show Massage


