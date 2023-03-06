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

namespace Farmacie_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vlad_fac\BD_proiect\Farmacie_app\Database.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert INTO Depozit(Id_Depozit,Stoc) VALUES (@Id_Depozit,@Stoc)", con);
            cmd.Parameters.AddWithValue("@Id_Depozit", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Stoc", int.Parse(textBox2.Text));           
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succes inserare");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit()
;        }

       
    }
}
