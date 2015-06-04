using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amphibian_WPF.Core
{
    public class EditableComment : Comment
    {
        private List<EditableComment> history = new List<EditableComment>();
        public List<EditableComment> History { get { return history; } set { history = value; } }
        private Boolean priv;
        public Boolean Private { get { return priv; } set { priv = value; } }

        public EditableComment(User owner, IssueSingle owningIssue, String content, Boolean priv) : base(owner, owningIssue, content) { this.Private = priv; }
    }
}
