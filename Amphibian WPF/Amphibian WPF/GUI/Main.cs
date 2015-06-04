using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amphibian_WPF.Shell;
using Amphibian_WPF.Core;

namespace Amphibian_WPF
{
    public partial class Main : Form
    {
        public IssueProxy tracked = new IssueProxy("Amphibian");
        public UserContainer users = new UserContainer();
        public Main()
        {
            InitializeComponent();
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.BackColor = System.Drawing.Color.Magenta;
            users.registerUser("test", "test", "Project Manager");
            mainTextPanel.BackColor = System.Drawing.Color.Black;
            tracked.getSubIssues().Add(new IssueList("System"));
            tracked.getSubIssues().Add(new IssueList("Grphics User Interface"));
            (tracked.getSubIssues()[0] as IssueList).SubIssues.Add(new IssueList("General"));
            loadTracked();
        }
        public void loadTracked() 
        {
            String text = tracked.getName();
            focusedTitle1.TitleText = " " + text;
            foreach (Issue i in tracked.getSubIssues()) 
            {

            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void openIssue(object sender, EventArgs e)
        {

        }

        private void subIssuesRB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
