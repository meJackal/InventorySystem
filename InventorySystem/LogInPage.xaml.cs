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
        public LogInPage()
        {
            InitializeComponent();
        }

        private bool Credentials(string username, string password)
        {
            return username == "admin" && password == "password";
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            if (Credentials(tbName.Text, pbPass.Password))
            {
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
            }
            else if (!Credentials(tbName.Text, pbPass.Password))
                MessageBox.Show("Incorrect Credentials... Try Again...");
            else
                MessageBox.Show("Input Your Credentials First.");
        }

       
    }
}
