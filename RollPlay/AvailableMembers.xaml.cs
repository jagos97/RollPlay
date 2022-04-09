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
    public partial class AvailableMembersWindow : UserControl
    {
      
  

        public AvailableMembersWindow(int gRow, int gCol, int gSpan, int numPlayers)
        {
            int startTime = 0;
            int endTime;

            InitializeComponent();

              if (gCol.Equals(1))
            {
                Day.Content = "Sunday";
            } else if (gCol.Equals(2))
            {
                Day.Content = "Monday";
            } else if (gCol.Equals(3))
            {
                Day.Content = "Tuesday";
            } else if (gCol.Equals(4))
            {
                Day.Content = "Wednesday";
            } else if (gCol.Equals(5))
            {
                Day.Content = "Thursday";
            } else if (gCol.Equals(6))
            {
                Day.Content = "Friday";
            }
                 else if (gCol.Equals(7))
            {
                Day.Content = "Saturday";
            } else
            {
                Day.Content = "";
            }

            if (gRow.Equals(1))
            {
                StartTime.Content = "12AM";
                startTime = 12;
                endTime = (startTime + gSpan);
                string AMPM = "AM";
                if (endTime > 12)
                {
                    endTime = endTime - 12;
                    AMPM = "PM";
                }
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;


            }
            else if (gRow.Equals(2))
            {
                StartTime.Content = "1AM";
                startTime = 1;
                endTime = (startTime + gSpan);
                string AMPM = "AM";
                if (endTime > 12)
                {
                    endTime = endTime - 12;
                    AMPM = "PM";
                }
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;

            }
            else if (gRow.Equals(3))
            {
                StartTime.Content = "2AM";
                startTime = 2;
                endTime = (startTime + gSpan);
                string AMPM = "AM";
                if (endTime > 12)
                {
                    endTime = endTime - 12;
                    AMPM = "PM";
                }
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(4))
            {
                StartTime.Content = "3AM";
                startTime = 3;
                endTime = (startTime + gSpan);
                string AMPM = "AM";
                if (endTime > 12)
                {
                    endTime = endTime - 12;
                    AMPM = "PM";
                }
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(5))
            {
                StartTime.Content = "4AM";
                startTime = 4;
                endTime = (startTime + gSpan);
                string AMPM = "AM";
                if (endTime > 12)
                {
                    endTime = endTime - 12;
                    AMPM = "PM";
                }
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(6))
            {
                StartTime.Content = "5AM";
                startTime = 5;
                endTime = (startTime + gSpan);
                string AMPM = "AM";
                if (endTime > 12)
                {
                    endTime = endTime - 12;
                    AMPM = "PM";
                }
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(7))
            {
                StartTime.Content = "6AM";
                startTime = 6;
                endTime = (startTime + gSpan);
                string AMPM = "AM";
                if (endTime > 12)
                {
                    endTime = endTime - 12;
                    AMPM = "PM";
                }
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(8))
            {
                StartTime.Content = "7AM";
                startTime = 7;
                endTime = (startTime + gSpan);
                string AMPM = "AM";
                if (endTime > 12)
                {
                    endTime = endTime - 12;
                    AMPM = "PM";
                }
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(9))
            {
                StartTime.Content = "8AM";
                startTime = 8;
                endTime = (startTime + gSpan);
                string AMPM = "AM";
                if (endTime > 12)
                {
                    endTime = endTime - 12;
                    AMPM = "PM";
                }
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(10))
            {
                StartTime.Content = "9AM";
                startTime = 9;
                endTime = (startTime + gSpan);
                string AMPM = "AM";
                if (endTime > 12)
                {
                    endTime = endTime - 12;
                    AMPM = "PM";
                }
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(11))
            {
                StartTime.Content = "10AM";
                startTime = 10;
                endTime = (startTime + gSpan);
                string AMPM = "AM";
                if (endTime > 12)
                {
                    endTime = endTime - 12;
                    AMPM = "PM";
                }
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(12))
            {
                StartTime.Content = "11AM";
                startTime = 11;
                endTime = (startTime + gSpan);
                string AMPM = "AM";
                if (endTime > 12)
                {
                    endTime = endTime - 12;
                    AMPM = "PM";
                }
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(13))
            {
                StartTime.Content = "12PM";
                startTime = 12;
                endTime = (startTime + gSpan);
                string AMPM = "PM";
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(14))
            {
                StartTime.Content = "1PM";
                startTime = 1;
                endTime = (startTime + gSpan);
                string AMPM = "PM";
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(15))
            {
                StartTime.Content = "2PM";
                startTime = 2;
                endTime = (startTime + gSpan);
                string AMPM = "PM";
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(16))
            {
                StartTime.Content = "3PM";
                startTime = 3;
                endTime = (startTime + gSpan);
                string AMPM = "PM";
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(17))
            {
                StartTime.Content = "4PM";
                startTime = 4;
                endTime = (startTime + gSpan);
                string AMPM = "PM";
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(18))
            {
                StartTime.Content = "5PM";
                startTime = 5;
                endTime = (startTime + gSpan);
                string AMPM = "PM";
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(19))
            {
                StartTime.Content = "6PM";
                startTime = 6;
                endTime = (startTime + gSpan);
                string AMPM = "PM";
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(20))
            {
                StartTime.Content = "7PM";
                startTime = 7;
                endTime = (startTime + gSpan);
                string AMPM = "PM";
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(21))
            {
                StartTime.Content = "8PM";
                startTime = 8;
                endTime = (startTime + gSpan);
                string AMPM = "PM";
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(22))
            {
                StartTime.Content = "9PM";
                startTime = 9;
                endTime = (startTime + gSpan);
                string AMPM = "PM";
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(23))
            {
                StartTime.Content = "10PM";
                startTime = 10;
                endTime = (startTime + gSpan);
                string AMPM = "PM";
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else if (gRow.Equals(24))
            {
                StartTime.Content = "11PM";
                startTime = 11;
                endTime = (startTime + gSpan);
                string AMPM = "PM";
                string endString = (endTime.ToString()) + AMPM;
                EndTime.Content = endString;
            }
            else
            {
                StartTime.Content = "";
                EndTime.Content = "";
            }

            if (numPlayers == 1)
            {
                Player1.Visibility = Visibility.Visible;
            } 
            else if (numPlayers == 2)
            {
                Player2.Visibility = Visibility.Visible;
                Player4.Visibility = Visibility.Visible;
            } 
            else if (numPlayers == 3)
            {
                Player1.Visibility = Visibility.Visible;
                Player3.Visibility = Visibility.Visible;
                Player5.Visibility = Visibility.Visible;
            }
            else if (numPlayers == 4)
            {
                Player2.Visibility = Visibility.Visible;
                Player3.Visibility = Visibility.Visible;
                Player4.Visibility = Visibility.Visible;
                Player5.Visibility = Visibility.Visible;
            } 
            else
            {
                Player1.Visibility = Visibility.Visible;
                Player2.Visibility = Visibility.Visible;
                Player3.Visibility = Visibility.Visible;
                Player4.Visibility = Visibility.Visible;
                Player5.Visibility = Visibility.Visible;
            }
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            PartyAvailabilityWindow window = Window.GetWindow(this) as PartyAvailabilityWindow;
            window.InfoPanel.Children.Clear();
        }


        


    }
}
