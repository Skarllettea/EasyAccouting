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

namespace EasyAccounting
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OnTimedEvent();
        }

        async Task OnTimedEvent()
        {
            while (true)
            {
                await Task.Delay(1000);
                lblTimeK.Content = DateTime.Now.ToString("dd.MM.yyyy, HH:mm:ss");
            }
        }

        private void Label_MouseUp(object sender, MouseButtonEventArgs e)
        {
            User user = new User();
            user.Show();
            this.Close();
        }
    }
}
