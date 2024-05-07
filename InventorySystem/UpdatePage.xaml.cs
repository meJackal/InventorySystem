using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace InventorySystem
{
    /// <summary>
    /// Interaction logic for UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Window
    {
        DataClasses1DataContext _dbConn = null;
        private int _appLogIn;
        private string _username;
        private inventoryList _selectedItem;

        public UpdatePage(inventoryList item, int appLogIn, string currUser)
        {
            InitializeComponent();

            _appLogIn = appLogIn;
            _username = currUser;

            _dbConn = new DataClasses1DataContext(
               Properties.Settings.Default.MidtermConnectionString);

            _selectedItem = item;

            loadInventory(item);
        }

        private void loadInventory(inventoryList item)
        {
            tbName.Text = item.Inventory_Name;

            if (item.Inventory_Type == "Dog")
                cmbType.SelectedIndex = 0;
            else if (item.Inventory_Type == "Cat")
                cmbType.SelectedIndex = 1;
            else if (item.Inventory_Type == "Supplies")
                cmbType.SelectedIndex = 2;

            if (item.Inventory_InStock == "Available")
                cmbAvailability.SelectedIndex = 0;
            else if (item.Inventory_InStock == "UnAvailable")
                cmbAvailability.SelectedIndex = 1;

            tbPrice.Text = item.Inventory_Price.ToString();

            tbQty.Text = item.Inventory_Quantity.ToString();

            tbRemark.Text = item.Inventory_Remarks;
        }


        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            _dbConn = new DataClasses1DataContext(Properties.Settings.Default.MidtermConnectionString);

            bool itemExists = _dbConn.Inventories.Any(item => item.Item_Name == tbName.Text && item.Inventory_ID != _selectedItem.Inventory_ID);

            if (!itemExists)
            {
                string updateName = tbName.Text;
                string updateType = (cmbType.SelectedItem as ComboBoxItem)?.Content.ToString();
                string updateAvailability = (cmbAvailability.SelectedItem as ComboBoxItem)?.Content.ToString();

                if (updateType == "DOG")
                    updateType = "IT1";
                else if (updateType == "CAT")
                    updateType = "IT2";
                else if (updateType == "SUPPLIES")
                    updateType = "IT3";


                if (updateAvailability == "AVAILABLE")
                    updateAvailability = "ST1";
                else if (updateAvailability == "UNAVAILABLE")
                    updateAvailability = "ST2";

                if (!int.TryParse(tbQty.Text, out int updateQty))
                {
                    MessageBox.Show("Please enter a valid quantity...");
                    return;
                }

                if (!int.TryParse(tbPrice.Text, out int updatePrice))
                {
                    MessageBox.Show("Please enter a valid price...");
                    return;
                }

                string updateRemark = tbRemark.Text;

                _dbConn.UpdateInventoryInfo(_selectedItem.Inventory_ID, updateName, updateType, updateQty, updateRemark,
                                            DateTime.Today, updatePrice, updateAvailability);
                _dbConn.SubmitChanges();

                MessageBox.Show("Item updated successfully...");
                back();
            }
            else
                MessageBox.Show("Item Name Already Exist... Update Product Terminated...");
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            back();
        }

        private void back()
        {
            if (_appLogIn == 1)
            {
                ManagerPage mp = new ManagerPage(_appLogIn, _username);
                mp.Show();
                this.Close();
            }
            else if (_appLogIn == 2)
            {
                MainWindow mw = new MainWindow(_appLogIn,_username);
                mw.Show();
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            _dbConn.DeleteInventoryByID(_selectedItem.Inventory_ID);
            MessageBox.Show("Inventory has been Removed...");
            back();
        }
    }
}
