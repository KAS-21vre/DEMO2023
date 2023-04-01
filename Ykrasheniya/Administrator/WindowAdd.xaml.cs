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

namespace Ykrasheniya
{
    /// <summary>
    /// Логика взаимодействия для WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        private Товары _currentProduct = new Товары();

        public WindowAdd(Товары selectedProduct)
        {
            InitializeComponent();
            _currentProduct = selectedProduct;

            cbEdIzm.ItemsSource = Instants.GetContext().ЕдиницыИзмерения.ToList();
            cbCategory.ItemsSource = Instants.GetContext().Категории.ToList();
            cbProizvoditel.ItemsSource = Instants.GetContext().Производитель.ToList();
        }
        public WindowAdd()
        {
            InitializeComponent();
            DataContext = _currentProduct;
            cbEdIzm.ItemsSource = Instants.GetContext().ЕдиницыИзмерения.ToList();
            cbCategory.ItemsSource = Instants.GetContext().Категории.ToList();
            cbProizvoditel.ItemsSource = Instants.GetContext().Производитель.ToList();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Товары товары = new Товары();
            товары.Артикул = tbArticl.Text;
            товары.Наименование = tbName.Text;
            товары.Описание = tbOpisanie.Text;
            товары.Размер_максимально_возможной_скидки = Convert.ToInt32(tbMaxSkidka.Text);
            товары.Действующая_скидка = Convert.ToInt32(tbDeystSkidka.Text);
            товары.Кол_во_на_складе = Convert.ToInt32(tbKolvo.Text);
            товары.Стоимость = Convert.ToInt32(tbStoimost.Text);
            товары.Единица_измерения = (cbEdIzm.SelectedItem as ЕдиницыИзмерения).КодЕдиницыИзмерения;
            товары.КодПроизводителя = (cbProizvoditel.SelectedItem as Производитель).КодПроизводителя;
            товары.КодКатегорииТовара = (cbCategory.SelectedItem as Категории).КодКатегории;

            
            try
            {
                Instants.GetContext().Товары.Add(товары);
                Instants.GetContext().SaveChanges();
                MessageBox.Show("Товар добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            

            DialogResult = true;
        }
    }
}
