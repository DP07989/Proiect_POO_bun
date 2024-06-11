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
    public partial class ModificaPrograma : Form
    {
        public ModificaPrograma()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IDTextBox.Text))
            {
                MySqlConnection con = new MySqlConnection("server  = localhost; userid = root; password = ; database = poo");
                con.Open();

                string Query = "UPDATE programe SET Nume = @nume, Prescurtare = @pres, Durata = @Dr, Tip = @tip WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@id", IDTextBox.Text);

                if (!string.IsNullOrEmpty(NumeTextBox.Text))
                {
                    cmd.Parameters.AddWithValue("@nume", NumeTextBox.Text);
                }

                if (!string.IsNullOrEmpty(PrescurtareTextBox.Text))
                {
                    cmd.Parameters.AddWithValue("@pres", PrescurtareTextBox.Text);
                }

                if (!string.IsNullOrEmpty(DurataTextBox.Text))
                {
                    cmd.Parameters.AddWithValue("@Dr", DurataTextBox.Text);
                }

                if (!string.IsNullOrEmpty(TipTextBox.Text))
                {
                    cmd.Parameters.AddWithValue("@tip", TipTextBox.Text);
                }

                cmd.ExecuteNonQuery();

                this.Close();
            }
        }

    }
}
