using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballScores
{
    class FootballManagement
    {
        private string TeamName;
        private List<FootballTeam> footballTeams;


        public string Name { get { return TeamName; } }

        public FootballManagement (string teamName)
        {
            this.TeamName = teamName;
        }

        public FootballManagement GetName(string teamName)
        {
            List<FootballTeam> filteredFootballTeams = new List<FootballTeam>();
            foreach (var footballTeam in footballTeams)
            {
                filteredFootballTeams.Add(footballTeam);
                
            }

            return null;
        
            
        }

    }
}
