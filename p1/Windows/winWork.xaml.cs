using p1.Classes;
using p1.DataBase;
using p1.Pages;
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

namespace p1.Windows
{
    /// <summary>
    /// Логика взаимодействия для winWork.xaml
    /// </summary>
    public partial class winWork : Window
    {
        public winWork()
        {
            InitializeComponent();
        }

        private string frameNow;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Content) 
            {
                case "Клиент":
                    frameNow = "Клиент";
                    Frame.Content = new pgClient();
                    break;
                case "Сотрудник":
                    frameNow = "Сотрудник";
                    Frame.Content = new PgEmployee();
                    break;
                case "Гендер":
                    frameNow = "Гендер";
                    Frame.Content = new PgGender();
                    break;
                case "Должность":
                    frameNow = "Должность";
                    Frame.Content = new PgPosition();
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (frameNow == "Клиент")
            {

                Frame.Content = new pgChAddClient();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (frameNow == "Клиент")
            {
                Frame.Content = new pgChAddClient();
            }
        }
    }
}
