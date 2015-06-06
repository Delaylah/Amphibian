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
using System.Windows.Shapes;
using Amphibian_WPF.Shell;

namespace Amphibian_WPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginUser(object sender, RoutedEventArgs e)
        {
            try
            {
                localInfo.loginUser(tbUsername.Text, tbPassword.Text);
                
                mainWindow mw = new mainWindow();
                mw.Show();
                this.Close();
            }
            catch (ArgumentException ar) { statusBar.Items.Clear(); statusBar.Items.Add(ar.Message); }
            
        }

        private void registerUser(object sender, RoutedEventArgs e)
        {
            try
            {
                localInfo.registerUser(tbUsername.Text, tbPassword.Text);
            }
            catch (ArgumentException ar) { statusBar.Items.Clear(); statusBar.Items.Add(ar.Message); }
        }
    }
}
