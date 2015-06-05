using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Amphibian
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public class PassedData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }

    public sealed partial class MainPage : Page
    {
        PassedData dt;

        const int i = 6;

        int[] arrayofids = new int[i] { 1, 2, 3, 4, 5, 6 };
        string[] arrayofnames = new string[i] { "Task One", "Task Two", "Task Three", "Task Four", "Task Five", "Task Six" };
        string[] arrayofdescriptions = new string[i] { "Task One Desc", "Task Two Desc", "Task Three Desc", "Task Four Desc", "Task Five Desc", "Task Six Desc" };

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            makeList();
            
        }

        public void makeList() {

            for (int x = 0; x < i; x++)
            {
                dt = new PassedData();

                dt.ID = arrayofids[x];
                dt.Name = arrayofnames[x];
                dt.Description = arrayofdescriptions[x];

                //Add the the item object into the listbox
                listBox.Items.Add(dt);
            }

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.
           
            //////HERE IS MISTERIOUS BUG BUG BUG BUG BUG //////////////////
            dt = e.Parameter as PassedData;

            makeList();

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Get the data object that represents the current selected item
            PassedData dt = (sender as Button).DataContext as PassedData;

            //Get the selected ListBoxItem container instance of the item whose marks button is pressed
            ListBoxItem pressedItem = this.listBox.ItemContainerGenerator.ContainerFromItem(dt) as ListBoxItem;

            //Checking whether that it is not null 
            if (pressedItem != null)
            {
                //Show other screen and pass data to it
                Frame.Navigate(typeof(ItemDefinition), dt);
            }
        }

    }
}
