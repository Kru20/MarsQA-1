using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class EducationSteps
    {
        [Given(@"add Universityorcollege Name, degree, choose country of college/University, Title, Year of graduation")]
        public void GivenAddUniversityorcollegeNameDegreeChooseCountryOfCollegeUniversityTitleYearOfGraduation()
        {
            EducationPage.AddEducation();
        }
        
        [Given(@"user click delete button")]
        public void GivenUserClickDeleteButton()
        {
            EducationPage.Delete();
        }
        
        [Given(@"user click edit icon")]
        public void GivenUserClickEditIcon()
        {
            EducationPage.Edit();
            
        }
        
        [Given(@"choose cancel")]
        public void GivenChooseCancel()
        {
            EducationPage.Cancle();
        }
        
        [When(@"user click add button")]
        public void WhenUserClickAddButton()
        {
            
        }
        
        [Then(@"Education should be saved")]
        public void ThenEducationShouldBeSaved()
        {
            
        }
        
        [Then(@"Education should be deleted")]
        public void ThenEducationShouldBeDeleted()
        {
            
        }
        
        [Then(@"Education should be edited")]
        public void ThenEducationShouldBeEdited()
        {
            
        }
        
        [Then(@"user can see Education tab")]
        public void ThenUserCanSeeEducationTab()
        {
            
        }
    }
}
