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

namespace p1.Pages
{
    /// <summary>
    /// Логика взаимодействия для pgClient.xaml
    /// </summary>
    public partial class pgClient : Page
    {
        public pgClient()
        {
            InitializeComponent();
            DG.ItemsSource = Context.Client.ToList();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            switch (mi.Header)
            {
                case "ID":
                    DG.ItemsSource = Context.Client.ToList().OrderBy(i => i.IDClient);
                    break;
                case "Patronimic":
                    DG.ItemsSource = Context.Client.ToList().OrderBy(i => i.Patronimic);
                    break;
            }
        }
    }
}
