Feature: StockMarketWatchlist
        By Admin 
		I Want 

@GotoClient@LogoutClient
Scenario: 01)Add Stock market watch list

	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Create a watch list with the name اتومات
	When  Add stock symbol to watch list فملی
	Then  The result should be a stock symbol is added to the new watch list


@GotoClient@LogoutClient
Scenario: 02)Delete Stock market watch list

	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Go to a watch list with the name اتومات
	When  Delete stock symbol to watch list 
	Then  The result should be a stock symbol is Deleted to the new watch list


	@GotoClient@LogoutClient
Scenario: 03)Delete  watch list
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Go to a watch list 
	When  Delete  watch list 
	Then  The result should be  Deleted to the new watch list