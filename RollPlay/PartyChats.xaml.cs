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

namespace RollPlay
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class PartyChats : Window
    {
        private static bool navBarMenuShown = false;

        public PartyChats()
        {
            InitializeComponent();
        }

        private void TavernNavBar_Click(object sender, RoutedEventArgs e)
        {
            TavernMenuWindow window = new TavernMenuWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void CollectionNavBar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void PartyChatPins_Click(object sender, RoutedEventArgs e)
        {
            Chat window = new Chat(chatName: "Party", subname: "");
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }


        private void PartyChat_Click(object sender, RoutedEventArgs e)
        {
            string message = (sender as Button).Tag as string;
            List<string> messages = new List<string> { message, "Nope"};
            List<string> senders = new List<string> { "lUser1","rMe"};

            Chat window = new Chat(messages: messages, senders: senders, chatName: "Party", subname: "Vex", makePartyChat: true);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }
        private void OtherChats_Click(object sender, RoutedEventArgs e)
        {
            OtherChats window = new OtherChats();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void NotificationsNavBar_Click(object sender, RoutedEventArgs e)
        {
            NotificationsWindow window = new NotificationsWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }        
        private void MenuNavBar_Click(object sender, RoutedEventArgs e)
        {
            if (navBarMenuShown)
            {
                navBarMenuHolder.Children.Clear();
                navBarMenuShown = false;
            }
            else
            {
                HamburgerMenu menu = new HamburgerMenu();
                navBarMenuHolder.Children.Clear();
                navBarMenuHolder.Children.Add(menu);
                navBarMenuShown = true;

            }

        }

    }
}
