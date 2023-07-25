using Podgotovka.Domain.Enum;
using Podgotovka.Service.LoginModule;
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

namespace Podgotovka.Windows
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        Autorize aut = new Autorize();
        MainWindow mainWindow;
        public Login(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            captchaPanel.Visibility = Visibility.Hidden;
        }

        private void LoginAccount(object sender, RoutedEventArgs e)
        {
            bool test=aut.LoginCheck(loginText.Text, passwordText.Password, mainWindow.allList.users);
            if (test)
            {
                mainWindow.OpenPages(Pages.main);
            }
            else
            {
                MessageBox.Show("Логин или пароль введены неверно!");
            }
            
        }


        private void LoginAnonymous(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPages(Pages.main);
        }
    }
}
