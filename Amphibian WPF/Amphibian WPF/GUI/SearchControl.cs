using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amphibian_WPF.GUI
{
    public partial class SearchControl : UserControl
    {
        public List<String> UserList { 
            get 
            {
                List<String> retvalue = new List<String>();
                for (int i = 0; i < comboBox1.Items.Count; i++) retvalue.Add(comboBox1.Items[i].ToString());
                return retvalue;
            }
            set { comboBox1.Items.Clear(); comboBox1.Items.Add("Any User"); foreach (String s in value)comboBox1.Items.Add(s); }
        }
        public String Selected { get { return comboBox1.SelectedItem.ToString(); } }
        public String Filter { get { return textBox1.Text; } }
        public void addUser(String s){comboBox1.Items.Add(s);}
        public void remUser(String s) { comboBox1.Items.Remove(s); }
        public SearchControl()
        {
            InitializeComponent();
            comboBox1.Items.Add("Any User");
            comboBox1.SelectedIndex = 0;
        }
    }
}
