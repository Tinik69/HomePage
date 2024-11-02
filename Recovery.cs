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
    public partial class Recovery : UserControl
    {
        public Recovery()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Recovery_Load(object sender, EventArgs e)
        {

        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("LogIn"))
            {
                LogIn login = new LogIn();
                login.Dock = DockStyle.Fill;
                HomePage.Instance.PnlContainer.Controls.Add(login);
            }
            HomePage.Instance.PnlContainer.Controls["LogIn"].BringToFront();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void birthdayLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
