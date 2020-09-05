using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkAPI
{
    public class JsonMirrors
    {
        public class User
        {
            public struct NameAndPassword
            {
                public string UserName { get; set; }
                public string UserPassword { get; set; }
            }

            public static NameAndPassword FormatNameAndPassword(string name, string password)
            {
                return new NameAndPassword { UserName = name, UserPassword = password };
            }

            public static NameAndPassword FormatNameAndPassword(NetworkAPI.User user)
            {
                return new NameAndPassword { UserName = user._name, UserPassword = user._password };
            }
        }
    }
}
