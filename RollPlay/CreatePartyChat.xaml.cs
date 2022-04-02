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
    public partial class CreatePartyChat : UserControl
    {

        public CreatePartyChat()
        {
            InitializeComponent();
                 
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            PartyPageWindow.chatPopupShown = false;

        }

        private void Camp_Selected(object sender, RoutedEventArgs e)
        {
            this.ShopInfo.Visibility = Visibility.Collapsed;
            //FINISH
        }

        private void Shop_Selected(object sender, RoutedEventArgs e)
        {
            this.ShopInfo.Visibility = Visibility.Visible;
            //FINSI
            
        }

        private void Inn_Selected(object sender, RoutedEventArgs e)
        {
            this.ShopInfo.Visibility = Visibility.Collapsed;
            //FINISH
        }

        private void Other_Selected(object sender, RoutedEventArgs e)
        {
            this.ShopInfo.Visibility = Visibility.Collapsed;
            //FINISH
        }
    }
}
