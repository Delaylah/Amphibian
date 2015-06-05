using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amphibian_WPF.Shell;

namespace Amphibian_WPF.GUI
{
    public partial class LoginForm : Form
    {
        public String Username { get { return textBox1.Text; } set { textBox1.Text = value; } }
        public String Password { get { return textBox2.Text; } set { textBox2.Text = value; } }
        private localInfo info;
        private Boolean regMode;
        public LoginForm(localInfo li,Boolean reg)
        {
            InitializeComponent();
            info = li;
            regMode = reg;
        }

        private void closeForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkandTry(object sender, EventArgs e)
        {
            try
            {
                if (regMode == true) info.registerUser(this.Username, this.Password);
                else info.loginUser(this.Username, this.Password);
            }
            catch(ArgumentException a){statusStrip1.Items.Clear();statusStrip1.Items.Add(a.ToString());}
            this.Close();
        }

    }
}
