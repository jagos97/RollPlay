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

          public string CharacterName { get; set; }

          public string PartyName { get; set; }

          public string CharacterClass { get; set; }

          public string CharacterRace { get; set; }

          public string CharacterLevel { get; set; }

          public string photo { get; set; }

          public static bool popupShown = false;

          public CharacterPageWindow(string Name, string Party, string Class, string Race, string Level)
          {
              InitializeComponent();
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
                CharacterSubMenu subMenu = new CharacterSubMenu();
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

