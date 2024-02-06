using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{

    public class AccountInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string AccountType { get; set; }
        public int AccountNumber { get; set; }
        public int SortCode { get; set; }
        public decimal InitialBalance { get; set; }
        public int OverdraftLimit { get; set; }
    }

    public class EditPop : DAO
    {

        public void PopulateCombo(List<string> accnrs)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspPopCombo";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string accno = dr.GetInt32(0).ToString();
                accnrs.Add(accno);
            }
            CloseCon();
        }
    
        
      public AccountInfo Populate(string accountNR) 
        {
            AccountInfo account = null;

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspPopUser";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", accountNR);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                account = new AccountInfo
                {
                    FirstName = dr.GetString(1),
                    LastName = dr.GetString(2),
                    Email = dr.GetString(3),
                    Phone = dr.GetString(4),
                    Address1 = dr.GetString(5),
                    Address2 = dr.GetString(6),
                    City = dr.GetString(7),
                    County = dr.GetString(8),
                    AccountType = dr.GetString(9),
                    AccountNumber = dr.GetInt32(10),
                    SortCode = dr.GetInt32(11),
                    InitialBalance = dr.GetDecimal(12),
                    OverdraftLimit = dr.GetInt32(13)
                };
                
            }

            CloseCon();
            return account;
        }  
      
     


        public void UserUpdate(string em,string ph,string ad1,string ad2,string county,string cty,int limit,string id)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "UserUpdate";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@em", em);
            cmd.Parameters.AddWithValue("@ph", ph);
            cmd.Parameters.AddWithValue("@ad1", ad1);
            cmd.Parameters.AddWithValue("@ad2", ad2);
            cmd.Parameters.AddWithValue("@county", county);
            cmd.Parameters.AddWithValue("@cty", cty);
            cmd.Parameters.AddWithValue("@limit", limit);

            cmd.ExecuteNonQuery();
            CloseCon();
        }

       

        public void AllTransaction(string id, string transtype, int destaccnr, int descsort, decimal tranamount, int referno, DateTime timestamp)
        {
            
          

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "UspTransaction";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("@transtype", transtype);
            cmd.Parameters.AddWithValue("@destaccnr", destaccnr);
            cmd.Parameters.AddWithValue("@descsort", descsort);
            cmd.Parameters.AddWithValue("@transamount", tranamount);
            cmd.Parameters.AddWithValue("@transareferennumber", referno);
            cmd.Parameters.AddWithValue("@timestamp", timestamp);


            cmd.ExecuteNonQuery();
            CloseCon();
        }


    }
}
