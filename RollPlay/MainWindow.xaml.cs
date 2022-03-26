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

        public MainWindow()
        {
            InitializeComponent();
            MainGrid.Focus();
            ChangNavBarSelected();

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
                ChangNavBarSelected();
            }
            if (e.Key == Key.A)
            {
                navbarSelected = navbarSelected - 1;
                if (navbarSelected < 0)
                {
                    navbarSelected = 4;
                }
                ChangNavBarSelected();
            }
            if(e.Key == Key.Right)
            {
                TavernMenuWindow britt = new TavernMenuWindow();
                britt.Show();
                this.Close();
            }

            if (e.Key == Key.Left)
            {
                Window3 applePie = new Window3();
                applePie.Show();
                this.Close();

            }
            if (e.Key == Key.Up)
            {
                Window1 poncho = new Window1();
                poncho.Show();
                poncho.Top = this.Top;
                poncho.Left = this.Left;
                this.Close();
            }

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

        private void PartiesCollectionSubMenuSelector_Click(object sender, RoutedEventArgs e)
        {
            PartiesWindow window = new PartiesWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void FriendsCollectionSubMenuSelector_Click(object sender, RoutedEventArgs e)
        {
            FriendsWindow window = new FriendsWindow();
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
    }
}
