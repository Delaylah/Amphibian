using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amphibian_WPF.Core;

namespace Amphibian_WPF.Shell
{
    public class CommentHistory : History
    {
        private List<Comment> history = new List<Comment>();

        public List<Comment> getHistory() { return history; }
        public void setHistory(List<Comment> value) { history = value; }
        public override void clearData()
        {
            List<Comment> temp = new List<Comment>(history);
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

        public void addItem(Comment i) { history.Add(i); }
        public void removeItem(Comment i) { history.Remove(i); }

        public CommentHistory() : base() { }
    }
}