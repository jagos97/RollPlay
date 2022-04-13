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
        public string Description { get; set; }

        public string schedSession { get; set; }


        private static bool navBarMenuShown = false;




        public ShopWindow(string ShopName, string ShopKeep, List<string> items, List<string> prices, string PartyName, string PlayerName, string Description, string schedSession)
        {


            this.ShopName = ShopName;
            this.ShopKeep = ShopKeep;
            this.items = items;
            this.prices = prices;
            this.PartyName = PartyName;
            this.PlayerName = PlayerName;
            this.Description = Description;
            this.schedSession = schedSession;
            InitializeComponent();

            if (items.Count > 0)
            {
                ShopViewer.Visibility = Visibility.Visible;

                for (int i = 0; i < items.Count; i++)
                {
                    StackPanel stackPanel = new StackPanel();
                    stackPanel.Orientation = Orientation.Horizontal;
                    stackPanel.Visibility = Visibility.Visible;

                    TextBlock label1 = new TextBlock();
                    label1.Text = items[i];
                    label1.FontSize = 14;
                    label1.FontWeight = FontWeights.Light;
                    label1.Margin = new Thickness(15, 0, 0, 0);
                    label1.Width = 175;
                    label1.TextWrapping = TextWrapping.Wrap;
                    label1.Foreground = Brushes.White;

                    TextBlock label2 = new TextBlock();
                    label2.Text = prices[i];
                    label2.FontSize = 14;
                    label2.FontWeight = FontWeights.Light;
                    label2.Margin = new Thickness(0, 0, 0, 0);
                    label2.Width = 75;
                    label2.TextWrapping = TextWrapping.Wrap;
                    label2.Foreground = Brushes.White;


                    stackPanel.Children.Add(label1);
                    stackPanel.Children.Add(label2);
                    ShopMenu.Children.Add(stackPanel);

                }
            }


        }

        public void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            PartyPageWindow window = new PartyPageWindow(PartyName, PlayerName, ShopName, Description, null, schedSession);
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

        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            BlockUIContainer block = new BlockUIContainer();
            Label label = new Label();

            label.Foreground = Brushes.White;
            label.Content = "Me";
            label.FontSize = 8;
            label.Margin= new Thickness(0,0,10,-3);
            label.Opacity = .5;
            label.FontStyle = FontStyles.Italic;
            label.HorizontalAlignment = HorizontalAlignment.Right;

            block.Child = label;

            BlockUIContainer block1 = new BlockUIContainer();
            Border border = new Border();
            TextBlock textBlock = new TextBlock();

            System.Drawing.Color myColor = System.Drawing.ColorTranslator.FromHtml("#BB8282");
            border.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
            border.BorderThickness = new Thickness(5, 5, 5, 5);
            border.CornerRadius = new CornerRadius(5);
            border.MaxWidth = 200;
            border.HorizontalAlignment = HorizontalAlignment.Right;
            border.Margin = new Thickness(0, 0, 10, 0);
            System.Windows.Media.RenderOptions.SetEdgeMode((DependencyObject)border, EdgeMode.Aliased);

            textBlock.Foreground = Brushes.White;
            textBlock.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
            textBlock.TextWrapping = TextWrapping.Wrap;
            textBlock.MaxWidth = 200;
            textBlock.Text = Message.Text.ToString();
            Message.Clear();

            border.Child = textBlock;

            block1.Child = border;

            flowdoc_chat_wnd.Blocks.Add(block);
            flowdoc_chat_wnd.Blocks.Add(block1);


        }

    }
}

