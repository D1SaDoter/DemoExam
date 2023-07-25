using System;
using System.Collections.Generic;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;

namespace Podgotovka.Windows.Model
{
    /// <summary>
    /// Логика взаимодействия для ProductModel.xaml
    /// </summary>
    public partial class ProductModel : UserControl
    {
        MainWindow mainWindow;
        public ProductModel(MainWindow _mainWindow, int i)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            idText.Text = mainWindow.allList.products[i].Id.ToString();
            nameText.Text = mainWindow.allList.products[i].ProductName;
            decriptionText.Text = mainWindow.allList.products[i].ProductDescription;
            producerText.Text = mainWindow.allList.products[i].ProductManufacturer;
            priceText.Text = mainWindow.allList.products[i].ProductCost.ToString();
            try
            {
                BitmapImage bi = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Images/" + mainWindow.allList.products[i].ProductPhoto, UriKind.RelativeOrAbsolute));
                imageProduct.Source = bi;
            }
            catch
            {
                BitmapImage bi = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Images/logo.png", UriKind.RelativeOrAbsolute));
                imageProduct.Source = bi;
            }
                
        }

        private void DeleteProduct(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(idText.Text);
            new Main(mainWindow, id, "Delete");
        }

        private void AddInBasket(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(idText.Text);
            new Main(mainWindow, id, "Basket");
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(idText.Text);
            new Main(mainWindow, id, "Edit");
        }
    }
}
