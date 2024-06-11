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
    public partial class AddPrograma : Form
    {
        public AddPrograma()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server  = localhost; userid = root; password = ; database = poo");
            con.Open();

            string Query = "INSERT INTO programe (ID, Nume, Prescurtare, Durata, Tip) VALUES (NULL, @nume, @presc, @durata, @tip);";
            MySqlCommand cmd = new MySqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@nume", NumeTB.Text);
            cmd.Parameters.AddWithValue("@presc", PrescurtareTB.Text);
            cmd.Parameters.AddWithValue("@durata", DurataTB.Text);
            cmd.Parameters.AddWithValue("@tip", TipTB.Text);
            

            cmd.ExecuteNonQuery();

            this.Close();
        }
    }
}
