using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Pages
{
    class HomePage
    {

        private const string BASE_URL = "https://www.aa.com/homePage.do?locale=en_US";
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "reservationFlightSearchForm.originAirport")]
        private IWebElement inputFrom;

        [FindsBy(How = How.Id, Using = "reservationFlightSearchForm.destinationAirport")]
        private IWebElement inputTo;

        [FindsBy(How = How.Name, Using = "adultOrSeniorPassengerCount")]
        private IWebElement selectNumberList;

        [FindsBy(How = How.Id, Using = "aa-leavingOn")]
        private IWebElement inputDepart;

        [FindsBy(How = How.Id, Using = "aa-returningFrom")]
        private IWebElement inputReturn;

        [FindsBy(How = How.Id, Using = "flightSearchForm.button.vacationSubmit")]
        private IWebElement buttonSearch;

        [FindsBy(How = How.Id, Using = "cookieConsentAccept")]
        private IWebElement buttonAcceptCookie;

        
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void ClickOnSearchButton()
        {
            buttonSearch.Click();
        }

        public void Search(string from, string to, string numberOfPassangers, string departDate, string returnDate)
        {
            ClearValue();
            inputFrom.SendKeys(from);
            inputTo.SendKeys(to);
            selectNumberList.SendKeys(numberOfPassangers);
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
