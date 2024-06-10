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

namespace OrangePOC.Tests
{
    internal class Login : Base
    {


        [Test]
        public void Loginscreen()
        {
            test = extent.CreateTest("Verify login");
            test.Log(Status.Info, "Started test login");
            Loginpage loginpage = new Loginpage(driver);
            Testreader testreader = new Testreader();
            string username = testreader.getUserName();
            string password = testreader.getPassword();
            loginpage.validlogin(username, password);

            //loginpage.validlogin("Admin", "admin123");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h6[text()='Dashboard']")));
            test.Log(Status.Info, "Dashboard is displayed ");
            test.Log(Status.Pass, "User successfully logged into app");




        }
    }


}

