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
    public partial class CreateAccount : UserControl
    {
        public event EventHandler<AccountEventArgs> AccountCreated;
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

        private void proceedButton_Click(object sender, EventArgs e)
        {

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

