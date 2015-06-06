using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amphibian_WPF.Core;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.ComponentModel;

namespace Amphibian_WPF.Shell
{
    public class IssueProxy
    {
        private IssueList project;
        [Browsable(false)]
        public IssueList Project { get { return project; } set { project = value; } }
        private Issue trackedIssue;
        [Browsable(false)]
        public Issue TrackedIssue { get { return trackedIssue; } set { trackedIssue = value; } }
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
        public void newIssue(User submitter, Boolean list)
        {
            if (list){
                IssueList tempL = new IssueList("%novalue%");
                this.TrackedIssue = tempL;
                return;
            }
            IssueSingle tempS = new IssueSingle(submitter, false, "%novalue%", "%novalue%");
            this.TrackedIssue = tempS;
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
            if (i == null) throw new ArgumentException("This is a list, there is no description");
            return i.Description; 
        }
        public List<RelatedIssue> getRelatedList()
        {
            IssueSingle i = this.TrackedIssue as IssueSingle;
            if (i == null) new List<RelatedIssue>();
            return i.RelatedList;
        }
        public String getCreationInfo()
        {
            IssueSingle i = this.TrackedIssue as IssueSingle;
            if (i == null) throw new ArgumentException("This is a list, there is no creation info");
            return "by: "+i.Creator.Name+", created on: "+i.CreationTime.ToString();
        }
        public void printIssue()
        {
            IssueSingle i = this.TrackedIssue as IssueSingle;
            if (i == null) throw new ArgumentException("This is a list, cannot print");

            PrintDocument p = new PrintDocument();
            String s = i.Name + "\n\n" + "Description:\n" + getDescription();
            p.PrintPage += delegate(object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(s, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
            };
            try
            {
                p.Print();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }
        }

    }
}
