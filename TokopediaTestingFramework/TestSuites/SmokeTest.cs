using NUnit.Framework;
using TokopediaTestingFramework.Configuration;
using TokopediaTestingFramework.Pages;

namespace TokopediaTestingFramework
{
    [TestFixture]
    public class SmokeTest
    {
        /// <summary>
        /// Test the home page
        /// </summary>
        [Test]
        public void CanGoToHomePage()
        {

            // Check if the browser title contains keyword
            // Set the title keywords in Constants.cs file
            Assert.IsTrue(Browser.chromeDriver.Title.Contains(Constants.Url.browserTitle));

        }

        /// <summary>
        /// To test if user can log in using existing account
        /// Set the credential in Configuration/Constants.cs
        /// </summary>
        [Test]
        public void CanLogInAsRegisteredUser()
        {

            // Click the login button
            GetPageOf.TopNavigation.EnterLogInPopUp();

            // Set the email and password using valid account
            GetPageOf.Login.LogInAsRegisteredUser();

            // Check if user successfully login
            Assert.IsTrue(GetPageOf.TopNavigation.IsLoggedIn());

        }

        //[Test]
        //public void CanLogInAsLastUser()
        //{

        //}

        //[TearDown]
        //public static void TearDown()
        //{

        //}
    }
}
