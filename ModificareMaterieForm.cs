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
    public partial class ModificareMaterieForm : Form
    {
        public ModificareMaterieForm()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IDTB.Text))
            {
                MySqlConnection con = new MySqlConnection("server  = localhost; userid = root; password = ; database = poo");
                con.Open();

                string Query = "UPDATE materii SET Nume = ?, Cod = ?, Profesor = ?, Nr_credite = ? WHERE ID = ?";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@id", IDTB.Text);

                if (!string.IsNullOrEmpty(NumeTB.Text))
                {
                    cmd.Parameters.AddWithValue("@nume", NumeTB.Text);
                }

                if (!string.IsNullOrEmpty(CodTB.Text))
                {
                    cmd.Parameters.AddWithValue("@cod", CodTB.Text);
                }

                if (!string.IsNullOrEmpty(ProfesorTB.Text))
                {
                    cmd.Parameters.AddWithValue("@profesor", ProfesorTB.Text);
                }

                if (!string.IsNullOrEmpty(CrediteTB.Text))
                {
                    cmd.Parameters.AddWithValue("@nrcredite", int.Parse(CrediteTB.Text));
                }

                cmd.ExecuteNonQuery();

                this.Close();
            }
        }

    }
}
