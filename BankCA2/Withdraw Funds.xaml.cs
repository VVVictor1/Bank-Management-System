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
using DAL;
using System.Data;

namespace BankCA2
{
    /// <summary>
    /// Interaction logic for Withdraw_Funds.xaml
    /// </summary>
    public partial class Withdraw_Funds : Window
    {
        public Withdraw_Funds()
        {
            InitializeComponent();
            InitializeCombo();
        }
        EditPop ed = new EditPop();
        private void InitializeCombo()
        {
            List<string> acid = new List<string>();
            ed.PopulateCombo(acid);
            foreach (var acc in acid)
            {
                cboacc.Items.Add(acc);
            }
        }
        DisplayData display = new DisplayData();
        int acnr;
        private void cboacc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string acid = cboacc.SelectedItem.ToString();
            decimal bal;            
             DataTable dt = display.GetUserDeposit(acid, out bal,out acnr);
            txtbal.Text = bal.ToString();
            dgvdata.ItemsSource = dt.DefaultView;

        }

        private void btnwithdraw_Click(object sender, RoutedEventArgs e)
        {
            string acid = cboacc.SelectedItem.ToString();
            decimal bal = decimal.Parse(txtbal.Text);
            decimal amount = decimal.Parse(txtamount.Text);
            decimal nb = bal;

            if(amount < bal)
            {
                nb = bal - amount;
                MessageBox.Show("Your Account has been debited with " + amount + "\n Your new balance is " + nb, "Withdraw Form",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Not enouth funds in your account","Withdraw",MessageBoxButton.OKCancel,MessageBoxImage.Error);
            }


            int sort = 101010;
            Random random = new Random();
            int randomNumber = random.Next(10000000, 99999999);
            string trtype = "Withdraw";

            ed.AllTransaction(acid, trtype, acnr, sort, amount, randomNumber, DateTime.Now);



            display.UpdateBal(acid,nb);
            txtamount.Clear();
        }
    }
}
