using System;

namespace OpenDoorLibrary
{
    public class User
    {
        static public string username { get; set; }
        static public string role { get; set; }

        public User() { }

        public User(string name, string r = "Administrator")
        {
            username = name;
            role = r;
        }

        public void ResetUser()
        {
            username = String.Empty;
            role = String.Empty;
        }
    }
}