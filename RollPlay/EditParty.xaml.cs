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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class EditPartyWindow : Window
    {

        private static bool navBarMenuShown = false;

        public static StackPanel playerSelected = null;

        public string PartyName { get; set; }
        public string InitialName { get; set; }

        public string PlayerName { get; set; }

        public static bool invitePopupShown = false;
        public static bool popupShown = false;
        public static bool chatPopupShown = false;
        public static Border partySelected = null;

        public List<string> friendsList = new List<string>();

        public EditPartyWindow(string PartyName, string PlayerName, List<string> friendsList)
        {
            this.friendsList = friendsList;
            this.PartyName = PartyName;
            this.PlayerName = PlayerName;
            this.InitialName = PartyName;
            InitializeComponent();

                if (friendsList.Count > 0)
            {
                foreach (string friend in friendsList)
                {
                    StackPanel stack = new StackPanel();
                    stack.Orientation = Orientation.Vertical;
                    stack.HorizontalAlignment = HorizontalAlignment.Center;

                    Button button = new Button();
                    button.Height = 75;
                    button.Width = 75;
                    button.BorderThickness = new Thickness(0, 0, 0, 0);
                    button.Margin = new Thickness(10, 10, 0, 0);

                    BitmapImage bmi = new BitmapImage();
                    ImageBrush brush = new ImageBrush();
                    bmi.BeginInit();
                    bmi.UriSource = new Uri("pack://application:,,,/pics/defaultCharacter.png", UriKind.Absolute);
                    bmi.EndInit();
                    brush.ImageSource = bmi;
                    button.Background = brush;

                    Button removeButton = new Button();
                    removeButton.Height = 40;
                    removeButton.Width = 40;
                    removeButton.Click += RemovePlayer_Click;
                    removeButton.Margin = new Thickness(50, -125, 0, 0);
                    removeButton.BorderThickness = new Thickness(0, 0, 0, 0);
                    BitmapImage bmi1 = new BitmapImage();
                    ImageBrush brush1 = new ImageBrush();
                    bmi1.BeginInit();
                    bmi1.UriSource = new Uri("pack://application:,,,/pics/remove.png", UriKind.Absolute);
                    bmi1.EndInit();
                    brush1.ImageSource = bmi1;
                    removeButton.Background = brush1;

                    TextBlock textBlock = new TextBlock();
                    textBlock.HorizontalAlignment = HorizontalAlignment.Center;
                    textBlock.TextWrapping = TextWrapping.Wrap;
                    textBlock.TextAlignment = TextAlignment.Center;
                    textBlock.MaxWidth = 75;
                    textBlock.Text = friend;
                    textBlock.Margin = new Thickness(10, 5, 0, 0);

                    stack.Children.Add(button);
                    stack.Children.Add(removeButton);
                    stack.Children.Add(textBlock);
                    PartyMembers.Children.Add(stack);
                }

            }
        }

        private void MainChat_Click(object sender, RoutedEventArgs e)
        {
            return;
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            PartiesWindow window = new PartiesWindow();
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

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scrollViewer = (ScrollViewer)sender;
            if (e.Delta > 0)
            {
                scrollViewer.LineLeft();
            }
            else
            {
                scrollViewer.LineRight();
            }
            e.Handled = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            PartyPageWindow window = new PartyPageWindow(PartyName, PlayerName, null, null, friendsList);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            this.PartyName = this.InitialName;
            PartyPageWindow window = new PartyPageWindow(PartyName, PlayerName, null, null, friendsList);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void RemovePlayer_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                Button remove = sender as Button;
                if (remove.Parent is StackPanel)
                {
                    StackPanel stack = remove.Parent as StackPanel;
                    if (stack != null)
                    {
                        foreach (UIElement item in stack.Children)
                        {
                            if (item is TextBlock)
                            {
                                TextBlock friendBlock = item as TextBlock;
                                string friend = friendBlock.Text.ToString();
                                friendsList.Remove(friend);
                                stack.Visibility = Visibility.Collapsed;
                            }
                        }
                    }
                }
            }
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
    }
}
