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
    /// Логика взаимодействия для WindowPerexod.xaml
    /// </summary>
    public partial class WindowPerexod : Window
    {
        public WindowPerexod()
        {
            InitializeComponent();
        }

        private void btProsmProduct_Click(object sender, RoutedEventArgs e)
        {
            WindowGosti windowGosti = new WindowGosti();
            windowGosti.Show();
            this.Close();
        }
    }
}
