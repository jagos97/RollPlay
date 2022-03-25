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
    public partial class TavernMenuWindow : Window
    {
        public TavernMenuWindow()
        {
            InitializeComponent();
        }

        private void CommonerMenuSelector_Click(object sender, RoutedEventArgs e)
        {
            CommonerMenuWindow window = new CommonerMenuWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

    }
}
