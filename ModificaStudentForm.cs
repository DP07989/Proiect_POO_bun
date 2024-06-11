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
    public partial class ModificaStudentForm : Form
    {
        public ModificaStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IDtextBox.Text != "")
            {
                MySqlConnection con = new MySqlConnection("server  = localhost; userid = root; password = ; database = poo");
                con.Open();

                string C = (CI.Text == "Licenta") ? "L" : "M"; // Ciclu_inv
                string F = FTB.Text; // Forma de invatamant is now taken from FTB
                string P = PS.Text; // Program
                string A = An.Text.Substring(An.Text.Length - 1); // Last digit of An_studiu
                string hash = Gr.Text; // Grupa

                string NM = $"{C}{F}{P}{A}{hash}";

                string Query = "UPDATE studenti SET Nume = @Nume, Initiala_tatalui = @initTata, CNP = @CNP, Data_i = @DI, Ciclu_inv = @CI, Medie_i = @MI, NM = @NM, Program = @PS, An_studiu = @An, Grupa = @Gr WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@id", IDtextBox.Text);

                if (!string.IsNullOrEmpty(Nume.Text))
                {
                    cmd.Parameters.AddWithValue("@Nume", Nume.Text);
                }

                if (!string.IsNullOrEmpty(initTata.Text))
                {
                    cmd.Parameters.AddWithValue("@initTata", initTata.Text);
                }

                if (!string.IsNullOrEmpty(CNP.Text))
                {
                    cmd.Parameters.AddWithValue("@CNP", CNP.Text);
                }

                if (!string.IsNullOrEmpty(DI.Text))
                {
                    cmd.Parameters.AddWithValue("@DI", DI.Text);
                }

                if (!string.IsNullOrEmpty(CI.Text))
                {
                    cmd.Parameters.AddWithValue("@CI", CI.Text);
                }

                if (!string.IsNullOrEmpty(MI.Text))
                {
                    cmd.Parameters.AddWithValue("@MI", MI.Text);
                }

                if (!string.IsNullOrEmpty(NM))
                {
                    cmd.Parameters.AddWithValue("@NM", NM);
                }

                if (!string.IsNullOrEmpty(PS.Text))
                {
                    cmd.Parameters.AddWithValue("@PS", PS.Text);
                }

                if (!string.IsNullOrEmpty(An.Text))
                {
                    cmd.Parameters.AddWithValue("@An", An.Text);
                }

                if (!string.IsNullOrEmpty(Gr.Text))
                {
                    cmd.Parameters.AddWithValue("@Gr", Gr.Text);
                }

                cmd.ExecuteNonQuery();

                con.Close();
            }
        }
    }
}
