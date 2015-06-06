using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace Amphibian_WPF
{
    /// <summary>
    /// Interaction logic for MenuControls.xaml
    /// </summary>
    
    public partial class MenuControls : UserControl
    {
        public String Time { get { return tbTime.Text; } set { tbTime.Text = value; } }
        public MenuControls()
        {
            InitializeComponent();
        }

        private void openHelp(object sender, RoutedEventArgs e)
        {
           /* Process wordProcess = new Process();
            wordProcess.StartInfo.FileName = System.Diagnostics.Process.Start(Application.StartupPath + "\\Info.docx");
            wordProcess.StartInfo.UseShellExecute = true;
            wordProcess.Start();*/
        }
    }
}
