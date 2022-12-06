Feature: LimitationsTimeStockSymbol
        By Admin 
		I Want Time limit for advertising the stock symbol
		So time limit for advertising the stock symbol

		By Customer 
		I Want  Buy Stock Symbol in the Day 
		So 


	@GoToUrlAndLoadPageAdmin@LogoutAdmin
Scenario:01) time limit for advertising the stock symbol
	Given LoginUser Admin With Username administrator And Password Administrator@IFS
	And   Go to Menu limitations And Click Create limitation  
	And   Create New limitations Enter Title <Title> And Symbol <Symbolname> And Massage Farsi <Massagefarsi>  And Active Stock symbol
	When  Go to Menu limitations And Click Edit limitation insert Time from 2 to 0
	Then The result Should be insert Time 
	Examples:
	| Title |Symbolname| Massagefarsi |
	| معامله در زمان فعلی به دلیل محدودیت  در بازار اعمال نمی شود | خساپا| اعمال محدودیت زمانی در نماد خساپا|


@GotoClient@LogoutClient@BuyMin@inTheDay@Positivetest
Scenario:  02)Buy stock symbol  with a minimum amount and a minimum number of day
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And serach Stock Symbol  وپست
	And Order the stock symbol IRO1BPST0001 enter the minimum price plus 0 and the minimum number plus 0
	When Save stock symbol Buy order information
	Then the result should Buy shares of the symbol Message <Massagefarsi>
		Examples:
	 | Massagefarsi                      |
	 | اعمال محدودیت زمانی در نماد خساپا |


@GoToUrlAndLoadPageAdmin@LogoutAdmin
Scenario: 03)Delete limitations stock symbol
	Given LoginUser Admin With Username administrator And Password Administrator@IFS
	And   Go to Menu limitations   
	When  Delete limitations First one Item
	Then  the result should be  delete



