using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.OpenEMRAutomation
{
    public class LogiUITest
    {
        [Test]
        public void ValidateTitleTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demo.openemr.io/b/openemr";
            string actualTitle=driver.Title;
            Assert.AreEqual("OpenEMR Login",actualTitle);
        }
    }
}
