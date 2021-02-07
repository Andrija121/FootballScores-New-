using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballScores
{
    class FootballTeam
    {
        private List<string> footballMatches;

        public FootballTeam()
        {
            this.footballMatches = new List<string>();
        }

        public void AddMatch(string homeTeam, string awayTeam, int homeTeamScore, int awayTeamScore)
        {
            string result = homeTeam + " - " + awayTeam + " (" + homeTeamScore + " : " + awayTeamScore + ")";
            footballMatches.Add(result);
        }

        public List<string> GetMatches()
        {
            return footballMatches;
        }
        public List<string> GetMatchesByTeam(string teamName)
        {
            List<string> footballMathcesByTeamName = new List<string>();
            foreach (var match in footballMatches)
            {
                // ASD-DSA (2:1)
                if (match.Contains(teamName))
                {
                    footballMathcesByTeamName.Add(match);

                }

            }
            return footballMathcesByTeamName;
        }

    }
}
