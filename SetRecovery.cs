using System.Data.SqlClient;

namespace PassGuard
{
    public partial class SetRecovery : UserControl
    {
        private string mainUsername;

        public SetRecovery(string mainUsername)
        {
            InitializeComponent();
            this.mainUsername = mainUsername;
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            // Ensure fields are not empty
            if (!string.IsNullOrWhiteSpace(bday_calendar.SelectionStart.ToString("yyyy-MM-dd")) &&
                !string.IsNullOrWhiteSpace(mama_tbox.Text) &&
                !string.IsNullOrWhiteSpace(pet_tbox.Text))
            {
                DateTime bday = bday_calendar.SelectionStart;
                string bdayStr = bday.ToString("yyyy-MM-dd");
                string mama = mama_tbox.Text;
                string pet = pet_tbox.Text;

                // SQL connection string
                string connectionString = @"Data Source=localhost\SQLExpress;Initial Catalog=PassGuard_Database;Integrated Security=True;Encrypt=False";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string getIdQuery = "SELECT Account_id FROM MainAccounts WHERE MainAccount_Username = @mainUsername";
                    string checkQuery = "SELECT COUNT(*) FROM Recovery WHERE Account_id = @accountId";
                    string insertQuery = @"
                        INSERT INTO Recovery (account_id, Birthday, Mother, Pet) 
                        VALUES (@accountId, @bday, @mama, @pet)";
                    string updateQuery = @"
                        UPDATE Recovery 
                        SET Birthday = @bday, Mother = @mama, Pet = @pet 
                        WHERE account_id = @accountId";

                    using (SqlCommand getIdCommand = new SqlCommand(getIdQuery, connection))
                    {
                        getIdCommand.Parameters.AddWithValue("@mainUsername", mainUsername); // Set the logged-in username

                        try
                        {
                            connection.Open();
                            object accountIdObj = getIdCommand.ExecuteScalar();

                            if (accountIdObj == null)
                            {
                                error.Text = "User account not found.";
                                error.ForeColor = Color.Red;
                                return;
                            }

                            int accountId = (int)accountIdObj;

                            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                            {
                                checkCommand.Parameters.AddWithValue("@accountId", accountId);
                                int recordCount = (int)checkCommand.ExecuteScalar();
                                SqlCommand command;

                                if (recordCount == 0)
                                {
                                    // Use the insert query if no recovery info exists
                                    command = new SqlCommand(insertQuery, connection);
                                    error.Text = "Recovery information added successfully.";
                                }
                                else
                                {
                                    command = new SqlCommand(updateQuery, connection);
                                    error.Text = "Recovery information updated successfully.";
                                }

                                command.Parameters.AddWithValue("@accountId", accountId);
                                command.Parameters.AddWithValue("@bday", bdayStr);
                                command.Parameters.AddWithValue("@mama", mama);
                                command.Parameters.AddWithValue("@pet", pet);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    error.ForeColor = Color.Green;
                                    mama_tbox.Clear();
                                    pet_tbox.Clear();
                                }
                                else
                                {
                                    error.Text = "Failed to save recovery information.";
                                    error.ForeColor = Color.Red;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                error.Text = "Please fill out all fields.";
                error.ForeColor = Color.Red;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
