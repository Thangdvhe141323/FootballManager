using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
namespace BUS
{
    public class BUSChange
    {
        public void Update(string user,string pass, string ans, string ques, string phone, string email)
        {
            (new DAOChange()).Update(user,pass, ans, ques, phone, email);
        }
    }
}
