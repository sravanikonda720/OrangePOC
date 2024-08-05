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
    internal class PIM
    {

        private IWebDriver driver;
        private WebDriverWait wait;

        public PIM(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//a[@href='/web/index.php/pim/viewPimModule']")]
        private IWebElement pimmodule;



        //[FindsBy(How = How.XPath, Using = "//h6[linktext='PIM']")]
        //    "//span[contains(text(),'PIM')]")]
     

        [FindsBy(How = How.XPath, Using = "//div[@class='orangehrm-header-container']/button")]
        private IWebElement addbutton;//give va


        [FindsBy(How = How.Name, Using = "firstName")]
        private IWebElement firstname;//give va


        [FindsBy(How = How.Name, Using = "lastName")]
        private IWebElement lastname;//give va


        [FindsBy(How = How.XPath, Using = "//div[@class=\"oxd-grid-item oxd-grid-item--gutters\"]//input[@class=\"oxd-input oxd-input--active\"]")]

        private IWebElement Employeeid;//give va
        
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement Save;


        public IWebElement getpimmodule()//these are methods to use in testscript to perform actions 
        {
            return pimmodule;
        }

        public IWebElement getaddbutton()//these are methods to use in testscript to perform actions 
        {
            return addbutton;
        }

        public IWebElement getfirstname()//these are methods to use in testscript to perform actions 
        {
            return firstname;
        }

        public IWebElement getlastname()//these are methods to use in testscript to perform actions 
        {
            return lastname;
        }

        public IWebElement getEmployeeid()//these are methods to use in testscript to perform actions 
        {
            return Employeeid;
        }

        public IWebElement getSave()//these are methods to use in testscript to perform actions 
        {
            return Save;
        }









    }
}
