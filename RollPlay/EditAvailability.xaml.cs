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
    public partial class EditAvailabilityWindow : Window
    {



        public string PartyName { get; set; }




        public EditAvailabilityWindow(string PartyName)
        {
            this.PartyName = PartyName;
            InitializeComponent();
        }

        public void UpdateAvailability_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        public void Cancel_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Button someButton = sender as Button;
            if (someButton.Content.Equals("x"))
            {
                Color color = (Color)ColorConverter.ConvertFromString("#87A397");
                System.Drawing.Color myColor = System.Drawing.ColorTranslator.FromHtml("#87A397");
                someButton.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
                int index = Grid.GetRow(someButton);
                UIElement timeLabel = null;

                for (int i = 0; i < Calendar.Children.Count; i++)
                {
                    UIElement a = Calendar.Children[i];
                    if (Grid.GetRow(a) == index && Grid.GetColumn(a) == 0)
                    {
                        timeLabel = a;
                        Border border1 = timeLabel as Border;
                        Label label1 = border1.Child as Label;
                        someButton.Content = label1.Content;
                        someButton.Foreground = Brushes.White;
                    }
                        
                }

            } else
            {
                someButton.Background = Brushes.Transparent;
                someButton.Foreground = Brushes.Transparent;
                someButton.Content = "x";

            }
            {

            }
        }
    }
}
