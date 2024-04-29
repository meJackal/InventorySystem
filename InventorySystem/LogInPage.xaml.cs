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
        bool flag = false;

        public LogInPage()
        {
            InitializeComponent();
            _dbConn = new DataClasses1DataContext(
                Properties.Settings.Default.InventoryManagementConnectionString);
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            if (tbName.Text.Length > 0 && pbPass.Password.Length > 0)
            {
                flag = false;
                IQueryable<staff> selectResults = from s in _dbConn.staffs
                                                  where s.staff_Username == tbName.Text
                                                  select s;

                if (selectResults.Count() == 1)
                {
                    foreach (staff s in selectResults)
                    {
                        if (s.staff_Pass == pbPass.Password)
                        {
                            MessageBox.Show("Login complete.");

                            flag = true;
                            break;
                        }
                        else
                            MessageBox.Show("The password is incorrect.");
                    }
                }
                else
                    MessageBox.Show("The username does not exist.");

                _dbConn.SubmitChanges();
            }

            if (flag)
            {
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
            }
        }

       
    }
}
