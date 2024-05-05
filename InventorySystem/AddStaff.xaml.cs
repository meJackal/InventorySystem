using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace InventorySystem
{
    /// <summary>
    /// Interaction logic for StaffUpdatePage.xaml
    /// </summary>
    public partial class AddStaff : Window
    {
        DataClasses1DataContext _dbConn = null;
        private int _appLogIn;

        public AddStaff(int appLogIn)
        {
            InitializeComponent();
            _appLogIn = appLogIn;
            _dbConn = new DataClasses1DataContext(
               Properties.Settings.Default.MidtermConnectionString);
        }

        private void btnAddStaff_Click(object sender, RoutedEventArgs e)
        {
            bool dupe = false;
            bool flag = false;
            IQueryable<Staff> staff = from s in _dbConn.Staffs
                                      select s;
            int count = 1;
            DateTime date = DateTime.Now;
            string convert = "";
            count = staff.Count();
            foreach (Staff s in staff)
            {
                if(s.Staff_Username == tbUser.Text)
                {
                    MessageBox.Show("Staff UserName Already Exist... Add Staff Terminated...");
                    dupe = true;
                    break;
                }
            }
            if (!dupe)
            {
                Staff newstaff = new Staff();
                if(tbName.Text != null && tbUser.Text != null && tbPass.Text != null)
                {
                    if (count.ToString().Length < 2)
                        convert += 0;
                    convert = "S" + convert;
                    convert += count.ToString();
                    newstaff.Staff_ID = convert;
                    newstaff.Staff_Name = tbName.Text;
                    newstaff.Staff_Username = tbUser.Text;
                    newstaff.Staff_Password = tbPass.Text;
                    newstaff.StaffRole_ID = "SR2";
                    newstaff.StaffStatus_ID = "SS1";
                    _dbConn.Staffs.InsertOnSubmit(newstaff);
                    _dbConn.SubmitChanges();
                    flag = true;
                }
            }
            if (flag)
            {
                ManagerPage mp = new ManagerPage(_appLogIn);
                mp.Show();
                this.Close();
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            back();
        }

        private void back()
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
