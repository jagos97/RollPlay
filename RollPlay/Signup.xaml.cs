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
    public partial class Signup : Window
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(email.Text.ToString()) | String.IsNullOrWhiteSpace(password.Password.ToString()) | String.IsNullOrWhiteSpace(user.Text.ToString()) | String.IsNullOrWhiteSpace(password2.Password.ToString()))
            {
                email.BorderBrush = Brushes.Red;
                password.BorderBrush = Brushes.Red;
                user.BorderBrush = Brushes.Red;
                password2.BorderBrush = Brushes.Red;
                genError.Visibility = Visibility.Visible;

            } else if (!password.Password.ToString().Equals(password2.Password.ToString()))
            {
                password.BorderBrush = Brushes.Red;
                password2.BorderBrush = Brushes.Red;
                passError.Visibility = Visibility.Visible;
            }else
            {
                MainWindow window = new MainWindow();
                window.Show();
                window.Top = this.Top;
                window.Left = this.Left;
                this.Close();
            }
        }

        private void Signin_Click(object sender, RoutedEventArgs e)
        {
            Login window = new Login();
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
        }

     
    }
}
