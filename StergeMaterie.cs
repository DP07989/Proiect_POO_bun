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
    public partial class StergeMaterie : Form
    {
        public StergeMaterie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server  = localhost; userid = root; password = ; database = poo");
            con.Open();

            string Query = "DELETE FROM materii WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);




            cmd.ExecuteNonQuery();

            this.Close();
        }
    }
}
