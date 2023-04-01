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
    /// Логика взаимодействия для WindowGosti.xaml
    /// </summary>
    public partial class WindowGosti : Window
    {
        public WindowGosti()
        {
            InitializeComponent();
            ListProduct.ItemsSource = Instants.GetContext().Товары.ToList();
        }
    }
}
