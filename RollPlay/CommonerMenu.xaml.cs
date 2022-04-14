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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class CommonerMenuWindow : Window
    {

        private static bool navBarMenuShown = false;

        public CommonerMenuWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CombatSelector_Click(object sender, RoutedEventArgs e)
        {
            string title = "COMBAT";
            string desc1 = "A typical combat is a clash between two sides, a flurry of weapons, feints, parries," +
                " footwork, and spellcasting. The game organizes the chaos of battle into a cycle of rounds and turns.";
            string desc2 = "A round lasts 6 seconds in game world, during which each battle participant takes one turn." +
                " Once everyone has taken a turn, the fight continues to the next round if neither side has defeated the other.";
            string desc3 = "On your turn you can: move, take one action, and take one bonus action";
            var redirect = new Uri(@"https://www.dndbeyond.com/sources/basic-rules/combat");
            BarkeeperInformationWindow window = new BarkeeperInformationWindow(title, desc1, desc2, desc3, redirect);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void SpellSelector_Click(object sender, RoutedEventArgs e)
        {
            string title = "SPELLCASTING";
            string desc1 = "A spell is a magical effect that varies from a damaging attack" +
                " to a protective ward. Spells can deal damage, remove conditions, and even restore" +
                " life to the dead";
            string desc2 = "A spell has a level from 0 to 9. A caster can only cast a limited number" +
                " of spells per day represented by spell slots. When a character casts a spell" +
                ", they expend a spell slot";
            string desc3 = "Generally, when a character finishes a long rest, all expended spell slots" +
                " are restored.";
            var redirect = new Uri(@"https://www.dndbeyond.com/sources/basic-rules/spellcasting");
            BarkeeperInformationWindow window = new BarkeeperInformationWindow(title, desc1, desc2, desc3, redirect);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void RoleplayingSelector_Click(object sender, RoutedEventArgs e)
        {
            string title = "ROLEPLAYING";
            string desc1 = "Roleplaying is, literally, the act of playing out a role. In this case, it's you as a player determining " +
                "how your character thinks, acts, and talks. Roleplaying is a part of every aspect of the game.";
            string desc2 = "Your character's quirks, mannerisms, and personality influence how interactions resolve. There are two styles you can use when roleplaying:";
            string desc3 = "the descriptive approach (describe your characters words and actions) or active (speaking as your character, like an actor)";
            var redirect = new Uri(@"https://www.dndbeyond.com/sources/basic-rules/adventuring#Roleplaying");
            BarkeeperInformationWindow window = new BarkeeperInformationWindow(title, desc1, desc2, desc3, redirect);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void AdventuringSelector_Click(object sender, RoutedEventArgs e)
        {
            string title = "ADVENTURING";
            string desc1 = "The game follows a natural rhythm; (1) the DM describes the environment, " +
                "(2) the players describe what they want to do, and, (3) the DM narrates the results of the players actions";
            string desc2 = "Adventuring can take place in a city, or the wilderness and can involve social roleplaying" +
                " interactions, combat encounters, or downtime where your character can rest";
            string desc3 = "Adventuring is a broad topic, and most of what players do in D&D can be considered adventuring.";
            var redirect = new Uri(@"https://www.dndbeyond.com/sources/basic-rules/adventuring#Adventuring");
            BarkeeperInformationWindow window = new BarkeeperInformationWindow(title, desc1, desc2, desc3, redirect);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void RaceClassSelector_Click(object sender, RoutedEventArgs e)
        {
            string title = "RACES & CLASSES";
            string desc1 = "There are many races and classes to choose from when creating your character; the standard fantasy races" +
                "like humans, elves and dwarves, and more fantastical ones such as tieflings, goblins, and tortles.";
            string desc2 = "You can choose to be a martial class, a spellcaster or some combination of both" +
                " (often called half-casters). Your class gives you special features which you gain as you level up.";
            string desc3 = "Each class uses different ability scores, and certain races grant ability score increases. Make sure you choose a good race & class combo.";
            var redirect = new Uri(@"https://www.dndbeyond.com/sources/basic-rules/races");
            BarkeeperInformationWindow window = new BarkeeperInformationWindow(title, desc1, desc2, desc3, redirect);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void DMSelector_Click(object sender, RoutedEventArgs e)
        {
            string title = "DMING";
            string desc1 = "It's good to be the Dungeon Master! Not only do you get to tell fantastic stories about heroes, villains, monsters and magic, but you " +
                "also get to create the world in which these stories live. ";
            string desc2 = "The Dungeon Master is the creative force behind a D&D game. The DM creates a world for the other players to explore, and also creates and" +
                " runs adventures that drive the story. An adventure typically hinges on the successful completion of a quest, and can be as short as a single game session.";
            string desc3 = "Longer adventures might embroil players in great conflicts that require multiple game sessions to resolve. When strung together, these adventures form an ongoing campaign.";
            var redirect = new Uri(@"https://www.dndbeyond.com/sources/basic-rules/running-the-game");
            BarkeeperInformationWindow window = new BarkeeperInformationWindow(title, desc1, desc2, desc3, redirect);
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
