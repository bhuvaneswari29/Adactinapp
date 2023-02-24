using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;



namespace Adactinapp.PageObjects
{
    class SearchHotelPages
    {
        private IWebDriver driver;
        [FindsBy(How = How.Id, Using = "Location")]
        [CacheLookup]
        public SelectElement location { get; set; }

        [FindsBy(How = How.Id, Using = "Hotels")]
        [CacheLookup]
        public SelectElement hotels { get; set; }

        [FindsBy(How = How.Id, Using = "RoomType")]
        [CacheLookup]
        public SelectElement room { get; set; }

        [FindsBy(How = How.Id, Using = "NumberofRooms")]
        [CacheLookup]
        public SelectElement noofrooms { get; set; }

        [FindsBy(How = How.Id, Using = "datepick_in")]
        [CacheLookup] 
        public IWebElement checkin { get; set; }

        [FindsBy(How = How.Id, Using = "datepick_out")]
        [CacheLookup] 
        public IWebElement checkout { get; set; }

        [FindsBy(How = How.Id, Using = "adult_room")]
        [CacheLookup] 
        public SelectElement adultroom { get; set; }

        [FindsBy(How = How.Id, Using = "child_room")]
        [CacheLookup] public 
        SelectElement childroom { get; set; }

        [FindsBy(How = How.Id, Using = "Submit")]
        [CacheLookup] 
        public IWebElement searchbtn { get; set; }

        public SearchHotelPages(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void SearchAction()
        {
            location.SelectByIndex(2);
            hotels.SelectByIndex(2);
            room.SelectByIndex(2);
            noofrooms.SelectByIndex(2);
            checkin.SendKeys("14/02/2023");
            checkout.SendKeys("15/02/2023");
            adultroom.SelectByIndex(2);
            childroom.SelectByIndex(2);
            searchbtn.Click();
        }
    }
}
