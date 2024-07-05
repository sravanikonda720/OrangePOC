
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangePOC.Page_Objects
{
    internal class Reset
    {

        private IWebDriver driver;
        public Reset(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        //[FindsBy(How = How.XPath, Using = "(//span[@class='oxd-text oxd-text--span oxd-main-menu-item--name'])[1]")]
        //private IWebElement admintab;

        //[FindsBy(How = How.XPath, Using = "//div[@class='oxd-form-row']/div/div[1]/div/div[2]/child::input")]
        //private IWebElement UsernameFilter;
        [FindsBy(How = How.XPath, Using = "(//input[@class='oxd-input oxd-input--active'])[2]")]
        private IWebElement userSearch;
        //[FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-form-actions']/button[2]")]
        private IWebElement searchButton;
        [FindsBy(How = How.XPath, Using = "(//button[@class='oxd-icon-button oxd-table-cell-action-space'])[2]")]
        private IWebElement editicon;
        [FindsBy(How = How.XPath, Using = "//span[@class='oxd-checkbox-input oxd-checkbox-input--active --label-right oxd-checkbox-input']")]
        private IWebElement passwordCheckbox;
        [FindsBy(How = How.XPath, Using = "(//input[@type='password'])[1]")]
        private IWebElement passwordtab;
        [FindsBy(How = How.XPath, Using = "(//input[@type='password'])[2]")]
        private IWebElement confirmpasswordtab;
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement savebutton;

       

        public void Reset1(string pwdmodifyuser, string NewPwd, string cnfnewpassword)
        {
            //admintab.Click();
            userSearch.SendKeys(pwdmodifyuser);
            searchButton.Click();
            editicon.Click();
            passwordCheckbox.Click();
            passwordtab.SendKeys(NewPwd);
            confirmpasswordtab.SendKeys(cnfnewpassword);
            savebutton.Click();
        }

       

    }
}