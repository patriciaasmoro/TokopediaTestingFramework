using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace TokopediaTestingFramework.Configuration
{
    class CustomControls
    {
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextFromDDL(IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }

        public static void SwitchPopUpTo(string elementId)
        {
            WebDriverWait wait = new WebDriverWait(Browser.chromeDriver, TimeSpan.FromSeconds(10));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(elementId)));

            Actions action = new Actions(Browser.chromeDriver);
            action.MoveToElement(element).Perform();
        }

        public static void SwitchFrameTo(IWebElement loginFrame)
        {
            Browser.chromeDriver.SwitchTo().Frame(loginFrame);
        }
    }


}
