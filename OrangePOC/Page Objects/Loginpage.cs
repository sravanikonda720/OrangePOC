using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangePOC.Page_Objects
{
    internal class Loginpage
    {
        private IWebDriver driver;

        public Loginpage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement username;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement submit;

        [FindsBy(How = How.XPath, Using = "//p[@class='oxd-userdropdown-name']")]
        //"//*[@id=\"app\"]/div[1]/div[1]/header/div[1]/div[2]/ul/li/span/i')]")]
        //"//ul[@class='oxd-dropdown-menu']")]
        //"//*[@id=\"app\"]/div[1]/div[1]/header/div[1]/div[2]/ul/li/ul')]")]
        //"//*[@id=\"app\"]/div[1]/div[1]/header/div[1]/div[2]/ul/li/span/p')]")]
        private IWebElement profileIcon;

        [FindsBy(How = How.XPath, Using = "//a[@href='/web/index.php/auth/logout']")]
        //"//*[@id=\"app\"]/div[1]/div[1]/header/div[1]/div[2]/ul/li/ul/li[4]/a)]")]
        private IWebElement logoutButton;


        //[FindsBy(How = How.XPath, Using = "//h6[linktext='Dashboard']")]

        //private IWebElement dashboard;



        //[FindsBy(How = How.XPath ,Using = "//a[@href='https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index']")]
        //private IWebElement dashboard()

        public void validlogin(string user, string pass)
        {
            username.SendKeys(user);
            password.SendKeys(pass);
            submit.Click();
        }



        public IWebElement getUsername()
        {
            return username;
        }
        public IWebElement getPassWord()
        {
            return password;
        }

        public IWebElement getSubmit()
        {
            return submit;
        }

        public void Logout()
        {
            profileIcon.Click();
            logoutButton.Click();
        }
        public bool IsLoginSuccessful()
        {
            try
            {
                
                IWebElement element = driver.FindElement(By.XPath("//element-indicating-successful-login"));
                return element.Displayed;
            }

            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
