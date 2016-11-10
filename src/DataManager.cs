using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProjectRanker.src
{
    /// <summary>
    /// This class willbe responsible for reading, 
    /// loading and writing data to and from files
    /// </summary>
    class DataManager
    {
        /// <summary>
        /// Called when data needs to be read from a file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public string[] readAllData(string fileName)
        {
            // Try...
            try
            {
                // Return all the lines in a given file name
                return File.ReadAllLines(fileName);
            }
            // Catch any exception
            catch (Exception e)
            {
                // Return all the lines in a given file name + .txt
                return File.ReadAllLines(fileName + ".txt");
            }
        }

        /// <summary>
        /// Called when data is required to be loaded into a list box
        /// </summary>
        /// <param name="data"></param>
        /// <param name="listBox"></param>
        public void loadAllData(string[] data, ListBox listBox)
        {
            // Counter for foreach loop
            int i = 0;

            // Declare new string builder to remove , from names
            StringBuilder strb;

            // For each string in the data array...
            foreach (string s in data)
            {
                // Init string builder
                strb = new StringBuilder(s);

                // If the string at any given index in the data array is the same as the unwanted string...
                if (data[i].Equals("Last Name,First Name"))
                {
                    // Add 1 the counter
                    i++;

                    // Restart loop
                    continue;
                }

                for (int j = 0; j < strb.Length; j++)
                {
                    // If there is a comma...
                    if (strb[j].Equals(','))
                    {
                        // Replace index with a space
                        strb[j] = ' ';
                    }
                }

                data[i] = strb.ToString();

                // Add items to the list box index from the data array index
                listBox.Items.Add(data[i]);

                // Add 1 to the counter
                i++;
            }
        }

        /// <summary>
        /// Called when data is loaded into a list of students
        /// </summary>
        /// <param name="data"></param>
        /// <param name="students"></param>
        public void loadAllData(string[] data, List<Student> students)
        {
            // Counter for foreach loop
            int i = 0;

            // Declare new string builder to remove , from names
            StringBuilder strb;

            // For each string in the data array...
            foreach (string s in data)
            {
                // Init string builder
                strb = new StringBuilder(s);

                // If the string at any given index in the data array is the same as the unwanted string...
                if (data[i].Equals("Last Name,First Name"))
                {
                    // Add 1 the counter
                    i++;

                    // Restart loop
                    continue;
                }

                for (int j = 0; j < strb.Length; j++)
                {
                    // If there is a comma...
                    if (strb[j].Equals(','))
                    {
                        // Replace index with a space
                        strb[j] = ' ';
                        break;
                    }
                }

                data[i] = strb.ToString();

                // Add items to the list box index from the data array index
                students.Add(new Student(data[i]));

                // Add 1 to the counter
                i++;
            }
        }

        /// <summary>
        /// Called when data is needed to be written to a file
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        public void writeAllData(string fileName, string[] data)
        {
            // Variable writer is a new Stream Writer with the files name
            var writer = new StreamWriter(fileName);

            // For each string in the data array...
            foreach (string s in data)
            {
                // Write the data to the file line
                writer.WriteLine(s);
            }

            // Close the Stream Writer
            writer.Close();
        }
    }
}