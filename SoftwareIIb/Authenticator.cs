using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareIIb
{
    public delegate bool Authenticate(string username, string password);

    internal class Authenticator
    {
        public static Authenticate authenticate;
        public static bool authenticated;
        public static user currentUser;

        public Authenticator()
        {

        }

        public static void addHandler(Authenticate auth)
        {
            authenticate += auth;
        }

        public static void removeHandler(Authenticate auth)
        {
            authenticate -= auth;
        }
    }
}
