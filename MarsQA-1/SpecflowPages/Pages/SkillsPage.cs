using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class SkillsPage
    {
        
        public static IWebElement SkillsTab => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        public static IWebElement AddNewBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public static IWebElement AddSkillTab => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        public static IWebElement SkillsLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
        public static IWebElement AddBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        public static IWebElement Cancel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]"));
        public static IWebElement EditBtn1 => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
        public static IWebElement EditTextBox1 => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
        public static IWebElement LevelTextBox1 => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select"));
        public static IWebElement UpdateBtn1 => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));

        public static IWebElement EditBtn2 => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[1]/i"));
        public static IWebElement EditTextBox2 => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td/div/div[1]/input"));
        public static IWebElement LevelTextBox2 => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td/div/div[2]/select"));
        public static IWebElement UpdateBtn2 => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td/div/span/input[1]"));
        public static IWebElement DeleteBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
        public static void AddSkills()
        {
            ExcelLibHelper.PopulateInCollection(@"E:\Krups\Internship\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Skills");
            Thread.Sleep(2500);
            SkillsTab.Click();
            Thread.Sleep(1500);
            AddNewBtn.Click();
            AddSkillTab.SendKeys(ExcelLibHelper.ReadData(2, "Skills"));
            Thread.Sleep(1500);
            SkillsLevel.Click();
            SelectElement oSelect1 = new SelectElement(SkillsLevel);
            oSelect1.SelectByValue("Intermediate");
            Thread.Sleep(1500);
            AddBtn.Click();
            Thread.Sleep(1500);


            AddNewBtn.Click();
            AddSkillTab.SendKeys(ExcelLibHelper.ReadData(3, "Skills"));
            Thread.Sleep(1500);
            SkillsLevel.Click();
            SelectElement oSelect3 = new SelectElement(SkillsLevel);
            oSelect3.SelectByValue("Beginner");
            Thread.Sleep(1500);
            AddBtn.Click();


            AddNewBtn.Click();
            AddSkillTab.SendKeys(ExcelLibHelper.ReadData(4, "Skills"));
            Thread.Sleep(1500);
            SkillsLevel.Click();

            SelectElement oSelect5 = new SelectElement(SkillsLevel);
            oSelect5.SelectByValue("Expert");
            Thread.Sleep(1500);
            AddBtn.Click();
        }
        public static void CancelSkills()
        {
            
            Thread.Sleep(1500);
            SkillsTab.Click();
            Thread.Sleep(1500);
            AddNewBtn.Click();
            Thread.Sleep(1500);
            Cancel.Click();
        }
        public static void EditSkills()
        {
            ExcelLibHelper.PopulateInCollection(@"E:\Krups\Internship\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Skills");
            Thread.Sleep(1500);
            SkillsTab.Click();
            Thread.Sleep(1500);
            EditBtn1.Click();
            Thread.Sleep(1500);
            EditTextBox1.Clear();
            EditTextBox1.SendKeys(ExcelLibHelper.ReadData(7, "Skills"));
            Thread.Sleep(1500);
            LevelTextBox1.Click();
            Thread.Sleep(1500);
            SelectElement oSelect6 = new SelectElement(LevelTextBox1);
            oSelect6.SelectByValue("Expert");
            Thread.Sleep(1500);
            UpdateBtn1.Click();
            Thread.Sleep(2500);
            
            EditBtn2.Click();
            EditTextBox2.Clear();
            Thread.Sleep(1500);
            EditTextBox2.SendKeys(ExcelLibHelper.ReadData(8, "Skills"));
            Thread.Sleep(1500);
            LevelTextBox2.Click();
            Thread.Sleep(1500);
            SelectElement oSelect7 = new SelectElement(LevelTextBox2);
            oSelect7.SelectByValue("Intermediate");
            Thread.Sleep(1500);
            UpdateBtn2.Click();


        }
        public static void Delete()
        {
            Thread.Sleep(1500);
            SkillsTab.Click();
            Thread.Sleep(1500);
            DeleteBtn.Click();
            Thread.Sleep(1500);
            DeleteBtn.Click();
        }
    }
}

