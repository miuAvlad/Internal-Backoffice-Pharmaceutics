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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vlad_fac\BD_proiect\Farmacie_app\Database.mdf;Integrated Security=True");
        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

            String Password_login;
            byte ID_login = 255;
            Boolean ID_err = false;
            try
            {
                ID_login = byte.Parse(ID_textbox.Text);
            }
            catch
            {
                MessageBox.Show("Stupid monkey, the ID is integer");
                ID_err = true;
                Password_textbox.Clear();
                ID_textbox.Clear();
                ID_textbox.Focus();

            }
            Password_login = Password_textbox.Text;
            if (!ID_err)
            {
                try
                {
                    con.Open();
                    String querry = "SELECT * FROM ANGAJAT WHERE Id_Angajat='" + ID_login + "' AND Password='" + Password_login + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                    DataTable table = new DataTable();
                    sda.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        interfata2 form1 = new interfata2();
                        form1.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Invalid ID or Password");
                        Password_textbox.Clear();
                        ID_textbox.Clear();
                        ID_textbox.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Runtime error");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void ID_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            ID_textbox.Clear();
            Password_textbox.Clear();
            ID_textbox.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
}
