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

        public List<string> friendsList = new List<string>();

 
       
        public PartyPageSubMenu(string PartyName, string PlayerName, List<string> friendsList)
        {
            this.friendsList = friendsList;
            this.PartyName = PartyName;
            this.PlayerName = PlayerName;
            InitializeComponent();

        }

        public void SwapCharacter_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }
        public void EditParty_Click(object sender, RoutedEventArgs e)
        {
            PartyPageWindow window1 = Window.GetWindow(this) as PartyPageWindow;
            string schedSession = window1.schedSession;

            EditPartyWindow window = new EditPartyWindow(PartyName, PlayerName, friendsList, schedSession);
            window.Show();
            window.Top = Window.GetWindow(this).Top;
            window.Left = Window.GetWindow(this).Left;
            Window.GetWindow(this).Close();
            PartyPageWindow.popupShown = false;


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
