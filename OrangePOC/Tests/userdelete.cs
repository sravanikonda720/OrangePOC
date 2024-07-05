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
using WebDriverManager;
using AventStack.ExtentReports.Model;
using AventStack.ExtentReports;

namespace OrangePOC.Tests
{
    internal class Userdelete : Base
    {

        [Test]
        public void delete()
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

            test.Log(Status.Info, "Usermanagement tab");
            Admin_page adminpage = new Admin_page(driver);
            adminpage.getAdminTab().Click();
            test.Log(Status.Info, "Admin button clicked");

            Deleteuser dl = new Deleteuser(driver);
            dl.UserDelete("sravani123");
            dl.getconfirmdeleteUser().Click();
            dl.getuserdeletedbutton().Click();
        }     
    }
}
