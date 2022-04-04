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


    }
}
