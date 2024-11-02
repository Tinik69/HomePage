namespace PassGuard
{
    partial class SignUp
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
            proceedButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            backButton = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // proceedButton
            // 
            proceedButton.Anchor = AnchorStyles.Bottom;
            proceedButton.Location = new Point(482, 276);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(94, 29);
            proceedButton.TabIndex = 0;
            proceedButton.Text = "Proceed";
            proceedButton.UseVisualStyleBackColor = true;
            proceedButton.Click += proceedButton_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom;
            textBox1.Location = new Point(415, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom;
            textBox2.Location = new Point(415, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(235, 27);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(235, 180);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 5;
            label1.Text = "Create Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(235, 227);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 6;
            label2.Text = "Create Password";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 67);
            panel1.TabIndex = 8;
            // 
            // backButton
            // 
            backButton.Location = new Point(13, 13);
            backButton.Name = "backButton";
            backButton.Size = new Size(106, 35);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(415, 20);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 0;
            label4.Text = "Sign Up";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 56);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(proceedButton);
            Name = "SignUp";
            Size = new Size(923, 464);
            Load += SignUp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button proceedButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Button backButton;
    }
}
