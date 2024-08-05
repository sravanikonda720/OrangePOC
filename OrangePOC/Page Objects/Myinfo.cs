using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangePOC.Page_Objects
{
    internal class Myinfo
    {

            private IWebDriver driver;
            private WebDriverWait wait;

            public Myinfo(IWebDriver driver)
            {
                this.driver = driver;
                this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                PageFactory.InitElements(driver, this);
            }


            [FindsBy(How = How.XPath, Using = "//a[@href='/web/index.php/pim/viewMyDetails']")]
            private IWebElement personaldetails  ;

        [FindsBy(How = How.Name, Using = "firstName")]
        private IWebElement Firstname;

        [FindsBy(How = How.Name, Using = "lastName")]
        private IWebElement lastName;


        [FindsBy(How = How.XPath, Using = "//button[@type='submit'][1]")]
        private IWebElement submit;


        public IWebElement getpersonaldetails()//these are methods to use in testscript to perform actions 
        {
            return personaldetails;
        }

     

        public IWebElement getFirstname()//these are methods to use in testscript to perform actions 
        {
            return Firstname;
        }

        public IWebElement getlastName()//these are methods to use in testscript to perform actions 
        {
            return lastName;
        }

        public IWebElement getsubmit()//these are methods to use in testscript to perform actions 
        {
            return submit;
        }

    }
}
