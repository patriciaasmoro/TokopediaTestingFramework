using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokopediaTestingFramework.Configuration
{
    public static class Constants
    {
        public static class UserCredential
        {
            
            // Set Your User Credential Here
            public const string userEmail = "hi_cia@yahoo.com";
            public const string password = "123456";
            public const string name = "Patricia";

            // Set the new user credential here
            public const string newEmail = "patricia.asmara@yahoo.com";
            public const string newPassword = "123456";
            
        }

        public static class Url
        {

            public const string baseUrl = "https://www.tokopedia.com";
            public const string browserTitle = "Tokopedia";
        }

        public static class TopNavigationElements
        {
            public const string masukButtonId = "login-ddl-link";
            public const string loginFrameId = "iframe-accounts";
            public const string userTabId = "user-tab";

            public const string profileLinkCss = "#user-profile > div > span.fw-600";
        }

        public static class LoginElements
        {
            public const string emailAddressTxtFieldId = "inputEmail";
            public const string passwordTxtFieldId = "inputPassword";

            public const string loginButtonXPath = "//button[@id='global_login_btn']";
        }

    }
}
