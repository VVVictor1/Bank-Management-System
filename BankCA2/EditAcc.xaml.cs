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
    /// Interaction logic for EditAcc.xaml
    /// </summary>
    public partial class EditAcc : Window
    {
        public EditAcc()
        {
            InitializeComponent();
            InitializePop();
           
        }

        EditPop ed = new EditPop();
        private void InitializePop()
        {
            List<string> acno = new List<string>();
            ed.PopulateCombo(acno);

            foreach (string accnr in acno)
            {
                cboacc.Items.Add(accnr);
            }
            cbocounty.ItemsSource = Enum.GetValues(typeof(Counties));
        }

        private void cboacc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
            string aa;
        
            
            aa = cboacc.SelectedItem.ToString();
            AccountInfo accountInfo = ed.Populate(aa);
            if(accountInfo != null)
            {
                txtfn.Text = accountInfo.FirstName;
                txtsn.Text = accountInfo.LastName;
                txtphone.Text = accountInfo.Phone;
                txtem.Text = accountInfo.Email;
                txtadress1.Text = accountInfo.Address1;
                txtadress2.Text = accountInfo.Address2;
                txtcity.Text = accountInfo.City;
            }

           foreach (var item in cbocounty.Items)
            {
                if (item.ToString() == accountInfo.County)
                {
                    cbocounty.SelectedItem = item;
                    break;
                }
            }

            string ff = "Saving Account";
            if (ff == accountInfo.AccountType)
            {
                rdosav.IsChecked = true;
                txtlimit.IsEnabled = false;
            }
            else
            {
                rdocur.IsChecked = true;
                txtlimit.IsEnabled = true;
            }

            txtaccno.Text = accountInfo.AccountNumber.ToString();
            txtsortcode.Text = accountInfo.SortCode.ToString();
            txtbalance.Text = accountInfo.InitialBalance.ToString();
            txtlimit.Text = accountInfo.OverdraftLimit.ToString();


        }


        private void btuupdate_Click(object sender, RoutedEventArgs e)
        {
            string emm = txtem.Text;
            string ph = txtphone.Text;
            string ad1 = txtadress1.Text;
            string ad2 = txtadress2.Text;
            string county = cbocounty.SelectedItem.ToString();
            string cty = txtcity.Text;
            int overlimit = int.Parse(txtlimit.Text);
            string aa = cboacc.SelectedItem.ToString();

            ed.UserUpdate(emm, ph, ad1, ad2, county, cty, overlimit,aa);
            MessageBox.Show("You have successfully updated your details", "Edit",MessageBoxButton.OK,MessageBoxImage.Information);
        }

    }
}
