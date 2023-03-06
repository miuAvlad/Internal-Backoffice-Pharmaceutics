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
    public partial class FormMedicamente : Form
    {
        public FormMedicamente()
        {
            InitializeComponent();
        }

        private void Depozit_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //////////// de scris
            ///
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vlad_fac\BD_proiect\Farmacie_app\Database.mdf;Integrated Security=True");
            con.Open();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vlad_fac\BD_proiect\Farmacie_app\Database.mdf;Integrated Security=True");


            if (textBox1 != null)
            {
                SqlCommand cmd = new SqlCommand("Select *from Medicament as M INNER JOIN Medicament_Depozit as MD ON MD.Id_Medicament= M.Id_Mediacment  where M.Id_Mediacment=@ID_Depozit", con);
                cmd.Parameters.AddWithValue("@Id_Depozit", int.Parse(textBox1.Text));
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable table = new DataTable();
                sda.Fill(table);
                dataGridView1.DataSource = table;
                con.Close();

            }


            con.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vlad_fac\BD_proiect\Farmacie_app\Database.mdf;Integrated Security=True");


            if (textBox1 != null)
            {
                SqlCommand cmd = new SqlCommand("Select *from Medicament as M INNER JOIN Medicament_Farmacie as MF ON MF.Id_Medicament= M.Id_Mediacment  where M.Id_Mediacment=@ID_Depozit", con);
                cmd.Parameters.AddWithValue("@Id_Depozit", int.Parse(textBox2.Text));
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable table = new DataTable();
                sda.Fill(table);
                dataGridView1.DataSource = table;
                con.Close();

            }


            con.Open();
        }
    }
}
