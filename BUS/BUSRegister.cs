using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace BUS
{
    public class BUSRegister
    {
        public void Register(string user, string pass, string phone, string email,object ques ,string ass)
        {
            
            (new DAORegister()).Register(user, pass, phone, email,ques,ass);
        }

        
    }
}
