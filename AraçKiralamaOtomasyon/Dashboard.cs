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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=C:\Users\etome\Documents\CarRentaldb.mdf;
                                        Integrated Security=True;Connect Timeout=30");
        private void Dashboard_Load(object sender, EventArgs e)
        {
            string car= "select Count(*) from CarTbl";
            SqlDataAdapter sda=new SqlDataAdapter(car,Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            carLbl.Text = dt.Rows[0][0].ToString();

            string customer = "select Count(*) from CustomerTbl";
            SqlDataAdapter sda2 = new SqlDataAdapter(customer, Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            customerLbl.Text = dt2.Rows[0][0].ToString();

            string users = "select Count(*) from UserTbl";
            SqlDataAdapter sda3 = new SqlDataAdapter(users, Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            usersLbl.Text = dt3.Rows[0][0].ToString();
        }

        private void carLbl_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
