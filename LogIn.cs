using System.Data.SqlClient;


namespace PassGuard
{
    public partial class LogIn : UserControl
    {

        public LogIn()

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



        public string MainUsername { get; private set; }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(mainusername_textbox.Text) && !string.IsNullOrWhiteSpace(mainpassword_textbox.Text))
            {
                MainUsername = mainusername_textbox.Text;
                string mainPassword = mainpassword_textbox.Text;

                if (IsLoginValid(MainUsername, mainPassword))
                {
                    if (HomePage.Instance.PnlContainer.Controls.ContainsKey("MainMenu"))
                    {
                        Control existingMainMenu = HomePage.Instance.PnlContainer.Controls["MainMenu"];
                        HomePage.Instance.PnlContainer.Controls.Remove(existingMainMenu);
                        existingMainMenu.Dispose();
                    }

                    MainMenu mainMenu = new MainMenu(MainUsername);
                    mainMenu.Dock = DockStyle.Fill;
                    HomePage.Instance.PnlContainer.Controls.Add(mainMenu);

                    HomePage.Instance.PnlContainer.Controls["MainMenu"].BringToFront();
                }
                else
                {
                    error.Text = "Invalid username or password.";
                }
            }
            else
            {
                error.Text = "Please fill out all fields.";
            }
        }

        private bool IsLoginValid(string username, string password)
        {
            bool isValid = false;
            string connectionString = @"Data Source=localhost\SQLExpress;Initial Catalog=PassGuard_Database;Integrated Security=True;Encrypt=False";
            string query = "SELECT COUNT(*) FROM MainAccounts WHERE MainAccount_Username = @username AND MainAccount_Password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            isValid = true;
                        }
                    }
                    catch (Exception)
                    {


                    }
                }
            }

            return isValid;
        }

        private void recoverLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (HomePage.Instance.PnlContainer.Controls.ContainsKey("Recovery"))
            {
                Control existingRecovery = HomePage.Instance.PnlContainer.Controls["Recovery"];
                HomePage.Instance.PnlContainer.Controls.Remove(existingRecovery);
                existingRecovery.Dispose(); // Dispose the old instance to free resources
            }

            // Create and add a fresh instance
            Recovery recovery = new Recovery();
            recovery.Dock = DockStyle.Fill;
            HomePage.Instance.PnlContainer.Controls.Add(recovery);
            HomePage.Instance.PnlContainer.Controls["Recovery"].BringToFront();
        }


    }
}
