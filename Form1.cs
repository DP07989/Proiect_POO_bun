using MySql.Data.MySqlClient;
using System;
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

        private void submitUserButton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server  = localhost; userid = root; password = ; database = poo");
                con.Open();

                string query = "SELECT * FROM users WHERE Name = @username AND PassHash = @password";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", userBox.Text);
                cmd.Parameters.AddWithValue("@password", passwordBox.Text);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {

                    while (rdr.Read())
                    {
                        Globals.AccesLevel = Convert.ToInt16(rdr["AL"]);
                    }

                    rdr.Close();

                    MainAppForm mainAppForm = new MainAppForm();
                    this.Hide();
                    mainAppForm.ShowDialog();
                    this.Close();
                    Globals.AccesLevel = Convert.ToInt16(rdr["AL"]);


                }
                else
                {
                    MessageBox.Show("Invalid username or password.","Failed Login", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

              
            


            }
            catch (Exception)
            {
                MessageBox.Show("Could not verify user", "Database Connection Failure", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            

            
        }

        private void Main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
