namespace PassGuard
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            signupButton = new Button();
            loginButton = new Button();
            aboutButton = new Button();
            panelContainer = new Panel();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 130);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // signupButton
            // 
            signupButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            signupButton.Location = new Point(713, 11);
            signupButton.Margin = new Padding(3, 2, 3, 2);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(85, 23);
            signupButton.TabIndex = 0;
            signupButton.Text = "Sign Up";
            signupButton.UseVisualStyleBackColor = true;
            signupButton.Click += new System.EventHandler(signup_Click);
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loginButton.Location = new Point(617, 11);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(81, 23);
            loginButton.TabIndex = 1;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += new System.EventHandler(login_Click);
            // 
            // aboutButton
            // 
            aboutButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            aboutButton.Location = new Point(522, 11);
            aboutButton.Margin = new Padding(3, 2, 3, 2);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(80, 23);
            aboutButton.TabIndex = 2;
            aboutButton.Text = "About";
            aboutButton.UseVisualStyleBackColor = true;
            aboutButton.Click += new System.EventHandler(about_Click);
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(aboutButton);
            panelContainer.Controls.Add(signupButton);
            panelContainer.Controls.Add(loginButton);
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(807, 354);
            panelContainer.TabIndex = 5;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 56);
            ClientSize = new Size(807, 350);
            Controls.Add(panelContainer);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomePage";
            Text = "HomePage";
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private Button signupButton;
        private Button loginButton;
        private Button aboutButton;
        private Panel panelContainer;
    }
}