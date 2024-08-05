using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangePOC.Helpers;
using OrangePOC.Page_Objects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangePOC.Tests
{
    internal class TESTPIM:Base
    {
        [Test]
        public void TestPIM()
        {

            test = extent.CreateTest("Add AdminLogin ");
            test.Log(Status.Info, "Started test login");
            Loginpage loginpage = new Loginpage(driver);
            Testreader Data = new Testreader();
            string username = Data.getUserName();
            string password = Data.getPassword();
            loginpage.validlogin(username, password);


            

            PIM pimscreen = new PIM(driver);
            pimscreen.getpimmodule().Click();
            pimscreen.getaddbutton().Click();
            pimscreen.getfirstname().SendKeys("rest1");
            pimscreen.getlastname().SendKeys("test");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            //driver.FindElement(By.XPath("//div[@class='oxd-grid-item oxd-grid-item--gutters']/div/div[2]")).Clear();
            //  pimscreen.getEmployeeid().Clear();
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class=\"oxd-grid-item oxd-grid-item--gutters\"]//input[@class=\"oxd-input oxd-input--active\"]")));
            //pimscreen.getEmployeeid().Clear();
             pimscreen.getEmployeeid().SendKeys(Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace);

            pimscreen.getEmployeeid().SendKeys("23123");
            pimscreen.getSave().Click();
            Assert.Pass("Successfully saved");

        }
       
    }
}
