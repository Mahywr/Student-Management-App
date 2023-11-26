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



                InsertNameIntoDatabas(uniqueId ,userName, cohortYear, selectedDuration);




            }
            else
            {

                MessageBox.Show("Please enter a valid year.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void
            InsertNameIntoDatabas(string uniqueId , string userName, int cohortYear, string selectedDuration )
        {
            string connectionString = "Data Source=C:\\Users\\Asus\\Desktop\\New folder (2)\\practice 1\\practice1DB.db;Version=3;";

            string commandText = "INSERT INTO registration (Name , cohortYear, Duration , id) VALUES (@Name , @cohortYear, @Duration , @UniqueId);";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@Name", userName);
                    command.Parameters.AddWithValue("@cohortYear", cohortYear);
                    command.Parameters.AddWithValue("@Duration", selectedDuration);
                    command.Parameters.AddWithValue("@UniqueId", uniqueId);

                    command.ExecuteNonQuery();

                    MessageBox.Show("saved successfully");
                }
            }
        }
                private string GenerateUniqueId(int cohortYear)
                {
                    Random random = new Random();
                    int randomNumber = random.Next(100000, 999999);
                    return $"{cohortYear}{randomNumber}";
                }





            
        

        private void FrmApllication_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}

