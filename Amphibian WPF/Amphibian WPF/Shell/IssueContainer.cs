using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amphibian_WPF.Core;

namespace Amphibian_WPF.Shell
{
    public class IssueContainer
    {
        private List<IssueSingle> allIssues = new List<IssueSingle>();
        public List<IssueSingle> AllIssues { get { return allIssues; } set { allIssues = value; } }
        public void delIssue(IssueSingle i) { this.AllIssues.Remove(i); }
        public T search<T>(object arg)
        {
            var method = from m in GetType().GetMethods()
                         where m.Name == "search"
                               && m.GetParameters().Length == 1
                               && arg.GetType().IsAssignableFrom
                                                 (m.GetParameters()[0].GetType())
                               && m.ReturnType == typeof(T)
                         select m;

            return (T)method.Single().Invoke(this, new object[] { arg });
        }
        public List<IssueSingle> search(User u)
        {
            List<IssueSingle> retValue = allIssues.Where(x=>x.Creator==u).ToList();

            return retValue;
        }
        public List<IssueSingle> search(String filter)
        {
            List<IssueSingle> retValue = allIssues.Where(x => (x.Name + " " + x.Description).Contains(filter) == true).ToList();

            return retValue;
        }
        public List<IssueSingle> search(String filter, String u)
        {
            List<IssueSingle> retValue = allIssues.Where(x => (x.Name + " " + x.Description).Contains(filter) == true && x.Creator.Name==u).ToList();

            return retValue;
        }
        public IssueContainer() { }
    }
}
