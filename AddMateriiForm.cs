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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_POO_bun
{
    public partial class AddMateriiForm : Form
    {
        public AddMateriiForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server  = localhost; userid = root; password = ; database = poo");
            con.Open();

            string Query = "INSERT INTO materii (ID, Nume, Cod, Profesor, Nr_credite) VALUES (NULL, @nume, @cod, @profesor, @nrcredite);";
            MySqlCommand cmd = new MySqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@nume", NameTB.Text);
            cmd.Parameters.AddWithValue("@cod", CodTB.Text);
            cmd.Parameters.AddWithValue("@profesor", ProfesorTB.Text);
            cmd.Parameters.AddWithValue("@nrcredite", int.Parse(NrcTB.Text));

            cmd.ExecuteNonQuery();

            this.Close();

            
        }
    }
}
