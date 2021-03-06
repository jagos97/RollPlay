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
    public partial class TavernChat : Window
    {
        private static bool popupShown = false;



        public TavernChat()
        {
            InitializeComponent();

        }

        public void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            FindFriendsMenuWindow window = new FindFriendsMenuWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ContextMenu menu = button.ContextMenu;
            menu.PlacementTarget = button;
            menu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            menu.HorizontalOffset = -150;
            menu.IsOpen = true;
        }

        public void ChatSubMenu_Click(object sender, RoutedEventArgs e)
        {

            popupPanel.Children.Clear();
            ChatPartySubMenu menu = new ChatPartySubMenu();
            popupPanel.Children.Add(menu);
        }


        private void TavernNavBar_Click(object sender, RoutedEventArgs e)
        {
            TavernMenuWindow window = new TavernMenuWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            overlayPanel.Visibility = Visibility.Collapsed;
        }

        public void SeeMembersInChat()
        {
            popupShown = false;
        }

        public void InviteToParty_Click(object sender, RoutedEventArgs e)
        {

            InviteSentConfirmation sent = new InviteSentConfirmation();
            confirmPanel.Children.Add(sent);
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

