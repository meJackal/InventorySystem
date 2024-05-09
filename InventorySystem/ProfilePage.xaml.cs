using System;
using System.Collections;
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
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Window
    {
        DataClasses1DataContext _dbConn = null;
        private int _appLogIn;
        private string _username;

        public ProfilePage(int appLogIn,string username)
        {
            InitializeComponent();

            _appLogIn = appLogIn;
            _username = username;

            _dbConn = new DataClasses1DataContext(
                Properties.Settings.Default.MidtermConnectionString);

            userProfile();
        }

        private void userProfile()
        {
            var user = (from u in _dbConn.Staffs
                         where u.Staff_ID == _username
                         select u).FirstOrDefault();

            if (user != null)
            {
                tbName.Text = user.Staff_Name;
                tbUser.Text = user.Staff_Username;
                pbPass.Password = user.Staff_Password;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            bool usernameExists = false;
            IQueryable<Staff> staffList = from s in _dbConn.Staffs
                                      select s;
            foreach (Staff s in staffList)
            {
                if (s.Staff_Username == tbUser.Text)
                {
                    MessageBox.Show("Staff UserName Already Exist...");
                    usernameExists = true;
                    break;
                }
            }
            if(!usernameExists)
            {
                if (tbName.Text != "" && tbUser.Text != "" && pbPass.Password != "" && pbConfirmPass.Password != "")
                {
                    tbPass.Text = pbPass.Password;
                    tbConfirmPass.Text = pbConfirmPass.Password;
                    if (tbPass.Text == tbConfirmPass.Text)
                    {
                        var staff = (from s in _dbConn.Staffs
                                     where s.Staff_ID == _username
                                     select s).FirstOrDefault();

                        if (staff != null)
                        {
                            staff.Staff_Name = tbName.Text;
                            staff.Staff_Username = tbUser.Text;
                            staff.Staff_Password = tbPass.Text;
                            _dbConn.SubmitChanges();

                            MessageBox.Show("Profile Updated Successfully...");

                            back();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords does not match...");
                    }
                }
                else
                {
                    if (tbName.Text == null)
                        MessageBox.Show("Please enter your name...");
                    if (tbUser.Text == null)
                        MessageBox.Show("Please enter a username...");
                    if (pbPass.Password == "" || pbConfirmPass.Password == "")
                        MessageBox.Show("Please enter a password on both password boxes...");
                }
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

        private void btnToggle_Click(object sender, RoutedEventArgs e)
        {
            Image show = new Image();
            Image unshow = new Image();

            show.Source = new BitmapImage(new Uri("pack://application:,,,/Images/show.png"));
            unshow.Source = new BitmapImage(new Uri("pack://application:,,,/Images/unshow.png"));

            if (pbPass.PasswordChar == '*')
            {
                tbPass.Visibility = Visibility.Visible;
                pbPass.Visibility = Visibility.Collapsed;
                tbPass.Text = pbPass.Password;
                pbPass.PasswordChar = '\0';
                btnToggle.Background = new ImageBrush(show.Source);
            }
            else
            {
                tbPass.Visibility = Visibility.Collapsed;
                pbPass.Visibility = Visibility.Visible;
                pbPass.Password = tbPass.Text;
                pbPass.PasswordChar = '*';
                btnToggle.Background = new ImageBrush(unshow.Source);
            }
        }

        private void btnToggle1_Click(object sender, RoutedEventArgs e)
        {
            Image show = new Image();
            Image unshow = new Image();

            show.Source = new BitmapImage(new Uri("pack://application:,,,/Images/show.png"));
            unshow.Source = new BitmapImage(new Uri("pack://application:,,,/Images/unshow.png"));

            if (pbConfirmPass.PasswordChar == '*')
            {
                tbConfirmPass.Visibility = Visibility.Visible;
                pbConfirmPass.Visibility = Visibility.Collapsed;
                tbConfirmPass.Text = pbConfirmPass.Password;
                pbConfirmPass.PasswordChar = '\0';
                btnToggle1.Background = new ImageBrush(show.Source);
            }
            else
            {
                tbConfirmPass.Visibility = Visibility.Collapsed;
                pbConfirmPass.Visibility = Visibility.Visible;
                pbConfirmPass.Password = tbConfirmPass.Text;
                pbConfirmPass.PasswordChar = '*';
                btnToggle1.Background = new ImageBrush(unshow.Source);
            }
        }
    }
}
