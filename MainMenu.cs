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
            if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("CreateAccount"))
            {
                CreateAccount createAcc = new CreateAccount();
                createAcc.Dock = DockStyle.Fill;
                createAcc.AccountCreated += OnAccountCreated;
                HomePage.Instance.PnlContainer.Controls.Add(createAcc);
            }
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
            string query = "SELECT * FROM Accounts WHERE Account_id = (SELECT Account_id FROM MainAccounts WHERE MainAccount_Username = @Parameter);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Parameter", mainUsername);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }
    }
}
