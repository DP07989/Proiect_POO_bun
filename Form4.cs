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
    public partial class ModifyUser : Form
    {
        public ModifyUser()
        {
            InitializeComponent();
        }

        private void ExecuteQueryButton_Click(object sender, EventArgs e)
        {
            if (IDtextBox.Text != "")
            {
                MySqlConnection con = new MySqlConnection("server  = localhost; userid = root; password = ; database = poo");
                con.Open();

                string Query = "UPDATE users SET Name = @user, PassHash = @pass, AL = @AL WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@id", IDtextBox.Text);

                if (!string.IsNullOrEmpty(NumeTextBox.Text))
                {
                    cmd.Parameters.AddWithValue("@user", NumeTextBox.Text);
                }

                if (!string.IsNullOrEmpty(PassTextBox.Text))
                {
                    cmd.Parameters.AddWithValue("@pass", PassTextBox.Text);
                }

                if (!string.IsNullOrEmpty(ALTextBox.Text))
                {
                    cmd.Parameters.AddWithValue("@AL", ALTextBox.Text);
                }

                cmd.ExecuteNonQuery();

                this.Close();
            }
        }

        private void ModifyUser_Load(object sender, EventArgs e)
        {

        }

        private void Titlu_Click(object sender, EventArgs e)
        {

        }
    }
}
