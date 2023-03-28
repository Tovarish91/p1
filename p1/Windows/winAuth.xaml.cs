using p1.Windows;
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
using p1.Classes;
using static p1.Classes.clEntity;

namespace p1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public String cptch = "";
        public String Login = "";
        public MainWindow()
        {
            InitializeComponent();

            Random rand = new Random();
            for (int i = 0; i < 5; i++) cptch += Convert.ToChar(rand.Next(0x0410, 0x44F));
            LbCaptcha.Content = cptch;
        }

        private void LbReg_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("djfg");
            //MainWindow MW = new MainWindow();
            //MW.AuthRegFrame.Content = new RegistrationPage();

        }
        private int count = 0;
        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            //var authUser = Context.Employee.ToList().Where(i => i.Email == tboxAuthLogin.Text && i.Password == tboxAuthPas.Text).FirstOrDefault();
            //var authRoleAdm = Context.Employee.ToList().Where(i => i.Role == "admin").FirstOrDefault();
            //if (authUser != null)
            //{
            //    if (tboxCaptcha.Text == cptch)
            //    {
            //        if(authRoleAdm != null)
            //        {
                        Login = tboxAuthLogin.Text;
                        winWork ww = new winWork();
                        ww.Show();
                        this.Close();
            //        }
            //    }
            //    else MessageBox.Show("Captcha не совподает");
            //}
            //else
            //{
            //    //count++;
            //    MessageBox.Show("Неверный логин или пароль");
            //    //if (count >= 3)
            //    //{
            //    //    MessageBox.Show("Перед повторной попыткой осталось 10 сек");
            //    //    btnAuth.IsEnabled = false;
            //    //    for (int i = 0; i < 10; i++)
            //    //    {
            //    //        MessageBox.Show("До следующей попытки осталось: " + (10 - i) + " сек");
            //    //    }
            //    //    btnAuth.IsEnabled = true;
            //    //}
            //}        
        }
    }
}
