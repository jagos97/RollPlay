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
    public partial class InfoPrompt : UserControl
    {
      
  

        public InfoPrompt()
        {
            
            InitializeComponent();
                 
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            PartyAvailabilityWindow window = Window.GetWindow(this) as PartyAvailabilityWindow;
            window.InfoPanel.Children.Clear();
        }


        


    }
}
