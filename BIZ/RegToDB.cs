using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BIZ
{

    public class RegToDB
    {
        Regist regist = new Regist();

        public string fullname { get; set; }
        public string username { get; set; }
        public string Email { get; set; }
        public string password { get; set; }

        public RegToDB(string fn,string ur,string email,string pass)
        {
            fullname = fn;
            username = ur;
            Email = email; 
            password = pass;           
        }

        public void AddUser()
        {        
            regist.AddUsers(fullname,username,Email,password);
        }

        
    }
}
