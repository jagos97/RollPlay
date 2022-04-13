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
    public partial class InviteSentConfirmation : UserControl
    {
      
  

        public InviteSentConfirmation()
        {
           
            InitializeComponent();
     
        }


        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is Chat)
            {
                Chat window = Window.GetWindow(this) as Chat;
                window.ClearEverything();
            } else if (Window.GetWindow(this) is TavernChat)
            {
                TavernChat window = Window.GetWindow(this) as TavernChat;
                window.confirmPanel.Children.Clear();
            }
            
        }

        


    }
}
