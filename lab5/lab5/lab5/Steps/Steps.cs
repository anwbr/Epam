using OpenQA.Selenium;

namespace lab5.Steps
{
    class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void SearchCaseOne(string from, string to, string numberOfPassangers, string departDate, string returnDate)
        {
            Pages.HomePage homePage = new Pages.HomePage(driver);
            homePage.OpenPage();
            homePage.Search(from, to, numberOfPassangers, departDate, returnDate);
        }

        public void SearchCaseFive(string from, string to, string numberOfPassangers, string departDate, string returnDate, string timeOfDay, string typePassangers)
        {
            Pages.FlightsPage flightsPage = new Pages.FlightsPage(driver);
            flightsPage.OpenPage();
            flightsPage.Search(from, to, numberOfPassangers, departDate, returnDate, timeOfDay, typePassangers);
        }
    }
}
