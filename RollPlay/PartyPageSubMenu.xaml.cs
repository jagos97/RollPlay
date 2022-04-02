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
    /// <summary>
    /// Interaction logic for CharacterSubMenu.xaml
    /// </summary>
    public partial class PartyPageSubMenu : UserControl
    {

        public string PartyName { get; set; }
        public string PlayerName { get; set; }
 
       
        public PartyPageSubMenu(string PartyName, string PlayerName)
        {
            InitializeComponent();
            this.PartyName = PartyName;
            this.PlayerName = PlayerName;
        }

        public void SwapCharacter_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }
        public void EditParty_Click(object sender, RoutedEventArgs e)
        {
            
            EditPartyWindow window = new EditPartyWindow(PartyName, PlayerName);
            window.Show();
            window.Top = Window.GetWindow(this).Top;
            window.Left = Window.GetWindow(this).Left;
            Window.GetWindow(this).Close();


        }

        public void LeaveParty_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        public void NotImplemented_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Under Construction");
        }
    }
}
