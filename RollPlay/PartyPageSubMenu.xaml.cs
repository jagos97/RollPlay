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
    public partial class PartyPageSubMenu : UserControl
    {
        public PartyPageSubMenu()
        {
            InitializeComponent();
        }

        public void SwapCharacter_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }
        public void EditPrty_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        public void LeaveParty_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        public void NotImplemented_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Under Construction");
        }
    }
}
