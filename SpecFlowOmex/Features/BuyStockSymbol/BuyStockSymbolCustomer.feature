Feature: BuyStockSymbolCustomer
		 By Customer
		 I Want Edit Buy  one Stock Symbol خساپا  	
		so   Edit Buy stock symbol with amounts and numbers in different time periods

@GotoClient@LogoutClient@@BuyMin@Positivetest
Scenario Outline:01)Buy stock symbol  with a price and a  number 
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	And   Select Advanced panel type
	And   Select Time range type Cleint <timerange>
	And   order the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client
	When  Save stock symbol Buy order Customer information
	Then  The result is that the customer must buy the shares of the stock symbol And Show massage سفارش با موفقیت ثبت شد
Examples: 
	    | price | number | plusprice | plusnumber | timerange |
	    | min   | min    | 0          | 0           | روز       |
	    | min   | max    | 0          | 0           | انجام و حذف |
	    | max   | min    | 0          | 0           | معتبر تا لغو |
        | max   | max    | 0          | 0           |معتبر تا تاریخ|
	
@GotoClient@LogoutClient@Buy@EditOrderNumber@Positivetest
Scenario: 02)Edit Buy stock symbol  with a price and a  number 
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	And   Editing <TypeEdit> order the stock symbol IRO1BPST0001 Enter the <Editprice>imum price plus <EditPlusprice> and the <Editnumber>imum number plus <EditPlusnumber>  Client
	When  Edit order Bought shares of the symbol
	Then  The result is that the customer must buy the shares of the stock symbol And Show massage ویرایش سفارش با موفقیت ثبت شد
Examples:  
		   |TypeEdit | Editprice | Editnumber | EditPlusprice | EditPlusnumber |	     
	       |تعداد    | min       | max        |      0        |         -2       |
		   |تعداد    | max       | min        |      0        |         2       |
	       |قیمت     | min       | max        |        -2      |        0        |  
		   |قیمت     | max       | min        |        2      |        0       |  

@GotoClient@LogoutClient@Buy@inTheDay@EditOrderNumber@Positivetest
Scenario:  02)Delete Buy stock symbol  with a price and a  number 
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	When  Delete order Bought shares of the symbol
	Then  the result should Delete Buy shares of the symbol And Show Massage

@GotoClient@LogoutClient@@Buy@Positivetest
Scenario Outline: Computational investigation of purchasing power and value in buying from a stock symbol
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	And   order the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client
	When  Get text And Assert And Save stock symbol Buy order Customer information 
	Then  The result is that the customer must buy the shares of the stock symbol And Show massage ویرایش سفارش با موفقیت ثبت شد
Examples: 
	    | price | number | plusprice | plusnumber | timerange |
	    | min   | min    | 0          | 0           | روز       |
#خرید از یک نماد بورسی با قیمت یا تعداد خارج از رنج امکان پذیر نیست
@GotoClient@LogoutClient@NotBuy@NegativeTest
Scenario Outline: It is not possible to buy a stock symbol with a price or quantity outside the range
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	And   Select Advanced panel type
	And   Select Time range type Cleint <timerange>
	And   order the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client
	When  Error message <textmessageOutOfRangePrice>  And  <textmessageOutOfRangeNumber>is displayed
	Then  the result should Buy shares of the Stock symbol

Examples: 
	    | price | number | plusprice | plusnumber | timerange    | textmessageOutOfRangePrice | textmessageOutOfRangeNumber |
	    | min   | max    | 1         | 1           | انجام و حذف  | قیمت در بازه مجاز نیست     | تعداد در بازه مجاز نیست     |
	    | max   | min    | -1          | -1          | معتبر تا لغو | قیمت در بازه مجاز نیست     | تعداد در بازه مجاز نیست     |
#خرید از یک نماد بورسی با قیمت و تعداد خارج از رنج امکان پذیر نیست
@GotoClient@LogoutClient@NotBuy@NegativeTest
Scenario Outline:It is not possible to buy from a stock symbol with a price and quantity outside the range
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	And   Select Advanced panel type
	And   Select Time range type Cleint <timerange>
	And   order the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client
	When  Error message <textmessageOutOfRangePrice>  And  <textmessageOutOfRangeNumber>is displayed
	Then  the result should Buy shares of the Stock symbol

Examples: 
	    | price | number | plusprice | plusnumber | timerange    | textmessageOutOfRangePrice | textmessageOutOfRangeNumber |
	    | min   | max    | -1         | 1           | انجام و حذف  | قیمت در بازه مجاز نیست     | تعداد در بازه مجاز نیست     |
	    | max   | min    | 1          | -1          | معتبر تا لغو | قیمت در بازه مجاز نیست     | تعداد در بازه مجاز نیست     |
#
@GotoClient@LogoutClient@@Buy@Positivetest
Scenario Outline: Buy stock symbol  with a Stock transaction value 
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	And   Select Advanced panel type
	And   Select Time range type Cleint <timerange>
	And   Enter the value of the stock exchange transaction <transactionvalue>  
	And   order the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> Client
	When  Save stock symbol Buy order Customer information
	Then  The result is that the customer must buy the shares of the stock symbol And Show massage سفارش با موفقیت ثبت شد
Examples: 
	    | price | plusprice | timerange | transactionvalue |
	    | min   | 0         | روز       | 1000000          |