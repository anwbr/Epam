using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;

namespace lab3
{
    [TestClass]
    public class SeleniumExampleTest
    {
        private static IWebDriver webDriverChrome;
        private const string username = "Kreker";
        private const string password = "Time4Death!";
        [AssemblyInitialize]
        public static void SetUP(TestContext testContext)
        {
            try
            {
                webDriverChrome = new ChromeDriver(@"C:\Program Files\ChromeGeckoDrivers\");
            }
            catch (Exception exception)
            {
                exception.StackTrace.ToString();
            }
            
        }
        [TestMethod]
        public void TestChrome()
        {
            webDriverChrome.Navigate().GoToUrl("https://vk.com/");
            webDriverChrome.FindElement(By.Id("index_email")).SendKeys(username);
            webDriverChrome.FindElement(By.Id("index_pass")).SendKeys(password);
            webDriverChrome.FindElement(By.XPath("//button[@id='index_login_button']")).Click();
            System.Threading.Thread.Sleep(3000);
        }
        [TestCleanup]
        public void TestCloseChrome()
        {
            if (webDriverChrome != null)
                webDriverChrome.Quit();
        }
    }
}
