using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Adactinapp.PageObjects;
using SeleniumExtras.PageObjects;


namespace Adactinapp.TestCases
{
    class logintest
    {
        IWebDriver driver;
        [Test]
        public void Test()
        {
            driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";
            Console.WriteLine("Started the program");

            var loginpg = new LoginPages(driver);
            loginpg.loginAction();

            var searchpg = new SearchHotelPages(driver);
            searchpg.SearchAction();

            PageFactory.InitElements(driver, loginpg);
            loginpg.uname.SendKeys("Megha123");
            loginpg.pwd.SendKeys("Megha@2001");
            loginpg.loginbtn.Click();
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Logout")).Click();

        }
        [TearDown]
        public void Close()
        {
            Console.WriteLine("Finished execution");
            driver.Close();
        }

    }
}
