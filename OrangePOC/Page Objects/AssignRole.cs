using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangePOC.Page_Objects
{
    internal class AssignRole
    {
        private IWebDriver driver;
        public AssignRole(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "(//input[@class='oxd-input oxd-input--active'])[2]")]
        private IWebElement userSearch;
        //[FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-form-actions']/button[2]")]
        private IWebElement searchButton;
        [FindsBy(How = How.XPath, Using = "(//button[@class='oxd-icon-button oxd-table-cell-action-space'])[2]")]
        private IWebElement editicon;

        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-select-text-input']")]
        private IWebElement DropdownUserRole;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement savebutton;

        public IWebElement getuserSearch()
        {
            return userSearch;
        }
        public IWebElement getediticon()
        {
            return editicon;
        }

        public IWebElement getsavebutton()
        { 
            return savebutton;
        
        }
        public bool IsRoleChanged()
        {
            try
            {

                IWebElement element = driver.FindElement(By.XPath("//element-indicating-successful-updated"));
                return element.Displayed;
            }

            catch (NoSuchElementException)
            {
                return false;
            }
        }






    }
}

