using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class BUSManageAcc
    {
        public bool updateAcc(string pass, string phone, string email, string ques, string ans, int userID)
        {
            return (new DAOManageAcc()).updateAcc(pass, phone, email, ques, ans, userID);
        }
    }
}
