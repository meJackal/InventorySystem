using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace InventorySystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            LogInPage logIn = new LogInPage();
            logIn.Show();
            this.Close();
        }

        private void inventoryListView_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = inventoryListView.SelectedItem as Inventory;
            if (item != null)
            {
                UpdatePage up = new UpdatePage(item);
                up.Show();
                this.Close();
            }
        }
    }
}
