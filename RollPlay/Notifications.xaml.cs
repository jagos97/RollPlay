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
using System.Windows.Shapes;

namespace RollPlay
{
  public partial class NotificationsWindow : Window
  {

    private static bool navBarMenuShown = false;
    private static int navbarSelected = 0;
    private Border selectedNotification = null;
    private string schedSession = "No Session Scheduled";

    public NotificationsWindow()
    {
        InitializeComponent();
    }

    public void RemoveNotification_Click(object sender, RoutedEventArgs e)
    {
        selectedNotification = (Border)((StackPanel)((Grid)((Grid)((Button)sender).Parent).Parent).Parent).Parent;
        
        AllNotifications.Children.Remove(selectedNotification);
        if (AllNotifications.Children.Count < 2)
        {
            noCharacterMessage.Visibility = Visibility.Visible;
        }

    }

    public void RemoveAllNotifications_Click(object sender, RoutedEventArgs e)
    {
        
        for (int i = AllNotifications.Children.Count - 1; i > 0; i += -1) {
            UIElement Child = AllNotifications.Children[i];
            AllNotifications.Children.Remove(Child);
        }
    
        if (AllNotifications.Children.Count < 2)
        {
            noCharacterMessage.Visibility = Visibility.Visible;
        }

    }

    // Follow Notif
    private void ToParty_Click(object sender, RoutedEventArgs e)
    {
        string Name = "CURSE OF STRAHD";
        string Player = "JYNX BOPDAWDLE";

        AltMyAvailabilityWindow window = new AltMyAvailabilityWindow(Name, Player, null, schedSession);
        window.Show();
        window.Top = this.Top;
        window.Left = this.Left;
        this.Close();
    }

    // Navbar Navigation stuff
    private void TavernNavBar_Click(object sender, RoutedEventArgs e)
    {
      TavernMenuWindow window = new TavernMenuWindow();
      window.Show();
      window.Top = this.Top;
      window.Left = this.Left;
      this.Close();
    }

    private void MenuNavBar_Click(object sender, RoutedEventArgs e)
    {
      if (navBarMenuShown)
      {
        navBarMenuHolder.Children.Clear();
        navBarMenuShown = false;
      }
      else
      {
        HamburgerMenu menu = new HamburgerMenu();
        navBarMenuHolder.Children.Clear();
        navBarMenuHolder.Children.Add(menu);
        navBarMenuShown = true;
      }
    }
    private void CollectionNavBar_Click(object sender, RoutedEventArgs e)
    {
      MainWindow window = new MainWindow();
      window.Show();
      window.Top = this.Top;
      window.Left = this.Left;
      this.Close();
    }
    private void ChatNavBar_Click(object sender, RoutedEventArgs e)
    {
      PartyChats window = new PartyChats();
      window.Show();
      window.Top = this.Top;
      window.Left = this.Left;
      this.Close();
    }
  }
}
