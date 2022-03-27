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
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>

    public partial class BarkeeperInformationWindow : Window
    {
        public string title { get; set; }
        public string desc1 { get; set; }
        public string desc2 { get; set; }
        public string desc3 { get; set; }
        public string redirect { get; set; }

        public BarkeeperInformationWindow(string title, string desc1, string desc2, string desc3, string redirect)
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
    }
}
