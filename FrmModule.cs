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
    public partial class FrmModule : Form
    {
        public FrmModule()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSaveModule_Click(object sender, EventArgs e)
        {
            string moduleName = txtModule.Text;


            int moduleId = GenerateUniqueIdForModule();
            int degreeProgramId = Convert.ToInt32(cmbDegree.SelectedValue);

            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3;";
            string query = "INSERT INTO ModuleTable (ModuleID, DegreeProgramId, ModuleName) VALUES (@ModuleID, @DegreeProgramId, @ModuleName)";

            using (var conn = new SQLiteConnection(connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ModuleID", moduleId);
                    cmd.Parameters.AddWithValue("@DegreeProgramId", degreeProgramId);
                    cmd.Parameters.AddWithValue("@ModuleName", moduleName);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Module added successfully.");
            txtModule.Clear();
            LoadModulesData();


        }

        private int GenerateUniqueIdForModule()
        {
            Random random = new Random();
            int id;
            bool idExists;

            do
            {
                id = random.Next(100000, 999999); // Generate a random 6-digit ID
                idExists = CheckIfModuleIdExists(id); // Implement this method to check if the ID already exists in the database
            }
            while (idExists);

            return id;
        }

        private bool CheckIfModuleIdExists(int id)
        {
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3;";
            string query = "SELECT COUNT(*) FROM ModuleTable WHERE ModuleID = @ModuleID";

            using (var conn = new SQLiteConnection(connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ModuleID", id);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void TxtModule_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmModule_Load(object sender, EventArgs e)
        {
            PopulateDegreeProgramComboBox();
            LoadModulesData();
        }

        private void PopulateDegreeProgramComboBox()
        {
            DataTable degreePrograms = GetDegreeProgramsFromDatabase();
            cmbDegree.DataSource = degreePrograms;
            cmbDegree.DisplayMember = "Title";
            cmbDegree.ValueMember = "id";
        }

        private DataTable GetDegreeProgramsFromDatabase()
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3;"; // 
            string query = "SELECT id, Title FROM DegreeProgram";

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
        private void LoadModulesData()
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3";

            string query = @"
        SELECT m.ModuleId, m.ModuleName, d.Title AS DegreeProgramName
    FROM ModuleTable m
    JOIN DegreeProgram d ON m.DegreeProgramId = d.id";

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

            gridModule.DataSource = dt;
        }
        private void DeleteModule(int moduleId)
        {
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3";
            string query = "DELETE FROM ModuleTable WHERE ModuleId = @ModuleId";

            using (var conn = new SQLiteConnection(connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ModuleId", moduleId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Module removed successfully.");
            LoadModulesData(); // Refresh the gridModule
        }


        private void BtnRemoveModule_Click(object sender, EventArgs e)
        {
            if (gridModule.CurrentRow == null)
            {
                MessageBox.Show("Please select a module to remove.");
                return;
            }

            // Get the ModuleId of the selected module
            int moduleId = Convert.ToInt32(gridModule.CurrentRow.Cells[0].Value);  // Adjust if your column name is different

            // Confirm before deleting
            if (MessageBox.Show("Are you sure you want to delete this module?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteModule(moduleId);
                LoadModulesData();
            }

        }
    }
}
