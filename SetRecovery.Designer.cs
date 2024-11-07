namespace PassGuard
{
    partial class SetRecovery
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
            error = new Label();
            bday_calendar = new MonthCalendar();
            proceedButton = new Button();
            petLabel = new Label();
            motherLabel = new Label();
            birthdayLabel = new Label();
            pet_tbox = new TextBox();
            mama_tbox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(backButton);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 67);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 23);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 1;
            label4.Text = "Set Recovery";
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
            // error
            // 
            error.AutoSize = true;
            error.ForeColor = Color.Red;
            error.Location = new Point(400, 408);
            error.Name = "error";
            error.Size = new Size(0, 20);
            error.TabIndex = 18;
            // 
            // bday_calendar
            // 
            bday_calendar.Location = new Point(347, 108);
            bday_calendar.MaxSelectionCount = 1;
            bday_calendar.Name = "bday_calendar";
            bday_calendar.TabIndex = 17;
            // 
            // proceedButton
            // 
            proceedButton.Location = new Point(430, 434);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(94, 29);
            proceedButton.TabIndex = 16;
            proceedButton.Text = "Proceed";
            proceedButton.UseVisualStyleBackColor = true;
            proceedButton.Click += proceedButton_Click;
            // 
            // petLabel
            // 
            petLabel.AutoSize = true;
            petLabel.ForeColor = SystemColors.ControlLightLight;
            petLabel.Location = new Point(288, 372);
            petLabel.Name = "petLabel";
            petLabel.Size = new Size(208, 20);
            petLabel.TabIndex = 15;
            petLabel.Text = "What is the name of your pet?";
            // 
            // motherLabel
            // 
            motherLabel.AutoSize = true;
            motherLabel.ForeColor = SystemColors.ControlLightLight;
            motherLabel.Location = new Point(288, 330);
            motherLabel.Name = "motherLabel";
            motherLabel.Size = new Size(200, 20);
            motherLabel.TabIndex = 14;
            motherLabel.Text = "What is your mother's name?";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.ForeColor = SystemColors.ControlLightLight;
            birthdayLabel.Location = new Point(400, 79);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(160, 20);
            birthdayLabel.TabIndex = 13;
            birthdayLabel.Text = "When is your birthday?";
            // 
            // pet_tbox
            // 
            pet_tbox.Location = new Point(517, 369);
            pet_tbox.Name = "pet_tbox";
            pet_tbox.Size = new Size(125, 27);
            pet_tbox.TabIndex = 12;
            // 
            // mama_tbox
            // 
            mama_tbox.Location = new Point(517, 327);
            mama_tbox.Name = "mama_tbox";
            mama_tbox.Size = new Size(125, 27);
            mama_tbox.TabIndex = 11;
            // 
            // SetRecovery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 59);
            Controls.Add(panel1);
            Controls.Add(error);
            Controls.Add(bday_calendar);
            Controls.Add(proceedButton);
            Controls.Add(petLabel);
            Controls.Add(motherLabel);
            Controls.Add(birthdayLabel);
            Controls.Add(pet_tbox);
            Controls.Add(mama_tbox);
            Name = "SetRecovery";
            Size = new Size(923, 521);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button backButton;
        private Label error;
        private MonthCalendar bday_calendar;
        private Button proceedButton;
        private Label petLabel;
        private Label motherLabel;
        private Label birthdayLabel;
        private TextBox pet_tbox;
        private TextBox mama_tbox;
    }
}
