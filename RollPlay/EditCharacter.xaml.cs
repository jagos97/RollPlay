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
using System.Text.RegularExpressions;

namespace RollPlay
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class EditCharacterWindow : Window
    { 
          private static bool navBarMenuShown = false;

            public string DefaultName { get; set; }
            public string DefaultParty { get; set; }
            public string DefaultClass { get; set; }
            public string DefaultRace { get; set; }
            public string DefaultLevel { get; set; }
            public int[] DefaultStats { get; set; }
            public string DefaultBio { get; set; }

            public string NameCharacter { get; set; }

            public string PartyName { get; set; }

            public string Class { get; set; }
            public string SubClass { get; set; }

            public string Race { get; set; }

            public string Level { get; set; }

            public int[] CharStats { get; set; }

            public string photo { get; set; }

            public string bio { get; set; }

          public static bool popupShown = false;

          public EditCharacterWindow(string Name, string Party, string Class, string Race, string Level, string Bio, int[] Stats, string Photo)
          {
              InitializeComponent();

                if (Name != null) {

                this.DataContext = this;

                    this.DefaultName = Name;
                    this.DefaultParty = Party;
                    this.DefaultClass = Class;
                    this.DefaultRace = Race;
                    this.DefaultLevel = Level;
                    this.DefaultStats = Stats;

                    if (DefaultName.Equals("JYNX BOPDAWDLE"))
                    {
                        if (Photo == null) {
                            this.photo = "/pics/jynx.png";
                        } else {
                            this.photo = Photo;
                        }
                        if (bio == null) {
                            this.DefaultBio="What is there to say about little ol'me? I love gardening and a good magic show.";
                        } else {
                            this.DefaultBio = Bio;
                        }
                    }

                    else if (DefaultName.Equals("SCRAVEN MIZZRYM"))
                    {
                        if (Photo == null) {
                            this.photo = "/pics/scraven.png";
                        } else {
                            this.photo = Photo;
                        }
                        if (bio == null) {
                            this.DefaultBio="Love to spend quiet nights in the graveyard, making new friends with the dead.";
                        } else {
                            this.DefaultBio = Bio;
                        }
                    }
                } else {
                    this.DefaultName = null;
                }
          }

        private void BackToCharacter_Click(object sender, RoutedEventArgs e)
        {
            if (DefaultName == null) {
                MainWindow window = new MainWindow();
                window.Show();
                window.Top = this.Top;
                window.Left = this.Left;
                this.Close();
            } else {
                int[] thisStats = new int[6];
                if (DefaultName.Equals("ToCharacter1")) {
                    thisStats = new int[] {1, 8, 3, 7, 5, 0};
                } else {
                    thisStats = new int[] {1, 4, 3, 7, 5, 3};
                }

                CharacterPageWindow window = new CharacterPageWindow(this.DefaultName, this.DefaultParty, this.DefaultClass, this.DefaultRace, this.DefaultLevel, DefaultBio, thisStats, this.photo);
                window.Show();
                window.Top = this.Top;
                window.Left = this.Left;
                this.Close();
            }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

            this.NameCharacter = NewName.Text;
            this.Class = NewClass.Text;
            this.SubClass = NewSubClass.Text;
            string tempClass = Class + " | " + SubClass;
            this.Race = NewRace.Text;
            this.Level = NewCharLevel.Text;
            string tempLevel = "Level " + Level;
            this.bio = NewBio.Text;

            int[] thisStats = new int[6];


            // if (DefaultName.Equals("ToCharacter1")) {
            //     thisStats = new int[] {1, 8, 3, 7, 5, 0};
            // } else {
            //     thisStats = new int[] {1, 4, 3, 7, 5, 3};
            // }



            CharacterPageWindow window = new CharacterPageWindow(this.NameCharacter, this.DefaultParty, tempClass, this.Race, tempLevel, this.bio, thisStats, this.photo);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
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

