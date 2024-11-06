using System.Data.SqlClient;

namespace PassGuard
{
    public partial class SignUp : UserControl
    {

        public SignUp()
        {
            InitializeComponent();
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
            else if (password_signup_tbox.Text.Length >= 8 && System.Text.RegularExpressions.Regex.IsMatch(password, @"\d"))
            {

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
                            error.Text = ("An error occurred while creating the account.");
                        }
                    }
                    catch (Exception ex)
                    {
                        error.Text = ($"An error occurred: {ex.Message}");
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

        private void password_signup_tbox_TextChanged(object sender, EventArgs e)
        {
            string password = password_signup_tbox.Text.Trim();

            if (password_signup_tbox.Text.Length >= 8 && System.Text.RegularExpressions.Regex.IsMatch(password, @"\d"))
            {
                pwordstr.Text = "Password strength: Strong";
                pwordstr.ForeColor = Color.Green;
            }
            else if (password_signup_tbox.Text.Length >= 8 && !System.Text.RegularExpressions.Regex.IsMatch(password, @"\d"))
            {
                pwordstr.Text = "Password strength: Medium";
                pwordstr.ForeColor = Color.Orange;
            }
            else if (password_signup_tbox.Text.Length > 0 && password_signup_tbox.Text.Length < 8)
            {
                pwordstr.Text = "Password strength: Weak";
                pwordstr.ForeColor = Color.Red;
            }
            else
            {
                pwordstr.Text = string.Empty; 
            }
        }
    }
}
