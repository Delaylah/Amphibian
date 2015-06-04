using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amphibian_WPF.Core;

namespace Amphibian_WPF.Shell
{
    public class UserContainer
    {
        private List<Person> allUsers = new List<Person>();
        public List<Person> AllUsers { get { return allUsers; } set { allUsers = value; } }

        public UserContainer() { }
        private String createToken(String pass) { return pass; } // any type of encryption can be used
        public void registerUser(String name, String password, String type)
        {
            password = createToken(password);
            switch (type)
            {
                case "Project Manager":
                    this.AllUsers.Add(new ProjectManager(name, password));
                    break;
                default :
                    throw new Exception("The specified user type does not exist");
            }
        }
        public String getType(String name)
        {
            return this.AllUsers.Any(x => x.Name == name).GetType().ToString();
        }
    }
}
