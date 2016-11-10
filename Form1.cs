using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ProjectRanker.src;

// File to read from
// ics4u101_students.csv

namespace ProjectRanker
{
    /// <summary>
    /// This class will handle all actions heard by the form
    /// </summary>
    public partial class f_mainForm : Form
    {
        #region variables
        // Data manager object
        private DataManager dataManager;

        // Team manager object
        private TeamManager teamManager;

        // String of data that will be displayed/used for different purposes
        private string[] data;

        // Is there a voter at this current time
        private bool hasVoter;

        // Who is the current voter?
        private string voter;

        // Declare a new list of students
        private List<Student> students;

        // Enum for which list box is selected
        enum LB
        {
            UNSELECTED,
            SELECTED
        };
        #endregion

        /// <summary>
        /// Called when form is created
        /// </summary>
        public f_mainForm()
        {
            // Called by windows forms
            InitializeComponent();

            // Init dataManager
            dataManager = new DataManager();

            // Set the voter to empty
            voter = "";

            // Set the background color of the window to honeydew
            BackColor = Color.LightSeaGreen;

            // Set the colour of the menu bar to honeydew
            menuStrip1.BackColor = Color.LightSeaGreen;

            // Init the list of students
            students = new List<Student>();
        }

        /// <summary>
        /// Called when the user clicks on the load file button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_loadFile_Click(object sender, EventArgs e)
        {
            // If there are items aleady in the list box...
            if (listBox_unselected.Items.Count > 0)
            {
                // Clear the student list
                students.Clear();

                // Clear the list box
                listBox_unselected.Items.Clear();
            }

            // Try...
            try
            {
                // Loads all data from txt file passed by user to the data array
                data = dataManager.readAllData(t_loadFile.Text);
            }
            // Catch the FileNotFoundException
            catch(FileNotFoundException)
            {
                // Stores the string to tell user that there was an error
                const string errorMessage = "Your file was not found! Please re-enter your file name.\n" +
                    "(Make sure you don't type your extension! i.e .txt)";

                // Stores the string to name the message box that appears
                const string exceptionType = "System.IO.FileNotFoundException";

                // Tell user via message box that their file was not found
                MessageBox.Show(errorMessage,
                    exceptionType);

                // Leave function
                return;
            }

            // Clears the load file text box
            t_loadFile.Clear();

            // Loads all data from the data array into the list box
            //dataManager.loadAllData(data, listBox_unselected);

            // Loads all data from the data array into the list of students
            dataManager.loadAllData(data, students);

            // While i is less than student count...
            foreach (var t in students)
            {
                // Add the student to the list box 
                listBox_unselected.Items.Add(t.Name);
            }
        }

        /// <summary>
        /// Called when the user selects or changes the current selection inside of the unselected list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_unselected_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If there are no items in the list box, leave function
            if (listBox_unselected.Items.Count == 0) return;

            // Declare new object selected
            object selected;

            // Try...
            try
            {
                // Object selected is the same as the current selected item in the list box
                selected = listBox_unselected.SelectedItem;
            } 
            // Catch a null ref exception
            catch(NullReferenceException)
            {
                // Leave function
                return;
            }

            // If the user clicks on the "Last Name,First Name" string at the top, leave function
            //if (selected.Equals("Last Name,First Name")) return;

            // If there is currently no voter...
            if (!hasVoter)
            {
                // Set the voter to the selected person
                voter = selected.ToString();

                // Set the text box to display that voter
                t_currentVoter.Text = voter;

                // Set the voter boolean to true
                hasVoter = true;

                // Call the remove object function
                removeObject(selected, LB.UNSELECTED);

                // Leave the function
                return;
            }

            // Add the selected item to the selected list box
            listBox_selected.Items.Add(selected);

            // Call the remove object function
            removeObject(selected, LB.UNSELECTED);
        }

        /// <summary>
        /// Called when the user selected or changes the currenet selection inside of the selected list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_selected_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If there are no items, leave function
            if (listBox_selected.Items.Count == 0) return;

            // Variable is the same as the selected item in the list box
            var selected = listBox_selected.SelectedItem;

            // Add the selected item to the unselected item box
            listBox_unselected.Items.Add(selected);

