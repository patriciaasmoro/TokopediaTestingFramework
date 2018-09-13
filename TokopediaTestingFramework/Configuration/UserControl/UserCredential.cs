using System;

namespace TokopediaTestingFramework.Configuration.UserControl
{
    public class UserCredential
    {

        public static string GetEmail(bool isRegisteredUser)
        {
            return isRegisteredUser ? Constants.UserCredential.userEmail : Constants.UserCredential.newEmail;
        }

        public static string GetPassword(bool isRegisteredUser)
        {

            return isRegisteredUser ? Constants.UserCredential.password : Constants.UserCredential.newPassword;
        }

        public static string GetUserName(bool isRegisteredUser)
        {
            return Constants.UserCredential.name;
        }
    }
}