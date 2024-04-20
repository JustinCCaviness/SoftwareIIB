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
        public static bool last;
        public static string currentUser = null;

        public Authenticator()
        {

        }

        public static void addDelegate(Authenticate auth)
        {
            authenticate += auth;
        }

        public static void removeDelegate(Authenticate auth)
        {
            authenticate -= auth;
        }
    }
}
