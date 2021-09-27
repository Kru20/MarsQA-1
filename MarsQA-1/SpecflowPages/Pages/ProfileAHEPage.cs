using MarsQA_1.Helpers;
using NUnit.Framework;
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
    public static class ProfileAHEPage
    {
        public static IWebElement Notification => Driver.driver.FindElement(By.XPath("/html/body/div[1]"));
        private static IWebElement EditIcon => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
        private static IWebElement Dropdown => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
       
        private static IWebElement EditIconHour => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
        private static IWebElement DropdownHour => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select"));
      
        private static IWebElement EditIconEarnTarget => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
        private static IWebElement DropdownEarnTarget => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select"));
       
        public static void AddAvaibility()
        {
            ExcelLibHelper.PopulateInCollection(@"E:\Krups\Internship\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "AHE");
            string Notification1 = "Availability updated";

            System.Threading.Thread.Sleep(1500);
            EditIcon.Click();
            System.Threading.Thread.Sleep(1500);
            Dropdown.Click();
            System.Threading.Thread.Sleep(1500);
            SelectElement oSelect = new SelectElement(Dropdown);
            //oSelect.SelectByText(ExcelLibHelper.ReadData(2, "Avaibility"));
            System.Threading.Thread.Sleep(2500);
            oSelect.SelectByValue("1");

            //Assertion
            System.Threading.Thread.Sleep(2500);
            Assert.AreEqual(Notification1, Notification.Text);
            TestContext.WriteLine("Availability Added successfully");




        }
        public static void AddHours()
        {
            ExcelLibHelper.PopulateInCollection(@"E:\Krups\Internship\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "AHE");
            string Notification1 = "Availability updated";
            System.Threading.Thread.Sleep(2500);
            EditIconHour.Click();
            System.Threading.Thread.Sleep(1500);
            DropdownHour.Click();
            System.Threading.Thread.Sleep(1500);
            SelectElement oSelect = new SelectElement(DropdownHour);
            //oSelect.SelectByText(ExcelLibHelper.ReadData(2, "Hours"));
            oSelect.SelectByValue("1");
            Thread.Sleep(2500);

            Assert.AreEqual(Notification1, Notification.Text);
            TestContext.WriteLine("Hours Added successfully");
        }
        public static void AddEarnTarget()
        {
            ExcelLibHelper.PopulateInCollection(@"E:\Krups\Internship\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "AHE");
            string Notification1 = "Availability updated";
            System.Threading.Thread.Sleep(1500);
            EditIconEarnTarget.Click();
            System.Threading.Thread.Sleep(1500);
            DropdownEarnTarget.Click();
            System.Threading.Thread.Sleep(1500);
            SelectElement oSelect = new SelectElement(DropdownEarnTarget);
            //oSelect.SelectByText(ExcelLibHelper.ReadData(2, "EarnTarget"));
            oSelect.SelectByValue("2");
            Thread.Sleep(2000);
            Assert.AreEqual(Notification1, Notification.Text);
            TestContext.WriteLine("EarnTarget Added successfully");

        }

        public static void EditAvaibility()
        {
            ExcelLibHelper.PopulateInCollection(@"E:\Krups\Internship\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "AHE");
            string Notification1 = "Availability updated";
            System.Threading.Thread.Sleep(1000);
            EditIcon.Click();
            System.Threading.Thread.Sleep(1000);
            Dropdown.Click();
            System.Threading.Thread.Sleep(1000);
            SelectElement oSelect = new SelectElement(Dropdown);
            //oSelect.SelectByText(ExcelLibHelper.ReadData(5, "Avaibility"));
            oSelect.SelectByValue("3");
            System.Threading.Thread.Sleep(1000);
            Assert.AreEqual(Notification1, Notification.Text);
            TestContext.WriteLine("Availability updated successfully");

        }
        public static void EditHours()
        {
            ExcelLibHelper.PopulateInCollection(@"E:\Krups\Internship\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "AHE");
            string Notification1 = "Availability updated";
            System.Threading.Thread.Sleep(1500);
            EditIconHour.Click();
            System.Threading.Thread.Sleep(1500);
            DropdownHour.Click();
            System.Threading.Thread.Sleep(1500);
            SelectElement oSelect = new SelectElement(DropdownHour);
            oSelect.SelectByText(ExcelLibHelper.ReadData(5, "Hours"));
            System.Threading.Thread.Sleep(1500);
            Assert.AreEqual(Notification1, Notification.Text);
            TestContext.WriteLine("Hours updated successfully");
        }
        public static void EditEarnTarget()
        {
            ExcelLibHelper.PopulateInCollection(@"E:\Krups\Internship\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "AHE");
            string Notification1 = "Availability updated";
            System.Threading.Thread.Sleep(1500);
            EditIconEarnTarget.Click();
            System.Threading.Thread.Sleep(1500);
            DropdownEarnTarget.Click();
            System.Threading.Thread.Sleep(1500);
            SelectElement oSelect = new SelectElement(DropdownEarnTarget);
            oSelect.SelectByText(ExcelLibHelper.ReadData(5, "EarnTarget"));
            System.Threading.Thread.Sleep(1500);
            Assert.AreEqual(Notification1, Notification.Text);
            TestContext.WriteLine("EarnTarget updated successfully");

        }

    }
}
