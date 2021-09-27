Feature: Skills can be Add, delete, Edit or Cancel
	

@addSkills
Scenario: Add known Skills
	Given add Skills Name, choose Skills level
	When user click add
	Then Skills should be saved

@DeleteSkills
Scenario: Delete existing Skills
	Given user click delete
	Then Skills should be deleted

@EditSkills
Scenario: Edit existing skills
	Given User Choose edit skills
	Then skills should be edited

@CancelSkills
Scenario: Cancle skills
	Given User choose cancel
	Then user can see skills tab