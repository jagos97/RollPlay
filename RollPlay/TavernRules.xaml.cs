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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class TavernRulesWindow : Window
    {

        private static bool navBarMenuShown = false;

        public TavernRulesWindow()
        {
            InitializeComponent();
        }

        private void CollectionNavBar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
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

        private void ChatNavBar_Click(object sender, RoutedEventArgs e)
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

        private void Proceed_Click(object sender, RoutedEventArgs e)
        {
            TavernChat window = new TavernChat();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            TavernMenuWindow window = new TavernMenuWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }
    }
}
