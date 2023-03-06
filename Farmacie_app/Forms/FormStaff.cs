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
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vlad_fac\BD_proiect\Farmacie_app\Database.mdf;Integrated Security=True");

            con.Open();
            
                if (textBox1 != null)
                {
                    SqlCommand cmd = new SqlCommand("Select *from Angajat as A INNER JOIN Depozit as D ON D.Id_Depozit= A.ID_Depozit  where D.Id_Depozit=@ID_Depozit", con);
                    cmd.Parameters.AddWithValue("@Id_Depozit", int.Parse(textBox1.Text));
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable table = new DataTable();
                    sda.Fill(table);
                    dataGridView1.DataSource = table;
                    con.Close();

                }         
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vlad_fac\BD_proiect\Farmacie_app\Database.mdf;Integrated Security=True");

            con.Open();

            if (textBox2 != null)
            {
                SqlCommand cmd = new SqlCommand("Select *from Angajat as A INNER JOIN Farmacie as F ON F.Id_Farmacie= A.ID_Farmacie where F.Id_Farmacie=@Id_Farmacie", con);
                cmd.Parameters.AddWithValue("@Id_Farmacie", int.Parse(textBox2.Text));
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable table = new DataTable();
                sda.Fill(table);
                dataGridView1.DataSource = table;
                con.Close();

            }

        }
    }
}
