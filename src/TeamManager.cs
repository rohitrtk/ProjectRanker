using System.Collections.Generic;

namespace ProjectRanker.src
{
    /// <summary>
    /// This class will handle all the teams required for this project
    /// </summary>
    class TeamManager
    {
        // Array of teams to store the different teams
        public List<Team> arrayOfTeams;

        /// <summary>
        /// Called when team manager is inited
        /// </summary>
        public TeamManager()
        {
            // Init array of teams
            arrayOfTeams = new List<Team> ();

            // While i is less than the number of teams 
            for(var i = 0;i < arrayOfTeams.Count;i++)
            {
                // If i isn't at the last index...
                arrayOfTeams.Add(i < arrayOfTeams.Count - 1 ? new Team(i, 4) : new Team(i, 5));
            }
        }
    }
}