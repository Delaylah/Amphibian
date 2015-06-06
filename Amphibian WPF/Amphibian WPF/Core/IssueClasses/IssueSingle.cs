using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Amphibian_WPF.Core
{
    public class IssueSingle : Issue
    {
        private User creator;
        public User Creator { get { return creator; } set { creator = value; } }
        private Boolean priv;
        public Boolean Private { get { return priv; } set { priv = value; } }
        private String description;
        public String Description { get { return description; } set { description = value; } }
        private DateTime creationTime;
        public DateTime CreationTime { get { return creationTime; } set { creationTime = value; } }
        private DateTime editTime;
        public DateTime EditTime { get { return editTime; } set { editTime = value; } }
        private List<RelatedIssue> relatedList = new List<RelatedIssue>();
        public List<RelatedIssue> RelatedList { get { return relatedList; } set { relatedList = value; } }
        private List<Comment> comments = new List<Comment>();
        public List<Comment> Comments { get { return comments; } set { comments = value; } }
        private String _status;
        public String Status { get { return _status; } set { Status = value; } }

        public IssueSingle(User creator, Boolean priv, String name, String description) : base(name) 
        {
            this.Creator = creator;
            this.Private = priv;
            this.Description = description;
            this.CreationTime = DateTime.Now;
            this.EditTime = DateTime.Now;
            this.Status = "Unconfirmed";
        }
    }
}
