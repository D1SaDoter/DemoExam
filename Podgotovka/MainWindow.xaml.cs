using Podgotovka.Domain;
using Podgotovka.Domain.Classes;
using Podgotovka.Domain.Enum;
using Podgotovka.Service;
using Podgotovka.Windows;
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

namespace Podgotovka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Lists allList=new Lists();
        public MainWindow()
        {
            InitializeComponent();
            allList.GetRole();
            allList.GetUser();
            OpenPages(Pages.login);
        }
        public void OpenPages(Pages pages)
        {
            if (pages == Pages.login) framePanel.Navigate(new Login(this));
            if (pages == Pages.main) framePanel.Navigate(new Main(this));
        }
    }
}
