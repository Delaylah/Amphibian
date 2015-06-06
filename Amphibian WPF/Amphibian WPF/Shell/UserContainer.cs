using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amphibian_WPF.Core;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Amphibian_WPF.Shell
{
    public static class UserContainer
    {
        //public static List<Person> allUsers = new List<Person>();
        public static BindingList<Person> allUsers = new BindingList<Person>();

        private static String createToken(String pass) { return pass; } // any type of encryption can be used
        public static String getType(String name)
        {
            return allUsers.Any(x => x.Name == name).GetType().ToString();
        }
    }
}
