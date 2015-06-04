using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amphibian_WPF.Core
{
    public class ProtectedComment : Comment
    {
        public ProtectedComment(User owner, IssueSingle owningIssue, String content) : base(owner, owningIssue, content) { }
    }
}
