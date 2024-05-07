using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace InventorySystem
{
    /// <summary>
    /// Interaction logic for StaffUpdatePage.xaml
    /// </summary>
    public partial class StaffUpdatePage : Window
    {
        DataClasses1DataContext _dbConn = null;
        private int _appLogIn;
        private string _username;
        private staffList _selectedItem;

        public StaffUpdatePage(staffList item, int appLogIn, string currUser)
        {
            InitializeComponent();

            _appLogIn = appLogIn;
            _username = currUser;

            _dbConn = new DataClasses1DataContext(
               Properties.Settings.Default.MidtermConnectionString);

            _selectedItem = item;

            loadStaff(item);
        }

        private void loadStaff(staffList item)
        {
            tbName.Text = item.Staff_Name;

            tbUser.Text = item.Staff_Username;

            if (item.Staff_StaffRole == "Manager")
                cmbSR.SelectedIndex = 0;
            else if (item.Staff_StaffRole == "Employee")
                cmbSR.SelectedIndex = 1;

            if (item.Staff_StaffStatus == "Active")
                cmbSS.SelectedIndex = 0;
            else if (item.Staff_StaffStatus == "InActive")
                cmbSS.SelectedIndex = 1;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            _dbConn = new DataClasses1DataContext(Properties.Settings.Default.MidtermConnectionString);

            bool usernameExists = _dbConn.Staffs.Any(item => item.Staff_Username == tbUser.Text && item.Staff_ID != _selectedItem.Staff_ID);

            if (!usernameExists)
            {
                string updateName = tbName.Text;
                string updateUsername = tbUser.Text;

                string updateRole = (cmbSR.SelectedItem as ComboBoxItem)?.Content.ToString();
                string updateStatus = (cmbSS.SelectedItem as ComboBoxItem)?.Content.ToString();

                if (updateRole == "MANAGER")
                    updateRole = "SR1";
                else if (updateRole == "EMPLOYEE")
                    updateRole = "SR2";

                if (updateStatus == "ACTIVE")
                    updateStatus = "SS1";
                else if (updateStatus == "INACTIVE")
                    updateStatus = "SS2";

                _dbConn.UpdateStaffInfo(_selectedItem.Staff_ID, updateName, updateUsername, updateRole, updateStatus);
                _dbConn.SubmitChanges();
                MessageBox.Show("Staff updated successfully...");
                back();
            }
            else
                MessageBox.Show("Staff UserName Already Exist... Update Staff Terminated...");
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
                MainWindow mw = new MainWindow(_appLogIn, _username);
                mw.Show();
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            _dbConn.DeleteStaffByID(_selectedItem.Staff_ID);
            MessageBox.Show("Staff has been Removed...");
            back();
        }
    }
}
