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
    public partial class InviteToParty : UserControl
    {
        List<string> NameList = new List<string>();
        List<string> AddFriendList = new List<string>();

        public InviteToParty()
        {
            InitializeComponent();

            if (FriendsList.Items.Count > 0)
            {
                foreach (ListBoxItem friend in FriendsList.Items)
                {
                    NameList.Add(friend.Content.ToString());
                }
            }
                 
        }

        private void NameSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameSearch.Text))
            {
                FriendsList.Items.Clear();
                foreach (string name in NameList)
                {
                    if (name.ToLower().Contains(NameSearch.Text.Trim().ToLower()))
                    {
                        FriendsList.Items.Add(name);
                    }
                }

            } else if (string.IsNullOrWhiteSpace(NameSearch.Text))
            {
                FriendsList.Items.Clear();
                foreach (string name in NameList)
                {
                    FriendsList.Items.Add(name);
                }
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;

        }

        private void Friend_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is ListBoxItem)
            {
                ListBoxItem friend = sender as ListBoxItem;
                string friendName = friend.Content.ToString();
                AddFriendList.Add(friendName);
            }

        }

        private void Friend_Unchecked(object sender, RoutedEventArgs e)
        {
            if (sender is ListBoxItem)
            {
                ListBoxItem friend = sender as ListBoxItem;
                string friendName = friend.Content.ToString();
                AddFriendList.Remove(friendName);
            }
        }

        private void Invite_Click(object sender, RoutedEventArgs e)
        {
            PartyPageWindow window = Window.GetWindow(this) as PartyPageWindow;
            
            if (AddFriendList.Count > 0)
            {
                foreach (string friend in AddFriendList)
                {
                    window.addFriend(friend);

                }
            }

            window.overlay.Children.Clear();
        }


    }
}
