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
    public partial class FocusedTitle : UserControl
    {
        public String TitleText { get { return title.Text; } set { title.Text = value; } }
        public FocusedTitle()
        {
            InitializeComponent();
            title.BackColor = System.Drawing.Color.Black;
        }
    }
}
