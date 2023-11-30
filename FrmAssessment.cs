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
    public partial class FrmAssessment : Form
    {
        public FrmAssessment()
        {
            InitializeComponent();
            PopulateModulesComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAssessment_Load(object sender, EventArgs e)
        {
            LoadAssessmentData();

        }
        private int GenerateUniqueIdForAssessment()
        {
            Random random = new Random();
            int id;
            bool idExists;

            do
            {
                id = random.Next(100000, 999999); // Generate a random 6-digit ID
                idExists = CheckIfAssessmentIdExists(id);
            }
            while (idExists);

            return id;
        }

        private bool CheckIfAssessmentIdExists(int id)
        {
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3;";
            string query = "SELECT COUNT(*) FROM Assessment WHERE AssessmentId = @AssessmentId";

            using (var conn = new SQLiteConnection(connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AssessmentId", id);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }



        private void PopulateModulesComboBox()
        {
            DataTable modules = GetModulesFromDatabase();
            cmbModule.DataSource = modules;
            cmbModule.DisplayMember = "ModuleName"; // Adjust as per your ModuleTable column names
            cmbModule.ValueMember = "ModuleId";
        }
        private DataTable GetModulesFromDatabase()
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3";
            string query = "SELECT ModuleId, ModuleName FROM ModuleTable"; // Adjust the query if needed

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

        private void BtnSaveAssessment_Click(object sender, EventArgs e)
        {
            string assessmentName = TxtAssessment.Text;
            int moduleId = Convert.ToInt32(cmbModule.SelectedValue);
            int assessmentId = GenerateUniqueIdForAssessment();


            AddAssessment(assessmentName, moduleId, assessmentId);
            LoadAssessmentData();

        }
        private void AddAssessment(string assessmentName, int moduleId, int assessmentId)
        {
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3";
            string query = "INSERT INTO Assessment (AssessmentId, AssessmentName, ModuleId) VALUES (@AssessmentId, @AssessmentName, @ModuleId)";

            using (var conn = new SQLiteConnection(connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AssessmentId", assessmentId);
                    cmd.Parameters.AddWithValue("@AssessmentName", assessmentName);
                    cmd.Parameters.AddWithValue("@ModuleId", moduleId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Assessment added successfully.");
            TxtAssessment.Clear();
        }
        private void LoadAssessmentData()
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3";
            string query = @"
        SELECT a.AssessmentId, a.AssessmentName, a.ModuleId, m.ModuleName
        FROM Assessment a
        JOIN ModuleTable m ON a.ModuleId = m.ModuleId";

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

            GridAssessment.DataSource = dt;
        }

        private void BtnRemoveAssessment_Click(object sender, EventArgs e)
        {
            if (GridAssessment.CurrentRow == null)
            {
                MessageBox.Show("Please select an assessment to remove.");
                return;
            }

            int assessmentId = Convert.ToInt32(GridAssessment.CurrentRow.Cells[0].Value); 

            // Confirm before deleting
            if (MessageBox.Show("Are you sure you want to delete this assessment?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteAssessment(assessmentId);

            }

        }
        private void DeleteAssessment(int assessmentId)
        {
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3";
            string query = "DELETE FROM Assessment WHERE AssessmentId = @AssessmentId";

            using (var conn = new SQLiteConnection(connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AssessmentId", assessmentId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Assessment removed successfully.");
            LoadAssessmentData(); // Refresh the GridAssessment
        }

    }
}
