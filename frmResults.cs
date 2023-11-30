using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_1
{
    public partial class frmResult : Form
    {
        public frmResult()
        {
            InitializeComponent();
            SetupGridResult();
            GridResult.DataSource = FetchStudentResults();
        }

        private void frmResults_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SetupGridResult()
        {
            // Add columns to GridResult DataGridView
             // Adjust this as needed
                                                                                   
        }
        public class StudentResult
        {
            public string StudentName { get; set; }
            public int TotalAssignments { get; set; }
            public int AssignmentsPassed { get; set; }
            public int AssignmentsFailed { get; set; }
            public double AverageGrade { get; set; }
            public string ProgramResult { get; set; }
        }
        private List<StudentResult> FetchStudentResults()
        {
            List<StudentResult> results = new List<StudentResult>();

            // Establish your database connection
            string connectionString = "Data Source=practice1DB.db;Version=3;";
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Query to fetch student data
                string query = @"
            SELECT r.Name, COUNT(a.AssessmentId) AS Total, AVG(g.Grade) AS AverageGrade
            FROM registration r
            JOIN Grades g ON r.id = g.StudentId
            JOIN Assessment a ON g.AssessmentId = a.AssessmentId
            GROUP BY r.Name";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var studentResult = new StudentResult
                            {
                                StudentName = reader["Name"].ToString(),
                                TotalAssignments = Convert.ToInt32(reader["Total"]),
                                AverageGrade = Convert.ToDouble(reader["AverageGrade"]),
                            };

                            // Add logic to calculate passed and failed assignments
                            studentResult.AssignmentsPassed = CalculatePassedAssignments(studentResult.StudentName, conn);
                            studentResult.AssignmentsFailed = studentResult.TotalAssignments - studentResult.AssignmentsPassed;

                            // Determine final result
                            studentResult.ProgramResult = CalculateFinalResult(studentResult.AverageGrade);

                            results.Add(studentResult);
                        }
                    }
                }
            }

            return results;
        }
        private int CalculatePassedAssignments(string studentName, SQLiteConnection conn)
        {
            // Define a pass mark, for example, 50
            int passMark = 50;

            string query = @"
        SELECT COUNT(*)
        FROM Grades g
        JOIN registration r ON g.StudentId = r.id
        WHERE r.Name = @Name AND g.Grade >= @PassMark";

            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", studentName);
                cmd.Parameters.AddWithValue("@PassMark", passMark);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        private string CalculateFinalResult(double averageGrade)
{
    if (averageGrade >= 70)
        return "Distinction";
    else if (averageGrade >= 50)
        return "Pass";
    else
        return "Fail";
}


    }
}
