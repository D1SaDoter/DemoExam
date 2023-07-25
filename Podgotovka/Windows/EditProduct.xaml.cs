using Microsoft.Win32;
using Podgotovka.Domain.Classes;
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

namespace Podgotovka.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditProduct.xaml
    /// </summary>
    public partial class EditProduct : Page
    {
        MainWindow mainWindow;
        public EditProduct(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }
        public EditProduct(MainWindow _mainWindow, int id)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            BitmapImage bi = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Images/" + mainWindow.allList.products[id-1].ProductPhoto, UriKind.RelativeOrAbsolute));
            imageEdit.Source = bi;
            textName.Text = mainWindow.allList.products[id - 1].ProductName;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nameFile = "";
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                nameFile += (char)(rnd.Next(65, 90));
            }
            string path = Convert.ToString(new Uri(Directory.GetCurrentDirectory()));
            path=path.Remove(0, 8);
            string fileName = "";
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog() == true)
            {
                fileName = fileDialog.FileName;
            }
            File.Copy(fileName, path + "/Images/"+nameFile+".png");
            
            
        }
    }
}
