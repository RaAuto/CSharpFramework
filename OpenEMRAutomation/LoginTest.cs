using Company.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.OpenEMRAutomation
{
    
    public class LoginTest : AutomationWrapper
    {
        [Test]
        [TestCase("admin","pass", "English (Indian)", "OpenEMR")]
        [TestCase("physician", "physician", "English (Indian)", "OpenEMR")]
        public void ValidLoginTest(string username,string password,string language,string expectedTitle)
        {
            driver.FindElement(By.Id("authUser")).SendKeys(username);
            driver.FindElement(By.Id("clearPass")).SendKeys(password);
            SelectElement SelectLanguage =new  SelectElement(driver.FindElement(By.XPath("//select[@name='languageChoice']")));
            SelectLanguage.SelectByText(language);
            driver.FindElement(By.Id("login-button")).Click();
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));
       
        }
        [Test]
        [TestCase("adm", "pa", "English (Indian)")]
        [TestCase("physic", "physic", "English (Indian)")]

        public void InValidLoginTest(string username, string password, string language)
        {
            driver.FindElement(By.Id("authUser")).SendKeys(username);
            driver.FindElement(By.Id("clearPass")).SendKeys(password);
            SelectElement SelectLanguage = new SelectElement(driver.FindElement(By.XPath("//select[@name='languageChoice']")));
            SelectLanguage.SelectByText(language);
            driver.FindElement(By.Id("login-button")).Click();
            string actualeError =driver.FindElement(By.XPath("//p[contains(text(),'Invalid')]")).Text;
            Assert.That(actualeError, Does.Contain("Invalid"));

        }
    }
}
