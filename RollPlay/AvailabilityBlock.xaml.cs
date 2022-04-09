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

namespace RollPlay
{
    /// <summary>
    /// Interaction logic for CharacterSubMenu.xaml
    /// </summary>
    /// 


    public partial class AvailabilityBlock : UserControl
    {
        Color color = (Color)ColorConverter.ConvertFromString("#3094CC");
        System.Drawing.Color myColor = System.Drawing.ColorTranslator.FromHtml("#3094CC");

        Color color1 = (Color)ColorConverter.ConvertFromString("#87A397");
        System.Drawing.Color myColor1 = System.Drawing.ColorTranslator.FromHtml("#87A397");

        public List<string> days = new List<string>();

        public List<string> addBlock = new List<string>();

        public AvailabilityBlock()
        {
            InitializeComponent();
        }

        public void selectStartHour(object sender, MouseEventArgs e)
        {
            if (sender is ListBoxItem)
            {
                ListBoxItem hour = sender as ListBoxItem;
                StartHour.Content = hour.Content;
            }
        }
        public void selectStartMinute(object sender, MouseEventArgs e)
        {
            if (sender is ListBoxItem)
            {
                ListBoxItem minute = sender as ListBoxItem;
                StartMinute.Content = minute.Content;
            }
        }

        public void selectStartAMPM(object sender, MouseEventArgs e)
        {
            if (sender is ListBoxItem)
            {
                ListBoxItem AMPM = sender as ListBoxItem;
                StartAMPM.Content = AMPM.Content;
            }
        }

        public void selectEndHour(object sender, MouseEventArgs e)
        {
            if (sender is ListBoxItem)
            {
                ListBoxItem hour = sender as ListBoxItem;
                EndHour.Content = hour.Content;
            }
        }

        public void selectEndMinute(object sender, MouseEventArgs e)
        {
            if (sender is ListBoxItem)
            {
                ListBoxItem minute = sender as ListBoxItem;
                EndMinute.Content = minute.Content;
            }
        }

        public void selectEndAMPM(object sender, MouseEventArgs e)
        {
            if (sender is ListBoxItem)
            {
                ListBoxItem AMPM = sender as ListBoxItem;
                EndAMPM.Content = AMPM.Content;
            }
        }

        public void ShowStartTimes_Click(object sender, RoutedEventArgs e)
        {
            EndBox.Visibility = Visibility.Collapsed;
            StartBox.Visibility = Visibility.Visible;
        }

        public void ShowEndTimes_Click(object sender, RoutedEventArgs e)
        {
            StartBox.Visibility = Visibility.Collapsed;
            EndBox.Visibility = Visibility.Visible;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                Button button = sender as Button;
                if(button.Background == Brushes.White)
                {
                    button.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
                    button.Foreground = Brushes.White;
                    string addDay = (button.Content).ToString();
                    days.Add(addDay);
                } else
                {
                    button.Background = Brushes.White;
                    button.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
                    string removeDay = (button.Content).ToString();
                    days.Remove(removeDay);
                }
            }
        }

        private void Allday_Checked(object sender, RoutedEventArgs e)
        {
            StartHour.Content = "12";
            StartMinute.Content = "00";
            StartAMPM.Content = "AM";

            EndHour.Content = "11";
            EndMinute.Content = "55";
            EndAMPM.Content = "PM";
        }

        private void Allday_Unchecked(object sender, RoutedEventArgs e)
        {
            StartHour.Content = "--";
            StartMinute.Content = "--";
            StartAMPM.Content = "AM";

            EndHour.Content = "--";
            EndMinute.Content = "--";
            EndAMPM.Content = "PM";
        }

        private void Everyday_Checked(object sender, RoutedEventArgs e)
        {
            sun.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
            sun.Foreground = Brushes.White;
            days.Add("Su");

            mon.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
            mon.Foreground = Brushes.White;
            days.Add("Mo");

            tue.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
            tue.Foreground = Brushes.White;
            days.Add("Tu");

            wed.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
            wed.Foreground = Brushes.White;
            days.Add("We");

            thu.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
            thu.Foreground = Brushes.White;
            days.Add("Th");

            fri.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
            fri.Foreground = Brushes.White;
            days.Add("Fr");


            sat.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
            sat.Foreground = Brushes.White;
            days.Add("Sa");
        }

