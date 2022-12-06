Feature: InitialPublicOfferings
	As Customer

@GotoClient@LogoutClient@@BuyMin@Positivetest
Scenario: Buy Initial Public Offerings By the Customer
	Given LoginUser Customer With Username 0153540664 And Password TseTab.ir123
	And   Initial Public Offerings select 1
	When  order the Initial Public Offerings stock symbol IRO1BPST0001 Enter the <price>imum price plus <plusprice> and the <number>imum number plus <plusnumber>  Client
	Then  the result should be 