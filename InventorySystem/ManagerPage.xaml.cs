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
        private string _username;

        public ManagerPage(int appLogIn, string currUser)
        {
            InitializeComponent();
            _appLogIn = appLogIn;
            _username = currUser;

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
                UpdatePage up = new UpdatePage(item, _appLogIn, _username);
                up.Show();
                this.Close();
            }
        }

        private void inventoryListViewStaff_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = inventoryListViewStaff.SelectedItem as staffList;
            if (item != null)
            {
                StaffUpdatePage sup = new StaffUpdatePage(item, _appLogIn, _username);
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
            AddProduct addProduct = new AddProduct(_appLogIn, _username);
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
            AddStaff addStaff = new AddStaff(_appLogIn, _username);
            addStaff.Show();
            this.Close();
        }

        private void tbSearch_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            var search = tbSearch.Text.ToUpper();

            if (inventoryListView.Visibility == Visibility.Visible)
            {
                var searchInventory = from item in _dbConn.InventoryWithTypeDescriptions
                                      where item.Inventory_ID.ToUpper().Contains(search) ||
                                            item.Item_Name.ToUpper().Contains(search)
                                      select new inventoryList
                                      {
                                          Inventory_ID = item.Inventory_ID,
                                          Inventory_Name = item.Item_Name,
                                          Inventory_InStock = item.InStock_Desc,
                                          Inventory_Quantity = item.AmountOfStock ?? 0,
                                          Inventory_Type = item.ItemType_Desc,
                                          Inventory_Price = item.ItemCost ?? 0,
                                          Inventory_Remarks = item.Inventory_Remarks,
                                          Inventory_Date = item.Date_Checked
                                      };

                inventoryListView.ItemsSource = searchInventory.ToList();
            }
            else if (inventoryListViewStaff.Visibility == Visibility.Visible)
            {
                var searchStaff = from staff in _dbConn.StaffWithRoleAndStatus
                                  where staff.Staff_ID.ToUpper().Contains(search) ||
                                        staff.Staff_Name.ToUpper().Contains(search)
                                  select new staffList
                                  {
                                      Staff_ID = staff.Staff_ID,
                                      Staff_Name = staff.Staff_Name,
                                      Staff_Username = staff.Staff_Username,
                                      Staff_StaffRole = staff.StaffRole_Desc,
                                      Staff_StaffStatus = staff.StaffStatus_Desc,
                                  };

                inventoryListViewStaff.ItemsSource = searchStaff.ToList();
            }
        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {
            ProfilePage pg = new ProfilePage(_appLogIn, _username);
            pg.Show();
            this.Close();
        }
    }
}
