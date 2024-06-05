using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace MyLibrary.Tests
{
    public class BaseTest
    {
        protected ExtentReports extent;
        protected ExtentTest test;

        [OneTimeSetUp]
        public void BeforeClass()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter("TestReport.html");
            extent.AttachReporter(htmlReporter);
        }

        [SetUp]
        public void BeforeTest()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = TestContext.CurrentContext.Result.StackTrace;

            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                test.Fail(stackTrace);
            }
            else if (status == NUnit.Framework.Interfaces.TestStatus.Passed)
            {
                test.Pass("Test passed");
            }
        }

        [OneTimeTearDown]
        public void AfterClass()
        {
            extent.Flush();
        }
    }
}

