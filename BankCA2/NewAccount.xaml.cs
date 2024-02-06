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
using BIZ;

namespace BankCA2
{
    /// <summary>
    /// Interaction logic for NewAccount.xaml
    /// </summary>
    public partial class NewAccount : Window
    {

       

        public NewAccount()
        {
            InitializeComponent();
            InitializeCombobox();
        }

        private void InitializeCombobox()
        {           
            cbocounty.ItemsSource = Enum.GetValues(typeof(Counties));
            cbocounty.SelectedIndex = (int)Counties.Antrim;
        }

        private void rdocurrent_Checked(object sender, RoutedEventArgs e)
        {
            lbllimit.IsEnabled = true;
            txtlimit.IsEnabled = true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string fn = txtfn.Text;
            string sn = txtsn.Text;
            string em = txtem.Text;
            string ph = txtphone.Text;
            string ad1 = txtadress1.Text;
            string ad2 = txtadress2.Text;
            string cty = txtcity.Text;
            string county = cbocounty.SelectedItem.ToString();
            string acctype = "Current Account ";
            if (rdosaving.IsChecked.Value)
            {
                acctype = "Saving account";
                txtlimit.Text = "0";
               
            }
            int accno = int.Parse(txtaccno.Text);
            int sortco  = 101010;
            decimal inibal = decimal.Parse(txtbalance.Text);
            int overlimit = int.Parse(txtlimit.Text);

            
            NewAcc acc = new NewAcc(fn,sn,em,ph,ad1,ad2,cty,county,acctype,accno,sortco,inibal,overlimit);
            acc.NewAccount();

            txtlimit.Clear();
            txtfn.Clear();
            txtem.Clear();
            txtcity.Clear();          
            txtsn.Clear();
            txtadress1.Clear();
            txtadress2.Clear();
            txtbalance.Clear();
            txtaccno.Clear();
            txtphone.Clear();

        }

       

        private void rdosaving_Checked(object sender, RoutedEventArgs e)
        {
            lbllimit.IsEnabled = false;
            txtlimit.IsEnabled = false;
            
        }
       
    }
    
}
