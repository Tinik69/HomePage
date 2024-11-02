using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

    public CreateAccount()
    {
        InitializeComponent();
    }

    private void proceedButton_Click(object sender, EventArgs e)
    {
        // Validate inputs before proceeding
        if (!string.IsNullOrWhiteSpace(accname_tbox.Text) && !string.IsNullOrWhiteSpace(createusername_tbox.Text) && !string.IsNullOrWhiteSpace(createpassword_tbox.Text))
        {
            // Trigger the AccountCreated event and pass the account data
            AccountCreated?.Invoke(this, new AccountEventArgs(accname_tbox.Text, createusername_tbox.Text, createpassword_tbox.Text));
            
            // Clear fields after the event is triggered
            accname_tbox.Text = "";
            createusername_tbox.Text = "";
            createpassword_tbox.Text = "";
        }
        else
        {
            MessageBox.Show("Please fill out all fields.");
        }
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        this.Hide();
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
