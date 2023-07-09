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

namespace AraçKiralamaOtomasyon
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            showUsers();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=C:\Users\etome\Documents\CarRentaldb.mdf;
                                        Integrated Security=True;Connect Timeout=30");
        private void showUsers()
        {
            Con.Open();
            string query = "Select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserdataGrid.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (UserNameTxt.Text == "" || UserPassTxt.Text == "")
            {
                MessageBox.Show("Boş Alan Girdiniz");
            }
            else
            {
                try 
                {
                    Con.Open();
                    SqlCommand query = new SqlCommand("insert into UserTbl(Username,Userpass) values(@UN,@UP)", Con);
                    query.Parameters.AddWithValue("@UN", UserNameTxt.Text);
                    query.Parameters.AddWithValue("@UP", UserPassTxt.Text);
                    query.ExecuteNonQuery();
                    MessageBox.Show("Kaydedildi");
                    Con.Close();
                    showUsers();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
           
        }
        private void deleteUser_Click(object sender, EventArgs e)
        {
            if (UserNameTxt.Text=="") {
                MessageBox.Show("Boş Alan Girdiniz");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from UserTbl Where Username=@UserName", Con);
                    cmd.Parameters.AddWithValue("@Username", UserNameTxt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Silindi");
                    Con.Close();
                    showUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
            }
        }

        private void UserdataGrid_DoubleClick(object sender, EventArgs e)
        {
        }
        private void UserdataGrid_Click(object sender, EventArgs e)
        {
           
            UserNameTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Username").ToString();
            UserPassTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Userpass").ToString();
            Key= Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id"));
        }
        int Key = 0;
        private void updateUser_Click(object sender, EventArgs e)
        {
            if (UserNameTxt.Text == "" || UserPassTxt.Text == "")
            {
                MessageBox.Show("Boş Alan Girdiniz");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update UserTbl Set Username=@UN,Userpass=@UP " +
                        "where Id=@Id", Con);
                    cmd.Parameters.AddWithValue("@UN", UserNameTxt.Text);
                    cmd.Parameters.AddWithValue("@UP", UserPassTxt.Text);
                    cmd.Parameters.AddWithValue("@Id", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Güncellendi.");
                    Con.Close();
                    showUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainform=new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform=new MainForm();
            mainform.Show();
        }
    }
}
