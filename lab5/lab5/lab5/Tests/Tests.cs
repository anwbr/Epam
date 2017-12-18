using NUnit.Framework;
using System.Collections.Generic;

namespace lab5.Tests
{
    [TestFixture]
    class Tests
    {
        private Steps.Steps steps = new Steps.Steps(); 
        private string FROM = string.Empty;
        private string TO = string.Empty;
        private string NUMBEROFPASSANGERS = string.Empty;
        private string DEPARTDATE = string.Empty;
        private string RETURNDATE = string.Empty;
        private string AIRCLASS = string.Empty;
        private string COUNTROOM = string.Empty;
        private IList<string> DATE;
        private IList<string> TIMEOFDAY;
        private IList<string> TYPEPASSANGERS;


        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void TestCaseOne()
        {
            FROM = "NYC";
            TO = "JAN";
            NUMBEROFPASSANGERS = "1";
            DEPARTDATE = "12/20/2017";
            RETURNDATE = "12/24/2017";
            steps.SearchCaseOne(FROM, TO, NUMBEROFPASSANGERS, DEPARTDATE, RETURNDATE);
        }

        [Test]
        public void TestCaseTwo()
        {
            FROM = "NYC";
            TO = "NYC";
            NUMBEROFPASSANGERS = "1";
            DEPARTDATE = "12/20/2017";
            RETURNDATE = "12/24/2017";
            steps.SearchCaseTwo(FROM, TO, NUMBEROFPASSANGERS, DEPARTDATE, RETURNDATE);
        }

        [Test]
        public void TestCaseThree()
        {
            FROM = "NYC";
            TO = "JAN";
            NUMBEROFPASSANGERS = "1";
            DEPARTDATE = "12/20/2017";
            steps.SearchCaseThree(FROM, TO, NUMBEROFPASSANGERS, DEPARTDATE);
        }

        [Test]
        public void TestCaseFour()
        {
            FROM = "NYC";
            TO = "JAN";
            NUMBEROFPASSANGERS = "6";
            DEPARTDATE = "12/20/2017";
            RETURNDATE = "12/24/2017";
            steps.SearchCaseFour(FROM, TO, NUMBEROFPASSANGERS, DEPARTDATE, RETURNDATE);
        }

        [Test]
        public void TestCaseFive()
        {
            FROM = "BLI";
            TO = "JAN";
            NUMBEROFPASSANGERS = "2";
            DATE = new List<string>() { "12/20/2017", "12/24/2017" };
            TIMEOFDAY = new List<string>() { "3:00 pm", "5:00 pm" };
            TYPEPASSANGERS = new List<string>() { "12" };
            steps.SearchCaseFive(FROM, TO, NUMBEROFPASSANGERS, DATE, TIMEOFDAY, TYPEPASSANGERS);
        }

        [Test]
        public void TestCaseSix()
        {
            FROM = "BLI";
            TO = "JAN";
            NUMBEROFPASSANGERS = "1";
            DATE = new List<string>() { "12/20/2017", "12/24/2017" };
            TIMEOFDAY = new List<string>() { "3:00 pm", "5:00 pm" };
            TYPEPASSANGERS = new List<string>() { "5" };
            steps.SearchCaseSix(FROM, TO, NUMBEROFPASSANGERS, DATE, TIMEOFDAY, TYPEPASSANGERS);
        }

        [Test]
        public void TestCaseSeven()
        {
            FROM = "BLI";
            TO = "JAN";
            NUMBEROFPASSANGERS = "1";
            DATE = new List<string>() { "12/20/2017", "12/24/2017" };
            TIMEOFDAY = new List<string>() { "3:00 pm", "5:00 pm" };
            steps.SearchCaseSeven(FROM, TO, NUMBEROFPASSANGERS, DATE, TIMEOFDAY, TYPEPASSANGERS);
        }

        [Test]
        public void TestCaseEight()
        {
            FROM = "BLI";
            TO = "JAN";
            NUMBEROFPASSANGERS = "1";
            DATE = new List<string>() { "12/20/2017", "12/24/2017" };
            TIMEOFDAY = new List<string>() { "3:00 pm", "5:00 pm" };
            AIRCLASS = "Business";
            steps.SearchCaseEight(FROM, TO, NUMBEROFPASSANGERS, DATE, TIMEOFDAY, TYPEPASSANGERS, AIRCLASS);
        }

        [Test]
        public void TestCaseNine()
        {
            FROM = "BLI";
            TO = "JAN";
            NUMBEROFPASSANGERS = "1";
            DATE = new List<string>() { "12/20/2017", "12/24/2017" };
            TIMEOFDAY = new List<string>() { "3:00 pm", "5:00 pm" };
            AIRCLASS = "Business";
            COUNTROOM = "3";
            steps.SearchCaseNine(FROM, TO, NUMBEROFPASSANGERS, DATE, TIMEOFDAY, TYPEPASSANGERS, AIRCLASS, COUNTROOM);
        }

        [Test]
        public void TestCaseTen()
        {
            FROM = "BLI";
            TO = "JAN";
            NUMBEROFPASSANGERS = "1";
            DATE = new List<string>() { "12/20/2017", "" };
            TIMEOFDAY = new List<string>() { "3:00 pm", "5:00 pm" };
            steps.SearchCaseTen( FROM, TO, NUMBEROFPASSANGERS, DATE, TIMEOFDAY, TYPEPASSANGERS);
        }
    }
}
