using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_POO_bun
{
    public partial class MainAppForm : Form
    {
        string SelectedTable;

        public MainAppForm()
        {
            InitializeComponent();
            AccesLevelLabel.Text = "Acces Level: " + Globals.AccesLevel;
            this.SelectedTable = "studenti";
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void Users_Click(object sender, EventArgs e)
        {
            if (Globals.AccesLevel >= 3)
                SelectedTable = "users";
            else
            {
                MessageBox.Show("Trebuie să fiți administrator (Nivel de acces 3) pentru a modifica aceste date)", "No permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlConnection con = new MySqlConnection("server  = localhost; userid = root; password = ; database = poo");
            con.Open();

            string Query = "SELECT * FROM users";
            MySqlCommand cmd = new MySqlCommand(Query,con);

            MySqlDataReader reader = cmd.ExecuteReader();
           

           
            DataTable dt = new DataTable();

            
            dt.Load(reader);

           
            dataGrid.DataSource = dt;

            
            reader.Close();
            con.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)//Adauga Intrate
        {
            if (SelectedTable == "users")
            { 
                UserForm userForm = new UserForm();
                userForm.ShowDialog();
            }

            if (SelectedTable == "programe")
            {
               AddPrograma addPrograma = new AddPrograma();
                addPrograma.ShowDialog();
       
            }

            if (SelectedTable == "materii")
            {
                AddMateriiForm addMateriiForm = new AddMateriiForm();
                addMateriiForm.ShowDialog();
            }

            if (SelectedTable == "studenti")
            {
                AddStudentForm addStudentForm = new AddStudentForm();
                addStudentForm.ShowDialog();
            }
        }

    


    private void toolStripButton4_Click(object sender, EventArgs e)//Sterge intrare
        {
            if (SelectedTable == "users")
            {
                DeleteUserForm deleteUserForm = new DeleteUserForm();
                deleteUserForm.ShowDialog();
            }

            if (SelectedTable == "materii")
            { 
                StergeMaterie stergeMaterie = new StergeMaterie();
                stergeMaterie.ShowDialog(); 
            }

            if (SelectedTable == "programe")
            {
                StergeProgramaForm stergePrograma = new StergeProgramaForm();
                stergePrograma.ShowDialog();
            }

            if (SelectedTable == "studenti")
            {
                StergeStudent stergeStudent = new StergeStudent();
                stergeStudent.ShowDialog();
            }


        }

        private void toolStripButton5_Click(object sender, EventArgs e)//Modifica intrare
        {
            if (SelectedTable == "users")
            {
                ModifyUser modifyUser = new ModifyUser();
                modifyUser.ShowDialog();
            }

            if (SelectedTable == "materii")
            {
                ModificareMaterieForm modificareMaterieForm = new ModificareMaterieForm();
                modificareMaterieForm.ShowDialog();
            }

            if (SelectedTable == "programe")
            {
                ModificaPrograma modificaPrograma = new ModificaPrograma();
                modificaPrograma.ShowDialog();
            }

            if(SelectedTable == "studenti")
            {
                ModificaStudentForm modificaStudentForm = new ModificaStudentForm();
                modificaStudentForm.ShowDialog();
            }

            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void MateriiButton_Click(object sender, EventArgs e)
        {
            SelectedTable = "materii";
            if (Globals.AccesLevel >= 3)
                SelectedTable = "materii";
            else
            {
                MessageBox.Show("Trebuie să fiți administrator (Nivel de acces 3) pentru a modifica aceste date)", "No permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlConnection con = new MySqlConnection("server  = localhost; userid = root; password = ; database = poo");
            con.Open();

            string Query = "SELECT * FROM materii";
            MySqlCommand cmd = new MySqlCommand(Query, con);

            MySqlDataReader reader = cmd.ExecuteReader();
            
            DataTable dt = new DataTable();
            dt.Load(reader);

            
            dataGrid.DataSource = dt;


            reader.Close();
            con.Close();

        }

        private void ProgrameButton_Click(object sender, EventArgs e)
        {
            if (Globals.AccesLevel >= 3)
                SelectedTable = "programe";
            else
            {
                MessageBox.Show("Trebuie să fiți administrator (Nivel de acces 3) pentru a modifica aceste date)", "No permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //SelectedTable = "programe";


            MySqlConnection con = new MySqlConnection("server  = localhost; userid = root; password = ; database = poo");
            con.Open();

            string Query = "SELECT * FROM programe";
            MySqlCommand cmd = new MySqlCommand(Query, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);


            dataGrid.DataSource = dt;


            reader.Close();
            con.Close();
        }

        private void StudentiButton_Click(object sender, EventArgs e)
        {
            if (Globals.AccesLevel >= 2)
                SelectedTable = "studenti";
            else
            {
                MessageBox.Show("Trebuie să fiți secretar (Nivel de acces 2) pentru a modifica aceste date)", "No permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //SelectedTable = "studenti";


            MySqlConnection con = new MySqlConnection("server  = localhost; userid = root; password = ; database = poo");
            con.Open();

            string Query = "SELECT * FROM studenti";
            MySqlCommand cmd = new MySqlCommand(Query, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);


            dataGrid.DataSource = dt;


            reader.Close();
            con.Close();
        }

        private void Catalog_Click(object sender, EventArgs e)
        {
            string connectionString = "server  = localhost; userid = root; password = ; database = poo";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT Nume, Grupa, An_studiu, Program FROM studenti";
                MySqlCommand cmd = new MySqlCommand(query, con);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    using (StreamWriter writer = new StreamWriter("catalog.csv"))
                    {
                        writer.WriteLine("Nume,Grupa,Program,An_studiu_1_Materie1,An_studiu_1_Materie2,An_studiu_1_Materie3,An_studiu_1_Materie4,An_studiu_2_Materie1,An_studiu_2_Materie2,An_studiu_2_Materie3,An_studiu_2_Materie4,An_studiu_3_Materie1,An_studiu_3_Materie2,An_studiu_3_Materie3,An_studiu_3_Materie4,An_studiu_4_Materie1,An_studiu_4_Materie2,An_studiu_4_Materie3,An_studiu_4_Materie4");
                        while (reader.Read())
                        {
                            string nume = reader.GetString(0);
                            string group = reader.GetString(1);
                            string An = reader.GetString(2);
                            string program = reader.GetString(3);
                            writer.WriteLine($"{nume},{group},{program},{An}_Materie1,{An}_Materie2,{An}_Materie3,{An}_Materie4");
                        }
                    }
                }

                con.Close();
            }
        }

    }
}




