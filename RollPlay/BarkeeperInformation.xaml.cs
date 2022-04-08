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
using System.Diagnostics;
using System.Windows.Navigation;

namespace RollPlay
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>

    public partial class BarkeeperInformationWindow : Window
    {
        public string title { get; set; }
        public string desc1 { get; set; }
        public string desc2 { get; set; }
        public string desc3 { get; set; }
        public Uri redirect { get; set; }

        private static bool navBarMenuShown = false;

        public BarkeeperInformationWindow(string title, string desc1, string desc2, string desc3, Uri redirect)
        {
            this.title = title;
            this.desc1 = desc1;
            this.desc2 = desc2;
            this.desc3 = desc3;
            this.redirect = redirect;

            InitializeComponent();
        }

        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
        
            CommonerMenuWindow window = new CommonerMenuWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void CollectionNavBar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GoBack.Visibility = Visibility.Collapsed;
            Redirect.Visibility = Visibility.Visible;
            Response.Visibility = Visibility.Visible;

        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true});
            e.Handled = true;
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            CommonerMenuWindow window = new CommonerMenuWindow();
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
            } else
            {
                HamburgerMenu menu = new HamburgerMenu();
                navBarMenuHolder.Children.Clear();
                navBarMenuHolder.Children.Add(menu);
                navBarMenuShown=true;

            }
        }
    }
}
