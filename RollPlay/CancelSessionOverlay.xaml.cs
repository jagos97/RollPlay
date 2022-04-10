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
    public partial class CancelSession : UserControl
    {
      
  

        public CancelSession()
        {
           
            InitializeComponent();
     
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            PartyPageWindow window = Window.GetWindow(this) as PartyPageWindow;
            window.overlay.Children.Clear();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            PartyPageWindow window = Window.GetWindow(this) as PartyPageWindow;
            window.SessionText.Text = "No Session Scheduled";
            window.schedSession = "No Sessoin Scheduled";
            window.TrashSched.Visibility = Visibility.Collapsed;
            window.overlay.Children.Clear();
        }

        


    }
}
