using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Pages
{
    class FlightsPage
    {
        private const string BASE_URL = "https://www.aavacations.com/advanced-search.asp";
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "flight-hotel_from_city")]
        private IWebElement inputFrom;

        [FindsBy(How = How.Id, Using = "flight-hotel_to_city")]
        private IWebElement inputTo;

        [FindsBy(How = How.Id, Using = "flight-hotel_from_date")]
        private IWebElement inputDepart;

        [FindsBy(How = How.Id, Using = "flight-hotel_from_time")]
        private IWebElement inputTimeDepart;

        [FindsBy(How = How.Id, Using = "flight-hotel_to_date")]
        private IWebElement inputReturn;

        [FindsBy(How = How.Id, Using = "flight-hotel_to_time")]
        private IWebElement inputTimeReturn;

        [FindsBy(How = How.Id, Using = "flight-hotel_serviceClass")] 
        private IWebElement inputOptionClass;

        [FindsBy(How = How.Name, Using = "room1-adults")]
        private IWebElement numberPassengers;

        [FindsBy(How = How.Name, Using = "room1-children")]
        private IWebElement numberChildren;

        [FindsBy(How = How.Id, Using = "searchButton")]
        private IWebElement buttonSearch;

        [FindsBy(How = How.Name, Using = "flight-hotel_rooms")]
        private IWebElement countRooms;

        public FlightsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void Search(string from, string to, string numberOfPassangers, IList<string> date, IList<string> timeOfDay, IList<string> typePassangers)
        {
            ClearValue();
            inputFrom.SendKeys(from);
            inputTo.SendKeys(to);
            inputDepart.SendKeys(date[0]);
            inputTimeDepart.SendKeys(timeOfDay[0]);
            inputReturn.SendKeys(date[1]);
            inputTimeReturn.SendKeys(timeOfDay[1]);
            numberPassengers.SendKeys(numberOfPassangers);
            ChooseChildren(typePassangers);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", buttonSearch);
        }

        public void SearchWithClass(string from, string to, string numberOfPassangers, IList<string> date, IList<string> timeOfDay, IList<string> typePassangers, string airClass)
        {
            ClearValue();
            inputFrom.SendKeys(from);
            inputTo.SendKeys(to);
            inputDepart.SendKeys(date[0]);
            inputOptionClass.SendKeys(airClass);
            inputTimeDepart.SendKeys(timeOfDay[0]);
            inputReturn.SendKeys(date[1]);
            inputTimeReturn.SendKeys(timeOfDay[1]);
            numberPassengers.SendKeys(numberOfPassangers);
            ChooseChildren(typePassangers);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", buttonSearch);
        }

        public void SearchWithClassAndRooms(string from, string to, string numberOfPassangers, IList<string> date, IList<string> timeOfDay, IList<string> typePassangers, string airClass, string countRoom)
        {
            ClearValue();
            inputFrom.SendKeys(from);
            inputTo.SendKeys(to);
            inputDepart.SendKeys(date[0]);
            inputOptionClass.SendKeys(airClass);
            inputTimeDepart.SendKeys(timeOfDay[0]);
            inputReturn.SendKeys(date[1]);
            inputTimeReturn.SendKeys(timeOfDay[1]);
            numberPassengers.SendKeys(numberOfPassangers);
            countRooms.SendKeys(countRoom);
            ChooseChildren(typePassangers);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", buttonSearch);
        }

        public void ChooseChildren(IList<string> typePassangers)
        {
            if (typePassangers != null)
            {
                if (typePassangers.Count != 0)
                {
                    numberChildren.SendKeys(typePassangers.Count.ToString());
                    for (int i = 1; i <= typePassangers.Count; i++)
                    {
                        driver.FindElement(By.Id("room1-children-age" + i)).SendKeys(typePassangers[i - 1]);
                    }
                }
            }
        }

        public void ClearValue()
        {
            inputFrom.Clear();
            inputDepart.Clear();
            inputReturn.Clear();
        }
    }
}
