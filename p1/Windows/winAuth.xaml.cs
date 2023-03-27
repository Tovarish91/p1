using p1.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace p1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Random rand = new Random();
            String cptch = "";
            for (int i = 0; i < 5; i++) cptch += Convert.ToChar(rand.Next(0x0410, 0x44F));
            LbCaptcha.Content = cptch;
        }

        private void LbReg_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("djfg");
            //MainWindow MW = new MainWindow();
            //MW.AuthRegFrame.Content = new RegistrationPage();
        }
        
        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            //var authUser = Context.Client.ToList().Where(i => i.Login == tboxAuthLogin.Text && i.Password == tboxAuthPas.Text).FirstOrDefault();
            //if (authUser != null)
            //{
            //    // переход на окно пользователя
            //}
            //else
            //{
            //    MessageBox.Show("Неверный логин или пароль");
            //}

            winWork ww = new winWork();
            ww.Show();
            this.Close();        
        }
    }
}
