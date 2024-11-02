namespace PassGuard
{
    partial class LogIn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            backButton = new Button();
            mainusername_textbox = new TextBox();
            mainpassword_textbox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            recoverLink = new LinkLabel();
            label2 = new Label();
            error = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(backButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 67);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(439, 24);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 8;
            label1.Text = "Log In";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 25);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "Log In";
            // 
            // backButton
            // 
            backButton.Location = new Point(11, 20);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 0;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // mainusername_textbox
            // 
            mainusername_textbox.Location = new Point(394, 176);
            mainusername_textbox.Name = "mainusername_textbox";
            mainusername_textbox.Size = new Size(125, 27);
            mainusername_textbox.TabIndex = 1;
            // 
            // mainpassword_textbox
            // 
            mainpassword_textbox.Location = new Point(394, 247);
            mainpassword_textbox.Name = "mainpassword_textbox";
            mainpassword_textbox.Size = new Size(125, 27);
            mainpassword_textbox.TabIndex = 2;
            mainpassword_textbox.TextChanged += mainpassword_textbox_TextChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.ForeColor = Color.White;
            usernameLabel.Location = new Point(409, 153);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(108, 20);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Your Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(409, 224);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(103, 20);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Your Password";
            passwordLabel.Click += passwordLabel_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(409, 322);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 5;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // recoverLink
            // 
            recoverLink.AutoSize = true;
            recoverLink.Location = new Point(463, 372);
            recoverLink.Name = "recoverLink";
            recoverLink.Size = new Size(69, 20);
            recoverLink.TabIndex = 6;
            recoverLink.TabStop = true;
            recoverLink.Text = "Recovery";
            recoverLink.LinkClicked += recoverLink_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(373, 372);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 9;
            label2.Text = "Can't Log in?";
            label2.Click += label2_Click;
            // 
            // error
            // 
            error.AutoSize = true;
            error.ForeColor = Color.Red;
            error.Location = new Point(357, 287);
            error.Name = "error";
            error.Size = new Size(0, 20);
            error.TabIndex = 10;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 56);
            Controls.Add(error);
            Controls.Add(label2);
            Controls.Add(recoverLink);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(mainpassword_textbox);
            Controls.Add(mainusername_textbox);
            Controls.Add(panel1);
            Name = "LogIn";
            Size = new Size(923, 464);
            Load += LogIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox mainusername_textbox;
        private TextBox mainpassword_textbox;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button loginButton;
        private LinkLabel recoverLink;
        private Button backButton;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label error;
    }
}
