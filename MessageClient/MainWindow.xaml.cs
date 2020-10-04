using MessageClient.Models;
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

namespace MessageClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInbox_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new InboxModel();
            if (btnInbox.IsChecked == true)
            {
                btnSent.IsChecked = false;
                btnContacts.IsChecked = false;
                btnSettings.IsChecked = false;
            }
        }

        private void btnSent_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new SentModel();
            if (btnSent.IsChecked == true)
            {
                btnInbox.IsChecked = false;
                btnContacts.IsChecked = false;
                btnSettings.IsChecked = false;
            }
        }

        private void btnContacts_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ContactsModel();
            if (btnContacts.IsChecked == true)
            {
                btnInbox.IsChecked = false;
                btnSent.IsChecked = false;
                btnSettings.IsChecked = false;
            }
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new SettingsModel();
            if (btnSettings.IsChecked == true)
            {
                btnInbox.IsChecked = false;
                btnSent.IsChecked = false;
                btnContacts.IsChecked = false;
            }
        }
    }
}
