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

namespace BankCA2
{
    /// <summary>
    /// Interaction logic for Transfer.xaml
    /// </summary>
    public partial class Transfer : Window
    {
        public Transfer()
        {
            InitializeComponent();
            InitialzieCombobox();
        }
        EditPop ed = new EditPop();
        private void InitialzieCombobox()
        {

            List<string> acnr = new List<string>();

            ed.PopulateCombo(acnr);

            foreach (var itemfr in acnr)
            {
                cbofrom.Items.Add(itemfr);
                cboto.Items.Add(itemfr);
            }
            

        }
        TransferPop transfer = new TransferPop();

        private void btntransfer_Click(object sender, RoutedEventArgs e)
        {
            AccountDebit();
            AccountCredit();

            string acid = cbofrom.SelectedItem.ToString();

            int sort = 101010;
            Random random = new Random();
            decimal amount = decimal.Parse(txtamount.Text);
            int acno = int.Parse(txtaccnoto.Text);
            int randomNumber = random.Next(10000000, 99999999);
            string trtype = "Transfer";

            ed.AllTransaction(acid, trtype, acno, sort, amount, randomNumber, DateTime.Now);
        }
        DisplayData dt = new DisplayData();
        void AccountDebit()
        {
            string acid = cbofrom.SelectedItem.ToString();
            decimal bal = decimal.Parse(txtbal.Text);
            decimal amount = decimal.Parse(txtamount.Text);
            decimal nb = bal;

            if(amount < bal)
            {
                nb = bal - amount;
                MessageBox.Show("Your Account has been debited with " + amount + "\n Your new balance is " + nb, "Withdraw Form", MessageBoxButton.OK,MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("Not enouth funds in your account");
            }

            
            
            dt.UpdateBal(acid, nb);

        }

        void  AccountCredit()
        {
            string acid = cboto.SelectedItem.ToString();
            decimal bal;
            dt.GetUserData(acid, out bal);

            
            decimal amount = decimal.Parse(txtamount.Text);
            decimal nb = bal + amount;
            
            dt.UpdateBal(acid, nb);
            txtdes.Clear();
            
            txtname.Clear();
        }

        private void cbofrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fn;
            string sn;
            decimal bal;
            int accfrom;

            string acid = cbofrom.SelectedItem.ToString();

            transfer.PopTrnasferFROM(acid, out bal, out fn, out sn, out accfrom);

            txtfn.Text = fn;
            txtsn.Text = sn;
            txtbal.Text = bal.ToString();
            txtaccnofrom.Text = accfrom.ToString();

        }

        private void cboto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int accto;
            int sortcode;

            string acid = cboto.SelectedItem.ToString();
            transfer.TrnasferTO(acid, out accto, out sortcode);

            txtaccnoto.Text = accto.ToString();
            txtsortcode.Text = sortcode.ToString();


        }
    }
}
