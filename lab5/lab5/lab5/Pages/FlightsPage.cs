using OpenQA.Selenium;
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
        private const string BASE_URL = "https://www.aa.com/booking/find-flights";
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "segments0.origin")]
        private IWebElement inputFrom;

        [FindsBy(How = How.Id, Using = "segments0.destination")]
        private IWebElement inputTo;

        [FindsBy(How = How.Name, Using = "passengerCount")]
        private IWebElement selectNumberPassengersList;

        [FindsBy(How = How.Id, Using = "passengers0.passengerType")]
        private IWebElement selectTypePassengersList;

        [FindsBy(How = How.Id, Using = "segments0.travelTime")]
        private IWebElement inputTimeofDayDepart;

        [FindsBy(How = How.Id, Using = "segments0.travelDate")]
        private IWebElement inputDepart;

        [FindsBy(How = How.Id, Using = "segments1.travelTime")]
        private IWebElement inputTimeofDayReturn;

        [FindsBy(How = How.Id, Using = "segments1.travelDate")]
        private IWebElement inputReturn;

        [FindsBy(How = How.Id, Using = "flightSearchSubmitBtn")]
        private IWebElement buttonSearch;

        [FindsBy(How = How.Id, Using = "cookieConsentAccept")]
        private IWebElement buttonAcceptCookie;


        public FlightsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void Search(string from, string to, string numberOfPassangers, string departDate, string returnDate, string timeOfDay, string typePassangers)
        {
            ClearValue();
            inputFrom.SendKeys(from);
            inputTo.SendKeys(to);
            selectNumberPassengersList.SendKeys(numberOfPassangers);
            selectTypePassengersList.SendKeys(typePassangers);
            inputTimeofDayReturn.SendKeys(timeOfDay);
            inputTimeofDayDepart.SendKeys(timeOfDay);
            inputDepart.SendKeys(departDate);
            inputReturn.SendKeys(returnDate);
            buttonSearch.Click();
            System.Threading.Thread.Sleep(13000);
        }

        public void ClearValue()
        {
            buttonAcceptCookie.Click();
            inputFrom.Clear();
            inputDepart.Clear();
            inputReturn.Clear();
        }
    }
}
