Feature: LimitationsMarketTypeStockSymbol
	By Admin 

	@GoToUrlAndLoadPageAdmin@LogoutAdmin
Scenario:01) Market Type limit for advertising the stock symbol
	Given LoginUser Admin With Username administrator And Password Administrator@IFS
	And   Go to Menu limitations And Click Create limitation  
	And   Create New limitations Enter Title <Title> And Symbol <Symbolname> And Massage Farsi <Massagefarsi>  And Active Stock symbol
	When  Go to Menu limitations And Click Edit limitation insert Market Type بورس
	Then The result Should be insert Time 
	Examples:
	| Title |Symbolname| Massagefarsi |
	| معامله با نوع بازار ،به دلیل محدودیت  در بازار اعمال نمی شود | خساپا| اعمال محدودیت نوع بازار  در نماد خساپا|


@GotoClient@LogoutClient@BuyMin@inTheDay@Positivetest
Scenario:  02)Buy stock symbol  with a minimum amount and a minimum number of day
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And serach Stock Symbol  وپست
	And Order the stock symbol IRO1BPST0001 enter the minimum price plus 0 and the minimum number plus 0
	When Save stock symbol Buy order information
	Then the result should Buy shares of the symbol Message <Massagefarsi>
		Examples:
	 | Massagefarsi                      |
	 | اعمال محدودیت نوع بازار در نماد خساپا |


@GoToUrlAndLoadPageAdmin@LogoutAdmin
Scenario: 03)Delete limitations stock symbol
	Given LoginUser Admin With Username administrator And Password Administrator@IFS
	And   Go to Menu limitations   
	When  Delete limitations First one Item
	Then  the result should be  delete