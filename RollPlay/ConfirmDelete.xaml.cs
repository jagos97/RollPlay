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
    public partial class ConfirmDelete : UserControl
    {



        public ConfirmDelete()
        {

            InitializeComponent();

        }

        public void OK_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is PartiesWindow)
            {
                PartiesWindow window = Window.GetWindow(this) as PartiesWindow;
                window.LeaveParty();
                window.overlay.Children.Clear();
            }
            else if (Window.GetWindow(this) is FriendsWindow)
            {
                FriendsWindow window = Window.GetWindow(this) as FriendsWindow;
                window.DeleteFriend();
                window.overlay.Children.Clear();
            }
            else if (Window.GetWindow(this) is MainWindow)
            {
                MainWindow window = Window.GetWindow(this) as MainWindow;
                window.LeaveParty();
                window.overlay.Children.Clear();
            } else if (Window.GetWindow(this) is EditPartyWindow)
            {
                EditPartyWindow window = Window.GetWindow(this) as EditPartyWindow;
                window.RemovePlayer();
                window.overlay.Children.Clear();
            } else if (Window.GetWindow(this) is PartyAvailabilityWindow)
            {
                PartyAvailabilityWindow window = Window.GetWindow(this) as PartyAvailabilityWindow;
                window.InfoPanel.Children.Clear();
                RequestAvail request = new RequestAvail();
                window.InfoPanel.Children.Add(request);
            }


        }

        public void Cancel_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is PartiesWindow)
            {
                PartiesWindow window = Window.GetWindow(this) as PartiesWindow;
                window.overlay.Children.Clear();
            }
            else if (Window.GetWindow(this) is FriendsWindow)
            {
                FriendsWindow window = Window.GetWindow(this) as FriendsWindow;
                window.overlay.Children.Clear();
            }
            else if (Window.GetWindow(this) is MainWindow)
            {
                MainWindow window = Window.GetWindow(this) as MainWindow;
                window.overlay.Children.Clear();
            } else if (Window.GetWindow(this) is EditPartyWindow)
            {
                EditPartyWindow window = Window.GetWindow(this) as EditPartyWindow;
                window.overlay.Children.Clear();
            } else if (Window.GetWindow(this) is PartyAvailabilityWindow)
            {
                PartyAvailabilityWindow window = Window.GetWindow(this) as PartyAvailabilityWindow;
                window.InfoPanel.Children.Clear();
            }



        }
    }
}
