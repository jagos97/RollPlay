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
using System.Diagnostics;

namespace RollPlay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class PartiesWindow : Window
    {
        private static bool navBarMenuShown = false;

        private static bool popupShown = false;

        private string schedSession = "No Session Scheduled";

        public PartiesWindow()
        {
            InitializeComponent();
            MainGrid.Focus();
        }
        private void CharactersCollectionSubMenuSelector_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void FriendsCollectionSubMenuSelector_Click(object sender, RoutedEventArgs e)
        {
            FriendsWindow window = new FriendsWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void PartySubmenu_Click(object sender, RoutedEventArgs e)
        {
            if (popupShown)
            {
                SubMenuHolder.Children.Clear();
                popupShown = false;
            }
            else
            {
                PartySubMenu1 partySubMenu1 = new PartySubMenu1();
                SubMenuHolder.Children.Clear();
                SubMenuHolder.Children.Add(partySubMenu1);
                popupShown = true;
            }
            e.Handled = true;
        }

        private void TavernNavBar_Click(object sender, RoutedEventArgs e)
        {
            TavernMenuWindow window = new TavernMenuWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();

        }

        private void ToParty_Click(object sender, RoutedEventArgs e)
        {
            string Name = (string)PartyName.Content;
            string Player = (string)PlayerName.Content;

            PartyPageWindow window = new PartyPageWindow(Name, Player, null, null, null, schedSession);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void ToParty2_Click(object sender, RoutedEventArgs e)
        {
            string Name = (string)PartyName2.Content;
            string Player = (string)PlayerName2.Content;

            PartyPageWindow window = new PartyPageWindow(Name, Player, null, null, null, schedSession);
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
