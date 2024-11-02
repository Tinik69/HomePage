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
using System.Data.SqlClient;
using System.Collections;

namespace PassGuard
{
    public partial class MainMenu : UserControl
    {
        string connectionString = @"Data Source=localhost\SQLExpress;Initial Catalog=PassGuard_Database;Integrated Security=True;Encrypt=False";

        private string mainUsername;

        public MainMenu(string username)
        {
            InitializeComponent();
            mainUsername = username;
        }
        public MainMenu()
        {
            InitializeComponent();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("Settings"))
            {
                Settings settings = new Settings();
                settings.Dock = DockStyle.Fill;
                HomePage.Instance.PnlContainer.Controls.Add(settings);
            }
            HomePage.Instance.PnlContainer.Controls["Settings"].BringToFront();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (HomePage.Instance.PnlContainer.Controls.ContainsKey("CreateAccount"))
            {
                Control existingCreateAccount = HomePage.Instance.PnlContainer.Controls["CreateAccount"];
                HomePage.Instance.PnlContainer.Controls.Remove(existingCreateAccount);
                existingCreateAccount.Dispose(); // Dispose the old instance to free resources
            }

            // Create and add a fresh instance
            CreateAccount createAcc = new CreateAccount(mainUsername);
            createAcc.Dock = DockStyle.Fill;
            createAcc.AccountCreated += OnAccountCreated;
            HomePage.Instance.PnlContainer.Controls.Add(createAcc);
            HomePage.Instance.PnlContainer.Controls["CreateAccount"].BringToFront();
        }

        private void OnAccountCreated(object sender, AccountEventArgs e)
        {
            // Insert the new account data into the database
            string insertQuery = "INSERT INTO Accounts (Account_name, Account_username, Account_password) VALUES (@Name, @Username, @Password);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", e.AccountName);
                    command.Parameters.AddWithValue("@Username", e.Username);
                    command.Parameters.AddWithValue("@Password", e.Password);
                    command.ExecuteNonQuery();
                }
            }
        }



        private void showbutton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Accounts WHERE Account_id = (SELECT Account_id FROM MainAccounts WHERE MainAccount_Username = @mainusername);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@mainusername", mainUsername);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if (HomePage.Instance.PnlContainer.Controls.ContainsKey("LogIn"))
            {
                Control existinglogin = HomePage.Instance.PnlContainer.Controls["LogIn"];
                HomePage.Instance.PnlContainer.Controls.Remove(existinglogin);
                existinglogin.Dispose();
            }

            LogIn login = new LogIn();
            login.Dock = DockStyle.Fill;
            HomePage.Instance.PnlContainer.Controls.Add(login);
            HomePage.Instance.PnlContainer.Controls["LogIn"].BringToFront();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (HomePage.Instance.PnlContainer.Controls.ContainsKey("EditAccount"))
            {
                Control existingEditAccount = HomePage.Instance.PnlContainer.Controls["EditAccount"];
                HomePage.Instance.PnlContainer.Controls.Remove(existingEditAccount);
                existingEditAccount.Dispose(); // Dispose the old instance to free resources
            }

            // Create and add a fresh instance
            EditAccount editAcc = new EditAccount(mainUsername);
            editAcc.Dock = DockStyle.Fill;
            HomePage.Instance.PnlContainer.Controls.Add(editAcc);
            HomePage.Instance.PnlContainer.Controls["EditAccount"].BringToFront();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                error.Text = ("Please select a row to delete.");
                error.ForeColor = Color.Red;
                return;
            }

            string accountName = dataGridView1.SelectedRows[0].Cells["Account_Name"].Value.ToString();

            // Confirm deletion
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            // Connection string to the database
            string connectionString = @"Data Source=localhost\SQLExpress;Initial Catalog=PassGuard_Database;Integrated Security=True;Encrypt=False"; // Replace with your actual connection string

            // SQL query to delete the row from the Accounts table
            string deleteQuery = "DELETE FROM Accounts WHERE Account_Name = @AccountName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                // Add parameter to prevent SQL injection
                command.Parameters.AddWithValue("@AccountName", accountName);

                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the delete command
                    int result = command.ExecuteNonQuery();

                    // Check if the deletion was successful
                    if (result > 0)
                    {
                        // Remove the selected row from the DataGridView
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                        error.Text = ("Account deleted successfully.");
                        error.ForeColor = Color.Green;
                    }
                    else
                    {
                        error.Text = ("Failed to delete the account from the database.");
                        error.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the operation
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
