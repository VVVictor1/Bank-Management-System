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
using System.Text.RegularExpressions;
using BIZ;
using System.Net;
using System.Net.Mail;


namespace BankCA2
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        HashTable hc = new HashTable();
        RegToDB RegistDB;
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        
        public string code { get; set; }
        private string emailadress;
        public string Email_Adress {
          get {
                return emailadress; 
              }

            set
            {
             
                    if (regex.IsMatch(value))
                    {
                        emailadress = value;
                    }
                    else
                    {
                      throw new ArgumentException("Invalid email address");
                    }
                
            
              }
            }
        
        private string fullname;
        private string username;       
        private string password;


        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            fullname = txtfn.Text;
            username = txtuser.Text;
            emailadress = txtemail.Text;
            password = txtpass.Password;
            
            Email_Adress = emailadress;
           
            string[] noempty = { fullname, username,Email_Adress,password};
            bool isempty = false;
            foreach (string nm in noempty)
            {
                if (nm == string.Empty)
                {
                    isempty = true;
                    MessageBox.Show("Please fill in all the fields","Invalid",MessageBoxButton.OKCancel,MessageBoxImage.Warning);
                    break;
                }
            }

            if (!isempty)
            {

                code = Generate_Code();

                try
                {
                    EM_Confirmation Email_Confirm = new EM_Confirmation(code);
                    MailMessage mail = new MailMessage();
                    SmtpClient smtpclient = new SmtpClient("smtp.gmail.com");
                    mail.From = new MailAddress("viictorvaalah@gmail.com");
                    mail.To.Add(emailadress);
                    mail.Subject = "Email Verification";
                    mail.Body = $"<html ><body> <h1>Your verifcation code is <br> <b> {code} </b> </h1> </body> </html>";
                    mail.IsBodyHtml = true;
                    smtpclient.Port = 587;
                    smtpclient.UseDefaultCredentials = false;
                    smtpclient.Credentials = new NetworkCredential("viictorvaalah@gmail.com", "svxcyiutubqmrqds");
                    smtpclient.EnableSsl = true;
                    smtpclient.Send(mail);
                    password = hc.PassHash(txtpass.Password);
                    Email_Confirm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }
        //joh.william212@gmail.com

        public void Confirmed()
        {
                RegistDB = new RegToDB(fullname, username,Email_Adress, password);
                RegistDB.AddUser();
                MessageBox.Show("You have successfully signed up", "Welcome", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();            
        }

        public string Generate_Code()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

    }

}
