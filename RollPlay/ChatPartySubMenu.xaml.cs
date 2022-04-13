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
    public partial class ChatPartySubMenu : UserControl
    {

        public static bool popupShown = false;

        public ChatPartySubMenu()
        {
            InitializeComponent();
        }
        public void NotImplemented_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Under Construction");
        }
        public void ViewPeople_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is Chat)
            {
                Chat parentWindow = Window.GetWindow(this) as Chat;
                parentWindow.SeeMembersInChat();
            }

            else if (Window.GetWindow(this) is TavernChat)
            {
                TavernChat parentWindow = Window.GetWindow(this) as TavernChat;
                parentWindow.overlayPanel.Visibility = Visibility.Visible;
                parentWindow.popupPanel.Children.Clear();
                parentWindow.SeeMembersInChat();

            }
        }
    }
}
