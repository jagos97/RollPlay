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

namespace RollPlay
{

    public partial class CharacterSubMenu : UserControl
    {
        public string NameCharacter { get; set; }

        public string PartyName { get; set; }

        public string Class { get; set; }

        public string Race { get; set; }

        public string Level { get; set; }

        public int[] Stats {get;set;} 
           
        public CharacterSubMenu(string Name, string Party, string Class, string Race, string Level, int[] Stats)
        {
            InitializeComponent();
            this.DataContext = this;

            this.NameCharacter = Name;
            this.PartyName = Party;
            this.Class = Class;
            this.Race = Race;
            this.Level = Level;
        }

        private void UnderConstruction_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Under Construction");
         }

        private void EditCharacter_Click(object sender, RoutedEventArgs e)
        {
            EditCharacterWindow window = new EditCharacterWindow(NameCharacter, PartyName, Class, Race, Level, null, Stats, null);
            window.Show();
            window.Top = Window.GetWindow(this).Top;
            window.Left = Window.GetWindow(this).Left;
            Window.GetWindow(this).Close();
        }

        private void LeaveParty_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow)
            {
                MainWindow window = Window.GetWindow(this) as MainWindow;
                ConfirmDelete confirm = new ConfirmDelete();
                window.overlay.Children.Clear();
                window.overlay.Children.Add(confirm);
            } else {
                MessageBox.Show("Under Construction");
            }
        }
    }
}
