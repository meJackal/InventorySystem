using System;
using System.Linq;
using System.Windows;

namespace InventorySystem
{
    /// <summary>
    /// Interaction logic for UpdatePage.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        DataClasses1DataContext _dbConn = null;
        private int _appLogIn;

        public AddProduct(int appLogIn)
        {
            InitializeComponent();
            _dbConn = new DataClasses1DataContext(
                Properties.Settings.Default.MidtermConnectionString);

            _appLogIn = appLogIn;
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            bool flag = false;
            IQueryable<Inventory> inventory = from i in _dbConn.Inventories
                                              select i;
            int qtyInt = 0;
            int priceInt = 0;
            int count = 1;
            DateTime date = DateTime.Now;
            string convert = "";
            foreach (Inventory i in inventory)
            {
                count++;
            }
            string qty = tbQty.Text;
            string price = tbPrice.Text;
            if (int.TryParse(qty, out qtyInt) == true && int.TryParse(price, out priceInt) == true)
            {
                if (!_dbConn.Inventories.Any(item => item.Item_Name == tbName.Text))
                {
                    Inventory newitem = new Inventory();
                    if (cmbAvailability.SelectedItem != null && cmbType.SelectedItem != null && tbName.Text != null)
                    {
                        if (count.ToString().Length < 2)
                            convert += 0;
                        convert = "I" + convert;
                        convert += count.ToString();
                        newitem.Inventory_ID = convert;
                        newitem.Item_Name = tbName.Text;
                        if (int.Parse(qty) < 1)
                            newitem.InStock_ID = "ST2";
                        else if (int.Parse(qty) > 0)
                            newitem.InStock_ID = "ST1";
                        newitem.AmountOfStock = int.Parse(qty);
                        newitem.ItemCost = int.Parse(price);
                        newitem.Inventory_Remarks = "None.";
                        newitem.ItemType_ID = "IT" + (cmbType.SelectedIndex + 1).ToString();
                        newitem.Staff_ID = "S02";
                        newitem.Date_Checked = date;
                    }
                    _dbConn.Inventories.InsertOnSubmit(newitem);
                    _dbConn.SubmitChanges();
                    flag = true;
                }
                else
                    MessageBox.Show("Item Name Already Exist... Add Product Terminated...");
            }
            if (flag)
            {
                if (_appLogIn == 1)
                {
                    ManagerPage mp = new ManagerPage(_appLogIn);
                    mp.Show();
                    this.Close();
                }
                else if (_appLogIn == 2)
                {
                    MainWindow mw = new MainWindow(_appLogIn);
                    mw.Show();
                    this.Close();
                }
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (_appLogIn == 1)
            {
                ManagerPage mp = new ManagerPage(_appLogIn);
                mp.Show();
                this.Close();
            }
            else if (_appLogIn == 2)
            {
                MainWindow mw = new MainWindow(_appLogIn);
                mw.Show();
                this.Close();
            }
        }
    }
}