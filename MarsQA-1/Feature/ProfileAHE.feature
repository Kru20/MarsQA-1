Feature: user can add or edit profile details 
As a user
people can see skills.
	
@addDetails
Scenario: add profile details
	Given Existing user can go to profile Page
	When user want to add Avaibility, Hours, Earn Target
	Then details should be saved

@EditDescription
Scenario: Edit profile details
	Given Existing user can go to profile Page
	When user want to edit Avaibility, Hours, Earn Target
	Then details should be saved