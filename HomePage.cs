﻿using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGuard
{
    public partial class HomePage : Form
    {
        private Stack<UserControl> navigationStack = new Stack<UserControl>();
        static HomePage _obj;

        public static HomePage Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new HomePage();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public HomePage()
        {
            InitializeComponent();
        }
        public void NavigateTo(UserControl newControl)
        {
            if (this.Controls.Contains(newControl)) return;

            // Save current control on the stack
            if (this.Controls.Count > 0)
            {
                var currentControl = this.Controls[0] as UserControl;
                if (currentControl != null)
                {
                    navigationStack.Push(currentControl);
                    this.Controls.Remove(currentControl);
                }
            }

            // Show the new control
            newControl.Dock = DockStyle.Fill;
            this.Controls.Add(newControl);
        }

        // Method to handle the back navigation
        public void NavigateBack()
        {
            if (navigationStack.Count > 0)
            {
                // Remove current control
                var currentControl = this.Controls[0] as UserControl;
                if (currentControl != null)
                {
                    this.Controls.Remove(currentControl);
                }

                // Show previous control
                var previousControl = navigationStack.Pop();
                previousControl.Dock = DockStyle.Fill;
                this.Controls.Add(previousControl);
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            _obj = this;

            // Clear other controls if they exist to avoid stacking
            HomePage.Instance.PnlContainer.Controls.Clear();

            SignUp signUp = new SignUp();
            signUp.Dock = DockStyle.Fill;
            HomePage.Instance.PnlContainer.Controls.Add(signUp);
            signUp.BringToFront();
        }

        private void about_Click(object sender, EventArgs e)
        {
            _obj = this;

            // Clear other controls if they exist to avoid stacking
            HomePage.Instance.PnlContainer.Controls.Clear();

            About about = new About();
            about.Dock = DockStyle.Fill;
            HomePage.Instance.PnlContainer.Controls.Add(about);
            about.BringToFront();
        }

        private void login_Click(object sender, EventArgs e)
        {
            _obj = this;

            // Clear other controls if they exist to avoid stacking
            HomePage.Instance.PnlContainer.Controls.Clear();

            LogIn login = new LogIn();
            login.Dock = DockStyle.Fill;
            HomePage.Instance.PnlContainer.Controls.Add(login);
            login.BringToFront();
        }



        public void GoBackToMain()
        {
            // Hide all UserControls and reset to the main view
            foreach (Control control in PnlContainer.Controls.OfType<UserControl>())
            {
                control.Hide();
            }
            // Optionally, show any main controls (if you have any other controls to show)
            // e.g. mainLabel.Visible = true; or any specific initialization
            PnlContainer.Visible = true; // Show the main panel if needed
        }
    }

}

