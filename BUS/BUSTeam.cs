using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAO;

namespace BUS
{
    public class BUSTeam
    {
        public DataTable loadDataTeam(int playerID)
        {
            return (new DAOTeam()).LoadDataTeam(playerID);
        }
    }
}
