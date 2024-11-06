namespace PassGuard
{
    partial class CreateAccount
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
            backButton = new Button();
            label4 = new Label();
            createusername_tbox = new TextBox();
            createpassword_tbox = new TextBox();
            addaccButton = new Button();
            generateButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            accname_tbox = new TextBox();
            error = new Label();
            passwordstrength = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 67);
            panel1.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.Location = new Point(15, 17);
            backButton.Margin = new Padding(3, 4, 3, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(86, 31);
            backButton.TabIndex = 10;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(418, 17);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 9;
            label4.Text = "Create Account";
            // 
            // createusername_tbox
            // 
            createusername_tbox.BackColor = SystemColors.ControlLightLight;
            createusername_tbox.Location = new Point(470, 175);
            createusername_tbox.Margin = new Padding(3, 4, 3, 4);
            createusername_tbox.Name = "createusername_tbox";
            createusername_tbox.Size = new Size(114, 27);
            createusername_tbox.TabIndex = 1;
            // 
            // createpassword_tbox
            // 
            createpassword_tbox.BackColor = SystemColors.ControlLightLight;
            createpassword_tbox.Location = new Point(470, 233);
            createpassword_tbox.Margin = new Padding(3, 4, 3, 4);
            createpassword_tbox.Name = "createpassword_tbox";
            createpassword_tbox.Size = new Size(114, 27);
            createpassword_tbox.TabIndex = 2;
            // 
            // addaccButton
            // 
            addaccButton.Location = new Point(347, 316);
            addaccButton.Margin = new Padding(3, 4, 3, 4);
            addaccButton.Name = "addaccButton";
            addaccButton.Size = new Size(86, 31);
            addaccButton.TabIndex = 4;
            addaccButton.Text = "Add";
            addaccButton.UseVisualStyleBackColor = true;
            addaccButton.Click += addaccButton_Click;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(470, 316);
            generateButton.Margin = new Padding(3, 4, 3, 4);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(86, 31);
            generateButton.TabIndex = 5;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(304, 179);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 6;
            label1.Text = "Create your Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(304, 237);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 7;
            label2.Text = "Create your Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(304, 122);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 9;
            label3.Text = "Account Name";
            // 
            // accname_tbox
            // 
            accname_tbox.BackColor = SystemColors.ControlLightLight;
            accname_tbox.Location = new Point(470, 118);
            accname_tbox.Margin = new Padding(3, 4, 3, 4);
            accname_tbox.Name = "accname_tbox";
            accname_tbox.Size = new Size(114, 27);
            accname_tbox.TabIndex = 8;
            // 
            // error
            // 
            error.AutoSize = true;
            error.ForeColor = Color.Red;
            error.Location = new Point(347, 278);
            error.Name = "error";
            error.Size = new Size(0, 20);
            error.TabIndex = 10;
            // 
            // passwordstrength
            // 
            passwordstrength.AutoSize = true;
            passwordstrength.Location = new Point(608, 236);
            passwordstrength.Name = "passwordstrength";
            passwordstrength.Size = new Size(0, 20);
            passwordstrength.TabIndex = 11;
            createpassword_tbox.TextChanged += createpassword_tbox_TextChanged;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 56);
            Controls.Add(passwordstrength);
            Controls.Add(error);
            Controls.Add(label3);
            Controls.Add(accname_tbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(generateButton);
            Controls.Add(addaccButton);
            Controls.Add(createpassword_tbox);
            Controls.Add(createusername_tbox);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateAccount";
            Size = new Size(923, 464);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox createusername_tbox;
        private TextBox createpassword_tbox;
        private Button addaccButton;
        private Button generateButton;
        private Label label1;
        private Label label2;
        private Button backButton;
        private Label label3;
        private TextBox accname_tbox;
        private Label error;
        private Label passwordstrength;

    }
}
