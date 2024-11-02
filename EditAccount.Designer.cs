namespace PassGuard
{
    partial class EditAccount
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
            submitButton = new Button();
            generateButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            backButton.Location = new Point(14, 17);
            backButton.Margin = new Padding(3, 4, 3, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(86, 31);
            backButton.TabIndex = 9;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 23);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 9;
            label4.Text = "Edit Account";
            // 
            // submitButton
            // 
            submitButton.Location = new Point(398, 307);
            submitButton.Margin = new Padding(3, 4, 3, 4);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(86, 31);
            submitButton.TabIndex = 1;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(526, 307);
            generateButton.Margin = new Padding(3, 4, 3, 4);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(86, 31);
            generateButton.TabIndex = 2;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(451, 141);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(451, 193);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(451, 245);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(258, 145);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 6;
            label1.Text = "Enter new Account Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(258, 197);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 7;
            label2.Text = "Enter new Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(258, 249);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 8;
            label3.Text = "Enter new Password";
            // 
            // EditAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 56);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(generateButton);
            Controls.Add(submitButton);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditAccount";
            Size = new Size(923, 464);
            Load += EditAccount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button submitButton;
        private Button generateButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button backButton;
    }
}
