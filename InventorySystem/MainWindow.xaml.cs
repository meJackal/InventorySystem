using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using static InventorySystem.lvData;

namespace InventorySystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<inventory> Test { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Test = new ObservableCollection<inventory>
            {
                new lvData.inventory { ID = 1, Name = "Item 1", Availability = "Available", Type = "Dog", 
                    Quantity = 10, Price = 19, UpdatedBy = "John", dt = DateTime.Now, Remark = "New" },
                new lvData.inventory { ID = 2, Name = "Item 2", Availability = "NotAvailable", Type = "Cat", 
                    Quantity = 0, Price = 29, UpdatedBy = "Mary", dt = DateTime.Now, Remark = "Out of stock" }
            };

            DataContext = this;
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            LogInPage logIn = new LogInPage();
            logIn.Show();
            this.Close();
        }

        private void inventoryListView_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = inventoryListView.SelectedItem as inventory;
            if (item != null)
            {
                UpdatePage up = new UpdatePage(item);
                up.Show();
                this.Close();
            }
        }
    }
}
