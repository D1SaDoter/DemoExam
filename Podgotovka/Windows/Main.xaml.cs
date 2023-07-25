using Podgotovka.Domain.Enum;
using Podgotovka.Windows.Model;
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
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        int test = 0;
        MainWindow mainWindow;
        public Main(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            
            LoadProductItems();
        }
        public Main(MainWindow _mainWindow, int id, string whichButton)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            if(whichButton=="Delete")
            {
                mainWindow.allList.DeleteProduct(id);
                mainWindow.OpenPages(Pages.main);
            }
            if (whichButton == "Basket")
            {

            }
            if (whichButton == "Edit")
            {
                mainWindow.framePanel.Navigate(new EditProduct(mainWindow, id));
            }
            
        }
        public void LoadProductItems()
        {
            mainWindow.allList.products.Clear();
            panelProduct.Children.Clear();
            mainWindow.allList.GetProduct();
            for (int i = 0; i < mainWindow.allList.products.Count; i++)
            {
                panelProduct.Children.Add(new ProductModel(mainWindow, i));
            }
        }
    }
}
