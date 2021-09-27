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
    public static class EducationPage
    {
        public static IWebElement EducationTab => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
        public static IWebElement ClgName => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));

        public static IWebElement CountryName => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
        public static IWebElement Title => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));

        public static IWebElement Degree => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
        public static IWebElement PassingYear => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));

        public static IWebElement AddBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
        public static IWebElement CancelBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[2]"));

        public static IWebElement AddNewBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        public static IWebElement EditBtn1 => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[1]/i"));

        public static IWebElement ClgName1 => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[1]/div[1]/input"));

        public static IWebElement CountryName1 => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[1]/div[2]/select"));
        public static IWebElement Title1 => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[2]/div[1]/select"));

        public static IWebElement Degree1 => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[2]/div[2]/input"));
        public static IWebElement PassingYear1 => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[2]/div[3]/select"));
        public static IWebElement Update1 => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[3]/input[1]"));
        public static IWebElement DeleteBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[2]/i"));
        public static IWebElement Notification => Driver.driver.FindElement(By.XPath("/html/body/div[1]"));
        
       public static void AddEducation()
        {
            string Exp = "Education has been added";
            ExcelLibHelper.PopulateInCollection(@"E:\Krups\Internship\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Education");
            
            Thread.Sleep(2500);
            EducationTab.Click();
            Thread.Sleep(1500);
            AddNewBtn.Click();
            Thread.Sleep(1500);

            ClgName.SendKeys(ExcelLibHelper.ReadData(3, "ClgName"));
            Thread.Sleep(1500);

            CountryName.Click();
            Thread.Sleep(1500);
            SelectElement oSelect1 = new SelectElement(CountryName);
            oSelect1.SelectByValue("Brazil");
            Thread.Sleep(1500);

            //var selectedValue = oSelect1.SelectedOption.GetAttribute("country");
            //Assert.AreEqual("Brazil", selectedValue);



            Title.Click();
            Thread.Sleep(1500);
            SelectElement oselect2 = new SelectElement(Title);
            oselect2.SelectByValue("Associate");
            Thread.Sleep(1500);

            Degree.SendKeys(ExcelLibHelper.ReadData(3, "Degree"));
            Thread.Sleep(1500);

            PassingYear.Click();
            Thread.Sleep(1500);
            SelectElement oselect3 = new SelectElement(PassingYear);
            oselect3.SelectByValue("2017");
            Thread.Sleep(1500);

            AddBtn.Click();

            Thread.Sleep(2500);
            //string alertMessage = Driver.driver.SwitchTo().Alert().Text;
            //Assert.IsTrue(alertMessage.Contains("Education has been added"));
            Assert.AreEqual(Exp, Notification.Text);
            TestContext.WriteLine("Education Added successfully");
            

            Thread.Sleep(2500);

            //Second Education Add

            
            Thread.Sleep(1500);
            AddNewBtn.Click();
            Thread.Sleep(1500);
            
            
            ClgName.SendKeys(ExcelLibHelper.ReadData(4, "ClgName"));
            Thread.Sleep(1500);

            CountryName.Click();
            Thread.Sleep(1500);
            SelectElement oSelect4 = new SelectElement(CountryName);
            oSelect4.SelectByValue("Hong Kong");
            Thread.Sleep(1500);

            Title.Click();
            Thread.Sleep(1500);
            SelectElement oselect5 = new SelectElement(Title);
            oselect5.SelectByValue("BArch");
            Thread.Sleep(1500);

            Degree.SendKeys(ExcelLibHelper.ReadData(3, "Degree"));
            Thread.Sleep(1500);

            PassingYear.Click();
            Thread.Sleep(1500);
            SelectElement oselect6 = new SelectElement(PassingYear);
            oselect6.SelectByValue("2019");
            Thread.Sleep(1500);

            AddBtn.Click();

            Thread.Sleep(1500);

            Assert.AreEqual(Exp, Notification.Text);
            System.Console.WriteLine("Education added successfully");

        }

        public static void Edit()
        {
            string Notification1 = "Education as been updated";

            ExcelLibHelper.PopulateInCollection(@"E:\Krups\Internship\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Education");
            Thread.Sleep(2500);
            EducationTab.Click();
            Thread.Sleep(2500);
            EditBtn1.Click();
            Thread.Sleep(2500);
            ClgName1.Clear();
            ClgName1.SendKeys(ExcelLibHelper.ReadData(7, "ClgName"));
            Thread.Sleep(1500);

            CountryName1.Click();
            Thread.Sleep(1500);
            SelectElement oSelect1 = new SelectElement(CountryName1);
            oSelect1.SelectByValue("India");
            Thread.Sleep(1500);

            Title1.Click();
            Thread.Sleep(1500);
            SelectElement oselect2 = new SelectElement(Title1);
            oselect2.SelectByValue("M.A");
            Thread.Sleep(1500);
            Degree1.Clear();
            Degree1.SendKeys(ExcelLibHelper.ReadData(2, "Degree"));
            Thread.Sleep(1500);

            PassingYear1.Click();
            Thread.Sleep(1500);
            SelectElement oselect3 = new SelectElement(PassingYear1);
            oselect3.SelectByValue("2011");
            Thread.Sleep(1500);

            Update1.Click();
            Thread.Sleep(1500);

            Assert.AreEqual(Notification1, Notification.Text);
            TestContext.WriteLine("Education has been updated successfully");
        }
        public static void Cancle()
        {
            Thread.Sleep(1500);
            EducationTab.Click();
            Thread.Sleep(1500);
            AddNewBtn.Click();
            Thread.Sleep(1500);
            CancelBtn.Click();
        }
        public static void Delete()
        {
            string Exp1 = "Education entry successfully removed";
            Thread.Sleep(1500);
            EducationTab.Click();
            Thread.Sleep(1500);
            DeleteBtn.Click();
            Thread.Sleep(1500);
            DeleteBtn.Click();
            Thread.Sleep(1500);
            
            Assert.AreEqual(Exp1, Notification.Text);
            TestContext.WriteLine("Education Deleted successfully");
        }


    }
}
