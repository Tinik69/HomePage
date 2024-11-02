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
    public partial class DeleteAccount : UserControl
    {
        public DeleteAccount()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("MainMenu"))
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Dock = DockStyle.Fill;
                HomePage.Instance.PnlContainer.Controls.Add(mainMenu);
            }
            HomePage.Instance.PnlContainer.Controls["MainMenu"].BringToFront();
        }
    }
}
