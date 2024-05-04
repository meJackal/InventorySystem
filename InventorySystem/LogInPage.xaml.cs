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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InventorySystem
{
    /// <summary>
    /// Interaction logic for LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Window
    {
        DataClasses1DataContext _dbConn = null;
        public int _appLogIn;

        public LogInPage()
        {
            InitializeComponent();
            _dbConn = new DataClasses1DataContext(
                Properties.Settings.Default.MidtermConnectionString);
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            if (tbName.Text.Length > 0 && pbPass.Password.Length > 0)
            {
                IQueryable<Staff> selectResults = from s in _dbConn.Staffs
                                                  where s.Staff_Username == tbName.Text
                                                  select s;

                if (selectResults.Count() == 1)
                {
                    foreach (Staff s in selectResults)
                    {
                        if (s.Staff_Password == pbPass.Password || s.Staff_Password == tbPass.Text)
                        {
                            MessageBox.Show($"Login complete... {s.Staff_Name}");

                            if (s.StaffRole_ID == "SR1")
                            {
                                _appLogIn = 1;
                                ManagerPage mp = new ManagerPage(_appLogIn);
                                mp.Show();

                            }
                            else if (s.StaffRole_ID == "SR2")
                            {
                                _appLogIn = 2;
                                MainWindow mw = new MainWindow(_appLogIn);
                                mw.Show();

                            }

                            this.Close();
                        }
                        else
                            MessageBox.Show("The password is incorrect...");
                    }
                }
                else
                    MessageBox.Show("The username does not exist...");

                _dbConn.SubmitChanges();
            }
            else
                MessageBox.Show("Please Input Username & Password...");
        }

        private void btnToggle_Click(object sender, RoutedEventArgs e)
        {
            Image show = new Image();
            Image unshow = new Image();

            show.Source = new BitmapImage(new Uri("pack://application:,,,/Images/show.png"));
            unshow.Source= new BitmapImage(new Uri("pack://application:,,,/Images/unshow.png"));

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
    }
}
