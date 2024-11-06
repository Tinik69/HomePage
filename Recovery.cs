using System.Data.SqlClient;

namespace PassGuard
{
    public partial class Recovery : UserControl
    {
        public Recovery()
        {
            InitializeComponent();
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
                    string query = @"
                SELECT account_id 
                FROM Recovery 
                WHERE Birthday = @bday AND Mother = @mama AND Pet = @pet";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@bday", bdayStr);
                        command.Parameters.AddWithValue("@mama", mama);
                        command.Parameters.AddWithValue("@pet", pet);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();

                            if (result != null)
                            {
                                int accountId = (int)result;
                                string mainUsernameQuery = "SELECT MainAccount_Username FROM MainAccounts WHERE account_id = @accountId";
                                using (SqlCommand mainUsernameCommand = new SqlCommand(mainUsernameQuery, connection))
                                {
                                    mainUsernameCommand.Parameters.AddWithValue("@accountId", accountId);
                                    object usernameResult = mainUsernameCommand.ExecuteScalar();

                                    if (usernameResult != null)
                                    {
                                        string mainUsername = usernameResult.ToString();

                                        // Remove any existing MainMenu instance
                                        if (HomePage.Instance.PnlContainer.Controls.ContainsKey("MainMenu"))
                                        {
                                            Control existingMainMenu = HomePage.Instance.PnlContainer.Controls["MainMenu"];
                                            HomePage.Instance.PnlContainer.Controls.Remove(existingMainMenu);
                                            existingMainMenu.Dispose();
                                        }

                                        // Pass both MainUsername and accountId to MainMenu
                                        MainMenu mainMenu = new MainMenu(accountId, mainUsername);
                                        mainMenu.Dock = DockStyle.Fill;
                                        HomePage.Instance.PnlContainer.Controls.Add(mainMenu);
                                        HomePage.Instance.PnlContainer.Controls["MainMenu"].BringToFront();
                                    }
                                    else
                                    {
                                        error.Text = ("No account associated with the provided details.");
                                        error.ForeColor = Color.Red;
                                    }
                                }
                            }
                            else
                            {
                                error.Text = ("Recovery details do not match.");
                                error.ForeColor = Color.Red;
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
                error.Text = ("Please fill out all fields.");
                error.ForeColor = Color.Red;
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
