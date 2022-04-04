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
        public static StackPanel playerSelected = null;

        public string PartyName { get; set; } 
        public string InitialName { get; set; }

        public string PlayerName { get; set; } 

        public static bool invitePopupShown = false;
        public static bool popupShown = false;
        public static bool chatPopupShown = false;
        public static Border partySelected = null;

        public EditPartyWindow(string PartyName, string PlayerName)
        {
            this.PartyName = PartyName;
            this.PlayerName = PlayerName;
            this.InitialName = PartyName;
            InitializeComponent();
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
            PartyPageWindow window = new PartyPageWindow(this.PartyName, this.PlayerName);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            this.PartyName = this.InitialName;
            PartyPageWindow window = new PartyPageWindow(this.PartyName, this.PlayerName);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        private void RemovePlayer_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }
    }
}
