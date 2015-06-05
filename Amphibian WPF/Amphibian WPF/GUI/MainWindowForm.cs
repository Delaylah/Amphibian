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

namespace Amphibian_WPF.GUI
{
    public partial class MainWindowForm : Form
    {
        List<Issue> gridIssues = new List<Issue>();
        private localInfo info;
        private List<String> backtrackList = new List<String>();
        private IssueProxy issueTracker = new IssueProxy("Amphibian");
        public MainWindowForm(localInfo i)
        {
            InitializeComponent();
            info = i;
            titleControl1.text = " Amphibian";
            backtrackList.Add(" Amphibian");
            foreach (Person p in info.userList) searchControl1.addUser(p.Name);
            IssueList ilist = issueTracker.TrackedIssue as IssueList;
            ilist.SubIssues.Add(new IssueList("General"));
            ilist.SubIssues.Add(new IssueList("Gui"));

            resetDataGrid();
            
        }

        private void closeForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void runSearch(object sender, EventArgs e)
        {
            List<IssueSingle> results = searchControl1.Selected != "Any User" ? info.issueContainer.search(searchControl1.Filter, searchControl1.Selected) : info.issueContainer.search(searchControl1.Filter);
        }

        private void runNew(object sender, EventArgs e)
        {

        }
        private void resetDataGrid()
        {
            
            this.dataGridView1.Rows.Clear();
            gridIssues = issueTracker.getSubIssues();
            foreach (Issue i in gridIssues)
            {
                if (i is IssueSingle)
                {
                    IssueSingle isin = i as IssueSingle;
                    dataGridView1.Rows.Add(isin.Name, isin.Creator.Name, isin.CreationTime.ToString(), isin.EditTime.ToString());
                }
                else dataGridView1.Rows.Add(i.Name);
            }
        }

        private void updateIndex(object sender, EventArgs e)
        {
            issueTracker.TrackedIssue = gridIssues[dataGridView1.CurrentCell.RowIndex];
            resetDataGrid();
        }
    }
}
