using NUnit.Framework;

namespace lab5.Tests
{
    [TestFixture]
    class Tests
    {
        private Steps.Steps steps = new Steps.Steps();
        private const string FROM = "NYC";
        private const string TO = "BLI";
        private const string NUMBEROFPASSANGERS = "2";
        private const string DEPARTDATE = "12/10/2017";
        private const string RETURNDATE = "12/18/2017";
        private const string TIMEOFDAY = "All day";
        private const string TYPEPASSANGERS = "Adult (16-64)";


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
            steps.SearchCaseOne(FROM, TO, NUMBEROFPASSANGERS, DEPARTDATE, RETURNDATE);
        }

        [Test]
        public void TestCaseFive()
        {
            steps.SearchCaseFive(FROM, TO, NUMBEROFPASSANGERS, DEPARTDATE, RETURNDATE, TIMEOFDAY, TYPEPASSANGERS);
        }
    }
}
