Feature: User can add,edit, delete or Cancel Max 4 Language
	

@addLanguage
Scenario: Add known Language
	Given add Language Name, language level
	When  click on add button
	Then language should be saved

@DeleteLanguage
Scenario: Delete existing Language
	Given  click delete button
	Then language should be deleted

@EditLanguage
Scenario: Edit existing Language
	Given user click edit
	Then language should be edited

@CancelLanguage
Scenario: Cancle Language
	Given choose cancel language
	Then user can see language tab