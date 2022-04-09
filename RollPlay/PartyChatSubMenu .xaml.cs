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
    public partial class PartyChatSubMenu : UserControl
    {

        public string PartyName { get; set; }
        public string PlayerName { get; set; }

        public List<string> friendsList = new List<string>();
 
       
        public PartyChatSubMenu(string PartyName, string PlayerName, List<string> friendsList)
        {
            this.friendsList = friendsList;
            this.PartyName = PartyName;
            this.PlayerName = PlayerName;
            InitializeComponent();

        }


        public void DeleteChat_Click(object sender, RoutedEventArgs e)
        {
            PartyPageWindow window = Window.GetWindow(this) as PartyPageWindow;
            window.SubMenuHolder.Children.Clear();
            window.DeleteChat();
        }

        public void NotImplemented_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Under Construction");
        }
    }
}
