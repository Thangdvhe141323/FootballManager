using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
namespace BUS
{
    public class BUSUser
    {
        public bool checkUser(string account, string password)
        {
            //khong xu ly DB
            //Goi sang DAO de xu ly
            return (new DAOUser()).checkUser(account, password);
        }
    }
}
