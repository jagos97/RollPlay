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
    public partial class MainWindow : Window
    {
        private static int navbarSelected = 0;
        private static Thickness blank = new Thickness(0, 0, 0, 0);
        private static Thickness active = new Thickness(0, 4, 0, 0);
        private static SolidColorBrush lightBlue = new SolidColorBrush(Color.FromArgb(0xFF, 0x95, 0xDA, 0xDE));

        public MainWindow()
        {
            InitializeComponent();
            noCharacterMessage.Visibility = Visibility.Collapsed;
            MainGrid.Focus();
            ChangNavBarSelected();
            //PartiesCollectionSubMenuSelector.BorderBrush = lightBlue;

        }



        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D)
            {
                navbarSelected = navbarSelected + 1;
                if(navbarSelected > 4)
                {
                   navbarSelected = 0;
                }
            }
            if (e.Key == Key.A)
            {
                navbarSelected = navbarSelected - 1;
                if (navbarSelected < 0)
                {
                    navbarSelected = 4;
                }
            }
            ChangNavBarSelected();
        }

        private void ChangNavBarSelected()
        {
            if(navbarSelected == 0)
            {
                CollectionNavBar.BorderThickness = active;
                TavernNavBar.BorderThickness = blank;
                ChatNavBar.BorderThickness = blank;
                NotificationNavBar.BorderThickness = blank;
                MenuNavBar.BorderThickness = blank;

            }
            else if (navbarSelected == 1)
            {
                CollectionNavBar.BorderThickness = blank;
                TavernNavBar.BorderThickness = active;
                ChatNavBar.BorderThickness = blank;
                NotificationNavBar.BorderThickness = blank;
                MenuNavBar.BorderThickness = blank;

            }
            else if(navbarSelected == 2)
            {
                CollectionNavBar.BorderThickness = blank;
                TavernNavBar.BorderThickness = blank;
                ChatNavBar.BorderThickness = active;
                NotificationNavBar.BorderThickness = blank;
                MenuNavBar.BorderThickness = blank;

            }
            else if(navbarSelected == 3)
            {
                CollectionNavBar.BorderThickness = blank;
                TavernNavBar.BorderThickness = blank;
                ChatNavBar.BorderThickness = blank;
                NotificationNavBar.BorderThickness = active;
                MenuNavBar.BorderThickness = blank;

            }
            else if(navbarSelected == 4)
            {
                CollectionNavBar.BorderThickness = blank;
                TavernNavBar.BorderThickness = blank;
                ChatNavBar.BorderThickness = blank;
                NotificationNavBar.BorderThickness = blank;
                MenuNavBar.BorderThickness = active;

            }
        }
    }
}
