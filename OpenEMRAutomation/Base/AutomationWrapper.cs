using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Base
{
    public class AutomationWrapper
    {
        protected IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void Setup()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://demo.openemr.io/b/openemr";

        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
