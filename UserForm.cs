using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_POO_bun
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*MySqlConnection con = new MySqlConnection("server  = localhost; userid = root; password = ; database = poo");
                con.Open();

                string query = "SELECT * FROM users WHERE Name = @username AND PassHash = @password";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", userBox.Text);
                cmd.Parameters.AddWithValue("@password", passwordBox.Text);

                MySqlDataReader rdr = cmd.ExecuteReader();*/

            MySqlConnection con  = new MySqlConnection("server  = localhost; userid = root; password = ; database = poo");
            con.Open();

            string Query = "INSERT INTO users (Name, PassHash, AL) VALUES (@user, @pass, @AL)";
            MySqlCommand cmd = new MySqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@user", NumeTextBox.Text);
            cmd.Parameters.AddWithValue("@pass", PassTextBox.Text);
            cmd.Parameters.AddWithValue("@AL", ALTextBox.Text);


            cmd.ExecuteNonQuery();

            this.Close();
        }
    }
}
