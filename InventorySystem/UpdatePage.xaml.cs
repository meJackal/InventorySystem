using System.Windows;

namespace InventorySystem
{
    /// <summary>
    /// Interaction logic for UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Window
    {
        private inventoryList _selectedItem;

        public UpdatePage(inventoryList item)
        {
            InitializeComponent();

            _selectedItem = item;

            tbName.Text = item.Inventory_Name;

            if (item.Inventory_Type == "Dog")
                cmbType.SelectedIndex = 0;
            else if (item.Inventory_Type == "Cat")
                cmbType.SelectedIndex = 1;
            else if (item.Inventory_Type == "Supplies")
                cmbType.SelectedIndex = 2;

            if (item.Inventory_InStock == "Available")
                cmbType.SelectedIndex = 0;
            else if (item.Inventory_InStock == "UnAvailable")
                cmbType.SelectedIndex = 1;

            tbPrice.Text = item.Inventory_Price.ToString();

            tbQty.Text = item.Inventory_Quantity.ToString();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
