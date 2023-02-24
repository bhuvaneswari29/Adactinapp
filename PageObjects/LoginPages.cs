using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Adactinapp.PageObjects
{
    class LoginPages
    {
        private IWebDriver driver;
        [FindsBy(How = How.Id, Using = "username")]
        [CacheLookup]
        public IWebElement uname { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        public IWebElement pwd { get; set; }

        [FindsBy(How = How.Id, Using = "login")]
        [CacheLookup]
        public IWebElement loginbtn { get; set; }

    }

    public void loginAction()
    {
        uname.SendKeys("Megha123");
        pwd.SendKeys("Megha@2001");
        loginbtn.Click();
    }
}
