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
    public partial class CreatePartyChat : UserControl
    {
        int i = 0;
        List<string> items = new List<string>();
        List<string> prices = new List<string>();
        string ShopName = null;
        string ShopKeep = null;
        string Description = null;
        public string PartyName { get; set; }

        public string PlayerName { get; set; }

        public string schedSession { get; set; }

        public CreatePartyChat(string PartyName, string PlayerName, string schedSession)
        {
            this.schedSession = schedSession;
            this.PartyName = PartyName;
            this.PlayerName = PlayerName;
            InitializeComponent();
                 
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;

        }

        private void Camp_Selected(object sender, RoutedEventArgs e)
        {
            this.ShopInfo.Visibility = Visibility.Collapsed;
            //FINISH
        }

        private void Shop_Selected(object sender, RoutedEventArgs e)
        {
            this.ShopInfo.Visibility = Visibility.Visible;
            //FINSH
            
        }

        private void Inn_Selected(object sender, RoutedEventArgs e)
        {
            this.ShopInfo.Visibility = Visibility.Collapsed;
            //FINISH
        }

        private void Other_Selected(object sender, RoutedEventArgs e)
        {
            this.ShopInfo.Visibility = Visibility.Collapsed;
            //FINISH
        }

        private void AddStock_Click(object sender, RoutedEventArgs e)
        {
            itemPrice.Visibility = Visibility.Visible;
            StackPanel stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.Name = "stackPanel" + i;

            TextBox stock = new TextBox();
            stock.Name = "stock" + i;
            System.Diagnostics.Debug.WriteLine(stackPanel.Name);
            stock.Width = 171;
            stock.Height = 49;
            stock.FontSize = 18;
            stock.TextAlignment = TextAlignment.Left;
            stock.Margin = new Thickness(20, 8, 0, 0);
            stock.Padding = new Thickness(5, 10, 0, 0);
            //stock.SetValue(Border.CornerRadiusProperty, new CornerRadius(8));

            TextBox price = new TextBox();
            price.Name = "price" + i;
            price.Width = 68;
            price.Height = 49;
            price.FontSize = 18;
            price.TextAlignment = TextAlignment.Left;
            price.Margin = new Thickness(5, 8, 0, 0);
            price.Padding = new Thickness(5, 10, 0, 0);
            //price.SetValue(Border.CornerRadiusProperty, new CornerRadius(8));
            //price.Style.Setters.Add(new Setter { Property = CornerRadius, Value = 8 });
            i++;

            stackPanel.Children.Add(stock);
            stackPanel.Children.Add(price);
            AddStockPanel.Children.Add(stackPanel);

        }
        private void CreateChat_Click(object sender, RoutedEventArgs e)
        {
            if (Shop.IsSelected)
            {

                ShopName = NameSearch.Text;
                ShopKeep = ShopKeepName.Text;
                Description = Description1.Text;

                int count = AddStockPanel.Children.Count;
                for (int i = 0; i < count; i++)
                {
                    if (AddStockPanel.Children[i] != null)
                    {
                        object foundPanel = AddStockPanel.Children[i];
                        if (foundPanel != null)
                        {
                            StackPanel stack = foundPanel as StackPanel;
                            int count1 = stack.Children.Count;

                            for (int j = 0; j < count1; j++)
                            {
                                if (stack.Children[j] != null)
                                {

                                    object foundBox = stack.Children[j];
                                    TextBox box = foundBox as TextBox;
                                    string stockName = "stock" + i;
                                    string itemName = "price" + i;


                                    if ((box.Name).Equals(stockName))
                                    {
                                       
                                            items.Add(box.Text);

                                        


                                    }

                                    if ((box.Name).Equals(itemName)){
                                       
                                            prices.Add(box.Text);

                                        

                                    }



                                }
                            }

                            
                        }

                    }
                }


                if (String.IsNullOrWhiteSpace(ShopName) || String.IsNullOrWhiteSpace(Description))
                {
                    NameSearch.BorderBrush = Brushes.Red;
                    NameError.Visibility = Visibility.Visible;

                    Description1.BorderBrush = Brushes.Red;
                    DescriptionError.Visibility = Visibility.Visible;
                }
                else
                {
                    ShopWindow window = new ShopWindow(ShopName, ShopKeep, items, prices, PartyName, PlayerName, Description, schedSession);
                    window.Show();
                    window.Top = Window.GetWindow(this).Top;
                    window.Left = Window.GetWindow(this).Left;
                    Window.GetWindow(this).Close();
                }

            }

            if (Camp.IsSelected)
            {
                MessageBox.Show("Under Construction");

            }

            if (Inn.IsSelected)
            {
                MessageBox.Show("Under Construction");

            }

            if (Other.IsSelected)
            {
                MessageBox.Show("Under Construction");

            }

        }
    }
}
