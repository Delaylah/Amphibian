using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Amphibian_WPF.Core
{
    public class Issue
    {
        private Issue origin;
        [Browsable(false)]
        public Issue Origin { get { return origin; } set { origin = value; } }
        private String name;
        [Browsable(true)]
        public String Name { get { return name; } set { name = value; } }
        private List<Issue> history = new List<Issue>();
        [Browsable(false)]
        public List<Issue> Histoy { get { return history; } set { history = value; } }
        internal Issue(String name) { this.Name = name; }
        private Int32 dbID;
        [Browsable(true)]
        public Int32 databaseID { get { return dbID; } set { dbID = value; } }
        [Browsable(true)]
        public String Submitter { 
            get 
            {
                if (this is IssueSingle) return (this as IssueSingle).Creator.Name;
                return "";
            } }
        [Browsable(true)]
        public String CreatedOn
        {
            get
            {
                if (this is IssueSingle) return (this as IssueSingle).CreationTime.ToString();
                return "";
            }
        }
        [Browsable(true)]
        public String EditedOn
        {
            get
            {
                if (this is IssueSingle) return (this as IssueSingle).EditTime.ToString();
                return "";
            }
        }
    }
}
