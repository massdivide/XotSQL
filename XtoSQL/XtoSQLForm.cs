using System.Collections.Generic;
using System.Text;

namespace XtoSQL
{
    public partial class XtoSQLForm : Form
    {
        private string sqlFile = ""; // Declare the sqlFile variable at the class level


        public XtoSQLForm()
        {
            InitializeComponent();

            Log("XtoSQL initialized");
            Log("Please open a file to convert to SQL");
            Log("Click the 'Convert' button to begin the conversion");
            Log("The SQL file will have the same name as the original file with a .sql extension");
            Log("The SQL file will be saved in the same directory as the main executable.");
            Log("Then Execute the SQL file in your database to insert the data");
            Log("For additional information, conact @MassDivide on Discord or GitHub");
        }




        public void ConvertToSQLInsert(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            string fileName = Path.GetFileName(filePath);
            string insertStatement;
            int i = 0;
            List<string> insertStatements = new List<string>(); // Create a list to store the insert statements
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
            StringBuilder sb = new StringBuilder(); // Create a StringBuilder to build the insert statement

            foreach (string line in lines)
            {
                i++;
                sb.Append($"('{fileNameWithoutExtension}  {line.Replace("'", "''")}')"); // Append each value to the StringBuilder
                if (i < lines.Length)
                {
                    sb.Append(", "); // Add a comma if it's not the last value
                }
            }

            insertStatement = $"INSERT INTO `DataToStore` (`LotsOfData`) VALUES {sb.ToString()};"; // Build the final insert statement
            insertStatements.Add(insertStatement); // Add the insert statement to the list

            Log("Finished. [" + i + "] Items Processed.");
            SaveStringDataToSqlFile(fileNameWithoutExtension + ".sql", insertStatements.ToArray()); // Convert the list to an array and save it to the SQL file
            Log("Saved to: " + fileNameWithoutExtension + ".sql");
        }

        private void XtoSQLForm_Load(object sender, EventArgs e)
        {
        }

        public void XtoSQLForm_Open(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ClearLog();
                sqlFile = openFileDialog.FileName; // Assign the selected file name to the sqlFile variable
                Log("File opened: " + sqlFile);
            }
        }

        public void SaveStringDataToSqlFile(string filePath, string[] data)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in data)
                {
                    writer.WriteLine(line);
                }
            }
        }

        private void LogBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Log(string message)
        {
            DateTime timestamp = DateTime.Now;
            string nm = "[" + timestamp + "]" + " " + message;
            LogBox.Items.Add(nm);
        }

        private void ConvertSQLBUTTON_Click(object sender, EventArgs e)
        {
            Log("Converting to SQL...");
            ConvertToSQLInsert(sqlFile); // Pass the sqlFile
        }
        public void ClearLog()
        {
            LogBox.Items.Clear();
        }

        
    }
}
