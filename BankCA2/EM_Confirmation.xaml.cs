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


namespace BankCA2
{
    /// <summary>
    /// Interaction logic for EM_Confirmation.xaml
    /// </summary>
    public partial class EM_Confirmation : Window
    {
        private string Confirmation;

        Registration registration = new Registration();

        public EM_Confirmation(string code)
        {
            
            InitializeComponent();
            Confirmation = code;
  
            lblEmail.Content = registration.Email_Adress;
            
        }
        
        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {            
            string User_Code = txtCode.Text;            
            if (User_Code == Confirmation)
            {              
                registration.Confirmed();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Code", "Confiramtion", MessageBoxButton.OKCancel,MessageBoxImage.Error);
            }
        
        }
       
    }
}
