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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class PartyPageWindow : Window
    {
        private static bool navBarMenuShown = false;

        public string PartyName { get; set; }

        public string PlayerName { get; set; }

        public static bool popupShown = false;
        public static Border partySelected = null;

        public PartyPageWindow(string PartyName, string PlayerName)
        {
            this.PartyName = PartyName;
            this.PlayerName = PlayerName;
            InitializeComponent();
        }

        private void MainChat_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            PartiesWindow window = new PartiesWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void TavernNavBar_Click(object sender, RoutedEventArgs e)
        {
            TavernMenuWindow window = new TavernMenuWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();

        }

        private void PartyPageSubMenu_Click(object sender, RoutedEventArgs e)
        {
            if (popupShown)
            {
                SubMenuHolder.Children.Clear();
                popupShown = false;

            }
            else
            {
                PartyPageSubMenu subMenu = new PartyPageSubMenu(this.PartyName, this.PlayerName);
                SubMenuHolder.Children.Clear();
                SubMenuHolder.Children.Add(subMenu);
                popupShown = true;

            }
            e.Handled = true;
        }

        private void InviteToParty_Click(object sender, RoutedEventArgs e)
        {

            InviteToParty inviteMenu = new InviteToParty();
            overlay.Children.Clear();
            overlay.Children.Add(inviteMenu);
        }

        private void CreatePartyChat_Click(object sender, RoutedEventArgs e)
        {
            CreatePartyChat chatMenu = new CreatePartyChat(PartyName, PlayerName);
            overlay.Children.Clear();
            overlay.Children.Add(chatMenu);

        }


        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scrollViewer = (ScrollViewer)sender;
            if (e.Delta > 0)
            {
                scrollViewer.LineLeft();
            }
            else
            {
                scrollViewer.LineRight();
            }
            e.Handled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //TODO
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

        private void Availability_Click(object sender, RoutedEventArgs e)
        {
            EditAvailabilityWindow window = new EditAvailabilityWindow(PartyName);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            

            
        }
    }
}
