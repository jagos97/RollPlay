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
using System.Windows.Shapes;

namespace RollPlay
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class ExploreTavernWindow : Window
    {

       public string Prompt1 { get; set; }
        public string Prompt2 { get; set; }
        public string Prompt3 { get; set; }
        public string Prompt4 { get; set; }
        public string Prompt5 { get; set; }
        public string Prompt6 { get; set; } 

        public ExploreTavernWindow(string Prompt1, string Prompt2, string Prompt3, string Prompt4, string Prompt5, string Prompt6)
        {
            this.Prompt1 = Prompt1;
            this.Prompt2 = Prompt2;
            this.Prompt3 = Prompt3;
            this.Prompt4 = Prompt4;
            this.Prompt5 = Prompt5;
            this.Prompt6 = Prompt6;
            InitializeComponent();
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
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
            } else
            {
                scrollViewer.LineRight();
            }
            e.Handled = true;
        }
    }
}
