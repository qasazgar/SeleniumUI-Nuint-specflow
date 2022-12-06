Feature: NoteOnStockSymbol
	As Customer And Trader
	I Want Create a Note on stock symbol
	So 

@GotoClient@LogoutClient@Note
Scenario: 01)Create a Note on stock symbol  As Customer1
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Go to the profile panel
	And   Click Icon sticky note 
	When  we create a note on stock symbol خساپا with text برای این نماد یک یادداشت ثبت شد And Status <status>  
	Then  Show stock symbol notes یادداشت با موفقیت اضافه شد.
Examples: 
      | status           |
      | انجام شده       |
      | در حال انجام    |
      | در انتظار اقدام |


@GotoClient@LogoutClient@Note
Scenario: 02)Edit a Note on stock symbol  As Customer
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Go to the profile panel
	When  We edit a note on stock symbol خساپا with text برای این نماد یک یادداشت ویرایش شد  
	Then  Show stock symbol notes یادداشت با موفقیت ویرایش شد.

@GotoClient@LogoutClient@Note
Scenario: 03)Delete a Note on stock symbol  As Customer
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Go to the profile panel
	When  We Delete a note on stock symbol خساپا  
	Then  Delete stock symbol notes 

	#GotostationDev

	@GotostationDev@LogoutUserStation@Note
Scenario: 04)Create a Note on stock symbol  As Trader
	Given LoginUser Trader With Username testtrader And Password P@10+1020
	And   Go to the profile panel station
	And   Click Icon sticky note 
	When  We create a note station on stock symbol خساپا with text برای این نماد یک یادداشت ثبت شد  
	Then  Show stock symbol station notes یادداشت با موفقیت اضافه شد.

@GotostationDev@LogoutUserStation@Note
Scenario: 05)Edit a Note on stock symbol  As Trader
	Given LoginUser Trader With Username testtrader And Password P@10+1020
	And   Go to the profile panel station
	When  We edit a note station on stock symbol خساپا with text برای این نماد یک یادداشت ویرایش شد  
	Then  Show stock symbol station notes یادداشت با موفقیت ویرایش شد.

@GotostationDev@LogoutUserStation@Note
Scenario: 06)Delete a Note on stock symbol  As Trader
	Given LoginUser Trader With Username testtrader And Password P@10+1020
	And   Go to the profile panel station
	When  We Delete a note station on stock symbol خساپا  
	Then  Delete stock symbol notes station