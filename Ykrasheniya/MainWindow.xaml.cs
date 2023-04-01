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
using Ykrasheniya.Menedger;

namespace Ykrasheniya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btRegistration_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Close();
        }

        private void btEnter_Click(object sender, RoutedEventArgs e)
        {
            var auto= Instants.GetContext().Пользователи.Where(p=> p.Логин==tbLogin.Text && p.Пароль==pbPassword.Password).FirstOrDefault();
            if (auto==null)
            {
                MessageBox.Show(" Пользователь не найден", "Ошибка при авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                switch (auto.КодРоли)
                {
                    case 1: MessageBox.Show("Добро пожаловать, Клиент " + auto.Фамилия, "Уведомление", MessageBoxButton.OK);
                           
                        break;

                    case 2: MessageBox.Show("Добро пожаловать, Администратор " + auto.Фамилия, "Уведомление", MessageBoxButton.OK);
                        WindowProduct windowProduct = new WindowProduct();
                        windowProduct.Show();
                        this.Close();
                        break;
                    case 3: MessageBox.Show("Добро пожаловать, Менеджер " + auto.Фамилия, "Уведомление", MessageBoxButton.OK);
                        WindowPerexod windowPerexod = new WindowPerexod();
                        windowPerexod.Show();
                        this.Close();
                        break;

                    default:
                        MessageBox.Show("Данные не обнаружены! ", "Уведомление", MessageBoxButton.OK);
                        break;
                }
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowGosti windowGosti = new WindowGosti();
            windowGosti.Show();
            this.Close();
            
        }
    }
}
