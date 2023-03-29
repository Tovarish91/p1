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
            Frame.Content = new pgClient();
        }

        private string frameNow;
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            switch (mi.Header)
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
                case "Сотрудник-Услуга":
                    frameNow = "Сотрудник-Услуга";
                    Frame.Content = new PgEmployeeService();
                    break;
                case "Услуга":
                    frameNow = "Услуга";
                    Frame.Content = new PgService();
                    break;
                case "Чек":
                    frameNow = "Чек";
                    Frame.Content = new pgVoucher();
                    break;
                case "Чек-Услуга":
                    frameNow = "Чек-Услуга";
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
                case "Продукт-Услуга":
                    frameNow = "Продукт-Услуга";
                    Frame.Content = new pgProductService();
                    break;
                case "Поставщик":
                    frameNow = "Поставщик";
                    Frame.Content = new pgProvider();
                    break;
                case "Logs":
                    frameNow = "Logs";
                    Frame.Content = new pgLogs();
                    break;
            }
        }

        private void btnChangeAdd_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (b.Name == "btnChange") Change = true;

            switch (frameNow)
            {
                case "Клиент":
                    Frame.Content = new pgChAddClient();
                    break;
                case "Сотрудник":
                    Frame.Content = new pgChAddEmployee();
                    break;
            }
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            Employee em = Context.Employee.First(i => i.IDEmployee == IDChange);
            Context.Employee.Remove(em);
            Context.SaveChanges();
            Frame.Content = new PgEmployee();
        }
    }
}
