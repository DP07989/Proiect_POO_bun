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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server  = localhost; userid = root; password = ; database = poo");
            con.Open();

            string C = (CI.Text == "Licenta") ? "L" : "M"; 
            string F = FTB.Text; 
            string P = PS.Text; 
            string A = An.Text.Substring(An.Text.Length - 1); 
            string hash = Gr.Text;

            string NM = $"{C}{F}{P}{A}{hash}";

            string Query = "INSERT INTO studenti (Nume, Initiala_tatalui, CNP, Data_i, Ciclu_inv, Medie_i, NM, Program, An_studiu, Grupa) VALUES (@Nume, @initTata, @CNP, @DI, @CI, @MI, @NM, @PS, @An, @Gr)";
            MySqlCommand cmd = new MySqlCommand(Query, con);

            cmd.Parameters.AddWithValue("@Nume", Nume.Text);
            cmd.Parameters.AddWithValue("@initTata", initTata.Text);
            cmd.Parameters.AddWithValue("@CNP", CNP.Text);
            cmd.Parameters.AddWithValue("@DI", DI.Text);
            cmd.Parameters.AddWithValue("@CI", CI.Text);
            cmd.Parameters.AddWithValue("@MI", MI.Text);
            cmd.Parameters.AddWithValue("@NM", NM);
            cmd.Parameters.AddWithValue("@PS", PS.Text);
            cmd.Parameters.AddWithValue("@An", An.Text);
            cmd.Parameters.AddWithValue("@Gr", Gr.Text);

            cmd.ExecuteNonQuery();

            con.Close();

            this.Close();
        }

    }
}
