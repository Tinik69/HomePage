using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
            HomePage.Instance.PnlContainer.Controls.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public string MainUsername { get; private set; }
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Ensure both fields are not empty
            if (!string.IsNullOrWhiteSpace(mainusername_textbox.Text) && !string.IsNullOrWhiteSpace(mainpassword_textbox.Text))
            {
                MainUsername = mainusername_textbox.Text;
                string mainPassword = mainpassword_textbox.Text;

                // Call the method to check if the username and password are valid
                if (IsLoginValid(MainUsername, mainPassword))
                {
                    // Check if MainMenu is already in the container
                    if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("MainMenu"))
                    {
                        // Pass the username to MainMenu when creating it
                        MainMenu mainMenu = new MainMenu(MainUsername);
                        mainMenu.Dock = DockStyle.Fill;
                        HomePage.Instance.PnlContainer.Controls.Add(mainMenu);
                    }

                    // Bring MainMenu to the front
                    HomePage.Instance.PnlContainer.Controls["MainMenu"].BringToFront();
                }
                else
                {
                    error.Text = "Invalid username or password.";
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
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
                    catch (Exception ex)
                    {

                    }
                }
            }

            return isValid;
        }

        private void recoverLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("Recovery"))
            {
                Recovery recovery = new Recovery();
                recovery.Dock = DockStyle.Fill;
                HomePage.Instance.PnlContainer.Controls.Add(recovery);
            }
            HomePage.Instance.PnlContainer.Controls["Recovery"].BringToFront();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void mainpassword_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
