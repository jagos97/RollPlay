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
    public partial class AltEditAvailabilityWindow : Window
    {

        Color color = (Color)ColorConverter.ConvertFromString("#87A397");
        System.Drawing.Color myColor = System.Drawing.ColorTranslator.FromHtml("#87A397");


        public string PartyName { get; set; }
        public string PlayerName { get; set; }

        public Grid inputGrid = null;

        List<Button> UndoChanges = new List<Button>();
        List<Button> RedoChanges = new List<Button>();




        public AltEditAvailabilityWindow(string PartyName, string PlayerName, Grid inputGrid)
        {

            Brush brush = Brushes.Black;
            if (brush.IsFrozen)
            {
                brush = brush.Clone();
            }
            brush.Opacity = 0.35;

            if (inputGrid == null)
            {
                this.PartyName = PartyName;
                this.PlayerName = PlayerName;

                InitializeComponent();
            } else
            {

                this.PartyName = PartyName;
                this.PlayerName = PlayerName;
                this.inputGrid = inputGrid;
                Border border = new Border();
                Label label = new Label();
                Button button = new Button();
                InitializeComponent();

                for (int index = this.Calendar.Children.Count - 1; index >= 0; index--)
                {
                    this.Calendar.Children.RemoveAt(index);
                }



                for (int i = inputGrid.Children.Count - 1; i >= 0; i--)
                {


                    UIElement item = inputGrid.Children[i];
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

                    if (item is Label)
                    {

                        Button itemButton = new Button();
                        Label itemLabel = item as Label;

                        itemButton.BorderBrush = brush; 
                        itemButton.BorderThickness = itemLabel.BorderThickness;
                        itemButton.Content = itemLabel.Content;
                        itemButton.Background = itemLabel.Background;
                        itemButton.Foreground = itemLabel.Foreground;
                        itemButton.PreviewMouseDown += Button_Click;
                        itemButton.MouseEnter += OnMouseMove;

                        itemButton.SetValue(Grid.RowProperty, r);
                        itemButton.SetValue(Grid.ColumnProperty, c);

                        Grid parent = itemButton.Parent as Grid;

                        if (parent != null)
                        {
                            parent.Children.Remove(itemButton);
                        }

                        this.Calendar.Children.Add(itemButton);

                    }

                    if (!(item is Label) && !(item is Border))
                    {

                        Button itemButton = new Button();

                        itemButton.BorderBrush = brush;
                        itemButton.BorderThickness = new Thickness(0,0,.5,.5);
                        itemButton.Content = "x";
                        itemButton.Background = Brushes.Transparent;
                        itemButton.Foreground = Brushes.Transparent;
                        itemButton.PreviewMouseDown += Button_Click;
                        itemButton.MouseEnter += OnMouseMove;



                        itemButton.SetValue(Grid.RowProperty, r);
                        itemButton.SetValue(Grid.ColumnProperty, c);

                        Grid parent = itemButton.Parent as Grid;
                        if (parent != null)
                        {
                            parent.Children.Remove(itemButton);
                        }

                        this.Calendar.Children.Add(itemButton);


                    }

                }

            }
        }
        

        public void UpdateAvailability_Click(object sender, RoutedEventArgs e)
        {
            AltMyAvailabilityWindow window = new AltMyAvailabilityWindow(PartyName, PlayerName, Calendar);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();

        }

        public void Cancel_Click(object sender, RoutedEventArgs e)
        {
            AltMyAvailabilityWindow window = new AltMyAvailabilityWindow(PartyName, PlayerName, null);
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close(); 
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Button someButton = sender as Button;
            if (someButton.Content.Equals("x"))
            {
                someButton.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
                someButton.Foreground = Brushes.Transparent;
                someButton.Content = "y";
                UndoChanges.Add(someButton);

            } else
            {
                someButton.Background = Brushes.Transparent;
                someButton.Foreground = Brushes.Transparent;
                someButton.Content = "x";
                UndoChanges.Add(someButton);


            }

            e.Handled = true;
        }


        public void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (UIElement item in Calendar.Children)
            {
                if (item is Button)
                {
                    Button button = item as Button;
                    button.Background = Brushes.Transparent;
                    button.Foreground = Brushes.Transparent;
                    button.Content = "x";
                }
            }
        }

        public void OnMouseMove (object sender, MouseEventArgs e)
        {
            var target = sender;
            if (target is Button)
            {
                Button someButton = target as Button;
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    if (someButton.Content.Equals("x"))
                    {
                        someButton.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
                        someButton.Content = "y";
                        someButton.Foreground = Brushes.Transparent;
                        UndoChanges.Add(someButton);


                    }
                    else
                    {
                        someButton.Background = Brushes.Transparent;
                        someButton.Foreground = Brushes.Transparent;
                        someButton.Content = "x";
                        e.Handled = true;
                        UndoChanges.Add(someButton);

                    }
                }
            }
        }

        public void Undo_Click(object sender, RoutedEventArgs e)
        {
            if (UndoChanges.Count > 0)
            {
                Button someButton = UndoChanges.Last();
                if (someButton.Content.Equals("x"))
                {
                    someButton.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
                    someButton.Content = "y";
                    someButton.Foreground = Brushes.Transparent;
                    RedoChanges.Add(someButton);
                    UndoChanges.RemoveAt(UndoChanges.Count - 1);


                }
                else
                {
                    someButton.Background = Brushes.Transparent;
                    someButton.Foreground = Brushes.Transparent;
                    someButton.Content = "x";
                    e.Handled = true;
                    RedoChanges.Add(someButton);
                    UndoChanges.RemoveAt(UndoChanges.Count - 1);

                }
            }

        }

        public void Redo_Click(object sender, RoutedEventArgs e)
        {
            if (RedoChanges.Count > 0)
            {
                Button someButton = RedoChanges.Last();
                if (someButton.Content.Equals("x"))
                {
                    someButton.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
                    someButton.Content = "y";
                    someButton.Foreground = Brushes.Transparent;
                    UndoChanges.Add(someButton);
                    RedoChanges.RemoveAt(RedoChanges.Count - 1);


                }
                else
                {
                    someButton.Background = Brushes.Transparent;
                    someButton.Foreground = Brushes.Transparent;
                    someButton.Content = "x";
                    e.Handled = true;
                    UndoChanges.Add(someButton);
                    RedoChanges.RemoveAt(RedoChanges.Count - 1);

                }
            }
    }

        public void SelectAll_Click(object sender, RoutedEventArgs e)
        {

            UIElement timeLabel = null;

            foreach (UIElement item in Calendar.Children)
            {
                if (item is Button)
                {
                    Button button = item as Button;

                    int r = Grid.GetRow(button);
                    int c = 0;

                    for (int i = 0; i < Calendar.Children.Count; i++)
                    {
                        UIElement a = Calendar.Children[i];
                        if (Grid.GetRow(a) == r && Grid.GetColumn(a) == 0)
                        {
                            button.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));

                        }
                    }
                }
            }
        }

        public void AddBlock_Click(object sender, RoutedEventArgs e)
        {
            AvailabilityBlock addBlock = new AvailabilityBlock();
            overlay.Children.Clear();
            overlay.Children.Add(addBlock);
            
        }

        public void RemoveBlock_Click(object sender, RoutedEventArgs e)
        {
            DeleteBlock removeBlock = new DeleteBlock();
            overlay.Children.Clear();
            overlay.Children.Add(removeBlock);
        }

    }
}
