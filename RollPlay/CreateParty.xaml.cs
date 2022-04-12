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
    public partial class CreateParty : UserControl
    {

        System.Drawing.Color errorColor = System.Drawing.ColorTranslator.FromHtml("#CC3641");

        public CreateParty()
        {
            InitializeComponent();
                 
        }

        private void WithCharacter_Selected(object sender, RoutedEventArgs e)
        {
            CharacterListPanel.Visibility = Visibility.Visible;
        }

        private void WithCharacter_Unselected(object sender, RoutedEventArgs e)
        {
            CharacterListPanel.Visibility = Visibility.Collapsed;
        }

        private void WithoutCharacter_Selected(object sender, RoutedEventArgs e)
        {
            WithoutCharacter.Visibility = Visibility.Visible;
        }

        private void WithoutCharacter_Unselected(object sender, RoutedEventArgs e)
        {
            WithoutCharacter.Visibility = Visibility.Collapsed;
        }

        private void CreateParty_Click(object sender, RoutedEventArgs e)
        {
            if (JoinWith.IsChecked == true)
            {
                if (CharacterList.SelectedIndex == -1)
                {
                    ListError.Visibility = Visibility.Visible;
                    CharacterList.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(errorColor.A, errorColor.R, errorColor.G, errorColor.B));

                }
                else if (String.IsNullOrEmpty(PartyNameBox.Text.ToString()))
                {
                    PartyNameBox.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(errorColor.A, errorColor.R, errorColor.G, errorColor.B));
                    NameError.Visibility = Visibility.Visible;
                }
                else
                {
                    ListBoxItem item = CharacterList.SelectedItem as ListBoxItem;
                    String PlayerName = item.Content.ToString();
                    String PartyName = PartyNameBox.Text.ToString();
                    String sched = "No Session Scheduled";
                    PartyPageWindow window = new PartyPageWindow(PartyName, PlayerName, null, null, null, sched);
                    PartiesWindow parent = Window.GetWindow(this) as PartiesWindow;
                    window.Show();
                    window.Top = parent.Top;
                    window.Left = parent.Left;
                    parent.overlay.Children.Clear();
                    parent.Close();

                }
            }
            else if (JoinWithout.IsChecked == true)
            {
                if (String.IsNullOrEmpty(DisplayName.Text.ToString()))
                {
                    DisplayError.Visibility = Visibility.Visible;
                    DisplayName.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(errorColor.A, errorColor.R, errorColor.G, errorColor.B));

                }
                else if (String.IsNullOrEmpty(PartyNameBox.Text.ToString()))
                {
                    NameError.Visibility = Visibility.Visible;
                    PartyNameBox.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(errorColor.A, errorColor.R, errorColor.G, errorColor.B));

                }
                else
                {
                    ListBoxItem item = CharacterList.SelectedItem as ListBoxItem;
                    String PlayerName = DisplayName.Text.ToString();
                    String PartyName = PartyNameBox.Text.ToString();
                    String sched = "No Session Scheduled";
                    PartyPageWindow window = new PartyPageWindow(PartyName, PlayerName, null, null, null, sched);
                    PartiesWindow parent = Window.GetWindow(this) as PartiesWindow;
                    window.Show();
                    window.Top = parent.Top;
                    window.Left = parent.Left;
                    parent.overlay.Children.Clear();
                    parent.Close();

                }
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            PartiesWindow window = Window.GetWindow(this) as PartiesWindow;
            window.overlay.Children.Clear();
        }

        
    }
}
