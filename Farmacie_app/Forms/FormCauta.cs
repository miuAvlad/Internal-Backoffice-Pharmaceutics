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
    public partial class FormCauta : Form
    {
        public FormCauta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vlad_fac\BD_proiect\Farmacie_app\Database.mdf;Integrated Security=True");
                     
                SqlCommand cmd = new SqlCommand("Select M.Denumire,M.Serie,M.Data_loz from Medicament as M where Id_Mediacment IN(select MD.Id_Medicament from Medicament_Depozit as MD INNER JOIN Medicament_Farmacie as MF ON MF.Id_Medicament = MD.Id_Medicament)", con);
                //cmd.Parameters.AddWithValue("@Id_Depozit", int.Parse(textBox1.Text));
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable table = new DataTable();
                sda.Fill(table);
                dataGridView1.DataSource = table;
                con.Close();         
            con.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vlad_fac\BD_proiect\Farmacie_app\Database.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select* from Medicament_Farmacie as MF inner join Farmacie as F on F.Id_Farmacie = MF.Id_Farmcaie where Pret = (select min (Pret) from Medicament_Farmacie) AND MF.Id_Medicament=@Id_Depozit", con);
            cmd.Parameters.AddWithValue("@Id_Depozit", int.Parse(textBox1.Text));
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable table = new DataTable();
            sda.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
            con.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vlad_fac\BD_proiect\Farmacie_app\Database.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from Medicament where ID_Producator = (select Id_Producator from Producator where Denumire = @Id_Depozit)", con);
            cmd.Parameters.AddWithValue("@Id_Depozit", textBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable table = new DataTable();
            sda.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
            con.Open();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vlad_fac\BD_proiect\Farmacie_app\Database.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from Medicament as M inner join Medicament_Farmacie as MF on MF.Id_Medicament = M.Id_Mediacment where M.Categorie = @Id_Depozit and MF.Pret < @Pret", con);
            cmd.Parameters.AddWithValue("@Id_Depozit", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Pret", int.Parse(textBox3.Text));
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable table = new DataTable();
            sda.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
            con.Open();
        }
    }
}









