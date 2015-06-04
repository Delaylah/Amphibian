using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amphibian_WPF.Core
{
    public class IssueList : Issue
    {
        private List<Issue> subIssues = new List<Issue>();
        public List<Issue> SubIssues { get { return subIssues; } set { subIssues = value; } }
        public IssueList(String name) : base(name) { }
    }
}
