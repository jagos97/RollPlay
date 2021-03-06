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
using System.Windows.Media.Effects;

namespace RollPlay
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class PartyPageWindow : Window
    {
        private static bool navBarMenuShown = false;

        public string PartyName { get; set; }

        public string PlayerName { get; set; }

        public string ChatName { get; set; }

        public string Description { get; set; }

        public string friendName { get; set; }

        public string schedSession { get; set; }

        public string photo { get; set; }

        public static bool popupShown = false;
        public static Border partySelected = null;
        public List<string> friendsList = new List<string>();
        public Border chatSelected = null;

        public PartyPageWindow(string PartyName, string PlayerName, string ChatName, string Description, List<string> friendsList, string schedSession)
        {
            
            if (friendsList != null)
            {
                this.friendsList = friendsList;
                this.PartyName = PartyName;
                this.PlayerName = PlayerName;
                this.schedSession = schedSession;

                InitializeComponent();

                if (!schedSession.Equals("No Session Scheduled"))
                {
                    TrashSched.Visibility = Visibility.Visible;
                }

                StackPanel stack1 = new StackPanel();
                stack1.Orientation = Orientation.Vertical;
                stack1.HorizontalAlignment = HorizontalAlignment.Center;
                stack1.MaxWidth = 320;

                Button button1 = new Button();
                button1.Height = 75;
                button1.Width = 75;
                button1.BorderThickness = new Thickness(0, 0, 0, 0);
                button1.Margin = new Thickness(10, 10, 0, 0);

                BitmapImage bmi1 = new BitmapImage();
                ImageBrush brush1 = new ImageBrush();
                bmi1.BeginInit();


                if (PlayerName.Equals("JYNX BOPDAWDLE"))
                {
                    bmi1.UriSource = new Uri("pack://application:,,,/pics/jynx.png", UriKind.Absolute);
                    bmi1.EndInit();
                    brush1.ImageSource = bmi1;
                    button1.Background = brush1;
                }

                else if (PlayerName.Equals("SCRAVEN MIZZRYM"))
                {
                    bmi1.UriSource = new Uri("pack://application:,,,/pics/scraven.png", UriKind.Absolute);
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

                TextBlock textBlock1 = new TextBlock();
                textBlock1.HorizontalAlignment = HorizontalAlignment.Center;
                textBlock1.TextWrapping = TextWrapping.Wrap;
                textBlock1.TextAlignment = TextAlignment.Center;
                textBlock1.MaxWidth = 75;
                textBlock1.Text = PlayerName;
                textBlock1.Margin = new Thickness(10, 5, 0, 0);
                textBlock1.Foreground = Brushes.White;

                stack1.Children.Add(button1);
                stack1.Children.Add(textBlock1);
                PartyMembers.Children.Add(stack1);

                if (friendsList.Count > 0)
                {
                    foreach (string friend in friendsList)
                    {
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

                        if (friend.Equals("Michael"))
                        {
                            bmi.UriSource = new Uri("pack://application:,,,/pics/michael.png", UriKind.Absolute);
                            bmi.EndInit();
                            brush.ImageSource = bmi;
                            button.Background = brush;
                        }
                        else if (friend.Equals("Pam"))
                        {
                            bmi.UriSource = new Uri("pack://application:,,,/pics/pam.png", UriKind.Absolute);
                            bmi.EndInit();
                            brush.ImageSource = bmi;
                            button.Background = brush;
                        }
                        else if (friend.Equals("Phyllis"))
                        {
                            bmi.UriSource = new Uri("pack://application:,,,/pics/phyllis.png", UriKind.Absolute);
                            bmi.EndInit();
                            brush.ImageSource = bmi;
                            button.Background = brush;
                        }
                        else if (friend.Equals("Dwight"))
                        {
                            bmi.UriSource = new Uri("pack://application:,,,/pics/dwight.png", UriKind.Absolute);
                            bmi.EndInit();
                            brush.ImageSource = bmi;
                            button.Background = brush;
                        }
                        else if (friend.Equals("Kelly"))
                        {
                            bmi.UriSource = new Uri("pack://application:,,,/pics/kelly.png", UriKind.Absolute);
                            bmi.EndInit();
                            brush.ImageSource = bmi;
                            button.Background = brush;
                        }
                        else if (friend.Equals("Stanley"))
                        {
                            bmi.UriSource = new Uri("pack://application:,,,/pics/stanley.png", UriKind.Absolute);
                            bmi.EndInit();
                            brush.ImageSource = bmi;
                            button.Background = brush;
                        }
                        else if (friend.Equals("Creed"))
                        {
                            bmi.UriSource = new Uri("pack://application:,,,/pics/creed.png", UriKind.Absolute);
                            bmi.EndInit();
                            brush.ImageSource = bmi;
                            button.Background = brush;
                        }
                        else if (friend.Equals("Jim"))
                        {
                            bmi.UriSource = new Uri("pack://application:,,,/pics/jim.png", UriKind.Absolute);
                            bmi.EndInit();
                            brush.ImageSource = bmi;
                            button.Background = brush;
                        }
                        else if (friend.Equals("Ryan"))
                        {
                            bmi.UriSource = new Uri("pack://application:,,,/pics/ryan.png", UriKind.Absolute);
                            bmi.EndInit();
                            brush.ImageSource = bmi;
                            button.Background = brush;
                        }
                        else if (friend.Equals("Daryl"))
                        {
                            bmi.UriSource = new Uri("pack://application:,,,/pics/daryl.png", UriKind.Absolute);
                            bmi.EndInit();
                            brush.ImageSource = bmi;
                            button.Background = brush;
                        }
                        else if (friend.Equals("Angela"))
                        {
                            bmi.UriSource = new Uri("pack://application:,,,/pics/angela.png", UriKind.Absolute);
                            bmi.EndInit();
                            brush.ImageSource = bmi;
                            button.Background = brush;
                        }
                        else if (friend.Equals("Oscar"))
                        {
                            bmi.UriSource = new Uri("pack://application:,,,/pics/oscar.png", UriKind.Absolute);
                            bmi.EndInit();
                            brush.ImageSource = bmi;
                            button.Background = brush;
                        }
                        else if (friend.Equals("Kevin"))
                        {
                            bmi.UriSource = new Uri("pack://application:,,,/pics/kevin.png", UriKind.Absolute);
                            bmi.EndInit();
                            brush.ImageSource = bmi;
                            button.Background = brush;
                        }
                        else if (friend.Equals("Meredith"))
                        {
                            bmi.UriSource = new Uri("pack://application:,,,/pics/meredith.png", UriKind.Absolute);
                            bmi.EndInit();
                            brush.ImageSource = bmi;
                            button.Background = brush;
                        } else
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
                        textBlock.Text = friend;
                        textBlock.Margin = new Thickness(10, 5, 0, 0);
                        textBlock.Foreground = Brushes.White;

                        stack.Children.Add(button);
                        stack.Children.Add(textBlock);
                        PartyMembers.Children.Add(stack);
                    }
                }
            } else
            {
                this.PartyName = PartyName;
                this.PlayerName = PlayerName;
                this.schedSession = schedSession;
                InitializeComponent();

                if (!schedSession.Equals("No Session Scheduled"))
                {
                    TrashSched.Visibility = Visibility.Visible;
                }

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

                
            }

            if (ChatName != null && Description != null)
            {
                Border border = new Border();
                border.BorderThickness = new Thickness(0, 0, 0, 0);
                border.Height = 120;
                border.Width = 275;
                border.HorizontalAlignment = HorizontalAlignment.Center;
                border.CornerRadius = new CornerRadius(10);
                border.Margin = new Thickness(0, 5, 0, 30);
                DropShadowEffect effect = new DropShadowEffect();
                effect.Opacity = .35;
                effect.ShadowDepth = 1.5;
                border.Effect = effect;

                Button button = new Button();
                button.Background = Brushes.Transparent;
                button.BorderBrush = Brushes.Transparent;
                button.Height = 120;
                button.HorizontalContentAlignment = HorizontalAlignment.Left;
                button.VerticalContentAlignment = VerticalAlignment.Top;

                StackPanel stack = new StackPanel();
                stack.MaxWidth = 320;

                StackPanel stackHor = new StackPanel();
                stackHor.Orientation = Orientation.Horizontal;

                Label label = new Label();
                label.Content = ChatName.ToUpper();
                label.FontWeight = FontWeights.Bold;
                label.FontSize = 14;
                label.Width = 230;
                label.Margin = new Thickness(10, 5, 0, 0);
                label.Foreground = Brushes.White;

                Button muteButton = new Button();
                muteButton.Height = 20;
                muteButton.Width = 20;
                muteButton.BorderThickness = new Thickness(0, 0, 0, 0);
                muteButton.Margin = new Thickness(0, 10, 0, 0);

                BitmapImage bmi = new BitmapImage();
                ImageBrush brush = new ImageBrush();
                bmi.BeginInit();
                bmi.UriSource = new Uri("pack://application:,,,/pics/silence.png", UriKind.Absolute);
                bmi.EndInit();
                brush.ImageSource = bmi;
                muteButton.Background = brush;

                stackHor.Children.Add(label);
                stackHor.Children.Add(muteButton);

                StackPanel stackHor2 = new StackPanel();
                stackHor2.Orientation = Orientation.Horizontal;
                TextBlock textBlock = new TextBlock();
                textBlock.TextWrapping = TextWrapping.Wrap;
                textBlock.Width = 225;
                textBlock.FontWeight = FontWeights.Light;
                textBlock.Margin = new Thickness(15, 0, 0, 0);
                textBlock.FontSize = 13;
                textBlock.Text = Description;

                Button kebabButton = new Button();
                kebabButton.Height = 20;
                kebabButton.Width = 20;
                kebabButton.BorderThickness = new Thickness(0, 0, 0, 0);
                kebabButton.Margin = new Thickness(0, 30, 0, 0);

                BitmapImage bmi1 = new BitmapImage();
                ImageBrush brush1 = new ImageBrush();
                bmi1.BeginInit();
                bmi1.UriSource = new Uri("pack://application:,,,/pics/kebabmenu.png", UriKind.Absolute);
                bmi1.EndInit();
                brush1.ImageSource = bmi1;
                kebabButton.Background = brush1;

                stackHor2.Children.Add(textBlock);
                stackHor2.Children.Add(kebabButton);

                stack.Children.Add(stackHor);
                stack.Children.Add(stackHor2);

                button.Content = stack;
                border.Child = button;

                Chats.Children.Add(border);
            }    
        }

        private void MainChat_Click(object sender, RoutedEventArgs e)
        {
            //TODO
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

        private void PartyPageSubMenu_Click(object sender, RoutedEventArgs e)
        {
            if (popupShown)
            {
                SubMenuHolder.Children.Clear();
                popupShown = false;
            }
            else
            {
                PartyPageSubMenu subMenu = new PartyPageSubMenu(PartyName, PlayerName, friendsList);
                SubMenuHolder.Children.Clear();
                SubMenuHolder.Children.Add(subMenu);
                popupShown = true;
            }
            e.Handled = true;
        }

        private void InviteToParty_Click(object sender, RoutedEventArgs e)
        {
            InviteToParty inviteMenu = new InviteToParty();
            overlay.Children.Clear();
            overlay.Children.Add(inviteMenu);
        }

        private void CreatePartyChat_Click(object sender, RoutedEventArgs e)
        {
            CreatePartyChat chatMenu = new CreatePartyChat(PartyName, PlayerName, schedSession);
            overlay.Children.Clear();
            overlay.Children.Add(chatMenu);
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

        private void Button_Click(object sender, RoutedEventArgs e)
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

        private void Availability_Click(object sender, RoutedEventArgs e)
        {
            AltMyAvailabilityWindow window = new AltMyAvailabilityWindow(PartyName, PlayerName, null, schedSession);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void NotificationsNavBar_Click(object sender, RoutedEventArgs e)
        {
            NotificationsWindow window = new NotificationsWindow();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }        


        private void ChatNavBar_Click(object sender, RoutedEventArgs e)
        {
            PartyChats window = new PartyChats();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        public void addFriend(string friendName)
        {
            this.friendName = friendName;
            friendsList.Add(friendName);

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

            if (friendName.Equals("Michael"))
            {
                bmi.UriSource = new Uri("pack://application:,,,/pics/michael.png", UriKind.Absolute);
                bmi.EndInit();
                brush.ImageSource = bmi;
                button.Background = brush;
            }
            else if (friendName.Equals("Pam"))
            {
                bmi.UriSource = new Uri("pack://application:,,,/pics/pam.png", UriKind.Absolute);
                bmi.EndInit();
                brush.ImageSource = bmi;
                button.Background = brush;
            }
            else if (friendName.Equals("Phyllis"))
            {
                bmi.UriSource = new Uri("pack://application:,,,/pics/phyllis.png", UriKind.Absolute);
                bmi.EndInit();
                brush.ImageSource = bmi;
                button.Background = brush;
            }
            else if (friendName.Equals("Dwight"))
            {
                bmi.UriSource = new Uri("pack://application:,,,/pics/dwight.png", UriKind.Absolute);
                bmi.EndInit();
                brush.ImageSource = bmi;
                button.Background = brush;
            }
            else if (friendName.Equals("Kelly"))
            {
                bmi.UriSource = new Uri("pack://application:,,,/pics/kelly.png", UriKind.Absolute);
                bmi.EndInit();
                brush.ImageSource = bmi;
                button.Background = brush;
            }
            else if (friendName.Equals("Stanley"))
            {
                bmi.UriSource = new Uri("pack://application:,,,/pics/stanley.png", UriKind.Absolute);
                bmi.EndInit();
                brush.ImageSource = bmi;
                button.Background = brush;
            }
            else if (friendName.Equals("Creed"))
            {
                bmi.UriSource = new Uri("pack://application:,,,/pics/creed.png", UriKind.Absolute);
                bmi.EndInit();
                brush.ImageSource = bmi;
                button.Background = brush;
            }
            else if (friendName.Equals("Jim"))
            {
                bmi.UriSource = new Uri("pack://application:,,,/pics/jim.png", UriKind.Absolute);
                bmi.EndInit();
                brush.ImageSource = bmi;
                button.Background = brush;
            }
            else if (friendName.Equals("Ryan"))
            {
                bmi.UriSource = new Uri("pack://application:,,,/pics/ryan.png", UriKind.Absolute);
                bmi.EndInit();
                brush.ImageSource = bmi;
                button.Background = brush;
            }
            else if (friendName.Equals("Daryl"))
            {
                bmi.UriSource = new Uri("pack://application:,,,/pics/daryl.png", UriKind.Absolute);
                bmi.EndInit();
                brush.ImageSource = bmi;
                button.Background = brush;
            }
            else if (friendName.Equals("Angela"))
            {
                bmi.UriSource = new Uri("pack://application:,,,/pics/angela.png", UriKind.Absolute);
                bmi.EndInit();
                brush.ImageSource = bmi;
                button.Background = brush;
            }
            else if (friendName.Equals("Oscar"))
            {
                bmi.UriSource = new Uri("pack://application:,,,/pics/oscar.png", UriKind.Absolute);
                bmi.EndInit();
                brush.ImageSource = bmi;
                button.Background = brush;
            }
            else if (friendName.Equals("Kevin"))
            {
                bmi.UriSource = new Uri("pack://application:,,,/pics/kevin.png", UriKind.Absolute);
                bmi.EndInit();
                brush.ImageSource = bmi;
                button.Background = brush;
            }
            else if (friendName.Equals("Meredith"))
            {
                bmi.UriSource = new Uri("pack://application:,,,/pics/meredith.png", UriKind.Absolute);
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
            textBlock.Text = friendName;
            textBlock.Margin = new Thickness(10,5,0,0);
            textBlock.Foreground = Brushes.White;

            stack.Children.Add(button);
            stack.Children.Add(textBlock);
            PartyMembers.Children.Add(stack);
        }

        private void Kebab_Click(object sender, RoutedEventArgs e)
        {
            if (popupShown)
            {
                SubMenuHolder.Children.Clear();
                popupShown = false;
            }
            else
            {
                PartyChatSubMenu subMenu = new PartyChatSubMenu(PartyName, PlayerName, friendsList);
                SubMenuHolder.Children.Clear();
                SubMenuHolder.Children.Add(subMenu);
                popupShown = true;
                chatSelected = (Border)((Button)((StackPanel)((StackPanel)((Button)sender).Parent).Parent).Parent).Parent;
            }
            e.Handled = true;

        }

        private void DeleteSession_Click(object sender, RoutedEventArgs e)
        {
            CancelSession areYouSure = new CancelSession();
            overlay.Children.Clear();
            overlay.Children.Add(areYouSure);
        }

        public void DeleteChat()
        {
            popupShown = false;
            Chats.Children.Remove(chatSelected);
            SubMenuHolder.Children.Clear();
        }

        private void ScheduleSession_Click(object sender, RoutedEventArgs e)
        {
            string sesh = SessionText.Text.ToString();
            PartyAvailabilityWindow window = new PartyAvailabilityWindow(PartyName, PlayerName, sesh);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }
    }
}
