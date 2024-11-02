using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGuard
{
    public partial class SignUp : UserControl
    {

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in HomePage.Instance.PnlContainer.Controls.OfType<UserControl>())
            {
                control.Hide();
            } 
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            string username = username_signup_tbox.Text.Trim();
            string password = password_signup_tbox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                error.Text = ("Please fill out all fields.");
                error.ForeColor = Color.Red;
                return;
            }

            string connectionString = @"Data Source=localhost\SQLExpress;Initial Catalog=PassGuard_Database;Integrated Security=True;Encrypt=False";

            string checkDuplicateQuery = "SELECT COUNT(*) FROM MainAccounts WHERE MainAccount_Username = @Username";
            string insertQuery = "INSERT INTO MainAccounts (MainAccount_Username, MainAccount_Password) VALUES (@Username, @Password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand checkDuplicateCommand = new SqlCommand(checkDuplicateQuery, connection))
            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
            {
                checkDuplicateCommand.Parameters.AddWithValue("@Username", username);
                insertCommand.Parameters.AddWithValue("@Username", username);
                insertCommand.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    int duplicateCount = (int)checkDuplicateCommand.ExecuteScalar();
                    if (duplicateCount > 0)
                    {
                        error.Text = ("This username is already taken.");
                        error.ForeColor = Color.Red;
                        return;
                    }

                    int result = insertCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        error.Text = ("Account created successfully!");
                        error.ForeColor = Color.Green;

                        username_signup_tbox.Clear();
                        password_signup_tbox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while creating the account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
