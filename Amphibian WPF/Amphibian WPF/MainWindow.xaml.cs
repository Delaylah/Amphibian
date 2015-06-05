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
using Amphibian_WPF.Shell;
using Amphibian_WPF.GUI;
using Amphibian_WPF.Core;

namespace Amphibian_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    

    public partial class MainWindow : Window
    {
        private localInfo info=new localInfo();
        public MainWindow()
        {
            info.userList.Add(new ProjectManager("Adis","pass"));
            MainWindowForm lf = new MainWindowForm(info);
            lf.Show();
            InitializeComponent();
        }
    }
}
