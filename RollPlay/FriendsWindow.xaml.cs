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
using System.Diagnostics;

namespace RollPlay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class FriendsWindow : Window
    {
        private static bool popupShown = false;
        public static Border friendSelected = null;
        private static Button friendSelectedButton = null;
        public FriendsWindow()
        {
            InitializeComponent();
            SearchfriendTextBox.Focus(); 
            for(int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                int j = i + 121;
                btn.Content = "NewFriend#" + j.ToString();
                btn.Height = 30;
                btn.Background = new SolidColorBrush(Colors.White);
                btn.BorderBrush = new SolidColorBrush(Colors.LightGray);
                btn.BorderThickness = new Thickness(0,0,0,2);
                btn.Click += (object sender, RoutedEventArgs e) => { SelectFriend_Click(sender,e); };
                PossibleFriendsStack.Children.Add(btn);
            }
        }

        private void CharactersCollectionSubMenuSelector_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void PartiesCollectionSubMenuSelector_Click(object sender, RoutedEventArgs e)
        {
            PartiesWindow window = new PartiesWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void TavernNavBar_Click(object sender, RoutedEventArgs e)
        {
            TavernMenuWindow window = new TavernMenuWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void PartySubMenu_Click(object sender, RoutedEventArgs e)
        {
            if (popupShown)
            {
                SubMenuHolder.Children.Clear();
                popupShown = false;
                friendSelected = null;
            }
            else
            {
                FriendSubMenu subMenu = new FriendSubMenu();
                SubMenuHolder.Children.Clear();
                SubMenuHolder.Children.Add(subMenu);
                popupShown = true;
                friendSelected = (Border)((StackPanel)((Button)sender).Parent).Parent;
            }
            e.Handled = true;
        }

        public void DeleteFriend()
        {
            popupShown = false;
            FriendHolder.Children.Remove(friendSelected);
            SubMenuHolder.Children.Clear();
            if(FriendHolder.Children.Count == 2)
            {
                noCharacterMessage.Visibility = Visibility.Visible;

            }
        }

        private void GoToAddFriend_Click(object sender, RoutedEventArgs e)
        {
            AddFriendOverlay.Visibility = Visibility.Visible;
        }
        private void GoToPendingFriends_Click(object sender, RoutedEventArgs e)
        {
            PendingFriendsOverlay.Visibility = Visibility.Visible;

        }
        private void ExitFriendOverlay_Click(object sender, RoutedEventArgs e)
        {
            AddFriendOverlay.Visibility = Visibility.Collapsed;
            PendingFriendsOverlay.Visibility = Visibility.Collapsed;
        }

        private void AddFriend_Click(object sender, RoutedEventArgs e)
        {
            string content = friendSelectedButton.Content as string;
            foreach (Button b in PossibleFriendsStack.Children)
            {
                b.Background = new SolidColorBrush(Colors.White);
            }
            MessageBox.Show("Friend Request sent to " + content);

        }
        private void AcceptFriend_Click(object sender, RoutedEventArgs e)
        {
            NewFriend.Visibility = Visibility.Visible;
            FriendRequestsStack.Children.Clear();
        }
        private void DeclineFriend_Click(object sender, RoutedEventArgs e)
        {
            FriendRequestsStack.Children.Clear();
        }
        private void ResindFriendRequest_Click(object sender, RoutedEventArgs e)
        {
            FriendRequestsSentStack.Children.Clear();
        }

        private void SelectFriend_Click(object sender, RoutedEventArgs e)
        {
            foreach (Button b in PossibleFriendsStack.Children)
            {
                b.Background = new SolidColorBrush(Colors.White);
            }
            Button btn = sender as Button;
            friendSelectedButton = btn;
            btn.Background = new SolidColorBrush(Colors.LightBlue);
        }

    }
}
