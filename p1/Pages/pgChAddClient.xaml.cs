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
using p1.DataBase;
using static p1.Classes.clEntity;

namespace p1.Pages
{
    /// <summary>
    /// Логика взаимодействия для pgChAddClient.xaml
    /// </summary>
    public partial class pgChAddClient : Page
    {
        public pgChAddClient()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          Client cl = new Client();

            var cln = Context.Client.ToList().Where(i => i.IDClient == Convert.ToInt32(tboxID.Text)).FirstOrDefault();
            if (cln != null) 
            {
                MessageBox.Show("!"); 
            }
            else
            {
                cl.IDClient = Convert.ToInt32(tboxID.Text);
                cl.IDGender = Convert.ToInt32(tboxIDGender.Text);
                cl.FirstName = tboxFirstName.Text;
                cl.LastName = tboxLastName.Text;
                cl.Patronimic = tboxPatronimic.Text;
                cl.Birthday = Convert.ToDateTime(tboxBirthday.Text);
                cl.Phone = Convert.ToInt32(tboxPhone.Text);
                cl.Email = tboxEmail.Text;

                Context.Client.Add(cl);
                Context.SaveChanges();
                MessageBox.Show("?");
            }
        }
    }
}
