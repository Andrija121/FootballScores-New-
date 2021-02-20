using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballScores
{
    class FootballMatch
    {
        private List<Match> footballMatches;

        public FootballMatch()
        {
            this.footballMatches = new List<Match>();
        }

        public void AddMatch(string homeTeam, string awayTeam, int homeTeamScore, int awayTeamScore)
        {
            Match result = new Match();
            result.HomeTeam = homeTeam;
            result.AwayTeam = awayTeam;
            result.Score = homeTeamScore.ToString() +" : "+ awayTeamScore.ToString();

            footballMatches.Add(result);
        }

        public List<Match> GetMatches()
        {
            return footballMatches;
        }
        public List<Match> GetMatchesByTeam(string teamName)
        {
            List<Match> footballMathcesByTeamName = new List<Match>();
            foreach (var match in footballMatches)
            {
                // ASD F - DSA (2:1) = ASD 
                //12345

                if (match.HomeTeam.Equals(teamName) || match.AwayTeam.Equals(teamName))
                {
                    footballMathcesByTeamName.Add(match);
                }
            }
            return footballMathcesByTeamName;
        }

        public void DeleteMatch(int index)
        {
            footballMatches.RemoveAt(index);
            
        }
        public void ChangeScore(int index,int homeScore,int awayScore)
        {
           
            footballMatches[index].Score = homeScore.ToString() + " : " + awayScore.ToString();
        }
        

    }
}
