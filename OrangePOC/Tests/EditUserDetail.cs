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
    public class EditUserDetail : Base
    {
        [Test]
        public void EditUser()
        {
            test = extent.CreateTest("Verify login");
            test.Log(Status.Info, "Started test login");
            Loginpage loginpage = new Loginpage(driver);
            Testreader testreader = new Testreader();
            string username = testreader.getUserName();
            string password = testreader.getPassword();
            loginpage.validlogin(username, password);

            UserManagement um = new UserManagement(driver);
            um.userNameSearch("FMLName");
            um.getEdituser().Click();
            um.selectDisabledStatus();
            um.getsaveButton().Click();

            




        }
    }
}
           
           

