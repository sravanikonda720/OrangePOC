using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V123.Debugger;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;

namespace OrangePOC.Page_Objects
{
    internal class Search_UsernameFilter
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public Search_UsernameFilter(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = 
            //"//input[@class='oxd-input oxd-input--active'])[2]")]
            "//div[@class='oxd-form-row']/div/div[1]/div/div[2]/child::input")]
        private IWebElement UsernameFilter;

        [FindsBy(How =How.XPath,Using = "//div[@class='oxd-form-actions']/button[2]")]
        private IWebElement SearchButton;




        public IWebElement getUsernameFilter()
        {
            return UsernameFilter;
        }

        public IWebElement getSearchButton()
        {
            return SearchButton;
        }


       
            }

        }












