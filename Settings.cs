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
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void recoverButton_Click(object sender, EventArgs e)
        {
            if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("Recovery"))
            {
                Recovery recovery = new Recovery();
                recovery.Dock = DockStyle.Fill;
                HomePage.Instance.PnlContainer.Controls.Add(recovery);
            }
            HomePage.Instance.PnlContainer.Controls["Recovery"].BringToFront();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            HomePage.Instance.GoBackToMain();
        }
    }
}
