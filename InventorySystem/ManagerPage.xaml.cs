using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace InventorySystem
{
    /// <summary>
    /// Interaction logic for ManagerPage.xaml
    /// </summary>
    public partial class ManagerPage : Window
    {
        DataClasses1DataContext _dbConn = null;
        private int _appLogIn;

        public ManagerPage(int appLogIn)
        {
            InitializeComponent();
            _appLogIn = appLogIn;

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
                                    Inventory_InStock = i.InStock_Desc,
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
                UpdatePage up = new UpdatePage(item, _appLogIn);
                up.Show();
                this.Close();
            }
        }

        private void inventoryListViewStaff_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = inventoryListViewStaff.SelectedItem as staffList;
            if (item != null)
            {
                StaffUpdatePage sup = new StaffUpdatePage(item, _appLogIn);
                sup.Show();
                this.Close();
            }
        }


        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            LogInPage logIn = new LogInPage();
            logIn.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddProduct addProduct = new AddProduct(_appLogIn);
            addProduct.Show();
            this.Close();
        }
        private void btnStaff_Click(object sender, RoutedEventArgs e)
        {
            inventoryListView.Visibility = Visibility.Collapsed;
            inventoryListViewStaff.Visibility = Visibility.Visible;

            btnAddStaff.Visibility = Visibility.Visible;
            lblAddI.Visibility = Visibility.Collapsed;
            lblAddS.Visibility = Visibility.Visible;

            btnDogs.Visibility = Visibility.Collapsed;
            btnCats.Visibility = Visibility.Collapsed;
            btnSupp.Visibility = Visibility.Collapsed;

            btnMan.Visibility = Visibility.Visible;
            btnEmp.Visibility = Visibility.Visible;

            loadStaff();
        }

        private void btnInventory_Click(object sender, RoutedEventArgs e)
        {
            inventoryListViewStaff.Visibility = Visibility.Collapsed;
            inventoryListView.Visibility = Visibility.Visible;

            btnAddStaff.Visibility = Visibility.Collapsed;
            lblAddI.Visibility = Visibility.Visible;
            lblAddS.Visibility = Visibility.Collapsed;

            btnDogs.Visibility = Visibility.Visible;
            btnCats.Visibility = Visibility.Visible;
            btnSupp.Visibility = Visibility.Visible;

            btnMan.Visibility = Visibility.Collapsed;
            btnEmp.Visibility = Visibility.Collapsed;

            loadInventory();
        }

        private void btnDogs_Click(object sender, RoutedEventArgs e)
        {
            var dogs = from i in _dbConn.InventoryWithTypeDescriptions
                       where i.ItemType_Desc == "Dog"
                       select new inventoryList
                       {
                           Inventory_ID = i.Inventory_ID,
                           Inventory_Name = i.Item_Name,
                           Inventory_InStock = i.InStock_Desc,
                           Inventory_Quantity = i.AmountOfStock ?? 0,
                           Inventory_Type = i.ItemType_Desc,
                           Inventory_Price = i.ItemCost ?? 0,
                           Inventory_Remarks = i.Inventory_Remarks,
                           Inventory_Date = i.Date_Checked
                       };

            inventoryListView.ItemsSource = dogs.ToList();
        }

        private void btnCats_Click(object sender, RoutedEventArgs e)
        {
            var cats = from i in _dbConn.InventoryWithTypeDescriptions
                       where i.ItemType_Desc == "Cat"
                       select new inventoryList
                       {
                           Inventory_ID = i.Inventory_ID,
                           Inventory_Name = i.Item_Name,
                           Inventory_InStock = i.InStock_Desc,
                           Inventory_Quantity = i.AmountOfStock ?? 0,
                           Inventory_Type = i.ItemType_Desc,
                           Inventory_Price = i.ItemCost ?? 0,
                           Inventory_Remarks = i.Inventory_Remarks,
                           Inventory_Date = i.Date_Checked
                       };

            inventoryListView.ItemsSource = cats.ToList();
        }

        private void btnSupp_Click(object sender, RoutedEventArgs e)
        {
            var supp = from i in _dbConn.InventoryWithTypeDescriptions
                       where i.ItemType_Desc == "Supplies"
                       select new inventoryList
                       {
                           Inventory_ID = i.Inventory_ID,
                           Inventory_Name = i.Item_Name,
                           Inventory_InStock = i.InStock_Desc,
                           Inventory_Quantity = i.AmountOfStock ?? 0,
                           Inventory_Type = i.ItemType_Desc,
                           Inventory_Price = i.ItemCost ?? 0,
                           Inventory_Remarks = i.Inventory_Remarks,
                           Inventory_Date = i.Date_Checked
                       };

            inventoryListView.ItemsSource = supp.ToList();
        }

        private void btnMan_Click(object sender, RoutedEventArgs e)
        {
            var manager = from i in _dbConn.StaffWithRoleAndStatus
                          where i.StaffRole_Desc == "Manager"
                          select new staffList
                          {
                              Staff_ID = i.Staff_ID,
                              Staff_Name = i.Staff_Name,
                              Staff_Username = i.Staff_Username,
                              Staff_StaffRole = i.StaffRole_Desc,
                              Staff_StaffStatus = i.StaffStatus_Desc,
                          };

            inventoryListViewStaff.ItemsSource = manager.ToList();
        }

        private void btnEmp_Click(object sender, RoutedEventArgs e)
        {
            var employee = from i in _dbConn.StaffWithRoleAndStatus
                           where i.StaffRole_Desc == "Employee"
                           select new staffList
                           {
                               Staff_ID = i.Staff_ID,
                               Staff_Name = i.Staff_Name,
                               Staff_Username = i.Staff_Username,
                               Staff_StaffRole = i.StaffRole_Desc,
                               Staff_StaffStatus = i.StaffStatus_Desc,
                           };

            inventoryListViewStaff.ItemsSource = employee.ToList();
        }

        private void btnAddStaff_Click(object sender, RoutedEventArgs e)
        {
            AddStaff addStaff = new AddStaff(_appLogIn);
            addStaff.Show();
            this.Close();
        }
    }
}
