using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amphibian_WPF.Core;
using Amphibian_WPF.Shell;

namespace Amphibian_WPF.GUI
{
    public partial class TitleControl : UserControl
    {
        public String text { get { return titleText.Text; } set { titleText.Text = value; } }
        public TitleControl()
        {
            InitializeComponent();
        }
    }
}
