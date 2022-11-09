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

namespace EasyAccounting
{
    /// <summary>
    /// Логика взаимодействия для User.xaml
    /// </summary>
    public partial class User : Window
    {
        public User()
        {
            InitializeComponent();


            //lblTime.Text = DateTime.Now.ToString("dd.MM.yyyy, HH:mm:ss");
        }

        private void tbPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pbPassword.Password.Length == 0)
            {
                tblPasswordHint.Visibility = Visibility.Visible;
            }
            else
                tblPasswordHint.Visibility = Visibility.Hidden;
        }

        private void pbPassword1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pbPassword1.Password.Length == 0)
            {
                tblPasswordHint1.Visibility = Visibility.Visible;
            }
            else
                tblPasswordHint1.Visibility = Visibility.Hidden;
        }

        private void pbPassword2_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pbPassword2.Password.Length == 0)
            {
                tblPasswordHint2.Visibility = Visibility.Visible;
            }
            else
                tblPasswordHint2.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Close();
        }
    }
}
