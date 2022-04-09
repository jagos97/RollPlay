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




        public PartyAvailabilityWindow(string PartyName, string PlayerName)
        {

                this.PartyName = PartyName;
                this.PlayerName = PlayerName;
                InitializeComponent();

        } 
         

        public void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            PartyPageWindow window = new PartyPageWindow(PartyName, PlayerName, null, null, null);
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

      
    }
    }

