using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Amphibian_WPF.Core
{
    public class RelatedIssue
    {
        private IssueSingle issue;
        public IssueSingle Issue { get { return issue; } set { issue = value; } }
        private String relationType;
        public String RelationType { get { return relationType; } set { relationType = value; } }

        public RelatedIssue(IssueSingle i, String rel) { this.Issue = i; this.RelationType = rel; }
    }
}
