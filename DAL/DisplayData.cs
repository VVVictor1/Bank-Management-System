using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DisplayData : DAO
    {
        
        public DataTable GetUserData(string acid,out decimal bal)
        {
            bal = 0;
           
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspPopUser";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", acid);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                bal = dr.GetDecimal(12);
            }
            CloseCon();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            CloseCon();

            return dt;
        }

        public DataTable GetUserDeposit(string acid, out decimal bal, out int acno)
        {
            bal = 0;
            acno = 0;
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspPopUser";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", acid);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                acno = dr.GetInt32(10);
                bal = dr.GetDecimal(12);
            }
            CloseCon();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            CloseCon();

            return dt;
        }

        public DataTable TransactionAll()
        {

            SqlDataAdapter da;
            DataTable dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspGetAlltra";
            cmd.CommandType = CommandType.StoredProcedure;

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            CloseCon();

            return dt;
        }


        public void UpdateBal(string acid,decimal nb)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "UspBalance";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("id", acid);
            cmd.Parameters.AddWithValue("bal",nb);

            cmd.ExecuteNonQuery();
            CloseCon();

        }
    }
}
