using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace BUS
{
    public class BUSForgot
    {
        public void LoadUSer(string name)
        {
             (new DAOForgot()).LoadUSer(name);
        }

        public void Update(string name, string ques, string ans, string phone, string email, string newpass)
        {
            (new DAOForgot()).Update(name, ques, ans, phone, email, newpass);
        }
    }
}
