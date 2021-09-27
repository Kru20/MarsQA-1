Feature: Add, Delete, Edit or Cancel Education Certification
	

@addCertification
Scenario: Add Certification
	Given add Certificate/Award Name, Certificate from
	And choose year
	When click add
	Then Certification should be saved

@DeleteCertification
Scenario: Delete existing Certification
	Given choose Certificate/Award Name
	When user click delete
	Then Certification should be deleted

@EditCertification
Scenario: Edit existing Certification
	Given Choose Certificate/Award Name
	When user click edit icon
	Then Certification should be edited

@CancelCertification
Scenario: Cancle Certification
	Given choose add new skills
	When choose cancel
	Then user can see Certification tab