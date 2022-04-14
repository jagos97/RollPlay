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
using System.Windows.Media.Effects;

namespace RollPlay
{
/// <summary>
/// Interaction logic for Window4.xaml
/// </summary>
public partial class CharacterPageWindow : Window
    { 
            private static bool navBarMenuShown = false;

            public string NameCharacter { get; set; }

            public string PartyName { get; set; }

            public string Class { get; set; }

            public string Race { get; set; }

            public string Level { get; set; }

            public string photo { get; set; }

            public string bio { get; set; }

            public int[] userStats {get; set;}


            public static bool popupShown = false;

            public CharacterPageWindow (string Name, string Party, string Class, string Race, string Level, string Bio, int[] Stats)
            {
                InitializeComponent();
                this.DataContext = this;

                this.NameCharacter = Name;
                this.PartyName = Party;
                this.Class = Class;
                this.Race = Race;
                this.Level = Level;
                this.userStats=Stats;

                if (NameCharacter.Equals("JYNX BOPDAWDLE"))
                {
                    this.photo = "/pics/jynx.png";

                    if (Bio == null) {
                        this.bio="What is there to say about little ol'me? I love gardening and a good magic show.";
                    } else {
                        this.bio = Bio;
                    }
                }

                else if (NameCharacter.Equals("SCRAVEN MIZZRYM"))
                {
                    this.photo = "/pics/scraven.png";
                    if (Bio == null) {
                        this.bio="Love to spend quiet nights in the graveyard, making new friends with the dead.";
                    } else {
                        this.bio = Bio;
                    }
                }

                for (int i = 8; i > Stats[0]; i += -1) {
                    UIElement Child = StrStat.Children[i-1];
                    StrStat.Children.Remove(Child);
                }
                for (int i = 8; i > Stats[1]; i += -1) {
                    UIElement Child = IntStat.Children[i-1];
                    IntStat.Children.Remove(Child);
                }
                for (int i = 8; i > Stats[2]; i += -1) {
                    UIElement Child = DexStat.Children[i-1];
                    DexStat.Children.Remove(Child);
                }
                for (int i = 8; i > Stats[3]; i += -1) {
                    UIElement Child = WisStat.Children[i-1];
                    WisStat.Children.Remove(Child);
                }
                for (int i = 8; i > Stats[4]; i += -1) {
                    UIElement Child = ConStat.Children[i-1];
                    ConStat.Children.Remove(Child);
                }
                for (int i = 8; i > Stats[5]; i += -1) {
                    UIElement Child = ChaStat.Children[i-1];
                    ChaStat.Children.Remove(Child);
                }
            }

            private void BackToMain_Click(object sender, RoutedEventArgs e)
            {
                MainWindow window = new MainWindow();
                window.Show();
                window.Top = this.Top;
                window.Left = this.Left;
                this.Close();
            }

            // Submenu
            private void CharacterSubMenu_Click(object sender, RoutedEventArgs e)
            {
            if (popupShown)
            {
                SubMenuHolder.Children.Clear();
                popupShown = false;
            }
            else
            {
                CharacterSubMenu subMenu = new CharacterSubMenu(NameCharacter, PartyName, Class, Race, Level, userStats);
                SubMenuHolder.Children.Clear();
                SubMenuHolder.Children.Add(subMenu);
                popupShown = true;
            }
            e.Handled = true;
        }

            // Navbar navigation
            private void CollectionNavBar_Click(object sender, RoutedEventArgs e)
            {
                MainWindow window = new MainWindow();
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

