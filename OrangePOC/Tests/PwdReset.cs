using AventStack.ExtentReports;
using OrangePOC.Helpers;
using OrangePOC.Page_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangePOC.Tests
{
    internal class PwdReset : Base
    {
        [Test]
        public void PassReset()
        {
            test = extent.CreateTest("Add AdminLogin ");
            test.Log(Status.Info, "Started test login");
            Loginpage loginpage = new Loginpage(driver);
            Testreader Data = new Testreader();
            string username = Data.getUserName();
            string password = Data.getPassword();
            loginpage.validlogin(username, password);

            test.Log(Status.Info, "Usermanagement tab");
            Admin_page adminpage = new Admin_page(driver);
            adminpage.getAdminTab().Click();
            test.Log(Status.Info, "Admin button clicked");

            Reset r = new Reset(driver);
            r.Reset1("sravani456", "rest@123", "rest@123");

            //Assert.Pass("pwd reset Successfully ");


            loginpage.Logout();
            test.Log(Status.Info, "Logged out");

            // Login with new password
            loginpage.validlogin("sravani456", "rest@123");
            test.Log(Status.Info, "Logged in with new password");

            Assert.IsTrue(loginpage.IsLoginSuccessful(), "Invalid credentials");


        }
    }
}