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
    public partial class PartySubMenu : UserControl
    {
        public PartySubMenu()
        {
            InitializeComponent();
        }

        private void LeaveParty_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is PartiesWindow)
            {
                PartiesWindow window = Window.GetWindow(this) as PartiesWindow;
                ConfirmDelete confirm = new ConfirmDelete();
                window.overlay.Children.Clear();
                window.overlay.Children.Add(confirm);
            }
        }
    }
}
