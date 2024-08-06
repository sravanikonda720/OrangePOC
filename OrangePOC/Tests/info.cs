using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
    internal class info:Base 
    {

        [Test]
            public void Testinfo()
            {

                test = extent.CreateTest("Add AdminLogin ");
                test.Log(Status.Info, "Started test login");
                Loginpage loginpage = new Loginpage(driver);
                Testreader Data = new Testreader();
                string username = Data.getUserName();
                string password = Data.getPassword();
                loginpage.validlogin(username, password);





        Myinfo infoscreen = new Myinfo(driver);
            infoscreen.getpersonaldetails().Click();
            infoscreen.getFirstname().Clear();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            
            Thread.Sleep(5000);
            //infoscreen.getFirstname().SendKeys(Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace);
            infoscreen.getFirstname().SendKeys("test");
           
   
                infoscreen.getsubmit().Click();

            String ExpectedMessage = "Successfully Updated";
            IWebElement Successmessage = driver.FindElement(By.XPath("//*[@id=\"oxd-toaster_1\"]/div/div[1]/div[2]/p[2]"));
            String Actualmessage = Successmessage.Text;
            Console.WriteLine(Actualmessage);            

            //*[@id="oxd-toaster_1"]

            Assert.AreEqual(ExpectedMessage, Actualmessage);

          

            }

        }
    }


