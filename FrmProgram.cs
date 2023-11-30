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
using System.Xml.Linq;

namespace practice_1
{
    public partial class FrmProgram : Form
    {
        public FrmProgram()
        {
            InitializeComponent();
            LoadProgramData();

        }

        private void btnSaveProgram_Click(object sender, EventArgs e)
        {
            string programTitle = txtProgramTitle.Text;
            if (!int.TryParse(txtCohortYear.Text, out int cohortYear))
            {
                MessageBox.Show("Please enter a valid cohort year.");
                return;
            }

            // Generate a unique 6-digit ID
            int programId = GenerateUniqueId();

            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3;";
            string query = "INSERT INTO DegreeProgram (id, Title, CohortYear) VALUES (@id, @Title, @CohortYear)";

            using (var conn = new SQLiteConnection(connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", programId);
                    cmd.Parameters.AddWithValue("@Title", programTitle);
                    cmd.Parameters.AddWithValue("@CohortYear", cohortYear);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Program added successfully.");
            txtProgramTitle.Clear();
            txtCohortYear.Clear();
            LoadProgramData();
        }

        private int GenerateUniqueId()
        {
            Random random = new Random();
            int id;
            bool idExists;

            do
            {
                id = random.Next(100000, 999999); // Generate a random 6-digit ID
                idExists = CheckIfIdExists(id); // Implement this method to check if the ID already exists in the database
            }
            while (idExists);

            return id;
        }

        // You need to implement this method
        private bool CheckIfIdExists(int id)
        {
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3;";
            string query = "SELECT COUNT(*) FROM DegreeProgram WHERE id = @id";

            using (var conn = new SQLiteConnection(connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void LoadProgramData()
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3;";
            string query = "SELECT * FROM DegreeProgram"; // Adjust the query if needed

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

            GridProgram.DataSource = dt;
        }

        private void btnRemoveProgram_Click(object sender, EventArgs e)
        {
            if (GridProgram.CurrentRow == null)
            {
                MessageBox.Show("Please select a program to remove.");
                return;
            }

            int programId = Convert.ToInt32(GridProgram.CurrentRow.Cells[1].Value); // Replace "id" with the actual name of the ID column

            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3;";
            string query = "DELETE FROM DegreeProgram WHERE id = @id";

            using (var conn = new SQLiteConnection(connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", programId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Program removed successfully.");
            LoadProgramData(); // Refresh the grid after removing the program
        }

        private void FrmProgram_Load(object sender, EventArgs e)
        {

        }
    }
}





