using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
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
using NUnit.Framework;
using System.IO;
using AventStack.ExtentReports.Model;

namespace OrangePOC.Helpers
{
    public class Base
    {
        public IWebDriver driver;
        public ExtentReports extent;
        public ExtentTest test;


        [OneTimeSetUp]
        public void SetupReporting()
        {
            //var path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            //var actualPath = path.Substring(0, path.LastIndexOf(“bin”));
            //var projectPath = new Uri(actualPath).LocalPath;
            //Directory.CreateDirectory(projectPath.ToString() + “Reports”);
            //Directory.CreateDirectory(projectPath.ToString() + “Reports”);
            //var reportPath = projectPath + “Reports\\ExtentReport.html”;
            //var htmlReporter = new ExtentHtmlReporter(reportPath);
            //extent = new ExtentReports();
            //extent.AttachReporter(htmlReporter);

            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            String reportPath = projectDirectory + "//index.html";
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }
        [SetUp]

        public void StartBrowser()
        {
            //test = extent.CreateTest(TestContext.CurrentContext.Test.Name);

            Testreader Data = new Testreader();
            String URL = Data.getURL();

            String browserName = ConfigurationManager.AppSettings["browser"];
            InitBrowser(browserName);
            //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl(URL);
            //test.Log(Status.Info, "Browser started");

        }

        //public IWebdriver getdriver()
        //{
        //    return driver;
        //}

        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;

                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;


            }
        }

        [TearDown]
        public void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace) ? "" : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                test.Log(Status.Fail, "Test Failed: " + errorMessage);
                test.Log(Status.Fail, stacktrace);
            }
            else
            {
                test.Log(Status.Pass, "Test Passed");
            }

            //driver.Quit();
            //test.Log(Status.Info, "Browser closed");
            //extent.Flush();
        }

        //[OneTimeTearDown]
        //public void TearDownReporting()
        //{
        //    extent.Flush();
        //}


    }

   
}