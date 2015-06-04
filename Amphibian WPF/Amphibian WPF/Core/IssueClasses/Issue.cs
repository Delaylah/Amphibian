using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amphibian_WPF.Core
{
    public class Issue
    {
        private Issue origin;
        public Issue Origin { get { return origin; } set { origin = value; } }
        private String name;
        public String Name { get { return name; } set { name = value; } }
        private List<Issue> history = new List<Issue>();
        public List<Issue> Histoy { get { return history; } set { history = value; } }
        internal Issue(String name) { this.Name = name; }
    }
}
