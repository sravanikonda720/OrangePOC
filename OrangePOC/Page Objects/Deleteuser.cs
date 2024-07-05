using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using SeleniumExtras.WaitHelpers;

namespace OrangePOC.Page_Objects
{
    internal class Deleteuser
    {

        private IWebDriver driver;
        private WebDriverWait wait;

        public Deleteuser(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href='/web/index.php/admin/viewAdminModule']")]
        private IWebElement admintab;
        [FindsBy(How = How.XPath, Using = "(//input[@class='oxd-input oxd-input--active'])[2]")]
        private IWebElement userSearch;
        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-form-actions']/button[2]")]
        private IWebElement searchButton;
        [FindsBy(How = How.XPath, Using = "(//span[@class='oxd-checkbox-input oxd-checkbox-input--active --label-right oxd-checkbox-input'])")]
        private IWebElement checkbox;
        [FindsBy(How = How.XPath, Using = "(//button[@type='button'][7])")]
        private IWebElement deleteUser;
        [FindsBy(How = How.XPath, Using = "(//button[@class='oxd-button oxd-button--medium oxd-button--label-danger orangehrm-button-margin'])")]

            //--"(//button[@type='button'])[10]")]
        private IWebElement confirmdeleteUser;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[2]/div[2]/div/div/button")]
        private IWebElement userdeletedbutton;


        public void UserDelete(string username)
        {
            admintab.Click();
            userSearch.SendKeys(username);
            searchButton.Click();
            checkbox.Click();
            deleteUser.Click();
            
        }

        public IWebElement getconfirmdeleteUser()
        {
          
            return confirmdeleteUser;
        }

        public IWebElement getuserdeletedbutton()
        {

            return userdeletedbutton;
        }

    }
}
