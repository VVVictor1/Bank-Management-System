using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DAL;

namespace BIZ
{
   public class NewAcc
    {
        public string First_Name{ get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phonne { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Account_Type { get; set; }
        public int Account_Number { get; set; }
        public int Sort_Code { get; set; }
        private decimal bal;
        public decimal Initial_Balance {

            get
            {
                return bal;
            }
            set
            {
                if(bal >= 0)
                {
                    bal = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        
        }

        public int Overdraft_Limit { get; set; }

        public NewAcc(string fn,string sn, string em,string ph,string adr1,string adr2,string cty,string county,string acctype,int accno,int sortco,decimal initlbal,int overlimit)
        {
            First_Name = fn;
            Surname = sn;
            Email = em;
            Phonne = ph;
            Adress1 = adr1;
            Adress2 = adr2;
            City = cty;
            County = county;
            Account_Type = acctype;
            Account_Number = accno;
            Sort_Code = sortco;
            Initial_Balance = initlbal;
            Overdraft_Limit = overlimit;

        }

        Regist rg = new Regist();
        
        public void NewAccount()
        {
            rg.NAcc(First_Name,Surname,Email,Phonne,Adress1,Adress2,City,County,Account_Type,Account_Number,Sort_Code,Initial_Balance,Overdraft_Limit);
        }
        

        

    }
}
