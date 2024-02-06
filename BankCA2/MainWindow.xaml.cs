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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DAL;



namespace BankCA2
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

        

        private void txtreg_Click(object sender, RoutedEventArgs e)
        {
            Registration rg = new Registration();
            rg.Show();
        }

        private void menuexit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            
        }

        private void menufile_Click(object sender, RoutedEventArgs e)
        {
            this.Show();
        }

        HashTable hc = new HashTable();
        private void txtlogin_Click(object sender, RoutedEventArgs e)
        {
            
            string ur = txtusername.Text;
            string pass = hc.PassHash(txtpassword.Password);
        

            Regist rg = new Regist();
            string fullname = rg.Login(ur, pass);
            bool loginSuccessful = fullname != null;           
            menuacc.IsEnabled = false;
            

            if (loginSuccessful)
            {
                MessageBox.Show("You have successfully Logged in", "Welcome", MessageBoxButton.OK, MessageBoxImage.Information);
                menuacc.IsEnabled = true;
                lblpass.IsEnabled = false;
                lbluser.IsEnabled = false;
                txtpassword.IsEnabled = false;
                txtusername.IsEnabled = false;
                txtreg.IsEnabled = false;
                txtlogin.IsEnabled = false;
                menulogin.Header = "Log out";
                lblname.Content = "Welcome: " + fullname;
                lblname.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xDE, 0xEA, 0xFF));

            }
            else
            {
                MessageBox.Show("You provide wrong details", "Invalid", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }

            txtusername.Clear();
            txtpassword.Clear();
            

        }

        private void menulogin_Click(object sender, RoutedEventArgs e)
        {
            menuacc.IsEnabled = false;
            lblpass.IsEnabled = true;
            lbluser.IsEnabled = true;
            txtpassword.IsEnabled = true;
            txtusername.IsEnabled = true;
            txtreg.IsEnabled = true;
            txtlogin.IsEnabled = true;
            lblname.Background = Brushes.White;
            lblname.Content = null;
            menulogin.Header = "Log in";
        }

        private void menuaccount_Click(object sender, RoutedEventArgs e)
        {
            NewAccount acc = new NewAccount();
            acc.Show();
        }

        private void menuedit_Click(object sender, RoutedEventArgs e)
        {
            EditAcc edit = new EditAcc();
            edit.Show();
        }

        private void menudeposit_Click(object sender, RoutedEventArgs e)
        {
            DepositFunds df = new DepositFunds();
            df.Show();
        }

        private void menuacc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuwithdraw_Click(object sender, RoutedEventArgs e)
        {
            Withdraw_Funds wf = new Withdraw_Funds();
            wf.Show();
        }

        private void menutransfer_Click(object sender, RoutedEventArgs e)
        {
            Transfer tr = new Transfer();
            tr.Show();
        }

        private void menutransaction_Click(object sender, RoutedEventArgs e)
        {
            Transaction tr = new Transaction();
            tr.Show();
        }
    }
}
