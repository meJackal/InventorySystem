using System.Linq;
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
        private int _appLogIn;
        private string _username;

        public MainWindow(int appLogIn, string currUser)
        {
            InitializeComponent();

            _appLogIn = appLogIn;
            _username = currUser;

            _dbConn = new DataClasses1DataContext(
                Properties.Settings.Default.MidtermConnectionString);

            loadInventory();
            
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

        private void btnInventory_Click(object sender, RoutedEventArgs e)
        {
            loadInventory();
        }

        private void btnStaff_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Invalid Access to staff..");
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

        private void tbSearch_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            var search = tbSearch.Text.ToUpper();

            var searchFilter = from i in _dbConn.InventoryWithTypeDescriptions
                               where i.Inventory_ID.ToUpper().Contains(search) ||
                               i.Item_Name.ToUpper().Contains(search)
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

            inventoryListView.ItemsSource = searchFilter.ToList();
        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {
            ProfilePage pg = new ProfilePage(_appLogIn, _username);
            pg.Show();
            this.Close();
        }
    }
}
