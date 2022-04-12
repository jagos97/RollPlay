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


    public partial class CreateSession : UserControl
    {
        Color color = (Color)ColorConverter.ConvertFromString("#3094CC");
        System.Drawing.Color myColor = System.Drawing.ColorTranslator.FromHtml("#3094CC");

        Color color1 = (Color)ColorConverter.ConvertFromString("#87A397");
        System.Drawing.Color myColor1 = System.Drawing.ColorTranslator.FromHtml("#87A397");

        public CreateSession()
        {
            InitializeComponent();
                 
        }

        private void CalendarSelect_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var calendar = sender as Calendar;
            if (calendar.SelectedDate.HasValue)
            {
                DateTime date = calendar.SelectedDate.Value;
                SelectedDate.Content = date.ToString("D");
            }
        }

        public void selectStartHour(object sender, MouseEventArgs e)
        {
            if (sender is ListBoxItem)
            {
                ListBoxItem hour = sender as ListBoxItem;
                StartHour.Content = hour.Content;
                SelectedStartHour.Content = hour.Content;
            }
        }

        public void selectStartMinute(object sender, MouseEventArgs e)
        {
            if (sender is ListBoxItem)
            {
                ListBoxItem minute = sender as ListBoxItem;
                StartMinute.Content = minute.Content;
                SelectedStartMinute.Content = minute.Content;

            }
        }

        public void selectStartAMPM(object sender, MouseEventArgs e)
        {
            if (sender is ListBoxItem)
            {
                ListBoxItem AMPM = sender as ListBoxItem;
                StartAMPM.Content = AMPM.Content;
                SelectedStartAMPM.Content = AMPM.Content;

            }
        }


        public void selectEndHour(object sender, MouseEventArgs e)
        {
            if (sender is ListBoxItem)
            {
                ListBoxItem hour = sender as ListBoxItem;
                EndHour.Content = hour.Content;
                SelectedEndHour.Content = hour.Content;

            }
        }

        public void selectEndMinute(object sender, MouseEventArgs e)
        {
            if (sender is ListBoxItem)
            {
                ListBoxItem minute = sender as ListBoxItem;
                EndMinute.Content = minute.Content;
                SelectedEndMinute.Content = minute.Content;

            }
        }

        public void selectEndAMPM(object sender, MouseEventArgs e)
        {
            if (sender is ListBoxItem)
            {
                ListBoxItem AMPM = sender as ListBoxItem;
                EndAMPM.Content = AMPM.Content;
                SelectedEndAMPM.Content = AMPM.Content;

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

        private void DateLabel_Click(object sender, RoutedEventArgs e)
        {
            DateLabel.FontWeight = FontWeights.Bold;
            TimeLabel.FontWeight = FontWeights.Light;
            DateLabel.Opacity = 1.0;
            TimeLabel.Opacity = .5;
            TimePanel.Visibility = Visibility.Collapsed;
            DatePanel.Visibility = Visibility.Visible;
            StartBox.Visibility = Visibility.Collapsed;
            EndBox.Visibility = Visibility.Collapsed;
        }

        private void TimeLabel_Click(object sender, RoutedEventArgs e)
        {
            DateLabel.FontWeight = FontWeights.Light;
            TimeLabel.FontWeight = FontWeights.Bold;

            DateLabel.Opacity = .5;
            TimeLabel.Opacity = 1.0;

            DatePanel.Visibility = Visibility.Collapsed;
            TimePanel.Visibility = Visibility.Visible;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            PartyAvailabilityWindow window = Window.GetWindow(this) as PartyAvailabilityWindow;
            window.InfoPanel.Children.Clear();

        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {

            if ((SelectedDate.Content.ToString().Equals("--")) | (SelectedStartHour.Content.ToString().Equals("--")) | (SelectedEndAMPM.Content.ToString().Equals("")) | (SelectedEndHour.Content.ToString().Equals("--")) | (SelectedEndAMPM.Content.ToString().Equals("")))
            {
                ErrorMessage1.Visibility = Visibility.Visible;

            } else if ( (SelectedStartAMPM.Content.Equals("PM") && SelectedEndAMPM.Content.Equals("AM") ) | (  (SelectedStartAMPM.Content.Equals(SelectedEndAMPM.Content) && (Int32.Parse(SelectedStartHour.Content.ToString()) > Int32.Parse(SelectedEndHour.Content.ToString()))))) 
            {
                ErrorMessage2.Visibility = Visibility.Visible;
                StartButton.BorderBrush = Brushes.Red;
                EndButton.BorderBrush = Brushes.Red;
            }
            else
            {
                string schedString = (SelectedDate.Content.ToString()) + " @ " + (SelectedStartHour.Content.ToString()) + ":" + (SelectedStartMinute.Content.ToString()) + (SelectedStartAMPM.Content.ToString()) + " - " + (SelectedEndHour.Content.ToString()) + ":" + (SelectedEndMinute.Content.ToString()) + (SelectedEndAMPM.Content.ToString());
                PartyAvailabilityWindow window = Window.GetWindow(this) as PartyAvailabilityWindow;
                window.ScheduledSession.Content = schedString;
                window.schedSession = schedString;
                window.InfoPanel.Children.Clear();
            }
        }
    }

    
}

