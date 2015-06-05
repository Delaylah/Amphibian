using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amphibian_WPF.Core;
using Amphibian_WPF.Shell;

namespace Amphibian_WPF.GUI
{
    public partial class IssueViewForm : Form
    {
        private Boolean expandedComments = false;
        private IssueProxy openIssue;
        public IssueViewForm(IssueProxy i)
        {
            openIssue = i;
            InitializeComponent();
            titleControl.text = " Project Amphibian";
            comments.text = " Comments";
            issueContent.Text = "Added " + openIssue.getCreationInfo() + "\n"+"\n Description: \n\n"+openIssue.getDescription();
        }

        private void closeForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void expandcomments(object sender, EventArgs e)
        {
            if (!expandedComments)
            {
                this.Height += 250;
                commentPanel.Height += 250;
            }
            else 
            {
                this.Height -= 250;
                commentPanel.Height -= 250;
            }
            expandedComments = !expandedComments;
        }
    }
}