            // Remove the selected item from the list box
            removeObject(selected, LB.SELECTED);
        }

        /// <summary>
        /// Called when the user clicks the remove voter button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_removeVoter_Click(object sender, EventArgs e)
        {
            // Add the selected item to the unselected list box
            listBox_unselected.Items.Add(voter);

            // Set the voter string to empty
            voter = "";

            // Set the has voter boolean to false
            hasVoter = false;

            // Display the current voter
            t_currentVoter.Text = voter;
        }

        /// <summary>
        /// Called when an object needs to removed from a list box
        /// </summary>
        /// <param name="selected"></param>
        /// <param name="listBox"></param>
        private void removeObject(object selected, LB listBox)
        {
            // Try...
            try
            {
                //listBox_unselected.Items.Remove(selected);
                
                // If the user has removed an object from the unselected list box...
                if(listBox == LB.UNSELECTED)
                {
                    // Remove the selected object from unselected list box
                    listBox_unselected.Items.Remove(selected);
                }
                // Otherwise they remove an object from the selected list box
                else
                {
                    // Remove the selected object from selected list box
                    listBox_selected.Items.Remove(selected);
                }
            }
            // Catch...
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Called when the user clicks the save file button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_saveFile_Click(object sender, EventArgs e)
        {
            // If there is no voter...
            if(voter.Equals(""))
            {
                // Stores the string to tell the user to select a voter
                var selectVoter = "Please select a voter!";

                // Tell the user to select a voter
                MessageBox.Show(selectVoter);

                // Leave the function
                return;
            }

            // String to store name of file user specified
            var saveFileName = voter;

            // String array for items in the selcted list box
            var itemsInList = new string[listBox_selected.Items.Count];

            // For loop to load list box items into the array
            for (var i = 0;i < listBox_selected.Items.Count;i++)
            {
                // Load data at i from the list box at i
                itemsInList[i] = listBox_selected.Items[i].ToString();
            }
           
            // Try...
            try
            {
                // Write data to a file specified by the user 
                dataManager.writeAllData(saveFileName + ".txt", itemsInList);
            } 
            // Catch...
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Called when the button to create teams is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_createTeams_Click(object sender, EventArgs e)
        {
            // If there are no students in the student list, leave function
            if (students.Count < 1) return;
            
            /*
             * Pseudocode for loading files and assigning rank to different students
             * Create a list of strings, list will hold the name of a student who has a txt file
             * Load avilable text files into the list of strings
             * Read text files
             *  Nested for loop, pass through name of all students then pass through name of students in current file
             *  Based on their index, add their index to their average rank
             */

            // Init teamManager
            teamManager = new TeamManager();

            // student preference lists
            // List of string arrays, basically a list of 
            var fileData = new List<string[]>();

            // Foreach student in the list of students...
            foreach (var std in students)
            {
                // String file is the same as the students name + .txt
                var file = std.Name + ".txt";

                // If the file doesn't exist, restart loop
                if (!File.Exists(file)) continue;

                // Add the string array of the file to the list of string arrays
                fileData.Add(dataManager.readAllData(file));
                std.averageRank = 0;
            }

            // Foreach string array in fileData...
            foreach(var stringArray in fileData)
            {
                // Loop through string array...
                for(var i = 0;i < stringArray.Length;i++)
                {
                    // Loop through students list...
                    foreach (var std in students)
                    {
                        // If the string array at index is equal to student at indexs name...
                        if(stringArray[i].Equals(std.Name))
                        {
                            // Add the string arrays index to the students average rank
                            std.averageRank += i;
                        }
                    }
                }
            }
            // Call the createTeams method
            createTeams(fileData);
        }

        /// <summary>
        /// Called when program needs to make teams
        /// <param name="fileData"></param>
        /// </summary>
        private void createTeams(List<string[]> fileData)
        {
            // New list of students, this list will be sorted by average rank
            var scoreList = new List<Student>();

            // Loop through score list...
            for (var i = 0; i < students.Count; i++)
            {
                // Add each element from students into the score list
                scoreList.Add(students.ElementAt(i));    // ics4u101_students.csv
            }
            
            // Call this method to sort the list by rank
            sortStudentRank(scoreList);

            /*
             * Add the top 4 people to each of their 
             * own teams to make sure they're all seperated
             */

            // Foreach loop counter
            var counter = 0;

            // Foreach team in array of teams...
            foreach (var v in teamManager.arrayOfTeams)
            {
                // Add this student to the team
                v.addStudentToTeam(scoreList.ElementAt(counter));

                // Add one to counter
                counter++;
            }

            // Write the teams to the GUI
            displayTeams(scoreList);
        }

        /// <summary>
        /// Called when program needs to display teams to text box
        /// </summary>
        private void displayTeams(List<Student> scoreList)
        {
            // CONTINUE HERE!!!
            foreach (var v in teamManager.arrayOfTeams)
            {
                rText_textBox1.AppendText("Team " + v.teamNumber);
                //rText_textBox1.
                for (int i = 0; i < teamManager.arrayOfTeams.Count; i++)
                {
                    //rText_textBox1.AppendText();
                }
            }
        }

        /// <summary>
        /// Called when program needs to sort the student scores from lowest to highest
        /// </summary>
        /// <param name="scoreList"></param>
        private void sortStudentRank(List<Student> scoreList)
        {
            // For the # of passes to make...
            for (var i = 1; i < scoreList.Count; i++)
            {
                // For the # of elements per pass...
                for (var j = 0; j < scoreList.Count - 1; j++)
                {
                    // If the current element is NOT larger than the next element...
                    if (!(scoreList.ElementAt(j).averageRank > scoreList.ElementAt(j + 1).averageRank)) continue;
                    
                    // Temp is the same as the element at current index
                    var temp = scoreList.ElementAt(j);

                    // Replace current index with the next index 
                    scoreList[j] = scoreList.ElementAt(j + 1);

                    // Replace the next index with 'current index' a.k.a temp
                    scoreList[j + 1] = temp;
                }
            }
        }
    }
}