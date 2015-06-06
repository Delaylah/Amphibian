using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Amphibian_WPF.Core;

namespace Amphibian_WPF.Shell
{
    public static class localInfo
    {
        public static List<String> clocks = new List<String>();
        private static Thread clockThread = new Thread(new ThreadStart(updateTimes));
        public static Person onlineUser;
        public static IssueContainer issueContainer = new IssueContainer();
        public static IssueProxy openIssue = new IssueProxy("Amphibian");
        public static void loadDB(){}
        private static String hashPass(String s) { return s; } //Ovdje se moze implementirati bilo koji hasher za sifru
        public static void registerUser(String name, String pass)
        {
            loadDB();
            if (UserContainer.allUsers.Any(x => x.Name == name)) throw new ArgumentException("Already exists");
            UserContainer.allUsers.Add(new User(name, hashPass(pass)));
            throw new ArgumentException("Done, you can now login");
        }
        public static void loginUser(String name,String pass)
        {
            loadDB();
            if (!UserContainer.allUsers.Any(x => x.Name == name && x.LoginToken == hashPass(pass))) throw new ArgumentException("No such users exists");
            onlineUser = UserContainer.allUsers.First(x => x.Name == name && x.LoginToken == hashPass(pass));
            
            clockThread.Start();
        }
        private static void updateTimes()
        {
            while (true)
                for (Int32 i = 0; i < clocks.Count;i++ ) clocks[i] = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        }
        public static void logoutUser() { onlineUser = null; clockThread.Abort(); }
    }
}
