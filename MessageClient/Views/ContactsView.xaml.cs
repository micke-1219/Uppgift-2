using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MessageClient.Views
{
    /// <summary>
    /// Interaction logic for ContactsView.xaml
    /// </summary>
    public partial class ContactsView : UserControl
    {
        public ContactsView()
        {
            InitializeComponent();
        }

        private void btnContact1_Click(object sender, RoutedEventArgs e)
        {
            ellipse.Fill = contactEllipse1.Fill;
            name.Text = contactName1.Text;
            if (btnContact1.IsChecked == true)
            {
                btnContact2.IsChecked = false;
                btnContact3.IsChecked = false;
                btnContact4.IsChecked = false;
                btnContact5.IsChecked = false;
                btnContact6.IsChecked = false;
                btnContact7.IsChecked = false;
                btnContact8.IsChecked = false;
                btnContact9.IsChecked = false;
                btnContact10.IsChecked = false;
            }
        }

        private void btnContact2_Click(object sender, RoutedEventArgs e)
        {
            ellipse.Fill = contactEllipse2.Fill;
            name.Text = contactName2.Text;
            if (btnContact2.IsChecked == true)
            {
                btnContact1.IsChecked = false;
                btnContact3.IsChecked = false;
                btnContact4.IsChecked = false;
                btnContact5.IsChecked = false;
                btnContact6.IsChecked = false;
                btnContact7.IsChecked = false;
                btnContact8.IsChecked = false;
                btnContact9.IsChecked = false;
                btnContact10.IsChecked = false;
            }
        }

        private void btnContact3_Click(object sender, RoutedEventArgs e)
        {
            ellipse.Fill = contactEllipse3.Fill;
            name.Text = contactName3.Text;
            if (btnContact3.IsChecked == true)
            {
                btnContact1.IsChecked = false;
                btnContact2.IsChecked = false;
                btnContact4.IsChecked = false;
                btnContact5.IsChecked = false;
                btnContact6.IsChecked = false;
                btnContact7.IsChecked = false;
                btnContact8.IsChecked = false;
                btnContact9.IsChecked = false;
                btnContact10.IsChecked = false;
            }
        }

        private void btnContact4_Click(object sender, RoutedEventArgs e)
        {
            ellipse.Fill = contactEllipse4.Fill;
            name.Text = contactName4.Text;
            if (btnContact4.IsChecked == true)
            {
                btnContact1.IsChecked = false;
                btnContact2.IsChecked = false;
                btnContact3.IsChecked = false;
                btnContact5.IsChecked = false;
                btnContact6.IsChecked = false;
                btnContact7.IsChecked = false;
                btnContact8.IsChecked = false;
                btnContact9.IsChecked = false;
                btnContact10.IsChecked = false;
            }
        }

        private void btnContact5_Click(object sender, RoutedEventArgs e)
        {
            ellipse.Fill = contactEllipse5.Fill;
            name.Text = contactName5.Text;
            if (btnContact5.IsChecked == true)
            {
                btnContact1.IsChecked = false;
                btnContact2.IsChecked = false;
                btnContact3.IsChecked = false;
                btnContact4.IsChecked = false;
                btnContact6.IsChecked = false;
                btnContact7.IsChecked = false;
                btnContact8.IsChecked = false;
                btnContact9.IsChecked = false;
                btnContact10.IsChecked = false;
            }
        }

        private void btnContact6_Click(object sender, RoutedEventArgs e)
        {
            ellipse.Fill = contactEllipse6.Fill;
            name.Text = contactName6.Text;
            if (btnContact6.IsChecked == true)
            {
                btnContact1.IsChecked = false;
                btnContact2.IsChecked = false;
                btnContact3.IsChecked = false;
                btnContact4.IsChecked = false;
                btnContact5.IsChecked = false;
                btnContact7.IsChecked = false;
                btnContact8.IsChecked = false;
                btnContact9.IsChecked = false;
                btnContact10.IsChecked = false;
            }
        }

        private void btnContact7_Click(object sender, RoutedEventArgs e)
        {
            ellipse.Fill = contactEllipse7.Fill;
            name.Text = contactName7.Text;
            if (btnContact7.IsChecked == true)
            {
                btnContact1.IsChecked = false;
                btnContact2.IsChecked = false;
                btnContact3.IsChecked = false;
                btnContact4.IsChecked = false;
                btnContact5.IsChecked = false;
                btnContact6.IsChecked = false;
                btnContact8.IsChecked = false;
                btnContact9.IsChecked = false;
                btnContact10.IsChecked = false;
            }
        }

        private void btnContact8_Click(object sender, RoutedEventArgs e)
        {
            ellipse.Fill = contactEllipse8.Fill;
            name.Text = contactName8.Text;
            if (btnContact8.IsChecked == true)
            {
                btnContact1.IsChecked = false;
                btnContact2.IsChecked = false;
                btnContact3.IsChecked = false;
                btnContact4.IsChecked = false;
                btnContact5.IsChecked = false;
                btnContact6.IsChecked = false;
                btnContact7.IsChecked = false;
                btnContact9.IsChecked = false;
                btnContact10.IsChecked = false;
            }
        }

        private void btnContact9_Click(object sender, RoutedEventArgs e)
        {
            ellipse.Fill = contactEllipse9.Fill;
            name.Text = contactName9.Text;
            if (btnContact9.IsChecked == true)
            {
                btnContact1.IsChecked = false;
                btnContact2.IsChecked = false;
                btnContact3.IsChecked = false;
                btnContact4.IsChecked = false;
                btnContact5.IsChecked = false;
                btnContact6.IsChecked = false;
                btnContact7.IsChecked = false;
                btnContact8.IsChecked = false;
                btnContact10.IsChecked = false;
            }
        }

        private void btnContact10_Click(object sender, RoutedEventArgs e)
        {
            ellipse.Fill = contactEllipse10.Fill;
            name.Text = contactName10.Text;
            if (btnContact10.IsChecked == true)
            {
                btnContact1.IsChecked = false;
                btnContact2.IsChecked = false;
                btnContact3.IsChecked = false;
                btnContact4.IsChecked = false;
                btnContact5.IsChecked = false;
                btnContact6.IsChecked = false;
                btnContact7.IsChecked = false;
                btnContact8.IsChecked = false;
                btnContact9.IsChecked = false;
            }
        }
    }
}
