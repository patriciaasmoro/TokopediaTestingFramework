using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using TokopediaTestingFramework.Configuration;
using TokopediaTestingFramework.Configuration.UserControl;

namespace TokopediaTestingFramework.Pages
{
    public class TopNavigationPage
    {

        [FindsBy(How = How.Id, Using = Constants.TopNavigationElements.loginFrameId)]
        private IWebElement loginFrame;

        [FindsBy(How = How.Id, Using = Constants.TopNavigationElements.masukButtonId)]
        private IWebElement masukButton;
        
        [FindsBy(How = How.CssSelector, Using = Constants.TopNavigationElements.profileLinkCss)]
        private IWebElement profileLink;
        
        public void EnterLogInPopUp()
        {
            masukButton.Click();
            CustomControls.SwitchFrameTo(loginFrame);
        }

        public bool IsLoggedIn()
        {
            CustomControls.SwitchPopUpTo(Constants.TopNavigationElements.userTabId);
            Thread.Sleep(2000);

            return profileLink.Text == UserGenerator.LastGeneratedUser.UserName;
        }
    }
}