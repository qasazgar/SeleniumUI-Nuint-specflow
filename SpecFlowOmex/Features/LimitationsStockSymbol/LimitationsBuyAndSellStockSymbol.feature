Feature: LimitationsBuyAndSellStockSymbol
    By Admin 
	I Want 



@GoToUrlAndLoadPageAdmin@LogoutAdmin
Scenario Outline: 01)Creating Limitation on the purchased And Active stock symbol
	Given LoginUser Admin With Username administrator And Password Administrator@IFS
	And   Go to Menu limitations And Click Create limitation
	And   Create New limitations Enter Title <Title> And Symbol <Symbolname> And Massage Farsi <Massagefarsi>  And Active Stock symbol
	When  Active limitations It has transaction order with it
	Then  the result should Create New Limitation And Active Stock Symbol   
 
Examples:
	| Title |Symbolname| Massagefarsi |
	| نماد فملی امکان معامله ثانویه را ندارد | فملی| در این نماد معامله صورت گرفته است .امکان معامله دوم در نماد میسر نیست|



@GotoClient@LogoutClient@@BuyMin@Positivetest
Scenario Outline:02)Buy stock symbol  with a amount and a  number 
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Search Stock Symbol Client  وپست
	And   Select Advanced panel type
	And   Select Time range type Cleint <timerange>
	And   order the stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client
	When  Save stock symbol Buy order Customer information
	Then  The result is that the customer must buy the shares of the stock symbol And Show massage
Examples: 
	    | price | number | plusprice | plusnumber | timerange    |
	    | min   | min    | 0          | 0           | روز          |


