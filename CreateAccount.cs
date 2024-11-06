using System.Data;
using System.Data.SqlClient;

namespace PassGuard
{
    public partial class CreateAccount : UserControl
    {
        private string mainUsername;

        private string GenerateRandomPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public CreateAccount(string mainusername)
        {
            InitializeComponent();
            mainUsername = mainusername;
        }

        private void addaccButton_Click(object sender, EventArgs e)
        {
            string accountName = accname_tbox.Text;
            string username = createusername_tbox.Text;
            string password = createpassword_tbox.Text;

            if (!string.IsNullOrWhiteSpace(accname_tbox.Text) &&
                    !string.IsNullOrWhiteSpace(createusername_tbox.Text) &&
                    !string.IsNullOrWhiteSpace(createpassword_tbox.Text))
            {
                if (createpassword_tbox.Text.Length >= 8 && System.Text.RegularExpressions.Regex.IsMatch(password, @"\d"))
                {

                    // SQL connection string
                    string connectionString = @"Data Source=localhost\SQLExpress;Initial Catalog=PassGuard_Database;Integrated Security=True;Encrypt=False";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // SQL query to insert a new account into the Accounts table
                        string query = @"
                    INSERT INTO Accounts (Account_id, Account_Name, Account_Username, Account_Password)
                    VALUES ((SELECT Account_id FROM MainAccounts WHERE MainAccount_Username = @mainUsername), @accountName, @username, @password)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Set parameters for the query
                            command.Parameters.AddWithValue("@mainUsername", mainUsername); // Logged-in user's username
                            command.Parameters.AddWithValue("@accountName", accountName);
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);

                            try
                            {
                                connection.Open();
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    error.Text = ("Account successfully created.");
                                    error.ForeColor = Color.Green;

                                    accname_tbox.Clear();
                                    createusername_tbox.Clear();
                                    createpassword_tbox.Clear();
                                }
                                else
                                {
                                    error.Text = ("Failed to create account. Please try again.");
                                    error.ForeColor = Color.Red;
                                }
                            }
                            catch (Exception)
                            {


                            }
                        }
                    }
                }
                else
                {
                    error.Text = password.Length < 8 ? "Password must be at least 8 characters long."
                    : "Password must contain at least one number.";
                    error.ForeColor = Color.Red;
                }

            }
            else
            {
                error.Text = ("Please fill out all fields.");
                error.ForeColor = Color.Red;
            }

            // Ensure fields are not empty

        }
        private void createpassword_tbox_TextChanged(object sender, EventArgs e)
        {
            string password = createpassword_tbox.Text.Trim();

            if (createpassword_tbox.Text.Length >= 8 && System.Text.RegularExpressions.Regex.IsMatch(password, @"\d"))
            {
                passwordstrength.Text = "Password strength: Strong";
                passwordstrength.ForeColor = Color.Green;
            }
            else if (createpassword_tbox.Text.Length >= 8 && !System.Text.RegularExpressions.Regex.IsMatch(password, @"\d"))
            {
                passwordstrength.Text = "Password strength: Medium";
                passwordstrength.ForeColor = Color.Orange;
            }
            else if (createpassword_tbox.Text.Length > 0 && createpassword_tbox.Text.Length < 8)
            {
                passwordstrength.Text = "Password strength: Weak";
                passwordstrength.ForeColor = Color.Red;
            }
            else
            {
                passwordstrength.Text = string.Empty;
            }
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string randomPassword = GenerateRandomPassword();
            createpassword_tbox.Text = randomPassword;
        }

        
    }

    public class AccountEventArgs : EventArgs
    {
        public string AccountName { get; }
        public string Username { get; }
        public string Password { get; }

        public AccountEventArgs(string accountName, string username, string password)
        {
            AccountName = accountName;
            Username = username;
            Password = password;
        }
    }

}

