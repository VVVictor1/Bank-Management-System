using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Regist:DAO
    {
        public void AddUsers(string fn,string ur,string email,string pass)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAddUser";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fn",fn);
            cmd.Parameters.AddWithValue("@ur",ur);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", pass);

            cmd.ExecuteNonQuery();

            CloseCon();

            
        }

        public string Login(string ur,string pass)
        {

            SqlDataReader dr;
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspLogin";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ur", ur);
            cmd.Parameters.AddWithValue("@pass", pass);
            
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string fullname = dr.GetString(1);
                return fullname;    
            }
            return null;                 
        }

        public void NAcc(string fn, string sn, string em, string ph, string adr1, string adr2, string cty, string county, string acctype, int accno, int sortco, decimal initlbal, int overlimit)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAccount";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@sn", sn);
            cmd.Parameters.AddWithValue("@em", em);
            cmd.Parameters.AddWithValue("@ph", ph);
            cmd.Parameters.AddWithValue("@ad1", adr1);
            cmd.Parameters.AddWithValue("@ad2", adr2);
            cmd.Parameters.AddWithValue("@cty", cty);
            cmd.Parameters.AddWithValue("@county", county);
            cmd.Parameters.AddWithValue("@acctype", acctype);
            cmd.Parameters.AddWithValue("@accno", accno);
            cmd.Parameters.AddWithValue("@sortco", sortco);
            cmd.Parameters.AddWithValue("@inibal", initlbal);
            cmd.Parameters.AddWithValue("@overlimit", overlimit);

            cmd.ExecuteNonQuery();
            CloseCon();

        }

    }
}
