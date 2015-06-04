using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amphibian_WPF.Core;

namespace Amphibian_WPF.Shell
{
    public class IssueProxy
    {
        private IssueList project;
        public IssueList Project { get { return project; } set { project = value; } }
        private Issue trackedIssue;
        public Issue TrackedIssue { get { return trackedIssue; } set { trackedIssue = value; } }
        public String getName() { return this.TrackedIssue.Name; }
        public IssueProxy(String name)
        {
            if (name == "") return;
            this.TrackedIssue = new IssueList(name);
            this.Project = this.TrackedIssue as IssueList;
        }
        public List<Issue> getSubIssues() 
        {
            IssueList i = this.TrackedIssue as IssueList;
            if (i == null) return new List<Issue>();
            return i.SubIssues;
        }
        public void newIssue(Boolean list)
        {
            if (list){
                //gui for list creation
                return;
            }
            //gui for single issue creation
            return;
        }
        public void addRelated(IssueContainer allIssues, Int32 id, String relationType) 
        {
            IssueSingle i = this.TrackedIssue as IssueSingle;
            if (i == null) return;
            i.RelatedList.Add(new RelatedIssue(allIssues.AllIssues[id],relationType));
            switch (relationType)
            {
                case "SubTask":
                    relationType = "Parent";
                    break;
                case "Duplicates":
                    relationType = "Duplicated by";
                    break;
                case "Copied To":
                    relationType = "Copied From";
                    break;
                case "Parent":
                    relationType = "SubTask";
                    break;
                case "Duplicated by":
                    relationType = "Duplicates";
                    break;
                case "Copied From":
                    relationType = "Copied To";
                    break;
                default :
                    break;
            }
            allIssues.AllIssues[id].RelatedList.Add(new RelatedIssue(i, relationType));
        }
        public void removeRelated(IssueContainer allIssues, Int32 id)
        {
            IssueSingle i = this.TrackedIssue as IssueSingle;
            if (i == null) return;
            allIssues.AllIssues[id].RelatedList.RemoveAll(x => x.Issue == i);
            i.RelatedList.RemoveAll(x => x.Issue == allIssues.AllIssues[id]);
        }
        public String getDescription() 
        {
            IssueSingle i = this.TrackedIssue as IssueSingle;
            if (i == null) return "This is a list, there is no description";
            return i.Description; 
        }
        public List<RelatedIssue> getRelatedList()
        {
            IssueSingle i = this.TrackedIssue as IssueSingle;
            if (i == null) new List<RelatedIssue>();
            return i.RelatedList;
        }
    }
}
