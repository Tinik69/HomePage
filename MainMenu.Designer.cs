using System.Data;

namespace PassGuard
{
    partial class MainMenu
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
        /// 

        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            button13 = new Button();
            button14 = new Button();
            addButton = new Button();
            panel2 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            showbutton = new Button();
            backButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 67);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 23);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 1;
            label2.Text = "Welcome to GuardPass";
            // 
            // button13
            // 
            button13.Location = new Point(474, 364);
            button13.Name = "button13";
            button13.Size = new Size(99, 61);
            button13.TabIndex = 13;
            button13.Text = "Edit";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(610, 364);
            button14.Name = "button14";
            button14.Size = new Size(99, 61);
            button14.TabIndex = 14;
            button14.Text = "Delete";
            button14.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(335, 364);
            addButton.Name = "addButton";
            addButton.Size = new Size(99, 61);
            addButton.TabIndex = 15;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(154, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 44);
            panel2.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Accounts";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(154, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(579, 221);
            dataGridView1.TabIndex = 18;
            // 
            // showbutton
            // 
            showbutton.Location = new Point(190, 364);
            showbutton.Name = "showbutton";
            showbutton.Size = new Size(99, 61);
            showbutton.TabIndex = 19;
            showbutton.Text = "Show";
            showbutton.UseVisualStyleBackColor = true;
            showbutton.Click += showbutton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(16, 18);
            backButton.Margin = new Padding(3, 4, 3, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(86, 31);
            backButton.TabIndex = 20;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(showbutton);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(addButton);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(panel1);
            Name = "MainMenu";
            Size = new Size(923, 464);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button13;
        private Button button14;
        private Button addButton;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button showbutton;
        private Button backButton;
    }
}
