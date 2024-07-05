using AventStack.ExtentReports;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
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
    internal class StatusFilterongrid : Base
    {
        [Test]
        public void GridStatus()
        {
            test = extent.CreateTest("Search for status Filter ");
            test.Log(Status.Info, "Started test login");
            Loginpage loginpage = new Loginpage(driver);
            Testreader Data = new Testreader();
            string username = Data.getUserName();
            string password = Data.getPassword();
            loginpage.validlogin(username, password);

            //Loginpage loginpage = new Loginpage(driver);
            //loginpage.validlogin("Admin", "admin123");


            Admin_page adminpage = new Admin_page(driver);
            adminpage.getAdminTab().Click();
            test.Log(Status.Info, "Admin button clicked");

            StatusFilter sf = new StatusFilter(driver);
            sf.StatusFiltersdropdown("Enabled");
            test.Log(Status.Info, "from dropdown Enabled  selected");

            sf.getSearchButton().Click();
            test.Log(Status.Info, "Click on Serach button");


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='oxd-text oxd-text--span']")));

            try
            {
                IWebElement noDataMessage = driver.FindElement(By.XPath("//span[contains(text(), 'No Records Found')]"));
                Assert.IsNotNull(noDataMessage, "No data found for the Status 'Enabled'.");
                test.Log(Status.Info, "No records found for the status 'Enabled'. Assertion passed.");
            }
            catch (NoSuchElementException)
            {
                IList<IWebElement> rows = driver.FindElements(By.XPath("//div[@class='oxd-table-body']/div"));
                Assert.IsTrue(rows.Count > 0, "Data found for the status 'Enabled'.");
                test.Log(Status.Info, "Records found for the status 'Enabled'. Assertion passed.");

                
            }
        }
    }
}




       
