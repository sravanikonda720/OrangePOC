using AventStack.ExtentReports;
using OpenQA.Selenium.Support.UI;
using OrangePOC.Helpers;
using OrangePOC.Page_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangePOC.Tests
{
    internal class EditAssignrole : Base
    {
        [Test]
        public void EditRole()
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

            AssignRole URE = new AssignRole(driver);
            URE.getuserSearch().SendKeys("FMLName1");

            //Click on Serach Button
            Search_UsernameFilter usernameFilter = new Search_UsernameFilter(driver);
            usernameFilter.getSearchButton().Click();
            test.Log(Status.Info, "Click on Serach button");
            
           
            URE.getediticon().Click();

            adminpage.SelectUserRole("Ess");
            test.Log(Status.Info, "from dropdown admin selected");

            URE.getsavebutton().Click();


           // Assert.IsTrue(URE.IsRoleChanged(), "Updated successfully");

               // Assert.IsTrue(loginpage.IsLoginSuccessful(), "Invalid credentials");

        }
    }
}
