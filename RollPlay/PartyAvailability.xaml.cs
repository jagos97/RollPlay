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
    public partial class PartyAvailabilityWindow : Window
    {

        public string PartyName { get; set; }

        public string PlayerName { get; set; }

        public string schedSession { get; set; }




        public PartyAvailabilityWindow(string PartyName, string PlayerName, string schedSession)
        {

                this.PartyName = PartyName;
                this.PlayerName = PlayerName;
                this.schedSession = schedSession;
                InitializeComponent();

        } 
         

        public void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            schedSession = ScheduledSession.Content.ToString();
            PartyPageWindow window = new PartyPageWindow(PartyName, PlayerName, null, null, null, schedSession);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            InfoPrompt info = new InfoPrompt();
            InfoPanel.Children.Add(info);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateSession scheduler = new CreateSession();
            InfoPanel.Children.Clear();
            InfoPanel.Children.Add(scheduler);
        }

        private void Request_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        private void MyAvail_Click(object sender, RoutedEventArgs e)
        {
            schedSession = ScheduledSession.Content.ToString();
            AltMyAvailabilityWindow window = new AltMyAvailabilityWindow(PartyName, PlayerName, null, schedSession);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();

        }

        private void MembersAvail_Click(object sender, RoutedEventArgs e)
        {
            

            Button button = sender as Button;
            Border border = button.Parent as Border;

            int gRow = Grid.GetRow(border);
            int gCol = Grid.GetColumn(border);
            int gSpan = Grid.GetRowSpan(border);
            int numPlayers;

            if ((button.Content.ToString()).Equals("5/5")){
                numPlayers = 5;
            } else if ((button.Content.ToString()).Equals("4/5"))
            {
                numPlayers = 4;
            } else if ((button.Content.ToString()).Equals("3/5"))
            {
                numPlayers = 3;
            } else if ((button.Content.ToString()).Equals("2/5"))
            {
                numPlayers = 2;
            }
            else
            {
                numPlayers = 1;
            }

            AvailableMembersWindow window = new AvailableMembersWindow(gRow, gCol, gSpan, numPlayers);
            InfoPanel.Children.Clear();
            InfoPanel.Children.Add(window);
        }

      
    }
    }

