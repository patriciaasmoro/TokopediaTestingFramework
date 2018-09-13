using OpenQA.Selenium.Support.PageObjects;

namespace TokopediaTestingFramework.Pages
{
    public static class GetPageOf
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.chromeDriver, page);
            return page;
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static TopNavigationPage TopNavigation
        {
            get { return GetPage<TopNavigationPage>(); }
        }

    }
}
