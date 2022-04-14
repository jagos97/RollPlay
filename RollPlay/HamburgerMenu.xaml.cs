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
    /// Interaction logic for PartySubMenu1.xaml
    /// </summary>
    public partial class HamburgerMenu : UserControl
    {

        public HamburgerMenu()
        {
            InitializeComponent();
        }

        private void CharacterPage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            window.Top = Window.GetWindow(this).Top;
            window.Left = Window.GetWindow(this).Left;
            Window.GetWindow(this).Close();
        }
       
        private void CreateCharacter_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }
        
        private void PartyPage_Click(object sender, RoutedEventArgs e)
        {
            PartiesWindow window = new PartiesWindow();
            window.Show();
            window.Top = Window.GetWindow(this).Top;
            window.Left = Window.GetWindow(this).Left;
            Window.GetWindow(this).Close();
        }

        private void CreateParty_Click(object sender, RoutedEventArgs e)
        {
            PartiesWindow window = new PartiesWindow();
            window.Show();
            window.Top = Window.GetWindow(this).Top;
            window.Left = Window.GetWindow(this).Left;
            Window.GetWindow(this).Close();

            CreateParty create = new CreateParty();
            window.overlay.Children.Clear();
            window.overlay.Children.Add(create);
        }

        private void FriendsPage_Click(object sender, RoutedEventArgs e)
        {
            FriendsWindow window = new FriendsWindow();
            window.Show();
            window.Top = Window.GetWindow(this).Top;
            window.Left = Window.GetWindow(this).Left;
            Window.GetWindow(this).Close();
        }

        private void MessagesPage_Click(object sender, RoutedEventArgs e)
        {
            PartyChats window = new PartyChats();
            window.Show();
            window.Top = Window.GetWindow(this).Top;
            window.Left = Window.GetWindow(this).Left;
            Window.GetWindow(this).Close();
        }

        private void TavernPage_Click(object sender, RoutedEventArgs e)
        {
            TavernMenuWindow window = new TavernMenuWindow();
            window.Show();
            window.Top = Window.GetWindow(this).Top;
            window.Left = Window.GetWindow(this).Left;
            Window.GetWindow(this).Close();
        }

        private void NotificationPage_Click(object sender, RoutedEventArgs e)
        {
            NotificationsWindow window = new NotificationsWindow();
            window.Show();
            window.Top = Window.GetWindow(this).Top;
            window.Left = Window.GetWindow(this).Left;
            Window.GetWindow(this).Close();
        }

        private void NotificationsPage_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }




    }
}
