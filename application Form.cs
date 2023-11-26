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
                
                InsertNameIntoDatabas(userName, cohortYear);
            }
            else
            {
                
                MessageBox.Show("Please enter a valid year.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void
            InsertNameIntoDatabas(string userName , int cohortYear)
        {
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3;";

            string commandText = "INSERT INTO registration (Name , cohortYear) VALUES (@Name , @cohortYear);";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@Name", userName);
                    command.Parameters.AddWithValue("@cohortYear", cohortYear);

                    command.ExecuteNonQuery();

                    MessageBox.Show("saved successfully");
                }
            }
        }

        private void FrmApllication_Load(object sender, EventArgs e)
        {

        }
    }


}

