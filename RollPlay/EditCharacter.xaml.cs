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

            public string NameCharacter { get; set; }

            public string PartyName { get; set; }

            public string Class { get; set; }

            public string Race { get; set; }

            public string Level { get; set; }

            public int[] CharStats { get; set; }

            public string photo { get; set; }

            public string bio { get; set; }

          public static bool popupShown = false;

          public EditCharacterWindow(string Name, string Party, string Class, string Race, string Level, string Bio, int[] Stats)
          {
              InitializeComponent();

              this.DataContext = this;

                this.NameCharacter = Name;
                this.PartyName = Party;
                this.Class = Class;
                this.Race = Race;
                this.Level = Level;
                this.CharStats = Stats;

                if (NameCharacter.Equals("JYNX BOPDAWDLE"))
                {
                    this.photo = "/pics/jynx.png";

                    if (bio == null) {
                        this.bio="What is there to say about little ol'me? I love gardening and a good magic show.";
                    } else {
                        this.bio = Bio;
                    }
                }

                else if (NameCharacter.Equals("SCRAVEN MIZZRYM"))
                {
                    this.photo = "/pics/scraven.png";
                    if (bio == null) {
                        this.bio="Love to spend quiet nights in the graveyard, making new friends with the dead.";
                    } else {
                        this.bio = Bio;
                    }
                }
          }

          private void BackToCharacter_Click(object sender, RoutedEventArgs e)
          {
            CharacterPageWindow window = new CharacterPageWindow(this.NameCharacter, this.PartyName, this.Class, this.Race, this.Level, null, this.CharStats);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
          }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            int str = Int32.Parse(StrStat.Text);
            int inte = Int32.Parse(IntStat.Text);
            int dex = Int32.Parse(DexStat.Text);
            int wis = Int32.Parse(WisStat.Text);
            int con = Int32.Parse(ConStat.Text);
            int cha = Int32.Parse(ChaStat.Text);

            int[] tempStats= {str, inte, dex, wis, con, cha};

            string tempBio = NewBio.Text;

            CharacterPageWindow window = new CharacterPageWindow(this.NameCharacter, this.PartyName, this.Class, this.Race, this.Level, tempBio, tempStats);
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

