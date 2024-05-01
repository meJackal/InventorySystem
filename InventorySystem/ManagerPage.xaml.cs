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
    /// Interaction logic for ManagerPage.xaml
    /// </summary>
    public partial class ManagerPage : Window
    {
        DataClasses1DataContext _dbConn = null;

        public ManagerPage()
        {
            InitializeComponent();

            _dbConn = new DataClasses1DataContext(
                Properties.Settings.Default.MidtermConnectionString);
            loadInventory();
            loadStaff();
        }

        private void loadInventory()
        {
            var inventoryData = from i in _dbConn.InventoryWithTypeDescriptions
                                select new inventoryList
                                {
                                    Inventory_ID = i.Inventory_ID,
                                    Inventory_Name = i.Item_Name,
                                    //Inventory_InStock = i.,
                                    Inventory_Quantity = i.AmountOfStock ?? 0,
                                    Inventory_Type = i.ItemType_Desc,
                                    Inventory_Price = i.ItemCost ?? 0,
                                    Inventory_Remarks = i.Inventory_Remarks,
                                    Inventory_Date = i.Date_Checked
                                };

            inventoryListView.ItemsSource = inventoryData.ToList();
        }

        private void loadStaff()
        {
            var staffData = from i in _dbConn.StaffWithRoleAndStatus
                                select new staffList
                                {
                                   Staff_ID = i.Staff_ID,
                                   Staff_Name = i.Staff_Name,
                                   Staff_Username = i.Staff_Username,
                                   Staff_StaffRole = i.StaffRole_Desc,
                                   Staff_StaffStatus = i.StaffStatus_Desc,
                                };

            inventoryListViewStaff.ItemsSource = staffData.ToList();
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
