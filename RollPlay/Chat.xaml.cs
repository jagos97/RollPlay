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

    public partial class Chat : Window
    {


        private static bool navBarMenuShown = false;
        private static string UserName = "";




        public Chat(List<string> messages = null, List<string> senders =null, string chatName = "User1", string subname = "Azog", string name = "Me")
        {
            InitializeComponent();
            UserName = "r"+ name;
            if(messages == null)
            {
                Label label = new Label();
                label.Content = "DM";
                label.Margin = new Thickness(5, 10, 15, 0);
                Border bdr = MakeBorder("l");
                TextBlock tb = MakeTextBlock("This is where the story begins. In the depth of the abyss. Where no one will come to your aid");
                bdr.Child = tb;
                messsageHolder.Children.Add(label);
                messsageHolder.Children.Add(bdr);

            }
            else
            {
                for (int i = 0; i < messages.Count; i++)
                {
                    Label lbl = MakeLabel(senders[i]);
                    Border bdr = MakeBorder(senders[i]);
                    TextBlock tb = MakeTextBlock(messages[i]);
                    bdr.Child = tb;
                    messsageHolder.Children.Add(lbl);
                    messsageHolder.Children.Add(bdr);
                }
            }
            ChatName.Content = chatName;
            SubName.Content = subname;

        }

        private Label MakeLabel(string v)
        {
            Label label = new Label();
            if (v.StartsWith('r'))
            {
                label.HorizontalAlignment = HorizontalAlignment.Right;
            }
            label.Content = v.Substring(1);
            label.Margin = new Thickness(5, 10, 15, 0);
            return label;
        }

        private TextBlock MakeTextBlock(string v)
        {
            TextBlock textBlock = new TextBlock();
            textBlock.TextWrapping = TextWrapping.Wrap;
            textBlock.Text = v;
            textBlock.HorizontalAlignment = HorizontalAlignment.Stretch;
            textBlock.FontSize = 16;
            textBlock.MaxWidth = 230;
            textBlock.Foreground = new SolidColorBrush(Colors.White);
            textBlock.Padding = new Thickness(10);
            return textBlock;
        }

        private Border MakeBorder(string sender)
        {
            Border bdr = new Border();
            bdr.HorizontalAlignment = HorizontalAlignment.Left;
            bdr.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF504B43"));
            if (sender.StartsWith('r'))
            {
                bdr.HorizontalAlignment = HorizontalAlignment.Right;
                bdr.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF556D7A"));
            }
            bdr.CornerRadius = new CornerRadius(10);
            bdr.Margin = new Thickness(0,0,15,0);

            return bdr;

        }

        public void Back_Click(object sender, RoutedEventArgs e)
        {
            PartyChats window = new PartyChats();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        public void Send_Message_Click(object sender, RoutedEventArgs e)
        {
            Border bdr = MakeBorder("r" + UserName);
            Label lbl = MakeLabel("r" + UserName);
            TextBlock tb = MakeTextBlock(MessageBar.Text);
            bdr.Child = tb;
            messsageHolder.Children.Add(lbl);
            messsageHolder.Children.Add(bdr);
            MessageBar.Text = "";

        }

        public void ChatSubMenu_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }
    }
}

