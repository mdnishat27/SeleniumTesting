using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SeleniumTesting
{
    [TestFixture]
    class ITesting
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void test01()
        {
            driver.Url = "https://elp.duetbd.org/";
            string user = "username";
            string pass = "password";

            IWebElement login = driver.FindElement(By.XPath("/html/body/nav/div/ul/li[2]/div/span/a"));
            login.Click();

            IWebElement username = driver.FindElement(By.Id("username"));
            username.SendKeys(user);

            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys(pass);

            IWebElement loginbtn = driver.FindElement(By.Id("loginbtn"));
            loginbtn.Click();

            IWebElement course = driver.FindElement(By.XPath("//div[@id='nav-drawer']/nav/ul/li[6]/a/div/div/span[2]"));
            course.Click();

            IWebElement dropdown = driver.FindElement(By.Id("action-menu-toggle-1"));
            dropdown.Click();

            IWebElement logout = driver.FindElement(By.Id("actionmenuaction-6"));
            logout.Click();
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }


    }
}
