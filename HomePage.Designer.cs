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
            pictureBox1 = new PictureBox();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 173);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 4;
            // 
            // signupButton
            // 
            signupButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            signupButton.Location = new Point(815, 15);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(97, 31);
            signupButton.TabIndex = 0;
            signupButton.Text = "Sign Up";
            signupButton.UseVisualStyleBackColor = true;
            signupButton.Click += signup_Click;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loginButton.Location = new Point(705, 15);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(93, 31);
            loginButton.TabIndex = 1;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += login_Click;
            // 
            // aboutButton
            // 
            aboutButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            aboutButton.Location = new Point(597, 15);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(91, 31);
            aboutButton.TabIndex = 2;
            aboutButton.Text = "About";
            aboutButton.UseVisualStyleBackColor = true;
            aboutButton.Click += about_Click;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(pictureBox1);
            panelContainer.Controls.Add(aboutButton);
            panelContainer.Controls.Add(signupButton);
            panelContainer.Controls.Add(loginButton);
            panelContainer.Location = new Point(0, 0);
            panelContainer.Margin = new Padding(3, 4, 3, 4);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(922, 472);
            panelContainer.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.passguard2;
            pictureBox1.Location = new Point(133, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(741, 550);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 56);
            ClientSize = new Size(922, 603);
            Controls.Add(panelContainer);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HomePage";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PassGuard";
            panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}