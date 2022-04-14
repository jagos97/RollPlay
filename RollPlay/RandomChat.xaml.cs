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
    public partial class RandomChat : Window
    {

        public string prompt { get; set; }

        public RandomChat(string prompt)
        {

            this.prompt = prompt;
            InitializeComponent();


        }

        public void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            ExploreTavernWindow window = new ExploreTavernWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        public void ChatSubMenu_Click(object sender, RoutedEventArgs e)
        {
            //TODO
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

