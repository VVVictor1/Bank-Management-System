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
using System.Windows.Shapes;
using System.Data;
using DAL;

namespace BankCA2
{
    /// <summary>
    /// Interaction logic for DepositFunds.xaml
    /// </summary>
    public partial class DepositFunds : Window
    {
        public DepositFunds()
        {
            InitializeComponent();
            InitializeCombo();
        }

        EditPop ed = new EditPop();

        private void InitializeCombo()
        {
           List<string> acid = new List<string>();
            ed.PopulateCombo(acid);
            foreach (var item in acid)
            {
                cboacc.Items.Add(item);
                
            }
        }

        int acno;
        DisplayData display = new DisplayData();
        private void cboacc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string accid = cboacc.SelectedItem.ToString();
            
            decimal bal;
            

            DataTable userData = display.GetUserDeposit(accid,out bal,out acno);
            txtbalance.Text = bal.ToString();
            datagrid.ItemsSource = userData.DefaultView;
            datagrid.IsReadOnly = true;


        }

        private void btndeposit_Click(object sender, RoutedEventArgs e)
        {
            string acid = cboacc.SelectedItem.ToString();
            decimal bal = decimal.Parse(txtbalance.Text);
            decimal amount = decimal.Parse(txtamount.Text);
            decimal nb = bal + amount;
            display.UpdateBal(acid,nb);
            MessageBox.Show("Your new balance is " + nb, "Deposit", MessageBoxButton.OK, MessageBoxImage.Information);


            int sort = 101010;
            Random random = new Random();
            int randomNumber = random.Next(10000000, 99999999);
            string trtype = "Deposit";

            ed.AllTransaction(acid, trtype, acno, sort, amount, randomNumber, DateTime.Now);



            txtamount.Clear();
      


        }

        private void btnrefresh_Click(object sender, RoutedEventArgs e)
        {
            txtamount.Clear();
            txtbalance.Clear();
            
            datagrid.ItemsSource = null;
        }
    }
}
