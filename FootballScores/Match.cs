using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballScores
{
    class Match
    {

        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public string Score { get; set; }



        public string GetInfo()
        {
            return HomeTeam + " - " + AwayTeam+ "   " + "( "+Score+" )";
        }
    }
}
