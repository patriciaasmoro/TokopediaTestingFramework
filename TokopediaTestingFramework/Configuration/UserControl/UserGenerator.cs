using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokopediaTestingFramework.Configuration.UserControl
{
    public static class UserGenerator
    {
        public static User LastGeneratedUser;
        
        public static void Initialize()
        {
            LastGeneratedUser = null;
        }

        public static User Generate(bool isRegisteredUser)
        {
            var user = GetGeneratedUser(isRegisteredUser);            

            LastGeneratedUser = user;
            return user;
        }

        private static User GetGeneratedUser(bool isRegisteredUser)
        {
            var user = new User
            {
                EmailAddress = UserCredential.GetEmail(isRegisteredUser),
                Password = UserCredential.GetPassword(isRegisteredUser),
                UserName = UserCredential.GetUserName(isRegisteredUser)
            };

            return user;
        }
    }

    public class User
    {
        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }
    }
}
