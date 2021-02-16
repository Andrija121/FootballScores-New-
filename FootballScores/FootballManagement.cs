using System.Collections.Generic;

namespace FootballScores
{
    internal class FootballManagement
    {
        private static readonly List<string> FootballTeams = new List<string>();


        public List<string> GetTeams()
        {
            return FootballTeams;
        }

        public bool AddTeam(string teamName)
        {
            if (!FootballTeams.Contains(teamName))
            {
                FootballTeams.Add(teamName);
                return true;
            }

            return false;
        }
        public bool DeleteTeam()
        {
            List<FootballManagement> footballManagements = new List<FootballManagement>();
            if(FootballTeams.Contains(footballManagements.ToString()))
            {
                FootballTeams.Remove(footballManagements.ToString());
                return true;
            }
            return false;
        }
    }
}