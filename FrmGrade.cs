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
    public partial class FrmGrade : Form
    {
        public FrmGrade()
        {
            InitializeComponent();

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchStudent(searchText);
            }
            else
            {
                MessageBox.Show("Please enter a name or ID to search.");
            }
        }

        private void SearchStudent(string searchText)
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=practice1DB.db;Version=3";
            string query = "SELECT id, Name FROM registration WHERE Name LIKE @SearchText OR id = @SearchId";

            using (var conn = new SQLiteConnection(connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%"); // For name search
                    int searchId;
                    if (int.TryParse(searchText, out searchId))
                    {
                        // searchText is a valid integer, use it for ID search
                        cmd.Parameters.AddWithValue("@SearchId", searchId);
                    }
                    else
                    {
                        // searchText is not a valid integer, use a dummy value for ID search !
                        cmd.Parameters.AddWithValue("@SearchId", -1);
                    }

                    conn.Open();
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            gridStudents.DataSource = dt;
        }

        //selecting student

        private void gridStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = gridStudents.Rows[e.RowIndex];
                int studentId = Convert.ToInt32(row.Cells["id"].Value); // Replace "id" with the actual column name for student ID
                DisplayStudentAssessments(studentId);
            }
        }
        private void DisplayStudentAssessments(int studentId)
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3";

            string query = @"
         SELECT a.AssessmentId, a.AssessmentName, g.Grade
    FROM Assessment a
    LEFT JOIN ModuleTable m ON a.ModuleId = m.ModuleId
    LEFT JOIN DegreeProgram d ON m.DegreeProgramId = d.id
    LEFT JOIN registration r ON d.id = r.ProgramDegreeId
    LEFT JOIN Grades g ON a.AssessmentId = g.AssessmentId AND r.id = g.StudentId
    WHERE r.id = @StudentId";

            using (var conn = new SQLiteConnection(connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    conn.Open();
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            // Assuming you have another DataGridView to display assessments
            gridAddGrade.DataSource = dt;
            AddGradeEntryColumnToGrid(); // Method to add a column for entering grades
        }

        private void AddGradeEntryColumnToGrid()
        {
            if (!gridAddGrade.Columns.Contains("Grade"))
            {
                DataGridViewTextBoxColumn gradeColumn = new DataGridViewTextBoxColumn();
                gradeColumn.Name = "Grade";
                gradeColumn.HeaderText = "Enter Grade";
                gridAddGrade.Columns.Add(gradeColumn);
            }
        }

        private void BtnAddGrade_Click(object sender, EventArgs e)
        {
            if (gridStudents.CurrentRow != null)
            {
                int studentId = Convert.ToInt32(gridStudents.CurrentRow.Cells["id"].Value); // Replace "id" with the actual column name for student ID
                DisplayStudentAssessments(studentId);
            }
            else
            {
                MessageBox.Show("Please select a student.");
            }
        }

        private void btnSaveGrade_Click(object sender, EventArgs e)
        {
            if (gridStudents.CurrentRow != null)
            {
                int studentId = Convert.ToInt32(gridStudents.CurrentRow.Cells["id"].Value);
                bool gradesSaved = false;

                foreach (DataGridViewRow row in gridAddGrade.Rows)
                {
                    if (row.Cells["Grade"].Value != null && row.Cells["AssessmentId"].Value != null)
                    {
                        string gradeStr = row.Cells["Grade"].Value.ToString();
                        int assessmentId = Convert.ToInt32(row.Cells["AssessmentId"].Value);

                        if (int.TryParse(gradeStr, out int grade) && grade >= 0 && grade <= 100)
                        {
                            SaveGrade(studentId, assessmentId, grade);
                            gradesSaved = true;
                        }
                        else
                        {
                            MessageBox.Show("Invalid grade for Assessment ID " + assessmentId + ". Please enter a valid grade (0-100).");
                            gradesSaved = false;
                            break; // Stop saving further grades as an invalid entry was found
                        }
                    }
                }

                if (gradesSaved)
                {
                    MessageBox.Show("Grades saved successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a student.");
            }
        }

        private void SaveGrade(int studentId, int assessmentId, int grade)
        {
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3";
            string query = "INSERT INTO Grades (studentId, AssessmentId, Grade) VALUES (@StudentId, @AssessmentId, @Grade)"; // Adjust the query as needed

            using (var conn = new SQLiteConnection(connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    cmd.Parameters.AddWithValue("@AssessmentId", assessmentId);

                    cmd.Parameters.AddWithValue("@Grade", grade);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void FrmGrade_Load(object sender, EventArgs e)
        {

        }
    }
}
