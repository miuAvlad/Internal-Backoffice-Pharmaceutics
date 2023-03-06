using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Farmacie_app.Forms
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //update medicamente
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vlad_fac\BD_proiect\Farmacie_app\Database.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Medicament_Farmacie set Stoc=@Stoc,Pret=@Pret,Id_Farmcaie=@Id_Farmcaie where Id_Medicament=@Id_Medicament", con);
            cmd.Parameters.AddWithValue("@Id_Farmcaie", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@Id_Medicament", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Stoc", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Pret", int.Parse(textBox13.Text));
            cmd.ExecuteNonQuery();
           
            MessageBox.Show("Succes update");
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Medicament_Farmacie", con);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);
            dataGridView1.DataSource = dtb1;
            con.Close();


        }

        private void insertA_Click(object sender, EventArgs e)
        {//////////////////
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vlad_fac\BD_proiect\Farmacie_app\Database.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert INTO Angajat(Id_Angajat,Nume,Prenume,CNP,Telefon,Adresa,ID_Farmacie,ID_Depozit,Password,Username) VALUES (@Id_Angajat,@Nume,@Prenume,@CNP,@Telefon,@Adresa,@ID_Farmacie,@ID_Depozit,@Password,@Username)", con);
            cmd.Parameters.AddWithValue("@Id_Angajat", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Nume", textBox1.Text);
            cmd.Parameters.AddWithValue("@Prenume", textBox2.Text);
            cmd.Parameters.AddWithValue("@CNP", textBox4.Text);
            cmd.Parameters.AddWithValue("@Telefon", textBox5.Text);
            cmd.Parameters.AddWithValue("@Adresa", textBox6.Text);
            cmd.Parameters.AddWithValue("@ID_Farmacie", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@ID_Depozit", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Password", textBox11.Text);
            cmd.Parameters.AddWithValue("@Username", textBox9.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succes inserare");
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * From Angajat", con);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);
            dataGridView1.DataSource = dtb1;

        }

        private void Insert_Med_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vlad_fac\BD_proiect\Farmacie_app\Database.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert INTO Medicament_Farmacie(Id_Farmcaie,Id_Medicament,Stoc,Pret) VALUES (@Id_Farmcaie,@Id_Medicament,@Stoc,@Pret)", con);

            cmd.Parameters.AddWithValue("@Id_Farmcaie", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@Id_Medicament", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Stoc", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Pret", int.Parse(textBox13.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succes inserare");
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Medicament_Farmacie", con);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);
            dataGridView1.DataSource = dtb1;
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vlad_fac\BD_proiect\Farmacie_app\Database.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Angajat set Nume=@Nume,Prenume=@Prenume,CNP=@CNP,Telefon=@Telefon,Adresa=@Adresa,ID_Farmacie=@ID_Farmacie,ID_Depozit=@ID_Depozit,Password=@Password,Username=@Username where Id_Angajat=@Id_Angajat ", con);
            cmd.Parameters.AddWithValue("@Id_Angajat", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Nume", textBox1.Text);
            cmd.Parameters.AddWithValue("@Prenume", textBox2.Text);
            cmd.Parameters.AddWithValue("@CNP", textBox4.Text);
            cmd.Parameters.AddWithValue("@Telefon", textBox5.Text);
            cmd.Parameters.AddWithValue("@Adresa", textBox6.Text);
            cmd.Parameters.AddWithValue("@ID_Farmacie", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@ID_Depozit", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Password", textBox11.Text);
            cmd.Parameters.AddWithValue("@Username", textBox9.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succes update");
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Angajat", con);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);
            dataGridView1.DataSource = dtb1;




            //SqlCommand cmd = new SqlCommand("Update Medicament_Farmacie set Stoc=@Stoc,Pret=@Pret,Id_Farmcaie=@Id_Farmcaie where Id_Medicament=@Id_Medicament", con);
        }

        private void Delete_Med_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vlad_fac\BD_proiect\Farmacie_app\Database.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Medicament_Farmacie where  Id_Medicament=@Id_Medicament ", con);
            cmd.Parameters.AddWithValue("@Id_Medicament", int.Parse(textBox10.Text));      
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succes delete");
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Medicament_Farmacie", con);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);
            dataGridView1.DataSource = dtb1;
        }

        private void deleteA_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vlad_fac\BD_proiect\Farmacie_app\Database.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Angajat where  Id_Angajat=@Id_Angajat ", con);
            cmd.Parameters.AddWithValue("@Id_Angajat", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succes delete");
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT *Angajat", con);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);
            dataGridView1.DataSource = dtb1;
        }
    }
}
