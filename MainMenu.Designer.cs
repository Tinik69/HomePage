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
            logoutButton = new Button();
            label2 = new Label();
            editButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            panel2 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            showbutton = new Button();
            error = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(logoutButton);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 67);
            panel1.TabIndex = 0;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(16, 18);
            logoutButton.Margin = new Padding(3, 4, 3, 4);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(86, 31);
            logoutButton.TabIndex = 20;
            logoutButton.Text = "Log Out";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 23);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 1;
            label2.Text = "Welcome to PassGuard!";
            // 
            // editButton
            // 
            editButton.Location = new Point(448, 364);
            editButton.Name = "editButton";
            editButton.Size = new Size(77, 40);
            editButton.TabIndex = 13;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(548, 364);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(77, 40);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(353, 364);
            addButton.Name = "addButton";
            addButton.Size = new Size(77, 40);
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
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(154, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(579, 221);
            dataGridView1.TabIndex = 18;
            // 
            // showbutton
            // 
            showbutton.Location = new Point(257, 364);
            showbutton.Name = "showbutton";
            showbutton.Size = new Size(77, 40);
            showbutton.TabIndex = 19;
            showbutton.Text = "Show";
            showbutton.UseVisualStyleBackColor = true;
            showbutton.Click += showbutton_Click;
            // 
            // error
            // 
            error.AutoSize = true;
            error.ForeColor = Color.Red;
            error.Location = new Point(353, 417);
            error.Name = "error";
            error.Size = new Size(0, 20);
            error.TabIndex = 20;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 56);
            Controls.Add(error);
            Controls.Add(showbutton);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(addButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(panel1);
            Name = "MainMenu";
            Size = new Size(923, 464);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button editButton;
        private Button deleteButton;
        private Button addButton;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button showbutton;
        private Button logoutButton;
        private Label error;
    }
}
