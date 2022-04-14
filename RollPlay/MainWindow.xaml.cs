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
    public partial class MainWindow : Window
    {
        private static bool navBarMenuShown = false;

        private static int navbarSelected = 0;
        private static bool popupShown = false;
        private static Thickness blank = new Thickness(0, 0, 0, 0);
        private static Thickness active = new Thickness(0, 4, 0, 0);
        private Button selectedCharacter = null;

        public MainWindow()
        {
            InitializeComponent();
            MainGrid.Focus();
            ChangNavBarSelected();

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D)
            {
                navbarSelected = navbarSelected + 1;
                if (navbarSelected > 4)
                {
                    navbarSelected = 0;
                }
                ChangNavBarSelected();
            }
            if (e.Key == Key.A)
            {
                navbarSelected = navbarSelected - 1;
                if (navbarSelected < 0)
                {
                    navbarSelected = 4;
                }
                ChangNavBarSelected();
            }
            if (e.Key == Key.Right)
            {
                TavernMenuWindow britt = new TavernMenuWindow();
                britt.Show();
                this.Close();
            }

            if (e.Key == Key.Left)
            {
                Window3 applePie = new Window3();
                applePie.Show();
                this.Close();

            }
            if (e.Key == Key.Up)
            {
                Window1 poncho = new Window1();
                poncho.Show();
                poncho.Top = this.Top;
                poncho.Left = this.Left;
                this.Close();
            }

        }

        private void ChangNavBarSelected()
        {
            if (navbarSelected == 0)
            {
                CollectionNavBar.BorderThickness = active;
                TavernNavBar.BorderThickness = blank;
                ChatNavBar.BorderThickness = blank;
                NotificationNavBar.BorderThickness = blank;
                MenuNavBar.BorderThickness = blank;

            }
            else if (navbarSelected == 1)
            {
                CollectionNavBar.BorderThickness = blank;
                TavernNavBar.BorderThickness = active;
                ChatNavBar.BorderThickness = blank;
                NotificationNavBar.BorderThickness = blank;
                MenuNavBar.BorderThickness = blank;

            }
            else if (navbarSelected == 2)
            {
                CollectionNavBar.BorderThickness = blank;
                TavernNavBar.BorderThickness = blank;
                ChatNavBar.BorderThickness = active;
                NotificationNavBar.BorderThickness = blank;
                MenuNavBar.BorderThickness = blank;

            }
            else if (navbarSelected == 3)
            {
                CollectionNavBar.BorderThickness = blank;
                TavernNavBar.BorderThickness = blank;
                ChatNavBar.BorderThickness = blank;
                NotificationNavBar.BorderThickness = active;
                MenuNavBar.BorderThickness = blank;

            }
            else if (navbarSelected == 4)
            {
                CollectionNavBar.BorderThickness = blank;
                TavernNavBar.BorderThickness = blank;
                ChatNavBar.BorderThickness = blank;
                NotificationNavBar.BorderThickness = blank;
                MenuNavBar.BorderThickness = active;

            }
        }

        private void PartiesCollectionSubMenuSelector_Click(object sender, RoutedEventArgs e)
        {
            PartiesWindow window = new PartiesWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void FriendsCollectionSubMenuSelector_Click(object sender, RoutedEventArgs e)
        {
            FriendsWindow window = new FriendsWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }
        private void CharacterSubMenu_Click(object sender, RoutedEventArgs e)
        {
            if (popupShown)
            {
                SubMenuHolder.Children.Clear();
                popupShown = false;
            }
            else
            {
                CharacterSubMenu subMenu = new CharacterSubMenu();
                SubMenuHolder.Children.Clear();
                SubMenuHolder.Children.Add(subMenu);
                popupShown = true;
                selectedCharacter = (Button)((StackPanel)((Border)((StackPanel)((Grid)((Button)sender).Parent).Parent).Parent).Parent).Parent;
            }
            e.Handled = true;
        }

        public void LeaveParty()
        {
            popupShown = false;
            AllCharacters.Children.Remove(selectedCharacter);
            SubMenuHolder.Children.Clear();
            if (AllCharacters.Children.Count < 2)
            {
                noCharacterMessage.Visibility = Visibility.Visible;
            }

        }

        // Characters Functions
        private void ToCharacter1_Click(object sender, RoutedEventArgs e)
        {
            string Name = (string)CharacterName1.Content;
            string Party = (string)CharacterParty1.Content;
            string Class = (string)CharacterClass1.Content;
            string Race = (string)CharacterRace1.Content;
            string Level = (string)CharacterLevel1.Content;

            CharacterPageWindow window = new CharacterPageWindow(Name, Party, Class, Race, Level);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void ToCharacter2_Click(object sender, RoutedEventArgs e)
        {
            string Name = (string)CharacterName2.Content;
            string Party = (string)CharacterParty2.Content;
            string Class = (string)CharacterClass2.Content;
            string Race = (string)CharacterRace2.Content;
            string Level = (string)CharacterLevel2.Content;


            CharacterPageWindow2 window = new CharacterPageWindow2(Name, Party, Class, Race, Level);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            e.Handled = true;
        }

        // Navbar Navigate
        private void TavernNavBar_Click(object sender, RoutedEventArgs e)
        {
            TavernMenuWindow window = new TavernMenuWindow();
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
    }
}
