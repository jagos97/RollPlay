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
            List<string> messages = new List<string> { "Welcome", "Hey it's me. now it is a longer mdosgsdig nsdgonsd sodgn fn"};
            List<string> senders = new List<string> { "lDM","rMe"};

            Chat window = new Chat(messages: messages, senders: senders);
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
