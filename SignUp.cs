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
    public partial class SignUp : UserControl
    {

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HomePage.Instance.PnlContainer.Controls.Clear();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("Recovery"))
            {
                Recovery recovery = new Recovery();
                recovery.Dock = DockStyle.Fill;
                HomePage.Instance.PnlContainer.Controls.Add(recovery);
            }
            HomePage.Instance.PnlContainer.Controls["Recovery"].BringToFront();
        }
    }
}
