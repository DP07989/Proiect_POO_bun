﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_POO_bun
{
    public partial class UniCatalog : Form
    {
        public UniCatalog()
        {
            InitializeComponent();

            userBox.Text = "Username...";
            userBox.ForeColor = Color.Gray;

            passwordBox.Text = "Password...";
            passwordBox.PasswordChar = '\0';
            passwordBox.ForeColor = Color.Gray;
        }

        private void userBox_Enter(object sender, EventArgs e)
        {
            if (userBox.Text == "Username...")
            {
                userBox.Text = "";
                userBox.ForeColor = Color.Black;
            }
        }

        private void userBox_Leave(object sender, EventArgs e)
        {
            if (userBox.Text == "")
            {
                userBox.Text = "Username...";
                userBox.ForeColor = Color.Gray;
            }
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            if(passwordBox.Text == "Password...")
            {
                passwordBox.Text = "";

                if (showPasswordCheckBox.Checked == false)
                    passwordBox.PasswordChar = '*'; 
                else passwordBox.PasswordChar = '\0';
                    
                passwordBox.ForeColor = Color.Black;
            }
        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                passwordBox.Text = "Password...";
                passwordBox.PasswordChar = '\0';
                passwordBox.ForeColor = Color.Gray;
            }
        }
        

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked == true)
                passwordBox.PasswordChar = '\0';
            else 
                if(passwordBox.Text !="Password...")
                passwordBox.PasswordChar = '*';
        }
    }
}
