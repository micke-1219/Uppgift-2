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
    /// Interaction logic for InboxView.xaml
    /// </summary>
    public partial class InboxView : UserControl
    {
        public InboxView()
        {
            InitializeComponent();
        }

        private void btnMessage1_Click(object sender, RoutedEventArgs e)
        {
            topic.Text = mailTopic1.Text;
            from.Text = senderName1.Text;
            date.Text = mailDate1.Text;
            content.Text = mailContent1.Text;
            if (btnMessage1.IsChecked == true)
            {
                btnMessage2.IsChecked = false;
                btnMessage3.IsChecked = false;
                btnMessage4.IsChecked = false;
                btnMessage5.IsChecked = false;
                btnMessage6.IsChecked = false;
                btnMessage7.IsChecked = false;
                btnMessage8.IsChecked = false;
                btnMessage9.IsChecked = false;
                btnMessage10.IsChecked = false;
            }
        }

        private void btnMessage2_Click(object sender, RoutedEventArgs e)
        {
            topic.Text = mailTopic2.Text;
            from.Text = senderName2.Text;
            date.Text = mailDate2.Text;
            content.Text = mailContent2.Text;
            if (btnMessage2.IsChecked == true)
            {
                btnMessage1.IsChecked = false;
                btnMessage3.IsChecked = false;
                btnMessage4.IsChecked = false;
                btnMessage5.IsChecked = false;
                btnMessage6.IsChecked = false;
                btnMessage7.IsChecked = false;
                btnMessage8.IsChecked = false;
                btnMessage9.IsChecked = false;
                btnMessage10.IsChecked = false;
            }
        }

        private void btnMessage3_Click(object sender, RoutedEventArgs e)
        {
            topic.Text = mailTopic3.Text;
            from.Text = senderName3.Text;
            date.Text = mailDate3.Text;
            content.Text = mailContent3.Text;
            if (btnMessage3.IsChecked == true)
            {
                btnMessage1.IsChecked = false;
                btnMessage2.IsChecked = false;
                btnMessage4.IsChecked = false;
                btnMessage5.IsChecked = false;
                btnMessage6.IsChecked = false;
                btnMessage7.IsChecked = false;
                btnMessage8.IsChecked = false;
                btnMessage9.IsChecked = false;
                btnMessage10.IsChecked = false;
            }
        }

        private void btnMessage4_Click(object sender, RoutedEventArgs e)
        {
            topic.Text = mailTopic4.Text;
            from.Text = senderName4.Text;
            date.Text = mailDate4.Text;
            content.Text = mailContent4.Text;
            if (btnMessage4.IsChecked == true)
            {
                btnMessage1.IsChecked = false;
                btnMessage2.IsChecked = false;
                btnMessage3.IsChecked = false;
                btnMessage5.IsChecked = false;
                btnMessage6.IsChecked = false;
                btnMessage7.IsChecked = false;
                btnMessage8.IsChecked = false;
                btnMessage9.IsChecked = false;
                btnMessage10.IsChecked = false;
            }
        }

        private void btnMessage5_Click(object sender, RoutedEventArgs e)
        {
            topic.Text = mailTopic5.Text;
            from.Text = senderName5.Text;
            date.Text = mailDate5.Text;
            content.Text = mailContent5.Text;
            if (btnMessage5.IsChecked == true)
            {
                btnMessage1.IsChecked = false;
                btnMessage2.IsChecked = false;
                btnMessage3.IsChecked = false;
                btnMessage4.IsChecked = false;
                btnMessage6.IsChecked = false;
                btnMessage7.IsChecked = false;
                btnMessage8.IsChecked = false;
                btnMessage9.IsChecked = false;
                btnMessage10.IsChecked = false;
            }
        }

        private void btnMessage6_Click(object sender, RoutedEventArgs e)
        {
            topic.Text = mailTopic6.Text;
            from.Text = senderName6.Text;
            date.Text = mailDate6.Text;
            content.Text = mailContent6.Text;
            if (btnMessage6.IsChecked == true)
            {
                btnMessage1.IsChecked = false;
                btnMessage2.IsChecked = false;
                btnMessage3.IsChecked = false;
                btnMessage4.IsChecked = false;
                btnMessage5.IsChecked = false;
                btnMessage7.IsChecked = false;
                btnMessage8.IsChecked = false;
                btnMessage9.IsChecked = false;
                btnMessage10.IsChecked = false;
            }
        }

        private void btnMessage7_Click(object sender, RoutedEventArgs e)
        {
            topic.Text = mailTopic7.Text;
            from.Text = senderName7.Text;
            date.Text = mailDate7.Text;
            content.Text = mailContent7.Text;
            if (btnMessage7.IsChecked == true)
            {
                btnMessage1.IsChecked = false;
                btnMessage2.IsChecked = false;
                btnMessage3.IsChecked = false;
                btnMessage4.IsChecked = false;
                btnMessage5.IsChecked = false;
                btnMessage6.IsChecked = false;
                btnMessage8.IsChecked = false;
                btnMessage9.IsChecked = false;
                btnMessage10.IsChecked = false;
            }
        }

        private void btnMessage8_Click(object sender, RoutedEventArgs e)
        {
            topic.Text = mailTopic8.Text;
            from.Text = senderName8.Text;
            date.Text = mailDate8.Text;
            content.Text = mailContent8.Text;
            if (btnMessage8.IsChecked == true)
            {
                btnMessage1.IsChecked = false;
                btnMessage2.IsChecked = false;
                btnMessage3.IsChecked = false;
                btnMessage4.IsChecked = false;
                btnMessage5.IsChecked = false;
                btnMessage6.IsChecked = false;
                btnMessage7.IsChecked = false;
                btnMessage9.IsChecked = false;
                btnMessage10.IsChecked = false;
            }
        }

        private void btnMessage9_Click(object sender, RoutedEventArgs e)
        {
            topic.Text = mailTopic9.Text;
            from.Text = senderName9.Text;
            date.Text = mailDate9.Text;
            content.Text = mailContent9.Text;
            if (btnMessage9.IsChecked == true)
            {
                btnMessage1.IsChecked = false;
                btnMessage2.IsChecked = false;
                btnMessage3.IsChecked = false;
                btnMessage4.IsChecked = false;
                btnMessage5.IsChecked = false;
                btnMessage6.IsChecked = false;
                btnMessage7.IsChecked = false;
                btnMessage8.IsChecked = false;
                btnMessage10.IsChecked = false;
            }
        }

        private void btnMessage10_Click(object sender, RoutedEventArgs e)
        {
            topic.Text = mailTopic10.Text;
            from.Text = senderName10.Text;
            date.Text = mailDate10.Text;
            content.Text = mailContent10.Text;
            if (btnMessage10.IsChecked == true)
            {
                btnMessage1.IsChecked = false;
                btnMessage2.IsChecked = false;
                btnMessage3.IsChecked = false;
                btnMessage4.IsChecked = false;
                btnMessage5.IsChecked = false;
                btnMessage6.IsChecked = false;
                btnMessage7.IsChecked = false;
                btnMessage8.IsChecked = false;
                btnMessage9.IsChecked = false;
            }
        }
    }
}
