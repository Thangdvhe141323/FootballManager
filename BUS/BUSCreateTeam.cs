using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
namespace BUS
{
    public class BUSCreateTeam
    {
        public void CreateTeam(string teamid, string name, string rigion, string image, string monney)
        {
            (new DAOCreateTeam()).CreateTeam(teamid, name, rigion, image, monney);
        }
    }
}
