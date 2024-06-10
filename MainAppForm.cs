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
            SelectedTable = "users";

            MySqlConnection con = new MySqlConnection("server  = localhost; userid = root; password = ; database = poo");
            con.Open();

            string Query = "SELECT * FROM users";
            MySqlCommand cmd = new MySqlCommand(Query,con);

            MySqlDataReader reader = cmd.ExecuteReader();
            //insert here

            // Create a new DataTable.
            DataTable dt = new DataTable();

            // Load the data from the reader into the DataTable.
            dt.Load(reader);

            // Bind the DataTable to the DataGridView.
            dataGrid.DataSource = dt;

            // Close the reader and the connection.
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

            if (SelectedTable == "materii")
            { 
                AddMateriiForm addMateriiForm = new AddMateriiForm();
                addMateriiForm.ShowDialog();
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
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void MateriiButton_Click(object sender, EventArgs e)
        {
            SelectedTable = "materii";


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
    }
}
