using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System.Threading;

namespace MarsQA_1.Pages
{
    public static class SignIn
    {
        private static IWebElement SignInBtn => Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("//INPUT[@type='password']"));
        private static IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
        //private static IWebElement ProfileBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
        public static void SigninStep()
        {
            Driver.NavigateUrl();
            SignInBtn.Click();
            Email.SendKeys(ExcelLibHelper.ReadData(2, "username"));
            Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            LoginBtn.Click();
            
            
        }
        //public static void Login()
        //{
        //    Driver.NavigateUrl();

        //    //Enter Url
        //    Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();

        //    //Enter Username
        //    Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("");

        //    //Enter password
        //    Driver.driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("");

        //    //Click on Login Button
        //    Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();

        //}
    }
}