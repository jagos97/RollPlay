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
using System.Diagnostics;
using System.Windows.Navigation;

namespace RollPlay
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CharacterPage(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Top = this.Top;
            window.Left = this.Left;
            window.Show();
            this.Close();
        }

        private void Signin_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(email.Text.ToString()) | String.IsNullOrWhiteSpace(password.Password.ToString()))
            {
                email.BorderBrush = Brushes.Red;
                password.BorderBrush = Brushes.Red;
                passError.Visibility = Visibility.Visible;
            } else
            {
                MainWindow window = new MainWindow();
                window.Show();
                window.Top = this.Top;
                window.Left = this.Left;
                this.Close();
            }
        }

        private void Signup_Click(object sender, RoutedEventArgs e)
        {
            Signup window = new Signup();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

     
    }
}
