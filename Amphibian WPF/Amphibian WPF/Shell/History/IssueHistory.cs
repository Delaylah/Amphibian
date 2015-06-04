using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amphibian_WPF.Core;

namespace Amphibian_WPF.Shell
{
    public class IssueHistory : History
    {
        private List<Issue> history = new List<Issue>();

        public List<Issue> getHistory() { return history; }
        public void setHistory(List<Issue> value) { history = value; }
        public override void clearData()
        {
            List<Issue> temp = new List<Issue>(history);
            history.Clear();
            for (Int32 i = temp.Count / 2; i <= temp.Count; i++) history.Add(temp[i]);
            base.clearData();
        }
        public override void saveData()
        {
            //save to issue table in the database
            base.saveData();
            this.clearData();
        }

        public void addItem(Issue i) { history.Add(i); }
        public void removeItem(Issue i) { history.Remove(i); }

        public IssueHistory() : base() { }
    }
}
