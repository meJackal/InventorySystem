﻿using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace InventorySystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext _dbConn = null;

        public MainWindow()
        {
            InitializeComponent();
            _dbConn = new DataClasses1DataContext(
                Properties.Settings.Default.MidtermConnectionString);
            loadInventory();
        }

        private void loadInventory()
        {
            var inventoryData = from i in _dbConn.Inventories
                                select new inventoryList
                                {
                                    Inventory_ID = i.Inventory_ID,
                                    Inventory_Name = i.Item_Name,
                                    Inventory_InStock = i.InStock_ID,
                                    Inventory_Quantity = i.AmountOfStock ?? 0,
                                    Inventory_Type = i.ItemType_ID,
                                    Inventory_Price = i.ItemCost ?? 0,
                                    Inventory_Remarks = i.Inventory_Remarks,
                                    Inventory_Date = i.Date_Checked
                                };


            inventoryListView.ItemsSource = inventoryData.ToList();
        }

        private void inventoryListView_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = inventoryListView.SelectedItem as inventoryList;
            if (item != null)
            {
                UpdatePage up = new UpdatePage(item);
                up.Show();
                this.Close();
            }
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            LogInPage logIn = new LogInPage();
            logIn.Show();
            this.Close();
        }
    }
}
