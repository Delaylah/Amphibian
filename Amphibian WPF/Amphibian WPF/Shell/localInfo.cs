using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amphibian_WPF.Core;

namespace Amphibian_WPF.Shell
{
    public class localInfo
    {
        public List<Person> userList = new List<Person>();
        public Person onlineUser;
        public IssueContainer issueContainer = new IssueContainer();
        public IssueProxy openIssue = new IssueProxy("Amphibian");
        public localInfo() { }
        public void loadDB(){}
        public void registerUser(String name, String pass)
        {
            loadDB();
            if (userList.Any(x => x.Name == name)) throw new ArgumentException("Already exists");
            userList.Add(new User(name, pass));
            //save to db here
        }
        public void loginUser(String name,String pass)
        {
            loadDB();
            if (!userList.Any(x => x.Name == name && x.LoginToken == pass)) throw new ArgumentException("No such users exists");
            onlineUser=userList.First(x => x.Name == name && x.LoginToken == pass);
        }
        public void logoutUser() { onlineUser = null; }

    }
}
