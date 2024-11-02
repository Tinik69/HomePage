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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PassGuard
{
    public partial class EditAccount : UserControl
    {
        private string mainUsername;
        public EditAccount(string mainusername)
        {
            InitializeComponent();
            mainUsername = mainusername;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private string GenerateRandomPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string accountName = accname_tbox.Text.Trim();
            string newUsername = edituser_tbox.Text.Trim();
            string newPassword = editpass_tbox.Text.Trim();

            if (string.IsNullOrEmpty(accountName) || string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword))
            {
                error.Text = ("Please fill in all fields.");
                error.ForeColor = Color.Red;
                return;
            }

            string connectionString = @"Data Source=localhost\SQLExpress;Initial Catalog=PassGuard_Database;Integrated Security=True;Encrypt=False";

            string updateQuery = "UPDATE Accounts SET Account_Username = @NewUsername, Account_Password = @NewPassword WHERE Account_Name = @AccountName AND Account_id = (SELECT Account_id FROM MainAccounts WHERE MainAccount_Username = @mainusername)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@mainusername", mainUsername);
                command.Parameters.AddWithValue("@NewUsername", newUsername);
                command.Parameters.AddWithValue("@NewPassword", newPassword);
                command.Parameters.AddWithValue("@AccountName", accountName);

                try
                {
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        error.Text = ("Account updated successfully!");
                        error.ForeColor = Color.Green;

                        accname_tbox.Clear();
                        edituser_tbox.Clear();
                        editpass_tbox.Clear();
                    }
                    else
                    {
                        error.Text = ("No matching account found with the specified name.");
                        error.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string randomPassword = GenerateRandomPassword();
            editpass_tbox.Text = randomPassword;
        }
    }
}
