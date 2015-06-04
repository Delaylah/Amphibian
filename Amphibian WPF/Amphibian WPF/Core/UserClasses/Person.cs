using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amphibian_WPF.Core
{
    public class Person
    {
        private String name;
        public String Name { get { return name; } set { name = value; } }
        private String loginToken;
        public String LoginToken { get { return loginToken; } set { loginToken = value; } }
        internal Person(String name, String login) { this.Name = name; this.LoginToken = login; }
    }
}
