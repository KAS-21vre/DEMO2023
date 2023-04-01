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

namespace Ykrasheniya.Menedger
{
    /// <summary>
    /// Логика взаимодействия для WindowProduct.xaml
    /// </summary>
    public partial class WindowProduct : Window
    {
        public WindowProduct()
        {
            InitializeComponent();
            ListProduct.ItemsSource= Instants.GetContext().Товары.ToList();
            
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowAdd windowAdd = new WindowAdd();
            if (windowAdd.ShowDialog() == true)
            {
                YkrasheniyaEntities _db = new YkrasheniyaEntities();
                ListProduct.ItemsSource = _db.Товары.ToList();
            }
        }

        private void btRedact_Click(object sender, RoutedEventArgs e)
        {
            var Prod = ((Товары)(sender as Button).DataContext);

            WindowAdd add = new WindowAdd(Prod);
            if (add.ShowDialog() == true)
            {
                YkrasheniyaEntities _db = new YkrasheniyaEntities();
                ListProduct.ItemsSource = _db.Товары.ToList();
            }
        }

        private void edit_menu_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void delete_menu_btn_Click(object sender, RoutedEventArgs e)
        {
            //var item = ListProduct.SelectedItem as Товары;
            //if (item != null)
            //{
            //    Instants.GetContext().Товары.Remove(item.КодПродукции);
            //}
        }
    }
}
