Feature: User can Add, Delete, Edit or Cancel Education
	

@addEducation
Scenario: Add Education
	Given add Universityorcollege Name, degree, choose country of college/University, Title, Year of graduation
	When user click add button
	Then Education should be saved

@DeleteEducation
Scenario: Delete existing Education
	Given user click delete button
	Then Education should be deleted

@EditEducation
Scenario: Edit existing Education
	Given user click edit icon
	Then Education should be edited

@CancelEducation
Scenario: Cancle Education
	Given choose cancel
	Then user can see Education tab