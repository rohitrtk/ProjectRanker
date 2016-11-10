using System.Collections.Generic;

namespace ProjectRanker.src
{
    /// <summary>
    /// This class will hold groups of 4 or 5 students
    /// </summary>
    class Team
    {
        #region variables
        // How many members are currently in the team
        public int teamSize { set; get; }

        // The teams average rank
        public float averageRank { get; set; }

        // ID for team
        public int teamNumber { get; set; }

        // List of students in this team
        public List<Student> students;
        #endregion 
        
        /// <summary>
        /// Called when a new team is made
        /// </summary>
        /// <param name="teamSize"></param>
        public Team(int teamNumber, int teamSize)
        {
            // Sets the team number to the same as the param team number
            this.teamNumber = teamNumber;

            // Sets the team size from class to the same as the param team size
            this.teamSize = teamSize;

            // Sets the average score of this team to 0
            averageRank = 0;

            // Init students
            students = new List<Student>();
        }

        /// <summary>
        /// Called when program needs to assign students to team
        /// </summary>
        /// <param name="student"></param>
        public void addStudentToTeam(Student student)
        {
            // Add this student to the list
            students.Add(new Student(student.Name));
            averageRank += student.averageRank;
        }
    }
}
