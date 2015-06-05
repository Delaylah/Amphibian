using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amphibian_WPF.Core;

namespace Amphibian_WPF.Shell
{
    public class CommentProxy
    {
        private Comment trackedComment;
        public Comment TrackedComment { get { return trackedComment; } set { trackedComment = value; } }
        public CommentProxy() { }
        public void newComment(Boolean priv)
        {

        }
        public String getDescription()
        {
            return this.TrackedComment.Content;
        }
        public String getCreationInfo()
        {
            return "by: " + this.TrackedComment.Owner.Name + ", created on: " + this.TrackedComment.CreationTime.ToString();
        }
    }
}
