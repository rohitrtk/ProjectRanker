namespace ProjectRanker.src
{
    /// <summary>
    /// This class can hold the name and average rank of a student
    /// </summary>
    class Student
    {
        #region variables
        // Name of the student
        public string Name { get; set; }

        // The average rank of the student
        public float averageRank { get; set; }
        #endregion

        /// <summary>
        /// Called when student is initialized
        /// </summary>
        /// <param name="name"></param>
        public Student(string name)
        {
            // Set Name to the constructors parameter
            Name = name;

            // Set average rank to 0
            averageRank = 0;
        }
    }
}
