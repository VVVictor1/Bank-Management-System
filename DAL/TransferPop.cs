using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class TransferPop : DAO
    {

        public void PopTrnasferFROM(string acid,out decimal bal,out string fn, out string sn,out int acno)
        {
            bal = 0;
            acno = 0;
            fn = null;
            sn = null;

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspPopUser";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id",acid);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fn = dr.GetString(1);
                sn = dr.GetString(2);
                acno = dr.GetInt32(10);
                bal = dr.GetDecimal(12);
            }
            CloseCon();

        }

        public void TrnasferTO(string acid,out int acno, out int sortcode)
        {
            acno = 0;
            sortcode = 0;

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspPopUser";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", acid);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               
                acno = dr.GetInt32(10);
                sortcode = dr.GetInt32(11);
            }
            CloseCon();

        }

        

       



    }
}