        private void Everyday_Unchecked(object sender, RoutedEventArgs e)
        {
            sun.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
            sun.Background = Brushes.White;
            days.Remove("Su");

            mon.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
            mon.Background = Brushes.White;
            days.Remove("Mo");

            tue.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
            tue.Background = Brushes.White;
            days.Remove("Tu");

            wed.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
            wed.Background = Brushes.White;
            days.Remove("We");

            thu.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
            thu.Background = Brushes.White;
            days.Remove("Th");

            fri.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
            fri.Background = Brushes.White;
            days.Remove("Fr");

            sat.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
            sat.Background = Brushes.White;
            days.Remove("Sa");
        }

        private void CreateBlock_Click(object sender, RoutedEventArgs e)
        {

            string startHourString = (StartHour.Content).ToString();
            string startAMPMString = (StartAMPM.Content).ToString();
            string startTime = startHourString + startAMPMString;

            string endHourString = (EndHour.Content).ToString();
            string endAMPMString = (EndAMPM.Content).ToString();
            string endTime = endHourString + endAMPMString;
            AltEditAvailabilityWindow window = Window.GetWindow(this) as AltEditAvailabilityWindow;

            if (startHourString.Equals("--") | endHourString.Equals("--")) {
                //TODO
            } else
            {
                int startRow = int.Parse(startHourString);
                int endRow =int.Parse(endHourString);
                int col;

                Brush brush = Brushes.Black;
                if (brush.IsFrozen)
                {
                    brush = brush.Clone();
                }
                brush.Opacity = 0.35;

                if (startAMPMString.Equals("AM"))
                {
                    if (startRow == 12)
                    {
                        startRow = 1;
                    }
                    else
                    {
                        startRow = startRow + 1;
                    }
                } else
                {
                    if (startRow == 12)
                    {
                        startRow = 13;
                    }
                    else
                    {
                        startRow = startRow + 13;
                    }
                }

                if (endAMPMString.Equals("AM"))
                {
                    if (endRow == 12)
                    {
                        endRow = 1;
                    }
                    
                } else
                {
                    if (endRow == 12)
                    {
                        endRow = 12;
                    } else
                    {
                        endRow = endRow + 12;
                    }
                }

                for (int i = 0; i < days.Count; i++)
                {
                    if (days[i].Equals("Su"))
                    {
                        col = 1;
                        int thisStart = startRow;
                        int thisend = endRow;
                       
                        foreach (UIElement item in window.Calendar.Children)
                        {
                            if (item is Button)
                            {
                                Button button = item as Button;

                                for (int j = 0; j < window.Calendar.Children.Count; j++)
                                {
                                    UIElement a = window.Calendar.Children[j];
                                    if (Grid.GetRow(a) == thisStart && Grid.GetColumn(a) == col)
                                    {
                                        button = a as Button;
                                        button.Content = "y";
                                        button.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor1.A, myColor1.R, myColor1.G, myColor1.B));
                                        
                                        if (thisStart < thisend)
                                        {
                                            thisStart++;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (days[i].Equals("Mo"))
                    {
                        col = 2;
                        int thisStart = startRow;
                        int thisend = endRow;
                      
                        foreach (UIElement item in window.Calendar.Children)
                        {
                            if (item is Button)
                            {
                                Button button = item as Button;

                                for (int j = 0; j < window.Calendar.Children.Count; j++)
                                {
                                    UIElement a = window.Calendar.Children[j];
                                    if (Grid.GetRow(a) == thisStart && Grid.GetColumn(a) == col)
                                    {
                                        button = a as Button;
                                        button.Content = "y";
                                        button.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor1.A, myColor1.R, myColor1.G, myColor1.B));

                                        if (thisStart < thisend)
                                        {
                                            thisStart++;
                                        }

                                    }
                                }
                            }
                        }
                    }

                    if (days[i].Equals("Tu"))
                    {
                        col = 3;
                        int thisStart = startRow;
                        int thisend = endRow;
                       
                        foreach (UIElement item in window.Calendar.Children)
                        {
                            if (item is Button)
                            {
                                Button button = item as Button;

                                for (int j = 0; j < window.Calendar.Children.Count; j++)
                                {
                                    UIElement a = window.Calendar.Children[j];
                                    if (Grid.GetRow(a) == thisStart && Grid.GetColumn(a) == col)
                                    {
                                        button = a as Button;
                                        button.Content = "y";
                                        button.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor1.A, myColor1.R, myColor1.G, myColor1.B));

                                        if (thisStart < thisend)
                                        {
                                            thisStart++;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (days[i].Equals("We"))
                    {
                        col = 4;
                        int thisStart = startRow;
                        int thisend = endRow;
                    
                        foreach (UIElement item in window.Calendar.Children)
                        {
                            if (item is Button)
                            {
                                Button button = item as Button;

                                for (int j = 0; j < window.Calendar.Children.Count; j++)
                                {
                                    UIElement a = window.Calendar.Children[j];
                                    if (Grid.GetRow(a) == thisStart && Grid.GetColumn(a) == col)
                                    {
                                        button = a as Button;
                                        button.Content = "y";
                                        button.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor1.A, myColor1.R, myColor1.G, myColor1.B));

                                        if (thisStart < thisend)
                                        {
                                            thisStart++;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (days[i].Equals("Th"))
                    {
                        col = 5;
                        int thisStart = startRow;
                        int thisend = endRow;
                    
                        foreach (UIElement item in window.Calendar.Children)
                        {
                            if (item is Button)
                            {
                                Button button = item as Button;

                                for (int j = 0; j < window.Calendar.Children.Count; j++)
                                {
                                    UIElement a = window.Calendar.Children[j];
                                    if (Grid.GetRow(a) == thisStart && Grid.GetColumn(a) == col)
                                    {
                                        button = a as Button;
                                        button.Content = "y";
                                        button.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor1.A, myColor1.R, myColor1.G, myColor1.B));

                                        if (thisStart < thisend)
                                        {
                                            thisStart++;
                                        }

                                    }
                                }
                            }
                        }
                    }

                    if (days[i].Equals("Fr"))
                    {
                        col = 6;
                        int thisStart = startRow;
                        int thisend = endRow;
                  
                        foreach (UIElement item in window.Calendar.Children)
                        {
                            if (item is Button)
                            {
                                Button button = item as Button;

                                for (int j = 0; j < window.Calendar.Children.Count; j++)
                                {
                                    UIElement a = window.Calendar.Children[j];
                                    if (Grid.GetRow(a) == thisStart && Grid.GetColumn(a) == col)
                                    {
                                        button = a as Button;
                                        button.Content = "y";
                                        button.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor1.A, myColor1.R, myColor1.G, myColor1.B));

                                        if (thisStart < thisend)
                                        {
                                            thisStart++;
                                        }

                                    }
                                }
                            }
                        }
                    }

                    if (days[i].Equals("Sa"))
                    {
                        col = 7;
                        int thisStart = startRow;
                        int thisend = endRow;
            
                        foreach (UIElement item in window.Calendar.Children)
                        {
                            if (item is Button)
                            {
                                Button button = item as Button;

                                for (int j = 0; j < window.Calendar.Children.Count; j++)
                                {
                                    UIElement a = window.Calendar.Children[j];
                                    if (Grid.GetRow(a) == thisStart && Grid.GetColumn(a) == col)
                                    {
                                        button = a as Button;
                                        button.Content = "y";
                                        button.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor1.A, myColor1.R, myColor1.G, myColor1.B));

                                        if (thisStart < thisend)
                                        {
                                            thisStart++;
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
                            }

            window.overlay.Children.Clear();
                    }

        public void Cancel_Click(object sender, RoutedEventArgs e)
        {
            AltEditAvailabilityWindow window = Window.GetWindow(this) as AltEditAvailabilityWindow;
            window.overlay.Children.Clear();
        }
    }

    
}
