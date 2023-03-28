using p1.Classes;
using p1.DataBase;
using p1.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using static p1.Classes.clEntity;
using p1.Windows;

namespace p1.Windows
{
    /// <summary>
    /// Логика взаимодействия для winWork.xaml
    /// </summary>
    public partial class winWork : Window
    {
        private Stopwatch sw = new Stopwatch();
        private DateTime EntrTime;
        public winWork()
        {
            InitializeComponent();
            EntrTime = DateTime.Now;
            sw.Start();
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
                case "Сотрудник-Сервис":
                    frameNow = "Сотрудник-Сервис";
                    Frame.Content = new PgEmployeeService();
                    break;
                case "Сервис":
                    frameNow = "Сервис";
                    Frame.Content = new PgService();
                    break;
                case "Чек":
                    frameNow = "Чек";
                    Frame.Content = new pgVoucher();
                    break;
                case "Чек-Сервис":
                    frameNow = "Чек-Сервис";
                    Frame.Content = new pgVoucherService();
                    break;
                case "Чек-Продукт":
                    frameNow = "Чек-Продукт";
                    Frame.Content = new pgVoucherProduct();
                    break;
                case "Продукт":
                    frameNow = "Продукт";
                    Frame.Content = new pgProduct();
                    break;
                case "Продукт-Сервис":
                    frameNow = "Продукт-Сервис";
                    Frame.Content = new pgProductService();
                    break;
                case "Поставщик":
                    frameNow = "Поставщик";
                    Frame.Content = new pgProvider();
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            sw.Stop();

            MainWindow mw= new MainWindow();
            Log l = new Log();

            l.Login = mw.Login;
            l.Time = sw.Elapsed.ToString();
            l.EntryTime = EntrTime;
            l.OutTime = System.DateTime.Now;
            l.LogoutReason = "Window close";

            Context.Log.Add(l);
            Context.SaveChanges();
            //MessageBox.Show(Convert.ToInt32(sw.Elapsed.ToString()).ToString());

            Environment.Exit(0);
        }
    }
}
