using OrangePOC.Helpers;
using OrangePOC.Page_Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using AventStack.ExtentReports;
using OpenQA.Selenium.Internal;


namespace OrangePOC.Tests
{
    internal class Adminuser : Base
    {

        [Test]
        public void Addscreen()
        {
            test = extent.CreateTest("Add AdminLogin ");
            test.Log(Status.Info, "Started test login");
            Loginpage loginpage = new Loginpage(driver);
            Testreader Data = new Testreader();
            string username = Data.getUserName();
            string password = Data.getPassword();
            loginpage.validlogin(username, password);


            //Loginpage loginpage = new Loginpage(driver);
            //loginpage.validlogin("Admin", "admin123");

            //loginpage.getUsername().SendKeys("Admin");
            //test.Log(Status.Info, "userName");
            //loginpage.getPassWord().SendKeys("admin123");
            //test.Log(Status.Info, "Password");
            //loginpage.getSubmit().Click();

            test.Log(Status.Info, "Usermanagement tab");
            Admin_page adminpage = new Admin_page(driver);
            adminpage.getAdminTab().Click();
            test.Log(Status.Info, "Admin button clicked");

            
            adminpage.getAddUser().Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
       
            test.Log(Status.Info, "Add user button clicked");

            //ENter UserRole dropdown
           
            adminpage.SelectUserRole("Admin");
           test.Log(Status.Info, "from dropdown admin selected");

            //ENter Employeenamefield  dropdown
          
            adminpage.Employeenamefield("Rahul  Das");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            adminpage.SelectFirstSuggestion();
            test.Log(Status.Info, " Rahul is input from search dropdown RahulDas selected");

            //ENter Status dropdown
           
            adminpage.Statusdropdown("Enabled"); 
            test.Log(Status.Info, "from dropdown Enabled  selected");

            //ENter Username 
           
            adminpage.getusernameTAB().SendKeys("Sravani456");
            test.Log(Status.Info, "Enter value in USername Tab");

            //ENter Password 
         
            adminpage.getpasswordTAB().SendKeys("Sravani123");
            test.Log(Status.Info, "Enter value in Password Tab");

            //Enter Confirm password
          ;
            adminpage.getconfirmpasswordTAB().SendKeys("Sravani123");
            test.Log(Status.Info, "Enter value in Confirm Password Tab");

            //click on save button
            
            adminpage.getSavebutton().Click();
            test.Log(Status.Info, "Save button click");

            Assert.Pass("Successfully saved");












        }
    }


}














