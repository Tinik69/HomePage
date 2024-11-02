namespace PassGuard
{
    partial class Recovery
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
            label4 = new Label();
            backButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            birthdayLabel = new Label();
            parentLabel = new Label();
            petLabel = new Label();
            proceedButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(backButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 67);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(445, 24);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 1;
            label4.Text = "Recovery";
            label4.Click += label4_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(18, 19);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 0;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(407, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(407, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(407, 252);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.ForeColor = SystemColors.ControlLightLight;
            birthdayLabel.Location = new Point(397, 103);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(160, 20);
            birthdayLabel.TabIndex = 4;
            birthdayLabel.Text = "When is your birthday?";
            birthdayLabel.Click += birthdayLabel_Click;
            // 
            // parentLabel
            // 
            parentLabel.AutoSize = true;
            parentLabel.ForeColor = SystemColors.ControlLightLight;
            parentLabel.Location = new Point(383, 163);
            parentLabel.Name = "parentLabel";
            parentLabel.Size = new Size(195, 20);
            parentLabel.TabIndex = 5;
            parentLabel.Text = "What is your parent's name?";
            // 
            // petLabel
            // 
            petLabel.AutoSize = true;
            petLabel.ForeColor = SystemColors.ControlLightLight;
            petLabel.Location = new Point(373, 229);
            petLabel.Name = "petLabel";
            petLabel.Size = new Size(208, 20);
            petLabel.TabIndex = 6;
            petLabel.Text = "What is the name of your pet?";
            // 
            // proceedButton
            // 
            proceedButton.Location = new Point(423, 307);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(94, 29);
            proceedButton.TabIndex = 7;
            proceedButton.Text = "Proceed";
            proceedButton.UseVisualStyleBackColor = true;
            proceedButton.Click += proceedButton_Click;
            // 
            // Recovery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 56);
            Controls.Add(proceedButton);
            Controls.Add(petLabel);
            Controls.Add(parentLabel);
            Controls.Add(birthdayLabel);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "Recovery";
            Size = new Size(923, 464);
            Load += Recovery_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label birthdayLabel;
        private Label parentLabel;
        private Label petLabel;
        private Button proceedButton;
        private Button backButton;
        private Label label4;
    }
}
