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
    public partial class AltMyAvailabilityWindow : Window
    {

        public string PartyName { get; set; }

        public string PlayerName { get; set; }


        public Grid calendarGrid = null;


        public AltMyAvailabilityWindow(string PartyName, string PlayerName, Grid calendarGrid)
        {
            this.calendarGrid = calendarGrid;
            this.PartyName = PartyName;
            this.PlayerName = PlayerName;

            if (calendarGrid == null)
             {


                this.PartyName = PartyName;
                this.PlayerName = PlayerName;
                InitializeComponent();

            } 
             else
             {
                 this.PartyName = PartyName;
                 this.calendarGrid = calendarGrid;
                 Border border = new Border();
                 Label label = new Label();
                 Button button = new Button();
                 InitializeComponent();

                for (int index = this.Calendar.Children.Count - 1; index >= 0; index--)
                {
                    this.Calendar.Children.RemoveAt(index);
                }

                for (int i = calendarGrid.Children.Count - 1; i >= 0; i--)
                 {

                    UIElement item = calendarGrid.Children[i];
                    int r = Grid.GetRow(item);
                    int c = Grid.GetColumn(item);

                    if (item is Border)
                    {
                        Border itemBorder = item as Border;
                        Label itemLabel = itemBorder.Child as Label;
            
                        border = itemBorder;
                        label = itemLabel;
                        border.Child = label;
            
                        border.SetValue(Grid.RowProperty, r);
                        border.SetValue(Grid.ColumnProperty, c);
            
                        Grid parent = border.Parent as Grid;

                        if (parent != null)
                        {
                            parent.Children.Remove(border);
                        }

                        this.Calendar.Children.Add(border);

                     }

                     if (item is Button)
                     {
                        Button itemButton = item as Button;
                        Label itemLabel = new Label();
                        itemLabel.BorderBrush = itemButton.BorderBrush;
                        itemLabel.BorderThickness = itemButton.BorderThickness;
                        itemLabel.Content = itemButton.Content;
                        itemLabel.Background = itemButton.Background;
                        itemLabel.Foreground = itemButton.Foreground;
                        itemLabel.HorizontalContentAlignment = HorizontalAlignment.Center;
                        itemLabel.VerticalContentAlignment = VerticalAlignment.Center;
                        itemLabel.FontSize = 10;

                        itemLabel.SetValue(Grid.RowProperty, r);
                        itemLabel.SetValue(Grid.ColumnProperty, c);

                        Grid parent = itemLabel.Parent as Grid;

                        if (parent != null)
                        {
                            parent.Children.Remove(itemLabel);
                        }

                        this.Calendar.Children.Add(itemLabel);

                    }

                }

                   }

        }

        public void EditAvailability_Click(object sender, RoutedEventArgs e)
        {
            AltEditAvailabilityWindow window = new AltEditAvailabilityWindow(PartyName, PlayerName, Calendar);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

        public void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            PartyPageWindow window = new PartyPageWindow(PartyName, PlayerName, null, null, null);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }



    }
    }

