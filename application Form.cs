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
using System.Xml;

namespace practice_1
{
    public partial class FrmApllication : Form
    {
        public FrmApllication()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;


            if (int.TryParse(txtCohortYear.Text, out int cohortYear))
            {

                string selectedDuration = cmbDuration.SelectedItem.ToString();
                string uniqueId = GenerateUniqueId(cohortYear);
                int programDegreeId = Convert.ToInt32(cmbDegreePrograms.SelectedValue);



                InsertNameIntoDatabas(uniqueId, userName, cohortYear, selectedDuration , programDegreeId);




            }
            else
            {

                MessageBox.Show("Please enter a valid year.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        private void
            InsertNameIntoDatabas(string uniqueId, string userName, int cohortYear, string selectedDuration, int programDegreeId)
        {
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3;";

            string commandText = "INSERT INTO registration (Name , cohortYear, Duration , id, ProgramDegreeId) VALUES (@Name , @cohortYear, @Duration , @UniqueId ,@ProgramDegreeId );";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@Name", userName);
                    command.Parameters.AddWithValue("@cohortYear", cohortYear);
                    command.Parameters.AddWithValue("@Duration", selectedDuration);
                    command.Parameters.AddWithValue("@UniqueId", uniqueId);
                    command.Parameters.AddWithValue("@ProgramDegreeId", programDegreeId);

                    command.ExecuteNonQuery();

                    MessageBox.Show("saved successfully");
                }
            }
            LoadStudentData();
        }
        private string GenerateUniqueId(int cohortYear)
        {
            Random random = new Random();
            int randomNumber = random.Next(100000, 999999);
            return $"{cohortYear}{randomNumber}";
        }








        private void FrmApllication_Load(object sender, EventArgs e)
        {

            LoadStudentData();
            PopulateDegreeProgramsComboBox();
        }

        private void LoadStudentData()
        {
            var studentData = GetStudentDataFromDatabase();
            gridStd.DataSource = studentData;
        }

        private DataTable GetStudentDataFromDatabase()
        {
            DataTable dt = new DataTable();

            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3;";
            string query = @"
        SELECT r.id, r.Name, r.CohortYear, r.duration, dp.Title AS ProgramName
        FROM registration r
        LEFT JOIN DegreeProgram dp ON r.ProgramDegreeId = dp.id";

            using (var conn = new SQLiteConnection(connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    conn.Open();
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridStd_CellContentClick(object sender, DataGridViewCellEventArgs e) //hereeee
        {



        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (gridStd.CurrentRow != null)
            {
                // Assuming the student's ID is in the first column of the DataGridView
                string studentId = gridStd.CurrentRow.Cells[3].Value.ToString();

                // Remove the student from the database
                RemoveStudentFromDatabase(studentId);

                // Refresh the DataGridView
                LoadStudentData();
            }
            else
            {
                MessageBox.Show("Please select a student to remove.");
            }
        }

        private void RemoveStudentFromDatabase(string studentId)
        {
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3;";
            string query = "DELETE FROM registration WHERE Id = @Id"; // Adjust the column name as per your database schema

            using (var conn = new SQLiteConnection(connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", studentId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }




        }
        private void PopulateDegreeProgramsComboBox()
        {
            DataTable degreePrograms = GetDegreePrograms();
            cmbDegreePrograms.DataSource = degreePrograms;
            cmbDegreePrograms.DisplayMember = "Title"; // Replace with your column name for the program title
            cmbDegreePrograms.ValueMember = "id"; // Replace with your column name for the program ID
        }

        private DataTable GetDegreePrograms()
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3;";
            string query = "SELECT id, Title FROM DegreeProgram"; // Adjust the query as per your table

            using (var conn = new SQLiteConnection(connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    conn.Open();
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }




    }


}

