using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class UserCanAddOrEditProfileDetailsSteps
    {
        [Given(@"Existing user can go to profile Page")]
        public void GivenExistingUserCanGoToProfilePage()
        {
            
            ExcelLibHelper.PopulateInCollection(@"E:\Krups\Internship\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");
        }

        [When(@"user want to add Avaibility, Hours, Earn Target")]
        public void WhenUserWantToAddAvaibilityHoursEarnTarget()
        {
            ProfileAHEPage.AddAvaibility();
            ProfileAHEPage.AddHours();
            ProfileAHEPage.AddEarnTarget();
            
        }

                    
        
        [When(@"user want to edit Avaibility, Hours, Earn Target")]
        public void WhenUserWantToEditAvaibilityHoursEarnTarget()
        {
            ProfileAHEPage.EditAvaibility();
            ProfileAHEPage.EditHours();
            ProfileAHEPage.EditEarnTarget();
            
        }
        
        [Then(@"details should be saved")]
        public void ThenDetailsShouldBeSaved()
        {
           
        }
    }
}
