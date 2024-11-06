namespace PassGuard
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomePage()); // Ensure MainForm is your initial form
                                             //LogInForm
                                             //SignUpForm
                                             //MainForm
                                             //CreateAccount
                                             //SystemRecoveryForm
        }
    }
}
