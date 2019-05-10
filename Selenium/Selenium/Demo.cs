using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class Demo
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\rutapo\\Desktop\\chromedriver_win32");
        }

        string[] usernames = { "rutaadmin", "admin" };
        string[] passwords = { "wavedms110rpadmin", "admin" };

        public void login(string user, string password)
        {
            driver.FindElement(By.XPath("//*[@id='Username']")).SendKeys(user);
            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys(password);           
        }
       
        [Test]
        public void test()
        {
            driver.Url = "http://dms110:85";
            login(usernames[0], passwords[0]);
            driver.FindElement(By.XPath("//*[@id='loginButton']")).Click();
        }

        [TearDown]
        public void closeBrowser()
        {
            //driver.Close();
        }
    }
}
