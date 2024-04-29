using Microsoft.Win32;
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

namespace InventorySystem
{
    /// <summary>
    /// Interaction logic for UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Window
    {
        private inventory selectedItem;

        public UpdatePage(inventory item)
        {
            InitializeComponent();
            
            //selectedItem = item;

            //tbName.Text = item.Name;
            //tbQty.Text = item.Quantity.ToString();
            //tbPrice.Text = item.Price.ToString();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog filepath = new OpenFileDialog();
            filepath.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            if (filepath.ShowDialog() == true)
            {
                string selectedFilePath = filepath.FileName;
                BitmapImage bitmap = new BitmapImage(new Uri(selectedFilePath));
                ImageDisplay.Source = bitmap;
            }
        }
    }
}
