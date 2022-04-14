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
    public partial class OtherChats : Window
    {
        private static bool navBarMenuShown = false;

        public OtherChats()
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

        private void OtherChat_Click(object sender, RoutedEventArgs e)
        {
            string message = (sender as Button).Tag as string;
            List<string> messages = new List<string> { message };
            List<string> senders = new List<string> { "lDragon's Bane"};

            Chat window = new Chat(messages: messages, senders: senders, chatName: "Dragon's Bane", subname: "", makePartyChat: false);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }
        private void OtherChatParty_Click(object sender, RoutedEventArgs e)
        {
            string message = (sender as Button).Tag as string;
            List<string> messages = new List<string> { message };
            List<string> senders = new List<string> { "lTrezorg the Brute" };

            Chat window = new Chat(messages: messages, senders: senders, chatName: "Tavern Chat", subname: "Vex", makePartyChat: true);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }
        private void PartyChats_Click(object sender, RoutedEventArgs e)
        {
            PartyChats window = new PartyChats();
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
