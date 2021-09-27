using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SkillsSteps
    {
        [Given(@"add Skills Name, choose Skills level")]
        public void GivenAddSkillsNameChooseSkillsLevel()
        {
            SkillsPage.AddSkills();
        }
        
        [Given(@"user click delete")]
        public void GivenUserClickDelete()
        {
            SkillsPage.Delete();  
        }
             
        
        [Given(@"User choose cancel")]
        public void GivenUserChooseCancel()
        {
            SkillsPage.CancelSkills();
        }

        [Given(@"User Choose edit skills")]
        public void GivenUserChooseEditSkills()
        {
            SkillsPage.EditSkills();
        }
        [When(@"user click add")]
        public void WhenUserClickAdd()
        {
            
        }
        
        [Then(@"Skills should be saved")]
        public void ThenSkillsShouldBeSaved()
        {
           
        }
        
        [Then(@"Skills should be deleted")]
        public void ThenSkillsShouldBeDeleted()
        {
           
        }
        
        [Then(@"skills should be edited")]
        public void ThenSkillsShouldBeEdited()
        {
            
        }
        
        [Then(@"user can see skills tab")]
        public void ThenUserCanSeeSkillsTab()
        {
           
        }
    }
}
