using NUnit.Framework;

namespace TokopediaTestingFramework
{
    /// <summary>
    /// Class contains the setup fixture
    /// This will be run before the test started and when test ended
    /// </summary>
    [SetUpFixture]
    public class BaseTest
    {
        [OneTimeSetUp]
        public void StartTest()
        {
            // Go to the base URL (Tokopedia website)
            Browser.Initialize();
        }

        [OneTimeTearDown]
        public void EndTest()
        {
            // End test by close the browser driver
            Browser.Close();
        }
    }
}
