Feature: LimitationsTransactionManagerStockSymbol
	By Admin 

	@GoToUrlAndLoadPageAdmin@LogoutAdmin
Scenario:01)Transaction Manager limit for advertising the stock symbol
	Given LoginUser Admin With Username administrator And Password Administrator@IFS
	And   Go to Menu limitations And Click Create limitation  
	And   Create New limitations Enter Title <Title> And Symbol <Symbolname> And Massage Farsi <Massagefarsi>  And Active Stock symbol
	When  Go to Menu limitations And Click Edit limitation insert Transaction Manager مشتری
	Then The result Should be insert Time 
	Examples:
	| Title |Symbolname| Massagefarsi |
	| معامله با تعداد مشخص شده ،به دلیل مجری معامله در بازار اعمال نمی شود | خساپا| اعمال محدودیت مجری معامله در نماد خساپا|


	@GotoClient@LogoutClient@Buy@inTheDay
Scenario:02) time limit Buy Stock Symbol in the Day  
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And serach Stock Symbol  خساپا
	When Buy shares of the symbol on the day
	Then the result should Buy shares of the symbol Message <Massagefarsi>
		Examples:
	 | Massagefarsi                      |
	 | اعمال محدودیت مجری معامله در نماد خساپا |


@GoToUrlAndLoadPageAdmin@LogoutAdmin
Scenario: 03)Delete limitations stock symbol
	Given LoginUser Admin With Username administrator And Password Administrator@IFS
	And   Go to Menu limitations   
	When  Delete limitations First one Item
	Then  the result should be  delete