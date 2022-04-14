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

        public string schedSession { get; set; }

        public StackPanel memberSelected = null;
        public string nameOfSelected = null;

        public EditPartyWindow(string PartyName, string PlayerName, List<string> friendsList, string schedSession)
        {
            this.friendsList = friendsList;
            this.PartyName = PartyName;
            this.PlayerName = PlayerName;
            this.InitialName = PartyName;
            this.schedSession = schedSession;
            InitializeComponent();

            StackPanel stack = new StackPanel();
            stack.Orientation = Orientation.Vertical;
            stack.HorizontalAlignment = HorizontalAlignment.Center;
            stack.MaxWidth = 320;

            Button button = new Button();
            button.Height = 75;
            button.Width = 75;
            button.BorderThickness = new Thickness(0, 0, 0, 0);
            button.Margin = new Thickness(10, 10, 0, 0);

            BitmapImage bmi = new BitmapImage();
            ImageBrush brush = new ImageBrush();
            bmi.BeginInit();


            if (PlayerName.Equals("JYNX BOPDAWDLE"))
            {
                bmi.UriSource = new Uri("pack://application:,,,/pics/jynx.png", UriKind.Absolute);
                bmi.EndInit();
                brush.ImageSource = bmi;
                button.Background = brush;
            }

            else if (PlayerName.Equals("SCRAVEN MIZZRYM"))
            {
                bmi.UriSource = new Uri("pack://application:,,,/pics/scraven.png", UriKind.Absolute);
                bmi.EndInit();
                brush.ImageSource = bmi;
                button.Background = brush;

            }
            else
            {
                bmi.UriSource = new Uri("pack://application:,,,/pics/user.png", UriKind.Absolute);
                bmi.EndInit();
                brush.ImageSource = bmi;
                button.Background = brush;

            }

            TextBlock textBlock = new TextBlock();
            textBlock.HorizontalAlignment = HorizontalAlignment.Center;
            textBlock.TextWrapping = TextWrapping.Wrap;
            textBlock.TextAlignment = TextAlignment.Center;
            textBlock.MaxWidth = 75;
            textBlock.Text = PlayerName;
            textBlock.Margin = new Thickness(10, 5, 0, 0);
            textBlock.Foreground = Brushes.White;

            stack.Children.Add(button);
            stack.Children.Add(textBlock);
            PartyMembers.Children.Add(stack);

            if (friendsList.Count > 0)
            {
                foreach (string friend in friendsList)
                {
                    StackPanel stack1 = new StackPanel();
                    stack1.Orientation = Orientation.Vertical;
                    stack1.HorizontalAlignment = HorizontalAlignment.Center;

                    Button button1 = new Button();
                    button1.Height = 75;
                    button1.Width = 75;
                    button1.BorderThickness = new Thickness(0, 0, 0, 0);
                    button1.Margin = new Thickness(10, 10, 0, 0);

                    BitmapImage bmi1 = new BitmapImage();
                    ImageBrush brush1 = new ImageBrush();
                    bmi1.BeginInit();

                    if (friend.Equals("Michael"))
                    {
                        bmi1.UriSource = new Uri("pack://application:,,,/pics/michael.png", UriKind.Absolute);
                        bmi1.EndInit();
                        brush1.ImageSource = bmi1;
                        button1.Background = brush1;
                    }
                    else if (friend.Equals("Pam"))
                    {
                        bmi1.UriSource = new Uri("pack://application:,,,/pics/pam.png", UriKind.Absolute);
                        bmi1.EndInit();
                        brush1.ImageSource = bmi1;
                        button1.Background = brush1;
                    }
                    else if (friend.Equals("Phyllis"))
                    {
                        bmi1.UriSource = new Uri("pack://application:,,,/pics/phyllis.png", UriKind.Absolute);
                        bmi1.EndInit();
                        brush1.ImageSource = bmi1;
                        button1.Background = brush1;
                    }
                    else if (friend.Equals("Dwight"))
                    {
                        bmi1.UriSource = new Uri("pack://application:,,,/pics/dwight.png", UriKind.Absolute);
                        bmi1.EndInit();
                        brush1.ImageSource = bmi1;
                        button1.Background = brush1;
                    }
                    else if (friend.Equals("Kelly"))
                    {
                        bmi1.UriSource = new Uri("pack://application:,,,/pics/kelly.png", UriKind.Absolute);
                        bmi1.EndInit();
                        brush1.ImageSource = bmi1;
                        button1.Background = brush1;
                    }
                    else if (friend.Equals("Stanley"))
                    {
                        bmi1.UriSource = new Uri("pack://application:,,,/pics/stanley.png", UriKind.Absolute);
                        bmi1.EndInit();
                        brush1.ImageSource = bmi1;
                        button1.Background = brush1;
                    }
                    else if (friend.Equals("Creed"))
                    {
                        bmi1.UriSource = new Uri("pack://application:,,,/pics/creed.png", UriKind.Absolute);
                        bmi1.EndInit();
                        brush1.ImageSource = bmi1;
                        button1.Background = brush1;
                    }
                    else if (friend.Equals("Jim"))
                    {
                        bmi1.UriSource = new Uri("pack://application:,,,/pics/jim.png", UriKind.Absolute);
                        bmi1.EndInit();
                        brush1.ImageSource = bmi1;
                        button1.Background = brush1;
                    }
                    else if (friend.Equals("Ryan"))
                    {
                        bmi1.UriSource = new Uri("pack://application:,,,/pics/ryan.png", UriKind.Absolute);
                        bmi1.EndInit();
                        brush1.ImageSource = bmi1;
                        button1.Background = brush1;
                    }
                    else if (friend.Equals("Daryl"))
                    {
                        bmi1.UriSource = new Uri("pack://application:,,,/pics/daryl.png", UriKind.Absolute);
                        bmi1.EndInit();
                        brush1.ImageSource = bmi1;
                        button1.Background = brush1;
                    }
                    else if (friend.Equals("Angela"))
                    {
                        bmi1.UriSource = new Uri("pack://application:,,,/pics/angela.png", UriKind.Absolute);
                        bmi1.EndInit();
                        brush1.ImageSource = bmi1;
                        button1.Background = brush1;
                    }
                    else if (friend.Equals("Oscar"))
                    {
                        bmi1.UriSource = new Uri("pack://application:,,,/pics/oscar.png", UriKind.Absolute);
                        bmi1.EndInit();
                        brush1.ImageSource = bmi1;
                        button1.Background = brush1;
                    }
                    else if (friend.Equals("Kevin"))
                    {
                        bmi1.UriSource = new Uri("pack://application:,,,/pics/kevin.png", UriKind.Absolute);
                        bmi1.EndInit();
                        brush1.ImageSource = bmi1;
                        button1.Background = brush1;
                    }
                    else if (friend.Equals("Meredith"))
                    {
                        bmi1.UriSource = new Uri("pack://application:,,,/pics/meredith.png", UriKind.Absolute);
                        bmi1.EndInit();
                        brush1.ImageSource = bmi1;
                        button1.Background = brush1;
                    }
                    else
                    {
                        bmi1.UriSource = new Uri("pack://application:,,,/pics/user.png", UriKind.Absolute);
                        bmi1.EndInit();
                        brush1.ImageSource = bmi1;
                        button1.Background = brush1;
                    }

                    Button removeButton = new Button();
                    removeButton.Height = 30;
                    removeButton.Width = 30;
                    removeButton.Click += RemovePlayer_Click;
                    removeButton.Margin = new Thickness(50, -125, 0, 0);
                    removeButton.BorderThickness = new Thickness(0, 0, 0, 0);
                    BitmapImage bmi2 = new BitmapImage();
                    ImageBrush brush2 = new ImageBrush();
                    bmi2.BeginInit();
                    bmi2.UriSource = new Uri("pack://application:,,,/pics/removeicon.png", UriKind.Absolute);
                    bmi2.EndInit();
                    brush2.ImageSource = bmi2;
                    removeButton.Background = brush2;

                    TextBlock textBlock1 = new TextBlock();
                    textBlock1.HorizontalAlignment = HorizontalAlignment.Center;
                    textBlock1.TextWrapping = TextWrapping.Wrap;
                    textBlock1.TextAlignment = TextAlignment.Center;
                    textBlock1.MaxWidth = 75;
                    textBlock1.Text = friend;
                    textBlock1.Margin = new Thickness(10, 5, 0, 0);
                    textBlock1.Foreground = Brushes.White;

                    stack1.Children.Add(button1);
                    stack1.Children.Add(removeButton);
                    stack1.Children.Add(textBlock1);
                    PartyMembers.Children.Add(stack1);
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
            PartyPageWindow window = new PartyPageWindow(PartyName, PlayerName, null, null, friendsList, schedSession);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(NewName.Text))
            {
                this.PartyName = this.InitialName;
                PartyPageWindow window = new PartyPageWindow(PartyName, PlayerName, null, null, friendsList, schedSession);
                window.Show();
                window.Top = this.Top;
                window.Left = this.Left;
                this.Close();
            } else
            {
                NameError.Visibility = Visibility.Visible;
                NewName.BorderBrush = Brushes.Red;
            }
        }

        private void RemovePlayer_Click(object sender, RoutedEventArgs e)
        {
            memberSelected = (StackPanel)((Button)sender).Parent;

            foreach(UIElement item in memberSelected.Children)
            {
                if (item is TextBlock)
                {
                    TextBlock textBlock = item as TextBlock;
                    nameOfSelected = textBlock.Text.ToString();
                    System.Diagnostics.Debug.WriteLine(nameOfSelected);
                }
            }

            ConfirmDelete confirm = new ConfirmDelete();
            overlay.Children.Clear();
            overlay.Children.Add(confirm);
        }

        public void RemovePlayer()
        {
            PartyMembers.Children.Remove(memberSelected);
            friendsList.Remove(nameOfSelected);
            overlay.Children.Clear();
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
