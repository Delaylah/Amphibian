using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Amphibian_WPF.Core
{
    public class Comment
    {
        private User owner;
        public User Owner { get { return owner; } set { owner = value; } }
        [Browsable(true)]
        public String Submitter { get { return Owner.Name; } }
        private IssueSingle owningIssue;
        public IssueSingle OwningIssue { get { return owningIssue; } set { owningIssue = value; } }
        private String content;
        [Browsable(true)]
        public String Content { get { return content; } set { content = value; } }
        private DateTime creationTime;
        public DateTime CreationTime { get { return creationTime; } set { creationTime = value; } }
        private Int32 dbID;
        [Browsable(true)]
        public Int32 databaseID { get { return dbID; } set { dbID = value; } }

        internal Comment(User owner, IssueSingle owningIssue, String content) 
        {
            this.CreationTime = DateTime.Now;
            this.Owner = owner;
            this.OwningIssue = owningIssue;
            this.Content = content;
        }
    }
}
