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
    internal class UserManagement
    {

        private IWebDriver driver;
        private WebDriverWait wait;
        public UserManagement(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "(//span[@class='oxd-text oxd-text--span oxd-main-menu-item--name'])[1]")]
        private IWebElement admintab;
        [FindsBy(How = How.XPath, Using = "(//input[@class='oxd-input oxd-input--active'])[2]")]
        private IWebElement userSearch;
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement searchButton;
        [FindsBy(How = How.XPath, Using = "(//button[@class='oxd-icon-button oxd-table-cell-action-space'])[2]")]
        private IWebElement edituser;

        [FindsBy(How = How.XPath, Using = "(//div[@class='oxd-select-text-input'])[2]")]
        private IWebElement changestatus;

        [FindsBy(How = How.XPath, Using = "//div[@role='listbox']//div[text()='Disabled']")]
        private IWebElement disabledOption;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement saveButton;






        public void userNameSearch(string us)
        {
            admintab.Click();
            userSearch.SendKeys(us);
            searchButton.Click();
        }
        public IWebElement getEdituser()
        {
            return edituser;
        }
        public void selectDisabledStatus()
        {
            changestatus.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(disabledOption)).Click();
        }

        public IWebElement getsaveButton()
        { return saveButton;}



    }
}