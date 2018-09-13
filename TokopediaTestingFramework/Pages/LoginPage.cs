using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using TokopediaTestingFramework.Configuration;
using TokopediaTestingFramework.Configuration.UserControl;

namespace TokopediaTestingFramework.Pages
{
    public class LoginPage
    {
        /// <summary>
        /// Define all DOMs in Login module
        /// </summary>
        [FindsBy(How = How.Id, Using = Constants.LoginElements.emailAddressTxtFieldId)]
        private IWebElement emailAddressTxtField;

        [FindsBy(How = How.Id, Using = Constants.LoginElements.passwordTxtFieldId)]
        private IWebElement passwordTxtField;

        [FindsBy(How = How.XPath, Using = Constants.LoginElements.loginButtonXPath)]
        private IWebElement loginButton;

        /// <summary>
        /// Log in using valid account
        /// </summary>
        public void LogInAsRegisteredUser()
        {
            // Clear last user logged in
            UserGenerator.Initialize();

            //Log in using the user credential, set in Constants.cs file
            LogIn(UserGenerator.Generate(true));
        }

        /// <summary>
        /// Log in using last user
        /// </summary>
        public void LogInAsLastUser()
        {
            LogIn(UserGenerator.LastGeneratedUser);
        }

        /// <summary>
        /// 
        /// </summary>
        public void LogInAsNewUser()
        {
            UserGenerator.Initialize();
            LogIn(UserGenerator.Generate(false));
        }

        private void LogIn(User user)
        {
            emailAddressTxtField.SendKeys(user.EmailAddress);
            passwordTxtField.SendKeys(user.Password);

            Thread.Sleep(2000);
            loginButton.Click();
        }
    }
}
