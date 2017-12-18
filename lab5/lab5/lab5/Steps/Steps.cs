using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

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
            homePage.SearchInManyPlace(from, to, numberOfPassangers, departDate, returnDate);
            foreach (var windowHandle in driver.WindowHandles)
            {
                if (windowHandle != driver.CurrentWindowHandle)
                {
                    driver.SwitchTo().Window(windowHandle);
                    IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(By.Id("view-itinerary")));
                    Assert.IsTrue(dynamicElement.Text.Contains("Hide"));
                }
            }

        }

        public void SearchCaseTwo(string from, string to, string numberOfPassangers, string departDate, string returnDate)
        {
            Pages.HomePage homePage = new Pages.HomePage(driver);
            homePage.OpenPage();
            homePage.SearchInManyPlace(from, to, numberOfPassangers, departDate, returnDate);
            foreach (var windowHandle in driver.WindowHandles)
            {
                if (windowHandle != driver.CurrentWindowHandle)
                {
                    driver.SwitchTo().Window(windowHandle);
                    IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(By.XPath("//H3[@small=''][text()='Oops!  Something went wrong!']")));
                    Assert.IsTrue(dynamicElement.Text.Contains("Oops! Something went wrong!"));
                }
            }
        }

        public void SearchCaseThree(string from, string to, string numberOfPassangers, string departDate)
        {
            Pages.HomePage homePage = new Pages.HomePage(driver);
            homePage.OpenPage();
            homePage.SearchInOnePlace(from, to, numberOfPassangers, departDate);
            foreach (var windowHandle in driver.WindowHandles)
            {
                if (windowHandle != driver.CurrentWindowHandle)
                {
                    driver.SwitchTo().Window(windowHandle);
                    IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(By.Id("view-itinerary")));
                    Assert.IsTrue(dynamicElement.Text.Contains("Hide"));
                }
            }
        }

        public void SearchCaseFour(string from, string to, string numberOfPassangers, string departDate, string returnDate)
        {

            Pages.HomePage homePage = new Pages.HomePage(driver);
            homePage.OpenPage();
            homePage.SearchInManyPlace(from, to, numberOfPassangers, departDate, returnDate);
            foreach (var windowHandle in driver.WindowHandles)
            {
                if (windowHandle != driver.CurrentWindowHandle)
                {
                    driver.SwitchTo().Window(windowHandle);
                    IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(By.Id("view-itinerary")));
                    Assert.IsTrue(dynamicElement.Text.Contains("Hide"));
                }
            }
        }

        public void SearchCaseFive(string from, string to, string numberOfPassangers, IList<string> date, IList<string> timeOfDay, IList<string> typePassangers)
        {
            Pages.FlightsPage flightsPage = new Pages.FlightsPage(driver);
            flightsPage.OpenPage();
            flightsPage.Search(from, to, numberOfPassangers, date, timeOfDay, typePassangers);
            IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(By.Id("SearchError")));
            Assert.IsTrue(dynamicElement.Text.Contains("No flights were found for the dates"));
        }

        public void SearchCaseSix(string from, string to, string numberOfPassangers, IList<string> date, IList<string> timeOfDay, IList<string> typePassangers)
        {
            Pages.FlightsPage flightsPage = new Pages.FlightsPage(driver);
            flightsPage.OpenPage();
            flightsPage.Search(from, to, numberOfPassangers, date, timeOfDay, typePassangers);
            IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(By.Id("SearchError")));
            Assert.IsTrue(dynamicElement.Text.Contains("No flights were found for the dates"));
        }

        public void SearchCaseSeven(string from, string to, string numberOfPassangers, IList<string> date, IList<string> timeOfDay, IList<string> typePassangers)
        {
            Pages.FlightsPage flightsPage = new Pages.FlightsPage(driver);
            flightsPage.OpenPage();
            flightsPage.Search(from, to, numberOfPassangers, date, timeOfDay, typePassangers);
            IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(By.Id("SearchError")));
            Assert.IsTrue(dynamicElement.Text.Contains("No flights were found for the dates"));
        }

        public void SearchCaseEight(string from, string to, string numberOfPassangers, IList<string> date, IList<string> timeOfDay, IList<string> typePassangers, string airClass)
        {
            Pages.FlightsPage flightsPage = new Pages.FlightsPage(driver);
            flightsPage.OpenPage();
            flightsPage.SearchWithClass(from, to, numberOfPassangers, date, timeOfDay, typePassangers, airClass);
            IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(By.Id("view-itinerary")));
            Assert.IsTrue(dynamicElement.Text.Contains("Hide"));
        }

        public void SearchCaseNine(string from, string to, string numberOfPassangers, IList<string> date, IList<string> timeOfDay, IList<string> typePassangers, string airClass, string countRoom)
        {
            Pages.FlightsPage flightsPage = new Pages.FlightsPage(driver);
            flightsPage.OpenPage();
            flightsPage.SearchWithClassAndRooms(from, to, numberOfPassangers, date, timeOfDay, typePassangers, airClass, countRoom);
            IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(By.Id("SearchError")));
            Assert.IsTrue(dynamicElement.Text.Contains("No flights were found for the dates"));
        }

        public void SearchCaseTen(string from, string to, string numberOfPassangers, IList<string> date, IList<string> timeOfDay, IList<string> typePassangers)
        {
            Pages.FlightsPage flightsPage = new Pages.FlightsPage(driver);
            flightsPage.OpenPage();
            flightsPage.Search(from, to, numberOfPassangers, date, timeOfDay, typePassangers);
            IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(By.Id("SearchError")));
            Assert.IsTrue(dynamicElement.Text.Contains("Please fix the 1 issue"));
        }
    }
}
