namespace PassGuard
{
    public partial class About : UserControl
    {
        public About()
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

    }
}
