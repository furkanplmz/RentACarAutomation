using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçKiralamaOtomasyon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=C:\Users\etome\Documents\CarRentaldb.mdf;
                                        Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userNameTxt.Text == "" || userPasswordTxt.Text == "")
            {
                MessageBox.Show("Boş Alan Girdiniz");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from UserTbl Where Username='" + userNameTxt.Text + "'and Userpass='" + userPasswordTxt.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Yanlış Şifre");
                }
                Con.Close();
            }
        }
    }
}
