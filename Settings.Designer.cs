namespace PassGuard
{
    partial class Settings
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
            backButton = new Button();
            logoutButton = new Button();
            recoverButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            // 
            // backButton
            // 
            backButton.Location = new Point(74, 82);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(107, 22);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(237, 82);
            logoutButton.Margin = new Padding(3, 2, 3, 2);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(107, 22);
            logoutButton.TabIndex = 2;
            logoutButton.Text = "Log Out";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // recoverButton
            // 
            recoverButton.Location = new Point(389, 82);
            recoverButton.Margin = new Padding(3, 2, 3, 2);
            recoverButton.Name = "recoverButton";
            recoverButton.Size = new Size(113, 22);
            recoverButton.TabIndex = 3;
            recoverButton.Text = "Recovery";
            recoverButton.UseVisualStyleBackColor = true;
            recoverButton.Click += recoverButton_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(recoverButton);
            Controls.Add(logoutButton);
            Controls.Add(backButton);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Settings";
            Size = new Size(557, 160);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button backButton;
        private Button logoutButton;
        private Button recoverButton;
        private Label label1;
    }
}
