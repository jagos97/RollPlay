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
    public partial class TavernMenuWindow : Window
    {

        string[] prompts = new string[] {"Are you drunk?!", "I need a favour...", "What did the lady threaten you with for your silence?", "Why were you a suspect?",
            "Oof, you really took a beatin', didn't ya?", "What kind of monster leaves a puppy in the street?", "How did you slip the hangman's noose?", "Don't mention this to anyone...",
            "I heard something strange about the cleric...", "Look at this bounty I found.", "*incoherent yelling*", "*jovial cheering and laughing*",
            "I don't care.. I'm leaving town tonight.", "Let's play a game, shall we?"};

        public string? Prompt1 { get; set; }
        public string? Prompt2 { get; set; }
        public string? Prompt3 { get; set; }
        public string? Prompt4 { get; set; }
        public string? Prompt5 { get; set; }
        public string? Prompt6 { get; set; }

        private static bool navBarMenuShown = false;


        public TavernMenuWindow()
        {
            InitializeComponent();
        }

        private void CommonerMenuSelector_Click(object sender, RoutedEventArgs e)
        {
            CommonerMenuWindow window = new CommonerMenuWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void FindfriendsSelector_Click(object sender, RoutedEventArgs e)
        {
            FindFriendsMenuWindow window = new FindFriendsMenuWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void RPMenuSelector_Click(object sender, RoutedEventArgs e)
        {

            Random rnd = new Random();
            int index = rnd.Next(prompts.Length);
            string Prompt1 = prompts[index];

            Random rnd1 = new Random();
            int index1 = rnd1.Next(prompts.Length);
            string Prompt2 = prompts[index1];

            Random rnd2 = new Random();
            int index2 = rnd2.Next(prompts.Length);
            string Prompt3 = prompts[index2];

            Random rnd3 = new Random();
            int index3 = rnd3.Next(prompts.Length);
            string Prompt4 = prompts[index3];

            Random rnd4 = new Random();
            int index4 = rnd4.Next(prompts.Length);
            string Prompt5 = prompts[index4];

            Random rnd5 = new Random();
            int index5 = rnd5.Next(prompts.Length);
            string Prompt6 = prompts[index5];

            ExploreTavernWindow window = new ExploreTavernWindow(Prompt1, Prompt2, Prompt3, Prompt4, Prompt5, Prompt6);
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
