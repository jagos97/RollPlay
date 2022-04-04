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

    public partial class ShopWindow : Window
    { 
        public List<string> items { get; set; }
        public List<string> prices { get; set; }
        public string ShopName { get; set; }
        public string ShopKeep { get; set; }
        public string PartyName { get; set; }
        public string PlayerName { get; set; }

        private static bool navBarMenuShown = false;




        public ShopWindow(string ShopName, string ShopKeep, List<string> items, List<string> prices, string PartyName, string PlayerName)
        {
            this.ShopName = ShopName;
            this.ShopKeep = ShopKeep;
            this.items = items;
            this.prices = prices;
            this.PartyName = PartyName;
            this.PlayerName = PlayerName;
            InitializeComponent();


            for (int i = 0; i < items.Count; i++)
            {
                StackPanel stackPanel = new StackPanel();
                stackPanel.Orientation = Orientation.Horizontal;

                Label label1 = new Label();
                label1.Content = items[i];
                label1.FontSize = 16;
                label1.FontWeight = FontWeights.Light;
                label1.Margin = new Thickness(10, -10, 140, 0);

                Label label2 = new Label();
                label2.Content = prices[i];
                label2.FontSize = 16;
                label2.FontWeight = FontWeights.Light;
                label2.Margin = new Thickness(0, -10 ,10, 0);


                stackPanel.Children.Add(label1);
                stackPanel.Children.Add(label2);
                ShopMenu.Children.Add(stackPanel);

            }


        }

        public void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            PartyPageWindow window = new PartyPageWindow(PartyName, PlayerName);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        public void ChatSubMenu_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        private void MenuNavBar_Click(object sender, RoutedEventArgs e)
        {
            if (navBarMenuShown)
            {
                navBarMenuHolder.Children.Clear();
                navBarMenuShown = false;
            }
            else
            {
                HamburgerMenu menu = new HamburgerMenu();
                navBarMenuHolder.Children.Clear();
                navBarMenuHolder.Children.Add(menu);
                navBarMenuShown = true;

            }
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

